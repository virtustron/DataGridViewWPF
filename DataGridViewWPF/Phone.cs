using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewWPF
{
    public class Phone
    {
        private string title;
        
        public string Title 
        {
            get
            {
                return title;
            }

            set
            {
                if (value == "")
                {
                    title = "Noname";
                }
                else
                {
                    title = value;
                }
            }
        }
        public string Company { get; set; }
        public int Price { get; set; }
    }
}
