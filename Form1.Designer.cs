namespace LoginScreen
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtPW = new TextBox();
            txtID = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
       
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 35F);
            lblAppName.ForeColor = Color.Yellow;
            lblAppName.Location = new Point(178, 26);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(181, 78);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
          
            txtPW.Font = new Font("맑은 고딕", 27.75F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(108, 224);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(320, 69);
            txtPW.TabIndex = 1;
            txtPW.Text = "비밀번호";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
          
            txtID.Font = new Font("맑은 고딕", 27.75F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(108, 137);
            txtID.Name = "txtID";
            txtID.Size = new Size(320, 69);
            txtID.TabIndex = 0;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
           
            btnLogin.BackColor = Color.Crimson;
            btnLogin.Font = new Font("맑은 고딕", 20F);
            btnLogin.ForeColor = Color.Yellow;
            btnLogin.Location = new Point(162, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(212, 84);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
           
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(539, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtID);
            Controls.Add(txtPW);
            Controls.Add(lblAppName);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAppName;
        private TextBox txtPW;
        private TextBox txtID;
        private Button btnLogin;
    }
}
