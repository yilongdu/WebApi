using MyWebApi.Common;
using MyWebApi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentModel model = new StudentModel();
            model.Name = "张三";
            string URL = Veriables.WebApiHost + Veriables.StudentControler;
            Fuctions.SendRequest<StudentModel>(model, URL, HttpMethod.Get);
        }
    }
}
