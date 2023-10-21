namespace STOCKUI2
{
    public partial class ObjectivesUI : Form
    {
        private ObjectiveList obj;
        public static string title; // Use of public static variables to hold the data of the selected objective to transfer to the next form in EditObjectives.
        public static string Description;
        public static string priority;
        public static DateTime deadline;
        public static bool status;
        private DateTime DATECHECKER;


        public ObjectivesUI()
        {
            obj = new ObjectiveList();
            InitializeComponent();
        }

        private void ObjectivesUI_Load(object sender, EventArgs e)
        {
            this.PriorityLBL.DropDownStyle = ComboBoxStyle.DropDownList;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (ObjectiveDB.CheckForObjectiveData()) // Only if a user has data present will it present any objectives - prevents exception
             {
                DisplayObjectives();
                
            }

            PriorityLBL.Items.Add("Critical");
            PriorityLBL.Items.Add("Moderate");
            PriorityLBL.Items.Add("Not Important");
            label5.Text = $"${TransactionDB.GetAccountBalance()}";

        }
        private void DisplayObjectives()
        {
            List<Objective> Objectives = obj.GetObjectives(); // Gets the list of objectives from the database
            foreach (Objective OBJECTIVE in Objectives)
            {
                obj.Enqueue(OBJECTIVE); // Enqueues the objectives into the priority queue.
            }
            
            List<Objective> menuObj = obj.ReturnOBJ(); // returns the objectives in the queue into another objective list
            int i = 0;
            foreach (Objective OBJECTIVE in menuObj)
            {
                if (!OBJECTIVE.GetStatus())
                {
                    string[] row = new string[] { OBJECTIVE.GetTitle(), OBJECTIVE.GetTask(), OBJECTIVE.GetStrPriority(), Convert.ToString(OBJECTIVE.GetDeadline()), Convert.ToString(OBJECTIVE.GetStatus()) };
                    ObjectiveViewer.Rows.Insert(i, row);
                    i++;

                }


            }
            ObjectiveViewer.Show();
            ObjectiveViewer.Visible = true;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleLBL.Text) || string.IsNullOrEmpty(DescriptionLBL.Text) || string.IsNullOrEmpty(DeadlineLBL.Text) || string.IsNullOrEmpty(PriorityLBL.Text))
            {
                MessageBox.Show("One or more fields are empty! ", "Error", MessageBoxButtons.OKCancel);
            
            
            }
            if (!DateTime.TryParse(DeadlineLBL.Text, out DATECHECKER)) // Tries parsing the input date to check if it is a valid date.
            {
                MessageBox.Show("Not a valid deadline, Please try Again");
            }
            else
            {
                try
                {

                    Objective OBJ = new Objective()
                    {
                        Title = TitleLBL.Text,
                        task = DescriptionLBL.Text,
                        Deadline = Convert.ToDateTime(DeadlineLBL.Text),
                        Status = false,
                        Priority = PriorityLBL.Text,

                    };
                    obj.AddObjective(OBJ);
                    MessageBox.Show("Objective Successfully Added", "Confirmed", MessageBoxButtons.OKCancel);
                    ObjectivesUI ui = new ObjectivesUI();
                    ui.Show();
                    this.Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Objective Unsuccessfully Added", "Error", MessageBoxButtons.OKCancel);

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ObjectiveViewer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Row hasn't been selected", "Error", MessageBoxButtons.OK);


            }
            else
            {
                if (ObjectiveViewer.Rows.Count > 0)
                {

                    DataGridViewRow selectedrow = ObjectiveViewer.SelectedRows[0]; // The selected row is collected to gather all info through an object
                    ObjectivesUI.title = selectedrow.Cells[0].Value.ToString(); //
                    ObjectivesUI.Description = selectedrow.Cells[1].Value.ToString();
                    ObjectivesUI.priority = selectedrow.Cells[2].Value.ToString();
                    ObjectivesUI.deadline = Convert.ToDateTime(selectedrow.Cells[3].Value);
                    ObjectivesUI.status = Convert.ToBoolean(selectedrow.Cells[4].Value);
                    EditObjectives editObj = new EditObjectives();
                    editObj.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("No Objective has been selected to edit. Please try again", "Error", MessageBoxButtons.OK);

                }

            }
       
            
         
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void PortfolioClick_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            this.Visible = false;
            form.Show();
        }

        private void PortfolioClick_Click_1(object sender, EventArgs e)
        {
            PortfolioPage form = new PortfolioPage();
            this.Visible = false;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeometricBrownianMotion form = new GeometricBrownianMotion();
            this.Visible = false;
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MinScreen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
