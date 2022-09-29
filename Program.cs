using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yönetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try {} hata olduğunu düşündüğünüz kod buraya yazılır.
            // catch() {} hata ile karşılaşıldığında ne yapılacağı buraya yazılır, parantez içi şekillenidirilebilir.
            // finally {} hata olsun veya olmasın kesinlikle yapılmasını istediğimiz buraya yazılır.

            try 
            {
                Console.Write("Bir sayı giriniz : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz Sayı : {0} ", num1);
                Console.WriteLine(" "); // Burası konsolda boşluk olması için yazılmıştır, bir önemi yok.
            }
            catch(Exception hata1)
            {
                Console.WriteLine("**Hata 1 : {0}", hata1.Message.ToString());   // Hataya neden olan bilgiyi ekrana yazar.
                // Eğer sayı değeri girdiyseniz hata vermez ama string  girdiyseniz hata mesajını gösterir.
                Console.WriteLine(" "); // Burası konsolda boşluk olması için yazılmıştır, bir önemi yok.
            }

            try
            {
                int num2 = int.Parse(null); // Hatalı olacak çünkü null değerini alamaz. 
            }

            catch(ArgumentNullException hata2)
            {
                Console.WriteLine("**Hata 2 : {0}", hata2); // Hatayı bu şekilde yazdırdığımızda satırına kadar hatanın nerede olduğunu gösterir.
                Console.WriteLine(" "); // Burası konsolda boşluk olması için yazılmıştır, bir önemi yok.
            }

            try
            {
                int num3 = int.Parse("test"); // Hatalı olacak çünkü string değeri integer (int) değerine çeviremeyiz.
            }

            catch(FormatException hata3)
            {
                Console.WriteLine("**Hata 3 : {0} ", hata3);
            }

            finally // Hata olsun veya olmasın her iki türlü ekrana yazılacak.
            {
                Console.WriteLine("Program tamamlandı.");
            }
        }
    }
}
