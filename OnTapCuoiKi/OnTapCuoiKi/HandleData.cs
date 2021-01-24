using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnTapCuoiKi
{
    class HandleData
    {
        SqlConnection connSV = new SqlConnection();
        public HandleData()
        {
            try
            {
                connSV.ConnectionString = "Data Source=DESKTOP-LKV2N3U;Initial Catalog=QLSV;Integrated Security=True";
                connSV.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getDataFormTable(String tableName)
        {
            DataTable dataTable = new DataTable();
            String strSql = "select * from " + tableName + "";

            try
            {
                SqlCommand sqlCmd = new SqlCommand(strSql, connSV);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCmd);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return dataTable;
        }

        public int themKhoa(String maKhoa, String tenKhoa)
        {
            int iResult;
            String spName = "sp_themKhoa";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(spName, connSV);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@maKhoa", maKhoa);
                sqlCommand.Parameters.AddWithValue("@tenKhoa", tenKhoa);
                iResult = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            return iResult;
        }

        public int xoaKhoa(String maKhoa)
        {
            int iResult;
            String spName = "sp_xoaKhoa";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(spName, connSV);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@maKhoa", maKhoa);
                iResult = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            return iResult;
        }

        public int suaKhoa(String maKhoa, String tenKhoa)
        {
            int iResult;
            String spName = "sp_suaKhoa";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(spName, connSV);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@maKhoa", maKhoa);
                sqlCommand.Parameters.AddWithValue("@tenKhoa", tenKhoa);
                iResult = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            return iResult;
        }

        public int themSinhVien(String ma, String ho, String ten, String gioiTinh, String ngaySinh, String noiSinh, String diaChi, String maKHoa, int hocBong)
        {
            int iResult;
            String spName = "sp_themSV";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(spName, connSV);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@maSV", ma);
                sqlCommand.Parameters.AddWithValue("@hoSV", ho);
                sqlCommand.Parameters.AddWithValue("@tenSV", ten);
                sqlCommand.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                sqlCommand.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                sqlCommand.Parameters.AddWithValue("@noiSinh", noiSinh);
                sqlCommand.Parameters.AddWithValue("@diaChi", diaChi);
                sqlCommand.Parameters.AddWithValue("@maKhoa", maKHoa);
                sqlCommand.Parameters.AddWithValue("@hocBong", hocBong);
                iResult = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            return iResult;
        }
    }
}
