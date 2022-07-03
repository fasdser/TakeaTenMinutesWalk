using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeaTenMinutesWalk
{
    internal class Program
    {
        //        You live in the city of Cartesia where all roads are laid out in a perfect grid.
        //        You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk.The city provides its citizens with a Walk 
        //        Generating App on their phones -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']).
        //        You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, so create a function that will return true if 
        //        the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point.
        //        Return false otherwise.
        //        Вы живете в городе Картезия, где все дороги выложены идеальной сеткой.
        //        Вы пришли на встречу на десять минут раньше назначенного срока, поэтому решили воспользоваться случаем и прогуляться.Город дарит своим горожанам Прогулку
        //        Создание приложения на их телефонах — каждый раз, когда вы нажимаете кнопку, оно отправляет вам массив строк из одной буквы, представляющих направления ходьбы (например, ['n', 's', 'w', 'e']).
        //        Вы всегда проходите только один квартал для каждой буквы (направления), и вы знаете, что вам потребуется одна минута, чтобы пройти один городской квартал, поэтому создайте функцию, которая будет возвращать true, если
        //        прогулка, которую предлагает вам приложение, займет у вас ровно десять минут (вы же не хотите опоздать или опоздать!) и, конечно же, вернет вас в исходную точку.
        //        В противном случае вернуть false.

        //        Note: you will always receive a valid array containing a random assortment of direction 
        //                letters ('n', 's', 'e', or 'w' only). It will never give you an empty array(that's not a walk, that's standing still!).
        static void Main(string[] args)
        {
            string[] array = new string[10] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" };          
            Console.WriteLine(IsValidWalk(array));
            Console.ReadKey();
        }

        public static bool IsValidWalk(string[] walk)
        {
            
            if (walk.Length != 10) return false;
            int x = 0, y = 0;
            for (int c = 0; c < walk.Length; c++)           
            {
                switch (walk[c])
                {
                    case "n": y++; break;
                    case "s": y--; break;
                    case "e": x++; break;
                    case "w": x--; break;
                }
            }
            if (x == 0 && y == 0) return true;
            return false;
        }

        //public static bool IsValidWalk(string[] walk)
        //{
        //    if (walk.Length != 10) return false;
        //    var x = 0; var y = 0;
        //    foreach (var dir in walk)
        //    {
        //        if (dir == "n") x++;
        //        else if (dir == "s") x--;
        //        else if (dir == "e") y++;
        //        else if (dir == "w") y--;
        //    }
        //    return x == 0 && y == 0;
        //}

        //public static bool IsValidWalk(string[] walk)
        //{
        //    int n = walk.Where(x => x == "n").Count();
        //    int s = walk.Where(x => x == "s").Count();
        //    int w = walk.Where(x => x == "w").Count();
        //    int e = walk.Where(x => x == "e").Count();
        //    if (walk.Length == 10 && n == s && w == e) return true;
        //    return false;
        //}
    }
}

