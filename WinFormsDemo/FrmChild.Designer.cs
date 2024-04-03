namespace WinFormsDemo
{
    partial class FrmChild
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
            lblWinName = new Label();
            btnSetWindowText = new Button();
            btnSendMessage = new Button();
            btnMoveWindow = new Button();
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
            lblWinName.TabIndex = 1;
            lblWinName.Text = "子ウインドウ";
            // 
            // btnSetWindowText
            // 
            btnSetWindowText.Location = new Point(12, 42);
            btnSetWindowText.Name = "btnSetWindowText";
            btnSetWindowText.Size = new Size(380, 38);
            btnSetWindowText.TabIndex = 2;
            btnSetWindowText.Text = "SetWindowText() で親タイトルを設定";
            btnSetWindowText.UseVisualStyleBackColor = true;
            btnSetWindowText.Click += btnSetWindowText_Click;
            // 
            // btnSendMessage
            // 
            btnSendMessage.Location = new Point(12, 86);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(380, 38);
            btnSendMessage.TabIndex = 3;
            btnSendMessage.Text = "SendMessage() で親にメッセージを送信";
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // btnMoveWindow
            // 
            btnMoveWindow.Location = new Point(12, 130);
            btnMoveWindow.Name = "btnMoveWindow";
            btnMoveWindow.Size = new Size(380, 38);
            btnMoveWindow.TabIndex = 4;
            btnMoveWindow.Text = "MoveWindow() で親の位置を変更";
            btnMoveWindow.UseVisualStyleBackColor = true;
            btnMoveWindow.Click += btnMoveWindow_Click;
            // 
            // FrmChild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 182);
            Controls.Add(btnMoveWindow);
            Controls.Add(btnSendMessage);
            Controls.Add(btnSetWindowText);
            Controls.Add(lblWinName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmChild";
            Text = "子ウインドウ";
            Load += FrmChild_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWinName;
        private Button btnSetWindowText;
        private Button btnSendMessage;
        private Button btnMoveWindow;
    }
}