using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MyWebApi.Common;
using MyWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFClient.ViewModel
{
    public class StudentViewModel : ViewModelBase
    {
        public StudentViewModel()
        {

        }
        #region 属性和变量

        private StudentModel _Student;
        public StudentModel Student
        {
            get { return _Student; }
            set
            {
                Student = value;
                RaisePropertyChanged(() => Student);
            }
        }

        private string URL = Veriables.WebApiHost + Veriables.StudentControler;

        #endregion

        #region 命令

        private ICommand _ConfirmCommand;
        public ICommand ConfirmCommand
        {
            get
            {
                if(_ConfirmCommand==null)
                {
                    _ConfirmCommand = new RelayCommand(OnConfirmCommandExecute);
                }
                return _ConfirmCommand;
            }
        }

        #endregion

        public void OnConfirmCommandExecute()
        {
            
        }
    }
}
