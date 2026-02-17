using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        string cs =
        "Server=(local)\\SQLEXPRESS;Database=pushpam;Trusted_Connection=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        // Multiple Adapters
        SqlDataAdapter projectAdapter =
            new SqlDataAdapter("SELECT * FROM PROJECT", con);

        SqlDataAdapter empAdapter =
            new SqlDataAdapter("SELECT * FROM EMP", con);

        SqlDataAdapter deptAdapter =
            new SqlDataAdapter("SELECT * FROM DEPT", con);

        // CommandBuilders (for Update)
        SqlCommandBuilder cb1 = new SqlCommandBuilder(projectAdapter);
        SqlCommandBuilder cb2 = new SqlCommandBuilder(empAdapter);
        SqlCommandBuilder cb3 = new SqlCommandBuilder(deptAdapter);

        // DataSet (Disconnected Storage)
        DataSet ds = new DataSet();

        // Fill Tables
        projectAdapter.Fill(ds, "PROJECT");
        empAdapter.Fill(ds, "EMP");
        deptAdapter.Fill(ds, "DEPT");

        // Display PROJECT
        Console.WriteLine("PROJECT TABLE");
        foreach (DataRow row in ds.Tables["PROJECT"].Rows)
        {
            Console.WriteLine(row["PID"] + " " +
                              row["PNAME"] + " " +
                              row["EMPID"]);
        }

        // Update PROJECT
        ds.Tables["PROJECT"].Rows[0]["PNAME"] = "ERP Updated";

        // Update EMP
        ds.Tables["EMP"].Rows[0]["ENAME"] = "Rahul";

        // Save Back to DB
        projectAdapter.Update(ds, "PROJECT");
        empAdapter.Update(ds, "EMP");

        Console.WriteLine("\nDatabase Updated Successfully");
    }
}
