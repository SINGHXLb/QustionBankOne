using DnsClient.Protocol;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QustionBankOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                         
            var client = new MongoClient("mongodb+srv://simeyAdmin:admin@cluster0.jzkv8.gcp.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("questionBank");
            var collection = database.GetCollection<BsonDocument>("questions");
            var list =   collection.Find(new BsonDocument()).ToList();
            foreach (var dox in list)
            {
                Console.WriteLine(dox);
            }
        }

        private void cmdReadRemote_Click(object sender, EventArgs e)
        {

            var client = new MongoClient("mongodb+srv://simeyAdmin:admin@cluster0.jzkv8.gcp.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("questionBank");
            var collection = database.GetCollection<BsonDocument>("questions");
            var documents  = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument doc in documents)
            {
                textBox1.Text += doc.ToString()  + Environment.NewLine ;
            }
          
          

        }
    }
}
