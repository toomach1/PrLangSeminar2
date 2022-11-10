var random = new Random();

int num = random.Next(10,100);
System.Console.WriteLine($"Число {num}");
int numFirst = num / 10;
int NumSecond = num % 10;

int max = 0;

if(numFirst<NumSecond){
    max = NumSecond;
}
else{
    max = numFirst;
}
Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");

