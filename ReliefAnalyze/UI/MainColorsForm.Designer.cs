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
            this.label1 = new System.Windows.Forms.Label();
            this.analyzeLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Ponds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rivers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.colorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // colorGridView
            // 
            this.colorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ponds,
            this.Rivers,
            this.Forests,
            this.Roads,
            this.Sand,
            this.Hills,
            this.Plain});
            this.colorGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.colorGridView.Location = new System.Drawing.Point(73, 65);
            this.colorGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorGridView.Name = "colorGridView";
            this.colorGridView.RowTemplate.Height = 24;
            this.colorGridView.Size = new System.Drawing.Size(952, 76);
            this.colorGridView.TabIndex = 0;
            this.colorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColorGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главные цвета";
            // 
            // analyzeLabel
            // 
            this.analyzeLabel.AutoSize = true;
            this.analyzeLabel.Location = new System.Drawing.Point(70, 168);
            this.analyzeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.analyzeLabel.Name = "analyzeLabel";
            this.analyzeLabel.Size = new System.Drawing.Size(0, 13);
            this.analyzeLabel.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(568, 291);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 33);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Ponds
            // 
            this.Ponds.HeaderText = "Водоёмы";
            this.Ponds.Name = "Ponds";
            this.Ponds.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Rivers
            // 
            this.Rivers.HeaderText = "Реки";
            this.Rivers.Name = "Rivers";
            // 
            // Forests
            // 
            this.Forests.HeaderText = "Леса";
            this.Forests.Name = "Forests";
            // 
            // Roads
            // 
            this.Roads.HeaderText = "Дороги";
            this.Roads.Name = "Roads";
            // 
            // Sand
            // 
            this.Sand.HeaderText = "Песок";
            this.Sand.Name = "Sand";
            // 
            // Hills
            // 
            this.Hills.HeaderText = "Горы";
            this.Hills.Name = "Hills";
            // 
            // Plain
            // 
            this.Plain.HeaderText = "Равнина";
            this.Plain.Name = "Plain";
            // 
            // MainColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 372);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.analyzeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainColorsForm";
            this.Text = "AnalyzeForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Ponds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roads;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hills;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plain;
    }
}