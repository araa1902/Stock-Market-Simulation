using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;

namespace STOCKUI2
{
    public partial class Dashboard : Form
    {

        List<string> LIST = new List<string>();
        private SearchHistory history;



        public Dashboard()
        {

            history = new SearchHistory();
            InitializeComponent();
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SearchHistoryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.TypeButton.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeButton.Items.Add("day");
            TypeButton.Items.Add("month");
            label5.Text = Convert.ToString($"${Math.Round(TransactionDB.GetAccountBalance(), 2)}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {



        }

        private async void button5_Click(object sender, EventArgs e)
        {


        }

        private async void label5_Click(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {

        }



        private void formsPlot2_Load(object sender, EventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TestObj_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            PortfolioPage pg = new PortfolioPage();
            pg.Show();

            this.Visible = false;

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void MaxScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            MaxScreen.Visible = false;
            MaxScreen.Location = MaxScreen.Location;
            MaxScreen.Visible = true;
        }

        private void MinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            MinScreen.Visible = false;
            MinScreen.Location = MinScreen.Location;
            MinScreen.Visible = true;
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            
            StockLabel.ForeColor = Color.White;

            try
            {
                
                cartesianChart1.TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Bottom;
                cartesianChart1.LegendTextSize = 1;
                cartesianChart1.AnimationsSpeed = TimeSpan.FromMilliseconds(500);
                
                string ticker = StockLabel.Text; 
                try
                {

                    API api = new API(); // Creates new instance of API
                    
                        List<Values> values = await api.StockStats(ticker); // Retrieves the current statistics for the stock entered
                        List<string> times = new List<string>();

                        if (values != null)
                        {

                            times = api.Initalise_timeseries(times, TypeButton.Text, Convert.ToInt32(DurationUpDown.Text)); // initalises the times
                            if (times != null)
                            {
                                List<Values> PriceData = new List<Values>(); // Creates a list of values to provide a container for the historical stock data.
                                PriceData = await api.Prices(ticker, times[1], times[0], $"1{TypeButton.Text}"); // Makes API retrieval response
                                cartesianChart1.Refresh();

                                double[] prices = new double[PriceData.Count]; // Creates an array to hold the Stock Price data points

                                for (int i = 0; i < prices.Length; i++)
                                {
                                    prices[i] = Math.Round(PriceData[i].GetClose()); // Adds each data point from the API response into the array.
                                }
                                cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;

                                cartesianChart1.TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Bottom;

                                cartesianChart1.Series = new ISeries[]
                                {
                                new LineSeries<double>
                                {
                                    Name = "Price",
                                    LineSmoothness = 1,
                                    DataLabelsSize = 0.10,
                                    LegendShapeSize = 0,
                                    Values = prices,
                                    IsVisibleAtLegend = true,
                                    Fill = null,
                                }

                                };




                                foreach (Values vals in values)
                                {
                                    DisplayHighPrice.Text = $"${Convert.ToString(Math.Round(vals.GetHigh(), 2))}"; // For each stock, it will display the current main data points, e.g. high
                                    DisplayClose.Text = $"${Convert.ToString(Math.Round(vals.GetClose(), 2))}";
                                    DisplayOpen.Text = $"${Convert.ToString(Math.Round(vals.GetOpen(), 2))}";
                                    DisplayLowPrice.Text = $"${Convert.ToString(Math.Round(vals.GetLow(), 2))}";
                                    DisplayPerChange.Text = $"{Convert.ToString(Math.Round(vals.GetPercentChange(), 2))}%";
                                    DisplayPrevClose.Text = $"${Convert.ToString(Math.Round(vals.GetPreviousClose(), 2))}";

                                }



                                history.AddSearch(ticker); // Adds each ticker search to the history stack object
                                LIST = history.ShowHistory(); // Adds each item from stack to List 
                                SearchHistoryBox.Items.Clear();
                                foreach (var item in LIST)
                                {
                                    SearchHistoryBox.Items.Add(item); // Adds each search to search box list.

                                }

                                List<Values> Prices = new List<Values>(); // Creates new list object holding prices used for MACD algorithm
                                List<string> TIMES = new List<string>();
                                Trends trend = new Trends(Prices); // Creates new instance of Trends that inputs price data.
                                times = trend.Initalise_timeseries(TIMES, "day", 100); // Initialises the times.
                                Prices = await api.Prices(StockLabel.Text, TIMES[1], TIMES[0], "1day");
                                Decision result = Trends.BuyOrSell(Prices); // Creates Decision Object which holds the outcome of the MACD algorithm
                                double confidence = Trends.FindPercentConfidence(Trends.GetMACDval(Prices));
                                if (result == Decision.Buy)
                                {
                                    DecisionLabel.ForeColor = Color.IndianRed;
                                    DecisionLabel.Text = "BUY";
                                    PercentageConfidenceLBL.Text = $"{Math.Round(confidence, 2)}%";
                                }
                                else if (result == Decision.Sell)
                                {
                                    DecisionLabel.ForeColor = Color.LawnGreen;
                                    DecisionLabel.Text = "SELL";
                                    PercentageConfidenceLBL.Text = $"{Math.Round(confidence, 2)}%";

                                }
                                else
                                {
                                    DecisionLabel.Text = "HOLD";
                                    PercentageConfidenceLBL.Text = $"{Math.Round(confidence, 2)}%";

                                }


                            }
                            else
                            {
                                MessageBox.Show("Times are not inputted correctly", "Error", MessageBoxButtons.OKCancel);

                            }

                        }
                        else
                        {
                            MessageBox.Show("Ticker field is invalid", "Cannot produce stock infomation", MessageBoxButtons.OK);

                        }
                          
                }
                catch (System.NullReferenceException ex)
                {
                    MessageBox.Show("Unable to retrieve stock data for ticker. One or more fields may be empty", "Error", MessageBoxButtons.OKCancel);

                }
                



            }

            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Invalid Ticker or Invalid field", "Error", MessageBoxButtons.OKCancel);


            }





        }
        private void MakeChart(double[] prices)
        {



        }
        private void HighLbl_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ObjectivesUI objUI = new ObjectivesUI();
            objUI.Show();
            this.Visible = false;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {   int quantity = Convert.ToInt32(QuantityTEXTBOX.Text);
                if (quantity != 0)
                {
                    Order order = new Order(TickerBuyTextBox.Text, Convert.ToInt32(QuantityTEXTBOX.Text), DateTime.Now, "BUY"); // Dynamic Generation of Object
                    DialogResult d = MessageBox.Show($"Would you like to make this payment?", "WARNING", MessageBoxButtons.YesNo); // Creates Object to be the result of warning label
                    if (d == DialogResult.Yes)
                    {

                        Transactions transaction = new Transactions(order); // Creates transaction object to hold the order.
                        transaction.MakeTransaction();
                        Refresh();
                        Dashboard form = new Dashboard();
                        form.Show();
                        this.Visible = false;
                    }

                } 
               
                else
                {
                    MessageBox.Show("Transaction Failed. Quantity cannot be 0", "Error", MessageBoxButtons.OKCancel);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction Failed. Invalid Ticker", "Error", MessageBoxButtons.OKCancel);
            
            }
            


        }

        private async void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeometricBrownianMotion gbm = new GeometricBrownianMotion();
            gbm.Show();
            this.Visible = false;

        }

        private void defaultLegend1_Load(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_Load_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            WelcomePage pg = new WelcomePage();
            pg.Show();
            this.Visible = false;
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (SearchHistoryBox.Text != null && TypeButton.Text != null && Convert.ToInt32(DurationUpDown.Text) != 0)
                {
                    API api = new API();
                    string ticker = SearchHistoryBox.Text; // FIX DAY TIMESERIES OPTION
                    List<string> times = new List<string>();
                    times = api.Initalise_timeseries(times, TypeButton.Text, Convert.ToInt32(QuantityTEXTBOX.Text));
                    List<Values> PriceData = await api.Prices(ticker, times[1], times[0], $"1{TypeButton.Text}"); 
                    List<Values> values = await api.StockStats(ticker);
                    double[] prices = new double[PriceData.Count];
                    for (int i = 0; i < prices.Length; i++)
                    {
                        prices[i] = Math.Round(PriceData[i].GetClose());
                    }


                    cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
                    cartesianChart1.BorderStyle = BorderStyle.Fixed3D;

                    cartesianChart1.TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Bottom;

                    cartesianChart1.Series = new ISeries[]
                    {
                    new LineSeries<double>
                    {
                        Values = prices,
                        IsVisibleAtLegend = true,
                        Fill = null

                    }
                    };
                    foreach (Values vals in values)
                    {
                        DisplayHighPrice.Text = $"${Convert.ToString(Math.Round(vals.GetHigh(), 2))}";
                        DisplayClose.Text = $"${Convert.ToString(Math.Round(vals.GetClose(), 2))}";
                        DisplayOpen.Text = $"${Convert.ToString(Math.Round(vals.GetOpen(), 2))}";
                        DisplayLowPrice.Text = $"${Convert.ToString(Math.Round(vals.GetLow(), 2))}";
                        DisplayPerChange.Text = $"{Convert.ToString(Math.Round(vals.GetPercentChange(), 2))}%";
                        DisplayPrevClose.Text = $"${Convert.ToString(Math.Round(vals.GetPreviousClose(), 2))}";

                    }
                }
                else
                {

                    MessageBox.Show("Unable to retrieve stock data for ticker", "Error", MessageBoxButtons.OKCancel);

                }


            }catch(NullReferenceException exc)
            {
                MessageBox.Show("Search History field is missing");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockLabel.Text = SearchHistoryBox.SelectedItem.ToString();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}