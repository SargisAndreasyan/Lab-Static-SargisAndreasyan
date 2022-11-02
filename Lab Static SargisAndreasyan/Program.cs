using ClassLibrary1;
using System.Security.Principal;
using static ClassLibrary1.Class1;

Class1 c = new Class1();
Account a = new Account("Sargis", "Andreasyan", DateTime.Now);
decimal n = Account.GetSum(50, 5, AccountState.Gold);
Console.WriteLine(n);