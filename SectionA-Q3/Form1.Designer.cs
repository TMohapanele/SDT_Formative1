namespace SectionA_Q3
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
            Languages = new ListBox();
            label1 = new Label();
            panel1 = new Panel();
            lblDate = new Label();
            btnRemove = new Button();
            btnAdd = new Button();
            txtLanguage = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Languages
            // 
            Languages.BackColor = Color.WhiteSmoke;
            Languages.FormattingEnabled = true;
            Languages.Location = new Point(103, 79);
            Languages.Name = "Languages";
            Languages.Size = new Size(419, 164);
            Languages.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(114, 36);
            label1.Name = "label1";
            label1.Size = new Size(396, 25);
            label1.TabIndex = 1;
            label1.Text = "My Favorite Programming Languages";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtLanguage);
            panel1.Controls.Add(Languages);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(71, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 386);
            panel1.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(103, 348);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 20);
            lblDate.TabIndex = 5;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 192, 192);
            btnRemove.Location = new Point(239, 304);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(130, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 192, 255);
            btnAdd.Location = new Point(103, 304);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLanguage
            // 
            txtLanguage.BackColor = Color.WhiteSmoke;
            txtLanguage.Location = new Point(103, 258);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(419, 27);
            txtLanguage.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Favorite Programming Languages";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox Languages;
        private Label label1;
        private Panel panel1;
        private TextBox txtLanguage;
        private Button btnRemove;
        private Button btnAdd;
        private Label lblDate;
    }
}
