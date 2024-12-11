Random random = new Random();

Console.WriteLine("Добро пожаловать в математическую викторину!");
await (Task.Delay(900));
Console.WriteLine("Смысл игры - решать примеры и зарабатывать за это очки");
await (Task.Delay(900));
Console.WriteLine("Если вы готовы начать: 1 - Примеры на сложение | 2 - Примеры на вычитание | 3 - Примеры на умножение | 4 - Примеры на деление");
string input = Console.ReadLine();


switch (input)
{
 case "1":
  PlusSample();
  break;
 
 case "2":
  MinusSample();
  break;
 
 case "3":
  MultiplicationSample();
  break;
 
 case "4":
  DegreeSample();
  break;
 
 default:
  Console.WriteLine("Введено неверное значение.");
  break;
 
}

void PlusSample() {

 for (int i = 0; i < 999; i++)
 {
  int num1 = random.Next(1, 100);
  int num2 = random.Next(1, 100);
  Console.WriteLine($"Ваш пример: {num1} + {num2}. Введите ответ: ");
  int userinput = Convert.ToInt32(Console.ReadLine());
  if (num1 + num2 == userinput)
  {
   Console.WriteLine($"Верно! Ответ: {num1 + num2}");
  }
  else
  {
   Console.WriteLine($"Неверный ответ. Правильный ответ: {num1 + num2}");
  }

 }
 
}

void MinusSample() {
 
 for (int i = 0; i < 999; i++)
 {
  int num1 = random.Next(1, 100);
  int num2 = random.Next(1, 100);
  Console.WriteLine($"Ваш пример: {num1} - {num2}. Введите ответ: ");
  int userinput = Convert.ToInt32(Console.ReadLine());
  if (num1 - num2 == userinput)
  {
   Console.WriteLine($"Верно! Ответ: {num1 - num2}");
  }
  else
  {
   Console.WriteLine($"Неверный ответ. Правильный ответ: {num1 - num2}");
  }

 }

}

void MultiplicationSample() {
 
 for (int i = 0; i < 999; i++)
 {
  int num1 = random.Next(1, 100);
  int num2 = random.Next(1, 100);
  Console.WriteLine($"Ваш пример: {num1} * {num2}. Введите ответ: ");
  int userinput = Convert.ToInt32(Console.ReadLine());
  if (num1 * num2 == userinput)
  {
   Console.WriteLine($"Верно! Ответ: {num1 * num2}");
  }
  else
  {
   Console.WriteLine($"Неверный ответ. Правильный ответ: {num1 * num2}");
  }

 }

}

void DegreeSample() {
 
 for (int i = 0; i < 999; i++)
 {
  int num1 = random.Next(1, 100);
  int num2 = random.Next(1, 100);
  Console.WriteLine($"Ваш пример: {num1} : {num2}. Введите ответ: ");
  int userinput = Convert.ToInt32(Console.ReadLine());
  if (num1 % num2 == userinput)
  {
   Console.WriteLine($"Верно! Ответ: {num1 % num2}");
  }
  else
  {
   Console.WriteLine($"Неверный ответ. Правильный ответ: {num1 % num2}");
  }

 }

}


