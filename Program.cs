using System;

namespace usr2
{
    class Program
    {
        static int _n1, _n2, _length1, _length2;
        private static string _ch1, _ch2, _str1, _str2;

        static void Main(string[] args)
        {
            GET_DATA();
            Enter();
        }

        private static void GET_DATA()
        {
            try
            {
                Console.WriteLine("Введите первый символ:");
                _ch1 = Console.ReadLine();
                _n1 = Convert.ToInt32(_ch1);
            }
            catch
            {
                _str1 = _ch1;
                _length1 = _str1.Length;
            }
            try
            {
                Console.WriteLine("Введите второй символ:");
                _ch2 = Console.ReadLine();
                _n2 = Convert.ToInt32(_ch2);
            }
            catch
            {
                _str2 = _ch2;
                _length2 = _str2.Length;
            }
        }

        private static void Enter()
        {
            
            if ((_n1 > _n2) | (_n1 < _n2) & (_n1 != _n2))
            {
                Console.WriteLine(_n1 > _n2);
            }
            else if

                ((_length1 > _length2) | (_length1 < _length2) & (_length1 != _length2))
            {
                Console.WriteLine(_length1 > _length2);
            }
            else
            {
                Console.WriteLine("Равны между собой");
            }
        }
    }
}