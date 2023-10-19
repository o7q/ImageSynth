using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading.Tasks;
using static ImageSynth.Files;
using static ImageSynth.Shell;
using static ImageSynth.Datasets.Vision;
using static ImageSynth.Datasets.Compare;
using static ImageSynth.Datasets.Synthesize;
using static ImageSynth.Datasets.Export.Append;
using static ImageSynth.Datasets.Export.Generate;
using static ImageSynth.BitmapTools.Transform;
using SuperfastBlur;

namespace ImageSynth
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        int imageWidth = 64;
        int imageArea = 4096;

        Bitmap scaledBitmap;
        Bitmap drawingBitmap;
        Graphics drawingGraphics;

        Bitmap visualizeBitmap;
        Bitmap synthesizeBitmap;

        private void Menu_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("datasets");
            ClearScreen();
        }

        private void ResetDrawingButton_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void InputPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Brush brush = new SolidBrush(drawColor);
                int brushSize = int.Parse(BrushSizeTextBox.Text);
                drawingGraphics.FillEllipse(brush, e.X - brushSize / 2, e.Y - brushSize / 2, brushSize, brushSize);

                UpdateInputBitmapPreview();
            }
        }

        private void UpdateInputBitmapPreview()
        {
            var upscaledBitmap = RescaleBitmap(drawingBitmap, imageWidth);
            scaledBitmap = upscaledBitmap;

            OutputPictureBox.Image = RescaleBitmap(upscaledBitmap, 256);
            InputPictureBox.Image = drawingBitmap;
        }

        private void UpdateDatasetButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("datasets\\" + DatasetNameTextBox.Text + ".dataset"))
                File.WriteAllText("datasets\\" + DatasetNameTextBox.Text + ".dataset", "");

            AppendDataset(scaledBitmap, "datasets\\" + DatasetNameTextBox.Text + ".dataset", imageWidth);

            ClearScreen();
            DatasetPictureBox.Image = RescaleBitmap(CalculateDatasetVision("datasets\\" + DatasetNameTextBox.Text + ".dataset", imageWidth), 256);
        }

        private void ClearScreen()
        {
            drawingBitmap = new Bitmap(InputPictureBox.Width, InputPictureBox.Height);
            drawingGraphics = Graphics.FromImage(drawingBitmap);
            drawingGraphics.Clear(Color.Black);
            InputPictureBox.Image = drawingBitmap;
        }

        private void LoadDatasetButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("datasets\\" + DatasetNameTextBox.Text + ".dataset"))
                visualizeBitmap = CalculateDatasetVision("datasets\\" + DatasetNameTextBox.Text + ".dataset", imageWidth);
            DatasetPictureBox.Image = RescaleBitmap(visualizeBitmap, 256);
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            var result = CompareDrawingToDatasets(scaledBitmap, "datasets", imageWidth);

            string data = "";
            for (int i = 0; i < result.Item2.Length; i++)
                data += Path.GetFileNameWithoutExtension(result.Item2[i]) + ": " + result.Item3[i] + "%\n";

            MessageBox.Show("Detected Model:\n" + Path.GetFileNameWithoutExtension(result.Item1) + "\n\n" + data);
        }

        Color drawColor = Color.FromArgb(255, 255, 255, 255);
        private void DrawingColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AnyColor = true;

            int r, g, b;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                r = Convert.ToInt32(colorDialog.Color.R);
                g = Convert.ToInt32(colorDialog.Color.G);
                b = Convert.ToInt32(colorDialog.Color.B);

                drawColor = Color.FromArgb(255, r, g, b);
            }
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    Image imageToDraw = Image.FromFile(fileDialog.FileName);
                    g.DrawImage(imageToDraw, new Rectangle(0, 0, 256, 256));
                }

                UpdateInputBitmapPreview();
            }
        }
        private void GenerateDatasetButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog selectFolderDialog = new OpenFileDialog())
            {
                selectFolderDialog.Multiselect = false;
                selectFolderDialog.CheckFileExists = false;
                selectFolderDialog.CheckPathExists = true;
                selectFolderDialog.FileName = "Select a folder";
                selectFolderDialog.Filter = "Directories|Folders";
                selectFolderDialog.ShowDialog();

                string[] filetypes = { ".png", ".jpg", ".jpeg" };

                if (selectFolderDialog.FileName != "" && selectFolderDialog.FileName != "Select a folder")
                    Task.Run(() => GenerateDataset("datasets\\" + DatasetNameTextBox.Text + ".dataset", LoadFiles(Path.GetDirectoryName(selectFolderDialog.FileName), filetypes), imageWidth, ProgressLabel));
            }
        }

        private void GlobalScaleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (GlobalScaleTextBox.Text == "")
                return;

            imageWidth = int.Parse(GlobalScaleTextBox.Text);
            imageArea = imageWidth * imageWidth;

            SizePreviewLabel.Text = imageWidth + "x" + imageWidth + " (" + imageArea + ")";
        }

        private void SaveDatasetImageButton_Click(object sender, EventArgs e)
        {
            visualizeBitmap.Save(DatasetNameTextBox.Text + "_snapshot.png");
        }

        private void GenerateImageButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("datasets\\" + DatasetNameTextBox.Text + ".dataset"))
            {
                var result = InitSynthesizeImage("datasets\\" + DatasetNameTextBox.Text + ".dataset", imageWidth);
                synthesizeBitmap = SynthesizeImage(scaledBitmap, result.Item1, imageWidth, result.Item2);
            }
            GeneratedPictureBox.Image = RescaleBitmap(synthesizeBitmap, 256);
        }

        private void SaveGeneratedImageButton_Click(object sender, EventArgs e)
        {
            synthesizeBitmap.Save(DatasetNameTextBox.Text + "_output.png");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DatasetNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists("datasets\\" + DatasetNameTextBox.Text + ".dataset"))
            {
                string datasetPath = "datasets\\" + DatasetNameTextBox.Text + ".dataset";
                string datasetScale = null;

                using (StreamReader reader = new StreamReader(datasetPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("@"))
                        {
                            datasetScale = line.Substring(0, line.IndexOf('@'));
                            break; // stop reading the file once the line with "@" is found.
                        }
                    }
                }

                GlobalScaleTextBox.Text = datasetScale;
                DatasetNameTextBox.ForeColor = Color.FromArgb(255, 200, 255, 200);
                GlobalScaleTextBox.ForeColor = Color.FromArgb(255, 200, 255, 200);
            }
            else
            {
                DatasetNameTextBox.ForeColor = Color.FromArgb(255, 200, 200, 200);
                GlobalScaleTextBox.ForeColor = Color.FromArgb(255, 200, 200, 200);
            }
        }

        private void GenerateVideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files (*.*)|*.*";

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            SynthesizeProgressLabel.Text = "Initializing...";

            string path = fileDialog.FileName;

            if (Directory.Exists("temp"))
                Directory.Delete("temp", true);

            Directory.CreateDirectory("temp\\input");
            Directory.CreateDirectory("temp\\output");
            StartProcess("ffmpeg.exe", "-i \"" + path + "\" -vf scale=" + imageWidth + ":" + imageWidth + " -r " + VideoFPSTextBox.Text + " \"temp\\input\\%d.png\"", "Generating Image Sequence");

            ProcessBulkImages();
        }

        async void ProcessBulkImages()
        {
            await Task.Run(() => BulkSynthesizeImage(DatasetNameTextBox.Text, imageWidth, GeneratedPictureBox, SynthesizeProgressLabel));
            StartProcess("ffmpeg", "-framerate " + VideoFPSTextBox.Text + " -i \"temp\\output\\%d.png\" -c:v libx264 -r " + VideoFPSTextBox.Text + " -pix_fmt yuv420p -y \"output.mp4\"", "Generating Video");
        }

        // constants for mouse window events
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // import the SendMessage and ReleaseCapture functions from user32.dll
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void GlowButton_Click(object sender, EventArgs e)
        {
            var blur = new GaussianBlur(drawingBitmap);
            Bitmap blurImage = blur.Process(2);

            using (Graphics g = Graphics.FromImage(drawingBitmap))
            {
                g.DrawImage(blurImage, new Rectangle(0, 0, 256, 256));
            }

            UpdateInputBitmapPreview();
        }

        private void GenerateRandomImageButton_Click(object sender, EventArgs e)
        {
            Bitmap noiseImage = new Bitmap(imageWidth, imageWidth);
            int x_index = 0;
            int y_index = 0;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < imageArea * 3; i += 3)
            {
                if (x_index == imageWidth)
                {
                    x_index = 0;
                    y_index++;
                }

                Color pixelColor = Color.FromArgb(255, rnd.Next(256) / rnd.Next(1, 5), rnd.Next(256) / rnd.Next(1, 5), rnd.Next(256) / rnd.Next(1, 5));
                noiseImage.SetPixel(x_index, y_index, pixelColor);

                x_index++;
            }

            using (Graphics g = Graphics.FromImage(drawingBitmap))
            {
                g.DrawImage(noiseImage, new Rectangle(0, 0, 256, 256));
            }

            UpdateInputBitmapPreview();
        }
    }
}