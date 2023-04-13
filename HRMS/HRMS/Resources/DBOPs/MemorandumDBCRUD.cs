using HRMS.Model.DBInterfaces;
using HRMS.Model.DBModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Resources.DBOPs
{
    public class MemorandumDBCRUD : BaseRepository
    {
        public MemorandumDBCRUD(string connectionString) { 
            this.conString= connectionString;
        }

        public List<CircularModel> displayExisting()
        {
            var models = new List<CircularModel>();
            var connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand ifany = new SqlCommand("Select * FROM MemorandumCircular");
            ifany.Connection = connection;
            using (SqlDataReader dr = ifany.ExecuteReader())
            {
                CircularModel cm = new CircularModel();
                if (dr.Read())
                {
                    cm.file = (byte[])dr["PDFFILE"];
                    cm.username = (string)dr["UploadedBy"];
                    cm.extn = (string)dr["PDFextn"];
                    models.Add(cm);
                }
                else
                {
                }
            }
            connection.Close();
            return models;
        }
        public CircularModel uploadFile(string username, string extn, byte[] file)
        {
            CircularModel newPDF= new CircularModel();
            var connection = new SqlConnection(conString);
            if (displayExisting().Any())
            {
                connection.Open();
                SqlCommand delete = new SqlCommand("DELETE FROM MemorandumCircular WHERE PDFID = 0");
                delete.Connection = connection;
                delete.ExecuteNonQuery();
                connection.Close();
            }
            connection.Open();
            SqlCommand command = new SqlCommand("Insert Into MemorandumCircular(PDFID, PDFFILE, PDFextn, UploadedBy)" +
                " Values(@id, @fname, @fileextn, @uploader)");
            command.Connection = connection;
            command.Parameters.Add("@id", SqlDbType.Int, 0).Value = 0;
            command.Parameters.Add("@fname", SqlDbType.VarBinary, -1).Value = file;
            command.Parameters.Add("@fileextn", SqlDbType.VarChar).Value = extn;
            command.Parameters.Add("@uploader", SqlDbType.VarChar).Value = username;
            command.ExecuteNonQuery();

            SqlCommand newpdf = new SqlCommand("Select * FROM MemorandumCircular");
            newpdf.Connection = connection;
            using (SqlDataReader dr = newpdf.ExecuteReader())
            {
                CircularModel cm = new CircularModel();
                if (dr.Read())
                {
                    newPDF.file = (byte[])dr["PDFFILE"];
                    newPDF.username = (string)dr["UploadedBy"];
                    newPDF.extn = (string)dr["PDFextn"];
                }
                else
                {
                }
            }
            connection.Close();
            return newPDF;
        }
    }
}
