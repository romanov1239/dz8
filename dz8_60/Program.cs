//Трёхмерная матрица 2*2*2
Console.Clear();

int[,,] triplearray = {{{22, 33},{44, 55}},
{{66, 77},{88, 99}} };

void PrintTriplearray(int[,,] array){
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int c = array.GetLength(2);

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                Console.Write($" {array[i,j,k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}
PrintTriplearray(triplearray);
