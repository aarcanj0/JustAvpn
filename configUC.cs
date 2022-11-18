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

namespace JustAvpn
{
    public partial class configUC : UserControl
    {
        public string thisprotocol = File.ReadAllText("protocol.data");
        public configUC()
        {
            InitializeComponent();
            if (this.thisprotocol.Equals("tcp"))
            {
                this.protocolSwitch.Checked = true;
            }else if (this.thisprotocol.Equals("udp"))
            {
                this.protocolSwitch.Checked = false;
            }

        }
        
        private void protocolSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (this.protocolSwitch.Checked)
            {
                File.WriteAllText("protocol.data", "tcp");
                thisprotocol = "tcp";

            }else
            {
                File.WriteAllText("protocol.data", "udp");
                thisprotocol = "udp";
            }
        }
    }
}
