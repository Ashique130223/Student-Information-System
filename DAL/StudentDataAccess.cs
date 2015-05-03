using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class StudentDataAccess
    {
        #region saveStudentInfo

        public bool saveStudentInfo(Student s)
        {
            try
            {
                StreamWriter write = new StreamWriter("E:\\Programing\\C Sharp  ( C#)\\Visual Studio 2013\\Projects\\ThreeLayerTest\\Text.txt", true);
                write.WriteLine(s.roll);
                write.WriteLine(s.name);
                write.WriteLine(s.batch);
                write.WriteLine(s.address);
                write.WriteLine(s.year);
                write.WriteLine(s.term);
                write.WriteLine(s.contact);

                write.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        #endregion

        #region getStudentInfo

        public Student[] getStudentInfo()
        {
            try
            {
                StreamReader r = new StreamReader("E:\\Programing\\C Sharp  ( C#)\\Visual Studio 2013\\Projects\\ThreeLayerTest\\Text.txt");

                Student[] sr = new Student[200];
                int i = 0;
                string f = r.ReadLine();
                while (f != null)
                {
                    sr[i] = new Student();
                    sr[i].roll = f;
                    sr[i].name = r.ReadLine();
                    sr[i].batch = r.ReadLine();
                    sr[i].address = r.ReadLine();
                    sr[i].year = r.ReadLine();
                    sr[i].term = r.ReadLine();
                    sr[i].contact = r.ReadLine();
                    f = r.ReadLine();
                    i++;
                }

                r.Close();
                return sr;

            }
            catch (Exception e)
            {

                return null;
            }
        }
        #endregion
    }
}
