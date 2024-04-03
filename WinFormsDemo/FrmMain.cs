using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class FrmMain : Form
    {
        const uint WM_APP = 0x8000;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnShowChild_Click(object sender, EventArgs e)
        {
            FrmChild frmChild = new FrmChild();
            frmChild.ShowDialog(this);
        }

        protected override void WndProc(ref Message m)
        {
            if(m.Msg == WM_APP)
            {
                MessageBox.Show("子ウインドウからメッセージを受け取りました");
            }
            base.WndProc(ref m);
        }
    }
}
