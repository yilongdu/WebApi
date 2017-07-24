using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.Model
{
    public class StudentModel:ViewModelBase
    {
        private int _ID = 0;
        public int ID
        {
            get
            { return _ID; }
            set
            {
                RaisePropertyChanged(() => ID); _ID = value;
            }
        }

        private string _Name = "";
        public string Name
        {
            get
            { return _Name; }
            set
            {
                _Name = value;
                RaisePropertyChanged(() => Name);
            }
        }
        private string _Sex = "";
        public string Sex
        {
            get
            { return _Sex; }
            set
            {
                _Sex = value;
                RaisePropertyChanged(() => Sex);
            }
        }

        private int _Age = 0;
        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                RaisePropertyChanged(() => Age);
            }
        }

        private string _Grade = "";
        public string Grade
        {
            get { return _Grade; }
            set { _Grade = value; RaisePropertyChanged(() => Grade); }
        }

        private int _IsDelete = 0;
        public int IsDelete
        {
            get { return _IsDelete; }
            set
            {
                _IsDelete = value;
                RaisePropertyChanged(() => IsDelete);
            }
        }
    }
}
