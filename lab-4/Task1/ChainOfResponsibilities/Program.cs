namespace ChainOfResponsibilities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Створення рівній
            SupportHandler level1 = new Level1SupportHandler();
            SupportHandler level2 = new Level2SupportHandler();
            SupportHandler level3 = new Level3SupportHandler();
            SupportHandler level4 = new Level4SupportHandler();

            // Встановлення рівній для підтримки
            level1.SetNext(level2);
            level2.SetNext(level3);
            level3.SetNext(level4);
            while (true)
            {
                Console.WriteLine("Вітаємо в системі підтримки користувачів. Будь ласка, оберіть опцію:");
                Console.WriteLine("1. Проблема зі з'єднанням інтернету");
                Console.WriteLine("2. Проблема з програмним забезпеченням");
                Console.WriteLine("3. Проблема з апаратною частиною");
                Console.WriteLine("4. Інша проблема");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Будь ласка, введіть коректний варіант.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        level1.HandleRequest(RequestType.InternetIssue);
                        break;
                    case 2:
                        level1.HandleRequest(RequestType.SoftwareIssue);
                        break;
                    case 3:
                        level1.HandleRequest(RequestType.HardwareIssue);
                        break;
                    case 4:
                        level1.HandleRequest(RequestType.OtherIssue);
                        break;
                }

                Console.WriteLine("Чи бажаєте продовжити? (Так/Ні)");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "так")
                    break;
            }
        }
    }
}