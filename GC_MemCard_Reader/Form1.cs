using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GC_MemCard_Reader
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Browse file
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.Open(openFile.FileName, FileMode.Open);
                this.memCard = new MemCard(fs);
                fs.Close();

                // Values should be set
                this.txtDateCreated.Text = memCard.DateCreated.ToString("dd/MM/yyyy");
                this.txtCardSize.Text = @"MB " + memCard.CardSize.ToString();
                this.txtEncoding.Text = (memCard.ASCII ? @"Western" : @"Japanese");
                this.txtChecksum1.Text = memCard.c1.ToString();
                this.txtChecksum2.Text = memCard.c2.ToString();
            }
        }

        private void labelLink_Copyright_Clicked(object Sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RlSEN");
        }
    }
}
