namespace ReliefAnalyze.UI
{
    partial class CriteriaForm
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
            this.criteriaGridView = new System.Windows.Forms.DataGridView();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.criteriaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // criteriaGridView
            // 
            this.criteriaGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.criteriaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criteriaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Building,
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
            this.criteriaGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.criteriaGridView.Location = new System.Drawing.Point(68, 159);
            this.criteriaGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.criteriaGridView.Name = "criteriaGridView";
            this.criteriaGridView.RowHeadersWidth = 51;
            this.criteriaGridView.RowTemplate.Height = 24;
            this.criteriaGridView.Size = new System.Drawing.Size(1388, 314);
            this.criteriaGridView.TabIndex = 1;
            // 
            // Building
            // 
            this.Building.HeaderText = "Объект для постройки";
            this.Building.MinimumWidth = 6;
            this.Building.Name = "Building";
            this.Building.Width = 125;
            // 
            // Ponds
            // 
            this.Ponds.HeaderText = "Водоёмы";
            this.Ponds.MinimumWidth = 6;
            this.Ponds.Name = "Ponds";
            this.Ponds.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ponds.Width = 125;
            // 
            // Rivers
            // 
            this.Rivers.HeaderText = "Реки";
            this.Rivers.MinimumWidth = 6;
            this.Rivers.Name = "Rivers";
            this.Rivers.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rivers.Width = 125;
            // 
            // Forests
            // 
            this.Forests.HeaderText = "Леса";
            this.Forests.MinimumWidth = 6;
            this.Forests.Name = "Forests";
            this.Forests.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Forests.Width = 125;
            // 
            // Roads
            // 
            this.Roads.HeaderText = "Дороги";
            this.Roads.MinimumWidth = 6;
            this.Roads.Name = "Roads";
            this.Roads.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Roads.Width = 125;
            // 
            // Sand
            // 
            this.Sand.HeaderText = "Песок";
            this.Sand.MinimumWidth = 6;
            this.Sand.Name = "Sand";
            this.Sand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sand.Width = 125;
            // 
            // Hills
            // 
            this.Hills.HeaderText = "Возвышенности";
            this.Hills.MinimumWidth = 6;
            this.Hills.Name = "Hills";
            this.Hills.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hills.Width = 125;
            // 
            // Mountains
            // 
            this.Mountains.HeaderText = "Горы";
            this.Mountains.MinimumWidth = 6;
            this.Mountains.Name = "Mountains";
            this.Mountains.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mountains.Width = 125;
            // 
            // Plain
            // 
            this.Plain.HeaderText = "Равнина";
            this.Plain.MinimumWidth = 6;
            this.Plain.Name = "Plain";
            this.Plain.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Plain.Width = 125;
            // 
            // Culture
            // 
            this.Culture.HeaderText = "Культуры";
            this.Culture.MinimumWidth = 6;
            this.Culture.Name = "Culture";
            this.Culture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Culture.Width = 125;
            // 
            // Swamp
            // 
            this.Swamp.HeaderText = "Болота";
            this.Swamp.MinimumWidth = 6;
            this.Swamp.Name = "Swamp";
            this.Swamp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Swamp.Width = 125;
            // 
            // Ice
            // 
            this.Ice.HeaderText = "Лёд";
            this.Ice.MinimumWidth = 6;
            this.Ice.Name = "Ice";
            this.Ice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ice.Width = 125;
            // 
            // CriteriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 598);
            this.Controls.Add(this.criteriaGridView);
            this.Name = "CriteriaForm";
            this.Text = "Критерии";
            this.Load += new System.EventHandler(this.CriteriaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.criteriaGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView criteriaGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
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