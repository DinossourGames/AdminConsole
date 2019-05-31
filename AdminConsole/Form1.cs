using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using RestSharp;
using ClassModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Linq;
using System;
using System.Collections.Generic;

namespace AdminConsole
{
    public partial class Form1 : Form
    {
        //public const string ServerIp = "http://177.52.28.212:5000/";
        public const string ServerIp = "http://127.0.0.1:5000/";
        private Thread t;
        private List<Item> listinha;

        public RestClient HttpClient { get; private set; }

        public Form1()
        {
            InitializeComponent();
            HttpClient = new RestClient(ServerIp);

            t = new Thread(() =>
            {
                while (true)
                {
                    CheckServer();
                    Thread.Sleep(10000);
                }
            });
            // t.Start();

            UpdateList();

        }

        private void UpdateList()
        {
            var request = new RestRequest("getItens", Method.GET);
            listinha = new List<Item>();
            HttpClient.ExecuteAsync(request, r =>
            {
                var obj = JObject.Parse(r.Content);
                var lista = obj["Result"];
                foreach (var item in lista)
                {
                    var i = JsonConvert.DeserializeObject<Item>(item.ToString());
                    listinha.Add(i);
                    Invoke((MethodInvoker)delegate
                    {
                        comboBox1.Items.Insert(comboBox1.Items.Count, i.Nome);
                    });
                }
            });

        }

        private void CheckServer()
        {
            var request = new RestRequest("status", Method.GET);
            HttpClient.Timeout = 200;
            var response = HttpClient.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                pbServerStatus.BackColor = Color.Green;
            else
                pbServerStatus.BackColor = Color.Red;

        }

        private void BtnItem_Click(object sender, System.EventArgs e)
        {
            var request = new RestRequest("addItem", Method.POST);

            //creating the json
            var a = new Item
            {
                Nome = string.IsNullOrWhiteSpace(txtItemName.Text) ? null : txtItemName.Text,
                Description = string.IsNullOrWhiteSpace(txtItemDesc.Text) ? null : txtItemDesc.Text,
                Durability = string.IsNullOrWhiteSpace(txtItemDurability.Text) ? 0 : int.Parse(txtItemDurability.Text),
                isLootBox = checkBox1.Checked,
                price = string.IsNullOrWhiteSpace(txtItemCost.Text) ? 0 : int.Parse(txtItemCost.Text),
                URL = string.IsNullOrWhiteSpace(txtImageUrl.Text) ? null : txtImageUrl.Text,
                Id = string.IsNullOrWhiteSpace(txtItemName.Text) && string.IsNullOrWhiteSpace(txtItemDesc.Text) && string.IsNullOrWhiteSpace(txtImageUrl.Text) ? 0.ToString() : 128.ToString(),
                StatBonus = new Atributos()
                {
                    Atk = string.IsNullOrWhiteSpace(txtItemAttack.Text) ? 0 : int.Parse(txtItemAttack.Text),
                    AtkRange = string.IsNullOrWhiteSpace(txtItemRange.Text) ? 0 : int.Parse(txtItemRange.Text),
                    Def = string.IsNullOrWhiteSpace(txtItemDefense.Text) ? 0 : int.Parse(txtItemDefense.Text),
                    Hp = string.IsNullOrWhiteSpace(txtItemHealth.Text) ? 0 : int.Parse(txtItemHealth.Text),
                    Luck = string.IsNullOrWhiteSpace(txtItemLucky.Text) ? 0 : int.Parse(txtItemLucky.Text),
                    MovSpeed = string.IsNullOrWhiteSpace(txtMoveSpeed.Text) ? 0 : int.Parse(txtMoveSpeed.Text)
                }
            };
            string jsonFile = JsonConvert.SerializeObject(a);
            //Creating the Request
            request.AddParameter("application/json; charset=utf-8", jsonFile, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            //Running the request
            new Thread(() =>
            {
                var response = HttpClient.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    pbAddStatus.BackColor = Color.Green;
                else
                    pbAddStatus.BackColor = Color.Red;
                Thread.Sleep(600);
                pbAddStatus.BackColor = Color.Gray;
            }).Start();

            UpdateList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }

        private void BtnPoolStart_Click(object sender, System.EventArgs e)
        {
            var request = new RestRequest("createPool", Method.GET);
            HttpClient.ExecuteAsync(request, r =>
            {
                Debug.WriteLine(r.StatusCode);
            });
        }

        private void BtnPoolEnd_Click(object sender, System.EventArgs e)
        {
            var request = new RestRequest("finishPool", Method.GET);
            HttpClient.ExecuteAsync(request, r =>
            {
                Debug.WriteLine(r.StatusCode);
            });

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var request = new RestRequest("finishPool", Method.POST);
           
            string jsonFile = JsonConvert.SerializeObject(listinha[comboBox1.SelectedIndex]);
            Debug.WriteLine(jsonFile);
            request.AddParameter("application/json; charset=utf-8", jsonFile, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            HttpClient.ExecuteAsync(request, r =>
            {
                Debug.WriteLine(r.StatusCode);
            });
        }
    }
}
