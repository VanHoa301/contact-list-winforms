namespace ContactList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemlienhe_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog(); // Mở form dưới dạng hộp thoại (modal)
        }

    }
}
