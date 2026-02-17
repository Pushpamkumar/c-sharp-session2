using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=.;Initial Catalog=pushpam;Integrated Security=True";

        SqlConnection con = new SqlConnection(connectionString);

        string query = "SELECT E.EMPID, E.ENAME, D.DNAME " +
                       "FROM EMP E INNER JOIN DEPT D " +
                       "ON E.DEPTID = D.DEPTID";

        SqlDataAdapter adapter = new SqlDataAdapter(query, con);

        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

        DataSet ds = new DataSet();

        // Fill DataSet (Disconnected Mode)
        adapter.Fill(ds, "EmpDept");

        // Display Data
        foreach (DataRow row in ds.Tables["EmpDept"].Rows)
        {
            Console.WriteLine(row["EMPID"] + " " +
                              row["ENAME"] + " " +
                              row["DNAME"]);
        }

        // Modify Data in DataSet
        ds.Tables["EmpDept"].Rows[0]["ENAME"] = "UpdatedName";

        // Update Database
        adapter.Update(ds, "EmpDept");

        Console.WriteLine("Database Updated Successfully");

        Console.ReadLine();
    }
}
