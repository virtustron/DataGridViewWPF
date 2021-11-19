using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewWPF
{
    class Phone : CommunicationDevice
    {
        
        
        //public bool QwertyKeyboard { get; set; }

        public override string Display()
        {
            string content = "";
            //content = this.Title + "; " + this.Company + "; " + this.Price.ToString() + "; " + this.QwertyKeyboard.ToString();

            return content;

        }
        
    }
}
