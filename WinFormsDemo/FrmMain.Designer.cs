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
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 341);
            Controls.Add(btnShowChild);
            Controls.Add(lblWinName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "親ウインドウ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog;
        private Label lblWinName;
        private Button btnShowChild;
    }
}