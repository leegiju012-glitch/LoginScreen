using System.Drawing;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtID.Select();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "비밀번호")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (txtPW.Text == "")
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "비밀번호";
                txtPW.ForeColor = Color.Silver;
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                SelectNextControl(txtPW, true, true, true, true);
            }
        }
        string myID = "admin";
        string myPW = "superman";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text; 
            string inputPW = txtPW.Text; 
            if (inputID == myID && inputPW == myPW) 
            { MessageBox.Show("로그인성공!");
            }
            else
            {
                MessageBox.Show("로그인실패~");
            }
        }
    }
}
