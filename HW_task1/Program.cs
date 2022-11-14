var random = new Random();

int num = random.Next(100,1000);
System.Console.WriteLine($"Число {num}");
int numFirst = num / 10;
int NumSecond = numFirst % 10;


Console.WriteLine(NumSecond);