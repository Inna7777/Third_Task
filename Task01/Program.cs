//Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число ");
string nStr = Console.ReadLine() ??"";
string [] mas = nStr.Select(i => i.ToString()).ToArray();
if (nStr.Length > 5)
{
    Console.WriteLine("Число не пятизначное. Введите пятизначное ");
}
else{
        if ( nStr[0]== nStr[4] && nStr[1]== nStr[3] )
     {
        Console.WriteLine($"Число { nStr } является полиндромом");
      }
   else
   {
    Console.WriteLine($"Число Не является полиндромом");
   }          
}
 
