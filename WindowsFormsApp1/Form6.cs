using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message =
       "Yeni Kulüp ekle";
            const string caption = "Kulüp Ekle";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel
                                         );
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 anamenu = new Form1();
            anamenu.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Kulüp Adı",
            System.Type.GetType("System.String"));
            dt.Columns.Add("Katılma Tarihi",
            System.Type.GetType("System.Int64"));

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].AllowDBNull = false;
            };


            dt.Rows.Add(new object[]
                {"Finans Kulübü", 04.2017});
            dt.Rows.Add(new object[]
                {"Girişimcilik Kulübü", 06.2019});
            dt.Rows.Add(new object[]
                {"Bilişim Kulübü", 01.2021});

            dataGridView1.DataSource = dt;
        }
    }
}
