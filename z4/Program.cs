int[,] pascal = new int[5, 5];

void Triangle(int[,] pascal)
{
    for (int i = 0; i < pascal.GetLength(0); i++)
    {
        Console.SetCursorPosition(pascal.GetLength(0) - i, i);
        for (int j = 0; j <= i; j++)
        {
            pascal[0, 0] = 1;
            if (j == 0 || j == i) pascal[i, j] = 1;
            else pascal[i, j] = pascal[(i - 1), (j - 1)] + pascal[(i - 1), j];
            Console.Write($"{pascal[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Triangle(pascal);

