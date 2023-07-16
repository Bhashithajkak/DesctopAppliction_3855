using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace DesktopApplication_1
{
    
    public partial class MainWindowVM: ObservableObject
    {
        //students observablecollection 
        [ObservableProperty]
        public ObservableCollection<Student>students;

        
        [ObservableProperty]
        public Student selectedStudent = null;


        //Delete student function 

        [RelayCommand]
        public void DeleteStudent()
        {
            if(selectedStudent != null) {
                students.Remove(selectedStudent);
            }
        }



        //Main Window close
        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }  
        

        

        // Modify student function
        [RelayCommand]
        public void ModifyStudent()
        {
            
            if (selectedStudent != null)
            {
                var vm = new ModifyWindowVM(selectedStudent);
                vm.Title = "Modify Student Data";
                var window = new ModifyWindow(vm);
                window.ShowDialog();


                
                if (vm.IsSaved)
                {
                    
                    int index = students.IndexOf(selectedStudent);
                    students.RemoveAt(index);
                    students.Insert(index, vm.student1);
                }
            
            }
            else
            {
                MessageBox.Show("Select a Student Before Modify!");
            }
        }



        //Add student function
        [RelayCommand]
        public void AddStudent()
        {
            Student newStudent = new Student();
            newStudent.Image = new BitmapImage(new Uri("/Images/1.png", UriKind.Relative));
            var vm = new ModifyWindowVM(newStudent);
            vm.Title = "Register New Student";
            var window=new ModifyWindow(vm);
            window.ShowDialog();
            if(vm.IsSaved)
            {
                students.Add(vm.student1);
            }
            
            
        }
        [RelayCommand]
        public void Exit()
        {
            CloseMainWindow();
        }
        public MainWindowVM()
        {
            students = new ObservableCollection<Student>();

            BitmapImage image1 = new BitmapImage(new Uri("/Images/1.png", UriKind.Relative));
            students.Add(new Student("Kavindu1", "Bhashitha1", 23, image1, "2000/07/26", 3.02));
            BitmapImage image2 = new BitmapImage(new Uri("/Images/2.png", UriKind.Relative));
            students.Add(new Student("Kavindu2", "Bhashitha2", 23, image2, "2000/07/26", 3.52));
            
        }


    }
}
