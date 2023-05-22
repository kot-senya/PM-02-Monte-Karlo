using System;

namespace монте_карло 
{
    internal class Program
    {
        static void findPi()
        {
            Random random = new Random();//рандом
            int n = 10000; //количество точек
            int r = 1; //радиус окружности
            double x, y; //точки координат
            double S0 = Math.Pow(2 * r,2);//нахождение площади квадрата в который вписана окружность
            int k = 0; //счетчик точек попавших в круг
            for (int i = 0; i < n; i++)
            {
                x = random.NextDouble() * (0 - 2 * r) + 2 * r;//генерация дробного числа от 0 до x = стороне квадрата
                y = random.NextDouble() * (0 - 2 * r) + 2 * r;//[точка начала - точка конца) + точка конца
                if (Math.Pow(x - r, 2) + Math.Pow(y - r, 2) <= Math.Pow(r, 2))//проверка вхождения точки в область
                {
                    k++;
                }
            }           
            double s = S0 * k / n; //нахождение площади круга по основной формуле Монте-Карло
            double pi = s / Math.Pow(r, 2); //нахождение числа π из выраженной формулы площади круга
            Console.WriteLine("Результат pi = {0}", pi);
            Console.WriteLine("Точно pi = {0}", Math.PI);
        }
        static void findS()
        {
            Random rnd = new Random(); //создание нового рандома
            int n = 10000000;  //количество точек
            double a = 5;   //высота базового прямоугольника
            double b = 8.5; //ширина базового прямоугольника
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - b) + b ;
                double y = rnd.NextDouble() * (0 - a) + a ;
                if ((x / 3 <= y) && (y <= (x * (10 - x)) / 5))//ограничения графика
                {
                    k++;
                }
            }
            double S = a * b * k / n;
            Console.WriteLine("S фигуры = {0}", S);
        }
        static void task1(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (15 + 5) - 5;
                double y = rnd.NextDouble() * (1 + 1) - 1;//значение синуса не может быть больше 1 или меньше -1
                if (y <= Math.Sin(x))
                {
                    k++;
                }
            }
            double S = (k / n) * 20 * 2;
            Console.WriteLine("1. y = sin (x), y = 0 \nS = {0}", S);
        }
        static void task2(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 + 7) - 7; //(0;0) - начало пересечения линий (7;3.5) - конец пересечения линий
                double y = rnd.NextDouble() * (0 - 8) + 8; //(4;8) - самая высокая точка
                if (y <= ((x * (8 - x)) / 2) && y >= (x/2))
                {
                    k++;
                }
            }
            double S = (k / n) * 7 * 8;
            Console.WriteLine("2. y = (x * (8 - x)) / 2, y = x/2\nS = {0}", S);
        }
        static void task3(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - 12) + 12; //(0;6) - начало пересечения линий (12;6) - конец пересечения линий
                double y = rnd.NextDouble() * (0 - 6) + 6; // у = 6
                if (y <= 6 && y >= Math.Pow((x - 6),2)/ 6)
                {
                    k++;
                }
            }
            double S = (k / n) * 12 * 6;
            Console.WriteLine("3. y = (x-6)^2/6, y = 6\nS = {0}", S);
        }
        static void task4(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - 2.5) + 2.04; //(0;0) - начало пересечения линий (10.2;2.04) - конец пересечения линий
                double y = rnd.NextDouble() * (0 - 4) + 4; //(6;4) - самая высокая точка
                if (y <= ((x * (12 - x)) / 9) && y >= x / 5)
                {
                    k++;
                }
            }
            double S = (k / n) * 2.5 * 4;
            Console.WriteLine("4. y = x(12-x)/9, y = x/5\nS = {0}", S);
        }
        static void task5(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - 8) + 8; //~(0;0) - начало пересечения линий (8;0) - конец пересечения линий
                double y = rnd.NextDouble() * (0 - 5) + 5; //(4;4) - самая высокая точка +-1
                if (y <= ((x * (8 - x)) / 4) && y >= (8 - x) / x)
                {
                    k++;
                }
            }
            double S = (k / n) * 8 * 5;
            Console.WriteLine("4. y = (x*(8-x))/4, y = (8-x)/8\nS = {0}", S);
        }
        static void task6(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - 3) + 3; //~(0;0.8) - начало пересечения линий ~(2.8;0.32) - конец пересечения линий
                double y = rnd.NextDouble(); //значение синуса не может быть больше 1 или меньше -1 а самое маленькое значение у2 0
                if (y <= Math.Sin(x) && y >= Math.Pow((x - 2),2) / 2)
                {
                    k++;
                }
            }
            double S = (k / n) * 3 * 1;
            Console.WriteLine("4. y = (x*(8-x))/4, y = (x-2)^2/2\nS = {0}", S);
        }
        static void displayAll()
        {
            int n = 10000000;  //количество точек
            findPi(); //Вычисление значения числа π методом Монте-Карло 
            findS();//Вычисление площади фигуры методом Монте-Карло
            //Упражнения
            task1(n);
            task2(n);
            task3(n);
            task4(n);
            task5(n);
            task6(n);
        }
        static void display1task()
        {
            Console.WriteLine("1. Вычисление значения числа ПИ методом Монте-Карло \n2. Вычисление площади фигуры методом Монте-Карло\n3. Упражнения");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    findPi();
                    break;
                case 2:
                    findS();
                    break;
                case 3:
                    int n = 10000000;
                    task1(n);
                    task2(n);
                    task3(n);
                    task4(n);
                    task5(n);
                    task6(n);
                    break;
            }
        }
        static void Main(string[] args)
        {
            displayAll();
        }
    }
}

