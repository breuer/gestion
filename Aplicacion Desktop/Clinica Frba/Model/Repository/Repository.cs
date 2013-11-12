﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clinica_Frba.Model.Repository
{
    public class Repository
    {
        public Repository()
        {
        }

        public DataTable listar(String query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                try
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    return (dataTable);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return null;
                }
                finally
                {
                    sqlCommand.Parameters.Clear();
                    sqlConnection.Dispose();
                    sqlCommand.Dispose();
                }
            }
        }

        public DataTable listar(String spName, List<SqlParameter> parametros)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (parametros.Count != 0)
                {
                    sqlCommand.Parameters.AddRange(parametros.ToArray());
                }
                try
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    return (dataTable);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return null;
                }
                finally
                {
                    sqlCommand.Parameters.Clear();
                    sqlConnection.Dispose();
                    sqlCommand.Dispose();
                }
            }
        }

        public void addModificar(String spName, List<SqlParameter> parametros)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.dbConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (parametros.Count != 0)
                {
                    sqlCommand.Parameters.AddRange(parametros.ToArray());
                }
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sqlCommand.Parameters.Clear();
                    sqlConnection.Dispose();
                    sqlCommand.Dispose();
                }
            }
        }
    }
}