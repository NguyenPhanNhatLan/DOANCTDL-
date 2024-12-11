using BasicCaculation.application;
using System;
using System.Windows.Forms;

namespace BasicCaculation
{
    public partial class CaculateForm : Form
    {
        public CaculateForm()
        {
            InitializeComponent();
        }

        private void NhapGiaTri(object sender, EventArgs e)
        {
            string[] lines = thanh_hien_thi.Lines;
            if (thanh_hien_thi.Lines[1] == "0")
            {
                lines[1] = "";
            }
            lines[1] += Helper.nhapgiatri(sender);
            thanh_hien_thi.Lines = lines;
        }

        private void XoaGiaTri(object sender, EventArgs e)
        {
            if (thanh_hien_thi.Lines[1] != "0")
            {
                thanh_hien_thi.Lines = new string[] { "", Helper.xoagiatri(thanh_hien_thi.Lines[1]) };
            }
        }

        private void XoaTatCa(object sender, EventArgs e)
        {
            thanh_hien_thi.Lines = new string[] { "", "0" };
        }

        private void Bang(object sender, EventArgs e)
        {
            string bieuthuc = thanh_hien_thi.Lines[1];
            string ketqua = CaculateHelper.XuLyBieuThuc(bieuthuc).ToString();
            var result = new string[] { bieuthuc, ketqua };
            thanh_hien_thi.Lines = result;
        }

        private void CaculateForm_Load(object sender, EventArgs e)
        {

        }

        private void thanh_hien_thi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
