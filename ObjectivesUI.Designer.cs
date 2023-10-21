namespace STOCKUI2
{
    partial class ObjectivesUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinScreen = new System.Windows.Forms.Button();
            this.MaxScreen = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PriorityLBL = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddOBJButton = new System.Windows.Forms.Button();
            this.TitleLBL = new System.Windows.Forms.TextBox();
            this.DescriptionLBL = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DeadlineLBL = new System.Windows.Forms.TextBox();
            this.ObjectiveViewer = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJS = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectiveViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBJS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.PortfolioClick);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 786);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 157);
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
            this.button3.Location = new System.Drawing.Point(0, 413);
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
            this.button4.Location = new System.Drawing.Point(-1, 324);
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
            this.PortfolioClick.Location = new System.Drawing.Point(0, 243);
            this.PortfolioClick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PortfolioClick.Name = "PortfolioClick";
            this.PortfolioClick.Size = new System.Drawing.Size(188, 63);
            this.PortfolioClick.TabIndex = 13;
            this.PortfolioClick.Text = "Portfolio";
            this.PortfolioClick.UseVisualStyleBackColor = true;
            this.PortfolioClick.Click += new System.EventHandler(this.PortfolioClick_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.MinScreen);
            this.panel1.Controls.Add(this.MaxScreen);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(191, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 73);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MinScreen
            // 
            this.MinScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinScreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinScreen.Location = new System.Drawing.Point(1168, 4);
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
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1037, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(888, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1173, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Objective";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(1124, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(1124, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(1120, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Priority";
            // 
            // PriorityLBL
            // 
            this.PriorityLBL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PriorityLBL.FormattingEnabled = true;
            this.PriorityLBL.Location = new System.Drawing.Point(1124, 606);
            this.PriorityLBL.Name = "PriorityLBL";
            this.PriorityLBL.Size = new System.Drawing.Size(121, 23);
            this.PriorityLBL.TabIndex = 11;
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(240, 113);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(224, 33);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Edit Selected Objective";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOBJButton
            // 
            this.AddOBJButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddOBJButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddOBJButton.Location = new System.Drawing.Point(1217, 672);
            this.AddOBJButton.Name = "AddOBJButton";
            this.AddOBJButton.Size = new System.Drawing.Size(107, 38);
            this.AddOBJButton.TabIndex = 14;
            this.AddOBJButton.Text = "ADD";
            this.AddOBJButton.UseVisualStyleBackColor = true;
            this.AddOBJButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // TitleLBL
            // 
            this.TitleLBL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TitleLBL.Location = new System.Drawing.Point(1124, 215);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(241, 23);
            this.TitleLBL.TabIndex = 15;
            // 
            // DescriptionLBL
            // 
            this.DescriptionLBL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DescriptionLBL.Location = new System.Drawing.Point(1124, 316);
            this.DescriptionLBL.Name = "DescriptionLBL";
            this.DescriptionLBL.Size = new System.Drawing.Size(235, 109);
            this.DescriptionLBL.TabIndex = 16;
            this.DescriptionLBL.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(1124, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Deadline";
            // 
            // DeadlineLBL
            // 
            this.DeadlineLBL.Location = new System.Drawing.Point(1128, 491);
            this.DeadlineLBL.Name = "DeadlineLBL";
            this.DeadlineLBL.Size = new System.Drawing.Size(225, 23);
            this.DeadlineLBL.TabIndex = 19;
            // 
            // ObjectiveViewer
            // 
            this.ObjectiveViewer.AllowUserToAddRows = false;
            this.ObjectiveViewer.AllowUserToDeleteRows = false;
            this.ObjectiveViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ObjectiveViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ObjectiveViewer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ObjectiveViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectiveViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Task,
            this.Priority,
            this.Deadline,
            this.Status});
            this.ObjectiveViewer.Location = new System.Drawing.Point(240, 170);
            this.ObjectiveViewer.Name = "ObjectiveViewer";
            this.ObjectiveViewer.ReadOnly = true;
            this.ObjectiveViewer.RowTemplate.Height = 25;
            this.ObjectiveViewer.Size = new System.Drawing.Size(714, 488);
            this.ObjectiveViewer.TabIndex = 21;
            this.ObjectiveViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 54;
            // 
            // Task
            // 
            this.Task.DataPropertyName = "task";
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            this.Task.Width = 54;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Width = 70;
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "Deadline";
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            this.Deadline.Width = 78;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 64;
            // 
            // ObjectivesUI
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1523, 786);
            this.Controls.Add(this.ObjectiveViewer);
            this.Controls.Add(this.DeadlineLBL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DescriptionLBL);
            this.Controls.Add(this.TitleLBL);
            this.Controls.Add(this.AddOBJButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.PriorityLBL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ObjectivesUI";
            this.Load += new System.EventHandler(this.ObjectivesUI_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectiveViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBJS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Button button3;
        private Button button4;
        private Button PortfolioClick;
        private Button button2;
        private Panel panel1;
        private Button MinScreen;
        private Button MaxScreen;
        private Button Exit;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox PriorityLBL;
        private Button EditButton;
        private Button AddOBJButton;
        private TextBox TitleLBL;
        private RichTextBox DescriptionLBL;
        private Label label9;
        private TextBox DeadlineLBL;
        private DataGridView ObjectiveViewer;
        private BindingSource OBJS;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Task;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Deadline;
        private DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Timer timer1;
    }
}