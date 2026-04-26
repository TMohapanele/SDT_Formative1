namespace SectionA_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Prevent empty input
            if (string.IsNullOrWhiteSpace(txtLanguage.Text))
            {
                MessageBox.Show("Please enter a programming language.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent duplicate entries
            if (Languages.Items.Contains(txtLanguage.Text))
            {
                MessageBox.Show("This programming language is already in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the language to the list
            Languages.Items.Add(txtLanguage.Text);

            //Show date and time
            lblDate.Text = $"Added on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";

            // Clear textbox
            txtLanguage.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Languages.SelectedItem != null)
            {
                Languages.Items.Remove(Languages.SelectedItem);
                lblDate.Text = $"Removed on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
            else
            {
                MessageBox.Show("Please select a programming language to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
