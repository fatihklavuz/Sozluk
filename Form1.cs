using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sozluk
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        //int sure = 90;
        int kelime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection Connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=szlk.mdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Connection.Close();
            YeniKelime();
        }

        private void YeniKelime()
        {
            int s = r.Next(0, 16500);
            lblcevap.Text = s.ToString();
            //lblcevap.Visible = true;
            Connection.Open();
            OleDbCommand command = new OleDbCommand("Select * from words where id=@p1", Connection);
            command.Parameters.AddWithValue("@p1", s);
            OleDbDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txteng.Text = dr[1].ToString();
               txtturk.Text = dr[2].ToString();

            }

            Connection.Close();
        }

        private void txtturk_TextChanged(object sender, EventArgs e)
        {
           
            if (txtturk.Text == lblcevap.Text)
            {
                kelime++;
                lblklm.Text = kelime.ToString();
                YeniKelime();
                txtturk.Text = "";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //sure--;
            //lblsure.Text = sure.ToString();
            //if (sure == 0)
            //{
            //    timer1.Stop();
            //    MessageBox.Show("SÜRE BİTTİ. DOĞRU KELİME SAYIN \n" + lblklm.Text);
            //    lblklm.Text = "0";
            //    lblsure.Text = "90";
            //    sure = 90;
            //    txteng.Text = "";
            //    txtturk.Text = "";
            //}
            YeniKelime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
