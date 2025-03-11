namespace FinalOOP
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
            label1 = new Label();
            label2 = new Label();
            tbSDid = new TextBox();
            tbSDname = new TextBox();
            tbSDmajor = new TextBox();
            tbADname = new TextBox();
            tbADmajor = new TextBox();
            lsbStudent = new ListBox();
            btnAddAdvisor = new Button();
            btnAddStudent = new Button();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            cbbAdvisor = new ComboBox();
            label10 = new Label();
            tbSDgrade = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            lbgrade = new Label();
            lbmajor = new Label();
            lbname = new Label();
            lbid = new Label();
            lbadvisor = new Label();
            label24 = new Label();
            groupBox1 = new GroupBox();
            btnShowGrade = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F, FontStyle.Bold);
            label1.Location = new Point(128, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Bold);
            label2.Location = new Point(402, 20);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 1;
            label2.Text = "Advisor";
            // 
            // tbSDid
            // 
            tbSDid.Location = new Point(97, 52);
            tbSDid.Name = "tbSDid";
            tbSDid.Size = new Size(145, 23);
            tbSDid.TabIndex = 2;
            // 
            // tbSDname
            // 
            tbSDname.Location = new Point(97, 94);
            tbSDname.Name = "tbSDname";
            tbSDname.Size = new Size(145, 23);
            tbSDname.TabIndex = 3;
            // 
            // tbSDmajor
            // 
            tbSDmajor.Location = new Point(97, 143);
            tbSDmajor.Name = "tbSDmajor";
            tbSDmajor.Size = new Size(145, 23);
            tbSDmajor.TabIndex = 5;
            // 
            // tbADname
            // 
            tbADname.Location = new Point(365, 52);
            tbADname.Name = "tbADname";
            tbADname.Size = new Size(145, 23);
            tbADname.TabIndex = 6;
            // 
            // tbADmajor
            // 
            tbADmajor.Location = new Point(365, 94);
            tbADmajor.Name = "tbADmajor";
            tbADmajor.Size = new Size(145, 23);
            tbADmajor.TabIndex = 8;
            // 
            // lsbStudent
            // 
            lsbStudent.FormattingEnabled = true;
            lsbStudent.ItemHeight = 15;
            lsbStudent.Location = new Point(586, 55);
            lsbStudent.Name = "lsbStudent";
            lsbStudent.Size = new Size(181, 124);
            lsbStudent.TabIndex = 9;
            lsbStudent.SelectedIndexChanged += lsbStudent_SelectedIndexChanged;
            // 
            // btnAddAdvisor
            // 
            btnAddAdvisor.Location = new Point(365, 184);
            btnAddAdvisor.Name = "btnAddAdvisor";
            btnAddAdvisor.Size = new Size(145, 41);
            btnAddAdvisor.TabIndex = 10;
            btnAddAdvisor.Text = "Add Advisor";
            btnAddAdvisor.UseVisualStyleBackColor = true;
            btnAddAdvisor.Click += btnAddAdvisor_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(97, 213);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(145, 41);
            btnAddStudent.TabIndex = 11;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(13, 55);
            label3.Name = "label3";
            label3.Size = new Size(78, 14);
            label3.TabIndex = 12;
            label3.Text = "Student ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(24, 97);
            label4.Name = "label4";
            label4.Size = new Size(45, 14);
            label4.TabIndex = 13;
            label4.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.Location = new Point(24, 146);
            label6.Name = "label6";
            label6.Size = new Size(45, 14);
            label6.TabIndex = 15;
            label6.Text = "Major";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.Location = new Point(292, 55);
            label7.Name = "label7";
            label7.Size = new Size(45, 14);
            label7.TabIndex = 16;
            label7.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label9.Location = new Point(293, 97);
            label9.Name = "label9";
            label9.Size = new Size(45, 14);
            label9.TabIndex = 18;
            label9.Text = "Major";
            // 
            // cbbAdvisor
            // 
            cbbAdvisor.FormattingEnabled = true;
            cbbAdvisor.Location = new Point(365, 143);
            cbbAdvisor.Name = "cbbAdvisor";
            cbbAdvisor.Size = new Size(145, 23);
            cbbAdvisor.TabIndex = 20;
            cbbAdvisor.SelectedIndexChanged += cbbAdvisor_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label10.Location = new Point(24, 187);
            label10.Name = "label10";
            label10.Size = new Size(47, 14);
            label10.TabIndex = 22;
            label10.Text = "Grade";
            // 
            // tbSDgrade
            // 
            tbSDgrade.Location = new Point(97, 184);
            tbSDgrade.Name = "tbSDgrade";
            tbSDgrade.Size = new Size(145, 23);
            tbSDgrade.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label11.Location = new Point(250, 146);
            label11.Name = "label11";
            label11.Size = new Size(109, 14);
            label11.TabIndex = 23;
            label11.Text = "Choose Advisor";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label12.Location = new Point(101, 34);
            label12.Name = "label12";
            label12.Size = new Size(89, 14);
            label12.TabIndex = 24;
            label12.Text = "Info Student";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label13.Location = new Point(41, 77);
            label13.Name = "label13";
            label13.Size = new Size(78, 14);
            label13.TabIndex = 25;
            label13.Text = "Student ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label14.Location = new Point(41, 114);
            label14.Name = "label14";
            label14.Size = new Size(45, 14);
            label14.TabIndex = 26;
            label14.Text = "Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label16.Location = new Point(41, 149);
            label16.Name = "label16";
            label16.Size = new Size(45, 14);
            label16.TabIndex = 28;
            label16.Text = "Major";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label17.Location = new Point(41, 187);
            label17.Name = "label17";
            label17.Size = new Size(47, 14);
            label17.TabIndex = 29;
            label17.Text = "Grade";
            // 
            // lbgrade
            // 
            lbgrade.AutoSize = true;
            lbgrade.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lbgrade.Location = new Point(179, 187);
            lbgrade.Name = "lbgrade";
            lbgrade.Size = new Size(57, 14);
            lbgrade.TabIndex = 34;
            lbgrade.Text = "label18";
            // 
            // lbmajor
            // 
            lbmajor.AutoSize = true;
            lbmajor.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lbmajor.Location = new Point(179, 149);
            lbmajor.Name = "lbmajor";
            lbmajor.Size = new Size(57, 14);
            lbmajor.TabIndex = 33;
            lbmajor.Text = "label19";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lbname.Location = new Point(179, 114);
            lbname.Name = "lbname";
            lbname.Size = new Size(57, 14);
            lbname.TabIndex = 31;
            lbname.Text = "label21";
            // 
            // lbid
            // 
            lbid.AutoSize = true;
            lbid.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lbid.Location = new Point(179, 77);
            lbid.Name = "lbid";
            lbid.Size = new Size(57, 14);
            lbid.TabIndex = 30;
            lbid.Text = "label22";
            // 
            // lbadvisor
            // 
            lbadvisor.AutoSize = true;
            lbadvisor.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lbadvisor.Location = new Point(179, 225);
            lbadvisor.Name = "lbadvisor";
            lbadvisor.Size = new Size(57, 14);
            lbadvisor.TabIndex = 36;
            lbadvisor.Text = "label23";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label24.Location = new Point(41, 225);
            label24.Name = "label24";
            label24.Size = new Size(57, 14);
            label24.TabIndex = 35;
            label24.Text = "Advisor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbadvisor);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(lbgrade);
            groupBox1.Controls.Add(lbmajor);
            groupBox1.Controls.Add(lbname);
            groupBox1.Controls.Add(lbid);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(43, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 296);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "InfoGroup";
            // 
            // btnShowGrade
            // 
            btnShowGrade.Location = new Point(586, 200);
            btnShowGrade.Name = "btnShowGrade";
            btnShowGrade.Size = new Size(181, 58);
            btnShowGrade.TabIndex = 38;
            btnShowGrade.Text = "Show Grade";
            btnShowGrade.UseVisualStyleBackColor = true;
            btnShowGrade.Click += btnShowGrade_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 677);
            Controls.Add(btnShowGrade);
            Controls.Add(groupBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(tbSDgrade);
            Controls.Add(cbbAdvisor);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAddStudent);
            Controls.Add(btnAddAdvisor);
            Controls.Add(lsbStudent);
            Controls.Add(tbADmajor);
            Controls.Add(tbADname);
            Controls.Add(tbSDmajor);
            Controls.Add(tbSDname);
            Controls.Add(tbSDid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbSDid;
        private TextBox tbSDname;
        private TextBox tbSDmajor;
        private TextBox tbADname;
        private TextBox tbADmajor;
        private ListBox lsbStudent;
        private Button btnAddAdvisor;
        private Button btnAddStudent;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label9;
        private ComboBox cbbAdvisor;
        private Label label10;
        private TextBox tbSDgrade;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label lbgrade;
        private Label lbmajor;
        private Label lbname;
        private Label lbid;
        private Label lbadvisor;
        private Label label24;
        private GroupBox groupBox1;
        private Button btnShowGrade;
    }
}
