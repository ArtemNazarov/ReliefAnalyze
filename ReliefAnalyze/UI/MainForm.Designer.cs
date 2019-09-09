namespace ReliefAnalyze
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.fragmentControursButton = new System.Windows.Forms.Button();
            this.contoursButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.opencvbutton = new System.Windows.Forms.Button();
            this.detectColors = new System.Windows.Forms.Button();
            this.analyzeImagebutton = new System.Windows.Forms.Button();
            this.fragmentColorsButton = new System.Windows.Forms.Button();
            this.chooseMainColorsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scaleBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FragmentFindContours = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.дополнительноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1286, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.exitMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(150, 26);
            this.openFileMenuItem.Text = "Открыть";
            this.openFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(150, 26);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // дополнительноToolStripMenuItem
            // 
            this.дополнительноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramMenuItem});
            this.дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            this.дополнительноToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.дополнительноToolStripMenuItem.Text = "Дополнительно";
            // 
            // histogramMenuItem
            // 
            this.histogramMenuItem.Name = "histogramMenuItem";
            this.histogramMenuItem.Size = new System.Drawing.Size(183, 26);
            this.histogramMenuItem.Text = "Гистограмма";
            this.histogramMenuItem.Click += new System.EventHandler(this.HistogramMenuItem_Click);
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(88, 57);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 2;
            this.analyzeButton.Text = "Анализ";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // fragmentControursButton
            // 
            this.fragmentControursButton.Location = new System.Drawing.Point(168, 57);
            this.fragmentControursButton.Margin = new System.Windows.Forms.Padding(2);
            this.fragmentControursButton.Name = "fragmentControursButton";
            this.fragmentControursButton.Size = new System.Drawing.Size(118, 23);
            this.fragmentControursButton.TabIndex = 3;
            this.fragmentControursButton.Text = "Контуры фрагмента";
            this.fragmentControursButton.UseVisualStyleBackColor = true;
            this.fragmentControursButton.Click += new System.EventHandler(this.FragmentControursButton_Click);
            // 
            // contoursButton
            // 
            this.contoursButton.Location = new System.Drawing.Point(312, 57);
            this.contoursButton.Margin = new System.Windows.Forms.Padding(2);
            this.contoursButton.Name = "contoursButton";
            this.contoursButton.Size = new System.Drawing.Size(103, 23);
            this.contoursButton.TabIndex = 4;
            this.contoursButton.Text = "Контуры";
            this.contoursButton.UseVisualStyleBackColor = true;
            this.contoursButton.Click += new System.EventHandler(this.ContoursButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.mainPictureBox);
            this.panel1.Location = new System.Drawing.Point(88, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 507);
            this.panel1.TabIndex = 5;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(800, 400);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseDown);
            // 
            // opencvbutton
            // 
            this.opencvbutton.Location = new System.Drawing.Point(949, 28);
            this.opencvbutton.Name = "opencvbutton";
            this.opencvbutton.Size = new System.Drawing.Size(119, 23);
            this.opencvbutton.TabIndex = 7;
            this.opencvbutton.Text = "findcontours";
            this.opencvbutton.UseVisualStyleBackColor = true;
            this.opencvbutton.Click += new System.EventHandler(this.Opencvbutton_Click);
            // 
            // detectColors
            // 
            this.detectColors.Location = new System.Drawing.Point(890, 57);
            this.detectColors.Name = "detectColors";
            this.detectColors.Size = new System.Drawing.Size(139, 23);
            this.detectColors.TabIndex = 9;
            this.detectColors.Text = "определить цвета";
            this.detectColors.UseVisualStyleBackColor = true;
            this.detectColors.Click += new System.EventHandler(this.DetectColors_Click);
            // 
            // analyzeImagebutton
            // 
            this.analyzeImagebutton.Location = new System.Drawing.Point(573, 31);
            this.analyzeImagebutton.Name = "analyzeImagebutton";
            this.analyzeImagebutton.Size = new System.Drawing.Size(137, 49);
            this.analyzeImagebutton.TabIndex = 10;
            this.analyzeImagebutton.Text = "Анализ цветовых объектов";
            this.analyzeImagebutton.UseVisualStyleBackColor = true;
            this.analyzeImagebutton.Click += new System.EventHandler(this.FindColorbutton_Click);
            // 
            // fragmentColorsButton
            // 
            this.fragmentColorsButton.Location = new System.Drawing.Point(420, 56);
            this.fragmentColorsButton.Name = "fragmentColorsButton";
            this.fragmentColorsButton.Size = new System.Drawing.Size(147, 23);
            this.fragmentColorsButton.TabIndex = 11;
            this.fragmentColorsButton.Text = "Контуры фргамента";
            this.fragmentColorsButton.UseVisualStyleBackColor = true;
            this.fragmentColorsButton.Click += new System.EventHandler(this.FragmentColorsButton_Click);
            // 
            // chooseMainColorsButton
            // 
            this.chooseMainColorsButton.Location = new System.Drawing.Point(312, 27);
            this.chooseMainColorsButton.Name = "chooseMainColorsButton";
            this.chooseMainColorsButton.Size = new System.Drawing.Size(183, 23);
            this.chooseMainColorsButton.TabIndex = 12;
            this.chooseMainColorsButton.Text = "Выбрать главные цвета";
            this.chooseMainColorsButton.UseVisualStyleBackColor = true;
            this.chooseMainColorsButton.Click += new System.EventHandler(this.ChooseMainColorsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1035, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Масштаб";
            // 
            // scaleBox
            // 
            this.scaleBox.AllowDrop = true;
            this.scaleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scaleBox.FormattingEnabled = true;
            this.scaleBox.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.scaleBox.Location = new System.Drawing.Point(1111, 58);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(77, 21);
            this.scaleBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1195, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "км / 100 пикс";
            // 
            // FragmentFindContours
            // 
            this.FragmentFindContours.Location = new System.Drawing.Point(716, 52);
            this.FragmentFindContours.Name = "FragmentFindContours";
            this.FragmentFindContours.Size = new System.Drawing.Size(163, 23);
            this.FragmentFindContours.TabIndex = 8;
            this.FragmentFindContours.Text = "Контуры фрагмента";
            this.FragmentFindContours.UseVisualStyleBackColor = true;
            this.FragmentFindContours.Click += new System.EventHandler(this.FragmentFindContours_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 671);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scaleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseMainColorsButton);
            this.Controls.Add(this.fragmentColorsButton);
            this.Controls.Add(this.analyzeImagebutton);
            this.Controls.Add(this.detectColors);
            this.Controls.Add(this.FragmentFindContours);
            this.Controls.Add(this.opencvbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contoursButton);
            this.Controls.Add(this.fragmentControursButton);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Анализ рельефа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.ToolStripMenuItem дополнительноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramMenuItem;
        private System.Windows.Forms.Button fragmentControursButton;
        private System.Windows.Forms.Button contoursButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button opencvbutton;
        private System.Windows.Forms.Button detectColors;
        private System.Windows.Forms.Button analyzeImagebutton;
        private System.Windows.Forms.Button fragmentColorsButton;
        private System.Windows.Forms.Button chooseMainColorsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox scaleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FragmentFindContours;
    }
}

