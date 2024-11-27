using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Bitcoin_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currencyselector.SelectedItem.ToString() == "EUR")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
            }
            /*
             Lisada juurde dollar, nael ja eesti kroon
             */
            if (currencyselector.SelectedItem.ToString() == "USD")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.USD.rate_float;
                resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.USD.code}";
            }
            if (currencyselector.SelectedItem.ToString() == "GBP")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.GBP.rate_float;
                resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.GBP.code}";
            }
            if (currencyselector.SelectedItem.ToString() == "EEK")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultlabel.Text = $"{Math.Round(((double)result*15.6466), 2)} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
                
            }
        }
        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);         
            }
            return bitcoin;
        }

        private void resultlabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bitcoinamountinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
