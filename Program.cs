namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kolaybolum, ortabolum, zorbolum, kolay, orta, zor;
            int puan = 100;
            Random rnd_kolay = new Random();
            kolay = rnd_kolay.Next(1, 3);
            Console.WriteLine("Sayıları tahmin ediniz. Bölüm: Kolay");
            do
            {
                Console.WriteLine("1 ile 3 arasında tahmin yapınız.");
                kolaybolum = Convert.ToInt32(Console.ReadLine());
                
                
                
                if (kolaybolum == kolay)
                {
                    Console.WriteLine("Doğru Cevap, Diğer seviyeye geçtiniz : Orta");
                    Random rnd_orta = new Random();
                    orta = rnd_orta.Next(1, 4);
                    do
                    {
                        Console.WriteLine("1 ile 5 arası bir değer giriniz : ");
                        ortabolum = Convert.ToInt32(Console.ReadLine());
                        if (ortabolum == orta)
                        {
                            Console.WriteLine("Doğru Cevap, Diğer seviyeye geçtiniz : Zor");
                            Random rnd_zor = new Random();
                            zor = rnd_zor.Next(1, 10);

                            do
                            {
                                Console.WriteLine("1 ile 10 arası bir değer giriniz : ");
                                zorbolum = Convert.ToInt32(Console.ReadLine());
                                if (zorbolum == zor)
                                {
                                    Console.WriteLine("Doğru Cevap, Puan : " + puan);
                                    puan = 0;
                                }

                                else
                                {
                                    puan -= 10;
                                    Console.WriteLine("Yanlış Cevap, Puan : " + puan);
                                }
                            } while (puan != 0);
                        }

                        
                        
                        else
                        {
                            puan -= 10;
                            Console.WriteLine("Yanlış Cevap, Puan : " + puan);
                        }

                    } while (puan != 0);

                }

                else
                {
                    puan -= 10;
                    Console.WriteLine("Yanlış Cevap, Puan : " + puan);
                }

            } while (puan != 0);
        }
    }
}