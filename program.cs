using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string filePath = "progress.json";

        UserProgress progress = LoadProgress(filePath);

        System.Console.WriteLine("Szia, ebben a 'játékban' 10 kategóri 10 kérdését fogod megválaszolni. Viszont ha elrontssz egy kérdést akkor egy kategóriával visszább kerülsz, az első kategória kivétel ez alól. Jó szórakozást!");
        while (true)
        {
            if (progress.Level == 1)
            {
                int index = 0;
            string[] questions =
            {
                "1. Egy háromszög 11 cm hosszú oldalával szemközti szöge 45°-os. Ennek a háromszögnek van egy 122°-os szöge is. Hány cm hosszú a háromszög 122°-os szögével szemközti oldala?",                                                                                                          
                "2. Számítsd ki az x-et ebben az egyenletben(ha két válasz van akkor és-el írd pl '1 és -2'):\n (x^2-4x+4)/(x^2-4) = 2" ,
                "3. Egy építkezésre teherautókkal szállítják a homokot. Öt egyforma teherautó mindegyikének nyolcszor kellene fordulnia, hogy az összes homokot odaszállítsák. Hány fordulóval tudná odaszállítani ugyanezt a mennyiségű homokot négy ugyanekkora teherautó?",
                "4. Egy meteorológiai állomáson november első hetében az alábbi napi hőmérsékleti maximumokat mérték (celsius fok-ban): 9, 5, 6, 9, 6, 6, 8. Adja meg az adatok szórását tizedesekre kerekítve!",
                "5. Egy vasúti tartálykocsi tömege üres tartállyal 23,8 tonna. Ebben a tartálykocsiban maximum 60 000 liter üzemanyagot szállíthatnak. Egy liter üzemanyag tömege 0,85 kg. Hány tonna a tartálykocsi tömege tele tartállyal?",
                "6. Az ABCD paralelogramma AB oldala 8 cm, AC átlója 11 cm hosszú. Az AB oldal és az AC átló 32fok-os szöget zár be egymással. Számítsa ki a paralelogramma területét!",
                "7. Az előző tanévben Janka történelemből kapott első három jegye 3, 3, 4 volt. A tanév hátralevő részében már csak ötösöket kapott. Hány ötöst kapott összesen történelemből Janka, ha tudjuk, hogy a tanév végén éppen 4,5 lett az átlaga?",
                "8. Hányadik hatványra kell emelni a 2-t, hogy 512-t kapjunk?",
                "9. Válassza ki az alábbiak közül azt az állítást, amely tagadása a következőnek!\n„Volt olyan nap a múlt héten, amikor esett az eső.”\nA: A múlt héten minden nap esett az eső.\nB: Nem volt olyan nap a múlt héten, amikor esett az eső.\nC: Volt olyan nap a múlt héten, amikor nem esett az eső.",  
                "10. Oldja meg az alábbi egyenletet a valós számok halmazán!\n|x −4| = 1"
            };

            string[] answers =
            {
                "13,2cm","2 és -6","10","1,2","74,8 tonna","46,6cm2","7 ötös","9","C","5 és 3"
            };

            while (index < questions.Length)
            {
                if (index == 0) System.Console.WriteLine("Ez az első kategória: Matek\n");
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("Rossz válasz, próbáld újra");
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
                "1. 2016-ban milyen régióbol jött csapat nyerte meg a worlds-t(major)\na) SK GAMING\nb) MIBR (Made in Brazil)\nc) Natus Vincere",
                "2. mennyibe kerül (2025 márc) p250 sand dune factory new\na) 0.50$ - 0.60$\nb) 25$\nc) 50$",
                "3. ha az 1. pisztolykört megnyerik a terroristák és bombát raknak majd a második körben 3-mac10 ölést és egy késeléssel megnyerik a kört plusz megölik az utolsót + 300 $ akkor annak a az embernek mennyi pénze lesz aki késelt? (nem 1 ember szerez 3killt hanem 3 külön ember és 1 szerez késelést)\na) 5000$\nb) 2500\nc) 3500",
                "4. ha 2014-ben vett volna az ember egy ex ibuypower matricát akkor az mennyibe került\na) 0.06$\nb) 70000$\nc) 5$ (majorre jutottak)",
                "5. S1mple-nek hltv top1je van\na) 3\nb) 5\nc) 10",
                "6. mikor volt a legelső major\na) 2005\nb) 2010\nc) 2013",
                "7. mikor volt az legutóbbi major 2024-ben\na) január\nb) március\nc) december",
                "8. Ádám Torzsi Torzsás mióta van a MouzSportsban (beleszámitva amikor az akadémiába érkezett)\na) 3év\nb) 5hónap\nc) 4év",
                "9. miért kellet nerfelni 2015 elején az awp-t",
                "10. Donk 17 éves cs prodigy orosz hol és mikor szerezte meg az első mvp-jét egy s-tier tournamenten 2024"
            };

            string[] answers =
            {
                "a","a","a","a","a","c","c","c","mert Kennys túl jó volt","katowice"
            };

            while (index < questions.Length)
            {
                if (index == 0) System.Console.WriteLine("Ez az második kategória: Counter-Strike \n");
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("Rossz válasz, mész egy kategóriával viszább!");
                    progress.Level--;
                    SaveProgress(filePath, progress);
                    Console.ReadKey();
                    break;
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
                "1. mit jelent a c#\na) csharp\nb) c hastag\nc) éles cbetű",
                "2. mi a rövidítése a htmlnek",
                "3. hány for-t lehet nestelni egymásba",
                "4. egy if be egybe lehet belerakni-e and és or-t",
                "5. mekkora legkisebb tömbnek az indexe",
                "6. for lehet e végtelen",
                "7. eljárás tud e használni return-t",
                "8. mennyi ága  lehet egy elágazásnak",
                "9. mit jelent a py",
                "10. lehet e fügvényt meghivni az öszes paraméter nélkül"
            };

            string[] answers =
            {
                "a","Hypertext Markup Language","végtelen","nem mert ez c#","0","lehet","tud","végtelen","python","lehet"
            };

            while (index < questions.Length)
            {
                if (index == 0) System.Console.WriteLine("Ez az harmadik kategória: Programozás\n");   
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("Rossz válasz, mész egy kategóriával viszább!");
                    progress.Level--;
                    SaveProgress(filePath, progress);
                    Console.ReadKey();
                    break;
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
                "1. hol kelett volna véget érnie a halálos irambannak\na) 5.rész\nb) 7.rész\nc) sose",
                "2. a fűrész 1 mikor jött ki?",
                "3. hány része van a sikolynak",
                "4. sikoly 6-ban  Tara-t ki játsza",
                "5. meik filmben halatszódott el az hogy bogie ember",
                "6. milyen folyóba fulladt bele először jason",
                "7. jason-nek miért nincs maszkja az 1.részben",
                "8. a fűrész 10-ben mi az indok arra hogy megölje az embereket jonh kramer",
                "9. a fűrészben amanda miért segíti kramer-t a gyilkolásokban",
                "10. jigsaw miért csinálja ezeket a 'förtelmes' dolgokat azokkal az emberekkel akiket odavisz a dungeonbe (filmbe ellet mondva)"
            };

            string[] answers =
            {
                "a","2004","6","Jenna Ortega","halloween","crystal lake","mert még nem találta meg","mert kramer-t becsapták azzal hogy a fejét meg műtik igy tuléli a halált","mert tulélte","az emberek olyan tetteket csináltak ami szembe megy az élettel"
            };

            while (index < questions.Length)
            {
                if (index == 0) System.Console.WriteLine("Ez az negyedik kategória: Filmek\n");
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("Rossz válasz, mész egy kategóriával viszább!");
                    progress.Level--;
                    SaveProgress(filePath, progress);
                    Console.ReadKey();
                    break;
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
                "1. Melyik karakter rendelkezik egy olyan passzív képességgel, amely lehetővé teszi számára, hogy minden szövetséges támadását megerősítse?",
                "2. Melyik karakter képes a saját életét áldozni, hogy folyamatosan mozgási sebességet és támadási sebességet kapjon?",
                "3. Melyik az egyetlen karakter, akinek az egyik képessége közvetlenül változtatja meg a támadásai típusát (fizikai sebzésről mágikusra vagy fordítva)?",
                "4. Melyik karakter képes a játékban egy rövid időre 'falon keresztül' látni anélkül, hogy igazi látómezőt biztosítana?",
                "5. Melyik az egyetlen karakter, aki képes átalakulni egy másik formába anélkül, hogy ulti képességet használna?",
                "6. Melyik karakter képes a saját életét áldozni, hogy folyamatosan mozgási sebességet és támadási sebességet kapjon?",
                "7. Melyik karakter rendelkezik egy olyan képességgel, amely lehetővé teszi számára, hogy egyetlen gombnyomással előrébb mozduljon egy rövid távolságot, és egyből támadjon is?",
                "8. Melyik az egyetlen karakter, akinek egy képessége egyszerre tudja meggyógyítani és sebezni az ellenfelet?",
                "9. karakter tud a saját képességei segítségével egy másik karakter képességeit is befolyásolni?",
                "10. Melyik karakter képes arra, hogy egy nagy területet robbanásveszélyes zónává változtasson, amely késleltetett sebzést okoz?"
            };

            string[] answers =
            {
                "milio","Briar","Zeri","Naafiri","K'Sante","Briar","Smolder","Renata Glasc","Viego","Bel'veth"
            };

            while (index < questions.Length)
            {
                if (index == 0) System.Console.WriteLine("Ez az ötödik kategória: League of Legends\n");
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("Rossz válasz, mész egy kategóriával viszább!");
                    progress.Level--;
                    SaveProgress(filePath, progress);
                    Console.ReadKey();
                    break;
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
                "1. Kik voltak a jakobinusok a francia forradalom idején?",
                "2. Milyen következményekkel járt a nagy földrajzi felfedezések kora?",
                "3. Mi volt a hidegháború?",
                "4. Hogyan változtatta meg az ipari forradalom a társadalmat?",
                "5. mettől meddig tartott az első világháboru",
                "6. az usa miért száltt be az első világháboruba 1917-ben",
                "7. mikor volt a normandiai partra szállás",
                "8. törökök meddig szálták meg az országunkat öszesen",
                "9. hitler menyi embert ölt meg",
                "10. mikor volt oroszországban polgárháboru"
            };

            string[] answers =
            {
                "republikánus politikai csoport","kereskedelmi hálózatokat hoztak","az USA és a Szovjetunió közötti  szembenállás","kézi munkáról  gépi termelés","1914-1918","A németek korlátlan tengeralattjáró-háborúja fenyegette az amerikai kereskedelmi érdekeket és állampolgárok életét.","1944","150év","17 millió","1917"
            };

            while (index < questions.Length)
            {
                if (index == 0) System.Console.WriteLine("Ez az hatodik kategória: Töri\n");
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("Rossz válasz, mész egy kategóriával viszább!");
                    progress.Level--;
                    SaveProgress(filePath, progress);
                    Console.ReadKey();
                    break;
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
                "1. Hogyan írjuk helyesen?\na) bérmálkozás\nb) bérmákozás\nc) bérmálás",
                "2. Hogyan írjuk helyesen?\na) ínyenc\nb) ínyensz\nc) ínyencz",
                "3. Hogyan írjuk helyesen?\na) szimpatikus\nb) szímpatikus\nc) szimpáttikus",
                "4. Hogyan írjuk helyesen?\na) egyhangúan\n b) egyhangúan\nc) egyhangúlyan",
                "5. Hogyan írjuk helyesen?\na) kettőzzük\n b) kettőzük\nc) kettőzzük meg",
                "6. Hogyan írjuk helyesen?\na) egyetérteni\n b) egyet érteni\nc) eggyetérteni",
                "7. Hogyan írjuk helyesen?\na) helyesírás\n b) helyes írás\nc) hejesírás",
                "8. Hogyan írjuk helyesen?\na) kegyenc\n b) kegyensz\nc) kegyens",
                "9. Hogyan írjuk helyesen?\na) szüntelen\n b) szüntetlen\nc) szüntetetlen",
                "10. Hogyan írjuk helyesen?\na) tulajdonképpen\n b) tulajdon képpen\nc) tulajdónképpen"
            };

            string[] answers =
            {
                "c","a","a","a","a","a","a","a","a","a"
            };

            while (index < questions.Length)
            {
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    if (index == 0) System.Console.WriteLine("Ez az hetedik kategória: Nyelvtan\n");
                    Console.WriteLine("Rossz válasz, mész egy kategóriával viszább!");
                    progress.Level--;
                    SaveProgress(filePath, progress);
                    Console.ReadKey();
                    break;
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
                "1. mi volt a politikája paul kottnak",
                //"2. kire szavazott tanár úr előző választásokkor",
                "3. mikor volt az előző fidesz 2/3 ad választásokkor",
                "4. kiegészítés Orbán viktor mondja hogy: any questions",
                "5. mi tortent a varoshazaval mikor magyar peti es az ismeretlen tidzasok bevonultak\na) felrobbant\nb) nagasaki\nc) kerdeztek Magyar Pétert, de nem valaszolt",
                "6. az m1 által milyen kampányt akartak a fideszesek felvenni a harcot magyar péter ellen",
                "7. fidesz politikája milyen szinten van",
                "8. miről szolt 2015-ben a hiradó folyamat",
                "9. ki amerika elnőke",
                "10. ki volt a Szovjetunió utolsó elnőke"
            };

            string[] answers =
            {
                "megölte a szeműveges embereket mert tul sokat tudtak",/*"",*/"2022","is there","c","hogy a pöcsére mondták hogy kicsi","óvóda","soros terv, migránció, brüsszel","Trump","Gorbacsov"
            };

            while (index < questions.Length)
            {
                if (index == 0) System.Console.WriteLine("Ez az nyolcadik kategória: Politika\n");
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("Rossz válasz, mész egy kategóriával viszább!");
                    progress.Level--;
                    SaveProgress(filePath, progress);
                    Console.ReadKey();
                    break;
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
                "1. Melyik NPC-t lehet megölni, hogy megszerezd a Dark Wood Grain Ring-et, amely lehetővé teszi a 'ninja flip' mozgást?\n(a) Shiva of the East\n(b) Lautrec of Carim\n(c) Alvina\n(d) Shiva testőre",
                "2. Melyik item szükséges ahhoz, hogy a Chaos Servant covenant rank 2-es szintjére lépj és kinyisd a shortcutot Izalith felé?\n(a) Sunlight Medal\n(b) Humanity\n(c) Demon Titanite\n(d) Chaos Flame Ember",
                "3. Melyik fegyver skálázódik a legjobban a 'Faith' stat-tal a Dark Souls 1-ben?\n(a) Sunlight Straight Sword\n(b) Greatsword of Artorias (Cursed)\n(c) Grant\n(d) Crescent Axe",
                "4. Milyen fontos tárgyat kapsz a Duke’s Archives-ban lévő börtönből való kijutáshoz?\n(a) Archive Prison Extra Key\n(b) Archive Tower Cell Key\n(c) Crystal Ember\n(d) Master Key",
                "5. Hogyan lehet megszerezni a Darkmoon Seance Ring-et, amely lehetővé teszi Gwyndolin elérését?\n(a) Anor Londo egyik titkos falán keresztül\n(b) The Catacombs egy ládájában\n(c) Duke’s Archives egy Crystal Golem-jéből\n(d) Vásárlás Patches-től",
                "6. Mi történik, ha Leonhard küldetéssorozatát végigviszed, és megölöd Rosaria-t?\n(a) Rosaria eltűnik, és nem tudsz többé Covenant rangokat növelni\n(b) Leonhard megjutalmaz egy különleges Darkwraith maszkot\n(c) Megkapod a Black Eye Orb-ot, amellyel invadelheted őt\n(d) Rosaria újraéled egy másik bonfire-nél",
                "7. Milyen feltételek mellett lehet megküzdeni Champion Gundyrrel az Untended Graves területén?\n(a) Meg kell találni és használni a Coiled Sword Fragment-et\n(b) Lothric Castle végigjátszása után automatikusan megnyílik az út\n(c) A Consumed King’s Garden egyik titkos falán keresztül\n(d) Firelink Shrine egyik illúziós falán keresztül lehet eljutni oda",
                "8. Melyik NPC árulja a Twinkling Titanite-ot Dark Souls 3-ban?\n(a) Patches\n(b) Shrine Handmaid (később, egy bizonyos Ash megadása után)\n(c) Orbeck of Vinheim\n(d) Hawkwood",
                "9. Milyen tárgyat ad Yuria of Londor, amely előkészíti a 'Usurpation of Fire' endinget?\n(a) Londor Talisman\n(b) Hollow’s Brand\n(c) Dark Sigil\n(d) Five Dark Sigils",
                "10. Mi a különleges képessége a Fume Ultra Greatsword-nek a többi ultra greatswordhöz képest?\n(a) Támadás közben magasabb poise-t biztosít\n(b) Kétkezes erős támadása hatalmas páncéltörő sebzést ad\n(c) Képes elnyelni az ellenfél FP-jét\n(d) Képes Fire és Dark sebzést is osztani"
            };

            string[] answers =
            {
                "d","b","c","b","b","c","c","b","d","a"
            };

            while (index < questions.Length)
            {
                if (index == 0) System.Console.WriteLine("Ez az kilencedik kategória: Dark Souls 1 és 3\n");
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("Rossz válasz, mész egy kategóriával viszább!");
                    progress.Level--;
                    SaveProgress(filePath, progress);
                    Console.ReadKey();
                    break;
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
                "1. Mi az a C# magyarul?\na) Fisz\nb) Cisz\nc) C",
                "2. Mi az a D egy b-vel magyarul?\na) Disz\nb) Dosz\nc) Desz",
                "3. Mi az a H egy b-vel magyarul\na) Hesz\nb) Bé\nc) nem tudom",
                "4. Cisz és a Desz az ugyanaz?\na) igen\nb) nem\nc) attól függ",
                "5. Mitől függ?\na) Hangszertől\nb) zenésztől\nc) Tanár úrtól",
                "6. Melyik csoportmunkában volt az első zenés feladat?\na) a harmadikban\nb) az utolsó utánniban\nc) az elsőben",
                "7. Az oktáv hány hangot fog le összesen a zongorán (nem csak egész)?\na) 13\nb) 8\nc) 1",
                "8. SzZA eddig hány szóló csellóversenyen vett részt?\na) 0\nb) 4\nc) 10",
                "9. Ki írta a Für Elise-t?\na) Liszt Ferenc\nb) Beethoven\nc) Haydn",
                "10. Összesen hány hangszert birtokol a csoport?\na) legalább 16\nb) legalább 420\nc) legalább 13"
            };

            string[] answers =
            {
                "b","c","b","c","a","c","a","a","b","c"
            };

            while (index < questions.Length)
            {
                if (index == 1) System.Console.WriteLine("Amúgy ez a tizedik kategória: Zene\n");
                Console.WriteLine(questions[index]);
                string userAnswer = Console.ReadLine().Trim();
                if (userAnswer == answers[index])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("Rossz válasz, mész egy kategóriával viszább!");
                    progress.Level--;
                    SaveProgress(filePath, progress);
                    Console.ReadKey();
                    break;
                }
            }

            Console.WriteLine("Gratulálok! Sikeresen megválaszoltad az összes kérdést.");
            progress.Level++;
            SaveProgress(filePath, progress);
            }
            else if (progress.Level == 11)
            {
                System.Console.WriteLine("Gratulálok, sikeresen végigjátszottad ezt a 'játékot', remélem annyira élvezted mint mi.");
                Console.ReadLine();
                break;
            }
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
        return new UserProgress();
    }
}

class UserProgress
{
    public int Level { get; set; } = 1;
}
