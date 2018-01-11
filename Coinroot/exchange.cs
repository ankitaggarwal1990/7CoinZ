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
//using Rock
using System.Net;
//using Newtonsoft.Json;

namespace Coinroot
{
    public partial class exchange : Form
    {
        public exchange()
        {
            InitializeComponent();
            exchange_comboBox.Items.Add("Bitcoin");
            exchange_comboBox.Items.Add("Bitcoin Cash");
            exchange_comboBox.Items.Add("Litecoin");
            exchange_comboBox.Items.Add("Dogecoin");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exchange_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            IBitcoinService bitcoinService = new BitcoinService();
            ILitecoinService litecoinService = new LitecoinService();
            IDogecoinService dogecoinService = new DogecoinService();

            if (exchange_comboBox.Text == "Bitcoin")
            {
                recieve_comboBox.Items.Clear();
                recieve_comboBox.Items.Add("Bitcoin Cash");
                recieve_comboBox.Items.Add("Litecoin");
                recieve_comboBox.Items.Add("Dogecoin");

                exchange_unit_label.Text = "btc";

                var bitcoin_balance = bitcoinService.GetBalance();
                exchange_label.Text = bitcoin_balance.ToString("0.000000");
                
            }
            else if (exchange_comboBox.Text == "Bitcoin Cash")
            {
                recieve_comboBox.Items.Clear();
                recieve_comboBox.Items.Add("Bitcoin");
                recieve_comboBox.Items.Add("Litecoin");
                recieve_comboBox.Items.Add("Dogecoin");

                exchange_unit_label.Text = "bch";
                var bitcoin_balance = bitcoinService.GetBalance();
                exchange_label.Text = bitcoin_balance.ToString("0.000000");
            }
            else if (exchange_comboBox.Text == "Litecoin")
            {
                recieve_comboBox.Items.Clear();
                recieve_comboBox.Items.Add("Bitcoin");
                recieve_comboBox.Items.Add("Bitcoin Cash");           
                recieve_comboBox.Items.Add("Dogecoin");

                exchange_unit_label.Text = "ltc";

                var litecoin_balance = litecoinService.GetBalance();
                exchange_label.Text = litecoin_balance.ToString("0.000000");
            }
            else if (exchange_comboBox.Text == "Dogecoin")
            {
                recieve_comboBox.Items.Clear();
                recieve_comboBox.Items.Add("Bitcoin");
                recieve_comboBox.Items.Add("Bitcoin Cash");
                recieve_comboBox.Items.Add("Litecoin");

                exchange_unit_label.Text = "doge";

                var dogecoin_balance = dogecoinService.GetBalance();
                exchange_label.Text = dogecoin_balance.ToString("0.000000");
               
            }
        }

        private void recieve_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IBitcoinService bitcoinService = new BitcoinService();
            ILitecoinService litecoinService = new LitecoinService();
            IDogecoinService dogecoinService = new DogecoinService();

            if (recieve_comboBox.Text == "Bitcoin")
            {
                recieve_unit_label.Text = "btc";
                var bitcoin_balance = bitcoinService.GetBalance();
                recieve_label.Text = bitcoin_balance.ToString("0.000000");
            }
            else if (recieve_comboBox.Text == "Bitcoin Cash")
            {
                recieve_unit_label.Text = "bch";
                var bitcoin_balance = bitcoinService.GetBalance();
                recieve_label.Text = bitcoin_balance.ToString("0.000000");
            }
            else if (recieve_comboBox.Text == "Litecoin")
            {
                recieve_unit_label.Text = "ltc";
                var litecoin_balance = litecoinService.GetBalance();
                recieve_label.Text = litecoin_balance.ToString("0.000000");
                
            }
            else if (recieve_comboBox.Text == "Dogecoin")
            {
                recieve_unit_label.Text = "doge";
                var dogecoin_balance = dogecoinService.GetBalance();
                recieve_label.Text = dogecoin_balance.ToString("0.000000");

            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            WebClient client = new WebClient();
            string myJSON = client.DownloadString("https://shapeshift.io/marketinfo/"+exchange_unit_label.Text+"_"+recieve_unit_label.Text);

            //myJSON.    myJSON.p

           // dynamic a = Json.JsonParser.Deserialize(myJSON);
           // double rate = a.rate;
            //Console.WriteLine(rate);
            Console.WriteLine("ankit");
            Console.WriteLine(myJSON);

            //var myClass = Newtonsoft.Json.JsonConvert.DeserializeObject(myJSON);
          //  double value = Convert.ToDouble(numericUpDown1.Value) * rate;

            //recieve_textBox.Text = value.ToString();
            
        }

        private void exchange_button_Click(object sender, EventArgs e)
        {
            IBitcoinService bitcoinService = new BitcoinService();
             WebClient client = new WebClient();
            var reqparm = new System.Collections.Specialized.NameValueCollection();
            reqparm.Add("amount", numericUpDown1.Value.ToString());
            reqparm.Add("withdrawal", bitcoinService.GetNewAddress());
            reqparm.Add("pair", exchange_unit_label.Text+"_"+recieve_unit_label.Text);
           // reqparm.Add("returnAddress", "escaping is already handled");
            byte[] responsebytes = client.UploadValues("https://shapeshift.io/sendamount", "POST", reqparm);
            string responsebody = Encoding.UTF8.GetString(responsebytes);

            Console.WriteLine(responsebody);
           // dynamic a = Json.JsonParser.Deserialize(responsebody);
           // string error = a.error;
           // Console.WriteLine(error);
        }
    }
}
