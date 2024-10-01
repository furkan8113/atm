See https://aka.ms/new-console-template for more information

            int bakiye = 1000;
            Console.WriteLine("ATM ye Hoşgeldiniz");
            Console.WriteLine("Hangi işlemi yapmak istiyorsunuz ?");
            
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Kalan Bakiyeniz :"+bakiye);
                Console.ReadLine();

            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istedğiniz tutarı giriniz :");
                int cekilecektutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecektutar > bakiye)
                    Console.WriteLine("Geçersiz tutar girdiniz.");
                else
                {
                    Console.WriteLine("Kalan tutar : " + (bakiye - cekilecektutar));
                }
                


            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz :");
                int yatirilacaktutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni bakiyeniz :"+(bakiye+yatirilacaktutar));
            }
            else if (secim == "4")
            {
                Console.WriteLine("Atmden çıkış yapılıyor.");



            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem giriniz.");
                Console.ReadLine();
            }

            Console.ReadLine();

        }
    }
}
