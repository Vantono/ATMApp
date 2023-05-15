﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI;


public static class Utility
{
    public static void PrintMessage(string msg, bool success = true)
    {
        if (success)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            Console.ForegroundColor= ConsoleColor.Red;
        }
        Console.WriteLine(msg);
        Console.ForegroundColor = ConsoleColor.White;
        PressEnterToContinue();
    }
    public static string GetUserInput(string prompt)
    {
        Console.WriteLine($"Enter {prompt}");
        return Console.ReadLine();
    }
    public static void PressEnterToContinue()
    {
        Console.WriteLine("\n\n Press Enter to Continue\n");
        Console.ReadLine();
    }

    public static string GetSecretInput(string prompt)
    {
        bool isPrompt = true;
        string asterics = "";

        StringBuilder input = new StringBuilder();
        while (true)
        {
            if (isPrompt)
                Console.WriteLine(prompt);
            ConsoleKeyInfo inputKey = Console.ReadKey(true);
            isPrompt = false;

            if (inputKey.Key == ConsoleKey.Enter)
            {
                if(input.Length == 6)
                {
                    break;
                }
                else
                {
                    PrintMessage("Please Enter 6 digits", false);
                    input.Clear();
                    isPrompt = true;
                    continue;
                }
            }
            if (inputKey.Key == ConsoleKey.Backspace && input.Length > 0)
            {
                input.Remove(input.Length - 1, 1);
            }
            else if(inputKey.Key != ConsoleKey.Backspace)
            {
                input.Append(inputKey.KeyChar);
                Console.WriteLine(asterics + "*");
            }
        }
        return input.ToString();
    }

}