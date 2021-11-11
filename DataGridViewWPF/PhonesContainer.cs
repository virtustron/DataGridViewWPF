using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewWPF
{
    class PhonesContainer
    {
        List<Phone> items;

        public PhonesContainer()
        {
            items = new List<Phone>();
        }


        public void Add(string Title, string Company, int Price)
        {
            Phone PhoneToAdd = new Phone { Title = Title, Company = Company, Price = Price };

            items.Add(PhoneToAdd);
        }

        public void Add(Phone PhoneToAdd)
        {
            items.Add(PhoneToAdd);
        }

    }
}
