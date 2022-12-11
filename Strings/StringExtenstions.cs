

namespace StringsExtenstions
{
    public static class StringExtenstions // Статический класс расширения для строк
    {
        public static string Seperate(this string str, string delimeter) // Метод расширения для строки (ключевое слово this в первой параметре говорит о том, что этот метод - расширение)
        {
            string result = string.Empty; // локальная пустая строка
            string[] words = str.Split(" "); // Разделеяем входную строку на слова, разделяемые пробелами
            foreach (var word in words) // Для каждого слова 
            {
                foreach (var symbol in word) // Для каждого символа в слове
                    result += symbol + delimeter; // Записываем в результат сам символ и разделитель после него

                result = result.TrimEnd(Convert.ToChar(delimeter)); // Убираем разделитель в конце слова
                result += " "; // Ставим пробел после слова
            }

            return result; // Возвращаем результат
        }
    }
}
