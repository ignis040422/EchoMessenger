namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // TextBox의 KeyDown 이벤트를 코드로 강제 연결 (엔터키 동작을 위해)
            txtMessage.KeyDown += txtMessage_KeyDown;

            // Enter 키를 누르면 btnSend 버튼이 자동으로 클릭되도록 설정
            this.AcceptButton = btnSend;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // TextBox 안에 입력된 문자열을 변수에 저장
            string msg;
            msg = txtMessage.Text;

            // 문자열 앞뒤 공백 제거
            msg = msg.Trim();

            // 입력값이 null이거나 공백이면 전송 안함
            if (!string.IsNullOrWhiteSpace(msg))
            {
                // 현재 시간 저장
                string time;
                time = DateTime.Now.ToString("HH:mm:ss");

                // 시간과 메시지를 하나의 문자열로 합침
                string result;
                result = "[" + time + "] " + msg;

                // ListBox에 메시지 추가
                lstChat.Items.Add(result);

                // ListBox에 저장된 메시지 개수를 변수에 저장
                int count;
                count = lstChat.Items.Count;

                // Label에 메시지 개수 표시
                lblCount.Text = "현재 대화: " + count + "개";

                // 입력창 초기화
                txtMessage.Clear();

                // 커서를 다시 입력창으로 이동
                txtMessage.Focus();
            }
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            // 엔터키를 눌렀을 때 실행
            if (e.KeyCode == Keys.Enter)
            {
                // 전송 버튼 클릭 이벤트 실행
                btnSend.PerformClick();

                // 엔터 입력 시 발생하는 소리 또는 줄바꿈 방지
                e.SuppressKeyPress = true;
            }
        }
    }
}


