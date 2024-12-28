using System;

class Program
{
    static void Main()
    {
        bool devamEtmekIstiyorMu = true;

        while (devamEtmekIstiyorMu) // Kullanıcı başka tatil planlamak istediği sürece çalışır
        {
            // Lokasyonlar ve fiyat bilgileri
            Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz:");
            Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı: 4000 TL)");
            Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı: 3000 TL)");
            Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı: 5000 TL)");

            string lokasyon = "";
            int lokasyonFiyati = 0;

            while (true) // Geçerli bir lokasyon seçilene kadar tekrar sorar
            {
                lokasyon = Console.ReadLine().ToLower();

                if (lokasyon == "bodrum")
                {
                    lokasyonFiyati = 4000;
                    break;
                }
                else if (lokasyon == "marmaris")
                {
                    lokasyonFiyati = 3000;
                    break;
                }
                else if (lokasyon == "çeşme")
                {
                    lokasyonFiyati = 5000;
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz lokasyon. Lütfen Bodrum, Marmaris veya Çeşme yazınız.");
                }
            }

            // Kişi sayısını alma
            Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
            int kisiSayisi = int.Parse(Console.ReadLine());

            // Ulaşım seçeneği
            Console.WriteLine("Tatilinize ne şekilde gitmek istiyorsunuz?");
            Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı: 1500 TL)");
            Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı: 4000 TL)");

            int ulasimFiyati = 0;

            while (true) // Geçerli bir ulaşım seçeneği girilene kadar tekrar sorar
            {
                string ulasim = Console.ReadLine();

                if (ulasim == "1")
                {
                    ulasimFiyati = 1500;
                    break;
                }
                else if (ulasim == "2")
                {
                    ulasimFiyati = 4000;
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen '1' ya da '2' yazınız.");
                }
            }

            // Toplam fiyat hesaplama
            int toplamFiyat = (lokasyonFiyati + ulasimFiyati) * kisiSayisi;

            // Plan özeti
            Console.WriteLine("\nTatil Planı Özeti:");
            Console.WriteLine($"Lokasyon: {lokasyon.ToUpper()}");
            Console.WriteLine($"Kişi Sayısı: {kisiSayisi}");
            Console.WriteLine($"Toplam Fiyat: {toplamFiyat} TL\n");

            // Başka tatil planlamak isteyip istemediğini sorma
            Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet/Hayır)");
            string devam = Console.ReadLine().ToLower();

            if (devam != "evet")
            {
                devamEtmekIstiyorMu = false;
                Console.WriteLine("İyi günler! Tatil planlama uygulamamızı kullandığınız için teşekkür ederiz.");
            }
        }
    }
}
