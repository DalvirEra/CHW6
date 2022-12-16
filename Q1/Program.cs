Console.WriteLine("Введите количество M: ");
int M = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i<M; i++){
    Console.WriteLine("Введите число "+ (i+1) + ": ");
    if (Convert.ToInt32(Console.ReadLine()) > 0 ){
        sum += 1;
    }
}
Console.WriteLine("Кол-во чисел > 0: " + sum);
