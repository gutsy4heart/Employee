namespace Employee
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
            Information = new ListBox();
            button1 = new Button();
            label1 = new Label();
            buttonSaveFile = new Button();
            textBoxSurname = new TextBox();
            textBoxSalary = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxHome = new TextBox();
            label6 = new Label();
            comboBoxPosition = new ComboBox();
            comboBoxStreet = new ComboBox();
            comboBoxCity = new ComboBox();
            SuspendLayout();
            // 
            // Information
            // 
            Information.Anchor = AnchorStyles.Right;
            Information.BackColor = SystemColors.ActiveCaption;
            Information.FormattingEnabled = true;
            Information.ItemHeight = 15;
            Information.Location = new Point(257, 7);
            Information.Name = "Information";
            Information.Size = new Size(234, 379);
            Information.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(99, 352);
            button1.Name = "button1";
            button1.Size = new Size(78, 23);
            button1.TabIndex = 2;
            button1.Text = "Применить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Фамилия";
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Anchor = AnchorStyles.Bottom;
            buttonSaveFile.Location = new Point(324, 353);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(107, 23);
            buttonSaveFile.TabIndex = 4;
            buttonSaveFile.Text = "Вывести данные";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += button2_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(80, 9);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(171, 23);
            textBoxSurname.TabIndex = 5;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(80, 38);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(171, 23);
            textBoxSalary.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 38);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Зарплата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 67);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Должность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 94);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 10;
            label4.Text = "Город";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 125);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 12;
            label5.Text = "Улица";
            // 
            // textBoxHome
            // 
            textBoxHome.Location = new Point(80, 154);
            textBoxHome.Name = "textBoxHome";
            textBoxHome.Size = new Size(171, 23);
            textBoxHome.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 154);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 14;
            label6.Text = "Дом";
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Back-End разработчик", "Front-End разработчик", "Full-Stack разработчик" });
            comboBoxPosition.Location = new Point(80, 67);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(171, 23);
            comboBoxPosition.TabIndex = 16;
            comboBoxPosition.SelectedIndexChanged += comboBoxPosition_SelectedIndexChanged;
            // 
            // comboBoxStreet
            // 
            comboBoxStreet.FormattingEnabled = true;
            comboBoxStreet.Items.AddRange(new object[] { "Гейдар Алиев", "Бейкер-стрит", "Парк Авеню" });
            comboBoxStreet.Location = new Point(80, 125);
            comboBoxStreet.Name = "comboBoxStreet";
            comboBoxStreet.Size = new Size(171, 23);
            comboBoxStreet.TabIndex = 17;
            
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Items.AddRange(new object[] { "Баку", "Лондон", "Нью-Йорк" });
            comboBoxCity.Location = new Point(80, 96);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(171, 23);
            comboBoxCity.TabIndex = 18;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(489, 384);
            Controls.Add(comboBoxCity);
            Controls.Add(comboBoxStreet);
            Controls.Add(comboBoxPosition);
            Controls.Add(textBoxHome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSalary);
            Controls.Add(label2);
            Controls.Add(textBoxSurname);
            Controls.Add(buttonSaveFile);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Information);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox Information;
        private Button button1;
        private Label label1;
        private Button buttonSaveFile;
        private TextBox textBoxSurname;
        private TextBox textBoxSalary;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxHome;
        private Label label6;
        private ComboBox comboBoxPosition;
        private ComboBox comboBoxStreet;
        private ComboBox comboBoxCity;
    }
}
