namespace STOCKUI2
{
    partial class GeometricBrownianMotion
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PortfolioClick = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinScreen = new System.Windows.Forms.Button();
            this.MaxScreen = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SimulationTable = new System.Windows.Forms.DataGridView();
            this.StatsLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DriftLBL = new System.Windows.Forms.TextBox();
            this.VolatilityLBL = new System.Windows.Forms.TextBox();
            this.ReferencePrice = new System.Windows.Forms.Label();
            this.DayNumLBL = new System.Windows.Forms.NumericUpDown();
            this.SimNum = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.PriceAtStart = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StockLBL = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SimulateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayNumLBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(246, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.PortfolioClick);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 758);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 177);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(0, 429);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 63);
            this.button3.TabIndex = 10;
            this.button3.Text = "Simulation";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(0, 340);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 63);
            this.button4.TabIndex = 11;
            this.button4.Text = "Objectives";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PortfolioClick
            // 
            this.PortfolioClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortfolioClick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PortfolioClick.Location = new System.Drawing.Point(0, 260);
            this.PortfolioClick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PortfolioClick.Name = "PortfolioClick";
            this.PortfolioClick.Size = new System.Drawing.Size(188, 63);
            this.PortfolioClick.TabIndex = 13;
            this.PortfolioClick.Text = "Portfolio";
            this.PortfolioClick.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(4, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 63);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.MinScreen);
            this.panel1.Controls.Add(this.MaxScreen);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(192, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 73);
            this.panel1.TabIndex = 3;
            // 
            // MinScreen
            // 
            this.MinScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinScreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinScreen.Location = new System.Drawing.Point(1170, 4);
            this.MinScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinScreen.Name = "MinScreen";
            this.MinScreen.Size = new System.Drawing.Size(29, 26);
            this.MinScreen.TabIndex = 15;
            this.MinScreen.Text = "-";
            this.MinScreen.UseVisualStyleBackColor = true;
            // 
            // MaxScreen
            // 
            this.MaxScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxScreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaxScreen.Location = new System.Drawing.Point(1205, 4);
            this.MaxScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaxScreen.Name = "MaxScreen";
            this.MaxScreen.Size = new System.Drawing.Size(31, 25);
            this.MaxScreen.TabIndex = 13;
            this.MaxScreen.Text = "+";
            this.MaxScreen.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(1242, 3);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(74, 26);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SimulationTable);
            this.panel4.Controls.Add(this.StatsLabel);
            this.panel4.Location = new System.Drawing.Point(762, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(525, 647);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // SimulationTable
            // 
            this.SimulationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationTable.Location = new System.Drawing.Point(39, 61);
            this.SimulationTable.Name = "SimulationTable";
            this.SimulationTable.RowTemplate.Height = 25;
            this.SimulationTable.Size = new System.Drawing.Size(432, 559);
            this.SimulationTable.TabIndex = 3;
            this.SimulationTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StatsLabel
            // 
            this.StatsLabel.AutoSize = true;
            this.StatsLabel.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StatsLabel.Location = new System.Drawing.Point(39, 14);
            this.StatsLabel.Name = "StatsLabel";
            this.StatsLabel.Size = new System.Drawing.Size(243, 25);
            this.StatsLabel.TabIndex = 0;
            this.StatsLabel.Text = "Simulation Statistics";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DriftLBL);
            this.panel5.Controls.Add(this.VolatilityLBL);
            this.panel5.Controls.Add(this.ReferencePrice);
            this.panel5.Controls.Add(this.DayNumLBL);
            this.panel5.Controls.Add(this.SimNum);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.PriceAtStart);
            this.panel5.Controls.Add(this.SearchButton);
            this.panel5.Controls.Add(this.StockLBL);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.SimulateButton);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(218, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 557);
            this.panel5.TabIndex = 6;
            // 
            // DriftLBL
            // 
            this.DriftLBL.Location = new System.Drawing.Point(145, 322);
            this.DriftLBL.Name = "DriftLBL";
            this.DriftLBL.Size = new System.Drawing.Size(100, 23);
            this.DriftLBL.TabIndex = 17;
            // 
            // VolatilityLBL
            // 
            this.VolatilityLBL.Location = new System.Drawing.Point(167, 286);
            this.VolatilityLBL.Name = "VolatilityLBL";
            this.VolatilityLBL.Size = new System.Drawing.Size(100, 23);
            this.VolatilityLBL.TabIndex = 16;
            // 
            // ReferencePrice
            // 
            this.ReferencePrice.AutoSize = true;
            this.ReferencePrice.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReferencePrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReferencePrice.Location = new System.Drawing.Point(244, 197);
            this.ReferencePrice.Name = "ReferencePrice";
            this.ReferencePrice.Size = new System.Drawing.Size(0, 16);
            this.ReferencePrice.TabIndex = 15;
            // 
            // DayNumLBL
            // 
            this.DayNumLBL.Location = new System.Drawing.Point(143, 253);
            this.DayNumLBL.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.DayNumLBL.Name = "DayNumLBL";
            this.DayNumLBL.Size = new System.Drawing.Size(55, 23);
            this.DayNumLBL.TabIndex = 12;
            // 
            // SimNum
            // 
            this.SimNum.Location = new System.Drawing.Point(185, 224);
            this.SimNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SimNum.Name = "SimNum";
            this.SimNum.Size = new System.Drawing.Size(57, 23);
            this.SimNum.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(34, 324);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Drift Constant: ";
            // 
            // PriceAtStart
            // 
            this.PriceAtStart.AutoSize = true;
            this.PriceAtStart.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceAtStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PriceAtStart.Location = new System.Drawing.Point(145, 197);
            this.PriceAtStart.Name = "PriceAtStart";
            this.PriceAtStart.Size = new System.Drawing.Size(0, 16);
            this.PriceAtStart.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(167, 164);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(88, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // StockLBL
            // 
            this.StockLBL.Location = new System.Drawing.Point(37, 164);
            this.StockLBL.Name = "StockLBL";
            this.StockLBL.Size = new System.Drawing.Size(117, 23);
            this.StockLBL.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(34, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Number Of Simulations: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(31, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Price at T = 0: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(185, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Stock Preset";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(31, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Volatility constant: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(34, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Number of Days: ";
            // 
            // SimulateButton
            // 
            this.SimulateButton.Location = new System.Drawing.Point(324, 253);
            this.SimulateButton.Name = "SimulateButton";
            this.SimulateButton.Size = new System.Drawing.Size(113, 51);
            this.SimulateButton.TabIndex = 1;
            this.SimulateButton.Text = "Simulate";
            this.SimulateButton.UseVisualStyleBackColor = true;
            this.SimulateButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(37, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search Stock";
            // 
            // GeometricBrownianMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1317, 758);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeometricBrownianMotion";
            this.Text = "GeometricBrownianMotion";
            this.Load += new System.EventHandler(this.GeometricBrownianMotion_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayNumLBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button PortfolioClick;
        private Panel panel3;
        private Panel panel1;
        private Button MinScreen;
        private Button MaxScreen;
        private Button Exit;
        private Panel panel4;
        private Panel panel5;
        private NumericUpDown DayNumLBL;
        private NumericUpDown SimNum;
        private Label label18;
        private Label PriceAtStart;
        private Button SearchButton;
        private TextBox StockLBL;
        private Label label16;
        private Label label15;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button SimulateButton;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label StatsLabel;
        private Label ReferencePrice;
        private DataGridView SimulationTable;
        private TextBox DriftLBL;
        private TextBox VolatilityLBL;
    }
}