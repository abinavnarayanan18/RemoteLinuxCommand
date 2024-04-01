using System;
using System.Windows.Forms;

namespace MyLinus.MyLinusModel
{
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // Get the selected command from the dropdown
            string selectedCommand = cmbCommands.SelectedItem.ToString();

            try
            {
                // Execute the selected command using SSHManager and display the output
                string output = SSHManager.Instance.ExecuteCommand(selectedCommand);

                // Append the output to the terminal textbox
                rtbTerminalOutput.AppendText(output + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing command: " + ex.Message);
            }
        }
    }
}
