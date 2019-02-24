using System;

namespace RoverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rover uygulamasına hoşgeldiniz...");
            Console.WriteLine("Harita boyutunu araya boşluk bırakarak giriniz...");
            string haritaBoyutu = Console.ReadLine();
            string[] haritaBoyuDizisi = haritaBoyutu.Split(' '); // haritaBoyutu dizisi boşluğa göre split edilerek değerler diziye atandı.
            Console.WriteLine("Aracın başlangıç noktasını ve baktığı yönü araya boşluk bırakarak giriniz...");
            Console.WriteLine("North: N , West: W, South: S East: E");
            string baslangicNoktasi = Console.ReadLine();
            string[] baslanginNoktasiDizisi = baslangicNoktasi.Split(' '); // baslangicNoktasi dizisi boşluğa göre split edilerek değerler diziye atandı.
            int XKoordinatim = int.Parse(baslanginNoktasiDizisi[0]); // X koordinat değeri alındı
            int YKoordinatim = int.Parse(baslanginNoktasiDizisi[1]); // Y koordinat değeri alındı
            string baslangicYonu = baslanginNoktasiDizisi[2]; // Başlangıç yönü alındı

            int haritaSatirSayisi = int.Parse(haritaBoyuDizisi[0]); // harita sınırları alındı
            int haritaSutunSayisi = int.Parse(haritaBoyuDizisi[1]);

            Console.WriteLine("Lütfen istikamet giriniz...");
            string gidilecekNokta = Console.ReadLine(); // gidilmek istenen noktaya dair istikamet alındı.
            string GuncelYonum = baslangicYonu; // başlangıç yönü güncel yön olarak atandı.

            for (int i = 0; i < gidilecekNokta.Length; i++)
            {
                StepByStep nesne = new StepByStep();
                nesne.Step(ref baslangicYonu, gidilecekNokta[i], ref XKoordinatim, ref YKoordinatim, ref GuncelYonum);
            }

            if (baslangicYonu == "N" | baslangicYonu == "W" | baslangicYonu == "S" | baslangicYonu == "E") // Başlangıç yönü doğru girildiyse;
            {
                if (XKoordinatim <= haritaSatirSayisi && YKoordinatim <= haritaSutunSayisi && XKoordinatim > 0 && YKoordinatim > 0) // ve harita sınırları içerisindeysem;
                    Console.WriteLine("Araç X: " + XKoordinatim + " Y:  " + YKoordinatim + " Koordinatında" + " ve " + GuncelYonum + " yönüne bakmaktadır"); // ekrana bilgileri yazdır.

                else if (XKoordinatim > haritaSatirSayisi || YKoordinatim > haritaSutunSayisi || XKoordinatim < 0 || YKoordinatim < 0) // harita sınırları dışında isem;
                    Console.WriteLine("Harita Dışına Çıktınız!"); // uyarı yazdır.
            }
            else  // yön bilgisi doğru değilse
                Console.WriteLine("Yanlış yön bilgisi girdiniz!"); // uyarı yazdır.
        }
    }
}
