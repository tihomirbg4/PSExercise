using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentInfoSystem
{
    public class MainFormVM : INotifyPropertyChanged
    {
        private Student _student;
        public Student Student
        {
            get { return _student; }
            set { _student = value; RaisePropertyChangedEvent("Student"); }
        }

        public List<string> StudStatusChoices { get; set; }

        private TestCommand _testCommand = new TestCommand();

        public event PropertyChangedEventHandler PropertyChanged;

      

        public TestCommand TestCommand
        {
            get { return _testCommand; }
        }

        public MainFormVM()
        {
            Student = new Student();
            FillStudStatusChoices();

        }
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery = @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)

                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }
    }
}
