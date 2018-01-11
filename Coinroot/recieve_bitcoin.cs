using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;

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


using Zen.Barcode;




namespace Coinroot
{
    public partial class recieve_bitcoin : Form
    {
        public recieve_bitcoin(string A)
        {
            
            InitializeComponent();


            //ICryptocoinService bitcoinService = new CryptocoinService("http://162.213.252.66:18332/", "test", "test123", "qwe");
            ICryptocoinService bitcoinService = new CryptocoinService("http://198.54.119.56:36345//", "bitcoinrpc", "GrvHKju9oLg6Kw", "qwe");
            
            string a = bitcoinService.GetNewAddress(A);
            address_textBox.Text = a;

            pictureBox.Location = new Point(75, 30);
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox.Image = qrcode.Draw(a, 50);

        
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
