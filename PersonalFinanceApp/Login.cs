namespace PersonalFinanceApp
{
    public partial class Login : Form
    {
        public string userNameInput;
        public string passwordInput;
        const string userName = "Adrian";
        const string password = "1234";

        public Login()
        {
            InitializeComponent();

            string path = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "Utilities",
                "profits.ico"
            );

            Icon = new Icon(path);

            path = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "Utilities",
                "obama.bmp"
            );

            if (File.Exists(path))
                pictureBox1.Image = Image.FromFile(path);
            else
                MessageBox.Show("Image not found");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {
            userNameInput = UserNameBox.Text;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            passwordInput = PasswordBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName == userNameInput 
                && password == passwordInput)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
