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

using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Gma.QrCodeNet.Encoding.Masking.Scoring;

namespace Coinroot
{
    public partial class recieve_litecoin : Form
    {
        public recieve_litecoin()
        {
            InitializeComponent();

            ILitecoinService litecoinService = new LitecoinService();
            string a = litecoinService.GetNewAddress();
            address_textBox.Text = a;
            
            Gma.QrCodeNet.Encoding.QrEncoder Encoder = new Gma.QrCodeNet.Encoding.QrEncoder(Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.H);
            Gma.QrCodeNet.Encoding.QrCode Code = Encoder.Encode(a);
            Bitmap TempBMP = new Bitmap(Code.Matrix.Width , Code.Matrix.Height);
            for (int X = 0; X <= (Code.Matrix.Width) - 1; X++)
            {
                for (int Y = 0; Y <= (Code.Matrix.Height) - 1; Y++)
                {
                    if (Code.Matrix.InternalArray[X, Y])
                        TempBMP.SetPixel(X, Y, System.Drawing.Color.Black);
                    else
                        TempBMP.SetPixel(X, Y, System.Drawing.Color.White);
                }
            }

            //TempBMP.Size abc = new System.Drawing.Size(120,120);

            //Console.Write(TempBMP);
            //ictureBox.Image.Size =new  Size(600, 700);
            //empBMP.Size = new Size(TempBMP.Height,TempBMP.Width);
            pictureBox.Size = new Size(100, 75);
           // pictureBox.Image = TempBMP;

            var imageTemp = new Bitmap(TempBMP);

            var image = new Bitmap(imageTemp, new System.Drawing.Size(new System.Drawing.Point(100, 75)));

            //image.Save("file.bmp", ImageFormat.Bmp);

            pictureBox.Image = image;

            

            //pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
