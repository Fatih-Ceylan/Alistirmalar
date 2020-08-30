namespace Alistirma
{
    class Alistirmalar
    {
        static void Main(string[] args)
        {

            #region for 1-100 arası bir ekleyerek yazdırma

            //for (int i = 1; i <= 100; i++)

            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadKey();

            #endregion

            #region  while 1-100 arası 4 ekleyerek yazdırma

            //int x = 1;

            //while (x <= 100)
            //{
            //    Console.WriteLine(x);
            //    x= x+4;

            //}
            //Console.ReadKey();

            #endregion

            #region girilen iki sayının toplamı

            //Console.Write("ilk numarayı girin: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("diğer numarayı girin: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("iki numaranın toplamı: {0} ", n1 + n2);

            //Console.WriteLine("çıkmak için bir tuşa basınız");
            //Console.ReadKey();

            #endregion

            #region girilen iki sayı arasını 2'şer ekleyek yazdırma

            //Console.Write("1.sayiyi giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sayiyi giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //while (sayi1 <= sayi2)

            //{
            //    Console.WriteLine(sayi1);
            //    sayi1 = sayi1 + 2;
            //}
            //Console.ReadKey();

            #endregion

            #region iki değer arasındaki sayıları gösterme

            //Console.WriteLine("1.sayıyı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());


            //while (sayi1 <= sayi2)
            //{
            //    Console.WriteLine(sayi1);
            //    sayi1++;
            //}

            #endregion

            #region 1-100 arasındaki sayılarda 3 ve 3'ün katlarını ekrana yazdırma

            //int x = 1;

            //while (x <= 100)
            //{
            //    if (x % 3 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //    x++;

            //}
            //Console.ReadKey();

            #endregion

            #region Girilen 5 adet sayının toplanıp yazılması


            //int sayac = 1;
            //int sayi = 0;
            //int toplam = 0;

            //while (sayac<=5)

            //{
            //    Console.Write("{0}. sayıyı giriniz: ", sayac);
            //     sayi = Convert.ToInt32(Console.ReadLine());

            //    toplam = toplam + sayi;
            //    sayac++;

            //}
            //Console.Write("Sayıların toplamı: {0}", toplam);
            //Console.ReadKey();

            #endregion

            #region Kaç adet sınav notu girileceği belirlenecek ve ortalaması alınacak

            //int sayac = 1;
            //int SinavAdet = 0;
            //int not = 0;
            //int toplam = 0;
            //int ortalama = 0;

            //Console.WriteLine("Kaç adet sınav girilecek?");
            //SinavAdet = Convert.ToInt32(Console.ReadLine());

            //while (sayac <= SinavAdet)
            //{
            //    Console.WriteLine("{0}.Sınav notunu giriniz", sayac);
            //    not = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + not;
            //    sayac++;
            //}

            //ortalama = toplam / SinavAdet;
            //Console.WriteLine("Sınav notu ortalamanız: {0}", ortalama);
            //Console.ReadKey();

            #endregion

            #region Kullanıcı adı ve parola girme, 3 tekrar hakkı

            //string admin = "fatih", sifre = "1";
            //string kullaniciAd, kullaniciSifre;
            //int hak = 3;
            //int deneme = 0;
            //do
            //{
            //    Console.Write("Kullanıcı adını giriniz: ");
            //    kullaniciAd = Console.ReadLine();

            //    Console.Write("Şifreyi giriniz: ");
            //    kullaniciSifre = Console.ReadLine();

            //    if (kullaniciAd == admin && kullaniciSifre == sifre)
            //    {
            //        Console.WriteLine("Hoşgeldiniz sayın {0}...", admin.ToUpper());
            //    }
            //    else
            //    {
            //        hak--;
            //        deneme++;

            //        Console.WriteLine("Yanlış giriş yaptınız ve {0} hakkınız kaldı.", hak);

            //        if (hak == 0)
            //        {
            //            Console.WriteLine("{0} defada doğru kullanıcı adı/parola giremediniz." +
            //                              " Lüften müşteri hizmetlerini arayınız!", deneme);
            //        }

            //    }

            //} while ((kullaniciAd != admin || kullaniciSifre != sifre) && hak != 0);

            //Console.ReadKey();

            #endregion

            #region Nested for loop

            //for (int i = 0; i <= 6; i++)
            //{
            //    for (int j=i; j <=6; j++)
            //    {
            //        Console.WriteLine ("i değeri: {0}, J değeri: {1}", i,j);
            //    }
            //}
            //Console.Read();

            #endregion

            #region 0 girilene kadar sayıları arka planda toplama

            //int sayi;
            //int  toplam=0;

            //do
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam +sayi;

            //} while (sayi!=0);
            //Console.WriteLine("Sayıların toplamı:{0} " , toplam);
            //Console.ReadKey();

            #endregion

            #region rastgele üretilen bir sayıyı 5 hakta tahmin etme

            //Random rnd = new Random();

            //int uretilensayi = rnd.Next(15, 30);
            //int sayi;
            //int hak = 5;
            //int tekrar = 0;

            //Console.WriteLine("Üretilen sayı: {0}", uretilensayi);

            //do
            //{
            //    Console.WriteLine("Bir tahminde bulununuz: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    hak--;
            //    tekrar++;

            //    if (sayi == uretilensayi)
            //    {
            //        Console.WriteLine("Tebrikler! Doğru sayıyı {0}. tahminde buldunuz!", tekrar);
            //    }
            //    else if (sayi < uretilensayi && hak > 0)
            //    {
            //        Console.WriteLine("Sayıyı büyütün, {0} hakkınız kaldı", hak);

            //    }
            //    else if (sayi > uretilensayi && hak > 0)
            //    {
            //        Console.WriteLine("Sayıyı küçültün, {0} hakkınız kaldı", hak);
            //    }

            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Malesef {0} kerede doğru tahminde bulunamadınız!", tekrar);
            //    }


            //} while (sayi != uretilensayi && hak != 0);

            //Console.WriteLine("Çıkmak için bir tuşa basınız");
            //Console.ReadKey();

            #endregion

            #region dışarıdan girilen sayıya kadar çıktısını yazın

            //Console.WriteLine(" sayı gir");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region dizi içeriğinin minimum maximum değerlerini sıralayın
            //int[] dizi = new int[] { 3, 1, 4, 7, 2, 500 };
            //int max = 0;
            //int min = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i] > dizi[0])
            //    {
            //        max = dizi[i];
            //    }
            //    else
            //    {
            //        min = dizi[i];
            //    }
            //}

            //Console.WriteLine("Max değer: " + max);
            //Console.WriteLine("min değer: " + min);
            //Console.ReadKey();

            #endregion

            #region dizideki içeriklerin karesini alma
            /*
                        int[] dizi = new int[] { 3, 1, 40, 7, 2, 500, 6, 10 };
                        int[] dizi2 = new int[dizi.Length];

                        for (int i = 0; i < dizi.Length; i++)
                        {
                            dizi2[i] = dizi[i] * dizi[i];
                            Console.WriteLine(dizi2[i]);
                        }
                        Console.ReadKey();

                        //   karesi 50'den büyük  olanlarını gösterme
                        for (int i = 0; i < dizi2.Length; i++)
                        {
                            dizi2[i] = dizi[i] * dizi[i];
                            if (dizi2[i] > 50)
                            {
                                Console.WriteLine(dizi[i]);
                            }
                        }
                        Console.ReadKey();
             */
            #endregion

            #region ekrana 5 defa sayı girilip, girilen sayı kadar yıldız yazdırılacak, devam etmek istediğimizi soracak

            //int abc = 1;
            //int count = 1;
            //while (abc == 1)
            //{
            //    if (count == 6)
            //    {
            //        Console.WriteLine("Devam etmek istiyor musun?");
            //        string cevap = Console.ReadLine(); //E or H

            //        if (cevap == "E")
            //        {
            //            count = 1;
            //        }
            //        else
            //        {
            //            Console.WriteLine("uygulamadan çıkıldı bir tuşa bas!");
            //            break;
            //        }
            //    }
            //    Console.WriteLine("Sayı gir!");
            //    int sayi = int.Parse(Console.ReadLine());
            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine("");
            //    count += 1;
            //}

            //Console.ReadKey();

            #endregion

            #region dizi içindeki tek ve çift sayıları ayıklama
            /*
                        /// İlk olarak tek ve çift sayılarımızı tutacak iki adet değişken tanımlıyoruz.
                        string teksayilar = "";
                        string ciftsayilar = "";
                        /// Burada int[] ifadesiyle te boyutlu bir dizi tanımlıyoruz ve 0'dan 9'a kadar elaman atıyoruz.
                        int[] dizi = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        /// Döngümüzü kuruyoruz. Döngümüz 0'dan başlayıp dizideki elaman sayısı kadar dönecek.
                        for (int i = 0; i < dizi.Length; i++)
                        {
                            // Burada dizinin i. elemanının 2'ye göre modunu alıyoruz.
                            // Eğer sonuc 1 ise sayı tektir.
                            if (dizi[i] % 2 == 1)
                                teksayilar += dizi[i].ToString();
                            else
                                // Değilse sayı çifttir.
                                ciftsayilar += dizi[i].ToString();
                        }
                        /// Daha sonra kullanıcıya mesaj olarak veriyoruz. Burayı istediğiniz şekilde yazdırabilirsiniz.
                        Console.WriteLine("TekSayı: " + teksayilar.ToString() + " / ÇiftSayı: " + ciftsayilar.ToString());
                        Console.ReadLine();


                        /* alternatif yol



                        */
            #endregion

            #region Fibonacci dizilimi

            //int x = 0;
            //int y = 1, z;
            //int sayi;
            //Console.WriteLine("Adım sayısını giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine(x + " " + "\n" + y + " ");
            //for (int i = 0; i < sayi - 2; i++)
            //{
            //    z = x + y;
            //    Console.WriteLine(z);
            //    x = y;
            //    y = z;
            //}
            //Console.ReadKey();

            #endregion

            #region Kelime tahmin etme

            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 4;
            //bool outOfGuesses = false;

            //Console.WriteLine("Guess the magic word! \n");
            //while (guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter your guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;

            //        if (guessCount != guessLimit)
            //        {
            //            Console.WriteLine($"Remaining guess: {guessLimit - guessCount}");
            //        }
            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }
            //}
            //if (outOfGuesses)
            //{
            //    Console.WriteLine("You Lose!");
            //}
            //else
            //{
            //    Console.WriteLine("You Win!");
            //}

            //Console.ReadKey();
            #endregion
        }
    }
}











