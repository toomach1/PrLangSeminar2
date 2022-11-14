var random = new Random();

int num = random.Next(100,1000);
System.Console.WriteLine($"Число {num}");
int numFirst = num / 100;
int NumSecond = num % 10;
int result = numFirst * 10 + NumSecond;

Console.WriteLine($"Итоговое число в числе {result}");
