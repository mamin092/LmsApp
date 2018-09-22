using Common.ViewModel;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Model;

namespace ViewModel
{
    public class TeacherViewModel : BaseViewModel<Teacher>
    {
        public TeacherViewModel(Teacher teacher) : base(teacher)
        {
            Name = teacher.Name;
            Phone = teacher.Phone;
            Course = teacher.Course;
            TotalCredit = teacher.TotalCredit;
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Course { get; set; }
        public double TotalCredit { get; set; }

    }
}
