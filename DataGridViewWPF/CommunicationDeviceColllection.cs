using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewWPF
{
    class CommunicationDeviceColllection
    {
        List<CommunicationDevice> items;

        public CommunicationDeviceColllection()
        {
            items = new List<CommunicationDevice>();
        }

        public void Add(CommunicationDevice item)
        {
            items.Add(item);
        }

        /*
        public void Add(string Title, string Company, int Price)
        {
            CommunicationDevice item = new CommunicationDevice { Title = Title, Company = Company, Price = Price };

            items.Add(item);
        }
        */

        public string DisplayItems()
        {
            string content = "";
            
            foreach (var item in items)
            {
                content = content + item.Display();
            }

            return content;
        }



    }
}
