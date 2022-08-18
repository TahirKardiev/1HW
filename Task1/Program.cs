Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine("Палиндром.");
  }
  else 
  {
    Console.WriteLine("НЕ палиндром.");
  }
}

if (number.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine("Не пятизначное число");