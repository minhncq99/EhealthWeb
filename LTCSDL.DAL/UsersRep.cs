using LTCSDL.Common.DAL;
using System.Linq;
using LTCSDL.DAL.Models;
using System;
using LTCSDL.Common.Rsp;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace LTCSDL.DAL
{
    public class UsersRep : GenericRep<EhealthContext, User>
    {
        #region -- Overide --
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override User Read(int id)
        {
            var res = All.FirstOrDefault(p => p.UserId == id);
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Remove(int id)
        {
            var m = All.First(p => p.UserId == id);
            m = base.Delete(m);
            return m.UserId;
        }


        #endregion

        #region -- Methods --
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SingleRsp CreateUser(string FullName, string UserName, string Password,
            string Email, string Job, int TypeUser)
        {
            var res = new SingleRsp();


            // Check Email
            bool emailIsTrue = Regex.IsMatch(Email, 
                @"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$");
            if (!emailIsTrue) 
            {
                res.SetError("Email is not valid!");
                return res;
            }

            // Check Password(có tổi thiểu 8 kí tự và ít nhất 1 kí tự in hoa 1 số)
            bool passwordIsTrue = Regex.IsMatch(Password,
                @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            if (!passwordIsTrue) 
            {
                res.SetError("Password is not valid");
                return res;
            }

            bool userNameIsTrue = Regex.IsMatch(UserName,
                @"^[a-z0-9_-]{5,20}$");
            if (!userNameIsTrue)
            {
                res.SetError("Username is not valid");
                return res;
            }

            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        User newUser = new User();
                        newUser.FullName = FullName;
                        newUser.UserName = UserName;
                        newUser.Password = Password;
                        newUser.Email = Email;
                        newUser.Job = Job;
                        newUser.TypeUser = TypeUser;
                        var t = context.Users.Add(newUser);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (TypeUser != 0 && TypeUser != 1)
                        {
                            tran.Rollback();
                            res.SetError("TypeUser không hợp lệ");
                        }
                        else
                        {
                            tran.Rollback();
                            res.SetError(ex.StackTrace);
                        }
                    }
                }
            }
            return res;
        }

        public SingleRsp UpdateUser(int UserId ,string FullName, string UserName, string Password,
            string Email, string Job, int TypeUser)
        {
            var res = new SingleRsp();

            // Check Email
            bool emailIsTrue = Regex.IsMatch(Email,
                @"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$");
            if (!emailIsTrue)
            {
                res.SetError("Email is not valid!");
                return res;
            }

            // Check Password(có tổi thiểu 8 kí tự và ít nhất 1 kí tự in hoa 1 số)
            bool passwordIsTrue = Regex.IsMatch(Password,
                @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            if (!passwordIsTrue)
            {
                res.SetError("Password is not valid");
                return res;
            }

            bool userNameIsTrue = Regex.IsMatch(UserName,
                @"^[a-z0-9_-]{5,20}$");
            if (!userNameIsTrue)
            {
                res.SetError("Username is not valid");
                return res;
            }

            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Users.Find(UserId);
                        if(res.Data == null)
                        {
                            res.SetError("Not found!");
                            return res;
                        }
                        else
                        {
                            User newUser = new User();
                            newUser.UserId = UserId;
                            newUser.FullName = FullName;
                            newUser.UserName = UserName;
                            newUser.Password = Password;
                            newUser.Email = Email;
                            newUser.Job = Job;
                            newUser.TypeUser = TypeUser;
                            context.Entry(res.Data).CurrentValues.SetValues(newUser);

                            context.SaveChanges();
                            tran.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }

        public SingleRsp DeleteUser(int userId)
        {
            var res = new SingleRsp();
            using (var context = new EhealthContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        res.Data = context.Users.Find(userId);
                        context.Remove(res.Data);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;
        }

        public object checkTypeUser(int userId)
        {
            object res = new object();
            var cnn = (SqlConnection)Context.Database.GetDbConnection();
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                var cmd = cnn.CreateCommand();
                cmd.CommandText = "checkTypeUser";
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(ds);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var x = new
                        {
                            TypeUser = row["TypeUser"]
                        };
                        res = x;
                    }
                }
            }
            catch (Exception e)
            {
                res = null;
            }
            return res;
        }
        #endregion
    }
}
