using System;
using System.Data;
using Microsoft.Data.SqlClient;

public class Program
{
    static void Main()
    {
        Draft();
    }

    public static void Draft()
    {
        // ✅ Connection String (Your Laptop)
        string cs =
        "Server=localhost\\SQLEXPRESS;Database=pushpam;Trusted_Connection=True;TrustServerCertificate=True;";


        // ✅ Select Query
        string sql = "SELECT ID, DEPTNAME FROM DEPT";

        DataSet ds = new DataSet();

        using (var con = new SqlConnection(cs))
        {
            var adapter = new SqlDataAdapter(sql, con);

            // Auto generate Insert/Update/Delete
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            // 1️⃣ Load Data (Disconnected)
            adapter.Fill(ds, "DEPT");

            Console.WriteLine("Data Loaded in Memory\n");

            // 2️⃣ Show Data (Offline)
            foreach (DataRow row in ds.Tables["DEPT"].Rows)
            {
                Console.WriteLine(row["ID"] + " | " + row["DEPTNAME"]);
            }

            // 3️⃣ Add New Row Offline
            Console.WriteLine("\nAdding new row offline...\n");

            DataRow newRow = ds.Tables["DEPT"].NewRow();

            newRow["ID"] = 10;
            newRow["DEPTNAME"] = "FINANCE";

            ds.Tables["DEPT"].Rows.Add(newRow);

            // 4️⃣ Send Changes to DB
            adapter.Update(ds, "DEPT");

            Console.WriteLine("Database Updated!");
        }

        // 5️⃣ Save to XML
        ds.WriteXml("TestData.xml");

        Console.WriteLine("Saved to TestData.xml");
    }

    // Parameter Example (For Future Use)
    private static void GetRecord(string cs, string dept,
                                  out SqlConnection con,
                                  out SqlCommand cmd)
    {
        string sql = @"SELECT EmployeeId, FullName, Salary
                       FROM dbo.Employees
                       WHERE Department = @dept
                       ORDER BY Salary DESC";

        con = new SqlConnection(cs);
        cmd = new SqlCommand(sql, con);

        cmd.Parameters.AddWithValue("@dept", dept);
    }
}
