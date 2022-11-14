Console.WriteLine("Введите 2 числa");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num%num2;

if(result == 0){
    
    Console.WriteLine("Кратно");
 
}

else{
    Console.WriteLine($"Не кратно, остаток {result}");
}

