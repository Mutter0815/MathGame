using System;
using static System.Console;
namespace MathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string sim = "";
            int numb1, numb2, numb3, count = 0, result = 0, PlayerResult, health = 5, level = 0;

            TextColor("\t\t\tИгра Скоросчет\n",ConsoleColor.Red);
            Write($"Хотите ли вы ознакомится правилами? Если да,введите Y,если нет,то N: ");

            char rules;
            rules = Convert.ToChar(ReadLine());
            Console.Clear();

            switch (rules)
            {
                case 'н':
                case 'y':
                case 'Y':
                    TextColor("\t\t\tИгра Скоросчет.\n\n",ConsoleColor.Red);
                    WriteLine( 
                        "\t\t---------------Правила игры---------------\n" +
                        "Все очень просто,программа генерирует примеры с двузначыми числами\nкоторые вам нужно решать на скорость.\n" +
                        "За каждый правильно решенный пример,вы получаете 1 очко.\n" +
                        "в игре присутствует несколько разных уровней желаем вам удачи и хорошей игры ^_^. \n"+ 
                        "по всем обращаться сюда:"
                        );
                    TextColor(" email: mutter8525@yandex.ru.\n telegram: @mutter0815\n",ConsoleColor.Green);
                    break;
                case 'т':
                case 'n':
                case 'N':
                    WriteLine("Раз с правилами ты уже знаком,то могу только пожелать тебе удачи ;D\n");
                    break;

            } //правила игры
           
            Random Var1 = new Random();
            Random Var2 = new Random();
            Random Var3 = new Random();
            Write("Уровни игры\n\n");
            WriteLine(" 1 уровень: сложение двузначных чисел\n");
            TextColor(" 2 уровень вычитание двузначных чисел\n",ConsoleColor.Red);
            TextColor(" 3 уровень умножение двузначных чисел\n",ConsoleColor.Yellow);
            Write("Введите уровень игры: ");
            level = Convert.ToInt32(ReadLine());
            Console.Clear();
            switch (level) //пользователь выбирает уровень игры
            {
                case 1:
                    WriteLine(" 1 уровень: сложение двузначных чисел\n");
                    while (health != 0)
                    {

                        Write("Введите ответ: ");
                        numb1 = Var1.Next(9, 99);
                        numb2 = Var2.Next(9, 99);
                        result = numb1 + numb2;
                        Write($"{numb1}+{numb2}=");
                        PlayerResult = Convert.ToInt32(ReadLine());

                        if (PlayerResult == result)
                        {
                            WriteLine("Правильно");
                            count++;
                        }
                        if (PlayerResult != result)
                        {
                            health--;
                            WriteLine($"Упс.. Вы ошиблись у вас осталось:{health} жизн{OrfografHealth(health)}");

                        }
                    }
                    break;
                    WriteLine("Game Over");
                    WriteLine($"За игру вы набрали:{count} очков");
                case 2:
                    WriteLine(" 2 уровень: вычитание двузначных чисел\n");

                    while (health != 0)
                    {
                        numb1 = Var1.Next(9, 99);

                        numb2 = Var2.Next(9, 99);

                        result = numb1 - numb2;

                        if (result > 0)
                        {
                            Write("Введите ответ: ");

                            Write($"{numb1}-{numb2}=");
                            PlayerResult = Convert.ToInt32(ReadLine());

                            if (PlayerResult == result) 
                            {
                                TextColor("Правильно", ConsoleColor.Green);
                                count++;
                            }
                            if (PlayerResult != result)
                            {
                                TextColor("Упс.. Вы ошиблись",ConsoleColor.DarkRed);
                                WriteLine($" у вас осталось: {health} жизн{OrfografHealth(health)}");
                                health--;
                            }
                        }
                    }

                    OrfografScore(count);
                    WriteLine("Game Over");
                    WriteLine($"За игру вы набрали:{ OrfografScore(count)} очк{sim}");

                    break;
                case 3:
                    WriteLine("3 уровень: умножение двузначных чисел\n");
                    while (health != 0)
                    {

                        Write("Введите ответ: ");

                        numb1 = Var1.Next(9, 99);

                        numb2 = Var2.Next(9, 99);

                        result = numb1 * numb2;

                        Write($"{numb1}*{numb2}=");
                        PlayerResult = Convert.ToInt32(ReadLine());

                        if (PlayerResult == result)
                        {
                            WriteLine("Правильно");
                            count++;
                        }
                        if (PlayerResult != result)
                        {
                            health--;
                            WriteLine($"Упс.. Вы ошиблись у вас осталось: {health} жизн{OrfografHealth(health)}");

                        }
                    }
                    break;
                case 4:
                    WriteLine("4 уровень: решение примеров,с тремя числами\n");
                    while (health != 0)
                    {

                        Write("Введите ответ: ");

                        numb1 = Var1.Next(9, 99);
                        numb2 = Var2.Next(9, 99);
                        numb3 = Var3.Next(9, 99);

                        result = numb1 + numb2-numb3;

                        Write($"{numb1}+{numb2}-{numb3}=");
                        PlayerResult = Convert.ToInt32(ReadLine());

                        if (PlayerResult == result)
                        {
                            WriteLine("Правильно");
                            count++;
                        }
                        if (PlayerResult != result)
                        {
                            health--;
                            WriteLine($"Упс.. Вы ошиблись у вас осталось: {health} жизн{OrfografHealth(health)}");

                        }
                    }
                    break;

                    break;


            }
            Console.Clear();
            WriteLine("\t\t\t***********Game Over***********\n");
            WriteLine($"За игру вы набрали: {count} очк{sim}");
            WriteLine("Спасибо за игру ^_^");


        }

        static void TextColor(string text, ConsoleColor color)
        {
           
            Console.ForegroundColor = color;
            WriteLine(text);
            ResetColor();
        }
        static string OrfografScore(int count) // соблюдаем орфографию
        {
            string sim = "";

            if (count == 0)
            {
                sim = "ов";
            }
            if (count > 1 || count < 5)
            {
                sim = "а";
            }
            if (count == 1)
            {
                sim = "о";
            }
            if (count > 4)
            {
                sim = "ов";
            }
            return sim;

        }
        static string OrfografHealth(int health)//соблюдаем орофграфию
        {
            string sim1;
            if (health == 1)
            {
                sim1 = "ь";
            }
            else
            {
                sim1 = "ей";
            }
            return sim1;
        }
        
    }
     

}


    

