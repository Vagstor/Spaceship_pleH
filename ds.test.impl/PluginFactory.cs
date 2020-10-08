using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class PluginFactory : IPluginFactory
    {
        public IPlugin GetPlugin (string plCode)
        {
            switch (plCode)
            {
                case "1":
                    return new AdditionPlugin("Сложение", "1.0", "Осуществляет сложение двух целых чисел");
                case "2":
                    return new MultiplicationPlugin("Умножение", "1.0", "Осуществляет умножение двух целых чисел");
                default:
                    Console.WriteLine("Не указана (неверно указана) процедура!");
                    return new BasicPlugin("Первое число", "1.0", "Выводит первое число: базовая процедура");
            }
        }
    }
}
