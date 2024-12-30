namespace HavaDurumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hava Durumu Ödevi
            Console.WriteLine("Hava nasıl?(güzel/kötü)");
            string cevap = Console.ReadLine().ToLower().Trim();

            if (cevap == "güzel")
            {
                Console.WriteLine("Kaç derece?");
                sbyte derece = sbyte.Parse(Console.ReadLine());

                if (derece < 15)
                {
                    Console.WriteLine("Hava soğuk, dışarı çıkma.");
                }
                else if (derece >= 15 && derece <= 35)
                {
                    Console.WriteLine("Hava iyiymiş, dışarı çıkabilirsin.");
                }
                else if (derece > 35)
                {
                    Console.WriteLine("Hava çok sıcak, başına güneş geçer.");
                }
            }
            else if (cevap == "kötü")
            {
                Console.WriteLine("O zaman evde kal.");
            }
            else
            {
                Console.WriteLine("Sadece 'güzel' veya 'kötü' cevabı verilebilir.");
            }

        }
    }
    }

