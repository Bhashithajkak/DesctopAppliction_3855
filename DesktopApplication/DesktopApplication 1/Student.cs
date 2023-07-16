using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace DesktopApplication_1
{
   public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public BitmapImage Image { get; set; }

        public string DateofBirth { get; set; }
        public double Gpa { get; set; }

      

        public Student(string firstName, string lastName, int age, BitmapImage image, string dateofBirth, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Image = image;
            DateofBirth = dateofBirth;
            Gpa = gpa;
        }

       
        public Student()
        {
           
        }
        
       
        
    }


}
