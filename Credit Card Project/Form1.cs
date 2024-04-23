namespace Credit_Card_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void idTextBox_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "ID:")
            {
                idTextBox.ForeColor = Color.Black;
                idTextBox.Clear();
            }
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Name:")
            {
                nameTextBox.ForeColor = Color.Black;
                nameTextBox.Clear();
            }
        }

        private void dateTextBox_Click(object sender, EventArgs e)
        {
            if (dateTextBox.Text == "Date:")
            {
                dateTextBox.ForeColor = Color.Black;
                dateTextBox.Clear();
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            cardNumberLabel.Text = idTextBox.Text;
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {
            cardDateLabel.Text = dateTextBox.Text;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameLabel.Text = nameTextBox.Text;
        }
    }
}
