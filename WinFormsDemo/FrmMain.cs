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

using ManagedLibrary;
using VbManagedLibrary;
using CLRLibrary;

namespace WinFormsDemo
{

    public partial class FrmMain : Form
    {
        const uint WM_APP = 0x8000;

        [DllImport("Kernel32.dll")]
        extern static IntPtr LoadLibrary(string lpLibFileName);

        [DllImport("Kernel32.dll")]
        extern static bool FreeLibrary(IntPtr hLibModule);

        [DllImport("Kernel32.dll")]
        extern static IntPtr GetProcAddress(IntPtr hLibModule, string lpProcName);

        delegate int addIntNumDelegate(int a, int b);

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
            if (m.Msg == WM_APP)
            {
                MessageBox.Show("子ウインドウからメッセージを受け取りました");
            }
            base.WndProc(ref m);
        }

        private void btnCSharpDll_Click(object sender, EventArgs e)
        {
            DllClass dllClass = new DllClass();
            int num = dllClass.addIntNum(3, 5);
            MessageBox.Show("3 + 5 = " + num, "C# マネージド DLL からの呼出");
        }

        private void btnVbDll_Click(object sender, EventArgs e)
        {
            VbDllClass dllClass = new VbDllClass();
            int num = dllClass.addIntNum(8, 4);
            MessageBox.Show("8 + 4 = " + num, "VB.NET マネージド DLL からの呼出");
        }

        private void btnCppCliDll_Click(object sender, EventArgs e)
        {
            DllCLRClass dllCLRClass = new DllCLRClass();
            int num = dllCLRClass.addIntNum(7, 9);
            MessageBox.Show("7 + 9 = " + num, "C++/CLI DLL からの呼出");
        }

        private void btnCppNativeDll_Click(object sender, EventArgs e)
        {
            IntPtr hLib = LoadLibrary("NativeLibrary.dll");
            if (hLib == IntPtr.Zero)
            {
                MessageBox.Show("DLLの読み込みに失敗しました");
                return;
            }

            IntPtr fp = GetProcAddress(hLib, "addIntNum");
            addIntNumDelegate addIntNum = Marshal.GetDelegateForFunctionPointer<addIntNumDelegate>(fp);
            int num = addIntNum(12, 8);
            MessageBox.Show("12 + 8 = " + num, "C++ ネイティブ DLL からの呼出");
            FreeLibrary(hLib);
        }

        private void btnCallComObj_Click(object sender, EventArgs e)
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.Open(Path.GetDirectoryName(Application.ExecutablePath));
        }
    }
}
