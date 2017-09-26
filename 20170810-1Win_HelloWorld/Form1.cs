using System;
using System.Drawing;
using System.Windows.Forms;

namespace _20170810_1Win_HelloWorld
{
    public partial class Form1 : Form
    {

        /*
         Form kontrolcülerinde (toolboxtakiler) bazı özellikler bulunur. Bu özelliklere nesnenin properties penceresinden erişilir.
         Enable : Nesnenin kullanılabilir olup olmadığı ayarlanır
         Visible : Nesnenin görünebilir olup olmadığı ayarlanır. gibi.
         */

         /*
          Properties penceresinde şimşek işaretine tıkladığımızda o nesneye ait eventleri görüntüleriz. Varsayılan olarak tüm elementler boştur. Kullanılmak istenen evente çift tıklandığında kod penceresi açılır ve kod yazılmaya başlanır.
         */


         /*
          Sorun : Oluşturulan metotlar silinirse ORN. button click metodu oluşturuldu ve sonrasında kodlar arasından button1_Click metotu silindi. programı derlemeye çalıştığımızda uzun bir hata görürüz. 
             Çözüm : Error List üzerinden hataya çift tıklanır. sonrasında hatalı kod satırı silinir.       ,
          Nasıl Yapılmalı ? : Properties penceresinden silinmek istenen evente gelinir, sağ tıklanır ve RESET seçilir. sonrasında metot silinmediyse kodlar arasından silinir. Böylece hata almadan metot kaldırılmış olunur      
          */


          /*
           F7 : Bu tuşa basıldığında form ekranından kod yazım ekranına geçiş yapılır.
           Shift+F7 : Klavyeden bu tuşlara basıldığında tekrar design ekranına geçiş yapılır.
           */


           /*
            Her metot zamanı geldiği zaman çalıştırılır. 
            Metot içerisindeki kodlar satır satır sıralı olarak çalıştırılır.+
           */

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aşağıdaki iki kod button1_Click metodu içerisinde olduğu için ikiside aynı anda butona basıldığı zaman çalışacaktır.

            this.Text = "Merhaba Dünya"; // this. bu form anlamına gelir. bu formun textine yani form başlığına Merhaba Dünya yazar.
            MessageBox.Show("Merhaba Dünya"); // Ekranda bir mesaj kutusu çıkararak bu mesaj kutusunun içerisine Merhaba Dünya yazar.
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // Mouse butonun üzerine geldiği zaman çalışacak olan kodlar buraya yazılacaktır.
            button1.BackColor = Color.Fuchsia;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //MouseEnter metotu ile aynı işi yapar ancak bu event elemanın üzerine geldikten sonra bir süre bekenilirse çalıştırılır.
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Mouse nesnenin üzerinden ayrıldığında yapılacak olan işlemler burada yazılacaktır.
            button1.BackColor = Color.GhostWhite;
        }
    }
}
