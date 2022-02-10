using System;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{   
    public partial class Form1 : Form
    {
        string Gender = "";   
        int BirthDay, BirthMonth, BirthYear;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i=1;i<=31;i++)
            {
                Day.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                Month.Items.Add(i);
            }
            for (int i=1900;i<=2021;i++)
            {
                Year.Items.Add(i);
            }
           
        }

        private void RegisterStudent_Click(object sender, EventArgs e)
        {
            if (Male.Checked) Gender = Male.Text;
            else Gender = Female.Text;

            if (Day.Text != "-Day-" && Month.Text != "-Month-" && Year.Text != "-Year-")
            {
                BirthDay = (int)Day.SelectedItem;
                BirthMonth = (int)Month.SelectedItem;
                BirthYear = (int)Year.SelectedItem;
            }

            MessageBox.Show("Student name: " + FirstName.Text + " " + LastName.Text + " " +
                                               MiddleName.Text + "\nGender: " + 
                                               Gender + "\nDate of birth: " + 
                                               BirthDay + "/" + BirthMonth + "/" + BirthYear);
        }
    }
}
