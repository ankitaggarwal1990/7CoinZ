using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

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
//using NBitcoin.BitcoinCore;

//using OpenWebClient;
//using Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace Coinroot
{
    public partial class Form1 : Form
    {
        //Form2 settingsForm = new Form2();
        
        
       //private string address;
        //IBitcoinService bitcoinService = new BitcoinService();
        //ICryptocoinService bitcoinService = new CryptocoinService("http://162.213.252.66:18332/", "test", "test123", "qwe");

        ICryptocoinService bitcoinService = new CryptocoinService("http://198.54.119.56:36345//", "bitcoinrpc", "GrvHKju9oLg6Kw", "qwe");
        string username;
        
        public Form1()
        {
           



            //this.BackColor = Color.Azure;
            InitializeComponent();
            //home_panel.BackColor = Color.Azure;
            //wallet_panel.BackColor = Color.Azure;
            //exchange_panel.BackColor = Color.Azure;

            //panel2.BackColor = Color.Azure;

            home_panel.Dock = DockStyle.Fill;

            //panel3.Visible = false;
            //panel4.Visible = false;
            home_panel.Visible = true;
            //home_panel.Visible = false;
            wallet_panel.Visible = false;
            //exchange_panel.Visible = false;

            home_button.FlatAppearance.BorderSize = 0;
            wallet_button.FlatAppearance.BorderSize = 0;
            //exchange_button.FlatAppearance.BorderSize = 0;

            home_button.Hide();
            wallet_button.Hide();

            home_button.Image = Properties.Resources.home__2_;//Image.FromFile("C:\\Graphics\\My.ico");
            home_button.BackgroundImage = Properties.Resources.circle4;
            
            // Align the image and text on the button.
            //home_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F2D5E");
            //home_button.Text = "HOME";
            home_button.ImageAlign = ContentAlignment.MiddleCenter;
            //home_button.TextAlign = ContentAlignment.BottomCenter;

            wallet_button.Image = Properties.Resources.wallet_1;//Image.FromFile("C:\\Graphics\\My.ico");
            // Align the image and text on the button.
            wallet_button.ImageAlign = ContentAlignment.MiddleCenter;
           // wallet_button.TextAlign = ContentAlignment.MiddleCenter;

            //exchange_button.Image = Properties.Resources.exchange__1_;//Image.FromFile("C:\\Graphics\\My.ico");
            // Align the image and text on the button.
            //exchange_button.ImageAlign = ContentAlignment.MiddleCenter;
           // exchange_button.TextAlign = ContentAlignment.MiddleCenter;





            bitcoin_balance_wallet_label.Location = new Point(230,75);
            //bitcoin_balance_wallet_label.Hide();
            label_1.Hide();


            send_bitcoin_button.Location = new Point(150, 190);
            recieve_bitcoin_button.Location = new Point(450, 190);

            
            bitcoin_listView.Location = new System.Drawing.Point(0, 350);
            //bitcoin_listView.Name = "ListView1";
            bitcoin_listView.Size = new System.Drawing.Size(706, 250);
            
            //bitcoin_listView.BackColor = System.Drawing.Color.White;
            bitcoin_listView.ForeColor = System.Drawing.Color.Black;

            
            
            

            


            //bitcoin_pictureBox.Location = new Point(235,150);
            label_1.Location = new Point(290,270);
            bitcoin_home_label.Location = new Point(270,300);


            bitcoin_home_label.Hide();

            

            home_logo_pictureBox.Location = new Point(290,90);
            username_label.Location = new Point(300,215);
            username_textBox.Location = new Point(265,240);
            password_label.Location = new Point(300,300);
            password_textBox.Location = new Point(265,325);
            signin_button.Location = new Point(320,400);
            signup_label.Location = new Point(280,500);
            error_label.Location = new Point(290, 365);


            /*try
            {
                var bitcoin_Balance = bitcoinService.GetBalance();
                bitcoin_home_label.Text = bitcoin_Balance.ToString("0.000000") + " VCN";
            }
            catch (RpcException e)
            {
                Console.WriteLine(e);
                bitcoin_home_label.Text = "Not Connected";
                Console.WriteLine("Not connected");
            }  */          
        }


        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            send_bitcoin f2 = new send_bitcoin(username);
            f2.ShowDialog(); // Shows Form2
        }

        private void recieve_bitcoin_button_Click(object sender, EventArgs e)
        {
            recieve_bitcoin f3 = new recieve_bitcoin(username);
            f3.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            wallet_panel.Visible = false;
            //exchange_panel.Visible = false;

            home_panel.Dock = DockStyle.Fill;


            home_button.Image = Properties.Resources.home_1;
            home_button.BackgroundImage = Properties.Resources.circle4;
            //home_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F2D5E");
            home_button.ImageAlign = ContentAlignment.MiddleCenter;

            wallet_button.Image = Properties.Resources.wallet_1;
            wallet_button.BackgroundImage = Properties.Resources.strip;
            //home_button.BackgroundImage = Properties.Resources.
            //wallet_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#1C1F26");
            wallet_button.ImageAlign = ContentAlignment.MiddleCenter;

            

            try
            {
                var bitcoin_Balance = bitcoinService.GetBalance(username,1,null);
                bitcoin_home_label.Text = bitcoin_Balance.ToString("0.000000") + " 7CZ";    

            }
            catch (RpcException e1)
            {

                Console.WriteLine(e1);
                bitcoin_home_label.Text = "Not Connected";
                

                Console.WriteLine("Not connected");
            }
        }

        private void wallet_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            wallet_panel.Visible = true;
           // exchange_panel.Visible = false;

            

            wallet_panel.Dock = DockStyle.Fill;


            bitcoin_wallet_panel.Visible = true;
            


            bitcoin_wallet_panel.Dock = DockStyle.Fill;




            home_button.Image = Properties.Resources.home_2;
            home_button.BackgroundImage = Properties.Resources.strip;
            home_button.ImageAlign = ContentAlignment.MiddleCenter;

            wallet_button.Image = Properties.Resources.wallet_1;
            wallet_button.BackgroundImage = Properties.Resources.circle4;
            //wallet_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F2D5E");
            wallet_button.ImageAlign = ContentAlignment.MiddleCenter;

           

            
            



            //send_bitcoin_button.Location = new Point(150, 150);
            //recieve_bitcoin_button.Location = new Point(450, 150);
            bitcoin_listView.Clear();


            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[0].Text = "Date";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[1].Text = "Address";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[2].Text = "Type";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[3].Text = "Amount";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[4].Text = "Confirmation";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[5].Text = "Tx";


            try
            {
                var bitcoin_Balance = bitcoinService.GetBalance(username,1,null);

                bitcoin_balance_wallet_label.Text = bitcoin_Balance.ToString("0.000000") + " 7CZ";

                List<BitcoinLib.Responses.ListTransactionsResponse> a = new List<BitcoinLib.Responses.ListTransactionsResponse>();
                a = bitcoinService.ListTransactions(username, 10, 0, null);


                for (var i = 0; i < a.Count; i++)
                {
                    TimeSpan time = TimeSpan.FromSeconds(a[i].Time);
                    string[] row = { DateTime.Today.Add(time).ToString("HH:mm:ss"), a[i].Address, a[i].Category, a[i].Amount.ToString(), a[i].Confirmations.ToString(), a[i].TxId };
                    var listViewItem = new ListViewItem(row);
                    bitcoin_listView.Items.Add(listViewItem);
                }  


            }
            catch
            {
                bitcoin_balance_wallet_label.Text = "Not Connected";
            }
            
                     
        }

        private void exchange_button_Click(object sender, EventArgs e)
        {
            home_panel.Visible = false;
            wallet_panel.Visible = false;
            //exchange_panel.Visible = true;

            //exchange_panel.Dock = DockStyle.Fill;

            home_button.Image = Properties.Resources.home12;
            home_button.BackColor = Color.White;
            home_button.ImageAlign = ContentAlignment.MiddleCenter;

            wallet_button.Image = Properties.Resources.wallet__1_;
            wallet_button.BackColor = Color.White;
            wallet_button.ImageAlign = ContentAlignment.MiddleCenter;

            
            

            //exchange_comboBox.Update = "Bitcoin";
            //exchange1_label.Text = bitcoincash_home_label
            //exchange_unit_label.Text = "btc";



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            recieve_litecoin f5 = new recieve_litecoin();
            f5.ShowDialog();

        }

        private void Send_bitcoincash_button_Click(object sender, EventArgs e)
        {
            send_bitcoincash f2 = new send_bitcoincash();
            f2.ShowDialog(); // Shows Form2

        }

        private void recieve_bitcoincash_button_Click(object sender, EventArgs e)
        {
            recieve_bitcoincash F3 = new recieve_bitcoincash();
            F3.ShowDialog();

        }

        private void Send_litecoincash_button_Click(object sender, EventArgs e)
        {
            send_litecoin f6 = new send_litecoin();
            
            f6.ShowDialog();


        }

        private void Send_dogecoincash_button_Click(object sender, EventArgs e)
        {
            send_dogecoin f7 = new send_dogecoin();
            f7.ShowDialog();

        }

        private void recieve_dogecoincash_button_Click(object sender, EventArgs e)
        {
            recieve_dogecoin f8 = new recieve_dogecoin();
            f8.ShowDialog();

        }

        private void bitcoin_wallet_button_Click(object sender, EventArgs e)
        {    

            /*
            WebRequest webRequest = WebRequest.Create(@"https://cex.io/api/convert/BTC/USD");
            webRequest.ContentType = "text/html";
            webRequest.Method = "POST";
            string body = @"{""amnt"":""1.0""}";
            byte[] bytes = Encoding.ASCII.GetBytes(body);
            webRequest.ContentLength = bytes.Length;
            var os = webRequest.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);
            os.Close();
            webRequest.Timeout = 0; //setting the timeout to 0 causes the request to fail
            WebResponse webResponse = webRequest.GetResponse();

            */


            bitcoin_wallet_panel.Visible = true;
            

            bitcoin_wallet_panel.Dock = DockStyle.Fill;

            

            
            var bitcoin_Balance = bitcoinService.GetBalance(username,1,null);

            bitcoin_balance_wallet_label.Text = bitcoin_Balance.ToString("0.000000") + " 7CZ";

            List<BitcoinLib.Responses.ListTransactionsResponse> a  =new List<BitcoinLib.Responses.ListTransactionsResponse>();
            a = bitcoinService.ListTransactions();

            bitcoin_listView.Clear();

            //bitcoin_listView.DrawColumnHeader = Color.CornflowerBlue;


            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[0].Text = "Date";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[1].Text = "Address";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[2].Text = "Type";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[3].Text = "Amount";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[4].Text = "Confirmation";
            bitcoin_listView.Columns.Add(new ColumnHeader());
            bitcoin_listView.Columns[5].Text = "Tx";

            for (var i = 0; i < a.Count; i++)
            {
                TimeSpan time = TimeSpan.FromSeconds(a[i].Time);
                string[] row = { DateTime.Today.Add(time).ToString("HH:mm:ss"), a[i].Address, a[i].Category, a[i].Amount.ToString(), a[i].Confirmations.ToString(), a[i].TxId };
                var listViewItem = new ListViewItem(row);
                bitcoin_listView.Items.Add(listViewItem);
            }
            //bitcoin_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void bitcoincash_wallet_button_Click(object sender, EventArgs e)
        {      




            //bitcoin_conv_cur_label.Text = error;

            bitcoin_wallet_panel.Visible = false;
           
            

        }

        private void litecoin_wallet_button_Click(object sender, EventArgs e)
        {
            
        }

        private void dogecoin_wallet_button_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            exchange f9 = new exchange();
            f9.ShowDialog();
        }

        private void recieve_unit_label_Click(object sender, EventArgs e)
        {

        }

        private void exchange_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void recieve_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }


        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bitcoincash_home_label_Click(object sender, EventArgs e)
        {

        }

        private void litecoin_home_label_Click(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bitcoin_wallet_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bitcoin_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bitcoin_balance_wallet_label_Click(object sender, EventArgs e)
        {

        }

        private void home_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signin_button_Click(object sender, EventArgs e)
        {

            Regex mRegxExpression;

            if (username_textBox.Text.Trim() != string.Empty && password_textBox.Text.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(username_textBox.Text.Trim()))
                {

                    MessageBox.Show("E-mail address format is not correct.", "7COINZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    username_textBox.Focus();

                }
                else
                {
                    string URL = "http://198.54.119.56:9999/auth/authentcate";

                    dynamic foo = new ExpandoObject();
                    foo.email = username_textBox.Text;
                    foo.password = password_textBox.Text;

                    string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(foo);


                    //string DATA = @"{""email"":""asdd@da.xaxd"",""password"":""3241"",""confirmPassword"":""3241"",""spendingpassword"":""123"",""confirmspendingpassword"":""123""}";


                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                    request.Method = "POST";
                    request.ContentType = "application/json";
                    request.ContentLength = DATA.Length;
                    using (Stream webStream = request.GetRequestStream())
                    using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
                    {
                        requestWriter.Write(DATA);
                    }

                    try
                    {
                        WebResponse webResponse = request.GetResponse();
                        using (Stream webStream = webResponse.GetResponseStream())
                        {
                            if (webStream != null)
                            {
                                using (StreamReader responseReader = new StreamReader(webStream))
                                {
                                    string response = responseReader.ReadToEnd();
                                    Console.Out.WriteLine(response);

                                    dynamic d = JsonConvert.DeserializeObject(response);

                                    
                                    string error = d.message;
                                    Console.WriteLine(error);
                                    string message = "error";
                                    try
                                    {
                                        message = d.user.email;
                                    }
                                    catch
                                    {
                                        message = "error";
                                    }
                                    
                                    string user = username_textBox.Text;
                                      // error_label.Text = "safasfasf";

                                    if (message == user )
                                    {
                                        username_textBox.Text = "";
                                        password_textBox.Text = "";

                                        home_logo_pictureBox.Hide();
                                        username_label.Hide();
                                        username_textBox.Hide();
                                        password_label.Hide();
                                        password_textBox.Hide();
                                        signin_button.Hide();
                                        signup_label.Hide();

                                        label_1.Show();
                                        bitcoin_home_label.Show();

                                        username = "wallet_"+message;
                                        home_button.Show();
                                        wallet_button.Show();

                                        try
                                        {
                                            var bitcoin_Balance = bitcoinService.GetBalance(username);
                                            bitcoin_home_label.Text = bitcoin_Balance.ToString("0.000000") + " 7CZ";
                                        }
                                        catch (RpcException e1)
                                        {
                                            Console.WriteLine(e1);
                                            bitcoin_home_label.Text = "Not Connected";
                                            Console.WriteLine("Not connected");
                                        }  

                                    }
                                    if(error != "")
                                    {
                                        Console.WriteLine(error);
                                        error_label.Text = error;
                                    }

                                  
                                }
                            }
                        }
                    }
                    catch (Exception e1)
                    {
                        Console.Out.WriteLine("-----------------");
                        Console.Out.WriteLine(e1.Message);
                    }
                }

            }
            else
            {
                error_label.Text = "Please enter feilds!";
            }
            

             
       
        }

        private void signup_label_Click(object sender, EventArgs e)
        {
            signup f1 = new signup();
            f1.ShowDialog();
        }

        private void username_textBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Text = "";
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Text = "";
        }


               

     
    }
}
