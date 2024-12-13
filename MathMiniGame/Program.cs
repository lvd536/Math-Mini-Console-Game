﻿using System.Runtime;

Random random = new Random();

int rndnumber1 = 0;
int rndnumber2 = 0;
int exp = 0;
int primers = 0;
string folder = "C:\\MathGame\\";

CheckDataCoin(); // Проверка данных. Если их нет - создание файла с кол-вом коинов
CheckDataPrimerSucces();
StartCycle(); // Стартовый набор сообщений
string input = Console.ReadLine();

Settings(); // Настройки для игры
int primersvalue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВАЖНО: Посмотреть статистику - 001");

switch (input)
{
 case "1":
  PlusSample(primersvalue);
  break;
 
 case "2":
  MinusSample(primersvalue);
  break;
 
 case "3":
  MultiplicationSample(primersvalue);
  break;
 
 case "4":
  DegreeSample(primersvalue);
  break;
 
 case "5":
  AllinOne();
  break;
 
 default:
  Console.WriteLine("Введено неверное значение.");
  break;
 
}
void PlusSample(int value) {

 for (int i = 0; i < value; i++)
 {
  int num1 = random.Next(rndnumber1, rndnumber2);
  int num2 = random.Next(rndnumber1, rndnumber2);
  
  Console.WriteLine($"Ваш пример: {num1} + {num2}. Введите ответ: ");
  int userinput = Convert.ToInt32(Console.ReadLine());
  //int userinputint = Convert.ToInt32(userinput);
  if (num1 + num2 == userinput)
  {
   Console.WriteLine($"Верно! Ответ: {num1 + num2}");
   PrimerAdd();
   CoinAdd();
  }
  else if (userinput == 001)
  {
   Profile(false);
   break;
  }
  else
  {
   Console.WriteLine($"Неверный ответ. Правильный ответ: {num1 + num2}");
  }

 }
 
}

void MinusSample(int value) {
 
 for (int i = 0; i < value; i++)
 {
  
  int num1 = random.Next(rndnumber1, rndnumber2);
  int num2 = random.Next(rndnumber1, rndnumber2);
  
  Console.WriteLine($"Ваш пример: {num1} - {num2}. Введите ответ: ");
  int userinput = Convert.ToInt32(Console.ReadLine());
  if (num1 - num2 == userinput)
  {
   Console.WriteLine($"Верно! Ответ: {num1 - num2}");
   PrimerAdd();
   CoinAdd();
  }
  else if (userinput == 001)
  {
   Profile(false);
   break;
  }
  else
  {
   Console.WriteLine($"Неверный ответ. Правильный ответ: {num1 - num2}");
  }

 }

}

void MultiplicationSample(int value) {
 
 for (int i = 0; i < value; i++)
 {
  
  int num1 = random.Next(rndnumber1, rndnumber2);
  int num2 = random.Next(rndnumber1, rndnumber2);
  
  Console.WriteLine($"Ваш пример: {num1} * {num2}. Введите ответ: ");
  int userinput = Convert.ToInt32(Console.ReadLine());
  if (num1 * num2 == userinput)
  {
   Console.WriteLine($"Верно! Ответ: {num1 * num2}");
   PrimerAdd();
   CoinAdd();
  }
  else if (userinput == 001)
  {
   Profile(false);
   break;
  }
  else
  {
   Console.WriteLine($"Неверный ответ. Правильный ответ: {num1 * num2}");
  }

 }

}

void DegreeSample(int value) {
 
 for (int i = 0; i < value; i++)
 {
  
  int num1 = random.Next(rndnumber1, rndnumber2);
  int num2 = random.Next(rndnumber1, rndnumber2);
  
  Console.WriteLine($"Ваш пример: {num1} : {num2}. Введите ответ: ");
  int userinput = Convert.ToInt32(Console.ReadLine());
  if (num1 % num2 == userinput)
  {
   Console.WriteLine($"Верно! Ответ: {num1 % num2}");
   PrimerAdd();
   CoinAdd();
  }
  else if (userinput == 001)
  {
   Profile(false);
   break;
  }
  else
  {
   Console.WriteLine($"Неверный ответ. Правильный ответ: {num1 % num2}");
  }

 }

}

void CoinAdd()
{
 
 int exprndgen = random.Next(1, 50);
 int resultwin = exp + exprndgen;
 File.WriteAllText(folder + "coindb.game", Convert.ToString(resultwin));
 string getexp = File.ReadAllText(folder + "coindb.game");
 exp = Convert.ToInt32(getexp);
 Console.WriteLine($"Получено: {exprndgen} опыта! Всего опыта: {exp}");
  
}

void PrimerAdd()
{

 primers += 1;
 File.WriteAllText(folder + "primerdb.game", Convert.ToString(primers));
  
}

void CheckDataCoin()
{
 
 if (Directory.Exists(folder) && File.ReadAllText(folder + "coindb.game") != "")
 {
  string expget = File.ReadAllText(folder + "coindb.game");
  exp = int.Parse(expget);
 }
 else if (Directory.Exists(folder) && !File.Exists(folder + "coindb.game") || File.ReadAllText(folder + "coindb.game") == "")
 {
  File.WriteAllText(folder + "coindb.game", "1");
 }
 else
 {
  Directory.CreateDirectory(folder);
  File.Create(folder + "coindb.game").Dispose();
 }
 
}

void CheckDataPrimerSucces()
{
 
 if (Directory.Exists(folder) && File.Exists(folder + "primerdb.game"))
 {
  string primerget = File.ReadAllText(folder + "primerdb.game");
  primers = int.Parse(primerget);
 }
 else if (Directory.Exists(folder) && !File.Exists(folder + "primerdb.game"))
 {
  File.Create(folder + "primerdb.game").Dispose();
  File.WriteAllText(folder + "primerdb.game", "0");
 }
 else
 {
  
 }
 
}

void StartCycle()
{
 Console.WriteLine("Добро пожаловать в математическую викторину!");
 //Task.Delay(900);
 Console.WriteLine("Смысл игры - решать примеры и зарабатывать за это очки");
 //Task.Delay(900);
 Console.WriteLine("Если вы готовы начать: 1 - Примеры на сложение | 2 - Примеры на вычитание | 3 - Примеры на умножение | 4 - Примеры на деление | 5 - Все в одном");
}


void Settings()
{
 Console.WriteLine("1 - Выбрать диапазон чисел для генерации | 2 - Оставить базовый диапазон");
 int choiserange = Convert.ToInt32(Console.ReadLine());
 if (choiserange == 1)
 {
  Console.WriteLine("Введите диапазон чисел, от и до которых будут генерироваться примеры.");
  Console.WriteLine("Введите число от которого будет начинаться генерация");
  rndnumber1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите число на котором будет заканчиваться генерация: ");
  rndnumber2 = Convert.ToInt32(Console.ReadLine());
 }
 else { rndnumber1 = 1; rndnumber2 = 100; }

 Console.WriteLine("Введите кол-во примеров: ");
}

void AllinOne()
{

 for (int i = 0; i < primersvalue; i++)
 {

  int choise = random.Next(1, 4);

  switch (choise)
  {
   case 1: PlusSample(1); break;
   case 2: MinusSample(1); break;
   case 3: MultiplicationSample(1); break;
   case 4: DegreeSample(1); break;
   default: Console.WriteLine("Вы ввели некорректное значение."); break;
  }

 }
}

void Profile(bool detailed)
{
 //Console.WriteLine("Получаю данный о профил...");
 if (detailed)
 {
  Console.WriteLine("Ваш детализированный профиль с результатами ваших игр: ");
  // TODO: Сделть детальную статистику по пользователю.
 }
 else
 {
  Console.WriteLine("Ваш профиль с результатами ваших игр: ");
  Console.WriteLine($"Всего пройденых примеров: {primers}");
 }
}
