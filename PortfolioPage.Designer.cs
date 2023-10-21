namespace STOCKUI2
{
    partial class PortfolioPage
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
            this.components = new System.ComponentModel.Container();
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
            this.BalanceLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PortfolioViewButton = new System.Windows.Forms.Button();
            this.MostExpensiveInvestment = new System.Windows.Forms.Label();
            this.ShareLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LargestShares = new System.Windows.Forms.Label();
            this.ProfitTicker = new System.Windows.Forms.Label();
            this.MoneyInvestedLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ProportionLBL = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.InvestedStocksList = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SellButton = new System.Windows.Forms.Button();
            this.QuantityBox = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TickerBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBox)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(192, 797);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(4, 133);
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
            this.button3.Location = new System.Drawing.Point(3, 379);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 63);
            this.button3.TabIndex = 10;
            this.button3.Text = "Simulation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(3, 303);
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
            this.PortfolioClick.Location = new System.Drawing.Point(3, 220);
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
            this.panel1.Controls.Add(this.BalanceLBL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(192, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 73);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // BalanceLBL
            // 
            this.BalanceLBL.AutoSize = true;
            this.BalanceLBL.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BalanceLBL.Location = new System.Drawing.Point(987, 28);
            this.BalanceLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceLBL.Name = "BalanceLBL";
            this.BalanceLBL.Size = new System.Drawing.Size(0, 30);
            this.BalanceLBL.TabIndex = 3;
            this.BalanceLBL.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(850, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Balance: ";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(505, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(651, 329);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PortfolioViewButton);
            this.panel4.Controls.Add(this.MostExpensiveInvestment);
            this.panel4.Controls.Add(this.ShareLabel);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.LargestShares);
            this.panel4.Controls.Add(this.ProfitTicker);
            this.panel4.Controls.Add(this.MoneyInvestedLabel);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.ProportionLBL);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.SearchButton);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.InvestedStocksList);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(192, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 718);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // PortfolioViewButton
            // 
            this.PortfolioViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortfolioViewButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PortfolioViewButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PortfolioViewButton.Location = new System.Drawing.Point(208, 320);
            this.PortfolioViewButton.Name = "PortfolioViewButton";
            this.PortfolioViewButton.Size = new System.Drawing.Size(75, 23);
            this.PortfolioViewButton.TabIndex = 27;
            this.PortfolioViewButton.Text = "View Performance";
            this.PortfolioViewButton.UseVisualStyleBackColor = true;
            this.PortfolioViewButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // MostExpensiveInvestment
            // 
            this.MostExpensiveInvestment.AutoSize = true;
            this.MostExpensiveInvestment.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MostExpensiveInvestment.ForeColor = System.Drawing.Color.LightSalmon;
            this.MostExpensiveInvestment.Location = new System.Drawing.Point(7, 396);
            this.MostExpensiveInvestment.Name = "MostExpensiveInvestment";
            this.MostExpensiveInvestment.Size = new System.Drawing.Size(0, 17);
            this.MostExpensiveInvestment.TabIndex = 26;
            // 
            // ShareLabel
            // 
            this.ShareLabel.AutoSize = true;
            this.ShareLabel.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShareLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ShareLabel.Location = new System.Drawing.Point(102, 167);
            this.ShareLabel.Name = "ShareLabel";
            this.ShareLabel.Size = new System.Drawing.Size(0, 25);
            this.ShareLabel.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(7, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 25);
            this.label19.TabIndex = 24;
            this.label19.Text = "Shares:";
            // 
            // LargestShares
            // 
            this.LargestShares.AutoSize = true;
            this.LargestShares.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LargestShares.ForeColor = System.Drawing.Color.LightSalmon;
            this.LargestShares.Location = new System.Drawing.Point(10, 471);
            this.LargestShares.Name = "LargestShares";
            this.LargestShares.Size = new System.Drawing.Size(0, 17);
            this.LargestShares.TabIndex = 23;
            // 
            // ProfitTicker
            // 
            this.ProfitTicker.AutoSize = true;
            this.ProfitTicker.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProfitTicker.ForeColor = System.Drawing.Color.IndianRed;
            this.ProfitTicker.Location = new System.Drawing.Point(10, 549);
            this.ProfitTicker.Name = "ProfitTicker";
            this.ProfitTicker.Size = new System.Drawing.Size(0, 21);
            this.ProfitTicker.TabIndex = 22;
            // 
            // MoneyInvestedLabel
            // 
            this.MoneyInvestedLabel.AutoSize = true;
            this.MoneyInvestedLabel.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoneyInvestedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MoneyInvestedLabel.Location = new System.Drawing.Point(190, 119);
            this.MoneyInvestedLabel.Name = "MoneyInvestedLabel";
            this.MoneyInvestedLabel.Size = new System.Drawing.Size(0, 25);
            this.MoneyInvestedLabel.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(7, 119);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 25);
            this.label20.TabIndex = 19;
            this.label20.Text = "Money Invested:";
            // 
            // ProportionLBL
            // 
            this.ProportionLBL.AutoSize = true;
            this.ProportionLBL.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProportionLBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProportionLBL.Location = new System.Drawing.Point(137, 210);
            this.ProportionLBL.Name = "ProportionLBL";
            this.ProportionLBL.Size = new System.Drawing.Size(0, 25);
            this.ProportionLBL.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(10, 210);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 25);
            this.label18.TabIndex = 17;
            this.label18.Text = "Proportion: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(3, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 21);
            this.label17.TabIndex = 16;
            this.label17.Text = "Portfolio Performance";
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchButton.Location = new System.Drawing.Point(163, 63);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(80, 32);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(7, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 21);
            this.label16.TabIndex = 14;
            this.label16.Text = "Select Invested Stock";
            // 
            // InvestedStocksList
            // 
            this.InvestedStocksList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InvestedStocksList.FormattingEnabled = true;
            this.InvestedStocksList.Location = new System.Drawing.Point(7, 69);
            this.InvestedStocksList.Name = "InvestedStocksList";
            this.InvestedStocksList.Size = new System.Drawing.Size(120, 23);
            this.InvestedStocksList.TabIndex = 13;
            this.InvestedStocksList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(4, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Most Expensive Investment:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(7, 508);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Profit/Loss:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(4, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Largest Number of Shares: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(66, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Statistics";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(494, 517);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 220);
            this.panel5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(795, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "Orders";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.SellButton);
            this.panel6.Controls.Add(this.QuantityBox);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.TickerBox);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel6.Location = new System.Drawing.Point(998, 489);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 260);
            this.panel6.TabIndex = 13;
            // 
            // SellButton
            // 
            this.SellButton.BackColor = System.Drawing.Color.Cyan;
            this.SellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellButton.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SellButton.Location = new System.Drawing.Point(108, 206);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(74, 33);
            this.SellButton.TabIndex = 26;
            this.SellButton.Text = "SELL";
            this.SellButton.UseVisualStyleBackColor = false;
            this.SellButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(70, 105);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(154, 23);
            this.QuantityBox.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(52, 154);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(203, 35);
            this.panel7.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(4, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Transaction Price: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(70, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "QUANTITY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(70, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "TICKER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(88, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "MAKE ORDER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TickerBox
            // 
            this.TickerBox.Location = new System.Drawing.Point(70, 61);
            this.TickerBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TickerBox.Name = "TickerBox";
            this.TickerBox.Size = new System.Drawing.Size(154, 23);
            this.TickerBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(123, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "SELL";
            // 
            // PortfolioPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1333, 797);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PortfolioPage";
            this.Text = "PortfolioPage";
            this.Load += new System.EventHandler(this.PortfolioPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBox)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Button button3;
        private Button button4;
        private Button PortfolioClick;
        private Panel panel3;
        private Button button2;
        private Panel panel1;
        private Button MinScreen;
        private Button MaxScreen;
        private Button Exit;
        private Label BalanceLBL;
        private Label label4;
        private System.Windows.Forms.Timer timer2;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private Button SellButton;
        private NumericUpDown QuantityBox;
        private Panel panel7;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button button1;
        private TextBox TickerBox;
        private Label label8;
        private Label label14;
        private Label label13;
        private Label label9;
        private Button SearchButton;
        private Label label16;
        private ComboBox InvestedStocksList;
        private Label label17;
        private Label label20;
        private Label ProportionLBL;
        private Label label18;
        private Label MoneyInvestedLabel;
        private Label ProfitTicker;
        private Label LargestShares;
        private Label label19;
        private Label ShareLabel;
        private Label MostExpensiveInvestment;
        private Button PortfolioViewButton;
    }
}