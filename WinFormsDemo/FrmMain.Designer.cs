namespace WinFormsDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog = new ColorDialog();
            lblWinName = new Label();
            btnShowChild = new Button();
            grpDll = new GroupBox();
            btnVbDll = new Button();
            btnCppNativeDll = new Button();
            btnCppCliDll = new Button();
            btnCSharpDll = new Button();
            grpDll.SuspendLayout();
            SuspendLayout();
            // 
            // lblWinName
            // 
            lblWinName.AutoSize = true;
            lblWinName.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblWinName.ForeColor = Color.Red;
            lblWinName.Location = new Point(12, 9);
            lblWinName.Name = "lblWinName";
            lblWinName.Size = new Size(111, 30);
            lblWinName.TabIndex = 0;
            lblWinName.Text = "親ウインドウ";
            // 
            // btnShowChild
            // 
            btnShowChild.Location = new Point(17, 51);
            btnShowChild.Name = "btnShowChild";
            btnShowChild.Size = new Size(380, 38);
            btnShowChild.TabIndex = 1;
            btnShowChild.Text = "ウインドウ操作";
            btnShowChild.UseVisualStyleBackColor = true;
            btnShowChild.Click += btnShowChild_Click;
            // 
            // grpDll
            // 
            grpDll.Controls.Add(btnVbDll);
            grpDll.Controls.Add(btnCppNativeDll);
            grpDll.Controls.Add(btnCppCliDll);
            grpDll.Controls.Add(btnCSharpDll);
            grpDll.Location = new Point(12, 95);
            grpDll.Name = "grpDll";
            grpDll.Size = new Size(183, 208);
            grpDll.TabIndex = 2;
            grpDll.TabStop = false;
            grpDll.Text = "DLLの呼出";
            // 
            // btnVbDll
            // 
            btnVbDll.Location = new Point(6, 66);
            btnVbDll.Name = "btnVbDll";
            btnVbDll.Size = new Size(171, 38);
            btnVbDll.TabIndex = 6;
            btnVbDll.Text = "VB.NET マネージド DLL";
            btnVbDll.UseVisualStyleBackColor = true;
            btnVbDll.Click += btnVbDll_Click;
            // 
            // btnCppNativeDll
            // 
            btnCppNativeDll.Location = new Point(5, 154);
            btnCppNativeDll.Name = "btnCppNativeDll";
            btnCppNativeDll.Size = new Size(171, 38);
            btnCppNativeDll.TabIndex = 5;
            btnCppNativeDll.Text = "C++ ネイティブ DLL";
            btnCppNativeDll.UseVisualStyleBackColor = true;
            // 
            // btnCppCliDll
            // 
            btnCppCliDll.Location = new Point(5, 110);
            btnCppCliDll.Name = "btnCppCliDll";
            btnCppCliDll.Size = new Size(171, 38);
            btnCppCliDll.TabIndex = 4;
            btnCppCliDll.Text = "C++/CLI DLL";
            btnCppCliDll.UseVisualStyleBackColor = true;
            // 
            // btnCSharpDll
            // 
            btnCSharpDll.Location = new Point(6, 22);
            btnCSharpDll.Name = "btnCSharpDll";
            btnCSharpDll.Size = new Size(171, 38);
            btnCSharpDll.TabIndex = 3;
            btnCSharpDll.Text = "C# マネージド DLL";
            btnCSharpDll.UseVisualStyleBackColor = true;
            btnCSharpDll.Click += btnCSharpDll_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 335);
            Controls.Add(grpDll);
            Controls.Add(btnShowChild);
            Controls.Add(lblWinName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "親ウインドウ";
            grpDll.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog;
        private Label lblWinName;
        private Button btnShowChild;
        private GroupBox grpDll;
        private Button btnCppCliDll;
        private Button btnCSharpDll;
        private Button btnCppNativeDll;
        private Button btnVbDll;
    }
}