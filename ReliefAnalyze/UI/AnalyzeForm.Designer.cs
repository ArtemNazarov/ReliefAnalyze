namespace ReliefAnalyze
{
    partial class AnalyzeForm
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
            this.closeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.analyzeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pointsGridView = new System.Windows.Forms.DataGridView();
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.fragmentGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fragmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Location = new System.Drawing.Point(745, 558);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = false;
            this.closeButton.Size = new System.Drawing.Size(93, 36);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // analyzeLabel
            // 
            this.analyzeLabel.AutoSize = true;
            this.analyzeLabel.Depth = 0;
            this.analyzeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.analyzeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analyzeLabel.Location = new System.Drawing.Point(61, 366);
            this.analyzeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.analyzeLabel.Name = "analyzeLabel";
            this.analyzeLabel.Size = new System.Drawing.Size(0, 24);
            this.analyzeLabel.TabIndex = 5;
            // 
            // pointsGridView
            // 
            this.pointsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.pointsGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pointsGridView.Location = new System.Drawing.Point(11, 121);
            this.pointsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.pointsGridView.Name = "pointsGridView";
            this.pointsGridView.ReadOnly = true;
            this.pointsGridView.RowHeadersWidth = 51;
            this.pointsGridView.RowTemplate.Height = 24;
            this.pointsGridView.Size = new System.Drawing.Size(1428, 51);
            this.pointsGridView.TabIndex = 6;
            // 
            // Ponds
            // 
            this.Ponds.Frozen = true;
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
            this.Mountains.ReadOnly = true;
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
            this.Culture.ReadOnly = true;
            this.Culture.Width = 125;
            // 
            // Swamp
            // 
            this.Swamp.HeaderText = "Болота";
            this.Swamp.MinimumWidth = 6;
            this.Swamp.Name = "Swamp";
            this.Swamp.ReadOnly = true;
            this.Swamp.Width = 125;
            // 
            // Ice
            // 
            this.Ice.HeaderText = "Лёд";
            this.Ice.MinimumWidth = 6;
            this.Ice.Name = "Ice";
            this.Ice.ReadOnly = true;
            this.Ice.Width = 125;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(257, 24);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Наличие объектов в точках";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 207);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(306, 24);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Наличие объектов во фрагменте";
            // 
            // fragmentGridView
            // 
            this.fragmentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fragmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fragmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.fragmentGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fragmentGridView.Location = new System.Drawing.Point(11, 252);
            this.fragmentGridView.Margin = new System.Windows.Forms.Padding(2);
            this.fragmentGridView.Name = "fragmentGridView";
            this.fragmentGridView.ReadOnly = true;
            this.fragmentGridView.RowHeadersWidth = 51;
            this.fragmentGridView.RowTemplate.Height = 24;
            this.fragmentGridView.Size = new System.Drawing.Size(1428, 47);
            this.fragmentGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Водоёмы";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Реки";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Леса";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Дороги";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Песок";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Возвышенности";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Горы";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Равнина";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Культуры";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Болота";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Лёд";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1543, 636);
            this.Controls.Add(this.fragmentGridView);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pointsGridView);
            this.Controls.Add(this.analyzeLabel);
            this.Controls.Add(this.closeButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnalyzeForm";
            this.Text = "Анализ";
            this.Load += new System.EventHandler(this.AnalyzeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fragmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton closeButton;
        private MaterialSkin.Controls.MaterialLabel analyzeLabel;
        private System.Windows.Forms.DataGridView pointsGridView;
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView fragmentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}