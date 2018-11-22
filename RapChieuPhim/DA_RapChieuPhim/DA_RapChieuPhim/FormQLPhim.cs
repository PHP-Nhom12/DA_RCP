using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapChieuPhimBUS;
using RapChieuPhimDTO;
<<<<<<< HEAD

=======
>>>>>>> 042ac5c47f1b03b14a6e048a81eba0210df6318b
namespace DA_RapChieuPhim
{
    public partial class FormQLPhim : Form
    {
        
        public FormQLPhim()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        PhimBUS phim = new PhimBUS();
        TheLoaiBUS theloai = new TheLoaiBUS();
        

        private void FormQLPhim_Load(object sender, EventArgs e)
=======
        
        private void label2_Click(object sender, EventArgs e)
>>>>>>> 042ac5c47f1b03b14a6e048a81eba0210df6318b
        {
            loadTatCa();
        }

        private void loadTatCa()
        {
            // Load Phim vô Lookup Ten Phim
            

            // Load The Loai vô Lookup The Loai
            lueTheLoai.Properties.DataSource = theloai.LoadTheLoai();
            lueTheLoai.Properties.DisplayMember = "TenTheLoai";
            lueTheLoai.Properties.ValueMember = "MaTheLoai";

            //Load Mác vô lookup Mac
            lueMac.Properties.DataSource = phim.LoadPhimm();
            lueMac.Properties.DisplayMember = "Mac";
            lueMac.Properties.ValueMember = "MaPhim";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') e.KeyChar = char.ToLower(e.KeyChar);
        }


    }
}
