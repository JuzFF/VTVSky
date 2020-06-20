﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class Ve
    {
        private int maVe;
        private int maCB;
        private string tenHK;
        private string cmnd;
        private string dienThoai;
        private DateTime thoiGian;
        private HangVe hv;
        private int giaVe;

        public string MaVe
        {
            get
            {
                return ConvertToString(maVe,"VE");
            }
        }
        public string MaCB
        {
            get
            {
                return ConvertToString(maCB, "CB");
            }
        }
        public string TenHK
        {
            set
            {
                tenHK = value;
            }
            get
            {
                return tenHK;
            }
        }
        public string CMND
        {
            set
            {
                cmnd = value;
            }
            get
            {
                return cmnd;
            }
        }
        public string DienThoai
        {
            set
            {
                dienThoai = value;
            }
            get
            {
                return dienThoai;
            }
        }
        public DateTime ThoiGian
        {
            set
            {
                thoiGian = value;
            }
            get
            {
                return thoiGian;
            }
        }
        public string TenHV
        {
            get
            {
                return hv.TenHV;
            }
        }
        public int GiaVe
        {
            set
            {
                giaVe = value;
            }
            get
            {
                return giaVe;
            }
        }
        public int GetMaVe()
        {
            return maVe;
        }
        public int GetMaCB()
        {
            return maCB;
        }
        public Ve() { }
        public Ve(int _maVe,int _maCB, string _tenHK, string _cmnd, string _dienThoai, DateTime _thoiGian, HangVe _hv, int _giaVe)
        {
            maVe = _maVe;
            maCB = _maCB;
            tenHK = _tenHK;
            cmnd = _cmnd;
            dienThoai = _dienThoai;
            thoiGian = _thoiGian;
            hv = _hv;
            giaVe = _giaVe;
        }
        private string ConvertToString(int x,string pre)
        {
            string res = "000000";
            string s = x.ToString();
            return pre+res.Remove(res.Length - s.Length) + s;
        }
    }
}
