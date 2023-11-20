﻿using System.Collections.ObjectModel;
using University.WPF.Models.Base;

namespace University.WPF.Models
{
    internal class GroupModel : BaseModel
    {
        private string _name;
        private string _courseId;
        private CourseModel _course;
        private TeacherModel? _tutor;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string CourseId
        {
            get => _courseId;
            set
            {
                _courseId = value;
                OnPropertyChanged();
            }
        }
        public CourseModel Course
        {
            get => _course;
            set
            {
                _course = value;
                OnPropertyChanged();
            }
        }
        public TeacherModel Tutor
        {
            get => _tutor;
            set
            {
                _tutor = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<StudentModel> Students { get; set; }
    }
}
