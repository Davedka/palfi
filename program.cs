using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string filePath = "progress.json";

        // 1️⃣ Betöltjük az előző állapotot, ha létezik
        UserProgress progress = LoadProgress(filePath);

        // 2️⃣ Frissítjük az adatokat
        if (progress.Level == 1)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 2)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 3)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 4)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 5)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 6)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 7)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 8)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 9)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 10)
        {
            int index = 0;
        string[] questions =
        {
            ""
        };

        string[] answers =
        {
            ""
        };

        while (index < questions.Length)
        {
            Console.WriteLine(questions[index]);
            string userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Equals(answers[index], StringComparison.OrdinalIgnoreCase))
            {
                index++;
            }
            else
            {
                Console.WriteLine("Rossz válasz, próbáld újra!");
            }
        }

        Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
    }

    static void SaveProgress(string filePath, UserProgress progress)
    {
        string json = JsonConvert.SerializeObject(progress, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    static UserProgress LoadProgress(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<UserProgress>(json);
        }
        return new UserProgress(); // Ha nincs fájl, új állapot indul
    }
}

class UserProgress
{
    public int Level { get; set; } = 1;
}
