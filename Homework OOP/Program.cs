using System;
using System.Collections.Generic;

namespace Homework_OOP
{
    class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<int, Account> accounts = new Dictionary<int, Account>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArguments = command.Split(' ');
                int currentAccount = int.Parse(commandArguments[1]);
                if (commandArguments[0] == "Create")
                {
                    if (accounts.ContainsKey(currentAccount))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else accounts.Add(currentAccount, new Account(currentAccount, 0));                  
                }
                else if (commandArguments[0] == "Deposit")
                {
                    double depositValue = double.Parse(commandArguments[2]);
                    if (accounts.ContainsKey(currentAccount))
                    {
                        accounts[currentAccount].Deposit(depositValue);
                    }
                    else Console.WriteLine("Account does not exist");
                }
                else if (commandArguments[0] == "Withdraw")
                {
                    double withdrawValue = double.Parse(commandArguments[2]);
                    if (accounts.ContainsKey(currentAccount))
                    {
                        try
                        {
                            accounts[currentAccount].Withdraw(withdrawValue);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else Console.WriteLine("Account does not exist");
                }
                else if (commandArguments[0] == "Print")
                {
                    if (accounts.ContainsKey(currentAccount))
                    {
                        Console.WriteLine(accounts[currentAccount].ToString());
                    }
                    else Console.WriteLine("Account does not exist");
                }
                command = Console.ReadLine();
            }

        }
    }
}
