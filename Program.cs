using System.Collections.Concurrent;

namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aylar ay = Aylar.Aralik;

            //if (ay == Aylar.Kasim)
            //{
            //    Console.WriteLine("Evet Kasım ayındayız.");
            //}

            //switch (ay)
            //{
            //    case Aylar.Kasim:
            //        Console.WriteLine("Kasım ayındayız.");
            //        break;
            //    case Aylar.Aralik:
            //        Console.WriteLine("Aralık ayındayız.");
            //        break;

            //}

            Console.WriteLine("Haftanın Gününü Sayı Olarak Gir (1-7): ");
            int girilenGun = Convert.ToInt32(Console.ReadLine());

            girilenGun -= 1;

            if (Enum.IsDefined(typeof(Haftalar),girilenGun))
            {
                Haftalar gun = (Haftalar)girilenGun;
                Console.WriteLine("Seçilen gün: " + gun);

            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız.");
            }



        }
    }
}