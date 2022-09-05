using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022
{
    public class DataBaseFirstApproach
    {
        public static void Main()
        {

            //  getAllEmpDetails();
            // getAllEmpDetailsByID();
            // AddEmployee();
            // GetEmployeesUsingSPWithoutParameter();
            //GetEmployeesUsingSPWithParameter();

            CallStoredProcwithSQLParamater_insert();

            Console.ReadLine();

        }
        //private static void GetEmployeesUsingSPWithoutParameter()
        //{
        //    var ctx = new TrainingContext();
        //    var employee = ctx.Emps.FromSqlRaw("sp_GetEmployeeEname").ToList();

        //    foreach (var e in employee)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }
        //}
        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new TrainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                        ParameterName = "@empno",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Size = 100,
                        Direction = System.Data.
                        ParameterDirection.Input,
                        Value = 22819
                        },

                        new SqlParameter() {
                        ParameterName = "@ename",
                        SqlDbType = System.Data.
                        SqlDbType.VarChar,
                        Size = 100,
                        Direction = System.Data.
                        ParameterDirection.Input,
                        Value = "Arun"},


                        new SqlParameter() {
                        ParameterName = "@deptno",
                        SqlDbType = System.Data.
                        SqlDbType.Int,
                        Size = 100,
                        Direction = System.Data.
                        ParameterDirection.Input,
                        Value = 10},

                        new SqlParameter() {
                        ParameterName = "@job",
                        SqlDbType = System.Data.
                        SqlDbType.VarChar,
                        Size = 100,
                        Direction = System.Data.
                        ParameterDirection.Input,
                        Value = "DET"},


                         new SqlParameter() {
                        ParameterName = "@sal",
                        SqlDbType = System.Data.
                        SqlDbType.Int,
                        Size = 100,
                        Direction = System.Data.
                        ParameterDirection.Input,
                        Value = 10000},

                          new SqlParameter() {
                        ParameterName = "@deptno",
                        SqlDbType = System.Data.
                        SqlDbType.Int,
                        Size = 100,
                        Direction = System.Data.
                        ParameterDirection.Input,
                        Value = 10}





                        };


                        try
                        {
                      var result = ctx.Database.ExecuteSqlRaw("AddNewEmployee @empno, @ename,@job,@sal,@deptno", param);
                           Console.WriteLine("added");
                        }
                           catch (Exception ex)
                        {

                         throw;
                         
                         }

                        Console.WriteLine("update successful");


                        }

        //private static void GetEmployeesUsingSPWithParameter()
        //{
        //    {
        //        var ctx = new TrainingContext();

        //        var employees = ctx.Emps.FromSqlRaw("GetEmpsDetail @p0", 7521).ToList();


        //        foreach (var e in employees)
        //        {
        //            Console.WriteLine(e.Ename);
        //        }
        //    }
        //public static void getAllEmpDetailsByID()
        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    Console.WriteLine(emp.Ename +" " +emp.Sal + " " +emp.Job);  
        //}

        //public static void getAllEmpDetails()
        //{
        //    var ctx = new TrainingContext();
        //    //    var emps = ctx.Emps;
        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7369;
        //        employee.Ename = "SMITH";
        //       // employee.Sal = 2000;
        //        employee.Deptno = 20;

        //        employee.Job = "Mgr";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New Employee Updated");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //    foreach (var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename + "  "+emp.Sal);
        //    }
        //}
        //public static void AddEmployee()
        //{
        //    var ctx = new TrainingContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 2219;
        //        employee.Ename = "Arun";
        //        employee.Sal = 2000;
        //        employee.Deptno = 10;
        //        employee.Job = "DET";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New Employee added");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

    }
}
