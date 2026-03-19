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
            lblCount = new Label();
            btnDelete = new Button();
            btnClear = new Button();
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
            txtMessage.TextChanged += txtMessage_TextChanged;
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
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.BackColor = SystemColors.Info;
            lblCount.Font = new Font("맑은 고딕", 10F);
            lblCount.Location = new Point(68, 373);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(100, 19);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화: 0개";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(443, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "메시지 삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(551, 385);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 30);
            btnClear.TabIndex = 6;
            btnClear.Text = "전체 삭제";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
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
        private Label lblCount;
        private Button btnDelete;
        private Button btnClear;
    }
}
