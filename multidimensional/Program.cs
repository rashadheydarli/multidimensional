//int[,] arr = new int[3, 3]
//{
//    {1, 2, 3 },
//    {4, 5, 6 },
//    {7, 8, 9 }

//};
//int sum = 0;
//for(int i=0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//           sum += arr[i, j];

//        }

//    }
//}
//Console.WriteLine(sum);



int[,] arr = new int[5, 5]
{
    {1, 2, 3, 2, 4},
    {4, 5, 6, 1, 3},
    {7, 8, 9, 4, 8},
    {6, 3, 5, 3, 7},
    {1, 2, 9, 4, 5}

};

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i > j)
        {
            arr[i, j] = 0;
        }
        else
        {
            arr[i, j] = arr[i, j];
        }

    }
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
}

