using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BitcoinLib.Auxiliary;
using BitcoinLib.ExceptionHandling.Rpc;
using BitcoinLib.RPC.RequestResponse;
using BitcoinLib.RPC.Specifications;
using BitcoinLib.Services.Coins.Base;
using BitcoinLib.CoinParameters.Bitcoin;
using BitcoinLib.Services.Coins.Bitcoin;
using BitcoinLib.Services.Coins.Litecoin;
using BitcoinLib.Services.Coins.Dogecoin;
using BitcoinLib.Services.Coins.Cryptocoin;

namespace Coinroot
{
    public partial class send_bitcoincash : Form
    {
        public send_bitcoincash()
        {
            InitializeComponent();
            cancel_button.BackColor = Color.CornflowerBlue;
            send.BackColor = Color.CornflowerBlue;

            cancel_button.ForeColor = Color.White;
            send.ForeColor = Color.White;
        }

        

        private void send_Click_1(object sender, EventArgs e)
        {
            if (address_textBox.Text == "" && amount_numericUpDown.Value == 0)
            {
                error_label.Text = "Please enter the fields!";

            }
            else
            {
                IBitcoinService bitcoinService = new BitcoinService();
                var a = bitcoinService.ValidateAddress(address_textBox.Text);
                Console.WriteLine(a);
                if (a.IsValid == true)
                {
                    if (amount_numericUpDown.Value <= bitcoinService.GetBalance())
                    {
                        var b = Convert.ToDecimal(amount_numericUpDown.Value);
                        bitcoinService.SendToAddress(address_textBox.Text, b, null, null);
                        error_label.Text = "Send Successfully!";
                    }
                    else
                    {
                        error_label.Text = "Please enter valid amount !";
                    }

                }
                else
                {
                    error_label.Text = "Please enter a valid address!";
                }
            }
        }

        private void cancel_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
