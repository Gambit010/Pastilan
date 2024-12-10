using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastilPOS
{
    public partial class Order : Form
    {
        private List<string> addedProducts = new List<string>(); // To keep track of added products
        private decimal totalPrice = 0;

        public Order()
        {
            InitializeComponent();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            nuggetsQuantity.Enabled = true;
            lumpiaQuantity.Enabled = true;
            eggQuantity.Enabled = true;
            C2.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
        }

        private void C2_Click(object sender, EventArgs e)
        {
            nuggetsQuantity.Enabled = true;
            lumpiaQuantity.Enabled = true;
            eggQuantity.Enabled = true;
            C1.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            nuggetsQuantity.Enabled = true;
            lumpiaQuantity.Enabled = true;
            eggQuantity.Enabled = true;
            C2.Enabled = false;
            C1.Enabled = false;
            B2.Enabled = false;

        }

        private void B2_Click(object sender, EventArgs e)
        {
            nuggetsQuantity.Enabled = true;
            lumpiaQuantity.Enabled = true;
            eggQuantity.Enabled = true;
            C2.Enabled = false;
            B1.Enabled = false;
            C1.Enabled = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            nuggetsQuantity.Enabled = false;
            lumpiaQuantity.Enabled = false;
            eggQuantity.Enabled = false;
            C1.Enabled = true;
            C2.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            nuggetsQuantity.Value = 0;
            lumpiaQuantity.Value = 0;
            eggQuantity.Value = 0;
            extrariceQuantity.Value = 0;
        }

        private void addOrder_Click(object sender, EventArgs e)
        {        

        }

        private void proceedToCheckout_Click(object sender, EventArgs e)
        {
           
        }
    }
}
