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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        MainPageWorker Worker = new MainPageWorker();
        MainPageItem Item = new MainPageItem();
        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Worker.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Item.Show();
        }
    }
}
