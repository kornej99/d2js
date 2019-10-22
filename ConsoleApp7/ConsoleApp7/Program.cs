        using System;

    namespace HelloApp
    {
        class Program
        {
            static void Main(string[] args)
            {
            
                Console.WriteLine("Введите сторону треугольника a");
                var a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите сторону треугольника b");
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите сторону треугольника c");
                var c = Convert.ToInt32(Console.ReadLine());
                if (jopa(a, b, c) != 0)
                {
                    Console.WriteLine($"Периметр треугольника равен = {jopa(a, b, c)}");
                    Console.WriteLine($"Площадь треугольника ={Math.Round(Area(a, b, c), 4)}");
                    Console.WriteLine($"Площадь всей окружности ={Math.Round(circleArea(a, b, c), 4)}");
                }
                else
                {
                    Console.WriteLine("некорректные данные");
                }
                Console.ReadKey();
            }



            static int sOfTrigon(int a, int b, int c) => a + b + c;
            static double Area(int a, int b, int c)
            {
                var P = (a + b + c) / 2;
                double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                return S;
            }

            static double circleArea(int a, int b, int c)
            {
                var P = (a + b + c) / 2;
                double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c)); ;
                double R = S / P;
                double circleArea = 3.14 * Math.Pow(R, 2);
                return circleArea;
            }
            static int jopa(int a, int b, int c)
            {
                if (a > 0 & b > 0 & c > 0)
                {
                    if ((b + c) > a & (a + c) > b & (a + b) > c)
                    {
                        return sOfTrigon(a, b, c);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }   
            }
            }
        }

