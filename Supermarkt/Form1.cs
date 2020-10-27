using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarkt
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> shopingList = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {

            string articleName = getArticleName();
            int quantity = getQuantity();

            if (quantity > 0)
            {
                if (!shopingList.ContainsKey(articleName))
                    shopingList.Add(articleName, quantity);
                else
                    shopingList[articleName] += quantity;
            }

            UpdateShopingList();
        }

        private string getArticleName()
        {
            return tbArticle.Text;
        }

        private int getQuantity()
        {
            int quantity = 0;

            if (!int.TryParse(tbQuantity.Text, out quantity))
            {
                quantity = 0;
            }

            return quantity;
        }

        private void btRemoveProduct_Click(object sender, EventArgs e)
        {
            string articleName = getArticleName();
            int quantity = getQuantity();

            if (quantity < 0)
            {
                quantity = -quantity;
            }

            if (shopingList.ContainsKey(articleName))
            {
                if (true)
                {
                    if (shopingList[articleName] > quantity)
                    {
                        shopingList[articleName] -= quantity;
                    }
                    else
                    {
                        shopingList.Remove(articleName);
                    }
                }

            }

            UpdateShopingList();
        }

        private void UpdateShopingList()
        {
            lBoxShopingList.DataSource = new BindingSource(shopingList, null);
        }
    }
}
