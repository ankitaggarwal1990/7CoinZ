using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Coinroot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Process myProcess = new Process();
            Process myProcess1 = new Process();
            Process myProcess2 = new Process();
            Process myProcess3 = new Process();

            myProcess.StartInfo.UseShellExecute = false;
            // You can start any process, HelloWorld is a do-nothing example.
            myProcess.StartInfo.FileName = @"bitcoind.exe";
            myProcess.StartInfo.Arguments = "-datadir=" + @"Bitcoin";
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();

            System.Threading.Thread.Sleep(5000);

            myProcess1.StartInfo.UseShellExecute = false;
            // You can start any process, HelloWorld is a do-nothing example.
            myProcess1.StartInfo.FileName = @"litecoind.exe";
            myProcess1.StartInfo.Arguments = "-datadir=" + @"Litecoin";
            myProcess1.StartInfo.CreateNoWindow = true;
            myProcess1.Start();

            System.Threading.Thread.Sleep(5000);

            myProcess2.StartInfo.UseShellExecute = false;
            // You can start any process, HelloWorld is a do-nothing example.
            myProcess2.StartInfo.FileName = @"dogecoind.exe";
            myProcess2.StartInfo.Arguments = "-datadir=" + @"Dogecoin";
            myProcess2.StartInfo.CreateNoWindow = true;
            myProcess2.Start();

            System.Threading.Thread.Sleep(5000);


            this.Close();


        }
    }
}
