using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace GC_MemCard_Reader
{
    class MemCard
    {
        /* Memory Card Object
         * reads and parses a .raw
         * memory card file
        */

        /* Public */        
        public DateTime DateCreated; // Unix timestamp
        public uint CardSize; // in Megabytes
        public bool ASCII; // 1 = Ascii; 0 = JP
        public uint c1; // Checksum 1
        public uint c2; // Checksum 2

        /* Private */
        private Stream card; // Stream of the entire card        
        private uint Block = 0x2000; // Block size in bytes
        private byte[] Header; // Header of the given card, 8192/0x2000 bytes
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
        // Static unix time
        private System.DateTime GC_TIME = new System.DateTime(1999, 12, 31, 23, 59, 59, DateTimeKind.Utc); // Gamecube time: 1999-12-31:23:59:59.999

        // Memory offsets
        private uint TIME_OFFSET = 0x000c; // Date of creation in seconds since 1999-12-31:23:59:59.999
        private uint CARDSIZE_OFFSET = 0x0022; // In Mbits (/8 = MB)
        private uint ENCODING_OFFSET = 0x0024; // Bool
        private uint CHECKSUM_1_OFFSET = 0x01fc; // c1
        private uint CHECKSUM_2_OFFSET = 0x01fe; // c2

        // Offset lengths / Size
        private uint TIME_LENGTH = 0x8; // 8 bytes
        private uint CARDSIZE_LENGTH = 0x2; // 2 bytes
        private uint ENCODING_LENGTH = 0x2; // 2 bytes
        private uint CHECKSUM_LENGTH = 0x2; // 2 bytes



        public MemCard(Stream card)
        {
            this.card = card;
            parse();
        }

        private void parse()
        {
            try
            {
                byte[] buffer = new byte[Block];
                // Set the header to work with
                this.card.Read(buffer, 0x0, (int) this.Block);
                this.Header = buffer;

                this.DateCreated = GC_TIME.AddSeconds(getuint32FromHeader(TIME_OFFSET, TIME_LENGTH));

                this.CardSize = (getuint16FromHeader(CARDSIZE_OFFSET, CARDSIZE_LENGTH)/8);

                this.ASCII = (getuint16FromHeader(ENCODING_OFFSET, ENCODING_LENGTH) > 0 ? false : true);

                this.c1 = getuint16FromHeader(CHECKSUM_1_OFFSET, CHECKSUM_LENGTH);

                this.c2 = getuint16FromHeader(CHECKSUM_2_OFFSET, CHECKSUM_LENGTH);

                return;
            }
            catch(Exception e)
            {
                // No matter what error, abort mission
                // Notify the user
                this.warning(e.ToString());
                return;
            }
        }

        /*
         * Both (uint32fromheader and uint16 from header) convert the
         * bytes of the header to a HEX value and store those in a String         
         * array - I've tried MANY different ways to avoid that, if you know
         * one, please tell me :)
        */
        
        // returns the integer value within the given range (from offset to offset+length-1)
        private uint getuint32FromHeader(uint offset, uint length)
        {
            uint ret = 0;
            string[] tmp = new string[length/4];
            // length: total bytes
            // int32: 4 bytes
            int pos = 0; // position + 1 after 4 bytes being added

            for(int i = 0; i < length; i++)
            {
                tmp[pos] += Header[i + offset].ToString("X2");
                if ((i+1) % 4 == 0)
                    pos++;
            }

            for(int i = 0; i < pos; i++)
            {
                ret += uint.Parse(tmp[i], System.Globalization.NumberStyles.HexNumber);
            }
            return ret;
        }

        // returns the integer value within the given range (from offset to offset+length-1)
        private uint getuint16FromHeader(uint offset, uint length)
        {
            uint ret = 0;
            string[] tmp = new string[length / 2];
            // length: total bytes
            // int16: 2 bytes
            int pos = 0; // position + 1 after 2 bytes being added

            for (int i = 0; i < length; i++)
            {
                tmp[pos] += Header[i + offset].ToString("X2");
                if ((i + 1) % 2 == 0)
                    pos++;
            }

            for (int i = 0; i < pos; i++)
            {
                ret += uint.Parse(tmp[i], System.Globalization.NumberStyles.HexNumber);
            }
            return ret;
        }
        /*{
        uint ret = 0;
        for(int i = 0; i < length; i++)
        {
            ret += Header[offset + i];
        }
        return ret;
    }*/

        private void warning(string s)
        {
            Form Alert = new Form();
            Button btnOK = new Button();

            Label warning = new Label();

            warning.Text = s;

            Alert.Text = @"Warning!";
            Alert.FormBorderStyle = FormBorderStyle.FixedSingle;
            Alert.MaximizeBox = false;
            Alert.MinimizeBox = false;
            Alert.Size = new Size(400, 250);
            Alert.TopMost = true;
            Alert.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));


            warning.Height = 160;
            warning.Width = 370;
            warning.BackColor = System.Drawing.Color.Transparent;
            warning.Top = 10;
            warning.Left = 10;

            btnOK.Text = @"Ok";
            btnOK.Left = 150;
            btnOK.Top = 180;

            btnOK.Click += BtnOK_Click;

            Alert.Controls.Add(warning);
            Alert.Controls.Add(btnOK);
            Alert.ShowDialog();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Form parent = btn.FindForm();
            parent.Close();
        }

    }    
}
