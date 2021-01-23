using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Demo
{
    public class dal_Khoa : dal_KetNoiDB
    {
        //Xử lý thao tac du liệu khoa (Thêm, xóa, sửa)
        //Định nghĩa hàm lấy danh sách khoa
        public DataTable LayDSKhoa()
        {
            DataTable dtKhoa = new DataTable();
            //khai báo biến
            try
            {
            SqlCommand cmd = new SqlCommand("ten stored",_cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_....";
            SqlDataAdapter daKhoa = new SqlDataAdapter(cmd);
            daKhoa.Fill(dtKhoa);            
            }catch(SqlException ex)
            {

            }
            return dtKhoa;
        }

    }
}
