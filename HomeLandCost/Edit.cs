using HomeLandCost._02.DataAccess.Concrete;
using HomeLandCost._03.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLandCost
{
    public partial class Edit : Form
    {
        private CostItemDA ItemDA ;
        private CostWorkerDA WorkerDA;
        private MainPageItem mainPageItem;
        private MainPageWorker mainPageWorker;
        private string code;
        private int id;
        public Edit(int Id, string Key=null)
        {
            code = Key;
            id = Id;
            if (Key == "Item")
            {
                ItemDA = new CostItemDA();
                InitializeComponent();
                var data = ItemDA.Get(x => x.Id == Id);
                Name.Text = data.InfoCost;
                Price.Text = data.Price;

            }
            else
            {
                WorkerDA = new CostWorkerDA();
                InitializeComponent();
                var data = WorkerDA.Get(x => x.Id == Id);
                Name.Text = data.Employeer;
                Price.Text = data.Price;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (code == "Item")
            {
                var data = ItemDA.Get(x => x.Id == id);
                data.InfoCost= Name.Text;
                data.Price= Price.Text;
                ItemDA.Update(data);
                mainPageItem = new MainPageItem();
                this.Close();
                mainPageItem.Show();
            }
            else
            {
                var data = WorkerDA.Get(x => x.Id == id);
                data.Employeer = Name.Text;
                data.Price = Price.Text;
                WorkerDA.Update(data);
                mainPageWorker = new MainPageWorker();
                this.Close();
                mainPageWorker.Show();
            }

        }
    }
}
