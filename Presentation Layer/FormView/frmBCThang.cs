﻿using Business_Logic_Layer;
using Data_Transfer_Objects;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.FormView
{
    public partial class frmBCThang : CustomForm
    {
        public frmBCThang()
        {
            InitializeComponent();
        }

        private void frmBCThang_Load(object sender, EventArgs e)
        {
            this.rpvBCThang.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = Convert.ToInt32(tbThang.Text);
                int nam = Convert.ToInt32(tbNam.Text);
                DataSet ds = BLL_BCThang.GetDataSet(thang, nam);
                rpvBCThang.LocalReport.ReportPath = "Report/rpBCThang.rdlc";
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = ds.Tables[0];
                    rpvBCThang.LocalReport.DataSources.Clear();
                    rpvBCThang.LocalReport.DataSources.Add(rds);
                    rpvBCThang.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                Notification.Show(ex.Message);
            }
        }
    }
}
