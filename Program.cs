using System.Runtime.InteropServices;

public class Opgaver
{

    public static void Main()
    {
        Opgave_07_Mainmenu();
    }


    /* Opgave 1:
     * Program: Returnering af en streng
     * Lav et program, der kalder en metode, som returnerer en streng. Denne streng skal
     * indeholde teksten "Hello World!". Metoden skal kaldes fra Main-metoden og bruges som
     * input til en Console.WriteLine(), så beskeden udskrives i konsollen.
     */
    static void Opgave_01()
    {
        Console.Clear();
        Console.WriteLine(Opgave_01_Hjælpemetode());
        Console.ReadKey();
    }

    static string Opgave_01_Hjælpemetode()
    {
        return "Hello World!";
    }

    /* Opgave 2:
     *  Program: Udskrivning af brugerinput
     *  Lav et program, hvor brugeren kan indtaste en tekststreng som input. Derefter skal du
     *  oprette en metode, der modtager denne streng som parameter og udskriver den i
     *  konsollen. Metoden skal kaldes fra Main-metoden.
     */
    static void Opgave_02()
    {
        Console.Clear();
        Console.Write("Skriv noget: ");
        Opgave_02_Hjælpemetode(Console.ReadLine()!);

        Console.ReadKey();
    }

    static void Opgave_02_Hjælpemetode(string input)
    {
        Console.WriteLine(input);
    }
    /* Opgave 3:
     * Program: Summen af tre tal
     * Lav et program, hvor brugeren kan indtaste tre tal. Opret en metode, der tager imod de tre
     * tal som parametre, lægger dem sammen, og returnerer summen. Summen skal derefter
     * udskrives i konsollen via Console.WriteLine().
     */
    static void Opgave_03()
    {
        //Renser skærmen
        Console.Clear();

        double a, b, c;
        //Brugerinstruktion
        Console.WriteLine("Sum af tre tal.");
        Console.Write("1. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }
        Console.Write("2. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }
        Console.Write("3. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }

        //Udskriv summen.
        Console.WriteLine($"Summen er lig {Opgave_03_Sum(a, b, c)}");

        Console.ReadKey(); //Afvent tast for at afslutte. 

    }

    static double Opgave_03_Sum(double a, double b, double c)
    {
        return a + b + c;
    }

    /* Opgave 3a:
     * Program: Subtraktion af tre tal
     * Dette program skal være en udvidelse af Opgave 3. I stedet for at lægge de tre tal
     * sammen, skal metoden trække de tre tal fra hinanden og returnere resultatet, som derefter
     * skal udskrives i konsollen.
     */
    static void Opgave_03a()
    {
        //Renser skærmen
        Console.Clear();

        double a, b, c;
        //Brugerinstruktion
        Console.WriteLine("Subtraktion af tre tal.");
        Console.Write("1. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }
        Console.Write("2. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }
        Console.Write("3. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }

        //Udskriv summen.
        Console.WriteLine($"{a}-{b}-{c} er lig {Opgave_03_Subtraktion(a, b, c)}");

        Console.ReadKey(); //Afvent tast for at afslutte. 

    }

    static double Opgave_03_Subtraktion(double a, double b, double c)
    {
        return a - b - c;
    }

    /* Opgave 3b:
     * Program: Multiplikation af tre tal
     * Udvid Opgave 3 ved at oprette en metode, der modtager tre tal som input, ganger dem
     * sammen, og returnerer resultatet. Resultatet skal derefter udskrives i konsollen.
     */
    static void Opgave_03b()
    {
        //Renser skærmen
        Console.Clear();

        double a, b, c;
        //Brugerinstruktion
        Console.WriteLine("Multiplikation af tre tal.");
        Console.Write("1. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }
        Console.Write("2. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }
        Console.Write("3. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }

        //Udskriv summen.
        Console.WriteLine($"Produktet er lig {Opgave_03_Multiplikation(a, b, c)}");

        Console.ReadKey(); //Afvent tast for at afslutte. 
    }

    static double Opgave_03_Multiplikation(double a, double b, double c)
    {
        return a * b * c;
    }

    /* Opgave 3c:
     * Program: Summen af to tal divideret med et tredje
     * Lav et program, der modtager tre tal som input fra brugeren. Opret en metode, der lægger
     * de to første tal sammen og derefter dividerer summen med det tredje tal. Resultatet skal
     * returneres og udskrives i konsollen.
     */
    static void Opgave_03c()
    {
        //Renser skærmen
        Console.Clear();

        double a, b, c;
        //Brugerinstruktion
        Console.WriteLine("Summen af to tal divideret med et tredje.");
        Console.Write("1. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }
        Console.Write("2. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }
        Console.Write("3. tal: ");
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }

        //Udskriv summen.
        Console.WriteLine($"({a}+{b})/{c} = {Opgave_03_SumOgDivision(a, b, c)}");

        Console.ReadKey(); //Afvent tast for at afslutte. 
    }

    static double Opgave_03_SumOgDivision(double a, double b, double c)
    {
        return (a + b) / c;
    }

    /* Opgave 4:
     * Program: Navn og alder med gruppeinddeling
     * Lav et program, hvor brugeren kan indtaste et navn og en alder. Opret en metode, der
     * modtager disse input, og tjekker alderen for at bestemme, hvilken gruppe brugeren
     * tilhører, baseret på følgende aldersintervaller:
     * • 0-1 år: Du er nyfødt
     * • 2-3 år: Du er i dagpleje eller vuggestue
     * • 4-5 år: Du er i børnehave
     * • 6-18 år: Du går i skole
     * • 19 år og opefter: Nu begynder livet at blive alvor
     * Metoden skal returnere en streng, som kombinerer navnet og en passende besked
     * baseret på aldersgruppen, og denne besked skal derefter udskrives i konsollen.
     */
    static void Opgave_04()
    {
        Console.Clear(); //Renser skærmen

        Console.Write("Skriv dit navn: "); //Brugerinstruktion
        string navn = Console.ReadLine()!; //Læsning af brugerens navn

        double alder;
        Console.Write("Skriv din alder: ");//Brugerinstruktion
        //Læsning af input og test af input. 
        while (!double.TryParse(Console.ReadLine(), out alder))
        {
            Console.WriteLine("Fejl: Du skal skrive et tal.");
        }
        Console.WriteLine(Opgave_04_Hjælpemetode(navn, alder));


        Console.ReadKey(); //Afvent tast for at afslutte. 
    }

    static string Opgave_04_Hjælpemetode(string navn, double alder)
    {
        switch (alder)
        {
            case >= 0.0 and < 2.0:
                return $"{navn} er nyfødt.";
            case >= 2.0 and < 4.0:
                return $"{navn} er i dagpleje eller vuggestue.";
            case >= 4.0 and < 6.0:
                return $"{navn} er i børnehave.";
            case >= 6.0 and < 19.0:
                return $"{navn} går i skole.";
            case >= 19.0:
                return $"{navn} er alvorlig voksen.";
            default:
                return "(fejl: Ugyldig alder)";
        }
    }

    /* Opgave 5:
     * Program: Opdeling af komma-separeret streng
     * Lav et program, hvor brugeren indtaster en enkelt streng med værdier adskilt af kommaer.
     * Opret en metode, der modtager denne streng, splitter den op i et array af værdier, og
     * returnerer arrayet. I Main-metoden skal du udskrive størrelsen på arrayet og bruge en for-
     * løkke til at udskrive hver værdi i arrayet.
     */
    static void Opgave_05()
    {
        Console.Clear(); //Renser skærmen
        Console.WriteLine("Skrive en mængde ting separeret med KOMMA (,)");
        string input = Console.ReadLine()!;

        string[] output = Opgave_05_hjælpemetode(input);

        Console.WriteLine($"Dit input havde {output.Length} genstande:");
        foreach (string genstand in output)
        {
            Console.WriteLine(genstand);
        }
        Console.ReadKey();
    }
    static string[] Opgave_05_hjælpemetode(string input)
    {
        return input.Split(',');
    }

    /* Opgave 6:
     * Program: Gæt et tal-spil
     * Lav et program, der simulerer et klassisk "gæt et tal"-spil. Programmet skal generere et
     * tilfældigt tal mellem 1 og 25. Brugeren skal have op til 5 forsøg på at gætte tallet. Opret
     * flere metoder til spillet:
     * • En metode til at generere det tilfældige tal.
     * • En metode til at tjekke, om brugerens gæt er korrekt.
     * • En metode, der informerer brugeren, om gættet er for højt eller for lavt.
     * Hvis brugeren gætter rigtigt, skal spillet afsluttes med en besked, der fortæller, at de har
     * vundet. Hvis de løber tør for forsøg, skal spillet afslutte med en taberbesked.
     */
    static void Opgave_06()
    {
        //Rens skærmen
        Console.Clear();
        //Generering af det hemmeligt tal. 
        int hemmeligt = Opgave_06_random();
        //Variabel til at tælle forsøg
        int forsøg = 0;
        //Variabel til gæt
        int gæt = 0;
        //Instruktion til bruger. 
        Console.WriteLine("Gæt et tal mellem 1 og 25");
        while (true)
        {
            while (!int.TryParse(Console.ReadLine(), out gæt) || gæt < 1 || gæt > 25)
            {
                Console.WriteLine("Du skal skrive et heltal mellem 1 og 25");
            }
            //Inkrementer forsøg tæller;
            forsøg++;
            //Hvis gæt er korrekt har brugeren vundet.
            if (Opgave_06_korrekt(gæt, hemmeligt))
            {
                //Lykønskningsbesked
                Console.WriteLine($"Tillykke du gættede rigtigt i {forsøg} forsøg!");
                //Afvent tastetryk for at afslutte
                Console.ReadKey();
                //Afslut
                return;
            }
            else
            {
                Opgave_06_besked(gæt, hemmeligt);
            }
        }
    }

    //Metode til generering af et tilfældigt tal mellem 1 og 25
    static int Opgave_06_random()
    {
        Random rnd = new Random();
        return (rnd.Next() % 25) + 1;
    }

    //Metode til at tjekke om gættet er korrekt. 
    static bool Opgave_06_korrekt(int gæt, int hemmeligt)
    {
        if (gæt == hemmeligt) return true;
        else return false;
    }

    //Metode til at fortælle spilleren om gættet er for højt eller lavt. 
    static void Opgave_06_besked(int gæt, int hemmeligt)
    {
        if (gæt > hemmeligt) Console.WriteLine("Dit gæt er for højt. Prøv igen.");
        if (gæt < hemmeligt) Console.WriteLine("Dit gæt er for lavt. Prøv igen.");
    }

    /* Opgave 7.
     * Du skal lave en hovedmenu i et C#-konsolprogram, hvor brugeren kan navigere mellem
     * flere forskellige opgaver. Menuen skal give brugeren mulighed for at vælge en opgave,
     * køre den, og derefter give mulighed for at vende tilbage til hovedmenuen eller afslutte
     * programmet. Hovedmenuen skal være dynamisk og kunne tilføje flere opgaver, hvis
     * nødvendigt.
     */
    static void Opgave_07_Mainmenu()
    {
        //Løkke til hovedmenuen
        while (true)
        {
            //Udskriver hovedmenuen. 
            Console.Clear();
            Console.WriteLine("Grundlæggende Programmering H1.\tTEC.\tJanuar 2025.\tAsger Ømann.");
            Console.WriteLine();
            Console.WriteLine("Opgaver med metoder");
            Console.WriteLine();
            Console.WriteLine("Tryk på en tast for at vælge kategori: ");
            Console.WriteLine("A) Opgave 1: Program: Returnering af en streng");
            Console.WriteLine("B) Opgave 2: Program: Udskrivning af brugerinput");
            Console.WriteLine("C) Opgave 3: Program: Summen af tre tal");
            Console.WriteLine("D) Opgave 3a: Program: Subtraktion af tre tal");
            Console.WriteLine("E) Opgave 3b: Program: Multiplikation af tre tal");
            Console.WriteLine("F) Opgave 3c: Program: Summen af to tal divideret med et tredje");
            Console.WriteLine("G) Opgave 4: Program: Navn og alder med gruppeinddeling");
            Console.WriteLine("H) Opgave 5: Program: Opdeling af komma-separeret streng");
            Console.WriteLine("I) Opgave 6: Program: Gæt et tal-spil");
            Console.WriteLine("J) Opgave 7a: Temperaturskalaomregner");
            Console.WriteLine("K) Opgave 7b: Decimal, hexadecimal og binær omregner");
            Console.WriteLine("L) Opgave 7c: To variabler");
            Console.WriteLine("M) Hangman-opgave");
            Console.WriteLine();
            Console.WriteLine("0) Tast 0 for at afslutte");

            switch (char.ToUpper(Console.ReadKey(true).KeyChar))
            {
                case 'A':
                    Opgave_01();
                    break;
                case 'B':
                    Opgave_02();
                    break;
                case 'C':
                    Opgave_03();
                    break;
                case 'D':
                    Opgave_03a();
                    break;
                case 'E':
                    Opgave_03b();
                    break;
                case 'F':
                    Opgave_03c();
                    break;
                case 'G':
                    Opgave_04();
                    break;
                case 'H':
                    Opgave_05();
                    break;
                case 'I':
                    Opgave_06();
                    break;
                case 'J':
                    Opgave_07a();
                    break;
                case 'K':
                    Opgave_07b();
                    break;
                case 'L':
                    Opgave_07c();
                    break;
                case 'M':
                    Hangman();
                    break;
                case '0':
                    Opgave_07_afslut();
                    break;
                default:
                    continue;
            }

            //"Efter hver opgaveløsning skal brugeren kunne vælge, om de vil tilbage til
            //hovedmenuen eller afslutte programmet.
            //Hvis brugeren ønsker at afslutte, skal programmet lukke ordentligt."
            Console.Clear(); //renser skærmen
            //Forespørgsel til brugeren.
            Console.WriteLine("Tryk på Q for at afslutte. Tryk på en anden tast for at vende tilbage til hovedmenuen");
            //Afslut hvis der tastes Q
            if (char.ToUpper(Console.ReadKey(true).KeyChar) == 'Q')
            {
                Opgave_07_afslut();
            }
        }
    }

    //"Implementer en metode til at afslutte programmet, når brugeren vælger at afslutte."
    static void Opgave_07_afslut()
    {
        Environment.Exit(0);
    }

    /* Opgave 7a.
     * I denne opgave skal du lave et program, der kan kaldes fra jeres hovedmenu (som er
     * oprettet i Opgave 7). Programmet skal kunne omregne temperaturer mellem fire forskellige
     * temperaturtyper: Celsius, Fahrenheit, Kelvin og Réaumur. Brugeren skal kunne indtaste
     * en temperatur, der enten er i Celsius eller Fahrenheit, og herefter vælge, hvilken
     * temperaturtype de har indtastet. Programmet skal derefter konvertere den indtastede
     * temperatur til de andre tre typer og præsentere resultaterne på skærmen.
     */
    static void Opgave_07a()
    {
        //Brugerinstruktion
        Console.WriteLine("Skriv en temperaturværdi i Fahrenheit eller Celcius (kun tallet)");
        //Læs bruger input
        double input;
        while (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Du skal skrive et tal.");
        }

        //Input af temperatur skala.  
        char input_skala;
        Console.WriteLine("Hvilken skala er temperaturværdien i? Tast C for Celsius og F for Fahrenheit");
        while (true)
        {
            input_skala = char.ToUpper(Console.ReadKey(true).KeyChar);
            //Tjek om en gyldig skala er valgt, ellers ignorer tastetryk.
            if (input_skala == 'C' || input_skala == 'F') break;
        }

        //Variabler til skalaer
        double celcius = 0, fahrenheit = 0, kelvin = 0, réaumur = 0;

        //Beregn temperaturskalaer
        switch (input_skala)
        {
            case 'C':
                celcius = input;
                fahrenheit = (celcius * (9 / 5)) + 32;
                kelvin = celcius + 273.15;
                réaumur = celcius * (4 / 5);
                break;
            case 'F':
                fahrenheit = input;
                celcius = (fahrenheit - 32) * (5 / 9);
                kelvin = (fahrenheit - 32) * (5 / 9) + 273.15;
                réaumur = (fahrenheit - 32) * (4 / 9);
                break;
        }

        Console.WriteLine("Den indtastede temperatur svarer til følgende:");
        Console.WriteLine($"Celcius:\t{celcius:N2}");
        Console.WriteLine($"Fahrenheit:\t{fahrenheit:N2}");
        Console.WriteLine($"Kelvin:\t{kelvin:N2}");
        Console.WriteLine($"Réaumur:\t{réaumur}");

    }

    /* Opgave 7b.
     * I denne opgave skal du oprette et program, der kan omregne et tal, som brugeren
     * indtaster, til tre forskellige repræsentationer: decimal, hexadecimal og binær. Hver
     * omregning skal udføres i separate metoder, der modtager tallet og returnerer resultatet.
     * Programmet skal kunne kaldes fra hovedmenuen, som blev lavet i Opgave 7.
     */
    static void Opgave_07b()
    {
        Console.Clear();
        Console.WriteLine("Skriv et decimaltal der skal konverteres til binær og hexadecimal");
        int tal;
        while (!int.TryParse(Console.ReadLine(), out tal)) Console.WriteLine("Fejl: Du skal skrive et heltal");
        Console.WriteLine("Det indskrevne tal er følgende i de forskellige talformater");
        Console.WriteLine($"Decimal:\t{tal}");
        Console.WriteLine($"Hexadecimal:\t0x{Opgave_07b_hexadecimal(tal)}");
        Console.WriteLine($"Binær:\t\t0b{Opgave_07b_binær(tal)}");

        Console.ReadKey();

    }

    static string Opgave_07b_hexadecimal(int tal)
    {
        return $"{tal:X}";
    }

    static string Opgave_07b_binær(int tal)
    {
        return $"{tal:B}";
    }

    /* Opgave 7c.
     * I denne opgave skal du oprette et program, der håndterer flere forskellige brugerinput af
     * mindst to forskellige datatyper. Programmet skal gøre brug af mindst én løkke (for
     * eksempel en for, while eller do-while løkke) og en kontrolstruktur som f.eks. en if-else for
     * at træffe beslutninger baseret på input. Resultatet af beregningerne eller operationerne
     * skal returneres og udskrives i konsollen. Programmet skal kunne kaldes fra den
     * hovedmenu, der blev lavet i Opgave 7.
     */
    static void Opgave_07c()
    {
        Console.Clear();
        Console.WriteLine("Skriv en sætning");
        string sætning = Console.ReadLine()!;
        Console.WriteLine("Skriv et tal");
        int tal;
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out tal))
            {
                Console.WriteLine("Fejl: Du skal skrive et tal!");
            }
            else
            {
                Console.Write($"Den skrevne sætning gentaget {tal} gange: ");
                for (int i = 0; i < tal; i++)
                {
                    Console.Write(sætning);

                }
                Console.ReadKey();
                break;
            }
        }
    }

    static void Hangman()
    {
        //Declaring variables
        string secretword, shownword;
        int lives, wordlength;
        List<char> guessed_chars;

        //SETUP:
        guessed_chars = [];
        Console.Clear();
        Console.WriteLine("Game master. How many lives should players have?");
        while (!int.TryParse(Console.ReadLine(), out lives))
        {
            Console.WriteLine("Error: Lives must be a whole number");
        }
        while (true)
        {
            Console.Write("Game master. Choose a word for the players to guess: ");
            secretword = Console.ReadLine()!;
            secretword = secretword.Trim().ToUpper();//Remove whitespace.
            if (secretword.Contains(' '))
            {
                Console.WriteLine("Error: The secret work must be a single word!");
                continue;//Try again;
            }
            wordlength = secretword.Length;
            //Create shown word
            shownword = "";
            for (int i = 0; i < wordlength; i++)
            {
                shownword = shownword + "_";
            }
            break;
        }
        Console.Clear();
        Console.WriteLine("Word picked. press a key to start the game.");

        //Maingame loop
        //Start-turn
        while (lives > 0)
        {
            Console.Clear();
            Console.Write($"Lives:{lives}\tWordlength:{wordlength}\tGuessed letters: ");
            foreach (char c in guessed_chars)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine($"\tWord: {shownword}\n");
            Console.Write("Guess a word or letter: ");
            string guess = Console.ReadLine()!.Trim().ToUpper();

            //Letter or word?
            if (guess.Length == 1)
            {
                //Player guesses a character
                char guess_char = guess[0];
                if (guessed_chars.Contains(guess_char)) continue; //Ignore if already guessed. 
                guessed_chars.Add(guess_char);
                //Is letter in word? 
                if (secretword.Contains(guess_char))
                {
                    //Reveal guessed letters
                    for (int i = 0; i < wordlength; i++)
                    {
                        if (secretword[i] == guess_char)
                        {
                            //Looks very inefficient but strings are "readonly" in C# 
                            //so convert them to arrays. Manipulate the array convert back. 
                            char[] shownword_arr = shownword.ToArray();
                            shownword_arr[i] = guess_char;
                            // shownword = shownword_arr.ToString()!; //Didn't work
                            shownword = "";
                            for (int j = 0; j < wordlength; j++){
                               shownword = shownword + shownword_arr[j];
                            }
                        }
                    }
                    //Check if all letters guessed.
                    if (!shownword.Contains('_'))
                    {
                        Console.WriteLine();
                        Console.Write($"\tCongratulations you guessed all the letters in \"{shownword}\"");
                        //Await keypress.
                        Console.ReadKey();
                        //Exit
                        return;
                    }
                }
                else
                {
                    //Letter not in word take a life
                    lives--;
                }

            }
            else
            {
                //If player guesses a word.
                if (guess == secretword)
                {
                    //Player guesses correctly
                    Console.WriteLine();
                    Console.Write($"\tCongratulations you correctly guessed \"{secretword}\"");
                    //Await keypress.
                    Console.ReadKey();
                    //Exit
                    return;
                }
                else
                {
                    lives--;
                }

            }
        }
        //If used up all lives. 

    }

}