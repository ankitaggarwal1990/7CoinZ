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
    public partial class send_bitcoin : Form
    {
        //ICryptocoinService bitcoinService = new CryptocoinService("http://162.213.252.66:18332/", "test", "test123", "qwe");

        ICryptocoinService bitcoinService = new CryptocoinService("http://198.54.119.56:36345//", "bitcoinrpc", "GrvHKju9oLg6Kw", "qwe");
        decimal amount;
        string username;
        public send_bitcoin(string a)
        {
            InitializeComponent();
            cancel_button.BackColor = Color.CornflowerBlue;
            send.BackColor = Color.CornflowerBlue;

            cancel_button.ForeColor = Color.White;
            send.ForeColor = Color.White;

            username = a;
            amount = bitcoinService.GetBalance(a);
        }       

        private void send_Click(object sender, EventArgs e)
        {
            if (address_textBox.Text == "" && amount_numericUpDown.Value == 0)
            {
                error_label.Text = "Please enter the fields!";

            }
            else
            {
                
                
                var a = bitcoinService.ValidateAddress(address_textBox.Text);
                int minConf = 1;
                Console.WriteLine(a);
                if (a.IsValid == true)
                {
                    if (amount_numericUpDown.Value <= amount && amount_numericUpDown.Value != 0)
                    {
                        decimal b = Convert.ToDecimal(amount_numericUpDown.Value);
                        //string send_amount = address_textBox.Text;
                       // bitcoinService.SendToAddress(address_textBox.Text, b, null, null);
                        bitcoinService.SendFrom(username, address_textBox.Text, b, minConf, "", "");

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void address_textBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Text = "";
        }

        private void amount_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            error_label.Text = "";
        }
    }
}
