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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Ders Adı",
            System.Type.GetType("System.String"));
            dt.Columns.Add("Öğretmen Adı",
            System.Type.GetType("System.String"));
            dt.Columns.Add("Ders Kodu",
            System.Type.GetType("System.String"));
            dt.Columns.Add("Başarı Notu",
            System.Type.GetType("System.String"));

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].AllowDBNull = false;
            };
            
             
            
            

            

            dt.Rows.Add(new object[]
                {"Fizik II", "Şakir AYDOĞAN", "FIZ 102", "AA"});
            dt.Rows.Add(new object[]
                {"Nesneye Yönelik Programlama", "Ahmet COŞKUNÇAY", "BIM ", "BA"});
            dt.Rows.Add(new object[]
                {"Ayrık Matematik", "Ferhat BOZKURT", "BIM ", "BB"});
            dt.Rows.Add(new object[]
                {"Lineer Cebir", "Ömer TARAKÇI", "BIM ", "BB"});
            dt.Rows.Add(new object[]
                {"Matematik II", "Ömer TARAKÇI", "MAT ", "CC"});

            
            dataGridView1.DataSource = dt;

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 anamenu = new Form1();
            anamenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            MessageBox.Show("Yeni ders ekle", "Ders Ekle",
                                         MessageBoxButtons.OKCancel
                                         );
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            const string message = "Form Kapandı";
            const string caption = "Dersler Sayfası";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK
                                         );
        }
       

         

        
    }
}
