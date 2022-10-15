using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyGWA
{
    public partial class MainForm12 : Form
    {

        public MainForm12()
        {
            InitializeComponent();
            
        }

        public MainForm12(string value)
        {
            InitializeComponent();
            Value = value;      

        }
        public string Value { get; set; }
        public string gradeValue { get; set; }


        public bool checkComponents()
        {
            bool isNull = false;

            string subject1Grade = subject1.Text; string unit1Grade = unit1.Text;
            string subject2Grade = subject2.Text; string unit2Grade = unit2.Text;
            string subject3Grade = subject3.Text; string unit3Grade = unit3.Text;
            string subject4Grade = subject4.Text; string unit4Grade = unit4.Text;
            string subject5Grade = subject5.Text; string unit5Grade = unit5.Text;
            string subject6Grade = subject6.Text; string unit6Grade = unit6.Text;
            string subject7Grade = subject7.Text; string unit7Grade = unit7.Text;
            string subject8Grade = subject8.Text; string unit8Grade = unit8.Text;
            string subject9Grade = subject9.Text; string unit9Grade = unit9.Text;
            string subject10Grade = subject10.Text; string unit10Grade = unit10.Text;
            string subject11Grade = subject11.Text; string unit11Grade = unit11.Text;
            string subject12Grade = subject12.Text; string unit12Grade = unit12.Text;
            try
            {
                if (subject1Grade.Equals("Select Grade")|| subject2Grade.Equals("Select Grade") || subject3Grade.Equals("Select Grade") || subject4Grade.Equals("Select Grade") ||
                    subject5Grade.Equals("Select Grade") || subject6Grade.Equals("Select Grade") || subject7Grade.Equals("Select Grade") || subject8Grade.Equals("Select Grade") ||
                    subject9Grade.Equals("Select Grade") || subject10Grade.Equals("Select Grade") || subject11Grade.Equals("Select Grade") || subject12Grade.Equals("Select Grade") || 
                    unit1Grade.Equals("Select Unit") || unit2Grade.Equals("Select Unit") || unit3Grade.Equals("Select Unit") || unit4Grade.Equals("Select Unit") ||
                    unit5Grade.Equals("Select Unit") || unit6Grade.Equals("Select Unit") || unit7Grade.Equals("Select Unit") || unit8Grade.Equals("Select Unit") ||
                    unit9Grade.Equals("Select Unit") || unit10Grade.Equals("Select Unit") || unit11Grade.Equals("Select Unit") || unit12Grade.Equals("Select Unit"))
                {
                    isNull = true;
                    MessageBox.Show("Please Select a Grade/Unit!");
                }
           
                }catch(Exception)
            {

            }

            return isNull;
        }

       public void toArrayGradesUnits()
        {
            string results;
            
            if (!checkComponents())
            {

                
                int numberOfSubjects = int.Parse(Value);
                

                double[] subjectGrades = new double[numberOfSubjects];
                double totalSub = 0;
                double[] subjectUnit = new double[numberOfSubjects];
                double totalUnit = 0;
                double[] equals = new double[numberOfSubjects];
                double gwa = 0;


                string subject1Grade = subject1.Text;
                double subject1Grades = double.Parse(subject1Grade);

                string subject2Grade = subject2.Text;
                double subject2Grades = double.Parse(subject2Grade);

                string subject3Grade = subject3.Text;
                double subject3Grades = double.Parse(subject3Grade);

                string subject4Grade = subject4.Text;
                double subject4Grades = double.Parse(subject4Grade);

                string subject5Grade = subject5.Text;
                double subject5Grades = double.Parse(subject5Grade);

                string subject6Grade = subject6.Text;
                double subject6Grades = double.Parse(subject6Grade);

                string subject7Grade = subject7.Text;
                double subject7Grades = double.Parse(subject7Grade);

                string subject8Grade = subject8.Text;
                double subject8Grades = double.Parse(subject8Grade);

                string subject9Grade = subject9.Text;
                double subject9Grades = double.Parse(subject9Grade);

                string subject10Grade = subject10.Text;
                double subject10Grades = double.Parse(subject10Grade);

                string subject11Grade = subject11.Text;
                double subject11Grades = double.Parse(subject11Grade);

                string subject12Grade = subject12.Text;
                double subject12Grades = double.Parse(subject12Grade);

                

                //subjectGrades[0] = subject1Grades;
                //subjectGrades[1] = subject2Grades;
                //subjectGrades[2] = subject3Grades;
                //subjectGrades[3] = subject4Grades;
                //subjectGrades[4] = subject5Grades;
                //subjectGrades[5] = subject6Grades;
                //subjectGrades[6] = subject7Grades;
                //subjectGrades[7] = subject8Grades;
                //subjectGrades[8] = subject9Grades;
                //subjectGrades[9] = subject10Grades;
                //subjectGrades[10] = subject11Grades;
                //subjectGrades[11] = subject12Grades;

                string unit1Grade = unit1.Text;
                double unit1Grades = double.Parse(unit1Grade);

                string unit2Grade = unit2.Text;
                double unit2Grades = double.Parse(unit2Grade);

                string unit3Grade = unit3.Text;
                double unit3Grades = double.Parse(unit3Grade);

                string unit4Grade = unit4.Text;
                double unit4Grades = double.Parse(unit4Grade);

                string unit5Grade = unit5.Text;
                double unit5Grades = double.Parse(unit5Grade);

                string unit6Grade = unit6.Text;
                double unit6Grades = double.Parse(unit6Grade);

                string unit7Grade = unit7.Text;
                double unit7Grades = double.Parse(unit7Grade);

                string unit8Grade = unit8.Text;
                double unit8Grades = double.Parse(unit8Grade);

                string unit9Grade = unit9.Text;
                double unit9Grades = double.Parse(unit9Grade);

                string unit10Grade = unit10.Text;
                double unit10Grades = double.Parse(unit10Grade);

                string unit11Grade = unit11.Text;
                double unit11Grades = double.Parse(unit11Grade);

                string unit12Grade = unit12.Text;
                double unit12Grades = double.Parse(unit12Grade);
                
                if (numberOfSubjects == 2)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;                    

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();
                }
                if (numberOfSubjects == 3)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();

                }

                if (numberOfSubjects == 4)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;
                    subjectGrades[3] = subject4Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;
                    subjectUnit[3] = unit4Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();
                }

                if (numberOfSubjects == 5)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;
                    subjectGrades[3] = subject4Grades;
                    subjectGrades[4] = subject5Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;
                    subjectUnit[3] = unit4Grades;
                    subjectUnit[4] = unit5Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();
                }

                if (numberOfSubjects == 6)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;
                    subjectGrades[3] = subject4Grades;
                    subjectGrades[4] = subject5Grades;
                    subjectGrades[5] = subject6Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;
                    subjectUnit[3] = unit4Grades;
                    subjectUnit[4] = unit5Grades;
                    subjectUnit[5] = unit6Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();
                }
                
                if (numberOfSubjects == 7)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;
                    subjectGrades[3] = subject4Grades;
                    subjectGrades[4] = subject5Grades;
                    subjectGrades[5] = subject6Grades;
                    subjectGrades[6] = subject7Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;
                    subjectUnit[3] = unit4Grades;
                    subjectUnit[4] = unit5Grades;
                    subjectUnit[5] = unit6Grades;
                    subjectUnit[6] = unit7Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();                   
                    
                }
                
                if (numberOfSubjects == 8)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;
                    subjectGrades[3] = subject4Grades;
                    subjectGrades[4] = subject5Grades;
                    subjectGrades[5] = subject6Grades;
                    subjectGrades[6] = subject7Grades;
                    subjectGrades[7] = subject8Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;
                    subjectUnit[3] = unit4Grades;
                    subjectUnit[4] = unit5Grades;
                    subjectUnit[5] = unit6Grades;
                    subjectUnit[6] = unit7Grades;
                    subjectUnit[7] = unit8Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();
                }
                if (numberOfSubjects == 9)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;
                    subjectGrades[3] = subject4Grades;
                    subjectGrades[4] = subject5Grades;
                    subjectGrades[5] = subject6Grades;
                    subjectGrades[6] = subject7Grades;
                    subjectGrades[7] = subject8Grades;
                    subjectGrades[8] = subject9Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;
                    subjectUnit[3] = unit4Grades;
                    subjectUnit[4] = unit5Grades;
                    subjectUnit[5] = unit6Grades;
                    subjectUnit[6] = unit7Grades;
                    subjectUnit[7] = unit8Grades;
                    subjectUnit[8] = unit9Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();
                }

                if (numberOfSubjects == 10)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;
                    subjectGrades[3] = subject4Grades;
                    subjectGrades[4] = subject5Grades;
                    subjectGrades[5] = subject6Grades;
                    subjectGrades[6] = subject7Grades;
                    subjectGrades[7] = subject8Grades;
                    subjectGrades[8] = subject9Grades;
                    subjectGrades[9] = subject10Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;
                    subjectUnit[3] = unit4Grades;
                    subjectUnit[4] = unit5Grades;
                    subjectUnit[5] = unit6Grades;
                    subjectUnit[6] = unit7Grades;
                    subjectUnit[7] = unit8Grades;
                    subjectUnit[8] = unit9Grades;
                    subjectUnit[9] = unit10Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();
                }
                if (numberOfSubjects == 11)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;
                    subjectGrades[3] = subject4Grades;
                    subjectGrades[4] = subject5Grades;
                    subjectGrades[5] = subject6Grades;
                    subjectGrades[6] = subject7Grades;
                    subjectGrades[7] = subject8Grades;
                    subjectGrades[8] = subject9Grades;
                    subjectGrades[9] = subject10Grades;
                    subjectGrades[10] = subject11Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;
                    subjectUnit[3] = unit4Grades;
                    subjectUnit[4] = unit5Grades;
                    subjectUnit[5] = unit6Grades;
                    subjectUnit[6] = unit7Grades;
                    subjectUnit[7] = unit8Grades;
                    subjectUnit[8] = unit9Grades;
                    subjectUnit[9] = unit10Grades;
                    subjectUnit[10] = unit11Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();
                }
                if (numberOfSubjects == 12)
                {
                    subjectGrades[0] = subject1Grades;
                    subjectGrades[1] = subject2Grades;
                    subjectGrades[2] = subject3Grades;
                    subjectGrades[3] = subject4Grades;
                    subjectGrades[4] = subject5Grades;
                    subjectGrades[5] = subject6Grades;
                    subjectGrades[6] = subject7Grades;
                    subjectGrades[7] = subject8Grades;
                    subjectGrades[8] = subject9Grades;
                    subjectGrades[9] = subject10Grades;
                    subjectGrades[10] = subject11Grades;
                    subjectGrades[11] = subject12Grades;

                    subjectUnit[0] = unit1Grades;
                    subjectUnit[1] = unit2Grades;
                    subjectUnit[2] = unit3Grades;
                    subjectUnit[3] = unit4Grades;
                    subjectUnit[4] = unit5Grades;
                    subjectUnit[5] = unit6Grades;
                    subjectUnit[6] = unit7Grades;
                    subjectUnit[7] = unit8Grades;
                    subjectUnit[8] = unit9Grades;
                    subjectUnit[9] = unit10Grades;
                    subjectUnit[11] = unit12Grades;


                    for (int i = 0; i < numberOfSubjects; i++)
                    {
                        equals[i] = subjectGrades[i] * subjectUnit[i];
                        totalUnit = totalUnit + subjectUnit[i];
                        totalSub = totalSub + equals[i];
                        gwa = totalSub / totalUnit;
                    }
                    results = String.Format("{0:0.0000}", gwa);
                    ResultForm resultForm = new ResultForm(results);
                    resultForm.Show();
                }


            }      
            
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblCounter.Text = "You have " + Value + " subject/s";

            subject1.SelectedIndex = 0; unit1.SelectedIndex = 0;
            subject2.SelectedIndex = 0; unit2.SelectedIndex = 0;
            subject3.SelectedIndex = 0; unit3.SelectedIndex = 0;
            subject4.SelectedIndex = 0; unit4.SelectedIndex = 0;
            subject5.SelectedIndex = 0; unit5.SelectedIndex = 0;
            subject6.SelectedIndex = 0; unit6.SelectedIndex = 0;
            subject7.SelectedIndex = 0; unit7.SelectedIndex = 0;
            subject8.SelectedIndex = 0; unit8.SelectedIndex = 0;
            subject9.SelectedIndex = 0; unit9.SelectedIndex = 0;
            subject10.SelectedIndex = 0; unit10.SelectedIndex = 0;
            subject11.SelectedIndex = 0; unit11.SelectedIndex = 0;
            subject12.SelectedIndex = 0; unit12.SelectedIndex = 0;

            int numberOfSubjects = int.Parse(Value);

            string newVal = "0.00";
            if (numberOfSubjects == 2)
            {
                subject3.Visible = false; unit3.Visible = false;
                subject4.Visible = false; unit4.Visible = false;
                subject5.Visible = false; unit5.Visible = false;
                subject6.Visible = false; unit6.Visible = false;
                subject7.Visible = false; unit7.Visible = false;
                subject8.Visible = false; unit8.Visible = false;
                subject9.Visible = false; unit9.Visible = false;
                subject10.Visible = false; unit10.Visible = false;
                subject11.Visible = false; unit11.Visible = false;
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 176);
                //btnCompute.Location = new System.Drawing.Point(62, 176);
                //btnAdd.Location = new System.Drawing.Point(203, 176);

                btnBack.Location = new System.Drawing.Point(10, 207);
                btnExit.Location = new System.Drawing.Point(282, 207);

                this.Size = new System.Drawing.Size(369, 235);
                if (subject3.SelectedIndex == 0)
                {
                    subject3.Items[0] = newVal; unit3.Items[0] = newVal;
                    subject4.Items[0] = newVal; unit4.Items[0] = newVal;
                    subject5.Items[0] = newVal; unit5.Items[0] = newVal;
                    subject6.Items[0] = newVal; unit6.Items[0] = newVal;
                    subject7.Items[0] = newVal; unit7.Items[0] = newVal;
                    subject8.Items[0] = newVal; unit8.Items[0] = newVal;
                    subject9.Items[0] = newVal; unit9.Items[0] = newVal;
                    subject10.Items[0] = newVal; unit10.Items[0] = newVal;
                    subject11.Items[0] = newVal; unit11.Items[0] = newVal;
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }
            }
            if (numberOfSubjects == 3)
            {

                subject4.Visible = false; unit4.Visible = false;
                subject5.Visible = false; unit5.Visible = false;
                subject6.Visible = false; unit6.Visible = false;
                subject7.Visible = false; unit7.Visible = false;
                subject8.Visible = false; unit8.Visible = false;
                subject9.Visible = false; unit9.Visible = false;
                subject10.Visible = false; unit10.Visible = false;
                subject11.Visible = false; unit11.Visible = false;
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 176);
                //btnCompute.Location = new System.Drawing.Point(62, 176);
                //btnAdd.Location = new System.Drawing.Point(203, 176);

                btnBack.Location = new System.Drawing.Point(10, 207);
                btnExit.Location = new System.Drawing.Point(282, 207);

                this.Size = new System.Drawing.Size(369, 235);
                if (subject4.SelectedIndex == 0)
                {
                    
                    subject4.Items[0] = newVal; unit4.Items[0] = newVal;
                    subject5.Items[0] = newVal; unit5.Items[0] = newVal;
                    subject6.Items[0] = newVal; unit6.Items[0] = newVal;
                    subject7.Items[0] = newVal; unit7.Items[0] = newVal;
                    subject8.Items[0] = newVal; unit8.Items[0] = newVal;
                    subject9.Items[0] = newVal; unit9.Items[0] = newVal;
                    subject10.Items[0] = newVal; unit10.Items[0] = newVal;
                    subject11.Items[0] = newVal; unit11.Items[0] = newVal;
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }      
            }

            if (numberOfSubjects == 4)
            {

                subject5.Visible = false; unit5.Visible = false;
                subject6.Visible = false; unit6.Visible = false;
                subject7.Visible = false; unit7.Visible = false;
                subject8.Visible = false; unit8.Visible = false;
                subject9.Visible = false; unit9.Visible = false;
                subject10.Visible = false; unit10.Visible = false;
                subject11.Visible = false; unit11.Visible = false;
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 207);
                //btnCompute.Location = new System.Drawing.Point(61, 207);
                //btnAdd.Location = new System.Drawing.Point(202, 207);

                btnBack.Location = new System.Drawing.Point(10, 238);
                btnExit.Location = new System.Drawing.Point(282, 238);

                this.Size = new System.Drawing.Size(369, 268);

                if (subject5.SelectedIndex == 0)
                {            
                    subject5.Items[0] = newVal; unit5.Items[0] = newVal;
                    subject6.Items[0] = newVal; unit6.Items[0] = newVal;
                    subject7.Items[0] = newVal; unit7.Items[0] = newVal;
                    subject8.Items[0] = newVal; unit8.Items[0] = newVal;
                    subject9.Items[0] = newVal; unit9.Items[0] = newVal;
                    subject10.Items[0] = newVal; unit10.Items[0] = newVal;
                    subject11.Items[0] = newVal; unit11.Items[0] = newVal;
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }
            }

            if (numberOfSubjects == 5)
            {

                subject6.Visible = false; unit6.Visible = false;
                subject7.Visible = false; unit7.Visible = false;
                subject8.Visible = false; unit8.Visible = false;
                subject9.Visible = false; unit9.Visible = false;
                subject10.Visible = false; unit10.Visible = false;
                subject11.Visible = false; unit11.Visible = false;
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 238);
                //btnCompute.Location = new System.Drawing.Point(61, 238);
                //btnAdd.Location = new System.Drawing.Point(202, 238);

                btnBack.Location = new System.Drawing.Point(10, 269);
                btnExit.Location = new System.Drawing.Point(282, 269);

                this.Size = new System.Drawing.Size(369, 301);

                if (subject6.SelectedIndex == 0)
                {
                    subject6.Items[0] = newVal; unit6.Items[0] = newVal;
                    subject7.Items[0] = newVal; unit7.Items[0] = newVal;
                    subject8.Items[0] = newVal; unit8.Items[0] = newVal;
                    subject9.Items[0] = newVal; unit9.Items[0] = newVal;
                    subject10.Items[0] = newVal; unit10.Items[0] = newVal;
                    subject11.Items[0] = newVal; unit11.Items[0] = newVal;
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }
            }

            if (numberOfSubjects == 6)
            {
  
                subject7.Visible = false; unit7.Visible = false;
                subject8.Visible = false; unit8.Visible = false;
                subject9.Visible = false; unit9.Visible = false;
                subject10.Visible = false; unit10.Visible = false;
                subject11.Visible = false; unit11.Visible = false;
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 269);
                //btnCompute.Location = new System.Drawing.Point(61, 269);
                //btnAdd.Location = new System.Drawing.Point(202, 269);

                btnBack.Location = new System.Drawing.Point(10, 300);
                btnExit.Location = new System.Drawing.Point(282, 300);

                this.Size = new System.Drawing.Size(369, 334);

                if (subject7.SelectedIndex == 0)
                {             
                    subject7.Items[0] = newVal; unit7.Items[0] = newVal;
                    subject8.Items[0] = newVal; unit8.Items[0] = newVal;
                    subject9.Items[0] = newVal; unit9.Items[0] = newVal;
                    subject10.Items[0] = newVal; unit10.Items[0] = newVal;
                    subject11.Items[0] = newVal; unit11.Items[0] = newVal;
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }
            }

            if (numberOfSubjects == 7)
            {        
                subject8.Visible = false; unit8.Visible = false;
                subject9.Visible = false; unit9.Visible = false;
                subject10.Visible = false; unit10.Visible = false;
                subject11.Visible = false; unit11.Visible = false;
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 300);
                //btnCompute.Location = new System.Drawing.Point(61, 300);
                //btnAdd.Location = new System.Drawing.Point(202, 300);

                btnBack.Location = new System.Drawing.Point(10, 331);
                btnExit.Location = new System.Drawing.Point(282, 331);

                this.Size = new System.Drawing.Size(369, 367);

                if (subject8.SelectedIndex == 0)
                {
                    subject8.Items[0] = newVal; unit8.Items[0] = newVal;
                    subject9.Items[0] = newVal; unit9.Items[0] = newVal;
                    subject10.Items[0] = newVal; unit10.Items[0] = newVal;
                    subject11.Items[0] = newVal; unit11.Items[0] = newVal;
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }
            }

            if (numberOfSubjects == 8)
            {      
                subject9.Visible = false; unit9.Visible = false;
                subject10.Visible = false; unit10.Visible = false;
                subject11.Visible = false; unit11.Visible = false;
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 331);
                //btnCompute.Location = new System.Drawing.Point(61, 331);
                //btnAdd.Location = new System.Drawing.Point(202, 332);

                btnBack.Location = new System.Drawing.Point(10, 362);
                btnExit.Location = new System.Drawing.Point(282, 362);

                this.Size = new System.Drawing.Size(369, 400);
                if (subject9.SelectedIndex == 0)
                {
                    subject9.Items[0] = newVal; unit9.Items[0] = newVal;
                    subject10.Items[0] = newVal; unit10.Items[0] = newVal;
                    subject11.Items[0] = newVal; unit11.Items[0] = newVal;
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }
            }

            if (numberOfSubjects == 9)
            {
                subject10.Visible = false; unit10.Visible = false;
                subject11.Visible = false; unit11.Visible = false;
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 362);
                //btnCompute.Location = new System.Drawing.Point(61, 362);
                //btnAdd.Location = new System.Drawing.Point(202, 362);

                btnBack.Location = new System.Drawing.Point(10, 393);
                btnExit.Location = new System.Drawing.Point(282, 393);

                this.Size = new System.Drawing.Size(369, 433);

                if (subject10.SelectedIndex == 0)
                {
                    subject10.Items[0] = newVal; unit10.Items[0] = newVal;
                    subject11.Items[0] = newVal; unit11.Items[0] = newVal;
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }
            }
            if (numberOfSubjects == 10)
            {
                
                subject11.Visible = false; unit11.Visible = false;
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 393);
                //btnCompute.Location = new System.Drawing.Point(61, 393);
                //btnAdd.Location = new System.Drawing.Point(202, 393);

                btnBack.Location = new System.Drawing.Point(10, 424);
                btnExit.Location = new System.Drawing.Point(282, 424);

                this.Size = new System.Drawing.Size(369, 466);

                if (subject11.SelectedIndex == 0)
                {
                    subject11.Items[0] = newVal; unit11.Items[0] = newVal;
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }
            }

            if (numberOfSubjects == 11)
            {       
                subject12.Visible = false; unit12.Visible = false;

                btnCompute.Location = new System.Drawing.Point(130, 424);
                //btnCompute.Location = new System.Drawing.Point(61, 424);
                //btnAdd.Location = new System.Drawing.Point(202, 424);

                btnBack.Location = new System.Drawing.Point(10, 455);
                btnExit.Location = new System.Drawing.Point(282, 455);

                this.Size = new System.Drawing.Size(369, 499);

                if (subject11.SelectedIndex == 0)
                {       
                    subject12.Items[0] = newVal; unit12.Items[0] = newVal;
                }
            }

            if(numberOfSubjects == 12)
            {
                
            }

        }

        private void subject1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject1.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject2.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject3.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            
            toArrayGradesUnits();
        }

        private void subject4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject4.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject5.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject6.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject7.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject8.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject9.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject10.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject11.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void subject12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && subject12.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit1.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit2.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit3.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit4.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit5.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit6.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit7.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit8.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit9.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit10.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit11.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void unit12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && unit12.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.Show();
            this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }

        private void subject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject1.SelectedIndex != 0)
            {
                subject1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
            
        }

        private void subject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject2.SelectedIndex != 0)
            {
                subject2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject3.SelectedIndex != 0)
            {
                subject3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject3.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject4.SelectedIndex != 0)
            {
                subject4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject4.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject5.SelectedIndex != 0)
            {
                subject5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject6.SelectedIndex != 0)
            {
                subject6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject6.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject7.SelectedIndex != 0)
            {
                subject7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject7.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject8.SelectedIndex != 0)
            {
                subject8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject8.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject9.SelectedIndex != 0)
            {
                subject9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject9.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject10.SelectedIndex != 0)
            {
                subject10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject10.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject11.SelectedIndex != 0)
            {
                subject11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject11.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subject12.SelectedIndex != 0)
            {
                subject12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                subject12.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit1.SelectedIndex != 0)
            {
                unit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit2.SelectedIndex != 0)
            {
                unit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit3.SelectedIndex != 0)
            {
                unit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit3.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit4.SelectedIndex != 0)
            {
                unit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit4.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit5.SelectedIndex != 0)
            {
                unit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit6.SelectedIndex != 0)
            {
                unit6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit6.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit7.SelectedIndex != 0)
            {
                unit7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit7.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit8.SelectedIndex != 0)
            {
                unit8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit8.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit9.SelectedIndex != 0)
            {
                unit9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit9.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit10.SelectedIndex != 0)
            {
                unit10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit10.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit11.SelectedIndex != 0)
            {
                unit11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit11.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unit12.SelectedIndex != 0)
            {
                unit12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }
            else
            {
                unit12.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject1_Leave(object sender, EventArgs e)
        {
            string subject1Grade = subject1.Text;

            if (!subject1Grade.Equals("Select Grade"))
            {
                subject1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject1Grades = double.Parse(subject1Grade);
                if (subject1Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject1.SelectedIndex = 0;
                }                                    
            }
            else
            {
                subject1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject2_Leave(object sender, EventArgs e)
        {
            string subject2Grade = subject2.Text;

            if (!subject2Grade.Equals("Select Grade"))
            {
                subject2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject2Grades = double.Parse(subject2Grade);
                if (subject2Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject2.SelectedIndex = 0;
                }
            }
            else
            {
                subject2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject3_Leave(object sender, EventArgs e)
        {
            string subject3Grade = subject3.Text;

            if (!subject3Grade.Equals("Select Grade"))
            {
                subject3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject3Grades = double.Parse(subject3Grade);
                if (subject3Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject3.SelectedIndex = 0;
                }
            }
            else
            {
                subject3.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject4_Leave(object sender, EventArgs e)
        {
            string subject4Grade = subject4.Text;

            if (!subject4Grade.Equals("Select Grade"))
            {
                subject4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject4Grades = double.Parse(subject4Grade);
                if (subject4Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject4.SelectedIndex = 0;
                }
            }
            else
            {
                subject4.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject5_Leave(object sender, EventArgs e)
        {
            string subject5Grade = subject5.Text;

            if (!subject5Grade.Equals("Select Grade"))
            {
                subject5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject5Grades = double.Parse(subject5Grade);
                if (subject5Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject5.SelectedIndex = 0;
                }
            }
            else
            {
                subject5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject6_Leave(object sender, EventArgs e)
        {
            string subject6Grade = subject6.Text;

            if (!subject6Grade.Equals("Select Grade"))
            {
                subject6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject6Grades = double.Parse(subject6Grade);
                if (subject6Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject6.SelectedIndex = 0;
                }
            }
            else
            {
                subject6.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject7_Leave(object sender, EventArgs e)
        {
            string subject7Grade = subject7.Text;

            if (!subject7Grade.Equals("Select Grade"))
            {
                subject7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject7Grades = double.Parse(subject7Grade);
                if (subject7Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject7.SelectedIndex = 0;
                }
            }
            else
            {
                subject7.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject8_Leave(object sender, EventArgs e)
        {
            string subject8Grade = subject8.Text;

            if (!subject8Grade.Equals("Select Grade"))
            {
                subject8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject8Grades = double.Parse(subject8Grade);
                if (subject8Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject8.SelectedIndex = 0;
                }
            }
            else
            {
                subject8.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject9_Leave(object sender, EventArgs e)
        {
            string subject9Grade = subject9.Text;

            if (!subject9Grade.Equals("Select Grade"))
            {
                subject9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject9Grades = double.Parse(subject9Grade);
                if (subject9Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject9.SelectedIndex = 0;
                }
            }
            else
            {
                subject9.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject10_Leave(object sender, EventArgs e)
        {
            string subject10Grade = subject10.Text;

            if (!subject10Grade.Equals("Select Grade"))
            {
                subject10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject10Grades = double.Parse(subject10Grade);
                if (subject10Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject10.SelectedIndex = 0;
                }
            }
            else
            {
                subject10.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject11_Leave(object sender, EventArgs e)
        {
            string subject11Grade = subject11.Text;

            if (!subject11Grade.Equals("Select Grade"))
            {
                subject11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject11Grades = double.Parse(subject11Grade);
                if (subject11Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject11.SelectedIndex = 0;
                }
            }
            else
            {
                subject11.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void subject12_Leave(object sender, EventArgs e)
        {
            string subject12Grade = subject12.Text;

            if (!subject12Grade.Equals("Select Grade"))
            {
                subject12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double subject12Grades = double.Parse(subject12Grade);
                if (subject12Grades > 5)
                {
                    MessageBox.Show("Input is too high.");
                    subject12.SelectedIndex = 0;
                }
            }
            else
            {
                subject12.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit1_Leave(object sender, EventArgs e)
        {
            string unit1Grade = unit1.Text;

            if (!unit1Grade.Equals("Select Unit"))
            {
                unit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit1Grades = double.Parse(unit1Grade);
                if (unit1Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit1.SelectedIndex = 0;
                }
            }
            else
            {
                unit1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit2_Leave(object sender, EventArgs e)
        {
            string unit2Grade = unit2.Text;

            if (!unit2Grade.Equals("Select Unit"))
            {
                unit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit2Grades = double.Parse(unit2Grade);
                if (unit2Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit2.SelectedIndex = 0;
                }
            }
            else
            {
                unit2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit3_Leave(object sender, EventArgs e)
        {
            string unit3Grade = unit3.Text;

            if (!unit3Grade.Equals("Select Unit"))
            {
                unit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit3Grades = double.Parse(unit3Grade);
                if (unit3Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit3.SelectedIndex = 0;
                }
            }
            else
            {
                unit3.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit4_Leave(object sender, EventArgs e)
        {
            string unit4Grade = unit4.Text;

            if (!unit4Grade.Equals("Select Unit"))
            {
                unit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit4Grades = double.Parse(unit4Grade);
                if (unit4Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit4.SelectedIndex = 0;
                }
            }
            else
            {
                unit4.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit5_Leave(object sender, EventArgs e)
        {
            string unit5Grade = unit5.Text;

            if (!unit5Grade.Equals("Select Unit"))
            {
                unit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit5Grades = double.Parse(unit5Grade);
                if (unit5Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit5.SelectedIndex = 0;
                }
            }
            else
            {
                unit5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit6_Leave(object sender, EventArgs e)
        {
            string unit6Grade = unit6.Text;

            if (!unit6Grade.Equals("Select Unit"))
            {
                unit6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit6Grades = double.Parse(unit6Grade);
                if (unit6Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit6.SelectedIndex = 0;
                }
            }
            else
            {
                unit6.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit7_Leave(object sender, EventArgs e)
        {
            string unit7Grade = unit7.Text;

            if (!unit7Grade.Equals("Select Unit"))
            {
                unit7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit7Grades = double.Parse(unit7Grade);
                if (unit7Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit7.SelectedIndex = 0;
                }
            }
            else
            {
                unit7.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit8_Leave(object sender, EventArgs e)
        {
            string unit8Grade = unit8.Text;

            if (!unit8Grade.Equals("Select Unit"))
            {
                unit8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit8Grades = double.Parse(unit8Grade);
                if (unit8Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit8.SelectedIndex = 0;
                }
            }
            else
            {
                unit8.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit9_Leave(object sender, EventArgs e)
        {
            string unit9Grade = unit9.Text;

            if (!unit9Grade.Equals("Select Unit"))
            {
                unit9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit9Grades = double.Parse(unit9Grade);
                if (unit9Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit9.SelectedIndex = 0;
                }
            }
            else
            {
                unit9.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit10_Leave(object sender, EventArgs e)
        {
            string unit10Grade = unit10.Text;

            if (!unit10Grade.Equals("Select Unit"))
            {
                unit10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit10Grades = double.Parse(unit10Grade);
                if (unit10Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit10.SelectedIndex = 0;
                }
            }
            else
            {
                unit10.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit11_Leave(object sender, EventArgs e)
        {
            string unit11Grade = unit11.Text;

            if (!unit11Grade.Equals("Select Unit"))
            {
                unit11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit11Grades = double.Parse(unit11Grade);
                if (unit11Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit11.SelectedIndex = 0;
                }
            }
            else
            {
                unit11.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        private void unit12_Leave(object sender, EventArgs e)
        {
            string unit12Grade = unit12.Text;

            if (!unit12Grade.Equals("Select Unit"))
            {
                unit12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                double unit12Grades = double.Parse(unit12Grade);
                if (unit12Grades > 6)
                {
                    MessageBox.Show("Input is too high.");
                    unit12.SelectedIndex = 0;
                }
            }
            else
            {
                unit12.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }
        }

        int mov;
        int movX;
        int movY;

        private void MainForm12_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void MainForm12_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);

            }
        }

        private void MainForm12_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
