

namespace Strings
{
    internal class Lab20
    {
        private int _n1; // Входные поля
        private int _n2;
        private string? _s1;
        private string? _s2;

        public Lab20()
        {
            _s1 = Console.ReadLine(); // Чтение из консоли
            _n1 = Convert.ToInt32(Console.ReadLine());
            if (_n1 <= 0) // Если число меньше нуля, то кидаем ошибку инвалидной операции
                throw new InvalidOperationException();
            if(_n1 > _s1.Length)
                throw new InvalidOperationException("N1 greater than S1 length");
            _s2 = Console.ReadLine();
            _n2 = Convert.ToInt32(Console.ReadLine());
            if (_n2 > _s2.Length)
                throw new InvalidOperationException("N2 greater than S2 length");
            if (_n2 <= 0)
                throw new InvalidOperationException();

            Console.WriteLine(TrimByInt(_s1, _n1, _s2, _n2)); // Вывод результата
        }
        private string TrimByInt(string s1, int n1, string s2, int n2)
        {
            string result = string.Empty; // Пустая строка
            for (int i = 0; i < n1; i++) // Берем первые n1 символов из строки s1
                result += s1[i]; // Записываем в результат
            for (int i = s2.Length - n2; i < s2.Length; i++) // Берем последние n2 символов из строки s2
                result += s2[i]; // Записываем в результат
            return result; // Возвращаем результат
        }

    }
}
