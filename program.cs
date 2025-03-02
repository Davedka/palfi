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
            "Egy háromszög 11 cm hosszú oldalával szemközti szöge 45°-os. Ennek a háromszögnek van egy 122°-os szöge is. Hány cm hosszú a háromszög 122°-os szögével szemközti oldala?",                                                                                                          
            "(x^2-4x+4)/(x^2-4) = 2",
            "Egy építkezésre teherautókkal szállítják a homokot. Öt egyforma teherautó mindegyikének nyolcszor kellene fordulnia, hogy az összes homokot odaszállítsák. Hány fordulóval tudná odaszállítani ugyanezt a mennyiségű homokot négy ugyanekkora teherautó?",
            "Egy meteorológiai állomáson november első hetében az alábbi napi hőmérsékleti maximumokat mérték (celsius fok-ban): 9, 5, 6, 9, 6, 6, 8. Adja meg az adatok átlagát, terjedelmét és mediánját!",
            "Egy vasúti tartálykocsi tömege üres tartállyal 23,8 tonna. Ebben a tartálykocsiban maximum 60 000 liter üzemanyagot szállíthatnak. Egy liter üzemanyag tömege 0,85 kg. Hány tonna a tartálykocsi tömege tele tartállyal?",
            "Az ABCD paralelogramma AB oldala 8 cm, AC átlója 11 cm hosszú. Az AB oldal és az AC átló 32fok-os szöget zár be egymással. Számítsa ki a paralelogramma területét!",
            "Az előző tanévben Janka történelemből kapott első három jegye 3, 3, 4 volt. A tanév hátralevő részében már csak ötösöket kapott. Hány ötöst kapott összesen történelemből Janka, ha tudjuk, hogy a tanév végén éppen 4,5 lett az átlaga?",
            "Hányadik hatványra kell emelni a 2-t, hogy 512-t kapjunk?",
            "Válassza ki az alábbiak közül azt az állítást, amely tagadása a következőnek!\n„Volt olyan nap a múlt héten, amikor esett az eső.”\nA: A múlt héten minden nap esett az eső.\nB: Nem volt olyan nap a múlt héten, amikor esett az eső.\nC: Volt olyan nap a múlt héten, amikor nem esett az eső.",  
            "Oldja meg az alábbi egyenletet a valós számok halmazán!\n|x −4| = 1"  
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
            "mennyibe kerül (2025 márc) p250 sand dune factory new a- 0.50$ - 0.60$ b- 25$ c- 50$",
            "ha az 1. pisztolykört megnyerik a terroristák és bombát raknak majd a második körben 3-mac10 ölést és egy késeléssel megnyerik a kört plusz megölik az utolsót + 300 $ akkor annak a az embernek mennyi pénze lesz aki késelt? (nem 1 ember szerez 3killt hanem 3 külön ember és 1 szerez késelést) a- 5000$ b- 2500 c- 3500",
            "ha 2014-ben vett volna az ember egy ex ibuypower matricát akkor az mennyibe került a- 0.06$ b-70000$ c- 5$ (majorre jutottak)",
            "S1mple-nek hltv top1je van a-3 b-5 c-10",
            "mikor volt a legelső major a- 2005 b- 2010 c- 2013",
            "mikor volt az legutóbbi major 2024-ben a- január b- március c - december"
            "Ádám Torzsi Torzsás mióta van a MouzSportsban (beleszámitva amikor az akadémiába érkezett) a -3év b- 5hónap c- 4év",
            "miért kellet nerfelni 2015 elején az awp-t (válaszolós kérdés)",
            "Donk 17 éves cs prodigy orosz hol és mikor szerezte meg az első mvp-jét egy s-tier tournamenten 2024"
        };

        string[] answers =
        {
            "a","a","a","a","a","c","c","c","mert Kennys túl jó volt","katowice"
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
            "mit jelent a c# a- csharp b- c hastag b- éles cbetű",
            "mi a rövidítése a htmlnek (válaszolós)",
            "hány for-t lehet nestelni egymásba (válaszolós)",
            "egy if be egybe lehet belerakni-e and és or-t",
            "mekkora legkisebb tömbnek az indexe",
            "for lehet e végtelen",
            "eljárás tud e használni return-t",
            "mennyi ága  lehet egy elágazásnak",
            "mit jelent a py",
            "lehet e fügvényt meghivni az öszes paraméter nélkül"
        };

        string[] answers =
        {
            "a","Hypertext Markup Language","végtelen","nem mert ez c#","0","lehet","tud","végtelen","python","lehet"
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
            "hol kelett volna véget érnie a halálos irambannak a- 5.rész b- 7.rész c- sose",
            "a fűrész 1 mikor jött ki?",
            "hány része van a sikolynak",
            "sikoly 6-ban  Tara-t ki játsza",
            "meik filmben halatszódott el az hogy bogie ember",
            "milyen folyóba fulladt bele először jason",
            "jason-nek miért nincs maszkja az 1.részben",
            "a fűrész 10-ben mi az indok arra hogy megölje az embereket jonh kramer",
            "a fűrészben amanda miért segíti kramer-t a gyilkolásokban",
            "jigsaw miért csinálja ezeket a "förtelmes" dolgokat azokkal az emberekkel akiket odavisz a dungeonbe (filmbe ellet mondva)"
        };

        string[] answers =
        {
            "a","2004","6","Jenna Ortega","halloween","crystal lake","mert még nem találta meg","mert kramer-t becsapták azzal hogy a fejét meg műtik igy tuléli a halált","mert tulélte","az emberek olyan tetteket csináltak ami szembe megy az élettel"
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
            "Melyik bajnok rendelkezik egy olyan passzív képességgel, amely lehetővé teszi számára, hogy minden szövetséges támadását megerősítse?",
            "Melyik bajnok képes a saját életét áldozni, hogy folyamatosan mozgási sebességet és támadási sebességet kapjon?",
            "Melyik az egyetlen bajnok, akinek az egyik képessége közvetlenül változtatja meg a támadásai típusát (fizikai sebzésről mágikusra vagy fordítva)?",
            "Melyik bajnok képes a játékban egy rövid időre "falon keresztül" látni anélkül, hogy igazi látómezőt biztosítana?",
            "Melyik az egyetlen bajnok, aki képes átalakulni egy másik formába anélkül, hogy ulti képességet használna?",
            "Melyik bajnok képes a saját életét áldozni, hogy folyamatosan mozgási sebességet és támadási sebességet kapjon?",
            "Melyik bajnok rendelkezik egy olyan képességgel, amely lehetővé teszi számára, hogy egyetlen gombnyomással előrébb mozduljon egy rövid távolságot, és egyből támadjon is?",
            "Melyik az egyetlen bajnok, akinek egy képessége egyszerre tudja meggyógyítani és sebezni az ellenfelet?",
            "bajnok tud a saját képességei segítségével egy másik bajnok képességeit is befolyásolni?",
            "Melyik bajnok képes arra, hogy egy nagy területet robbanásveszélyes zónává változtasson, amely késleltetett sebzést okoz?"
        };

        string[] answers =
        {
            "milio","Briar","Zeri","Naafiri","K'Sante","Briar","Smolder","Renata Glasc","Viego","Bel'veth"
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
            "Kik voltak a jakobinusok a francia forradalom idején?",
            "Milyen következményekkel járt a nagy földrajzi felfedezések kora?",
            "Mi volt a hidegháború?",
            "Hogyan változtatta meg az ipari forradalom a társadalmat?",
            "mettől meddig tartott az első világháboru",
            "az usa miért száltt be az első világháboruba 1917-ben",
            "mikor volt a normandiai partra szállás",
            "törökök meddig szálták meg az országunkat öszesen",
            "hitler menyi embert ölt meg",
            "mikor volt oroszországban polgárháboru"
        };

        string[] answers =
        {
            "republikánus politikai csoport","kereskedelmi hálózatokat hoztak","az USA és a Szovjetunió közötti  szembenállás","kézi munkáról  gépi termelés","1914-1918","A németek korlátlan tengeralattjáró-háborúja fenyegette az amerikai kereskedelmi érdekeket és állampolgárok életét.","1944","150év","17 millió","1917"
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
              "a bérmálkozás
               b bérmákozás
               c bérmálás",

              "a ínyenc 
               b ínyensz
               c ínyencz",

              "a szimpatikus 
               b szímpatikus
               c szimpáttikus",

              "a egyhangúan 
               b egyhangúan
               c egyhangúlyan",

              "a kettőzzük 
               b kettőzük
               c kettőzzük meg",

              "a egyetérteni 
               b egyet érteni
               c eggyetérteni",

              "a helyesírás 
               b helyes írás
               c hejesírás",
                
              "a kegyenc 
               b kegyensz
               c kegyens",

              "a szüntelen 
               b szüntetlen
               c szüntetetlen",

              "a tulajdonképpen 
               b tulajdon képpen
               c tulajdónképpen"

        };

        string[] answers =
        {
            "c","a","a","a","a","a","a","a","a","a"
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
            "mi volt a politikája paul kottnak",
            "kire szavazott tanár úr előző választásokkor",
            "mikor volt az előző fidesz 2/3 ad választásokkor",
            "kiegészítés Orbán viktor mondja hogy: any questions",
            "mi tortent a varoshazaval mikor magyar peti es az ismeretlen tidzasok bevonultak a - felrobbant b - nagasaki c- kerdeztek magyar petit de nem valaszolt",
            "az m1 által milyen kampányt akartak a fideszesek felvenni a harcot magyar péter ellen",
            "fidesz politikája milyen szinten van",
            "miről szolt 2015-ben a hiradó folyamat",
            "ki amerika elnőke",
            "ki volt a Szovjetunió utolsó elnőke"
        };

        string[] answers =
        {
            "megölte a szeműveges embereket mert tul sokat tudtak","","2022","is there","c","hogy a pöcsére mondták hogy kicsi","óvóda","soros terv, migránció, brüsszel","Trump","Gorbacsov"
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

    Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
           progress.Level++;
           SaveProgress(filePath, progress);
        }
        else if (progress.Level == 11)
        {
            int index = 0;
        string[] questions =
        {
            "Ki az a jani  a- lepcsore hugyozott es kopkod jani b- thevrjani c- thevrpisti",
            "Morvai milyen bizniszt kezdett el 10.be a- dropship b - gamba c- thevrpisti",
            "mikor jott ki az nfs heat a- 2022 b - 2005 c- 2019",
            "mi volt a legelso nfs amivel jatszottam (dawe) a- nfs underground  b- nfs heat c- nfs most wanted",
            "kokinak hany centi a kukija a- python b- ---> c- --<",
            "az elso demonkiraly hany sor volt az eredeti a-500 b- 1100 c- thevrpisti",
            "thevr pisitinek mi volt az elso nagyobb rage-e videoban ami hungarikummá vált milyen játék és mikor a- catmario 2014 b-catmario 2013 c- catmario 2020",
            "mi az élet értelme a- ketto nulla ketto negy b - 42 c - thevrpisti",
            "hogy kerül a füre lépni tilos tábla a gyep közepére a- odaraktak b- odakerult c- ledobtak az ufok",
            "mennyi 15710 piros gombnak a fele a- anegyzeten ami gyok alatt van szor 2vel b- 7855 c- sokféle",
        };

        string[] answers =
        {
            "b","a és b","c","b","a","b","a","c","a","b"
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
