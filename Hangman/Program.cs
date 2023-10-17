﻿namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const string WinScreen = @"
                ┌───────────────────────────┐
                │                           │
                │ WW       WW  **  NN   N   │
                │ WW       WW  ii  NNN  N   │
                │  WW  WW WW   ii  N NN N   │
                │   WWWWWWW    ii  N  NNN   │
                │    WW  W     ii  N   NN   │
                │                           │
                │         Good job!         │
                │   You guessed the word!   │
                └───────────────────────────┘
                ";
            const string LoseScreen = @"
                ┌────────────────────────────────────┐
                │  LLL          OOOO    SSSS   SSSS  │
                │  LLL         OO  OO  SS  SS SS  SS │
                │  LLL        OO    OO SS     SS     │
                │  LLL        OO    OO  SSSS   SSSS  │
                │  LLL        OO    OO     SS     SS │
                │  LLLLLLLLLL  OO  OO  SS  SS SS  SS │
                │   LLLLLLLLL   OOOO    SSSS   SSSS  │
                │                                    |
                │        You were so close.          │
                │ Next time you will guess the word! │
                └────────────────────────────────────┘
                ";
            string[] WrongGussedFrames =
                {
                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"          ║   " + '\n' +
                @"          ║   " + '\n' +
                @"     ███  ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"          ║   " + '\n' +
                @"     ███  ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"     ███  ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      |\  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"     ███  ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"     /|\  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"     ███  ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"     /|\  ║   " + '\n' +
                @"       \  ║   " + '\n' +
                @"     ███  ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"     /|\  ║   " + '\n' +
                @"     / \  ║   " + '\n' +
                @"     ███  ║   " + '\n' +
                @"    ══════╩═══"
                };
            string[] DeathAnimationFrames = {
                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"     /|\  ║   " + '\n' +
                @"     / \  ║   " + '\n' +
                @"     ███  ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"     /|\  ║   " + '\n' +
                @"     / \  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      o>  ║   " + '\n' +
                @"     /|   ║   " + '\n' +
                @"      >\  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"     /|\  ║   " + '\n' +
                @"     / \  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"     <o   ║   " + '\n' +
                @"      |\  ║   " + '\n' +
                @"     /<   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"     /|\  ║   " + '\n' +
                @"     / \  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      o>  ║   " + '\n' +
                @"     /|   ║   " + '\n' +
                @"      >\  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      o>  ║   " + '\n' +
                @"     /|   ║   " + '\n' +
                @"      >\  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"     /|\  ║   " + '\n' +
                @"     / \  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"     <o   ║   " + '\n' +
                @"      |\  ║   " + '\n' +
                @"     /<   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"     <o   ║   " + '\n' +
                @"      |\  ║   " + '\n' +
                @"     /<   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"     <o   ║   " + '\n' +
                @"      |\  ║   " + '\n' +
                @"     /<   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"     /|\  ║   " + '\n' +
                @"     / \  ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      o   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      o   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      o   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      o   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      o   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      o   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      |   ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      /   ║   " + '\n' +
                @"      \   ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    |__   ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      .   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    \__   ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @"   ____   ║   " + '\n' +
                @"    ══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @"      .   ║   " + '\n' +
                @"    __    ║   " + '\n' +
                @"   /══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      .   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"    _ '   ║   " + '\n' +
                @"  _/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @"      _   ║   " + '\n' +
                @" __/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @"      .   ║   " + '\n' +
                @"          ║   " + '\n' +
                @" __/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      .   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @" __/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @"      _   ║   " + '\n' +
                @" __/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @"      .   ║   " + '\n' +
                @"          ║   " + '\n' +
                @" __/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"      .   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @" __/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @"      _   ║   " + '\n' +
                @" __/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      .   ║   " + '\n' +
                @"          ║   " + '\n' +
                @" __/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      '   ║   " + '\n' +
                @" __/══════╩═══",

                @"      ╔═══╗   " + '\n' +
                @"      |   ║   " + '\n' +
                @"      O   ║   " + '\n' +
                @"          ║   " + '\n' +
                @"          ║   " + '\n' +
                @"      _   ║   " + '\n' +
                @" __/══════╩═══"
            };
            string[] words = ReadWordsFromFile();
            const char Underscore = ' ';
            Console.CursorVisible = false;
            while (true)
            {
                string word = GetRandomWord(words);
                string wordToGuess = new(Underscore, word.Length);
                int incorrectGuessCount = 0;
                List<char> playerUsedLetters = new List<char>();
                DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);
                Console.ReadLine();

                //PlayGame(word, wordToGuess, incorrectGuessCount, playerUsedLetters);

                //Console.WriteLine("If you want to play again, press [Enter]. Else, type ‘quit’: ");
                //string PlayerInput = Console.ReadLine();
                //if (PlayerInput == "quit")
                //{
                //    Console.Clear();
                //    Console.WriteLine("Thank you for playing! Hangman was closed");
                //    break;
                //}
                //Console.Clear();

            }

            static string GetRandomWord(string[] words)
            {
                Random random = new Random();
                string word = words[random.Next(words.Length)];
                return word.ToLower();
            }


            void DrawCurrentGameState(bool inputIsInvalid, int incorrectGuess, string guessedWord, List<char> playerUsedLetters)
            {
                Console.Clear();
                Console.WriteLine(WrongGussedFrames[incorrectGuess]);
                Console.WriteLine($"Guess: {guessedWord}");
                Console.WriteLine($"You have to guess {guessedWord.Length} symbols.");
                Console.WriteLine($"The following letters are used: {String.Join(", ", playerUsedLetters)}");
                if (inputIsInvalid)
                {
                    Console.WriteLine("You should type only a single character!");
                }
                Console.Write("Your symbol: ");
            }
            void PlayGame(string word, string wordToGuess, int incorrectGuessCount, List<char> playerUsedLetters)
            {
                while (true)
                {
                    string playerInput = Console.ReadLine().ToLower();
                    if (playerInput.Length != 1)
                    {
                        DrawCurrentGameState(true, incorrectGuessCount, wordToGuess, playerUsedLetters);
                        continue;

                    }
                    char playerLetter = char.Parse(playerInput);
                    playerUsedLetters.Add(playerLetter);
                    bool playerLetterIsContained = CheckIfSymbolIsContained(word, playerLetter);
                    if (playerLetterIsContained)
                    {
                        wordToGuess = AddLetterToGuessWord(word, playerLetter, wordToGuess);
                    }
                    else
                    {
                        incorrectGuessCount++;
                    }
                    DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);
                    bool playerwins = CheckIfPlayerWins(wordToGuess);
                    if (playerwins)

                    {
                        Console.Clear();
                        Console.WriteLine(WinScreen);
                        Console.WriteLine($"The word you guessed is [{word}].");
                        break;
                    }
                    bool playerLoses = CheckIPlayerLoses(incorrectGuessCount);




                    static string[] ReadWordsFromFile()
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
                const string WordsFileName = "words.txt";
                string path = $@"{projectDirectory}\{WordsFileName}";
                string[] words = File.ReadAllLines(path);
                return words;
            }
        }
       
        
    }
}