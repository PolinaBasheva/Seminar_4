Задача 25/
  Console.Write("Введите число первое: ");
  int numone= Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число второе: ");
  int numtwo= Convert.ToInt32(Console.ReadLine());

int Result(int numone, int numtwo)
{
  int result = 1;
  for(int i=1; i <= numtwo; i++){
    result = result * numone;
  return result;
}


  int result_1 = Result(numone, numtwo);
  Console.WriteLine("Ответ: " + result_1);}
  
  Задача 27.
  Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

Задание 29.
int size = 8;
            int[] array = new int[8];
            Random myRandom = new Random();
 
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 20);
                Console.Write("{0} ", array[i]);
            }
