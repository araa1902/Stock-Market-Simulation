using System.Data;

namespace STOCKUI2
{
    public partial class GeometricBrownianMotion : Form
    {
        private API AC;
        public GeometricBrownianMotion()
        {
            InitializeComponent();
            AC = new API();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();
            this.Visible = false;

        }
        private void GeometricBrownianMotion_Load(object sender, EventArgs e)
        {
            

        }
        private async void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double Price = await AC.GetCurrentPrice(StockLBL.Text);
                if (Price == 0) // Checks if the ticker is valid from the API resposne.
                {
                    MessageBox.Show("Invalid Ticker", "Error", MessageBoxButtons.OKCancel);

                }
                else
                {
                    ReferencePrice.Text = Convert.ToString(Price);
                    PriceAtStart.Text = $"Price of {StockLBL.Text}: $";


                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Ticker or Invalid field", "Error", MessageBoxButtons.OKCancel);

            }

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool CheckValidFields()
        {
            if (SimNum.Value != 0 && DayNumLBL.Value != 0 && ReferencePrice.Text != null && Convert.ToDouble(VolatilityLBL.Text) > 0 && Convert.ToDouble(DriftLBL.Text) > 0 && Convert.ToDouble(VolatilityLBL.Text) <= 100 && Convert.ToDouble(DriftLBL.Text) <= 100 && VolatilityLBL.Text != null && DriftLBL.Text != null)
            {
                return true;
            }
            else
            {

                return false;
            }


        }
        private void button5_Click(object sender, EventArgs e)
        {
            SimulationTable.DataSource = null;
            SimulationTable.Rows.Clear();
            SimulationTable.Columns.Clear();
            if (CheckValidFields()) // Checks if fields entered are valid.
            {
                GenerateRandomNums randnums = new GenerateRandomNums(Convert.ToInt32(SimNum.Value), Convert.ToInt32(DayNumLBL.Value)); // Creates instance for generating the 2D random number array.
                double[,] RandomArray = randnums.RandomNumbersGeneration(); // Generates random numbers and assigns it to RandomArray
                SimulateGBM sim = new SimulateGBM(RandomArray, Convert.ToDouble(ReferencePrice.Text), Convert.ToDouble(VolatilityLBL.Text), Convert.ToDouble(DriftLBL.Text)); // Creates instance of simulation holding the user entered constants.
                sim.GBMSimulation(); // Simulates the brownian motion
                double[,] PRICES = sim.returnGBMSimulation(); // Returns Simulation results.
                DataTable table = new DataTable();

                table.Columns.Add("Sim Num", typeof(int));
                table.Columns.Add("Day", typeof(int));
                table.Columns.Add("Stock Price", typeof(double));
                double[] vals = new double[PRICES.Length];
               for (int i = 1; i < PRICES.GetLength(0); i++)
                {
                    for (int j = 0; j < PRICES.GetLength(1); j++)
                    {
                        table.Rows.Add(i + 1, j + 1, PRICES[i, j]);
                        vals[i] = PRICES[i, j];
                    }
                }
                
               StatsLabel.Text = $"Simulation Statistics for {StockLBL.Text}";
               SimulationTable.DataSource = table;

                

            }
            else
            {
                MessageBox.Show("Invalid Fields entered, Please try again", "Error", MessageBoxButtons.OKCancel);


            }




        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void GeometricBrownianMotion_Load_1(object sender, EventArgs e)
        {
           
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

