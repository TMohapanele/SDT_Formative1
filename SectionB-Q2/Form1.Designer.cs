namespace SectionB_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblName = new Label();
            lblID = new Label();
            lblCitizen = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            btnValidate = new Button();
            lblisValid = new Label();
            txtOutput = new TextBox();
            btnGenerate = new Button();
            cmbCitizen = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(475, 41);
            label1.TabIndex = 0;
            label1.Text = "Home Affairs Digital ID Processor";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.AntiqueWhite;
            lblName.Location = new Point(38, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Enter your name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.AntiqueWhite;
            lblID.Location = new Point(38, 144);
            lblID.Name = "lblID";
            lblID.Size = new Size(145, 20);
            lblID.TabIndex = 2;
            lblID.Text = "Enter you ID number";
            // 
            // lblCitizen
            // 
            lblCitizen.AutoSize = true;
            lblCitizen.BackColor = Color.AntiqueWhite;
            lblCitizen.Location = new Point(38, 197);
            lblCitizen.Name = "lblCitizen";
            lblCitizen.Size = new Size(165, 20);
            lblCitizen.TabIndex = 3;
            lblCitizen.Text = "Choose your citizenship";
            // 
            // txtName
            // 
            txtName.Location = new Point(227, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 27);
            txtName.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(227, 137);
            txtID.Name = "txtID";
            txtID.Size = new Size(191, 27);
            txtID.TabIndex = 5;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.Teal;
            btnValidate.ForeColor = SystemColors.Control;
            btnValidate.Location = new Point(174, 236);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(94, 29);
            btnValidate.TabIndex = 7;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblisValid
            // 
            lblisValid.AutoSize = true;
            lblisValid.BackColor = Color.AntiqueWhite;
            lblisValid.Location = new Point(174, 268);
            lblisValid.Name = "lblisValid";
            lblisValid.Size = new Size(0, 20);
            lblisValid.TabIndex = 8;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(112, 284);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(231, 131);
            txtOutput.TabIndex = 9;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Teal;
            btnGenerate.ForeColor = SystemColors.Control;
            btnGenerate.Location = new Point(149, 421);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(128, 29);
            btnGenerate.TabIndex = 10;
            btnGenerate.Text = "Generate Profile";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // cmbCitizen
            // 
            cmbCitizen.FormattingEnabled = true;
            cmbCitizen.Items.AddRange(new object[] { "South Africa", "Botswana", "Kenya" });
            cmbCitizen.Location = new Point(227, 189);
            cmbCitizen.Name = "cmbCitizen";
            cmbCitizen.Size = new Size(191, 28);
            cmbCitizen.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 480);
            Controls.Add(cmbCitizen);
            Controls.Add(btnGenerate);
            Controls.Add(txtOutput);
            Controls.Add(lblisValid);
            Controls.Add(btnValidate);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(lblCitizen);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblID;
        private Label lblCitizen;
        private TextBox txtName;
        private TextBox txtID;
        private Button btnValidate;
        private TextBox textBox3;
        private Button button1;
        private Label lblisValid;
        private TextBox txtOutput;
        private Button btnGenerate;
        private ComboBox cmbCitizen;
    }
}
