using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAU_Drone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (a == 0)
            {
                webBrowser2.Navigate("http://sethiserver.azurewebsites.net/data/trigger.php?q=hi");
                a = 1;
            }
            else if (a == 1)
            {
                webBrowser2.Navigate("http://sethiserver.azurewebsites.net/data/trigger.php?q=hx");
                a = 0;
            }
        }

        private void takeaphotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (a == 0)
            {
                webBrowser2.Navigate("http://sethiserver.azurewebsites.net/data/trigger.php?q=hi");
                a = 1;
                    }
            else if(a==1)
            {
                webBrowser2.Navigate("http://sethiserver.azurewebsites.net/data/trigger.php?q=hx");
                a = 0;
            }

        }
    }
}
