using HomeLandCost._02.DataAccess.Concrete;
using HomeLandCost._03.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace HomeLandCost
{
    public partial class MainPageWorker : Form
    {
        private CostWorkerDA WorkerDA;
        private MainPage mainPage;
        public MainPageWorker()
        {
            InitializeComponent();
            WorkerDA = new CostWorkerDA();
            RefreshDataMonth();
            this.WindowState = FormWindowState.Maximized;
            if (!GridData.Columns.Contains("Delete"))
            {
                var deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                GridData.Columns.Add(deleteButtonColumn);
            }
            if (!GridData.Columns.Contains("Edit"))
            {
                var editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "Edit";
                editButtonColumn.HeaderText = "Edit";
                editButtonColumn.Text = "Edit";
                editButtonColumn.UseColumnTextForButtonValue = true;
                GridData.Columns.Add(editButtonColumn);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Name.Text) && !String.IsNullOrEmpty(Price.Text) && int.TryParse(Price.Text, out int priceValue))
            {
                var data = new CostWorkerModel()
                {
                    Price = Price.Text,
                    Employeer = Name.Text
                };
                WorkerDA.Add(data);
                RefreshDataMonth();
                Price.Text = "";
                Name.Text = "";
            }
        }
        public void RefreshDataMonth()
        {
            button3.BackColor = Color.Chartreuse;
            button4.BackColor = Color.LightGray;
            var allData = WorkerDA.GetAll(x => x.DeletedId == 0 && x.AddTime.Month == DateTime.Now.Month);
            List<object> dataList = new List<object>();

            foreach (var item in allData)
            {
                var data = new
                {
                    Id = item.Id,
                    Name = item.Employeer,
                    Price = item.Price,
                    Tarix = item.AddTime,
                };
                dataList.Add(data);
            }

            dataList.Reverse();
            GridData.DataSource = dataList;

            decimal totalPrice = allData.Sum(x => decimal.Parse(x.Price));

            AllPrice.Text = totalPrice.ToString();

        }
        public void RefreshData()
        {
            button4.BackColor = Color.Chartreuse;
            button3.BackColor = Color.LightGray;
            var allData = WorkerDA.GetAll(x => x.DeletedId == 0);
            List<object> dataList = new List<object>();
            foreach (var item in allData)
            {
                var data = new
                {
                    Id = item.Id,
                    Name = item.Employeer,
                    Price = item.Price,
                    Tarix = item.AddTime,
                };
                dataList.Add(data);
            }
            dataList.Reverse();
            GridData.DataSource = dataList;
            decimal totalPrice = allData.Sum(x => decimal.Parse(x.Price));

            AllPrice.Text = totalPrice.ToString();
        }

        private void GridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridData.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int selectedTodoId = (int)GridData.Rows[e.RowIndex].Cells["Id"].Value;
                var data = WorkerDA.Get(x => x.Id == selectedTodoId);
                data.DeletedId = data.Id;
                WorkerDA.Update(data);
                RefreshData();
            }
            if (e.ColumnIndex == GridData.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int selectedTodoId = (int)GridData.Rows[e.RowIndex].Cells["Id"].Value;
                Edit edit = new Edit(selectedTodoId);
                edit.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshDataMonth();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "HomeLandCostWorker.docx";

            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

                using (DocX document = DocX.Create(filePath))
                {
                    Table table = document.AddTable(GridData.Rows.Count + 1, GridData.Columns.Count - 2);

                    for (int i = 0, docxCol = 0; i < GridData.Columns.Count; i++)
                    {
                        if (GridData.Columns[i].HeaderText != "Edit" && GridData.Columns[i].HeaderText != "Delete")
                        {
                            table.Rows[0].Cells[docxCol].Paragraphs.First().Append(GridData.Columns[i].HeaderText);
                            docxCol++;
                        }
                    }

                    for (int i = 0; i < GridData.Rows.Count; i++)
                    {
                        for (int j = 0, docxCol = 0; j < GridData.Columns.Count; j++)
                        {
                            if (GridData.Columns[j].HeaderText != "Edit" && GridData.Columns[j].HeaderText != "Delete")
                            {
                                object cellValue = GridData.Rows[i].Cells[j].Value;
                                table.Rows[i + 1].Cells[docxCol].Paragraphs.First().Append(cellValue != null ? cellValue.ToString() : "");
                                docxCol++;
                            }
                        }
                    }

                    document.InsertTable(table);
                    document.Save();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPage = new MainPage();
            this.Close();
            mainPage.Show();
        }
    }
}
