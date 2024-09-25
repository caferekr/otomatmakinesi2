namespace otomatmakinesi2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
           
            public class Urun
        {
            public string Ad { get; set; }
            public double Fiyat { get; set; }

            public Urun(string ad, double fiyat)
            {
                Ad = ad;
                Fiyat = fiyat;
            }

            public override string ToString()
            {
                return $"{Ad} - {Fiyat:C}";
            }
        }

        static void Main(string[] args)
        {
            List<Urun> urunler = new List<Urun>(); 
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("\nOtomat Makinesi");
                Console.WriteLine("1. Ürün Ekle");
                Console.WriteLine("2. Ürün Sil");
                Console.WriteLine("3. Fiyat Güncelle");
                Console.WriteLine("4. Ürünleri Listele");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminizi yapın (1-5): ");

                
                int secim;
                while (!int.TryParse(Console.ReadLine(), out secim) || secim < 1 || secim > 5)
                {
                    Console.Write("Geçersiz seçim! Lütfen 1-5 arasında bir sayı girin: ");
                }

                switch (secim)
                {
                    case 1:
                       
                        Console.Write("Ürün adı: ");
                        string ad = Console.ReadLine();
                        double fiyat;

                        
                        while (true)
                        {
                            Console.Write("Ürün fiyatı: ");
                            if (double.TryParse(Console.ReadLine(), out fiyat) && fiyat >= 0)
                            {
                                break; 
                            }
                            Console.WriteLine("Geçersiz fiyat! Lütfen pozitif bir değer girin.");
                        }

                        urunler.Add(new Urun(ad, fiyat));
                        Console.WriteLine($"{ad} ürünü başarıyla eklendi.");
                        break;

                    case 2:
                        
                        Console.Write("Silinecek ürün adı: ");
                        string silinecekAd = Console.ReadLine();
                        bool bulundu = false;

                        for (int i = 0; i < urunler.Count; i++)
                        {
                          
                            if (urunler[i].Ad.ToLower() == silinecekAd.ToLower())
                            {
                                urunler.RemoveAt(i);
                                Console.WriteLine($"{silinecekAd} ürünü başarıyla silindi.");
                                bulundu = true;
                                break; 
                            }
                        }

                        if (!bulundu)
                        {
                            Console.WriteLine($"{silinecekAd} ürünü bulunamadı.");
                        }
                        break;

                    case 3:
                        
                        Console.Write("Fiyatı güncellenecek ürün adı: ");
                        string guncellenecekAd = Console.ReadLine();
                        bulundu = false;

                        for (int i = 0; i < urunler.Count; i++)
                        {
                            
                            if (urunler[i].Ad.ToLower() == guncellenecekAd.ToLower())
                            {
                                double yeniFiyat;
                                while (true)
                                {
                                    Console.Write("Yeni fiyat: ");
                                    if (double.TryParse(Console.ReadLine(), out yeniFiyat) && yeniFiyat >= 0)
                                    {
                                        break; 
                                    }
                                    Console.WriteLine("Geçersiz fiyat! Lütfen pozitif bir değer girin.");
                                }
                                urunler[i].Fiyat = yeniFiyat;
                                Console.WriteLine($"{guncellenecekAd} ürününün fiyatı güncellendi.");
                                bulundu = true;
                                break; 
                            }
                        }

                        if (!bulundu)
                        {
                            Console.WriteLine($"{guncellenecekAd} ürünü bulunamadı.");
                        }
                        break;

                    case 4:
                        
                        Console.WriteLine("Otomattaki Ürünler:");
                        if (urunler.Count == 0)
                        {
                            Console.WriteLine("Hiç ürün yok.");
                        }
                        else
                        {
                            foreach (var urun in urunler)
                            {
                                Console.WriteLine(urun);
                            }
                        }
                        break;

                    case 5:
                        
                        devam = false;
                        Console.WriteLine("Otomat makinesi kapatılıyor...");
                        break;
                }
            }
        }
    }   
        }

    


