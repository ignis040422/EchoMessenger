namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // TextBox의 KeyDown 이벤트를 코드로 강제 연결 (엔터키 동작을 위해서)
            txtMessage.KeyDown += txtMessage_KeyDown;

            // TextBox의 TextChanged 이벤트를 코드로 강제 연결 (글자 수 제한을 위해서)
            txtMessage.TextChanged += txtMessage_TextChanged;

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
                // 현재 시간 저장 (작성 년도 월 일 시 분 초 추가)
                string time;
                time = DateTime.Now.ToString("yyyy-MM-dd / HH:mm:ss");

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

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            // 입력된 문자열 길이가 50자를 초과할 경우
            if (txtMessage.Text.Length > 50)
            {
                // 경고 메시지 출력
                MessageBox.Show("50자 이하로 입력하세요.");

                // 50자까지만 남기고 나머지 제거
                txtMessage.Text = txtMessage.Text.Substring(0, 50);

                // 커서를 문자열 끝으로 이동
                txtMessage.SelectionStart = txtMessage.Text.Length;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ListBox에서 선택된 항목이 있는지 확인
            if (lstChat.SelectedIndex != -1)
            {
                // 선택된 항목을 리스트에서 제거
                lstChat.Items.RemoveAt(lstChat.SelectedIndex);

                // ListBox에 저장된 메시지 개수를 변수에 저장
                int count;
                count = lstChat.Items.Count;

                // Label에 메시지 개수 표시
                lblCount.Text = "현재 대화: " + count + "개";
            }
            else
            {
                // 선택된 항목이 없을 경우 안내 메시지 출력
                MessageBox.Show("삭제할 메시지를 선택하세요.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // ListBox의 모든 항목을 삭제
            lstChat.Items.Clear();

            // Label을 초기 상태로 변경
            lblCount.Text = "현재 대화: 0개";

            // 입력창으로 다시 포커스 이동
            txtMessage.Focus();
        }
    }
}
