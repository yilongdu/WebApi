using MyWebApi.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.DataAsistent
{
    public class StudentAsistent : IAsistentBase<StudentModel>
    {
        public int Add(StudentModel t)
        {
            List<string> cols = new List<string>();
            List<string> vals = new List<string>();
            if(!string.IsNullOrEmpty(t.Name))
            {
                cols.Add("'Name'");
                vals.Add("'" + t.Name + "'");
            }
            string cmdStr = string.Format("insert into student ({0}) values ({1})", string.Join(",", cols), string.Join(",", vals));
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DataHelper.connStr;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdStr;
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int Delete(StudentModel t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public StudentModel Get(int id)
        {
            if (id<=0)
            {
                return null;
            }
            object obj = null;
            string cmdStr = "select * from student where id=" + id;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DataHelper.connStr;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdStr;
                    obj = cmd.ExecuteScalar();
                }
            }
            return new StudentModel();
        }

        public List<StudentModel> GetList(StudentModel t)
        {
            throw new NotImplementedException();
        }

        public int Update(StudentModel t)
        {
            throw new NotImplementedException();
        }
    }
}
