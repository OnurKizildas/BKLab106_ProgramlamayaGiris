﻿using System;

namespace _2_Asama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programda bize öğretilen Method'ları kullanmadım..
            try
            {
                string ad = null;
                string sifre = null;
                string anne = null;
                DateTime tarih = default(DateTime);
            a:
                Console.WriteLine("1-)Giriş\n2-)Kayıt Ol\n3-)Şifremi Unuttum\n4-)Çıkış");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                b:
                    string ad1 = null;
                    string sifre1 = null;
                    Console.Write("Kullanıcı Adı:");
                    ad1 = Console.ReadLine();
                    if (ad1 == "")
                    {
                        Console.WriteLine("Kullanıcı Adı Boş Geçilemez");
                        goto b;
                    }
                z:
                    Console.Write("Şifre:");
                    sifre1 = Console.ReadLine();
                    if (sifre1 == "")
                    {
                        Console.WriteLine("Şifre Boş Geçilemez");
                        goto z;
                    }

                    if (ad1 == ad && sifre1 == sifre)
                    {
                        Console.WriteLine($"Hoşgeldin {ad}");
                        Console.WriteLine($"Giriş Yaptığın Zaman:{DateTime.Now}");
                        Console.WriteLine("1-)Geri\n2-)Çıkış");
                        int veriii = Convert.ToInt32(Console.ReadLine());
                        if(veriii == 1){
                            goto a;
                        }else if(veriii == 2){
                            Console.WriteLine("Hoşçakal...");
                            Environment.Exit(0);
                        }
                    }
                    else if (ad == null && sifre == null)
                    {
                        Console.WriteLine("Lütfen Kayıt Olunuz..");
                        goto a;
                    }
                    else if (ad1 != ad && sifre1 == sifre)
                    {
                        Console.WriteLine("Kullanıcı Adını Yanlış Girdiniz..");
                        Console.Write("1-)Denemeye Devam Et\n2-)Çıkış:");
                        int b = Convert.ToInt32(Console.ReadLine());

                        if (b == 1)
                        {
                            goto b;
                        }
                        else if (b == 2)
                        {
                            Console.WriteLine("Hoşçakal..");
                            Environment.Exit(0);
                        }
                    }
                    else if (ad1 == ad && sifre1 != sifre)
                    {
                        Console.WriteLine("Şifreyi Yanlış Girdiniz..");
                        Console.Write("1-)Denemeye Devam Et\n2-)Çıkış:");
                        int b = Convert.ToInt32(Console.ReadLine());

                        if (b == 1)
                        {
                            goto b;
                        }
                        else if (b == 2)
                        {
                            Console.WriteLine("Hoşçakal..");
                            Environment.Exit(0);
                        }
                    }
                    else if (ad1 != ad && sifre1 != sifre)
                    {
                        Console.WriteLine("Kullanıcı Adı ve Şifreyi Yanlış Girdiniz..");
                        Console.Write("1-)Denemeye Devam Et\n2-)Çıkış:");
                        int b = Convert.ToInt32(Console.ReadLine());

                        if (b == 1)
                        {
                            goto b;
                        }
                        else if (b == 2)
                        {
                            Console.WriteLine("Hoşçakal..");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Giriş Başarısız...");
                    }

                }
                else if (a == 2)
                {
                ad:
                    Console.Write("Kullanıcı Adı:");
                    ad = Console.ReadLine();
                    if (ad == "")
                    {
                        Console.WriteLine("Kullanıcı Adı Boş Geçilemez");
                        goto ad;
                    }
                sifre:
                    Console.Write("Şifre:");
                    sifre = Console.ReadLine();
                    if (sifre == "")
                    {
                        Console.WriteLine("Şifre Boş Geçilemez");
                        goto sifre;
                    }
                anne:
                    Console.Write("Annenizin Adı:");
                    anne = Console.ReadLine();
                    if (anne == "")
                    {
                        Console.WriteLine("Anne Adı Boş Geçilemez");
                        goto anne;
                    }
                tarihhh:
                    try
                    {
                        Console.Write("Doğum Tarihiniz:");
                        tarih = Convert.ToDateTime(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Doğum Tarihi Boş Geçilemez");
                        goto tarihhh;
                    }

                    Console.WriteLine("Kayıt Başarılı..");
                    goto a;
                }
                else if (a == 3)
                {
                c:
                    Console.Write("Kullanıcı Adınız:");
                    string ad2 = Console.ReadLine();
                    if (ad2 == "")
                    {
                        Console.WriteLine("Kullanıcı Adı Boş Geçilemez");
                        goto c;
                    }
                    else if (ad2 != ad)
                    {
                        Console.WriteLine($"\"{ad2}\" 'lı kullanıcı kayıtlı değil..");
                        Console.WriteLine("1-)Denemeye Devam Et\n2-)Ana Menü\n3-)Çıkış");
                        int b = Convert.ToInt32(Console.ReadLine());

                        if (b == 1)
                        {
                            goto c;
                        }
                        else if (b == 2)
                        {
                            goto a;
                        }
                        else if (b == 3)
                        {
                            Console.WriteLine("Hoşçakal..");
                            Environment.Exit(0);
                        }
                    }
                    else if (ad2 == ad)
                    {
                        DateTime tarih1 = default(DateTime);
                    m:
                        try
                        {
                            Console.Write("Doğum Tarihinizi Giriniz:");
                            tarih1 = Convert.ToDateTime(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Doğum Tarihi Alanı Boş Geçilemez");
                            goto m;
                        }
                        if (tarih != tarih1)
                        {
                            Console.WriteLine("Hatalı Giriş Yaptınız...\n1-)Tekrar Dene\n2-)Ana Menü\n3-)Çıkış");
                            int k = Convert.ToInt32(Console.ReadLine());

                            if (k == 1)
                            {
                                goto m;
                            }
                            else if (k == 2)
                            {
                                goto a;
                            }
                            else if (k == 3)
                            {
                                Console.WriteLine("Hoşçakal...");
                                Environment.Exit(0);
                            }
                        }
                        else if (tarih == tarih1)
                        {
                            int anne2 = 0;
                        y:
                            try
                            {
                                Console.WriteLine("Annenizin Adı Kaç Harften Oluşuyor?");
                                anne2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Bu Alan Boş Geçilemez");
                                goto y;
                            }
                            int harf = anne.Length;

                            if (harf == anne2)
                            {
                            hhh:
                                Console.Write("Yeni Şifre:");
                                sifre = Console.ReadLine();
                                if (sifre == "")
                                {
                                    Console.WriteLine("Bu Alan Boş Geçilemez");
                                    goto hhh;
                                }
                                int veri = 0;
                                int sayi = 0;
                            eeeeee:
                                try
                                {
                                    Console.WriteLine("Sen Robot musun?\nAşağıdaki sayının aynısını giriniz...");
                                    Random rastgele = new Random();
                                    sayi = rastgele.Next(999999);


                                    Console.Write($"{sayi}:");
                                    veri = Convert.ToInt32(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Bu Alan Boş Geçilemez Ve Sadece Sayı Girilebilir");
                                    goto eeeeee;
                                }
                                if (veri == sayi)
                                {
                                    Console.WriteLine("Şifreniz Değiştirildi..");
                                    goto a;
                                }
                                else if (veri != sayi)
                                {
                                    Console.WriteLine("Robot olma ihtimalinizden dolayı çıkış yapılıyor..");
                                    Environment.Exit(0);
                                }
                            }
                            else if (harf != anne2)
                            {
                                Console.WriteLine("Hatalı Giriş..\n1-)Tekrar Dene\n2-)Ana Menü\n3-)Çıkış");
                                int t = Convert.ToInt32(Console.ReadLine());

                                if (t == 1)
                                {
                                    goto y;
                                }
                                else if (t == 2)
                                {
                                    goto a;
                                }
                                else if (t == 3)
                                {
                                    Console.WriteLine("Hoşçakal...");
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                }
                else if (a == 4)
                {
                    Console.WriteLine("Hoşçakal..");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Lütfen Size Verilen Rakamlardan Giriş Yapınız...");
                    goto a;
                }
            }
            catch
            {
                Console.Write("Lütfen Size Verilen Rakamlardan Giriş Yapınız...\n");

                Main(args);
            }
        }
    }
}