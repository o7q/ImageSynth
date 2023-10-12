namespace ImageSynth
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.InputPictureBox = new System.Windows.Forms.PictureBox();
            this.OutputPictureBox = new System.Windows.Forms.PictureBox();
            this.ResetDrawingButton = new System.Windows.Forms.Button();
            this.UpdateDatasetButton = new System.Windows.Forms.Button();
            this.DatasetNameTextBox = new System.Windows.Forms.TextBox();
            this.DatasetPictureBox = new System.Windows.Forms.PictureBox();
            this.LoadDatasetButton = new System.Windows.Forms.Button();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.DrawingColorButton = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.GlobalScaleTextBox = new System.Windows.Forms.TextBox();
            this.GenerateDatasetButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SaveDatasetImageButton = new System.Windows.Forms.Button();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.VisualizeLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.BrushSizeLabel = new System.Windows.Forms.Label();
            this.BrushSizeTextBox = new System.Windows.Forms.TextBox();
            this.DatasetNamePanel = new System.Windows.Forms.Panel();
            this.SizePreviewLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GeneratedPictureBox = new System.Windows.Forms.PictureBox();
            this.GenerateImageButton = new System.Windows.Forms.Button();
            this.SynthesizePanel = new System.Windows.Forms.Panel();
            this.FPSLabel = new System.Windows.Forms.Label();
            this.GenerateVideoButton = new System.Windows.Forms.Button();
            this.VideoFPSTextBox = new System.Windows.Forms.TextBox();
            this.SynthesizeLabel = new System.Windows.Forms.Label();
            this.SaveGeneratedImageButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SynthesizeProgressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPictureBox)).BeginInit();
            this.TitleBarPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.DatasetNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedPictureBox)).BeginInit();
            this.SynthesizePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPictureBox
            // 
            this.InputPictureBox.BackColor = System.Drawing.Color.Black;
            this.InputPictureBox.Location = new System.Drawing.Point(11, 28);
            this.InputPictureBox.Name = "InputPictureBox";
            this.InputPictureBox.Size = new System.Drawing.Size(256, 256);
            this.InputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InputPictureBox.TabIndex = 0;
            this.InputPictureBox.TabStop = false;
            this.InputPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InputPictureBox_MouseMove);
            // 
            // OutputPictureBox
            // 
            this.OutputPictureBox.BackColor = System.Drawing.Color.Black;
            this.OutputPictureBox.Location = new System.Drawing.Point(279, 28);
            this.OutputPictureBox.Name = "OutputPictureBox";
            this.OutputPictureBox.Size = new System.Drawing.Size(256, 256);
            this.OutputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OutputPictureBox.TabIndex = 0;
            this.OutputPictureBox.TabStop = false;
            // 
            // ResetDrawingButton
            // 
            this.ResetDrawingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ResetDrawingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ResetDrawingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetDrawingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ResetDrawingButton.Location = new System.Drawing.Point(181, 284);
            this.ResetDrawingButton.Name = "ResetDrawingButton";
            this.ResetDrawingButton.Size = new System.Drawing.Size(86, 36);
            this.ResetDrawingButton.TabIndex = 0;
            this.ResetDrawingButton.Text = "Reset Canvas";
            this.ResetDrawingButton.UseVisualStyleBackColor = false;
            this.ResetDrawingButton.Click += new System.EventHandler(this.ResetDrawingButton_Click);
            // 
            // UpdateDatasetButton
            // 
            this.UpdateDatasetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.UpdateDatasetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.UpdateDatasetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDatasetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(200)))));
            this.UpdateDatasetButton.Location = new System.Drawing.Point(279, 284);
            this.UpdateDatasetButton.Name = "UpdateDatasetButton";
            this.UpdateDatasetButton.Size = new System.Drawing.Size(36, 36);
            this.UpdateDatasetButton.TabIndex = 0;
            this.UpdateDatasetButton.Text = "Add";
            this.UpdateDatasetButton.UseVisualStyleBackColor = false;
            this.UpdateDatasetButton.Click += new System.EventHandler(this.UpdateDatasetButton_Click);
            // 
            // DatasetNameTextBox
            // 
            this.DatasetNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DatasetNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatasetNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatasetNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.DatasetNameTextBox.Location = new System.Drawing.Point(11, 34);
            this.DatasetNameTextBox.Name = "DatasetNameTextBox";
            this.DatasetNameTextBox.Size = new System.Drawing.Size(268, 26);
            this.DatasetNameTextBox.TabIndex = 0;
            this.DatasetNameTextBox.TextChanged += new System.EventHandler(this.DatasetNameTextBox_TextChanged);
            // 
            // DatasetPictureBox
            // 
            this.DatasetPictureBox.BackColor = System.Drawing.Color.Black;
            this.DatasetPictureBox.Location = new System.Drawing.Point(547, 28);
            this.DatasetPictureBox.Name = "DatasetPictureBox";
            this.DatasetPictureBox.Size = new System.Drawing.Size(256, 256);
            this.DatasetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DatasetPictureBox.TabIndex = 0;
            this.DatasetPictureBox.TabStop = false;
            // 
            // LoadDatasetButton
            // 
            this.LoadDatasetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.LoadDatasetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.LoadDatasetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadDatasetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(205)))));
            this.LoadDatasetButton.Location = new System.Drawing.Point(547, 284);
            this.LoadDatasetButton.Name = "LoadDatasetButton";
            this.LoadDatasetButton.Size = new System.Drawing.Size(128, 36);
            this.LoadDatasetButton.TabIndex = 0;
            this.LoadDatasetButton.Text = "Refresh";
            this.LoadDatasetButton.UseVisualStyleBackColor = false;
            this.LoadDatasetButton.Click += new System.EventHandler(this.LoadDatasetButton_Click);
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.AnalyzeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.AnalyzeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyzeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(205)))));
            this.AnalyzeButton.Location = new System.Drawing.Point(479, 284);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(56, 36);
            this.AnalyzeButton.TabIndex = 0;
            this.AnalyzeButton.Text = "Analyze";
            this.AnalyzeButton.UseVisualStyleBackColor = false;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // DrawingColorButton
            // 
            this.DrawingColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.DrawingColorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.DrawingColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawingColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawingColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(205)))));
            this.DrawingColorButton.Location = new System.Drawing.Point(11, 284);
            this.DrawingColorButton.Name = "DrawingColorButton";
            this.DrawingColorButton.Size = new System.Drawing.Size(85, 18);
            this.DrawingColorButton.TabIndex = 0;
            this.DrawingColorButton.Text = "Brush Color";
            this.DrawingColorButton.UseVisualStyleBackColor = false;
            this.DrawingColorButton.Click += new System.EventHandler(this.DrawingColorButton_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.LoadImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.LoadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(200)))));
            this.LoadImageButton.Location = new System.Drawing.Point(96, 284);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(85, 36);
            this.LoadImageButton.TabIndex = 0;
            this.LoadImageButton.Text = "Load Image";
            this.LoadImageButton.UseVisualStyleBackColor = false;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // GlobalScaleTextBox
            // 
            this.GlobalScaleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.GlobalScaleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GlobalScaleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GlobalScaleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.GlobalScaleTextBox.Location = new System.Drawing.Point(279, 34);
            this.GlobalScaleTextBox.Name = "GlobalScaleTextBox";
            this.GlobalScaleTextBox.Size = new System.Drawing.Size(63, 26);
            this.GlobalScaleTextBox.TabIndex = 0;
            this.GlobalScaleTextBox.Text = "64";
            this.GlobalScaleTextBox.TextChanged += new System.EventHandler(this.GlobalScaleTextBox_TextChanged);
            // 
            // GenerateDatasetButton
            // 
            this.GenerateDatasetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.GenerateDatasetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.GenerateDatasetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateDatasetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(200)))));
            this.GenerateDatasetButton.Location = new System.Drawing.Point(315, 284);
            this.GenerateDatasetButton.Name = "GenerateDatasetButton";
            this.GenerateDatasetButton.Size = new System.Drawing.Size(164, 36);
            this.GenerateDatasetButton.TabIndex = 0;
            this.GenerateDatasetButton.Text = "Generate Dataset From Images";
            this.GenerateDatasetButton.UseVisualStyleBackColor = false;
            this.GenerateDatasetButton.Click += new System.EventHandler(this.GenerateDatasetButton_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.ProgressLabel.Location = new System.Drawing.Point(314, 320);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(52, 13);
            this.ProgressLabel.TabIndex = 0;
            this.ProgressLabel.Text = "Waiting...";
            // 
            // SaveDatasetImageButton
            // 
            this.SaveDatasetImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.SaveDatasetImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.SaveDatasetImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDatasetImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(200)))));
            this.SaveDatasetImageButton.Location = new System.Drawing.Point(675, 284);
            this.SaveDatasetImageButton.Name = "SaveDatasetImageButton";
            this.SaveDatasetImageButton.Size = new System.Drawing.Size(128, 36);
            this.SaveDatasetImageButton.TabIndex = 0;
            this.SaveDatasetImageButton.Text = "Save";
            this.SaveDatasetImageButton.UseVisualStyleBackColor = false;
            this.SaveDatasetImageButton.Click += new System.EventHandler(this.SaveDatasetImageButton_Click);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TitleBarPanel.Controls.Add(this.TitleLabel);
            this.TitleBarPanel.Controls.Add(this.MinimizeButton);
            this.TitleBarPanel.Controls.Add(this.CloseButton);
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(1122, 26);
            this.TitleBarPanel.TabIndex = 0;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MinimizeButton.Location = new System.Drawing.Point(1070, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(26, 26);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CloseButton.Location = new System.Drawing.Point(1096, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 26);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MainPanel.Controls.Add(this.AnalyzeButton);
            this.MainPanel.Controls.Add(this.PreviewLabel);
            this.MainPanel.Controls.Add(this.VisualizeLabel);
            this.MainPanel.Controls.Add(this.InputLabel);
            this.MainPanel.Controls.Add(this.BrushSizeLabel);
            this.MainPanel.Controls.Add(this.BrushSizeTextBox);
            this.MainPanel.Controls.Add(this.InputPictureBox);
            this.MainPanel.Controls.Add(this.DrawingColorButton);
            this.MainPanel.Controls.Add(this.ProgressLabel);
            this.MainPanel.Controls.Add(this.SaveDatasetImageButton);
            this.MainPanel.Controls.Add(this.ResetDrawingButton);
            this.MainPanel.Controls.Add(this.LoadImageButton);
            this.MainPanel.Controls.Add(this.GenerateDatasetButton);
            this.MainPanel.Controls.Add(this.OutputPictureBox);
            this.MainPanel.Controls.Add(this.UpdateDatasetButton);
            this.MainPanel.Controls.Add(this.LoadDatasetButton);
            this.MainPanel.Controls.Add(this.DatasetPictureBox);
            this.MainPanel.Location = new System.Drawing.Point(10, 117);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(815, 344);
            this.MainPanel.TabIndex = 0;
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PreviewLabel.Location = new System.Drawing.Point(275, 8);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(63, 20);
            this.PreviewLabel.TabIndex = 0;
            this.PreviewLabel.Text = "Preview";
            // 
            // VisualizeLabel
            // 
            this.VisualizeLabel.AutoSize = true;
            this.VisualizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.VisualizeLabel.Location = new System.Drawing.Point(545, 8);
            this.VisualizeLabel.Name = "VisualizeLabel";
            this.VisualizeLabel.Size = new System.Drawing.Size(72, 20);
            this.VisualizeLabel.TabIndex = 0;
            this.VisualizeLabel.Text = "Visualize";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.InputLabel.Location = new System.Drawing.Point(8, 7);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(46, 20);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input";
            // 
            // BrushSizeLabel
            // 
            this.BrushSizeLabel.AutoSize = true;
            this.BrushSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(205)))));
            this.BrushSizeLabel.Location = new System.Drawing.Point(9, 304);
            this.BrushSizeLabel.Name = "BrushSizeLabel";
            this.BrushSizeLabel.Size = new System.Drawing.Size(30, 13);
            this.BrushSizeLabel.TabIndex = 0;
            this.BrushSizeLabel.Text = "Size:";
            // 
            // BrushSizeTextBox
            // 
            this.BrushSizeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.BrushSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrushSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrushSizeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(205)))));
            this.BrushSizeTextBox.Location = new System.Drawing.Point(39, 302);
            this.BrushSizeTextBox.Name = "BrushSizeTextBox";
            this.BrushSizeTextBox.Size = new System.Drawing.Size(57, 18);
            this.BrushSizeTextBox.TabIndex = 0;
            this.BrushSizeTextBox.Text = "10";
            // 
            // DatasetNamePanel
            // 
            this.DatasetNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DatasetNamePanel.Controls.Add(this.SizePreviewLabel);
            this.DatasetNamePanel.Controls.Add(this.SizeLabel);
            this.DatasetNamePanel.Controls.Add(this.NameLabel);
            this.DatasetNamePanel.Controls.Add(this.DatasetNameTextBox);
            this.DatasetNamePanel.Controls.Add(this.GlobalScaleTextBox);
            this.DatasetNamePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.DatasetNamePanel.Location = new System.Drawing.Point(10, 36);
            this.DatasetNamePanel.Name = "DatasetNamePanel";
            this.DatasetNamePanel.Size = new System.Drawing.Size(1102, 71);
            this.DatasetNamePanel.TabIndex = 0;
            // 
            // SizePreviewLabel
            // 
            this.SizePreviewLabel.AutoSize = true;
            this.SizePreviewLabel.Location = new System.Drawing.Point(345, 40);
            this.SizePreviewLabel.Name = "SizePreviewLabel";
            this.SizePreviewLabel.Size = new System.Drawing.Size(69, 13);
            this.SizePreviewLabel.TabIndex = 0;
            this.SizePreviewLabel.Text = "64x64 (4096)";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SizeLabel.Location = new System.Drawing.Point(275, 9);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(54, 25);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NameLabel.Location = new System.Drawing.Point(6, 7);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // GeneratedPictureBox
            // 
            this.GeneratedPictureBox.BackColor = System.Drawing.Color.Black;
            this.GeneratedPictureBox.Location = new System.Drawing.Point(12, 28);
            this.GeneratedPictureBox.Name = "GeneratedPictureBox";
            this.GeneratedPictureBox.Size = new System.Drawing.Size(256, 256);
            this.GeneratedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeneratedPictureBox.TabIndex = 0;
            this.GeneratedPictureBox.TabStop = false;
            // 
            // GenerateImageButton
            // 
            this.GenerateImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.GenerateImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.GenerateImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(200)))));
            this.GenerateImageButton.Location = new System.Drawing.Point(12, 284);
            this.GenerateImageButton.Name = "GenerateImageButton";
            this.GenerateImageButton.Size = new System.Drawing.Size(64, 36);
            this.GenerateImageButton.TabIndex = 0;
            this.GenerateImageButton.Text = "Input ->";
            this.GenerateImageButton.UseVisualStyleBackColor = false;
            this.GenerateImageButton.Click += new System.EventHandler(this.GenerateImageButton_Click);
            // 
            // SynthesizePanel
            // 
            this.SynthesizePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SynthesizePanel.Controls.Add(this.SynthesizeProgressLabel);
            this.SynthesizePanel.Controls.Add(this.FPSLabel);
            this.SynthesizePanel.Controls.Add(this.GenerateVideoButton);
            this.SynthesizePanel.Controls.Add(this.VideoFPSTextBox);
            this.SynthesizePanel.Controls.Add(this.SynthesizeLabel);
            this.SynthesizePanel.Controls.Add(this.SaveGeneratedImageButton);
            this.SynthesizePanel.Controls.Add(this.GenerateImageButton);
            this.SynthesizePanel.Controls.Add(this.GeneratedPictureBox);
            this.SynthesizePanel.Location = new System.Drawing.Point(835, 117);
            this.SynthesizePanel.Name = "SynthesizePanel";
            this.SynthesizePanel.Size = new System.Drawing.Size(277, 344);
            this.SynthesizePanel.TabIndex = 0;
            // 
            // FPSLabel
            // 
            this.FPSLabel.AutoSize = true;
            this.FPSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(200)))));
            this.FPSLabel.Location = new System.Drawing.Point(76, 307);
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(22, 9);
            this.FPSLabel.TabIndex = 1;
            this.FPSLabel.Text = "FPS:";
            // 
            // GenerateVideoButton
            // 
            this.GenerateVideoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.GenerateVideoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.GenerateVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.GenerateVideoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(200)))));
            this.GenerateVideoButton.Location = new System.Drawing.Point(76, 284);
            this.GenerateVideoButton.Name = "GenerateVideoButton";
            this.GenerateVideoButton.Size = new System.Drawing.Size(64, 18);
            this.GenerateVideoButton.TabIndex = 1;
            this.GenerateVideoButton.Text = "Video ->";
            this.GenerateVideoButton.UseVisualStyleBackColor = false;
            this.GenerateVideoButton.Click += new System.EventHandler(this.GenerateVideoButton_Click);
            // 
            // VideoFPSTextBox
            // 
            this.VideoFPSTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.VideoFPSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoFPSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoFPSTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(200)))));
            this.VideoFPSTextBox.Location = new System.Drawing.Point(98, 302);
            this.VideoFPSTextBox.Name = "VideoFPSTextBox";
            this.VideoFPSTextBox.Size = new System.Drawing.Size(42, 18);
            this.VideoFPSTextBox.TabIndex = 2;
            this.VideoFPSTextBox.Text = "10";
            // 
            // SynthesizeLabel
            // 
            this.SynthesizeLabel.AutoSize = true;
            this.SynthesizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SynthesizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SynthesizeLabel.Location = new System.Drawing.Point(9, 8);
            this.SynthesizeLabel.Name = "SynthesizeLabel";
            this.SynthesizeLabel.Size = new System.Drawing.Size(87, 20);
            this.SynthesizeLabel.TabIndex = 0;
            this.SynthesizeLabel.Text = "Synthesize";
            // 
            // SaveGeneratedImageButton
            // 
            this.SaveGeneratedImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.SaveGeneratedImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.SaveGeneratedImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveGeneratedImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(200)))));
            this.SaveGeneratedImageButton.Location = new System.Drawing.Point(140, 284);
            this.SaveGeneratedImageButton.Name = "SaveGeneratedImageButton";
            this.SaveGeneratedImageButton.Size = new System.Drawing.Size(128, 36);
            this.SaveGeneratedImageButton.TabIndex = 0;
            this.SaveGeneratedImageButton.Text = "Save";
            this.SaveGeneratedImageButton.UseVisualStyleBackColor = false;
            this.SaveGeneratedImageButton.Click += new System.EventHandler(this.SaveGeneratedImageButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.TitleLabel.Location = new System.Drawing.Point(8, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(88, 16);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "ImageSynth";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // SynthesizeProgressLabel
            // 
            this.SynthesizeProgressLabel.AutoSize = true;
            this.SynthesizeProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.SynthesizeProgressLabel.Location = new System.Drawing.Point(74, 320);
            this.SynthesizeProgressLabel.Name = "SynthesizeProgressLabel";
            this.SynthesizeProgressLabel.Size = new System.Drawing.Size(52, 13);
            this.SynthesizeProgressLabel.TabIndex = 1;
            this.SynthesizeProgressLabel.Text = "Waiting...";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1122, 471);
            this.Controls.Add(this.SynthesizePanel);
            this.Controls.Add(this.DatasetNamePanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "ImageSynth";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetPictureBox)).EndInit();
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.DatasetNamePanel.ResumeLayout(false);
            this.DatasetNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedPictureBox)).EndInit();
            this.SynthesizePanel.ResumeLayout(false);
            this.SynthesizePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox InputPictureBox;
        private System.Windows.Forms.PictureBox OutputPictureBox;
        private System.Windows.Forms.Button ResetDrawingButton;
        private System.Windows.Forms.Button UpdateDatasetButton;
        private System.Windows.Forms.TextBox DatasetNameTextBox;
        private System.Windows.Forms.PictureBox DatasetPictureBox;
        private System.Windows.Forms.Button LoadDatasetButton;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.Button DrawingColorButton;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.TextBox GlobalScaleTextBox;
        private System.Windows.Forms.Button GenerateDatasetButton;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Button SaveDatasetImageButton;
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel DatasetNamePanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox BrushSizeTextBox;
        private System.Windows.Forms.Label BrushSizeLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label VisualizeLabel;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label SizePreviewLabel;
        private System.Windows.Forms.PictureBox GeneratedPictureBox;
        private System.Windows.Forms.Button GenerateImageButton;
        private System.Windows.Forms.Panel SynthesizePanel;
        private System.Windows.Forms.Button SaveGeneratedImageButton;
        private System.Windows.Forms.Label SynthesizeLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button GenerateVideoButton;
        private System.Windows.Forms.Label FPSLabel;
        private System.Windows.Forms.TextBox VideoFPSTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SynthesizeProgressLabel;
    }
}

