using System;
using System.Windows.Forms;

namespace MyLinus.MyLinusModel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string host = TxtHostName.Text;
            string username = TxtUserName.Text;
            string password = TxtPassword.Text;

            try
            {
                // Connect to the server using SSHManager (assuming SSHManager is implemented elsewhere)
                SSHManager.Instance.Connect(host, username, password);

                // Open the Terminal form
                Terminal terminalForm = new Terminal();
                terminalForm.Show();

                // Hide the login form
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private void BtnBrowsePEM_Click(object sender, EventArgs e)
        {
            // Open file dialog to select PEM file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM Files (*.pem)|*.pem|All Files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Title = "Select PEM File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected PEM file path in the textbox
                string pemFilePath = openFileDialog.FileName;
            }
        }
    }
}
