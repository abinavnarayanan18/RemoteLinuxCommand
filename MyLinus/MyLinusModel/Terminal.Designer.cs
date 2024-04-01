using System.Windows.Forms;

namespace MyLinus.MyLinusModel
{
    partial class Terminal : Form
    {
        // Define form controls
        private Label label1;
        private ComboBox cmbCommands;
        private Button btnExecute;
        private RichTextBox rtbTerminalOutput;

        // Initialize form controls
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCommands = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.rtbTerminalOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command";
            // 
            // cmbCommands
            // 
            this.cmbCommands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommands.FormattingEnabled = true;
            this.cmbCommands.Items.AddRange(new object[] {
            "ls",
            "pwd",
            "date",
            "echo Hello"});
            this.cmbCommands.Location = new System.Drawing.Point(91, 15);
            this.cmbCommands.Name = "cmbCommands";
            this.cmbCommands.Size = new System.Drawing.Size(200, 21);
            this.cmbCommands.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(297, 15);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // rtbTerminalOutput
            // 
            this.rtbTerminalOutput.BackColor = System.Drawing.Color.Black;
            this.rtbTerminalOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTerminalOutput.ForeColor = System.Drawing.Color.White;
            this.rtbTerminalOutput.Location = new System.Drawing.Point(12, 50);
            this.rtbTerminalOutput.Name = "rtbTerminalOutput";
            this.rtbTerminalOutput.ReadOnly = true;
            this.rtbTerminalOutput.Size = new System.Drawing.Size(360, 200);
            this.rtbTerminalOutput.TabIndex = 3;
            this.rtbTerminalOutput.Text = "";
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.rtbTerminalOutput);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cmbCommands);
            this.Controls.Add(this.label1);
            this.Name = "Terminal";
            this.Text = "Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
