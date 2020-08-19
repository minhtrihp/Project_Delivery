using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGiaoHang
{
    public partial class FormDangKiNV: Form
    {
        public FormDangKiNV()
        {
            InitializeComponent();

            //Chỉ cho nhập tối đa 30 kí tự trong mật khẩu.
            txbMatKhau.MaxLength = 30;

            //Chỉ cho nhập tối đa 50 kí tự trong họ tên.
            txbHoTen.MaxLength = 50;
        }

        private bool chuyenDuLieuTuFormVaoDB()
        {
            //Tách họ và tên riêng
            String ho;
            String ten;
            int chiSoGiuaHoVaTen = txbHoTen.Text.LastIndexOf(" ");
            if (chiSoGiuaHoVaTen != -1)
            {
                ho = txbHoTen.Text.Substring(0, chiSoGiuaHoVaTen);
                ten = txbHoTen.Text.Substring(chiSoGiuaHoVaTen);
            }
            else //Trường hợp chỉ có tên hoặc không có khoảng trống thì sẽ lưu hết vô tên
            {
                ho = null;
                ten = txbHoTen.Text;
            }
            //TKKH
            QLTaiKhoan QLTK = new QLTaiKhoan();
            TaiKhoanNV TKNV = new TaiKhoanNV();
            NhanVien QLTTNV = new NhanVien();
            TKNV.TenTaiKhoan = maskedTxbSdt.Text;
            TKNV.MatKhau = txbMatKhau.Text;
            TKNV.TinhTrang = "Bình thường";
            TKNV.NgayTao = DateTime.Now;
            //TTKH
            QLTTNV.MaNV = maskedTxbSdt.Text;//Nhân viên là mã là SDT đăng kí
            QLTTNV.Ho = ho;
            QLTTNV.Ten = ten;
            QLTTNV.SDT = maskedTxbSdt.Text;
            //Xử lí tách ngày tháng năm
            string[] time = txbNgaySinh.Text.Split('/');
            //Năm / Tháng / Ngày vì lưu theo SQL
            QLTTNV.NgaySinh = new DateTime(int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2]));
            QLTTNV.GioiTinh = comboBoxGioiTinh.Text;
            QLTTNV.ChucVu = "Nhân viên";
            QLTTNV.DiaChi = txbDiaChi.Text;
            QLTTNV.TenTaiKhoan = maskedTxbSdt.Text;
            if (QLTK.nhapDuLieuVaoDB(TKNV, QLTTNV) == true)
            {
                return true;
            }
            return false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formDangNhap fDangNhap = new formDangNhap();
                this.Hide();
                fDangNhap.ShowDialog();
                this.Close();
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(isDienDuThongTin() && isMatKhauNhapLaiGiongMatKhau())
            {
                if (chuyenDuLieuTuFormVaoDB() == true)
                {
                    MessageBox.Show("Tạo thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLoaiDangNhap fLoaiDangNhap = new FormLoaiDangNhap();
                    this.Hide();
                    fLoaiDangNhap.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (!isMatKhauNhapLaiGiongMatKhau())
                {
                    MessageBox.Show("VUI LÒNG NHẬP LẠI ĐÚNG MẬT KHẨU!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            
        }

        private void txbHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbHoTen.Text.Trim()))
            {
                e.Cancel = true;
                txbHoTen.Focus();
                errorProvider1.SetError(txbHoTen, "Vui lòng nhập họ tên");
            }
            else 
            {
                e.Cancel = false;
                errorProvider1.SetError(txbHoTen, null);
            }
        }

        private void txbHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txbHoTen, "Vui lòng không nhập số !");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txbHoTen, null);
            }
        }

        private void txbDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbDiaChi.Text.Trim()))
            {
                e.Cancel = true;
                txbDiaChi.Focus();
                errorProvider3.SetError(txbDiaChi, "Vui lòng nhập địa chỉ");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txbDiaChi, null);
            }
        }

        private void txbNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            DateTime data = this.dateTimePickerNgaySinh.Value;
            if (string.IsNullOrEmpty(txbNgaySinh.Text.Trim()))
            {
                e.Cancel = true;
                txbNgaySinh.Focus();
                errorProvider4.SetError(txbNgaySinh, "Vui lòng chọn ngày sinh");
            }
            else if (txbNgaySinh.Text.Trim() != data.ToString("yyyy/MM/dd"))
            {
                e.Cancel = true;
                txbNgaySinh.Focus();
                errorProvider4.SetError(txbNgaySinh, "Vui lòng chọn ngày sinh giống với bảng kế bên");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(txbNgaySinh, null);
            }
        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime data = this.dateTimePickerNgaySinh.Value;
            this.txbNgaySinh.Text = data.ToString("yyyy/MM/dd");
        }

        private void maskedTxbSdt_Validating(object sender, CancelEventArgs e)
        {
            if ( !maskedTxbSdt.Text.StartsWith("0") )
            {
                e.Cancel = true;
                maskedTxbSdt.Focus();
                errorProvider5.SetError(maskedTxbSdt, "Vui lòng nhập số điện thoại bắt đầu là số 0!");
            }
            else if( !maskedTxbSdt.MaskFull )
            {
                e.Cancel = true;
                maskedTxbSdt.Focus();
                errorProvider5.SetError(maskedTxbSdt, "Vui lòng nhập đầy đủ số điện thoại !");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(maskedTxbSdt, null);
            }
        }

        private void txbMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (txbMatKhau.Text.Trim().Length < 6)
            {
                e.Cancel = true;
                txbMatKhau.Focus();
                errorProvider6.SetError(txbMatKhau, "Vui lòng nhập tối thiểu 6 kí tự!");
            }
            else
            {
                e.Cancel = false;
                errorProvider6.SetError(txbMatKhau, null);
            }
        }

        private void txbMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbMatKhau.Text.Trim().Length >= 0 && txbMatKhau.Text.Trim().Length < txbMatKhau.MaxLength)
            {
                if (e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = true;
                    txbMatKhau.Focus();
                    errorProvider6.SetError(txbMatKhau, "Vui lòng không nhập khoảng trống trong mật khẩu!");
                }
            }
        }

        private void txbMatKhauNhapLai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbMatKhauNhapLai.Text.Trim()))
            {
                e.Cancel = false;
                errorProvider7.SetError(txbMatKhauNhapLai, "Vui lòng nhập lại mật khẩu");
            }
            else
            {
                e.Cancel = false;
                errorProvider7.SetError(txbMatKhauNhapLai, null);
            }

            if (txbMatKhau.Text.Trim() != txbMatKhauNhapLai.Text.Trim())
            {
                e.Cancel = false;
                errorProvider7.SetError(txbMatKhauNhapLai, "Mật khẩu nhập lại khác mật khẩu");
            }
            else
            {
                e.Cancel = false;
                errorProvider7.SetError(txbMatKhauNhapLai, null);
            }
        }

        private void comboBoxGioiTinh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxGioiTinh.Text))
            {
                e.Cancel = true;
                comboBoxGioiTinh.Focus();
                errorProvider8.SetError(comboBoxGioiTinh, "Vui lòng chọn giới tính!");
            }
            else
            {
                e.Cancel = false;
                errorProvider8.SetError(comboBoxGioiTinh, null);
            }
        }

        private bool isDienDuThongTin()
        {
            if(!string.IsNullOrEmpty(txbHoTen.Text.Trim()))
            {
                if(!string.IsNullOrEmpty(txbDiaChi.Text.Trim()))
                {
                    if(!string.IsNullOrEmpty(txbNgaySinh.Text.Trim()))
                    {
                        if(maskedTxbSdt.MaskFull)
                        {
                            if(!string.IsNullOrEmpty(txbMatKhau.Text.Trim()))
                            {
                                if(!string.IsNullOrEmpty(txbMatKhauNhapLai.Text.Trim()))
                                {
                                    if(!string.IsNullOrEmpty(comboBoxGioiTinh.Text))
                                    {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        private bool isMatKhauNhapLaiGiongMatKhau()
        {
            if(txbMatKhauNhapLai.Text.Trim() == txbMatKhau.Text.Trim())
            {
                return true;
            }
            return false;
        }

        private void FormDangKiShippers_Load(object sender, EventArgs e)
        {

        }

        //private bool isTaiKhoanDaTonTai()
        //{
        //    if(maskedTxbSdt.Text == "0906939638" && txbMatKhau.Text == "123456")
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}