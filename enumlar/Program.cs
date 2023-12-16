using System;

class Program
{
    enum Gunler
    {
        Pazartesi = 1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    static void Main()
    {
        Console.WriteLine("Lütfen bir gün seçiniz:");

        foreach (var gun in Enum.GetValues(typeof(Gunler)))
        {
            Console.WriteLine($"{(int)gun}. {gun}");
        }

        int secilenGunNumarasi;
        bool gecerliGiris = false;

        do
        {
            Console.Write("Gün numarasını giriniz: ");

            if (int.TryParse(Console.ReadLine(), out secilenGunNumarasi))
            {
                if (Enum.IsDefined(typeof(Gunler), secilenGunNumarasi))
                {
                    gecerliGiris = true;
                }
                else
                {
                    Console.WriteLine("Geçersiz gün numarası! Lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        } while (!gecerliGiris);

        Gunler secilenGun = (Gunler)secilenGunNumarasi;

        Console.WriteLine($"Seçilen gün: {secilenGun}");

        if (secilenGun >= Gunler.Pazartesi && secilenGun <= Gunler.Cuma)
        {
            Console.WriteLine("Bu gün bir hafta içi günüdür.");
        }
        else
        {
            Console.WriteLine("Bu gün bir hafta sonu günüdür.");
        }
    }
}
