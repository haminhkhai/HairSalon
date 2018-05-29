using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;
class checkFunctions
{
    string pathConnect = Application.StartupPath + "/Config/conf.ini";
    //kiểm tra tồn tại database
    public bool checkConnectionDatabase()
    {
        try
        {
            using (SqlConnection sqlConn =
                new SqlConnection(getConnectionstring()))
            {
                sqlConn.Open();
                return (sqlConn.State == ConnectionState.Open);
            }
        }
        catch (SqlException)
        {
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }
    //get connection string
    private string getConnectionstring()
    {
        if (File.Exists(pathConnect))
        {
            MySecurity sec = new MySecurity();
            using (TextReader tr = new StreamReader(pathConnect))
            {
                return @"Server=103.246.223.14; Database=admin_VietNga2; UID=admin_VietNga2; PWD=abcxyz123; TrustServerCertificate = true";
            }
        }
        return null;
    }
    //check exit log file
    public bool checkExitingConfig()
    {
        if (File.Exists(pathConnect))
        {
            return true;
        }
        return false;
    }
}

