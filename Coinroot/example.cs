using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coinroot
{
    public partial class example : Form
    {
        public example()
        {
            InitializeComponent();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            wallet_panel.Visible = false;
            exchange_panel.Visible = false;
        }

        private void wallet_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            exchange_panel.Visible = false;
            wallet_panel.Visible = true;
            exchange_panel.Visible = false;
        }

        private void exchange_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            wallet_panel.Visible = false;
            exchange_panel.Visible = true;
            wallet_panel.Visible = false;
        }
    }
}
