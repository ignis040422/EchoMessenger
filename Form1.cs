namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // 입력값 가져오기
            string msg = txtMessage.Text;

            // ListBox에 추가
            lstChat.Items.Add(msg);

            // 입력창 비우기 (1차 과제)
            txtMessage.Clear();

        }
    }
}
