//Высокий уровень, 23
string[] students = { "Назаров Руслан", "Садик Назар", "Печкин Анатолий", "Печкин Андрей", "Фомичев Алексей",  };

int[] studentsCount = new int[students.Length];

for (int i = 0; i < students.Length; i++)
{
    for (int j = 0; j < students.Length; j++)
    {
        if (i != j && students[j].IndexOf(students[i].Split(' ')[0]) != -1)
        {
            studentsCount[i]++;
        }
    }
}

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"Студент {students[i]} имеет {studentsCount[i]} однофамильцев");
}