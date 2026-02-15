using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        string cs =
        "Server=localhost\\SQLEXPRESS;Database=pushpam;Trusted_Connection=True;TrustServerCertificate=True;";

        DataSet ds = new DataSet();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            //  Load DEPT
            SqlDataAdapter daDept =
                new SqlDataAdapter("SELECT * FROM DEPT", con);

            daDept.Fill(ds, "DEPT");

            // Load EMP
            SqlDataAdapter daEmp =
                new SqlDataAdapter("SELECT * FROM EMP", con);

            daEmp.Fill(ds, "EMP");

            //  Load PROJECT
            SqlDataAdapter daProj =
                new SqlDataAdapter("SELECT * FROM PROJECT", con);

            daProj.Fill(ds, "PROJECT");
        }

        // 🔹 Disconnected Mode Starts Here

        Console.WriteLine("=== Departments ===");
        PrintTable(ds.Tables["DEPT"]);

        Console.WriteLine("\n=== Employees ===");
        PrintTable(ds.Tables["EMP"]);

        Console.WriteLine("\n=== Projects ===");
        PrintTable(ds.Tables["PROJECT"]);

        //  Create Relation (Like Foreign Key in Memory)
        DataRelation rel =
            new DataRelation(
                "Dept_Emp",
                ds.Tables["DEPT"].Columns["ID"],
                ds.Tables["EMP"].Columns["DEPTID"]
            );

        ds.Relations.Add(rel);

        Console.WriteLine("\n=== Employees by Department ===");

        foreach (DataRow dept in ds.Tables["DEPT"].Rows)
        {
            Console.WriteLine("\nDepartment: " + dept["DEPTNAME"]);

            DataRow[] emps = dept.GetChildRows("Dept_Emp");

            foreach (DataRow emp in emps)
            {
                Console.WriteLine("   " + emp["EMPNAME"]);
            }
        }
    }

    static void PrintTable(DataTable table)
    {
        foreach (DataRow row in table.Rows)
        {
            foreach (var item in row.ItemArray)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}
