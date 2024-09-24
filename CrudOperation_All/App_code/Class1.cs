using System;
using System.Activities.Validation;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    string con_str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;
    public Class1()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Sno { get; set; }
    public string FullName { get; set; }
    public string MobileNo { get; set; }
    public string Email { get; set; }

    public string State { get; set; }


    private string _SendFrom;
    public string SendFrom
    {
        get
        {
            return _SendFrom;
        }
        set
        {
            _SendFrom = value;
        }
    }

    public SqlDataReader UspTblEmployeeRecordsGetAll()
    {
        objConnection = new SqlConnection(con_str); // Connection String
        objConnection.ConnectionString = con_str;
        objConnection.Open(); // Connection Open from DB
        objCommand = new SqlCommand(); // Object of Sql Command
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "UspTblEmployeeRecordsGetAll";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public string UspTblInsert()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "UspTblInsert"; // Old --UspTblVolunteerRegistrationInsert
            objCommand.Parameters.AddWithValue("@FullName", FullName);
            objCommand.Parameters.AddWithValue("@MobileNo", MobileNo);
            objCommand.Parameters.AddWithValue("@Email", Email);
            objCommand.Parameters.AddWithValue("@State", State);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }

            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;
        }
    }

    public string UspTblUpdate()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "UspTblUpdate"; // Old --UspTblVolunteerRegistrationInsert
            objCommand.Parameters.AddWithValue("@Sno", Sno);
            objCommand.Parameters.AddWithValue("@FullName", FullName);
            objCommand.Parameters.AddWithValue("@MobileNo", MobileNo);
            objCommand.Parameters.AddWithValue("@Email", Email);
            objCommand.Parameters.AddWithValue("@StateName", State);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }

            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;
        }
    }
        public string UspTblDelete()
        {
            using (SqlConnection objConnection = new SqlConnection(con_str))
            {
                SqlCommand objCommand;
                objCommand = objConnection.CreateCommand();
                objConnection.Open();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandTimeout = 0;
                objCommand.CommandText = "UspTblDelete"; // Old --UspTblVolunteerRegistrationInsert
                objCommand.Parameters.AddWithValue("@Sno", Sno);
                dataReader = objCommand.ExecuteReader();
                string j = "0";
                if (dataReader.Read())
                {
                    j = dataReader[0].ToString();
                }

                objCommand.Dispose();
                objConnection.Close();
                objConnection.Dispose();
                dataReader.Close();
                return j;
            }
        }



    }
