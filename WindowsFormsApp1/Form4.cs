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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 anamenu = new Form1();
            anamenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message =
       "Yeni staj ekle";
            const string caption = "Staj Ekle";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel
                                         );
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Şirket Adı",
            System.Type.GetType("System.String"));
            dt.Columns.Add("Yapıldığı Dönem",
            System.Type.GetType("System.Int64"));
            dt.Columns.Add("Başlangıç Tarihi",
            System.Type.GetType("System.Int64"));
            dt.Columns.Add("Bitiş Tarihi",
            System.Type.GetType("System.Int64"));

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].AllowDBNull = false;
            };


            dt.Rows.Add(new object[]
                {"Microsoft", 1, 04.2018 , 05.2018});
            dt.Rows.Add(new object[]
                {"IBM", 2, 08.2019, 09.2019});
            dt.Rows.Add(new object[]
                {"ORACLE", 2, 02.2020, 03.2020});


            dataGridView1.DataSource = dt;
        }
    }
}
