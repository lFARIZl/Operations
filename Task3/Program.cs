namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstBrend = "Adidas";
            int FirstShooseCount = 4;
            int FirstShoosePrice = 200;
            int FirstTotalPrice = FirstShooseCount * FirstShoosePrice;

            string SecondBrand = "Gucci";
            int SecondShooseCount = 2;
            int SecondShoosePrice = 1000;
            int SecondTotalPrice = SecondShooseCount * SecondShoosePrice;

            string ThirdBrand = "Nike";
            int ThirdShooseCount = 1;
            int ThirdShoosePrice = 150;
            int ThirdTotalPrice = ThirdShooseCount * ThirdShoosePrice;


            Console.WriteLine("Firma : " + FirstBrend );
            Console.WriteLine("Ayaqqabi sayi: " + FirstShooseCount);
            Console.WriteLine("Birinin qiymeti ($): " + FirstShoosePrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($): " + FirstTotalPrice);


            Console.WriteLine("Firma : " + SecondBrand);
            Console.WriteLine("Ayaqqabi sayi: " + SecondShooseCount);
            Console.WriteLine("Birinin qiymeti ($): " + SecondShoosePrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($): " + SecondTotalPrice);



            Console.WriteLine("Firma : " + ThirdBrand);
            Console.WriteLine("Ayaqqabi sayi: " + ThirdShooseCount);
            Console.WriteLine("Birinin qiymeti ($): " + ThirdShoosePrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($): " + ThirdTotalPrice);


        }
    }
}