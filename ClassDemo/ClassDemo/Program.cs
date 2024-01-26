﻿using System.Text;

namespace ClassDemo;

public class Program
{
    /// <summary>
    /// List of strings, join together by delimiter, ignore null or empty
    /// </summary>
    /// <param name="inputStrings">An array of strings that are...</param>
    /// <returns></returns>
    public static string JoinStringByDelimiterOriginal(string?[] inputStrings)
    {
        ArgumentNullException.ThrowIfNull(inputStrings);
        StringBuilder result = new();
        foreach (string? inputString in inputStrings)
        {
            if (inputString != null)
            {
                if (result.Length > 0)
                {
                    result.Append(' ');
                }
                result.Append(inputString);
            }
        }
        return result.ToString();
    }

    public string GetFullName(string firstName, string lastName, string? middleName = null)
    {
        return StringEx.JoinStringByDelimiter(firstName, lastName, middleName);
        //return firstName + $"{(middleName != null ? ' ' + middleName + ' ' : ' ')}" + lastName;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public void Login(string username, string password)
    {
        if (!TryLogin(username, password))
        {
            throw new InvalidOperationException("Your login is not valid");
        }
    }

    public bool TryLogin(string username, string password)
    {
        if (password == "goodpassword")
        {
            return true;
        }
        return false;
        // Moq library in C#
    }

    public bool TryConvert(string number, out int? result)
    {
        if (number == "one")
        {
            result = 1;
            return true;
        }
        else
        {
            result = null;
            return false;
        }
    }
    
}
