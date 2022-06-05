using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary;

namespace Exercise6_Hangman
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instantiating Classes////////////////////////////////////////////
            Console.ForegroundColor = ConsoleColor.White;
            WordsRepository word = new WordsRepository();
            HangShap hang = new HangShap();
            HumanBody humanBody = new HumanBody();
            GuessWord finalGuess = new GuessWord();

            //Choosing defficulty level////////////////////////////////////////
            Console.Write("Choose defficulty level of game(Easy:E - Hard:H): ");
            char Diffculty = Convert.ToChar(Console.ReadLine().ToLower());

            string result = "";
            while (true)
            {
                if (Diffculty == 'e')
                {
                    result = word.EasyWords();
                    break;
                }
                else if (Diffculty == 'h')
                {
                    result = word.HardWords();
                    break;
                }
                else
                {
                    Console.Write("Easy:E or Hard:H??? ");
                    Diffculty = Convert.ToChar(Console.ReadLine().ToLower());
                    continue;
                }
            }
            Console.Clear();
            //Questions Strat////////////////////////////////////////////
            hang.Hang();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Now you should guess only 6 letters!!!");
            char letter = ' ';
            char[] letArray = new char[6];
            for (int i = 1; i <= 6; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Letter number {i}: ");
                letter = Convert.ToChar(Console.ReadLine().ToLower());
                if (result.Contains(letter))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("   True");
                    letArray[i - 1] = letter;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("   False");
                    humanBody.Body(i);
                }
            }

            //Last chance to guess word//////////////////////////////////
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Ok, The word has {result.Length} letters, write it down:");
            finalGuess.guessWord(result, letArray);
            string finalWord = Console.ReadLine().ToLower();
            if (finalWord == result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                  Congratulation");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                  GAMEOVER!!!!!!!!!");
                humanBody.DeadBody();
                Console.WriteLine($"                  The answer is: {result}");
            }
            Console.ReadKey();
        } 
    }
}
