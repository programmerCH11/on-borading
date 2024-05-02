using RedLab_on_boarding.Attributes;
using RedLab_on_boarding.Data;
using RedLab_on_boarding.Delegates;
using RedLab_on_boarding.Exceptions;
using RedLab_on_boarding.Generics;
using RedLab_on_boarding.LinqTask;
using RedLab_on_boarding.QueryableVsEnumerable;
using RedLab_on_boarding.QueryOverTask;

#region FileStream

//using var repos = new FileRepository(Path.Combine(Directory.GetCurrentDirectory(), "Data/File.txt"), FileMode.Open);
//var data = await repos.ReadAsync(CancellationToken.None);

//Console.WriteLine(data);

#endregion

#region Exceptions

//Console.WriteLine(ExceptionExample.GetNumber("1"));

//Console.WriteLine(ExceptionExample.GetNumber(null));

//Console.WriteLine(ExceptionExample.GetNumber("efg"));

#endregion


#region Attributes

//var adminType = new AdminType();
//Console.WriteLine(adminType);

//var simpleType = new SimpleType();
//Console.WriteLine(simpleType);

#endregion

#region Generics

//Node head = new TypedNode<DateTime>(DateTime.UtcNow);
//head = new TypedNode<char>('A', head);
//head = new TypedNode<int>(13456, head);
//Console.WriteLine(head);

#endregion

#region Delegates

//var infinityNumbers = DelegatesMethods.GetInfinityNumberList();

//foreach (var number in infinityNumbers)
//{
//    Console.WriteLine("Current number: " + number);

//    Console.WriteLine("-----------------");
//}

//Console.Write("Even numbers: ");
//var evenNumbers = DelegatesMethods.GetEvenNumbers(infinityNumbers);
//foreach (var evenNumber in evenNumbers)
//{
//    Console.Write($"{evenNumber} ");
//}

//foreach (var number in DelegatesMethods.ThirdMethod(DelegatesMethods.GetEvenNumbers))
//{
//    Console.WriteLine(number);
//}

#endregion

#region Linq

//LinqMethod.GetBestBuyer();

#endregion

#region QueryableEnumerable

//QVsE.Test();

#endregion

#region QueryOver

Console.WriteLine(BuyersQueryOver.GetBestBuyer());

#endregion

Console.ReadLine();