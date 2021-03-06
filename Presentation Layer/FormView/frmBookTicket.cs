﻿using Business_Logic_Layer;
using Data_Transfer_Objects;
using Guna.UI2.WinForms.Helpers;
using Presentation_Layer.FormDigital;
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
    public partial class frmBookTicket : CustomForm
    {
        private PanelScrollHelper scrollHelper;
        private List<PhieuDatCho> pdcs;
        private SortableBindingList<PhieuDatCho> bl;
        private Color lastColor;
        public frmBookTicket()
        {
            InitializeComponent();
        }
        #region Other functions
        private void UpdateHeightDgv()
        {
            pnView.Height = 50 + 60 + 24 * dgvBuyTicket.RowCount;
        }
        private DataGridViewButtonColumn ButtonColumn(string text)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = text;
            btn.Text = text;
            btn.HeaderText = "";
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Flat;
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btn.Width = 50;
            return btn;
        }
        private void CustomDgv()
        {
            dgvBuyTicket.Columns.Add(ButtonColumn("Detail"));
            dgvBuyTicket.Columns.Add(ButtonColumn("Edit"));
            //dgvBuyTicket.Columns.Add(ButtonColumn("Delete"));

            dgvBuyTicket.Columns["MaVe"].Visible = false;
            dgvBuyTicket.Columns["MaCB"].Visible = false;
            dgvBuyTicket.Columns["DienThoai"].Visible = false;
            dgvBuyTicket.Columns["HV"].Visible = false;
            dgvBuyTicket.Columns["GiaVe"].Visible = false;
            dgvBuyTicket.Columns["TinhTrang"].Visible = false;
            dgvBuyTicket.Columns["GiaVe"].Visible = false;


            dgvBuyTicket.Columns["strMaVe"].Width = 80;
            dgvBuyTicket.Columns["strMaCB"].Width = 90;
            dgvBuyTicket.Columns["CMND"].Width = 90;
            //dgvBuyTicket.Columns["DienThoai"].Width = 90;
            dgvBuyTicket.Columns["ThoiGian"].Width = 180;
            dgvBuyTicket.Columns["TenHV"].Width = 120;
            //dgvBuyTicket.Columns["GiaVe"].Width = 90;
            dgvBuyTicket.Columns["strTinhTrang"].Width = 80;

            dgvBuyTicket.Columns["strMaVe"].HeaderText = "Mã Vé";
            dgvBuyTicket.Columns["strMaCB"].HeaderText = "Mã\nChuyến Bay";
            dgvBuyTicket.Columns["TenHK"].HeaderText = "Tên\nHành Khách";
            dgvBuyTicket.Columns["CMND"].HeaderText = "CMND";
            //dgvBuyTicket.Columns["DienThoai"].HeaderText = "Số\nĐiện Thoại";
            dgvBuyTicket.Columns["ThoiGian"].HeaderText = "Thời Gian";
            dgvBuyTicket.Columns["TenHV"].HeaderText = "Hạng Vé";
            //dgvBuyTicket.Columns["GiaVe"].HeaderText = "Giá\n(VND)";
            dgvBuyTicket.Columns["strTinhTrang"].HeaderText = "Tình Trạng";

            //dgvBuyTicket.Columns["DienThoai"].DefaultCellStyle.Format = "0";
            dgvBuyTicket.Columns["ThoiGian"].DefaultCellStyle.Format = "hh:mm tt dd/MM/yyyy";
            dgvBuyTicket.Columns["GiaVe"].DefaultCellStyle.Format = "###,###,###";

            dgvBuyTicket.Columns["strMaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["strMaCB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["CMND"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvBuyTicket.Columns["DienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["ThoiGian"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvBuyTicket.Columns["GiaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBuyTicket.Columns["strTinhTrang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private List<CBSource> sources()
        {
            var res = new List<CBSource>();
            CBSource i = new CBSource("MaVe", "Mã Vé");
            res.Add(i);
            i = new CBSource("MaCB", "Mã Chuyến Bay");
            res.Add(i);
            i = new CBSource("TenHK", "Tên Hành Khách");
            res.Add(i);
            i = new CBSource("CMND", "CMND");
            res.Add(i);
            i = new CBSource("TG", "Thời Gian");
            res.Add(i);
            return res;
        }
        private void reloadData()
        {
            pdcs = BLL_PhieuDatCho.GetPhieuDatChos();
            bl = new SortableBindingList<PhieuDatCho>(pdcs);
            dgvBuyTicket.DataSource = bl;
        }
        #endregion
        private void frmBookTicket_Load(object sender, EventArgs e)
        {
            cbSearch.DataSource = sources();
            cbSearch.DisplayMember = "Name";
            cbSearch.ValueMember = "ID";

            pdcs = BLL_PhieuDatCho.GetPhieuDatChos();
            bl = new SortableBindingList<PhieuDatCho>(pdcs);
            dgvBuyTicket.DataSource = bl;
            CustomDgv();

            //Update scrollbar
            scrollHelper = new PanelScrollHelper(pnScroll, sb, false);
            scrollHelper.UpdateScrollBar();
        }

        private void dgvFlights_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgvBuyTicket.Rows[e.RowIndex].Selected = true;
            if (e.ColumnIndex == 0)
            {
                Detail(dgvBuyTicket.Rows[e.RowIndex]);
            }
            else if (e.ColumnIndex == 1)
            {
                Edit(dgvBuyTicket.Rows[e.RowIndex]);
            }
        }

        private void pnScroll_Resize(object sender, EventArgs e)
        {
            if (scrollHelper != null)
                scrollHelper.UpdateScrollBar();
        }
        public override void RefreshData()
        {
            reloadData();
            Notification.Show("Làm mới danh sách sân bay",Status.SUCCESS);
        }
        #region Thao tác với phiếu đặt
        public override void Create()
        {
            AppState.state = Actions.ADD;
            var dialog = new frmPhieuDatChoEditing();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                int newMave = BLL_IdenMaVe.GetNewMaVe();
                if (BLL_PhieuDatCho.InsertPhieuDatCho(dialog.pdc, newMave))
                {
                    Notification.Show("Thêm phiếu đặt chỗ thành công", Status.SUCCESS);
                    BLL_IdenMaVe.ClearIden();
                }
                reloadData();
            }
            AppState.state = Actions.NOTHING;
        }
        private void Edit(DataGridViewRow row)
        {
            if ((int)row.Cells["TinhTrang"].Value == 1 && (((DateTime)row.Cells["ThoiGian"].Value) - DateTime.Now).Hours < ThamSo.TGHuyDatVe)
            {
                Notification.Show("Phiếu đặt chỗ đã quá thời gian",Status.WARNING);
                var dialog1 = new frmWarning("Thông Báo", "Phiếu đặt chỗ đã quá thời gian\n-->Tiến hành hủy");
                dialog1.ShowDialog();
                return;
            }
            else if ((int)row.Cells["TinhTrang"].Value == 2)
            {
                Notification.Show("Phiếu đặt chỗ đã bán không thể chỉnh sửa", Status.WARNING);
                var dialog1 = new frmWarning("Thông Báo", "Phiếu đặt chỗ đã bán không thể chỉnh sửa");
                dialog1.ShowDialog();
                return;
            }
            else if ((int)row.Cells["TinhTrang"].Value == 3)
            {
                Notification.Show("Phiếu đặt chỗ đã hủy không thể chỉnh sửa", Status.WARNING);
                var dialog1 = new frmWarning("Thông Báo", "Phiếu đặt chỗ đã hủy không thể chỉnh sửa");
                dialog1.ShowDialog();
                return;
            }
            AppState.state = Actions.EDIT;
            int maVe = (int)row.Cells["MaVe"].Value;
            int maCB = (int)row.Cells["MaCB"].Value;
            string tenHK = (string)row.Cells["TenHK"].Value;
            string cmnd = (string)row.Cells["CMND"].Value;
            string dienThoai = (string)row.Cells["DienThoai"].Value;
            DateTime thoiGian = (DateTime)row.Cells["ThoiGian"].Value;
            HangVe hv = (HangVe)row.Cells["HV"].Value;
            int giaVe = (int)row.Cells["GiaVe"].Value;
            int tt = (int)row.Cells["TinhTrang"].Value;

            PhieuDatCho pdc = new PhieuDatCho(maVe, maCB, tenHK, cmnd, dienThoai, thoiGian, hv, giaVe, tt);

            var dialog = new frmPhieuDatChoEditing(pdc);
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (BLL_PhieuDatCho.UpdatePhieuDatCho(dialog.pdc)) Notification.Show("Chỉnh sửa phiếu đặt chỗ thành công", Status.SUCCESS);
                reloadData();
            }
            AppState.state = Actions.NOTHING;
        }
        private void Detail(DataGridViewRow row)
        {
            int maVe = (int)row.Cells["MaVe"].Value;
            int maCB = (int)row.Cells["MaCB"].Value;
            string tenHK = (string)row.Cells["TenHK"].Value;
            string cmnd = (string)row.Cells["CMND"].Value;
            string dienThoai = (string)row.Cells["DienThoai"].Value;
            DateTime thoiGian = (DateTime)row.Cells["ThoiGian"].Value;
            HangVe hv = (HangVe)row.Cells["HV"].Value;
            int giaVe = (int)row.Cells["GiaVe"].Value;
            int tt = (int)row.Cells["TinhTrang"].Value;

            PhieuDatCho pdc = new PhieuDatCho(maVe, maCB, tenHK, cmnd, dienThoai, thoiGian, hv, giaVe, tt);

            var dialog = new frmPhieuDatChoEditing(pdc);
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {

            }
        }
        private  void Sale(DataGridViewRow row)
        {
            if ((int)row.Cells["TinhTrang"].Value == 1 && (((DateTime)row.Cells["ThoiGian"].Value)- DateTime.Now).Hours < ThamSo.TGHuyDatVe)
            {
                Notification.Show("Phiếu đặt chỗ đã quá thời gian", Status.WARNING);
                var dialog1 = new frmWarning("Thông Báo", "Phiếu đặt chỗ đã quá thời gian\n-->Tiến hành hủy");
                dialog1.ShowDialog();
                return;
            }
            else if ((int)row.Cells["TinhTrang"].Value == 2)
            {
                Notification.Show("Phiếu đặt chỗ đã bán", Status.WARNING);
                var dialog1 = new frmWarning("Thông Báo", "Phiếu đặt chỗ đã bán");
                dialog1.ShowDialog();
                return;
            }
            else if ((int)row.Cells["TinhTrang"].Value == 3)
            {
                Notification.Show("Phiếu đặt chỗ đã hủy không thể bán", Status.WARNING);
                var dialog1 = new frmWarning("Thông Báo", "Phiếu đặt chỗ đã hủy không thể bán");
                dialog1.ShowDialog();
                return;
            }
            int maVe = (int)row.Cells["MaVe"].Value;
            int maCB = (int)row.Cells["MaCB"].Value;
            string tenHK = (string)row.Cells["TenHK"].Value;
            string cmnd = (string)row.Cells["CMND"].Value;
            string dienThoai = (string)row.Cells["DienThoai"].Value;
            DateTime thoiGian = (DateTime)row.Cells["ThoiGian"].Value;
            HangVe hv = (HangVe)row.Cells["HV"].Value;
            int giaVe = (int)row.Cells["GiaVe"].Value;
            int tt = (int)row.Cells["TinhTrang"].Value;

            PhieuDatCho pdc = new PhieuDatCho(maVe, maCB, tenHK, cmnd, dienThoai, thoiGian, hv, giaVe, tt);
            var dialog = new frmWarning("Cảnh Báo!!!", "Bạn có muốn bán vé không?");
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                pdc.tinhTrang = 2;
                if (BLL_PhieuDatCho.SalePhieuDatCho(pdc)) Notification.Show("Bán vé thành công", Status.SUCCESS);
                BLL_PhieuDatCho.UpdatePhieuDatCho(pdc);
                reloadData();
            }
        }
        private void cancel(DataGridViewRow row)
        {
            if ((int)row.Cells["TinhTrang"].Value == 2)
            {
                Notification.Show("Phiếu đặt chỗ đã bán không thể hủy", Status.WARNING);
                var dialog1 = new frmWarning("Thông Báo", "Phiếu đặt chỗ đã bán không thể hủy");
                dialog1.ShowDialog();
                return;
            }
            else if ((int)row.Cells["TinhTrang"].Value == 3)
            {
                Notification.Show("Phiếu đặt chỗ đã hủy", Status.WARNING);
                var dialog1 = new frmWarning("Thông Báo", "Phiếu đặt chỗ đã hủy");
                dialog1.ShowDialog();
                return;
            }
            int maVe = (int)row.Cells["MaVe"].Value;
            int maCB = (int)row.Cells["MaCB"].Value;
            string tenHK = (string)row.Cells["TenHK"].Value;
            string cmnd = (string)row.Cells["CMND"].Value;
            string dienThoai = (string)row.Cells["DienThoai"].Value;
            DateTime thoiGian = (DateTime)row.Cells["ThoiGian"].Value;
            HangVe hv = (HangVe)row.Cells["HV"].Value;
            int giaVe = (int)row.Cells["GiaVe"].Value;
            int tt = (int)row.Cells["TinhTrang"].Value;

            PhieuDatCho pdc = new PhieuDatCho(maVe, maCB, tenHK, cmnd, dienThoai, thoiGian, hv, giaVe, tt);
            var dialog = new frmWarning("Cảnh Báo!!!", "Bạn có muốn hủy phiếu đặt ghế không?");
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                pdc.tinhTrang = 3;
                if (BLL_PhieuDatCho.UpdatePhieuDatCho(pdc)) Notification.Show("Hủy phiếu đặt chỗ thành công", Status.SUCCESS);
                reloadData();
            }
        }
        #endregion
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.SelectedValue.ToString() == "MaVe") pdcs = BLL_PhieuDatCho.SearchMaVe(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "MaCB") pdcs = BLL_PhieuDatCho.SearchMaCB(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TenHK") pdcs = BLL_PhieuDatCho.SearchTenHK(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "CMND") pdcs = BLL_PhieuDatCho.SearchCMND(tbSearch.Text);
            else if (cbSearch.SelectedValue.ToString() == "TG") pdcs = BLL_PhieuDatCho.SearchThoiGian(tbSearch.Text);
            bl = new SortableBindingList<PhieuDatCho>(pdcs);
            dgvBuyTicket.DataSource = bl;
        }
        #region Chỉnh sửa hiển thị của dgvAirports
        private void dgvFlightsList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dgvBuyTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = lastColor;
        }
        private void dgvFlightsList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            lastColor = dgvBuyTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            dgvBuyTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(99, 191, 173);
        }

        private void dgvFlightsList_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateHeightDgv();
        }
        #endregion
        #region Tool strip
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBuyTicket.SelectedRows.Count <= 0) return;
            Sale(dgvBuyTicket.SelectedRows[0]);
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvBuyTicket.SelectedRows.Count <= 0) return;
            cancel(dgvBuyTicket.SelectedRows[0]);
            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBuyTicket.SelectedRows.Count <= 0) return;
            Detail(dgvBuyTicket.SelectedRows[0]);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBuyTicket.SelectedRows.Count <= 0) return;
            Edit(dgvBuyTicket.SelectedRows[0]);
        }
        #endregion
    }
}
