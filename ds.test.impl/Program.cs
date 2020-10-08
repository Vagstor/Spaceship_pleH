using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool consent = true;
            while (consent)
            {
                Console.WriteLine("Здравствуйте! Доступные команды на данный момент:");
                Console.WriteLine();
                foreach (string pl in Plugins.PluginNames)
                    Console.WriteLine(pl);
                Console.WriteLine("Для использования одной из команд введите её код и нажмите Enter");
                IPluginFactory plFactory = new PluginFactory();
                IPlugin plugin = plFactory.GetPlugin(Console.ReadLine());
                Console.WriteLine("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(plugin.Run(num1, num2));
                Console.WriteLine("Хотели бы вы использовать программу еще раз? (y/n)");
                if (Console.ReadLine() == "n") consent = false;
            }
        }
    }
}
