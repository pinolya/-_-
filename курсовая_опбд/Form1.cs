namespace курсовая_опбд
{
    public partial class Form1 : Form
    {

        private AppDbContext context;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration(new AppDbContext());
            Hide();
            reg.ShowDialog();
            Show();
        }

        private void button_vxod_Click(object sender, EventArgs e)
        {
            User user;
            using (var context = new AppDbContext())
            {
                var log = textBox1.Text;
                var password = textBox2.Text;
                user = context.Users.FirstOrDefault(u =>
               u.Login == log && u.Password == password);
            }
            if (user != null)
            {
                if (textBox1.Text == "Veronica" && textBox2.Text == "Olya")
                {
                    MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin mainForm = new Admin(new AppDbContext());
                    Hide();
                    mainForm.ShowDialog();
                    DialogResult dialogResult =
                   MessageBox.Show("Закрыть программу?", "Думай",
                   MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        Close();
                    else if (dialogResult == DialogResult.No)
                        Show();
                }
                else
                {
                    MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Client mainForm = new Client(new AppDbContext(), user);
                    Hide();
                    mainForm.ShowDialog();
                    DialogResult dialogResult =
                   MessageBox.Show("Закрыть программу?", "Думай",
                   MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        Close();
                    else if (dialogResult == DialogResult.No)
                        Show();
                }
            }
            else
            {
                MessageBox.Show("Неправильный login или пароль", "Ошибка авторизации", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}