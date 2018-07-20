using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Services;

namespace MyCourse.AdminUserControls
{
    public partial class createCourseUserControl : UserControl
    {
        AddCourseEntities AddCourseEntities = new AddCourseEntities();
        AddCourseService AddCourseService = new AddCourseService();

        public string section1, section2, section3;
        public static int sectionNumber;

        public string section1StartingTime, section2StartingTime, section3StartingTime;
        public string section1EndingTime, section2EndingTime, section3EndingTime;

        private void secondDayBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = secondDayBox1.SelectedItem.ToString();
        }

        private void firstDayBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = firstDayBox2.SelectedItem.ToString();
        }

        private void secondDayBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = secondDayBox2.SelectedItem.ToString();
        }

        private void firstDayBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = firstDayBox3.SelectedIndex.ToString();
        }

        private void startingTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            section1StartingTime = startingTimePicker1.Text ;
        }

        private void endingTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            section1EndingTime = endingTimePicker1.Text;
        }

        private void startingTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            section2StartingTime = startingTimePicker2.Text;
        }

        private void endingTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            section2EndingTime = endingTimePicker2.Text;
        }

        private void startingTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            section3StartingTime = startingTimePicker3.Text;
        }

        private void endingTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            section3EndingTime = endingTimePicker3.Text;
        }

        private void secondDayBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = secondDayBox3.Text.ToString();
        }


        private void firstDayBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = firstDayBox1.SelectedItem.ToString();
        }

        

        public createCourseUserControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            courseName.Text = "";
            sectionComboBox.Text ="";
        }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sectionComboBox.SelectedItem.ToString() == "1")
            {
                secAPanel.Visible = true;
                secBPanel.Visible = false;
                secCPanel.Visible = false;
               
                section1 = sectionALabel.Text;
                sectionNumber = 1;
               
                

            }
            else if (sectionComboBox.SelectedItem.ToString() == "2")
            {
                secAPanel.Visible = true;
                secBPanel.Visible = true;
                secCPanel.Visible = false;
                
                section1 = sectionALabel.Text;
                section2 = secBLabel.Text;
                sectionNumber = 2;

                //section1StartingTime = startingTimePicker1.Text;
                //section1EndingTime = endingTimePicker1.Text;
               
                

            }
            else if (sectionComboBox.SelectedItem.ToString() == "3")
            {
                secAPanel.Visible = true;
                secBPanel.Visible = true;
                secCPanel.Visible = true;
                
                section1 = sectionALabel.Text;
                section2 = secBLabel.Text;
                section3 = secCLabel.Text;
                sectionNumber = 3;

                //section1StartingTime = startingTimePicker1.Text;
                //section1EndingTime = endingTimePicker1.Text;
                //section2StartingTime = startingTimePicker2.Text;
                //section2EndingTime = endingTimePicker2.Text;
                
               

          
            }
           
        }

        void clear()
        {
            courseName.Text = "";
            sectionComboBox.Text = "";
            secAPanel.Visible = false;
            secBPanel.Visible = false;
            secCPanel.Visible = false;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (courseName.Text == "" || sectionComboBox.Text == "" || sectionComboBox.SelectedItem.ToString() == "1" && firstDayBox1.Text == "" || sectionComboBox.SelectedItem.ToString() == "1" && secondDayBox1.Text == "" || sectionComboBox.SelectedItem.ToString() == "2" && firstDayBox1.Text == "" || sectionComboBox.SelectedItem.ToString() == "2" && firstDayBox2.Text == "" || sectionComboBox.SelectedItem.ToString() == "2" && secondDayBox1.Text == "" || sectionComboBox.SelectedItem.ToString() == "2" && secondDayBox2.Text == "" || sectionComboBox.SelectedItem.ToString() == "3" && firstDayBox1.Text == "" || sectionComboBox.SelectedItem.ToString() == "3" && firstDayBox2.Text == "" || sectionComboBox.SelectedItem.ToString() == "3" && firstDayBox3.Text == "" || sectionComboBox.SelectedItem.ToString() == "3" && secondDayBox1.Text == "" || sectionComboBox.SelectedItem.ToString() == "3" && secondDayBox2.Text == "" || sectionComboBox.SelectedItem.ToString() == "3" && secondDayBox3.Text == "")
            {

                { MessageBox.Show("complete the empty field!!!"); }
            }


            else
            {
                AddCourseEntities.CourseName = courseName.Text;
                AddCourseEntities.SectionName1 = section1;
                AddCourseEntities.SectionName2 = section2;
                AddCourseEntities.SectionName3 = section3;

                AddCourseEntities.SectionNumber = sectionNumber;

                AddCourseEntities.Section1StartingTime = section1StartingTime;
                AddCourseEntities.Section1EndingTime = section1EndingTime;

                AddCourseEntities.Section1FirstDay = textBox1.Text;
                AddCourseEntities.Section1SecondDay = textBox2.Text;

                AddCourseEntities.Section2StartingTime = section2StartingTime;
                AddCourseEntities.Section2EndingTime = section2EndingTime;

                AddCourseEntities.Section2FirstDay = textBox3.Text;
                AddCourseEntities.Section2SecondDay = textBox4.Text;

                AddCourseEntities.Section3StartingTime = section3StartingTime;
                AddCourseEntities.Section3EndingTime = section3EndingTime;

                AddCourseEntities.Section3FirstDay = textBox5.Text;
                AddCourseEntities.Section3SecondDay = textBox6.Text;


                AddCourseService.AddCourse(AddCourseEntities);
                clear();

                if (sectionComboBox.SelectedItem.ToString() == "1")
                {
                    string folderName = AddCourseEntities.CourseName + AddCourseEntities.SectionName1;
                    string path = @"C:\Users\HP\Desktop\AIUB\project\C#\Coursefolder\" + folderName; // or whatever  
                    if (!System.IO.Directory.Exists(path))
                    {
                        System.IO.Directory.CreateDirectory(path);
                    }
                    else
                    {
                        MessageBox.Show("Folder Already Created");
                    }
                }
                else if (sectionComboBox.SelectedItem.ToString() == "2")
                {

                    string folderName1 = AddCourseEntities.CourseName + AddCourseEntities.SectionName1;
                    string path1 = @"C:\Users\HP\Desktop\AIUB\project\C#\Coursefolder\" + folderName1; // or whatever  
                    if (!System.IO.Directory.Exists(path1))
                    {
                        System.IO.Directory.CreateDirectory(path1);
                    }
                    else
                    {
                        MessageBox.Show("Folder Already Created");
                    }
                    string folderName2 = AddCourseEntities.CourseName + AddCourseEntities.SectionName2;
                    string path2 = @"C:\Users\HP\Desktop\AIUB\project\C#\Coursefolder\" + folderName2; // or whatever  
                    if (!System.IO.Directory.Exists(path2))
                    {
                        System.IO.Directory.CreateDirectory(path2);
                    }
                    else
                    {
                        MessageBox.Show("Folder Already Created");
                    }
                }
                else if (sectionComboBox.SelectedItem.ToString() == "3")
                {

                    string folderName1 = AddCourseEntities.CourseName + AddCourseEntities.SectionName1;
                    string path1 = @"C:\Users\HP\Desktop\AIUB\project\C#\Coursefolder\" + folderName1; // or whatever  
                    if (!System.IO.Directory.Exists(path1))
                    {
                        System.IO.Directory.CreateDirectory(path1);
                    }
                    else
                    {
                        MessageBox.Show("Folder Already Created");
                    }
                    string folderName2 = AddCourseEntities.CourseName + AddCourseEntities.SectionName2;
                    string path2 = @"C:\Users\HP\Desktop\AIUB\project\C#\Coursefolder\" + folderName2; // or whatever  
                    if (!System.IO.Directory.Exists(path2))
                    {
                        System.IO.Directory.CreateDirectory(path2);
                    }
                    else
                    {
                        MessageBox.Show("Folder Already Created");
                    }
                    string folderName3 = AddCourseEntities.CourseName + AddCourseEntities.SectionName3;
                    string path3 = @"C:\Users\HP\Desktop\AIUB\project\C#\Coursefolder\" + folderName3; // or whatever  
                    if (!System.IO.Directory.Exists(path3))
                    {
                        System.IO.Directory.CreateDirectory(path3);
                    }
                    else
                    {
                        MessageBox.Show("Folder Already Created");
                    }
                }
            }

               
           
        }
    }
}
