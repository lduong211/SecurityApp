using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityApp.Forms
{
    public partial class frmSecurityApp : Form
    {
        public frmSecurityApp()
        {
            InitializeComponent();
        }
        string securitycode;
        string path = @"D:\My Study\Visual C#\Project C#\SecurityApp\AccessLog.txt";

        /// <summary>
        /// phuong thuc click cac nut so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNumber_Click(object sender, EventArgs e)
        {
            securitycode += ((Button)sender).Text;
            txtSecurityCode.Text = securitycode;
        }

        /// <summary>
        /// phuong thuc click nut reset(C)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            securitycode = "";
            txtSecurityCode.Text = securitycode;
        }

        /// <summary>
        /// phuong thuc click nut access(#)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccess_Click(object sender, EventArgs e)
        {
            string role = DateTime.Now.ToShortDateString();
            if (string.IsNullOrEmpty(securitycode))
                MessageBox.Show("vui long nhap so", "error");
            else
            {
                switch (int.Parse(securitycode))
                {
                    case 1645:
                    case 1689:
                        role += "\tTechnicians";
                        break;
                    case 8345:
                        role += "\tCustodians";
                        break;
                    case 9998:
                    case 1006:
                    case 1007:
                    case 1008:
                        role += "\tScientist";
                        break;
                    default:
                        role += "\tRestricted Access!";
                        break;
                }
                lsbAccessLog.Items.Add(role);
                WriteLogFile(role);
            }
            securitycode = "";
            txtSecurityCode.Text = securitycode;
        }

        private void WriteLogFile(string log)
        {
            File.AppendAllText(path, log + Environment.NewLine);
        }
    }
}
