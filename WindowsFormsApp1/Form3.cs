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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
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
       "Yeni proje ekle";
            const string caption = " Ekle";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel
                                         );
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Proje Adı",
            System.Type.GetType("System.String"));
            dt.Columns.Add("Proje Dili",
            System.Type.GetType("System.String"));
            dt.Columns.Add("Yapıldığı Dönem",
            System.Type.GetType("System.Int32"));
           

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].AllowDBNull = false;
            };

            dt.Rows.Add(new object[]
                {"Market Otomasyonu", "C", 1});
            dt.Rows.Add(new object[]
                {"Tombala", "C++", 2});
            dt.Rows.Add(new object[]
                {"Basit Web Site", "Html", 3 });
            
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
