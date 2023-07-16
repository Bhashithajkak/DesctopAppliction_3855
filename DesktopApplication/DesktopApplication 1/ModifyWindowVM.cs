using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace DesktopApplication_1
{
   public partial class ModifyWindowVM: ObservableObject
    {

        [ObservableProperty]
        public string firstName;
        [ObservableProperty]
        public string lastName;
        [ObservableProperty]
        public int age;
        [ObservableProperty]
        public BitmapImage image;
        [ObservableProperty]
        public string dateOfBirth;
        [ObservableProperty]
        public double gpa;

        


        
        public ModifyWindowVM(Student student)
        {
            
            firstName = student.FirstName;
            lastName = student.LastName;
            age = student.Age;
            dateOfBirth=student.DateofBirth;
            gpa = student.Gpa;
            image = student.Image;

        }

        
        public ModifyWindowVM()
        {
            
  
        }
        
        public string Title { get; set; }
        
        public Student student1 { get; set; }
        
        public Action CloseAction { get; set; }



        public bool IsSaved { get; set; }

        //save function
        [RelayCommand]
        public void Save()
        {
            if (firstName != null && lastName != null)
            {
                if (firstName.Length < 1 || lastName.Length < 1 || dateOfBirth == null || gpa == null)
                {
                    MessageBox.Show("Please Completely Information");
                }
                else if (gpa < 0 || 4 < gpa)
                {
                    MessageBox.Show("Invalid GPA");
                }
                else
                {
                    student1 = new Student(firstName, lastName, age, image, dateOfBirth, gpa);
                    CloseAction();
                    IsSaved = true;
                }
            }else
            {
                MessageBox.Show("Please Completely Information");
            }
            
            
            
            
        }

        [RelayCommand]
        public void CloseModifyWindow() {
            CloseAction();
        }
    

        [RelayCommand]
        public void AddImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if(openFileDialog.ShowDialog() == true)
            {
                image = new BitmapImage(new Uri(openFileDialog.FileName)); 
            }
        }
        }
    }
