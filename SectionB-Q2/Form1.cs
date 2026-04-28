namespace SectionB_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            CitizenProfile profile = new CitizenProfile(
                txtName.Text,
                txtID.Text,
                cmbCitizen.Text
                );

            lblisValid.Text = profile.ValidateID();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CitizenProfile profile = new CitizenProfile(
                txtName.Text,
                txtID.Text,
                cmbCitizen.Text
                );

            txtOutput.Text =
                $"Name: {profile.FullName}\r\n" +
                $"ID Number: {profile.IDNumber}\r\n" +
                $"Age: {profile.Age}\r\n" +
                $"Status: {profile.CitizenshipStatus}\r\n" +
                $"Validation: {profile.ValidateID()}\r\n" +
                $"Processed: {DateTime.Now}\r\n";
        }
    }
}
