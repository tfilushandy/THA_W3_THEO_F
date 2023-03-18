using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace THA_W3_NEW
{
    public partial class secondwindowform : Form
    {
        public static secondwindowform instance;
        public Label lab1;

        public secondwindowform()
        {
            InitializeComponent();
            instance= this;
            lab1 = result;

        }

        private void resulttext_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundred_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void magicbtn_Click(object sender, EventArgs e)
        {
            if (truecheckbox2.Checked == false || agree.Checked == false)
            {
                MessageBox.Show("Anda harus menyetujui kebijakan/memilih dengan benar terlebih dahulu");
            }
            else
            {
                if (backgroundblue.Checked == false && backgroundgreen.Checked == false && backgroundred.Checked == false && backgroundyellow.Checked == false && backgroundorange.Checked == false
                    && redtext.Checked == false && bluetext.Checked == false && greentext.Checked == false)
                {
                    MessageBox.Show("Pilih Minimal 1 Choice");
                }
                else
                {
                    if (backgroundred.Checked == true)
                    {
                        mainwindowform.instance.pnl.BackColor = Color.Red;
                    }
                    if (backgroundblue.Checked == true)
                    {
                        mainwindowform.instance.pnl.BackColor = Color.Blue;
                    }
                    if (backgroundgreen.Checked == true)
                    {
                        mainwindowform.instance.pnl.BackColor = Color.Green;
                    }
                    if (backgroundyellow.Checked == true)
                    {
                        mainwindowform.instance.pnl.BackColor = Color.Yellow;
                    }
                    if (backgroundorange.Checked == true)
                    {
                        mainwindowform.instance.pnl.BackColor = Color.Orange;
                    }
                    if(redtext.Checked == true)
                    {
                        foreach(Control c in mainwindowform.instance.Controls)
                        {
                            c.ForeColor = Color.Red;
                        }
                    }
                    if (bluetext.Checked == true)
                    {
                        foreach (Control c in mainwindowform.instance.Controls)
                        {
                            c.ForeColor = Color.Blue;
                        }
                    }
                    if (greentext.Checked == true)
                    {
                        foreach (Control c in mainwindowform.instance.Controls)
                        {
                            c.ForeColor = Color.Green;
                        }
                    }

                }
            }
        }
    }
}
