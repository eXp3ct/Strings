using System;
using StringsExtenstions;
namespace Strings
{
    internal class Lab9
    {
        private string _input; // Поле для входной строки

        public Lab9() // Конструктор
        {
            _input = FillString(); // Заполнение строки

            _input = _input.Seperate(" "); // Разделяем строку используя расширение Seperate из пространства имен StringExtensions

            Console.WriteLine(_input); // Вывод преобразованной строки
        }

        private string FillString() 
        {
            string? str = Console.ReadLine(); // Читаем строку из консоли
            if (str == string.Empty) // Если она пустая, то кидаем исключение инвалидной операции
                throw new InvalidOperationException();
            return str; // Возвращаем строку
        }
    }
}
