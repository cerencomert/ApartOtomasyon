using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtamanApart
{
    public partial class RoomInfo : MaterialForm
    {
        public RoomInfo()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime700, Primary.Lime700, Primary.Lime700, Accent.Orange400, TextShade.WHITE);
        }

        #region OleDb
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = AtamanApart2.accdb");
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        #endregion

        public void metot() {
            kapat.Visible = true;
            kat1.Visible = false;
            kat2.Visible = false;
            kat3.Visible = false;
            kat4.Visible = false;
            kat5.Visible = false;
            zemin_kat.Visible = false;
            materialDivider1.Visible = false;
            materialDivider2.Visible = false;
            materialDivider3.Visible = false;
            materialDivider4.Visible = false;
            materialDivider5.Visible = false;
            groupBox1.Visible = true;
        }

        #region Zemin Kat

        private void oda_1_Click(object sender, EventArgs e)
        {

            metot();
            oda_numarası.Text = oda_1.Text;
            kapasite.Text = "1";
            oda_ucret.Text = "600";
        }

        private void oda_2_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_2.Text;
            kapasite.Text = "1";
            oda_ucret.Text = "600";
        }

        private void oda_3_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_3.Text;
            kapasite.Text = "1";
            oda_ucret.Text = "600";
        }

        private void oda_4_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_4.Text;
            kapasite.Text = "1";
            oda_ucret.Text = "600";
        }

        private void oda_5_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_5.Text;
            kapasite.Text = "1";
            oda_ucret.Text = "600";
        }

        private void oda_6_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_6.Text;
            kapasite.Text = "1";
            oda_ucret.Text = "600";
        }

        private void oda_7_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_7.Text;
            kapasite.Text = "1";
            oda_ucret.Text = "600";
        }

        #endregion

        #region 1.Kat

        private void oda_101_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_101.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        private void oda_102_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_102.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        private void oda_103_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_103.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        private void oda_104_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_104.Text;
            kapasite.Text = "3";
            oda_ucret.Text = "500";
        }

        private void oda_105_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_105.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        private void oda_106_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_106.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        private void oda_107_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_107.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        private void oda_108_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_108.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        private void oda_109_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_109.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        private void oda_110_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_110.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        private void oda_111_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_111.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "500";
        }

        #endregion

        #region 2.Kat

        private void oda_201_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_201.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        private void oda_202_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_202.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        private void oda_203_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_203.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        private void oda_204_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_204.Text;
            kapasite.Text = "3";
            oda_ucret.Text = "650";
        }

        private void oda_205_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_205.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        private void oda_206_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_206.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        private void oda_207_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_207.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        private void oda_208_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_208.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        private void oda_209_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_209.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        private void oda_210_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_210.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        private void oda_211_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_211.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "650";
        }

        #endregion

        #region 3.Kat

        private void oda_301_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_301.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";

        }

        private void oda_302_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_302.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";

        }

        private void oda_303_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_303.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";

        }

        private void oda_304_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_304.Text;
            kapasite.Text = "3";
            oda_ucret.Text = "475";

        }

        private void oda_305_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_305.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";
        }

        private void oda_306_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_306.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";
        }

        private void oda_307_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_307.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";
        }

        private void oda_308_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_308.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";
        }

        private void oda_309_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_309.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";
        }

        private void oda_310_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_310.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";
        }

        private void oda_311_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_311.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "475";
        }

        #endregion

        #region 4.Kat

        private void oda_401_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_401.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        private void oda_402_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_402.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        private void oda_403_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_403.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        private void oda_404_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_404.Text;
            kapasite.Text = "3";
            oda_ucret.Text = "680";
        }

        private void oda_405_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_405.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        private void oda_406_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_406.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        private void oda_407_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_407.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        private void oda_408_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_408.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        private void oda_409_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_409.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        private void oda_410_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_410.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        private void oda_411_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_411.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "680";
        }

        #endregion

        #region 5.Kat

        private void oda_501_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_501.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "600";
        }

        private void oda_502_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_502.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "600";
        }

        private void oda_503_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_503.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "600";
        }

        private void oda_504_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_504.Text;
            kapasite.Text = "3";
            oda_ucret.Text = "600";
        }

        private void oda_505_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_505.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "600";
        }

        private void oda_506_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_506.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "600";
        }

        private void oda_507_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_507.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "600";
        }

        private void oda_508_Click(object sender, EventArgs e)
        {
            metot();
            oda_numarası.Text = oda_508.Text;
            kapasite.Text = "2";
            oda_ucret.Text = "600";
        }

        #endregion


        private void geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Student student = new Student();
            student.Show();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            kapat.Visible = true;
            kat1.Visible = true;
            kat2.Visible = true;
            kat3.Visible = true;
            kat4.Visible = true;
            kat5.Visible = true;
            zemin_kat.Visible = true;
            materialDivider1.Visible = true;
            materialDivider2.Visible = true;
            materialDivider3.Visible = true;
            materialDivider4.Visible = true;
            materialDivider5.Visible = true;
        }
    }
}
