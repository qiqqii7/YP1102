using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;


namespace Projekt
{
    /// <summary>
    /// Логика взаимодействия для sortirovka.xaml
    /// </summary>
    public partial class sortirovka : Window
    {
        public sortirovka()
        {
            InitializeComponent();

            gg.ItemsSource = Instances.db.products_users_table.Take(50000).ToList();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tovar bmiWindow = new Tovar();
            
            bmiWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            deleted bmiWindow = new deleted();
            
            bmiWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            //user = newUser;
           // gg.ItemsSource = Instances.db.products_users_table.Where(q => q.fk_user_id == user.pk_user_id).Take(100).ToList();
            //this.ComboBox.ItemsSource = Instances.db.categories.ToList();
            listpay bmiWindow = new listpay();
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";
            if (sfd.ShowDialog() == DialogResult)
                //using (StreamWriter streamWriter = new StreamWriter("W://!Личная/fff" + user.login + ".csv"))

            {

                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10 , 10, 42, 35);
               // PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream);
                doc.Open();
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance("Image.jpeg");
                doc.Add(image);
                doc.Close();
            }
        }
    }
}
