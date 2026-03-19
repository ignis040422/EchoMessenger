namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Echo_Messenger = new Label();
            txtMessage = new TextBox();
            btnSend = new Button();
            lstChat = new ListBox();
            SuspendLayout();
            // 
            // Echo_Messenger
            // 
            Echo_Messenger.AutoSize = true;
            Echo_Messenger.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Echo_Messenger.ForeColor = SystemColors.MenuHighlight;
            Echo_Messenger.Location = new Point(55, 58);
            Echo_Messenger.Name = "Echo_Messenger";
            Echo_Messenger.Size = new Size(258, 40);
            Echo_Messenger.TabIndex = 0;
            Echo_Messenger.Text = "Echo Messeenger";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(68, 336);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(464, 23);
            txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.Info;
            btnSend.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(551, 324);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(89, 45);
            btnSend.TabIndex = 2;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            btnSend.KeyDown += txtMessage_KeyDown;
            // 
            // lstChat
            // 
            lstChat.FormattingEnabled = true;
            lstChat.Location = new Point(68, 117);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(464, 199);
            lstChat.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstChat);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(Echo_Messenger);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Echo_Messenger;
        private TextBox txtMessage;
        private Button btnSend;
        private ListBox lstChat;
    }
}
