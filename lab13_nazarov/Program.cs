//Высокий уровень, 23 (Назаров Руслан)

try
{
    Console.Write("Введите строку с фамилиями и инициалами студентов: ");
    string input = Console.ReadLine().ToUpper(); // Приводим все буквы к верхнему регистру для унификации
    char[] mas = input.ToCharArray();

    int[] countArray = new int[33];

    foreach (char symbol in mas)
    {
        if (char.IsLetter(symbol))
        {
            int index = symbol - 'А';

            if (index >= 0 && index < 33)
            {
                countArray[index]++;
            }
        }
    }

    Console.WriteLine("Группа с указанием однофамильцев:");
    for (int i = 0; i < mas.Length; i++)
    {
        if (char.IsLetter(mas[i]))
        {
            int index = mas[i] - 'А';

            if (index >= 0 && index < 33)
            {
                Console.Write($"{mas[i]} ({countArray[index]}) ");
            }
        }
        else
        {
            Console.Write(mas[i]);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}