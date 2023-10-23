using Newtonsoft.Json;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace STOCKUI2
{

    internal class API 
    {
        
        private List<Values> values;
        private static readonly string API_FILEPATH = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\OneDrive - Bradford Grammar School\\Home Drive\\computer science\\Year 13 - Year 1\\NEA 10JAN\\testtttt\\NEA - 19DEC\\NEA\\API_KEY.txt";

        public API()
        {
            values = new List<Values>();

        }
        #region APICODE

        private static string GetAPI_KEY()
        {
            try
            {
                using (StreamReader reader = new StreamReader(API_FILEPATH, true))
                {

                    string path = reader.ReadLine();
                    return path;

                }

            }
            catch (Exception exception)
            {
                throw exception;

            }

        }
       
        public async Task<List<Values>> Prices(string ticker, string startdate, string enddate, string interval)
            // Used async methods and a task to utltise a separate thread just for the API response - provides quicker interface
        {
            HttpClient client = new HttpClient(); // Creates new client to link with web API  
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api.twelvedata.com/time_series?symbol={ticker}&start_date={startdate}&end_date={enddate}&interval={interval}&apikey={API.GetAPI_KEY()}&format=JSON"),
                // sends API request to retrieve stock data from API
            };
            using (var response = await client.SendAsync(request))
            {
                try
                {
                    response.EnsureSuccessStatusCode(); // checks if API request has sent data successfully
                    string JSON_response = await response.Content.ReadAsStringAsync(); // reads data as an asynchronous string
                    
                    JObject jobject = JObject.Parse(JSON_response); // Parses the string into JSON format for easy access of data.
                    // TEST IF ARRAY EMPTY
                    if (Convert.ToInt32(jobject["code"])  != 400)
                    {
                        foreach (var val in jobject["values"])
                        {

                            values.Add(new Values(Convert.ToString(val["datetime"]), Convert.ToDouble(val["high"]), Convert.ToDouble(val["low"]), Convert.ToDouble(val["open"]), Convert.ToDouble(val["close"]), Convert.ToDouble(val["previous_close"]), Convert.ToDouble(val["percent_change"])));
                            // Adds each data point over a data into the values list
                        }
                        return values;

                    }
                    else
                    {
                        return null;

                    }
                    
                   
                }
                catch (NullReferenceException e)
                {
                    
                    return null;
                    // Exception handling to check if user has entered a valid Stock ticker.
                }

            }
        }


        public async Task<List<Values>> StockStats(string ticker)
        {
            // Retrieves stock data at current day and time to be displayed on dashboard to user. Again using async methods and Task threading to improve user experience.
            try
            {
                HttpClient client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://api.twelvedata.com/quote?symbol={ticker}&apikey={API.GetAPI_KEY()}"),

                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var JSON_response = await response.Content.ReadAsStringAsync();
                    JObject jobject = JObject.Parse(JSON_response);
                    if (Convert.ToInt32(jobject["code"]) != 400)
                    {
                        values.Add(new Values(Convert.ToString(jobject["datetime"]), Convert.ToDouble(jobject["high"]), Convert.ToDouble(jobject["low"]), Convert.ToDouble(jobject["open"]), Convert.ToDouble(jobject["close"]), Convert.ToDouble(jobject["previous_close"]), Convert.ToDouble(jobject["percent_change"])));
                        return values;

                    }
                    else
                    {
                        return null;
                    }
                    
                }

            }
            catch (Exception exc)
            { 
                MessageBox.Show("Unable to Retrieve Stock Stats", "error", MessageBoxButtons.OKCancel);
                return null;
            }
           

        }

        public virtual List<string> Initalise_timeseries(List<string> timeseries, string intervaltype, int option)
            // Method Virtual to connect with Trends class to override method to create different time range.
        {
            // Creates a set of two dates to create a start and end to retrieve stock data from specified dates. Adds dates to 
            try
            {
                string dateTime = DateTime.Now.ToString();
                string now = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                if (intervaltype == "month" && option > 0)
                {
                    var minustime = DateTime.Today.AddMonths(-option);
                    string time = Convert.ToDateTime(minustime).ToString("yyyy-MM-dd");
                    timeseries.Add(now);
                    timeseries.Add(time);
                    return timeseries;
                }

                else if (intervaltype == "day" && option > 0)
                {
                    var minustime = DateTime.Today.AddDays(-option);
                    string time = Convert.ToDateTime(minustime).ToString("yyyy-MM-dd");
                    timeseries.Add(now);
                    timeseries.Add(time);
                    return timeseries;
                }
                else
                {
                    return null;
                
                }



            }
            catch (NullReferenceException ex)
            {
                return null;
            }
            
            
            
        }

        public async Task<double> GetCurrentPrice(string ticker)
        {
            // Gets current price of a ticker which is used in the buying and selling of stocks and used in the Geometric Brownian Motion of stocks.
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api.twelvedata.com/price?symbol={ticker}&apikey={API.GetAPI_KEY()}&format=JSON"),

            };
            using (var response = await client.SendAsync(request))
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    JObject jobject = JObject.Parse(body);
                    double Current_price = Convert.ToDouble(jobject["price"]);
                    return Current_price;


                }
                catch (Exception exc)
                {
                    return 0;
                
                }
                
            }

        }

        public async Task<string> Get_Name(string ticker)
        {
            // Retrieves Full name of company given the ticker

            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api.twelvedata.com/quote?symbol={ticker}&apikey={GetAPI_KEY()}&format=JSON"),

            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject jobject = JObject.Parse(body); // Parses JSON
                string FullName = Convert.ToString(jobject["name"]);
                return FullName;
            }

        }
        #endregion
    }

    public class Values
    {
        private string date;
        private double high;
        private double low;
        private double open;
        private double close;
        private double PreviousClose;
        private double PercentChange;

        public Values(string date, double high, double low, double open, double close, double PreviousClose, double PercentChange)
        {
            this.date = date;
            this.high = high;
            this.low = low;
            this.open = open;
            this.close = close;
            this.PercentChange = PercentChange;
            this.PreviousClose = PreviousClose;

        }
        public Values()
        {



        }
        // Using encapsulation to keep the properties private but created public methods to retrieve information
        public string GetDate()
        {
            return date;


        }
        public double GetHigh()
        {
            return high;

        }
        public double GetLow()
        {
            return low;

        }
        public double GetOpen()
        {
            return open;

        }
        public double GetClose()
        {
            return close;

        }

        public double GetPreviousClose()
        {
            return PreviousClose;

        }

        public double GetPercentChange()
        {
            return PercentChange;

        }

    }

    





}

