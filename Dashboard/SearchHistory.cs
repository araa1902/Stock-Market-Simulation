using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOCKUI2
{
    internal class SearchHistory
    {
        private List<string> History;

        public SearchHistory()
        {
            History = new List<string>();   
        
        }

        public List<string> ShowHistory()
        {
            List<string> items = new List<string>();
            foreach (var item in History)
            {
                items.Add(item);
            
            }

            return items;
            
        }

        public void AddSearch(string ticker)
        {
            
            History.Insert(0,ticker);
        
        }
    }




}
