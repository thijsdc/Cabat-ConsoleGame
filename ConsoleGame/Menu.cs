using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleGame
{
    class Menu
    {
        private int SelectedIndex;
        private String[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)

        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        public void DisplayOptions()

        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)

            {
                string CurrentOption = Options[i];
                string prefix;

                if(i == SelectedIndex)

                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;   
                }

                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                WriteLine($"{prefix} << {CurrentOption} >>");
            }

            ResetColor();
        }

        public int Run()

        {
            ConsoleKey keyPressed;

            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if(keyPressed == ConsoleKey.UpArrow)

                {
                    SelectedIndex--;
                    if (SelectedIndex == -1) SelectedIndex = Options.Length - 1;
                }

                else if (keyPressed == ConsoleKey.DownArrow)

                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length) SelectedIndex = 0;
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }

        public int Run(string displayart)

        {
            ConsoleKey keyPressed;

            do
            {
                Clear();
                Console.WriteLine(displayart);
                Console.WriteLine();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)

                {
                    SelectedIndex--;
                    if (SelectedIndex == -1) SelectedIndex = Options.Length - 1;
                }

                else if (keyPressed == ConsoleKey.DownArrow)

                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length) SelectedIndex = 0;
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }

        public int Run(int left, int top)

        {
            ConsoleKey keyPressed;

            do
            {
                Console.SetCursorPosition(left, top);
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)

                {
                    SelectedIndex--;
                    if (SelectedIndex == -1) SelectedIndex = Options.Length - 1;
                }

                else if (keyPressed == ConsoleKey.DownArrow)

                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length) SelectedIndex = 0;
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}
