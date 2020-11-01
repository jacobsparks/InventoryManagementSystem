using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class Outsourced : Part
    {
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {

        }
        public string CompanyName { get; set; }
    }
}
