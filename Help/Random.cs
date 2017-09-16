// rnd - задаём имя переменной рандома
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10); // ставим диапозон чисел (можно % 10[от 0 до 10])
            }
