using System.Drawing.Text;
using System.Xml.Linq;

namespace FinalOOP
{
    public partial class Form1 : Form
    {
        private List<Advisor> advisors = new List<Advisor>();
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            UpdateStudentList();
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            string advisorName = tbADname.Text;
            string advisorMajor = tbADmajor.Text;

            Advisor newAdvisor = new Advisor(advisorName, advisorMajor);
            advisors.Add(newAdvisor);
            cbbAdvisor.Items.Add(newAdvisor);



            //Clear
            tbADname.Clear();
            tbADmajor.Clear();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentID = tbSDid.Text;
            string studentName = tbSDname.Text;
            string studentMajor = tbSDmajor.Text;
            double grade;

            if (!double.TryParse(tbSDgrade.Text, out grade))
            {
                MessageBox.Show("กรุณากรอกเกรดเป็นตัวเลข");
                return;
            }

            if (cbbAdvisor.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษา");
                return;
            }
            Advisor advisor = cbbAdvisor.SelectedItem as Advisor;

            if (advisor == null)
            {
                MessageBox.Show("ไม่พบข้อมูลอาจารย์ที่ปรึกษา");
                return;
            }



            string advisorName = cbbAdvisor.SelectedItem.ToString();

            Student student = new Student(studentID, studentName, studentMajor, grade, advisor);
            students.Add(student);
            advisor.AddStudent(student);

            lbid.Text = student.ID;
            lbname.Text = student.Name;
            lbmajor.Text = student.Major;
            lbgrade.Text = student.Grade.ToString();
            lbadvisor.Text = student.Advisor.ToString();

            UpdateStudentList();
            MessageBox.Show("เพิ่มข้อมูลนักศึกษาเรียบร้อยแล้ว!");

            //Clear
            tbSDid.Clear();
            tbSDname.Clear();
            tbSDmajor.Clear();
            tbSDgrade.Clear();
            cbbAdvisor.SelectedIndex = -1;
        }

        private void UpdateStudentList()
        {
            lsbStudent.Items.Clear();
            foreach (var student in students)
            {
                lsbStudent.Items.Add(student.Name);
            }
        }

        private void btnShowGrade_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students recorded.");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            MessageBox.Show($"Top Student: {topStudent.Name} Grade: {topStudent.Grade} ");
        }

        private void lsbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbStudent.SelectedIndex != -1)
            {

                string selectedName = lsbStudent.SelectedItem.ToString();


                Student student = students.FirstOrDefault(s => s.Name == selectedName);


                if (student != null)
                {
                    lbid.Text = student.ID;
                    lbname.Text = student.Name;
                    lbmajor.Text = student.Major;
                    lbgrade.Text = student.Grade.ToString();
                    lbadvisor.Text = student.Advisor.Name;
                }
            }
        }

        private void cbbAdvisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
