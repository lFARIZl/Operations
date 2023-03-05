namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float TotalAzerbaijanBudget = 20000000;
            float TotalPayMinistryOfDefence = TotalAzerbaijanBudget * 0.2F;
            float TotalPayMinistryOfHighTechnologies = TotalAzerbaijanBudget * 0.1F;
            float RestOfBudget = TotalAzerbaijanBudget - TotalPayMinistryOfDefence - TotalPayMinistryOfHighTechnologies;

            Console.WriteLine("Büdcə: " + TotalAzerbaijanBudget);
            Console.WriteLine("Müdafiə Nazirliyinə: " + TotalPayMinistryOfDefence);
            Console.WriteLine("Yüksək Texnologiyalar Nazirliyinə: " + TotalPayMinistryOfHighTechnologies);
            Console.WriteLine("Yerdə qalan büdcə: " + RestOfBudget);
        }
    }
}