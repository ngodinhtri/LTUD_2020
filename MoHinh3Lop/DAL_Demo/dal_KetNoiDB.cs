using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Demo
{
    public class dal_KetNoiDB
    {
        //Xử lý việc kết nối
        protected SqlConnection _cn = new SqlConnection("Data Source=DESKTOP-LKV2N3U;Initial Catalog=QLSV;Integrated Security=True");
    }
}
