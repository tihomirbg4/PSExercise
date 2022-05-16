using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Student student = StudentData.TestStudents[0];

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public List<string> StudStatusChoices { get; set; }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здрасти!!! Това е твоята първа програма на Visual Studio 2022!");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void fillFieldWithData(Student student)
        {
            foreach (var item in mainGrid.Children)
            {
                if (item is TextBox)
                {
                    var textBox = (TextBox)item;
                    switch (textBox.Name)
                    {
                        case "firstName":
                            {

                                textBox.Text = student.firstName;
                                break;
                            }
                        case "middleName":
                            {
                                textBox.Text = student.middleName;
                                break;
                            }
                        case "lastName":
                            {
                                textBox.Text = student.lastName;
                                break;
                            }
                        case "faculty":
                            {
                                textBox.Text = student.faculty;
                                break;
                            }
                        case "major":
                            {
                                textBox.Text = student.major;
                                break;
                            }
                        case "QualificationDegree":
                            {
                                textBox.Text = student.qualificationDegree;
                                break;
                            }
                        case "status":
                            {
                                textBox.Text = student.status;
                                break;
                            }
                        case "facultyNumber":
                            {
                                textBox.Text = student.facultyNumber;
                                break;
                            }
                        case "course":
                            {
                                textBox.Text = student.course.ToString();
                                break;
                            }
                        case "stream":
                            {
                                textBox.Text = student.stream.ToString();
                                break;
                            }
                        case "group":
                            {
                                textBox.Text = student.group.ToString();
                                break;
                            }
                    }
                }
            }
        }

        private void clearTxtBoxes()
        {
            foreach (var item in mainGrid.Children)
            {
                if (item is TextBox)
                {
                    var textBox = (TextBox)item;
                    textBox.Text = "";
                }
            }
        }

        private void enableOrDisableGridCtrls(bool isEnabled)
        {
            foreach (var item in mainGrid.Children)
            {
                UIElement element = item as UIElement;
                element.IsEnabled = isEnabled;
                if (element is Button)
                {
                    btnEnable.IsEnabled = true;
                }
            }
        }

        private void btnEnable_Click(object sender, RoutedEventArgs e)
        {
            enableOrDisableGridCtrls(true);
        }

        private void btnDisable_Click(object sender, RoutedEventArgs e)
        {
            enableOrDisableGridCtrls(false);
        }

        private void btnStudentInfo_Click(object sender, RoutedEventArgs e)
        {
            fillFieldWithData(student);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            clearTxtBoxes();
        }

    }
}
