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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message =
      "Yeni kitap ekle";
            const string caption = "Kitap Ekle";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel
                                         );
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 anamenu = new Form1();
            anamenu.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Kitap Adı",
            System.Type.GetType("System.String"));
            dt.Columns.Add("Sayfa Sayısı",
            System.Type.GetType("System.Int64"));
            dt.Columns.Add("Yazar Adı",
            System.Type.GetType("System.String"));

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].AllowDBNull = false;
            };


            dt.Rows.Add(new object[]
                {"Aspidistra", 296, "George ORWELL" });
            dt.Rows.Add(new object[]
                {"Dava", 216,"Franz KAFKA"});
            dt.Rows.Add(new object[]
                {"Satranç", 83, "Stefan ZWEIG"});


            dataGridView1.DataSource = dt;
        }
    }
}
