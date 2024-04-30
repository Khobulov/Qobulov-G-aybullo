namespace LogFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string UserFilePath = @"C:\Users\Qobulov\Desktop\G6_Modul_3\LogFormApplication\Userlist.txt";
            string[] id = File.ReadAllLines(UserFilePath);
            File.AppendAllText(UserFilePath,id.Length.ToString() +
                "," + Fullname.Text + 
                ","+ UserName.Text +
                ","+Password.Text +"\n");

            Login login = new Login();
            Form1 form1 = new Form1();
            login.Show();

        }
    }
}
