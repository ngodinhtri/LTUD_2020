using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
    class ET_Khoa
    {
        
        private string _MaKhoa;
        private string _TenKhoa;
        //properties
        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
        public string TenKhoa { get => _TenKhoa; set => _TenKhoa = value; }
        //Constructor

        public ET_Khoa(string maKhoa, string tenKhoa)
        {
            _MaKhoa = maKhoa;
            _TenKhoa = tenKhoa;
        }
    }
}
