namespace Employee
{
    public partial class Form1 : Form
    {
        string employeeInfo = "employeeFile.txt";
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
              string.IsNullOrWhiteSpace(textBoxSalary.Text) ||
              string.IsNullOrWhiteSpace(textBoxHome.Text))
            {
                MessageBox.Show("����������, ��������� ��� ������������ ����.");
                return;
            }

            if (!decimal.TryParse(textBoxSalary.Text, out _))
            {
                MessageBox.Show("����������, ������� ���������� ����� ��� ��������.");
                return;
            }


            using (StreamWriter ws = new StreamWriter(employeeInfo, true))
            {
                
                    ws.WriteLine(@$"�������:{textBoxSurname.Text}
��������: {textBoxSalary.Text}
���������: {comboBoxPosition.Text}
�����: {comboBoxCity.Text} 
�����: {comboBoxStreet.Text}
���: {textBoxHome.Text}
------------------------------");
                
            }
            ClearAllFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(employeeInfo))
            {
                using (StreamReader sr = new StreamReader(employeeInfo))
                {
                    Information.Items.Clear();

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Information.Items.Add(line);
                    }
                }
            }
        }

        private void ClearAllFields()
        {
            textBoxSurname.Clear();
            textBoxSalary.Clear();
            textBoxHome.Clear();
            comboBoxCity.Text = "";
            comboBoxPosition.Text = "";
            comboBoxStreet.Text = "";
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPosition.SelectedIndex == comboBoxPosition.Items.Count - 1)
            {
                comboBoxPosition.Visible = true;
            }           
        }       
    }
}

