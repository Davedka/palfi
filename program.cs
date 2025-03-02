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
            "Egy háromszög 11 cm hosszú oldalával szemközti szöge 45°-os. Ennek a háromszögnek van egy 122°-os szöge is. Hány cm hosszú a háromszög 122°-os szögével szemközti oldala?,                                                                                                          
            "(x^2-4x+4)/(x^2-4) = 2",
            "Egy építkezésre teherautókkal szállítják a homokot. Öt egyforma teherautó mindegyikének nyolcszor kellene fordulnia, hogy az összes homokot odaszállítsák. Hány fordulóval                              
                                                                	tudná odaszállítani ugyanezt a mennyiségű homokot négy ugyanekkora teherautó?",
            "Egy meteorológiai állomáson november első hetében az alábbi napi hőmérsékleti maximumokat mérték (celsius fok-ban): 9, 5, 6, 9, 6, 6, 8. Adja meg az adatok átlagát, terjedelmét és mediánját!",
            "Egy vasúti tartálykocsi tömege üres tartállyal 23,8 tonna. Ebben a tartálykocsiban maximum 60 000 liter üzemanyagot szállíthatnak. Egy liter üzemanyag tömege 0,85 kg.                                 
                                                                	feladat: Hány tonna a tartálykocsi tömege tele tartállyal?",
            "Az ABCD paralelogramma AB oldala 8 cm, AC átlója 11 cm hosszú.                                                                                                                                         
                                                                	Az AB oldal és az AC átló 32fok-os szöget zár be egymással.
                                                                	feladat: Számítsa ki a paralelogramma területét!",
            "Az előző tanévben Janka történelemből kapott első három jegye 3, 3, 4 volt. A tanév                                                                                                                      
                                                                	hátralevő részében már csak ötösöket kapott.
                                                                	feladat: Hány ötöst kapott összesen történelemből Janka, ha tudjuk, hogy a tanév végén éppen 4,5 lett az átlaga?",
            "Hányadik hatványra kell emelni a 2-t, hogy 512-t kapjunk?",
            "Válassza ki az alábbiak közül azt az állítást, amely tagadása a következőnek!                                                                                                                             
                                                                		Volt olyan nap a múlt héten, amikor esett az eső.
                                                                	A: A múlt héten minden nap esett az eső.
                                                                	B: Nem volt olyan nap a múlt héten, amikor esett az eső.      
                                                                	C: Volt olyan nap a múlt héten, amikor nem esett az eső.",  
            "Oldja meg az alábbi egyenletet a valós számok halmazán!                                                                                                                                                     
                                                                			|x −4| = 1"                                                                                                                  
                                                                                                                                
        };

        string[] answers =
        {
            "13,2cm","2 és -6","10","7, 4 és 6","74,8 tonna","46,6cm2","7 ötös","9","C","5 és 3"
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
            "2016-ban milyen régióbol jött csapat nyerte meg a worlds-t(major) a- SK GAMING b- MIBR (Made in Brazil) c- Natus Vincere",
        };

        string[] answers =
        {
            "a"
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
