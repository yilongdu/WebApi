using MyWebApi.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
            if (!string.IsNullOrEmpty(t.Name))
            {
                cols.Add("Name");
                vals.Add("'" + t.Name + "'");
            }
            if (t.Age > 0)
            {
                cols.Add("Age");
                vals.Add("'" + t.Age + "'");
            }
            if (!string.IsNullOrEmpty(t.Grade))
            {
                cols.Add("Grade");
                vals.Add("'" + t.Grade + "'");
            }
            if (!string.IsNullOrEmpty(t.Sex))
            {
                cols.Add("Sex");
                vals.Add("'" + t.Sex + "'");
            }
            string cmdStr = string.Format("insert into student ({0}) values ({1})", string.Join(",", cols), string.Join(",", vals));
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DataHelper.connStr;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdStr;
                    conn.Open();
                    int p = cmd.ExecuteNonQuery();
                    conn.Close();
                    return p;
                }
            }
        }

        public int Delete(StudentModel t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            if (id <= 0)
            {
                return false;
            }
            string cmdStr = "update student set isdelete=1 where id=" + id;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DataHelper.connStr;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdStr;
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (a > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public StudentModel Get(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            SqlDataReader obj = null;
            string cmdStr = "select * from student where id=" + id;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DataHelper.connStr;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdStr;
                    conn.Open();
                    obj = cmd.ExecuteReader();

                    StudentModel ret = new StudentModel();
                    while (obj.Read())
                    {
                        ret.Age = obj["Age"] == DBNull.Value ? 0 : Convert.ToInt32(obj["Age"]);
                        ret.Grade = obj["Grade"] == DBNull.Value ? "" : obj["Grade"].ToString();
                        ret.ID = obj["ID"] == DBNull.Value ? 0 : Convert.ToInt32(obj["ID"]);
                        ret.Name = obj["Name"] == DBNull.Value ? "" : obj["Name"].ToString();
                        ret.Sex = obj["Sex"] == DBNull.Value ? "" : obj["Sex"].ToString();
                    }
                    conn.Close();
                    return ret;
                }
            }
        }

        public List<StudentModel> GetList(StudentModel t)
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(t.Name))
            {
                sb.Append(" and Name='" + t.Name + "'");
            }
            if (t.Age > 0)
            {
                sb.Append(" and Age='" + t.Age + "'");
            }
            if (!string.IsNullOrEmpty(t.Grade))
            {
                sb.Append(" and Grade='" + t.Grade + "'");
            }
            if (!string.IsNullOrEmpty(t.Sex))
            {
                sb.Append(" and Sex='" + t.Sex + "'");
            }
            string cmdStr = string.Format("select * from student where 1=1 {0}", sb.ToString());
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DataHelper.connStr;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdStr;
                    conn.Open();
                    var p = cmd.ExecuteReader();
                    List<StudentModel> stuList = new List<StudentModel>();
                    while (p.Read())
                    {
                        StudentModel ret = new StudentModel();
                        ret.Age = p["Age"] == DBNull.Value ? 0 : Convert.ToInt32(p["Age"]);
                        ret.Grade = p["Grade"] == DBNull.Value ? "" : p["Grade"].ToString();
                        ret.ID = p["ID"] == DBNull.Value ? 0 : Convert.ToInt32(p["ID"]);
                        ret.Name = p["Name"] == DBNull.Value ? "" : p["Name"].ToString();
                        ret.Sex = p["Sex"] == DBNull.Value ? "" : p["Sex"].ToString();
                        stuList.Add(ret);
                    }
                    conn.Close();
                    return stuList;
                }
            }
        }

        public int Update(int id, StudentModel t)
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(t.Name))
            {
                sb.Append(" Name='" + t.Name + "',");
            }
            if (t.Age > 0)
            {
                sb.Append(" Age='" + t.Age + "',");
            }
            if (!string.IsNullOrEmpty(t.Grade))
            {
                sb.Append(" Grade='" + t.Grade + "',");
            }
            if (!string.IsNullOrEmpty(t.Sex))
            {
                sb.Append(" Sex='" + t.Sex + "',");
            }
            if(sb.Length==0)
            {
                return 0;
            }
            string cmdStr = string.Format("update student set {0} where id={1}", sb.ToString().TrimEnd(','), id);
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DataHelper.connStr;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdStr;
                    conn.Open();
                    int p = cmd.ExecuteNonQuery();
                    conn.Close();
                    return p;
                }
            }
        }
    }
}
