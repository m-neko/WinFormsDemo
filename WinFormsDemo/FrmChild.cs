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
    public partial class FrmChild : Form
    {
        const uint GW_OWNER = 4;
        const uint WM_APP = 0x8000;

        struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        IntPtr hWnd;

        [DllImport("User32.dll")]
        extern static IntPtr GetWindow(IntPtr hWnd, uint ucmd);

        [DllImport("User32.dll")]
        extern static bool SetWindowText(IntPtr hWnd, string lpString);

        [DllImport("User32.dll")]
        extern static IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("User32.dll")]
        extern static bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("User32.dll")]
        extern static bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        public FrmChild()
        {
            InitializeComponent();
        }

        private void btnSetWindowText_Click(object sender, EventArgs e)
        {
            SetWindowText(hWnd, "このようにタイトルのテキストが変化します");
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage(hWnd, WM_APP, IntPtr.Zero, IntPtr.Zero);
        }

        private void FrmChild_Load(object sender, EventArgs e)
        {
            hWnd = GetWindow(this.Handle, GW_OWNER);
        }

        private void btnMoveWindow_Click(object sender, EventArgs e)
        {
            RECT rect = new RECT();
            GetWindowRect(hWnd, ref rect);
            MoveWindow(hWnd, 0, 0, rect.right-rect.left, rect.bottom-rect.top, true);
        }
    }
}
