namespace Lab_Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TotalAznInfo = "Məbləğ (AZN) : ";
            string TotalUsdInfo = "ABŞ dolları (USD) : ";
            string TotalEurInfo = "Avro (EUR) : ";
            string TotalRublInfo = "Rusiya rublu (RUB) : ";


            float TotalAzn = 1000;
            float TotalUsd = TotalAzn / 1.7000F;
            float TotalEur = TotalAzn / 1.8036F;
            float TotalRubl = TotalAzn / 0.0225F;

            Console.WriteLine(TotalAznInfo);
            Console.WriteLine(TotalAzn);

            Console.WriteLine(TotalUsdInfo);
            Console.WriteLine(TotalUsd);

            Console.WriteLine(TotalEurInfo);
            Console.WriteLine(TotalEur);

            Console.WriteLine(TotalRublInfo);
            Console.WriteLine(TotalRubl);




        }
    }
}