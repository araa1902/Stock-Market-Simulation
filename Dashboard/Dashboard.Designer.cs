
namespace STOCKUI2
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.MinScreen = new System.Windows.Forms.Button();
            this.MaxScreen = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SimulationButton = new System.Windows.Forms.Button();
            this.ObjectiveButton = new System.Windows.Forms.Button();
            this.PortfolioClick = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.QuantityTEXTBOX = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MakeTransaction = new System.Windows.Forms.Button();
            this.TickerBuyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PercentageConfidenceLBL = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DecisionLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DurationUpDown = new System.Windows.Forms.NumericUpDown();
            this.SearchHistoryBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TypeButton = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StockLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HighLbl = new System.Windows.Forms.Label();
            this.LowLbl = new System.Windows.Forms.Label();
            this.OpenLbl = new System.Windows.Forms.Label();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DisplayHighPrice = new System.Windows.Forms.Label();
            this.DisplayLowPrice = new System.Windows.Forms.Label();
            this.DisplayOpen = new System.Windows.Forms.Label();
            this.DisplayClose = new System.Windows.Forms.Label();
            this.DisplayPrevClose = new System.Windows.Forms.Label();
            this.DisplayPerChange = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTEXTBOX)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.MinScreen);
            this.panel1.Controls.Add(this.MaxScreen);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 73);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(19, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 52);
            this.button5.TabIndex = 16;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // MinScreen
            // 
            this.MinScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinScreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinScreen.Location = new System.Drawing.Point(1163, 4);
            this.MinScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinScreen.Name = "MinScreen";
            this.MinScreen.Size = new System.Drawing.Size(29, 26);
            this.MinScreen.TabIndex = 15;
            this.MinScreen.Text = "-";
            this.MinScreen.UseVisualStyleBackColor = true;
            this.MinScreen.Click += new System.EventHandler(this.MinScreen_Click);
            // 
            // MaxScreen
            // 
            this.MaxScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxScreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaxScreen.Location = new System.Drawing.Point(1205, 4);
            this.MaxScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaxScreen.Name = "MaxScreen";
            this.MaxScreen.Size = new System.Drawing.Size(30, 25);
            this.MaxScreen.TabIndex = 13;
            this.MaxScreen.Text = "+";
            this.MaxScreen.UseVisualStyleBackColor = true;
            this.MaxScreen.Click += new System.EventHandler(this.MaxScreen_Click);
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(1244, 3);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 26);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1015, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 3;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(860, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(579, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(593, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.SimulationButton);
            this.panel2.Controls.Add(this.ObjectiveButton);
            this.panel2.Controls.Add(this.PortfolioClick);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 724);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(-1, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SimulationButton
            // 
            this.SimulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimulationButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SimulationButton.Location = new System.Drawing.Point(0, 379);
            this.SimulationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SimulationButton.Name = "SimulationButton";
            this.SimulationButton.Size = new System.Drawing.Size(188, 63);
            this.SimulationButton.TabIndex = 10;
            this.SimulationButton.Text = "Simulation";
            this.SimulationButton.UseVisualStyleBackColor = true;
            this.SimulationButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ObjectiveButton
            // 
            this.ObjectiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObjectiveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ObjectiveButton.Location = new System.Drawing.Point(3, 303);
            this.ObjectiveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ObjectiveButton.Name = "ObjectiveButton";
            this.ObjectiveButton.Size = new System.Drawing.Size(188, 63);
            this.ObjectiveButton.TabIndex = 11;
            this.ObjectiveButton.Text = "Objectives";
            this.ObjectiveButton.UseVisualStyleBackColor = true;
            this.ObjectiveButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // PortfolioClick
            // 
            this.PortfolioClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortfolioClick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PortfolioClick.Location = new System.Drawing.Point(3, 213);
            this.PortfolioClick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PortfolioClick.Name = "PortfolioClick";
            this.PortfolioClick.Size = new System.Drawing.Size(188, 63);
            this.PortfolioClick.TabIndex = 13;
            this.PortfolioClick.Text = "Portfolio";
            this.PortfolioClick.UseVisualStyleBackColor = true;
            this.PortfolioClick.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(4, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 63);
            this.panel3.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(88, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Make Transaction:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.QuantityTEXTBOX);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.MakeTransaction);
            this.panel4.Controls.Add(this.TickerBuyTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(1021, 73);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 328);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // QuantityTEXTBOX
            // 
            this.QuantityTEXTBOX.Location = new System.Drawing.Point(70, 164);
            this.QuantityTEXTBOX.Name = "QuantityTEXTBOX";
            this.QuantityTEXTBOX.Size = new System.Drawing.Size(154, 23);
            this.QuantityTEXTBOX.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(46, 204);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(203, 35);
            this.panel7.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Transaction Price: ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "QUANTITY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "TICKER";
            // 
            // MakeTransaction
            // 
            this.MakeTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.MakeTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeTransaction.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakeTransaction.ForeColor = System.Drawing.SystemColors.Window;
            this.MakeTransaction.Location = new System.Drawing.Point(88, 265);
            this.MakeTransaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MakeTransaction.Name = "MakeTransaction";
            this.MakeTransaction.Size = new System.Drawing.Size(115, 34);
            this.MakeTransaction.TabIndex = 21;
            this.MakeTransaction.Text = "MAKE ORDER";
            this.MakeTransaction.UseVisualStyleBackColor = false;
            this.MakeTransaction.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TickerBuyTextBox
            // 
            this.TickerBuyTextBox.Location = new System.Drawing.Point(70, 99);
            this.TickerBuyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TickerBuyTextBox.Name = "TickerBuyTextBox";
            this.TickerBuyTextBox.Size = new System.Drawing.Size(154, 23);
            this.TickerBuyTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(99, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "MARKET";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.PercentageConfidenceLBL);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.DecisionLabel);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(1037, 421);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 341);
            this.panel5.TabIndex = 13;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // PercentageConfidenceLBL
            // 
            this.PercentageConfidenceLBL.AutoSize = true;
            this.PercentageConfidenceLBL.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PercentageConfidenceLBL.Location = new System.Drawing.Point(30, 257);
            this.PercentageConfidenceLBL.Name = "PercentageConfidenceLBL";
            this.PercentageConfidenceLBL.Size = new System.Drawing.Size(0, 28);
            this.PercentageConfidenceLBL.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(17, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Percentage Confidence: ";
            // 
            // DecisionLabel
            // 
            this.DecisionLabel.AutoSize = true;
            this.DecisionLabel.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecisionLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.DecisionLabel.Location = new System.Drawing.Point(54, 101);
            this.DecisionLabel.Name = "DecisionLabel";
            this.DecisionLabel.Size = new System.Drawing.Size(0, 63);
            this.DecisionLabel.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(41, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Stock Predictor";
            // 
            // panel6
            // 
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.DurationUpDown);
            this.panel6.Controls.Add(this.SearchHistoryBox);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.TypeButton);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Controls.Add(this.SearchButton);
            this.panel6.Controls.Add(this.StockLabel);
            this.panel6.Controls.Add(this.label7);
            this.panel6.ForeColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(776, 97);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 449);
            this.panel6.TabIndex = 18;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // DurationUpDown
            // 
            this.DurationUpDown.Location = new System.Drawing.Point(139, 127);
            this.DurationUpDown.Name = "DurationUpDown";
            this.DurationUpDown.Size = new System.Drawing.Size(80, 25);
            this.DurationUpDown.TabIndex = 29;
            // 
            // SearchHistoryBox
            // 
            this.SearchHistoryBox.FormattingEnabled = true;
            this.SearchHistoryBox.Location = new System.Drawing.Point(9, 369);
            this.SearchHistoryBox.Name = "SearchHistoryBox";
            this.SearchHistoryBox.Size = new System.Drawing.Size(121, 25);
            this.SearchHistoryBox.TabIndex = 27;
            this.SearchHistoryBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(118, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 21);
            this.label15.TabIndex = 25;
            this.label15.Text = "Time In Past";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(10, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 25);
            this.label14.TabIndex = 24;
            this.label14.Text = "Type";
            // 
            // TypeButton
            // 
            this.TypeButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeButton.FormattingEnabled = true;
            this.TypeButton.Location = new System.Drawing.Point(10, 126);
            this.TypeButton.Name = "TypeButton";
            this.TypeButton.Size = new System.Drawing.Size(78, 25);
            this.TypeButton.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(26, 293);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 28);
            this.label13.TabIndex = 22;
            this.label13.Text = "Recent Searches";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.richTextBox1.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 279);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 170);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchButton.Location = new System.Drawing.Point(58, 176);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(118, 37);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // StockLabel
            // 
            this.StockLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.StockLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StockLabel.Location = new System.Drawing.Point(10, 57);
            this.StockLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(194, 25);
            this.StockLabel.TabIndex = 20;
            this.StockLabel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(43, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search Stock";
            // 
            // HighLbl
            // 
            this.HighLbl.AutoSize = true;
            this.HighLbl.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HighLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HighLbl.Location = new System.Drawing.Point(216, 551);
            this.HighLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HighLbl.Name = "HighLbl";
            this.HighLbl.Size = new System.Drawing.Size(54, 20);
            this.HighLbl.TabIndex = 19;
            this.HighLbl.Text = "High:";
            this.HighLbl.Click += new System.EventHandler(this.HighLbl_Click);
            // 
            // LowLbl
            // 
            this.LowLbl.AutoSize = true;
            this.LowLbl.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LowLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LowLbl.Location = new System.Drawing.Point(216, 607);
            this.LowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowLbl.Name = "LowLbl";
            this.LowLbl.Size = new System.Drawing.Size(45, 20);
            this.LowLbl.TabIndex = 20;
            this.LowLbl.Text = "Low:";
            // 
            // OpenLbl
            // 
            this.OpenLbl.AutoSize = true;
            this.OpenLbl.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenLbl.Location = new System.Drawing.Point(216, 678);
            this.OpenLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpenLbl.Name = "OpenLbl";
            this.OpenLbl.Size = new System.Drawing.Size(63, 20);
            this.OpenLbl.TabIndex = 21;
            this.OpenLbl.Text = "Open: ";
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseLbl.Location = new System.Drawing.Point(216, 751);
            this.CloseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(72, 20);
            this.CloseLbl.TabIndex = 22;
            this.CloseLbl.Text = "Close: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(561, 551);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Prev Close:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(561, 629);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "% Change: ";
            // 
            // DisplayHighPrice
            // 
            this.DisplayHighPrice.AutoSize = true;
            this.DisplayHighPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayHighPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayHighPrice.Location = new System.Drawing.Point(279, 554);
            this.DisplayHighPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayHighPrice.Name = "DisplayHighPrice";
            this.DisplayHighPrice.Size = new System.Drawing.Size(0, 21);
            this.DisplayHighPrice.TabIndex = 25;
            // 
            // DisplayLowPrice
            // 
            this.DisplayLowPrice.AutoSize = true;
            this.DisplayLowPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayLowPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayLowPrice.Location = new System.Drawing.Point(269, 610);
            this.DisplayLowPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayLowPrice.Name = "DisplayLowPrice";
            this.DisplayLowPrice.Size = new System.Drawing.Size(0, 21);
            this.DisplayLowPrice.TabIndex = 26;
            // 
            // DisplayOpen
            // 
            this.DisplayOpen.AutoSize = true;
            this.DisplayOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayOpen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayOpen.Location = new System.Drawing.Point(279, 678);
            this.DisplayOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayOpen.Name = "DisplayOpen";
            this.DisplayOpen.Size = new System.Drawing.Size(0, 21);
            this.DisplayOpen.TabIndex = 27;
            // 
            // DisplayClose
            // 
            this.DisplayClose.AutoSize = true;
            this.DisplayClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayClose.Location = new System.Drawing.Point(279, 753);
            this.DisplayClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayClose.Name = "DisplayClose";
            this.DisplayClose.Size = new System.Drawing.Size(0, 21);
            this.DisplayClose.TabIndex = 28;
            // 
            // DisplayPrevClose
            // 
            this.DisplayPrevClose.AutoSize = true;
            this.DisplayPrevClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayPrevClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayPrevClose.Location = new System.Drawing.Point(665, 551);
            this.DisplayPrevClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayPrevClose.Name = "DisplayPrevClose";
            this.DisplayPrevClose.Size = new System.Drawing.Size(0, 21);
            this.DisplayPrevClose.TabIndex = 29;
            // 
            // DisplayPerChange
            // 
            this.DisplayPerChange.AutoSize = true;
            this.DisplayPerChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayPerChange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayPerChange.Location = new System.Drawing.Point(649, 629);
            this.DisplayPerChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayPerChange.Name = "DisplayPerChange";
            this.DisplayPerChange.Size = new System.Drawing.Size(0, 21);
            this.DisplayPerChange.TabIndex = 30;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(199, 105);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(571, 410);
            this.cartesianChart1.TabIndex = 33;
            this.cartesianChart1.Load += new System.EventHandler(this.cartesianChart1_Load_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1333, 797);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.DisplayPerChange);
            this.Controls.Add(this.DisplayPrevClose);
            this.Controls.Add(this.DisplayClose);
            this.Controls.Add(this.DisplayOpen);
            this.Controls.Add(this.DisplayLowPrice);
            this.Controls.Add(this.DisplayHighPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CloseLbl);
            this.Controls.Add(this.OpenLbl);
            this.Controls.Add(this.LowLbl);
            this.Controls.Add(this.HighLbl);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTEXTBOX)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Button button2;
        private Button SimulationButton;
        private Button ObjectiveButton;
        private Button PortfolioClick;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Button Exit;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label6;
        private Button MaxScreen;
        private Button MinScreen;
        private Panel panel6;
        private Button SearchButton;
        private TextBox StockLabel;
        private Label label7;
        private Label HighLbl;
        private Label LowLbl;
        private Label OpenLbl;
        private Label CloseLbl;
        private Label label8;
        private Label label9;
        private Label DisplayHighPrice;
        private Label DisplayLowPrice;
        private Label DisplayOpen;
        private Label DisplayClose;
        private Label DisplayPrevClose;
        private Label DisplayPerChange;
        private Button MakeTransaction;
        private TextBox TickerBuyTextBox;
        private Label label11;
        private Label label10;
        private Panel panel7;
        private Label label12;
        private Label label13;
        private RichTextBox richTextBox1;
        private NumericUpDown QuantityTEXTBOX;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label14;
        private ComboBox TypeButton;
        private Label label15;
        private Label DecisionLabel;
        private Label PercentageConfidenceLBL;
        private Label label17;
        private Button button5;
        private ComboBox SearchHistoryBox;
        private NumericUpDown DurationUpDown;
    }
}