﻿using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BLL_BCNam
    {
        public static DataSet GetDataSet(int nam)
        {
            return DAL_BCNam.GetDataSet(nam);
        }
    }
}
