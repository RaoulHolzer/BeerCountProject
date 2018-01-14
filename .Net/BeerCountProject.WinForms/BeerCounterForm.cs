using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerCountProject.WinForms
{
    public partial class BeerCountForm : Form
    {
        public BeerCountForm()
        {
            InitializeComponent();
        }
        private void betnAddNewBeer_Click(object sender, EventArgs e)
        {
            var priceText = tbPrice.Text;
            decimal.TryParse(priceText, out decimal price);
            new Beer(price);
        }
    }
}
