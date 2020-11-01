using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            partsGrid.DataSource = Inventory.AllParts;
            productsGrid.DataSource = Inventory.Products;
            PresetPartsAndProducts();
            
        }

        private void PresetPartsAndProducts()
        {
            Inventory.AllParts.Add(new InHouse(1, "Wheel", 19.99m, 13, 5, 20, 4));
            Inventory.AllParts.Add(new InHouse(2, "Seat", 25.99m, 4, 2, 10, 2));
            Inventory.AllParts.Add(new InHouse(3, "Chain", 11.99m, 18, 5, 20, 7));


        }

        private void AddPart_Click(object sender, EventArgs e)
        {

            AddPartScreen addPartScreen = new AddPartScreen();
            addPartScreen.ShowDialog();

        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            InHouse inhousePart = (InHouse)partsGrid.CurrentRow.DataBoundItem;
            new ModifyPartScreen(inhousePart).ShowDialog();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen();
            addProductScreen.ShowDialog();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            ModifyProductScreen modifyProductScreen = new ModifyProductScreen();
            modifyProductScreen.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deletePart_Click(object sender, EventArgs e)
        { 

            partsGrid.Rows.RemoveAt(partsGrid.CurrentCell.RowIndex);
        }
    }
}
