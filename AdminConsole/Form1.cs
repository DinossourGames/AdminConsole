using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using RestSharp;

namespace AdminConsole
{
    public partial class Form1 : Form
    {
        public const string ServerIp = "http://177.52.28.212:5000/";
        private Thread t;

        public Form1()
        {
            InitializeComponent();

            t = new Thread(() =>
            {
                while (true)
                {
                    CheckServer();
                    Thread.Sleep(10000);
                }
            });
            t.Start();
        }

        private void CheckServer()
        {
            var HttpClient = new RestClient(ServerIp + "status");
            var request = new RestRequest(Method.GET);
            HttpClient.Timeout = 200;
            var response = HttpClient.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                pbServerStatus.BackColor = Color.Green;
            else
                pbServerStatus.BackColor = Color.Red;

        }

        private void BtnItem_Click(object sender, System.EventArgs e)
        {
            var HttpClient = new RestClient(ServerIp + "addItem");
            var request = new RestRequest(Method.GET);
            //Creating the Request
            request.AddQueryParameter("id", "128");
            request.AddQueryParameter("name", string.IsNullOrWhiteSpace(txtItemName.Text) ? "none" : txtItemName.Text);
            request.AddQueryParameter("description", string.IsNullOrWhiteSpace(txtItemDesc.Text) ? "none" : txtItemDesc.Text);
            request.AddQueryParameter("durability", string.IsNullOrWhiteSpace(txtItemDurability.Text) ? "none" : txtItemDurability.Text);
            request.AddQueryParameter("cost", string.IsNullOrWhiteSpace(txtItemCost.Text) ? "10000" : txtItemCost.Text);
            request.AddQueryParameter("attack", string.IsNullOrWhiteSpace(txtItemAttack.Text) ? "0" : txtItemAttack.Text);
            request.AddQueryParameter("attack_range", string.IsNullOrWhiteSpace(txtItemRange.Text) ? "0" : txtItemRange.Text);
            request.AddQueryParameter("defense", string.IsNullOrWhiteSpace(txtItemDefense.Text) ? "0" : txtItemDefense.Text);
            request.AddQueryParameter("health", string.IsNullOrWhiteSpace(txtItemHealth.Text) ? "0" : txtItemHealth.Text);
            request.AddQueryParameter("lucky", string.IsNullOrWhiteSpace(txtItemLucky.Text) ? "0" : txtItemLucky.Text);
            request.AddQueryParameter("move_speed", string.IsNullOrWhiteSpace(txtMoveSpeed.Text) ? "0" : txtMoveSpeed.Text);
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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}
