using System;
using System.Windows.Forms;

namespace SecondLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var labelProduct = "Ürünler";
            string labelCart = "Sepetekiler";
            var addToCartButonText = "Sepete Ekle";
            var removeFromCartButonText = "Sepeten Çıkar"; // burdaki isimerndirme mantığı ilk önce görev sonra hangi araç olduğu


            lblProducts.Text = labelProduct;
            lblCart.Text = labelCart;
            btnAddToCart.Text = addToCartButonText;
            btnRemoveFromCart.Text = removeFromCartButonText;



            string[] products = new string[] { "Kalem", "Silgi", "Dolma Kalem", "Kalen Tıraş", "Tahta Kalemi", "Kalem Ucu" };

            foreach (string product in products) // Ürünlerimizi döngü sayesinde tüm arrays i dolaşarak yazdırıyoruz
            {
                 lbxProducts.Items.Add(product);
            }


            if (lbxCart.Items.Count == 0) // ilk yüklendiğinde ikiside disable olur
            {
                btnRemoveFromCart.Enabled = false;
              
            }
            if (lbxProducts.Items.Count == 0)
            {
                btnAddToCart.Enabled = false;
            }

     
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Buton Tetiklendi");
            //   MessageBox.Show(lbxProducts.SelectedItem.ToString()); // bu ksıımda seçmeden basarasak bag olur veya patlar veya kırılma olur bunların hepsi hata anlamında dadır bunun için önlem alacaz if else gibi
            //  lbxCart.Items.Add(lbxProducts.SelectedItem);

            if (lbxProducts.SelectedItem != null) // burası artık if else kontrollerini etmek için başlar boş mu değil mi filan 
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;
                lbxProducts.Items.Remove(lbxProducts.SelectedItem);
                if (lbxProducts.Items.Count == 0)//ürün bitiğinde disable olsun
                {
                    btnAddToCart.Enabled = false;
                }  
            }
            else
            {
             
                MessageBox.Show("Lütfen bir ürün seçiniz");
            }
            // btnRemoveFromCart.Enabled = true;// buraya eklersen mantık hatası olur ya else çalışırsa
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                btnRemoveFromCart.Enabled = false;

                // MessageBox.Show("lütfen çıkaracağınız ürünü seçiniz");
            }
        }
        // yapılacaklar;
        //ürünler sepetinde ürün yoksa disable olsun buton ekleme
        //ürünler ksımı seçili değilse ekleme butonu disable olsun 
        //eklediğin ürün gitsin ordan ve üürn bitiğinde deaktif olsun  
    }
}
