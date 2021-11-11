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
    }
}
