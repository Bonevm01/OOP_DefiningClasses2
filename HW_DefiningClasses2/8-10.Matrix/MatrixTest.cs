using System;

class MatrixTest
{
    static void Main()
    {
        //test task 8 and 9
        Matrix<int> intTable = new Matrix<int>(3, 3);
        Console.WriteLine("Matrix of integers:");
        Matrix<int>.CheckForNonZeroElements(intTable); //test true-false operator
        Console.WriteLine(intTable);
        
        intTable[1, 2] = 5;
        intTable[0, 1] = -3;
        intTable[2, 1] = -1;
        Matrix<int>.CheckForNonZeroElements(intTable);//test true-false operator
        Console.WriteLine(intTable);
        Console.WriteLine(intTable[0, 1]);

        Console.WriteLine("Decimal matrix:");
        Matrix<decimal> decTable = new Matrix<decimal>(2, 3);
        decTable[0, 0] = 1.251M;
        decTable[1, 2] = 2.3412M;
        Matrix<decimal>.CheckForNonZeroElements(decTable);//test true-false operator
        Console.WriteLine(decTable);

        Matrix<int> table2 = new Matrix<int>(3, 3);
        table2[0, 0] = -2;
        table2[0, 1] = 3;
        table2[0, 2] = 1;
        table2[1, 0] = -2;
        table2[1, 1] = -3;
        table2[2, 2] = 1;
       
        Console.WriteLine("Test matrix minus operation:");
        Console.WriteLine(intTable);
        Console.WriteLine("-");
        Console.WriteLine(table2);
        Console.WriteLine("=");
        Console.WriteLine(intTable - table2);

        Console.WriteLine("Test matrix plus operation:");
        Console.WriteLine(intTable);
        Console.WriteLine("+");
        Console.WriteLine(table2);
        Console.WriteLine("=");
        Console.WriteLine(intTable + table2);

        Console.WriteLine("Test matrix multiply operation:");
        Console.WriteLine(intTable);
        Console.WriteLine("*");
        Console.WriteLine(table2);
        Console.WriteLine("=");
        Console.WriteLine(intTable * table2);
    }


}
