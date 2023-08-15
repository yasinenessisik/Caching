using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JsonModelOkuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Root JsonListe()
        {
                Root root = null;
            
                WebClient client = new WebClient();
                string jsonText = client.DownloadString(@"https://api.ceptesok.com/api/customlists/95/products?stock=true&page=1");
                root = JsonConvert.DeserializeObject<Root>(jsonText);
                List<Product> productList = root.payload.products;
                grdListe.DataSource = productList;
         
            
           
            return root;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            JsonListe();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonListe();
        }
    }
}
