Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99){
  while(num>1000){
    num /=10;
  }
  int result = num%10;
  System.Console.WriteLine(result);
}
else{
  System.Console.WriteLine("третей цифры нет");
  }