namespace ReliefAnalyze
{
    partial class MainColorsForm
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
            this.colorGridView = new System.Windows.Forms.DataGridView();
            this.Ponds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rivers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mountains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Culture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Swamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.analyzeLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.resetColorsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // colorGridView
            // 
            this.colorGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.colorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ponds,
            this.Rivers,
            this.Forests,
            this.Roads,
            this.Sand,
            this.Hills,
            this.Mountains,
            this.Plain,
            this.Culture,
            this.Swamp,
            this.Ice});
            this.colorGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.colorGridView.Location = new System.Drawing.Point(73, 65);
            this.colorGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorGridView.Name = "colorGridView";
            this.colorGridView.RowHeadersWidth = 51;
            this.colorGridView.RowTemplate.Height = 24;
            this.colorGridView.Size = new System.Drawing.Size(1041, 310);
            this.colorGridView.TabIndex = 0;
            this.colorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColorGridView_CellClick);
            // 
            // Ponds
            // 
            this.Ponds.HeaderText = "Водоёмы";
            this.Ponds.MinimumWidth = 6;
            this.Ponds.Name = "Ponds";
            this.Ponds.ReadOnly = true;
            this.Ponds.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ponds.Width = 125;
            // 
            // Rivers
            // 
            this.Rivers.HeaderText = "Реки";
            this.Rivers.MinimumWidth = 6;
            this.Rivers.Name = "Rivers";
            this.Rivers.ReadOnly = true;
            this.Rivers.Width = 125;
            // 
            // Forests
            // 
            this.Forests.HeaderText = "Леса";
            this.Forests.MinimumWidth = 6;
            this.Forests.Name = "Forests";
            this.Forests.ReadOnly = true;
            this.Forests.Width = 125;
            // 
            // Roads
            // 
            this.Roads.HeaderText = "Дороги";
            this.Roads.MinimumWidth = 6;
            this.Roads.Name = "Roads";
            this.Roads.ReadOnly = true;
            this.Roads.Width = 125;
            // 
            // Sand
            // 
            this.Sand.HeaderText = "Песок";
            this.Sand.MinimumWidth = 6;
            this.Sand.Name = "Sand";
            this.Sand.ReadOnly = true;
            this.Sand.Width = 125;
            // 
            // Hills
            // 
            this.Hills.HeaderText = "Возвышенности";
            this.Hills.MinimumWidth = 6;
            this.Hills.Name = "Hills";
            this.Hills.ReadOnly = true;
            this.Hills.Width = 125;
            // 
            // Mountains
            // 
            this.Mountains.HeaderText = "Горы";
            this.Mountains.MinimumWidth = 6;
            this.Mountains.Name = "Mountains";
            this.Mountains.Width = 125;
            // 
            // Plain
            // 
            this.Plain.HeaderText = "Равнина";
            this.Plain.MinimumWidth = 6;
            this.Plain.Name = "Plain";
            this.Plain.ReadOnly = true;
            this.Plain.Width = 125;
            // 
            // Culture
            // 
            this.Culture.HeaderText = "Культуры";
            this.Culture.MinimumWidth = 6;
            this.Culture.Name = "Culture";
            this.Culture.Width = 125;
            // 
            // Swamp
            // 
            this.Swamp.HeaderText = "Болота";
            this.Swamp.MinimumWidth = 6;
            this.Swamp.Name = "Swamp";
            this.Swamp.Width = 125;
            // 
            // Ice
            // 
            this.Ice.HeaderText = "Лёд";
            this.Ice.MinimumWidth = 6;
            this.Ice.Name = "Ice";
            this.Ice.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главные цвета";
            // 
            // analyzeLabel
            // 
            this.analyzeLabel.AutoSize = true;
            this.analyzeLabel.Location = new System.Drawing.Point(70, 168);
            this.analyzeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.analyzeLabel.Name = "analyzeLabel";
            this.analyzeLabel.Size = new System.Drawing.Size(0, 15);
            this.analyzeLabel.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(427, 429);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 37);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resetColorsButton
            // 
            this.resetColorsButton.Location = new System.Drawing.Point(196, 22);
            this.resetColorsButton.Name = "resetColorsButton";
            this.resetColorsButton.Size = new System.Drawing.Size(132, 23);
            this.resetColorsButton.TabIndex = 4;
            this.resetColorsButton.Text = "Сброс по умолчанию";
            this.resetColorsButton.UseVisualStyleBackColor = true;
            this.resetColorsButton.Click += new System.EventHandler(this.ResetColorsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(356, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(124, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MainColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 509);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetColorsButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.analyzeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainColorsForm";
            this.Text = "Главные цвета для определения";
            this.Load += new System.EventHandler(this.MainColorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView colorGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label analyzeLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button resetColorsButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ponds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roads;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hills;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mountains;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Culture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Swamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ice;
    }
}