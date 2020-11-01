using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace InventoryManagementSystem
{
    static class Inventory
    {

        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        



        
    }
}

