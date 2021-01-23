using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Chuong5_BT1
{
    class HandleData
    {
        //Biến connnSv để kết nối cơ sở dữ liệu
        SqlConnection connSV = new SqlConnection();
        public HandleData()
        {
            try
            {
                connSV.ConnectionString = "Data Source=DESKTOP-BVDOO2T;Initial Catalog=QLSV;Integrated Security=True";
                connSV.Open();
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public DataTable getDataFromTable(String tableName)
        {
            DataTable dtTable = new DataTable();
            String strSQL = "select * from " + tableName + "";
            try
            {
                SqlCommand sqlCmd = new SqlCommand(strSQL,connSV);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCmd);
                dataAdapter.Fill(dtTable);
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return dtTable;
        }
        //Xóa khoa
        public int deleteKhoa(string sMaKhoa)
        {
            int iResult;
            string sNameSP = "sp_xoaKhoa";
            try
            {
                SqlCommand sqlCmd = new SqlCommand(sNameSP, connSV);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@makhoa", sMaKhoa);
                iResult = sqlCmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                iResult = 0;
                return 0;
            }
            return iResult;
        }
        //Thêm khoa
        public int insertKhoa(string sMaKhoa, string sTenKhoa)
        {
            int iResult;
            string sNameSP = "sp_themKhoa";
            try
            {
                SqlCommand sqlCmd = new SqlCommand(sNameSP, connSV);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@makhoa", sMaKhoa);
                sqlCmd.Parameters.AddWithValue("@tenkhoa", sTenKhoa);
                iResult = sqlCmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {          
                iResult = 0;
                return 0;
            }
            return iResult;
        }
        //Cập nhật khoa
        public int updateKhoa(string sMaKhoa, string sTenKhoa)
        {
            int iResult;
            string sNameSP = "sp_suaKhoa";
            try
            {
                SqlCommand sqlCmd = new SqlCommand(sNameSP, connSV);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@makhoa", sMaKhoa);
                sqlCmd.Parameters.AddWithValue("@tenkhoa", sTenKhoa);
                iResult = sqlCmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                iResult = 0;
            }
            return iResult;
        }
        //Thêm môn học
        public int insertMonHoc(string sMaMH, string sTenMH, int iSoTiet)
        {
            int iResult;
            string sNameSP = "sp_themMonHoc";
            try
            {
                SqlCommand sqlCmd = new SqlCommand(sNameSP, connSV);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@maMH", sMaMH);
                sqlCmd.Parameters.AddWithValue("@tenMH", sTenMH);
                sqlCmd.Parameters.AddWithValue("@soTiet", iSoTiet);
                iResult = sqlCmd.ExecuteNonQuery();
            }catch(SqlException ex)
            {
                iResult = 0;
            }

            return iResult;
        }
        //Xoá môn học
        public int deleteMonHoc(string sMaMH)
        {
            int iResult;
            string sNameSP = "sp_xoaMonHoc";
            try
            {
                SqlCommand sqlCmd = new SqlCommand(sNameSP, connSV);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@maMH", sMaMH);
                iResult = sqlCmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                iResult = 0;
            }
            return iResult;
        }
    }
}
