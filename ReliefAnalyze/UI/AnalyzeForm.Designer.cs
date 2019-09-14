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
            this.PondsFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiversFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForestsFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoadsFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SandFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HillsFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MountainsFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlainFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CultureFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SwampFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IceFragment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analyzeBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fragmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Location = new System.Drawing.Point(993, 687);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            this.analyzeLabel.Location = new System.Drawing.Point(17, 398);
            this.analyzeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.analyzeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.analyzeLabel.Name = "analyzeLabel";
            this.analyzeLabel.Size = new System.Drawing.Size(184, 24);
            this.analyzeLabel.TabIndex = 5;
            this.analyzeLabel.Text = "Подробный анализ";
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
            this.pointsGridView.Location = new System.Drawing.Point(15, 149);
            this.pointsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pointsGridView.Name = "pointsGridView";
            this.pointsGridView.ReadOnly = true;
            this.pointsGridView.RowHeadersWidth = 51;
            this.pointsGridView.RowTemplate.Height = 24;
            this.pointsGridView.Size = new System.Drawing.Size(1904, 63);
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
            this.materialLabel1.Location = new System.Drawing.Point(17, 102);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.materialLabel2.Location = new System.Drawing.Point(17, 255);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.PondsFragment,
            this.RiversFragment,
            this.ForestsFragment,
            this.RoadsFragment,
            this.SandFragment,
            this.HillsFragment,
            this.MountainsFragment,
            this.PlainFragment,
            this.CultureFragment,
            this.SwampFragment,
            this.IceFragment});
            this.fragmentGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fragmentGridView.Location = new System.Drawing.Point(15, 310);
            this.fragmentGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fragmentGridView.Name = "fragmentGridView";
            this.fragmentGridView.ReadOnly = true;
            this.fragmentGridView.RowHeadersWidth = 51;
            this.fragmentGridView.RowTemplate.Height = 24;
            this.fragmentGridView.Size = new System.Drawing.Size(1904, 58);
            this.fragmentGridView.TabIndex = 9;
            // 
            // PondsFragment
            // 
            this.PondsFragment.Frozen = true;
            this.PondsFragment.HeaderText = "Водоёмы";
            this.PondsFragment.MinimumWidth = 6;
            this.PondsFragment.Name = "PondsFragment";
            this.PondsFragment.ReadOnly = true;
            this.PondsFragment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PondsFragment.Width = 125;
            // 
            // RiversFragment
            // 
            this.RiversFragment.HeaderText = "Реки";
            this.RiversFragment.MinimumWidth = 6;
            this.RiversFragment.Name = "RiversFragment";
            this.RiversFragment.ReadOnly = true;
            this.RiversFragment.Width = 125;
            // 
            // ForestsFragment
            // 
            this.ForestsFragment.HeaderText = "Леса";
            this.ForestsFragment.MinimumWidth = 6;
            this.ForestsFragment.Name = "ForestsFragment";
            this.ForestsFragment.ReadOnly = true;
            this.ForestsFragment.Width = 125;
            // 
            // RoadsFragment
            // 
            this.RoadsFragment.HeaderText = "Дороги";
            this.RoadsFragment.MinimumWidth = 6;
            this.RoadsFragment.Name = "RoadsFragment";
            this.RoadsFragment.ReadOnly = true;
            this.RoadsFragment.Width = 125;
            // 
            // SandFragment
            // 
            this.SandFragment.HeaderText = "Песок";
            this.SandFragment.MinimumWidth = 6;
            this.SandFragment.Name = "SandFragment";
            this.SandFragment.ReadOnly = true;
            this.SandFragment.Width = 125;
            // 
            // HillsFragment
            // 
            this.HillsFragment.HeaderText = "Возвышенности";
            this.HillsFragment.MinimumWidth = 6;
            this.HillsFragment.Name = "HillsFragment";
            this.HillsFragment.ReadOnly = true;
            this.HillsFragment.Width = 125;
            // 
            // MountainsFragment
            // 
            this.MountainsFragment.HeaderText = "Горы";
            this.MountainsFragment.MinimumWidth = 6;
            this.MountainsFragment.Name = "MountainsFragment";
            this.MountainsFragment.ReadOnly = true;
            this.MountainsFragment.Width = 125;
            // 
            // PlainFragment
            // 
            this.PlainFragment.HeaderText = "Равнина";
            this.PlainFragment.MinimumWidth = 6;
            this.PlainFragment.Name = "PlainFragment";
            this.PlainFragment.ReadOnly = true;
            this.PlainFragment.Width = 125;
            // 
            // CultureFragment
            // 
            this.CultureFragment.HeaderText = "Культуры";
            this.CultureFragment.MinimumWidth = 6;
            this.CultureFragment.Name = "CultureFragment";
            this.CultureFragment.ReadOnly = true;
            this.CultureFragment.Width = 125;
            // 
            // SwampFragment
            // 
            this.SwampFragment.HeaderText = "Болота";
            this.SwampFragment.MinimumWidth = 6;
            this.SwampFragment.Name = "SwampFragment";
            this.SwampFragment.ReadOnly = true;
            this.SwampFragment.Width = 125;
            // 
            // IceFragment
            // 
            this.IceFragment.HeaderText = "Лёд";
            this.IceFragment.MinimumWidth = 6;
            this.IceFragment.Name = "IceFragment";
            this.IceFragment.ReadOnly = true;
            this.IceFragment.Width = 125;
            // 
            // analyzeBox
            // 
            this.analyzeBox.Location = new System.Drawing.Point(21, 447);
            this.analyzeBox.Name = "analyzeBox";
            this.analyzeBox.Size = new System.Drawing.Size(1898, 160);
            this.analyzeBox.TabIndex = 11;
            this.analyzeBox.Text = "";
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2057, 783);
            this.Controls.Add(this.analyzeBox);
            this.Controls.Add(this.fragmentGridView);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pointsGridView);
            this.Controls.Add(this.analyzeLabel);
            this.Controls.Add(this.closeButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PondsFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiversFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForestsFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoadsFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SandFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn HillsFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn MountainsFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlainFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CultureFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SwampFragment;
        private System.Windows.Forms.DataGridViewTextBoxColumn IceFragment;
        private System.Windows.Forms.RichTextBox analyzeBox;
    }
}