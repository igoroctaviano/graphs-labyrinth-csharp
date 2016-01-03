namespace PathFinder_501119
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
            this.LabelDelay = new System.Windows.Forms.Label();
            this.BarDelay = new System.Windows.Forms.TrackBar();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.LabelCompletedTime = new System.Windows.Forms.Label();
            this.ComboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.LabelSearchType = new System.Windows.Forms.Label();
            this.labelHeuristic = new System.Windows.Forms.Label();
            this.comboBoxHeuristicType = new System.Windows.Forms.ComboBox();
            this.labelMovementsAStar = new System.Windows.Forms.Label();
            this.labelAStar = new System.Windows.Forms.Label();
            this.labelBreadth = new System.Windows.Forms.Label();
            this.labelMovementsBreadth = new System.Windows.Forms.Label();
            this.labelCounterBreadth = new System.Windows.Forms.Label();
            this.labelCounterAStar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDelay
            // 
            this.LabelDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDelay.AutoSize = true;
            this.LabelDelay.BackColor = System.Drawing.Color.Transparent;
            this.LabelDelay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDelay.Location = new System.Drawing.Point(512, 119);
            this.LabelDelay.Name = "LabelDelay";
            this.LabelDelay.Size = new System.Drawing.Size(43, 15);
            this.LabelDelay.TabIndex = 14;
            this.LabelDelay.Text = "Atraso";
            this.LabelDelay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelDelay.Click += new System.EventHandler(this.LabelDelay_Click);
            // 
            // BarDelay
            // 
            this.BarDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BarDelay.AutoSize = false;
            this.BarDelay.BackColor = System.Drawing.Color.White;
            this.BarDelay.LargeChange = 10;
            this.BarDelay.Location = new System.Drawing.Point(465, 128);
            this.BarDelay.Maximum = 60;
            this.BarDelay.Name = "BarDelay";
            this.BarDelay.Size = new System.Drawing.Size(142, 33);
            this.BarDelay.TabIndex = 13;
            this.BarDelay.TickFrequency = 10;
            this.BarDelay.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.BarDelay.Value = 3;
            this.BarDelay.Scroll += new System.EventHandler(this.BarDelay_Scroll);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(467, 180);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(131, 23);
            this.ButtonStart.TabIndex = 31;
            this.ButtonStart.Text = "Executar";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Aqua;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 102);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(420, 421);
            this.flowLayoutPanel.TabIndex = 32;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Enabled = false;
            this.buttonClear.Location = new System.Drawing.Point(466, 226);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(132, 23);
            this.buttonClear.TabIndex = 33;
            this.buttonClear.Text = "Limpar solução";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(466, 255);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(132, 23);
            this.buttonReset.TabIndex = 34;
            this.buttonReset.Text = "Limpar tudo";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // LabelCompletedTime
            // 
            this.LabelCompletedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCompletedTime.AutoSize = true;
            this.LabelCompletedTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelCompletedTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCompletedTime.Location = new System.Drawing.Point(462, 206);
            this.LabelCompletedTime.Name = "LabelCompletedTime";
            this.LabelCompletedTime.Size = new System.Drawing.Size(67, 13);
            this.LabelCompletedTime.TabIndex = 30;
            this.LabelCompletedTime.Text = "Tempo  sec.";
            this.LabelCompletedTime.Click += new System.EventHandler(this.LabelCompletedTime_Click);
            // 
            // ComboBoxSearchType
            // 
            this.ComboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearchType.FormattingEnabled = true;
            this.ComboBoxSearchType.Items.AddRange(new object[] {
            "A*                      (Heurística)",
            "Largura                      (Cega)"});
            this.ComboBoxSearchType.Location = new System.Drawing.Point(286, 25);
            this.ComboBoxSearchType.Name = "ComboBoxSearchType";
            this.ComboBoxSearchType.Size = new System.Drawing.Size(177, 21);
            this.ComboBoxSearchType.TabIndex = 18;
            this.ComboBoxSearchType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSearchType_SelectedIndexChanged);
            // 
            // LabelSearchType
            // 
            this.LabelSearchType.AutoSize = true;
            this.LabelSearchType.BackColor = System.Drawing.Color.Transparent;
            this.LabelSearchType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearchType.Location = new System.Drawing.Point(283, 9);
            this.LabelSearchType.Name = "LabelSearchType";
            this.LabelSearchType.Size = new System.Drawing.Size(43, 17);
            this.LabelSearchType.TabIndex = 19;
            this.LabelSearchType.Text = "Busca";
            this.LabelSearchType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHeuristic
            // 
            this.labelHeuristic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeuristic.AutoSize = true;
            this.labelHeuristic.BackColor = System.Drawing.Color.Transparent;
            this.labelHeuristic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeuristic.Location = new System.Drawing.Point(283, 49);
            this.labelHeuristic.Name = "labelHeuristic";
            this.labelHeuristic.Size = new System.Drawing.Size(70, 17);
            this.labelHeuristic.TabIndex = 35;
            this.labelHeuristic.Text = "Heurística";
            this.labelHeuristic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxHeuristicType
            // 
            this.comboBoxHeuristicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHeuristicType.FormattingEnabled = true;
            this.comboBoxHeuristicType.Items.AddRange(new object[] {
            "Manhattan",
            "Euclidean"});
            this.comboBoxHeuristicType.Location = new System.Drawing.Point(286, 65);
            this.comboBoxHeuristicType.Name = "comboBoxHeuristicType";
            this.comboBoxHeuristicType.Size = new System.Drawing.Size(177, 21);
            this.comboBoxHeuristicType.TabIndex = 36;
            this.comboBoxHeuristicType.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeuristicType_SelectedIndexChanged);
            // 
            // labelMovementsAStar
            // 
            this.labelMovementsAStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMovementsAStar.AutoSize = true;
            this.labelMovementsAStar.BackColor = System.Drawing.Color.Transparent;
            this.labelMovementsAStar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovementsAStar.Location = new System.Drawing.Point(549, 38);
            this.labelMovementsAStar.Name = "labelMovementsAStar";
            this.labelMovementsAStar.Size = new System.Drawing.Size(75, 13);
            this.labelMovementsAStar.TabIndex = 38;
            this.labelMovementsAStar.Text = "movimentos.";
            this.labelMovementsAStar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMovementsAStar.Click += new System.EventHandler(this.labelMovementsAStar_Click);
            // 
            // labelAStar
            // 
            this.labelAStar.AutoSize = true;
            this.labelAStar.BackColor = System.Drawing.Color.Transparent;
            this.labelAStar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAStar.Location = new System.Drawing.Point(477, 14);
            this.labelAStar.Name = "labelAStar";
            this.labelAStar.Size = new System.Drawing.Size(33, 25);
            this.labelAStar.TabIndex = 39;
            this.labelAStar.Text = "A*";
            this.labelAStar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAStar.Click += new System.EventHandler(this.labelAStar_Click);
            // 
            // labelBreadth
            // 
            this.labelBreadth.AutoSize = true;
            this.labelBreadth.BackColor = System.Drawing.Color.Transparent;
            this.labelBreadth.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreadth.Location = new System.Drawing.Point(477, 54);
            this.labelBreadth.Name = "labelBreadth";
            this.labelBreadth.Size = new System.Drawing.Size(79, 25);
            this.labelBreadth.TabIndex = 41;
            this.labelBreadth.Text = "Largura";
            this.labelBreadth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelBreadth.Click += new System.EventHandler(this.labelBreadth_Click);
            // 
            // labelMovementsBreadth
            // 
            this.labelMovementsBreadth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMovementsBreadth.AutoSize = true;
            this.labelMovementsBreadth.BackColor = System.Drawing.Color.Transparent;
            this.labelMovementsBreadth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovementsBreadth.Location = new System.Drawing.Point(549, 84);
            this.labelMovementsBreadth.Name = "labelMovementsBreadth";
            this.labelMovementsBreadth.Size = new System.Drawing.Size(75, 13);
            this.labelMovementsBreadth.TabIndex = 40;
            this.labelMovementsBreadth.Text = "movimentos.";
            this.labelMovementsBreadth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCounterBreadth
            // 
            this.labelCounterBreadth.AutoSize = true;
            this.labelCounterBreadth.BackColor = System.Drawing.Color.Transparent;
            this.labelCounterBreadth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounterBreadth.ForeColor = System.Drawing.Color.Red;
            this.labelCounterBreadth.Location = new System.Drawing.Point(579, 58);
            this.labelCounterBreadth.Name = "labelCounterBreadth";
            this.labelCounterBreadth.Size = new System.Drawing.Size(19, 21);
            this.labelCounterBreadth.TabIndex = 42;
            this.labelCounterBreadth.Text = "0";
            this.labelCounterBreadth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCounterAStar
            // 
            this.labelCounterAStar.AutoSize = true;
            this.labelCounterAStar.BackColor = System.Drawing.Color.Transparent;
            this.labelCounterAStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounterAStar.ForeColor = System.Drawing.Color.Red;
            this.labelCounterAStar.Location = new System.Drawing.Point(579, 14);
            this.labelCounterAStar.Name = "labelCounterAStar";
            this.labelCounterAStar.Size = new System.Drawing.Size(19, 21);
            this.labelCounterAStar.TabIndex = 43;
            this.labelCounterAStar.Text = "0";
            this.labelCounterAStar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCounterAStar.Click += new System.EventHandler(this.labelCounterAStar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 565);
            this.Controls.Add(this.labelCounterAStar);
            this.Controls.Add(this.labelCounterBreadth);
            this.Controls.Add(this.labelBreadth);
            this.Controls.Add(this.labelMovementsBreadth);
            this.Controls.Add(this.labelAStar);
            this.Controls.Add(this.labelMovementsAStar);
            this.Controls.Add(this.comboBoxHeuristicType);
            this.Controls.Add(this.labelHeuristic);
            this.Controls.Add(this.ComboBoxSearchType);
            this.Controls.Add(this.LabelCompletedTime);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.LabelSearchType);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.LabelDelay);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.BarDelay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(651, 604);
            this.MinimumSize = new System.Drawing.Size(651, 604);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDelay;
        private System.Windows.Forms.TrackBar BarDelay;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label LabelCompletedTime;
        private System.Windows.Forms.ComboBox ComboBoxSearchType;
        private System.Windows.Forms.Label LabelSearchType;
        private System.Windows.Forms.Label labelHeuristic;
        private System.Windows.Forms.ComboBox comboBoxHeuristicType;
        private System.Windows.Forms.Label labelMovementsAStar;
        private System.Windows.Forms.Label labelAStar;
        private System.Windows.Forms.Label labelBreadth;
        private System.Windows.Forms.Label labelMovementsBreadth;
        private System.Windows.Forms.Label labelCounterBreadth;
        private System.Windows.Forms.Label labelCounterAStar;
    }
}

