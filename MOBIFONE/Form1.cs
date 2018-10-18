using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOBIFONE
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int DEM = 0;
        int SOA = 0, SOB = 0, SOTAM = 0;
        float KQT = 0;
        int DONGIADUNG = 600, DONGIASAI = 300;
               private void BTE_Click(object sender, EventArgs e)
        {
            DialogResult ASD = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THOÁT??", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ASD == DialogResult.OK)
            { Application.Exit(); }
            if (ASD == DialogResult.Cancel) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBSAI.Text = DONGIASAI.ToString();
            TBDUNG.Text = DONGIADUNG.ToString();
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            int TIEN1 = 0;
            int TIEN2 = 0;
            DEM = DEM + 1;
            TB1.Text = DEM.ToString();
            TIEN1 = DEM * DONGIASAI;
            TIEN2 = DEM * DONGIADUNG;
            TB3.Text = TIEN1.ToString();
            TB4.Text = TIEN2.ToString();
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            DialogResult DEM = MessageBox.Show("DUY CÓ CHẮC CHẮN MUỐN RESET KẾT QUẢ BỘ ĐẾM KHÔNG??", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DEM == DialogResult.OK)
            {
                TEST(sender, e);   
            }
            if (DEM == DialogResult.Cancel) { }
        }
        private void TEST (object sender, EventArgs e)
        {
            DEM = 0;
            TB1.Text = "0";
            TB3.Clear();
            TB4.Clear();
            TB3.Text = "0";
            TB4.Text = "0";

        }

        private void TB3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTTT_Click(object sender, EventArgs e)
        {
            int tinhthuebao = 0;
            int tinhthuebao1 = 0;
            int tinhthuebao2 = 0;

            tinhthuebao = int.Parse(TBSL.Text);
            tinhthuebao1 = tinhthuebao * DONGIASAI;
            tinhthuebao2 = tinhthuebao * DONGIADUNG;
            TB5.Text = tinhthuebao1.ToString();
            TB6.Text = tinhthuebao2.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser4_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void TBSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTTT_Click_1(object sender, EventArgs e)
        {
            BTTT_Click(sender, e);
        }

        private void BTTRU_Click(object sender, EventArgs e)
        {
            if (DEM > 0)
            {
                DEM = DEM - 1;
                TB1.Text = DEM.ToString();
                int BIN1 = int.Parse(TB3.Text);
                int BIN2 = int.Parse(TB4.Text);
                BIN1 = BIN1 - DONGIASAI;
                BIN2 = BIN2 - DONGIADUNG;
                TB3.Text = BIN1.ToString();
                TB4.Text = BIN2.ToString();
            }
            else
                MessageBox.Show("BẠN CHƯA HOÀN TẤT THUÊ BAO NÀO", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BTSAVE_Click(object sender, EventArgs e)
        {
          
            DialogResult AMD = MessageBox.Show("BẠN CÓ MUỐN LƯU GIÁ TRỊ NÀY KHÔNG?? NẾU KHÔNG HỆ THỐNG SẼ NHẬN GIÁ TRỊ MẶC ĐỊNH", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (AMD == DialogResult.OK)
            {
                DONGIASAI = int.Parse(TBSAI.Text);
                DONGIADUNG = int.Parse(TBDUNG.Text);
            }
            if (AMD == DialogResult.Cancel) { }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BT_TRU_Click(object sender, EventArgs e)
        {
            KQT = 0;
            SOA = int.Parse(TB_SOA.Text);
            SOB = int.Parse(TB_SOB.Text);
            KQT = SOA - SOB;
            TB_KQT.Text = KQT.ToString();
            LB_PT.Text = "-";
        }

        private void BT_XOA_Click(object sender, EventArgs e)
        {
            TB_SOA.Clear();
            TB_SOB.Clear();
            TB_KQT.Clear();
            SOA = 0;
            SOB = 0;
            KQT = 0;
            LB_PT.Text = "NONE";
            TB_SOA.Focus();
        }

        private void BT_NHAN_Click(object sender, EventArgs e)
        {
            KQT = 0;
            SOA = int.Parse(TB_SOA.Text);
            SOB = int.Parse(TB_SOB.Text);
            KQT = SOA * SOB;
            TB_KQT.Text = KQT.ToString();
            LB_PT.Text = "x";
        }

        private void BT_CHIA_Click(object sender, EventArgs e)
        {
            KQT = 0;
            if (SOB != 0)
            {
                SOA = int.Parse(TB_SOA.Text);
                SOB = int.Parse(TB_SOB.Text);
                KQT = SOA - SOB;
                TB_KQT.Text = KQT.ToString();
                LB_PT.Text = "/";
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ THỰC HIỆN PHÉP TÍNH CHIA CHO 0", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TB_SOB.Clear();
                SOB = 0;
 
            }
        }

        private void BT_KETQUATINH_Click(object sender, EventArgs e)
        {
            if (TB_KQT != null || KQT != 0)
            {
                SOTAM = int.Parse(TB_KQT.Text);
                TB_SOA.Clear();
                TB_SOB.Clear();
                TB_KQT.Clear();
                TB_SOA.Text = SOTAM.ToString();
                SOA = SOTAM;
                SOB = 0;
                KQT = 0;
                SOTAM = 0;
                TB_SOB.Focus();
            }
        }

        private void BT_CONG_Click(object sender, EventArgs e)
        {
            KQT = 0;
            SOA = int.Parse(TB_SOA.Text);
            SOB = int.Parse(TB_SOB.Text);
            KQT = SOA + SOB;
            TB_KQT.Text = KQT.ToString();
            LB_PT.Text = "+";
        }

        private void BTSET_Click(object sender, EventArgs e)
        {
            int BI1 = int.Parse(TBDAT.Text);
            DEM = BI1;
            TB1.Text = DEM.ToString();
        }
    }
}
