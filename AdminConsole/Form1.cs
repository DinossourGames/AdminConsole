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
using Firebase.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminConsole
{


    public partial class Form1 : Form
    {
        public static string ServerIp { get; private set; }

        public async Task GetServerIp()
        {
            var a = await Reference.Child("ServerIp").OnceSingleAsync<string>();
            ServerIp = a;
            Debug.WriteLine(ServerIp);
        }

        private Thread t;
        private List<Item> listinha = new List<Item>();

        public RestClient HttpClient { get; private set; }
        public FirebaseClient Reference { get; private set; }
        public List<Iten> ix { get; private set; }
        public Player Player { get; private set; }


        public Form1()
        {
            Reference = new FirebaseClient("https://patricioclicker.firebaseio.com/");
            InitializeComponent();

            Reference.Child("Pool").AsObservable<Pool>().Subscribe(i =>
            {
                if (i.Object != null)
                {
                    ix = i.Object.Items;
                }
                else
                {
                    ix = null;
                }
            });

            Reference.Child("Gamedata1").AsObservable<Player>().Subscribe(play =>
            {

                try
                {
                    if (play.Key == "Player")
                    {
                        if (play.Object.IsPlaying)
                            Player = play.Object;
                        else
                            Player = null;
                    }
                    else
                        Player = null;
                }
                catch { }

            });
        }

        private void UpdateUi()
        {
            //Pool part

            item1.Text = ix != null ? ix[0].Item.Nome : " --- ";
            item2.Text = ix != null ? ix[1].Item.Nome : " --- ";
            item3.Text = ix != null ? ix[2].Item.Nome : " --- ";
            item4.Text = ix != null ? ix[3].Item.Nome : " --- ";

            voto1.Text = ix != null ? ix[0].Votes.ToString() : " -- ";
            voto2.Text = ix != null ? ix[1].Votes.ToString() : " -- ";
            voto3.Text = ix != null ? ix[2].Votes.ToString() : " -- ";
            voto4.Text = ix != null ? ix[3].Votes.ToString() : " -- ";

            if (!cbUpdate.Checked)
            {
                // Player Part
                pAtk.Text = Player != null ? Player.Atk.ToString() : "";
                pDef.Text = Player != null ? Player.Def.ToString() : "";
                pRange.Text = Player != null ? Player.Range.ToString() : "";
                pLucky.Text = Player != null ? Player.Luck.ToString() : "";
                pHp.Text = Player != null ? Player.Hp.ToString() : "";
                pMaxHp.Text = Player != null ? Player.MaxHp.ToString() : "";
                pSpeed.Text = Player != null ? Player.Speed.ToString() : "";
                pX.Text = Player != null ? Player.X.ToString() : "";
                pY.Text = Player != null ? Player.Y.ToString() : "";
                pOnline.Text = Player != null ? Player.IsPlaying.ToString() : "";

                try
                {
                    itemsDetails.Text = Player == null ? "" : $"Nome: {Player.ItemAtual.Nome}\nDescrição: {Player.ItemAtual.Description }\nDurabilidade: {Player.ItemAtual.Durability}\nId: {Player.ItemAtual.Id}\nisLootBox: {Player.ItemAtual.isLootBox}\nPrice: {Player.ItemAtual.price}\n------------BONUS------------\nAtk: {Player.ItemAtual.StatBonus.Atk}\nRange: {Player.ItemAtual.StatBonus.AtkRange}\nDefesa: {Player.ItemAtual.StatBonus.Def}\nHp: {Player.ItemAtual.StatBonus.Hp}\nLuck: {Player.ItemAtual.StatBonus.Luck}\nMove Speed: {Player.ItemAtual.StatBonus.MovSpeed}";
                }
                catch { }
            }

        }

        private void UpdateList()
        {
            listinha.Clear();
            comboBox1.Items.Clear();
            var request = new RestRequest("getItens", Method.GET);
            HttpClient.ExecuteAsync(request, r =>
            {


                try
                {
                    Debug.WriteLine(r.Content);
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
                }
                catch
                { }
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
            //t.Abort();
        }

        private void BtnPoolStart_Click(object sender, System.EventArgs e)
        {
            var request = new RestRequest("createPool", Method.GET);
            HttpClient.ExecuteAsync(request, r =>
            {
                if (r.StatusCode == System.Net.HttpStatusCode.OK)
                    pbAddStatus.BackColor = Color.Green;
                else
                    pbAddStatus.BackColor = Color.Red;
                Thread.Sleep(600);
                pbAddStatus.BackColor = Color.Gray;
            });
        }

        private void BtnPoolEnd_Click(object sender, System.EventArgs e)
        {
            var request = new RestRequest("finishPool", Method.GET);
            HttpClient.ExecuteAsync(request, r =>
            {
                if (r.StatusCode == System.Net.HttpStatusCode.OK)
                    pbAddStatus.BackColor = Color.Green;
                else
                    pbAddStatus.BackColor = Color.Red;
                Thread.Sleep(600);
                pbAddStatus.BackColor = Color.Gray;
            });
            UpdateList();
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
                if (r.StatusCode == System.Net.HttpStatusCode.OK)
                    pbAddStatus.BackColor = Color.Green;
                else
                    pbAddStatus.BackColor = Color.Red;
                Thread.Sleep(600);
                pbAddStatus.BackColor = Color.Gray;
            });

            UpdateList();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await GetServerIp();

            HttpClient = new RestClient(ServerIp);

            UpdateList();
            UpdateUi();
            //t = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        CheckServer();
            //        Thread.Sleep(10000);
            //    }
            //});
            //t.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateUi();
        }

        private void CbUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (cbUpdate.Checked)
            {
                try
                {
                    var p = new Player
                    {
                        IsPlaying = Player.IsPlaying,
                        ItemAtual = Player.ItemAtual,
                        PoolResult = Player.PoolResult,
                        Atk = int.Parse(pAtk.Text),
                        Def = int.Parse(pDef.Text),
                        Hp = int.Parse(pHp.Text),
                        MaxHp = int.Parse(pMaxHp.Text),
                        Luck = int.Parse(pLucky.Text),
                        Range = int.Parse(pRange.Text),
                        Speed = int.Parse(pSpeed.Text),
                        R = 1
                    };


                    var request = new RestRequest("updatePlayer", Method.POST);

                    string jsonFile = JsonConvert.SerializeObject(p);
                    Debug.WriteLine(jsonFile);
                    request.AddParameter("application/json; charset=utf-8", jsonFile, ParameterType.RequestBody);
                    request.RequestFormat = DataFormat.Json;

                    HttpClient.ExecuteAsync(request, r =>
                    {
                        if (r.StatusCode == System.Net.HttpStatusCode.OK)
                            pbAddStatus.BackColor = Color.Green;
                        else
                            pbAddStatus.BackColor = Color.Red;
                        Thread.Sleep(600);
                        pbAddStatus.BackColor = Color.Gray;
                    });


                }
                catch { }

            }
        }
    }

    public class Pool
    {
        public List<Iten> Items { get; set; }
        public string Id { get; set; }
    }

    public class Iten
    {
        public Item Item { get; set; }
        public int Votes { get; set; }
    }
}
