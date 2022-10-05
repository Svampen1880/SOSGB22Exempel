namespace Arrayer

{
    internal class Pogram

    {
        static void Main(string[] args)

        {
            int intPick = 1;

            //Initerar en string array
            string[] strColors = { "Red", "Green", "Blue", "Yellow" };

            Console.WriteLine(strColors[3]);

            Console.WriteLine(strColors[intPick + 1]);

            strColors[2] += "Purple";

            Console.WriteLine(strColors[2]);

            //Initiera en Int array med bestämd stolek, dock utan element
            int[] intScore = new int[5];

            //skapar ett objekt av klassen random
            //förkortning av random = rand eller rnd
            Random random = new Random();
            random.Next();

            Console.WriteLine(intScore[0]);

            //Insert värden till array
            intScore[0] = 1;
            intScore[1] = 3;
            intScore[2] = intScore[0] + intScore[1];
            //Det finns två inbyggda klasser i c#, random och mattematik, random som används för att få slumpmässig generator, men mattemaik är en statisk klass så
            //man behöver inte skapa ett obejkt av den klassen. Men inom random så behöver man göra det eftersom det är inte en statisk klass 
            intScore[3] = intPick;
            intScore[4] = random.Next(10) + 1;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                intScore[0], intScore[1], intScore[2], intScore[3], intScore[4]);

            //Sortera array i nummerordning 
            Array.Sort(intScore);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                intScore[0], intScore[1], intScore[2], intScore[3], intScore[4]);

            //Längd samt högsta och minsta värde av Int array

            Console.WriteLine(intScore.Length); 
            Console.WriteLine(intScore.Max());
            Console.WriteLine(intScore.Min());
            Console.WriteLine(intScore.Sum());

            //Först och sista order i bokstavsordningen av String array
            //Min är först i bokstavordningen

            Console.WriteLine(strColors.Min());
            Console.WriteLine(strColors.Max());

            string[] strNames = { "Emelia", "Alva", "Nicki", "Sam Smith" };
        }
    }
}

