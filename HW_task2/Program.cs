Console.Write("Введи число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumText = Convert.ToString(Num);
if (Num > 99){
  Console.WriteLine("третья цифра -> " + NumText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}