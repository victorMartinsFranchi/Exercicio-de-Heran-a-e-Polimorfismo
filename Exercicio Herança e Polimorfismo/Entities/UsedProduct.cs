using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Herança_e_Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            string pricetag = Name + " (used) $ " + Price.ToString("F2") + " (Manufacture Date: " +
                 ManufactureDate.ToString("dd/MM/yyyy") + ")";
            return pricetag;
        }

    }
}
