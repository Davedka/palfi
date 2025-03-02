Ezt a programot egy projektre készítettük el ami egy csapatos projekt Pálfi Máté tanárúrnak.
A programhoz c#-ot használtunk legfőkképen viszont txt-formátumban leirva minden kérdések stb.
A program arra készült hogy Pálfi Máté tanárúr-at kiidegeljük a nagyon ritkás és fellegzetes kérdéssekkel.
A program tartalmaz 11 kategóriát abba mind van 10 kérdés tehát összesen 110 kérdés van feltéve a felhasználónak.
A kérdések nagy része tükrözi az egész Szoftverfejlesztő csoportunkat igy megpróbáltunk mindent kategóriát egy személy-re mintázni.
A program ötlete 2025 feb 20-28ig született meg kigondolva a kérdéseket illetve hogyan kellene lefejleszteni.
Először is Kiss Dávid csinált egyb txt-t amibe felirta a kérdéseket majd ezeket felrakta egy közös githubra majd ezek a kérdések át lettek konvertálva a kategoriákra amit szintén itt találsz, ezeket a kategóriákat tegnap azaz márc 1.-jén hoztuk létre sacper kb 2 és fél óra alatt az összes kérdéssel persze hogy felgyorsítsuk a developmentet használtunk chatgpt-t a kérdésekhez.
A program ugy működik hogy egy json file-ba tároljuk el a kérdéseket és válaszokat tömb-ként mivel nehezen lehetett volna megoldani vagyis inkább nem volt felhasználó barát az hogy a tanár úr ija be az utat ahova letöltötte a programot ezért a json-nel megoldottuk hogy akárhova tölti a programot ugyis lefog futni.


  
 





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


        static void SaveProgress(string filePath, UserProgress progress)
    {
        string json = JsonConvert.SerializeObject(progress, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
    ezek alkottják a program működését
    ez az eljárás csinálja meg hogy lementse az állást minden kategória után van mentés nem minden kérdés után



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
