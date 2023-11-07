namespace STOCKUI2
{
    partial class Reports
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
            this.UsernameLBL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ChoiceLBL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.Usernumlbl = new System.Windows.Forms.Label();
            this.NumberUserLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsernameLBL.FormattingEnabled = true;
            this.UsernameLBL.Location = new System.Drawing.Point(89, 95);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(139, 23);
            this.UsernameLBL.TabIndex = 0;
            this.UsernameLBL.SelectedIndexChanged += new System.EventHandler(this.UsernameLBL_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find User";
            // 
            // ReportGrid
            // 
            this.ReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportGrid.Location = new System.Drawing.Point(249, 29);
            this.ReportGrid.Name = "ReportGrid";
            this.ReportGrid.RowTemplate.Height = 25;
            this.ReportGrid.Size = new System.Drawing.Size(414, 470);
            this.ReportGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // ChoiceLBL
            // 
            this.ChoiceLBL.FormattingEnabled = true;
            this.ChoiceLBL.Location = new System.Drawing.Point(89, 201);
            this.ChoiceLBL.Name = "ChoiceLBL";
            this.ChoiceLBL.Size = new System.Drawing.Size(121, 23);
            this.ChoiceLBL.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(89, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmButton.Location = new System.Drawing.Point(89, 337);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(120, 49);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Location = new System.Drawing.Point(16, 506);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuButton.Location = new System.Drawing.Point(122, 506);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 9;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Usernumlbl
            // 
            this.Usernumlbl.AutoSize = true;
            this.Usernumlbl.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usernumlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Usernumlbl.Location = new System.Drawing.Point(669, 43);
            this.Usernumlbl.Name = "Usernumlbl";
            this.Usernumlbl.Size = new System.Drawing.Size(199, 25);
            this.Usernumlbl.TabIndex = 10;
            this.Usernumlbl.Text = "Number of Users: ";
            // 
            // NumberUserLBL
            // 
            this.NumberUserLBL.AutoSize = true;
            this.NumberUserLBL.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberUserLBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NumberUserLBL.Location = new System.Drawing.Point(669, 89);
            this.NumberUserLBL.Name = "NumberUserLBL";
            this.NumberUserLBL.Size = new System.Drawing.Size(0, 25);
            this.NumberUserLBL.TabIndex = 11;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(854, 541);
            this.Controls.Add(this.NumberUserLBL);
            this.Controls.Add(this.Usernumlbl);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChoiceLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReportGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox UsernameLBL;
        private Label label1;
        private DataGridView ReportGrid;
        private Label label2;
        private ComboBox ChoiceLBL;
        private Label label3;
        private Button ConfirmButton;
        private Button ExitButton;
        private Button MenuButton;
        private Label Usernumlbl;
        private Label NumberUserLBL;
    }
}