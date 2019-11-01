using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            cbSokhach.Items.Add("5");
            cbSokhach.Items.Add("10");
            cbSokhach.Items.Add("15");
            cbThoigian.Items.Add("6h");
            cbThoigian.Items.Add("12h");
            cbThoigian.Items.Add("7h");
            cbDiachi.Items.Add("736 Nguyễn Trãi,P.2,Q.5");
            cbDiachi.Items.Add("75 3 tháng 2,P.3,Q.11");
            cbDiachi.Items.Add("123 Nguyễn Chí Thanh,P.11,Q.11");


        }
       
        public string HoTen,ThoiGian,Diachi;
        public int SoKhach, DienThoai;
        public DateTime NgayThang;
        public void laydulieu()
        {
            HoTen = txtHoTen.Text;
            SoKhach = Int32.Parse(cbSokhach.SelectedItem.ToString());
            DienThoai = Int32.Parse(txtSodienthoai.Text.ToString());
            NgayThang = dateTimePicker1.Value.Date;
            ThoiGian = cbThoigian.Text;
            Diachi = cbDiachi.Text;
        }
        public void nhapdulieu()
        {
            //getMonAn();
            Hotro.ketnoi();
            Hotro.ThucThiLenh("INSERT INTO DAT_BAN VALUES('" + HoTen + "', " + SoKhach + ", " + DienThoai + ", '" + NgayThang + "','"+ ThoiGian + "','"+ Diachi + "')");
            MessageBox.Show("Thêm dữ liệu thành công!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            
            laydulieu();
            nhapdulieu();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtHoTen.Text= " ";
            txtSodienthoai.Text = "";
            cbSokhach.Text = "";
            cbThoigian.Text = "";
            cbDiachi.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
