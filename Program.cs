namespace HesapMakinesiGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi\n");

            Console.Write("Birinci Sayıyı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("İşlem Seçiniz(+, -, *, /, %): ");
            string islem = Console.ReadLine();


            if (islem == "+")
            {
                Console.WriteLine("Sonuc: " + (sayi1 + sayi2) );
            }
            else if (islem == "-")
            {
                Console.WriteLine("Sonuc: " + (sayi1 - sayi2) );
            }

        }
    }
}