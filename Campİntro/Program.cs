using System;

namespace Campİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string katogoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            bool sistemeGirisYapmisMi = false;


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(katogoriEtiketi);
            Console.ReadLine();

        }
    }
}
