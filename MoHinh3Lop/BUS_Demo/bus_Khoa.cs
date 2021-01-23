using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_Demo;

namespace BUS_Demo
{
    class bus_Khoa
    {
        //Sử dụng DAL
        dal_Khoa dal_khoa = new dal_Khoa();

        public DataTable LayDSKhoa()
        {
            return dal_khoa.LayDSKhoa();
        }
    }
}
