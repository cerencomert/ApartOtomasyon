using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AtamanApart
{
    public partial class MainPage : MaterialForm
    {
        public MainPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime700, Primary.Lime700, Primary.Lime700, Accent.Orange400, TextShade.WHITE);
        }

        private void ogrenci_islemi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student();
            student.Show();

        }

        private void personel_islemi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff staff = new Staff();
            staff.Show();
        }

        private void odeme_islemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void ziyaretci_islemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visitor visitor = new Visitor();
            visitor.Show();
        }

    }
}
