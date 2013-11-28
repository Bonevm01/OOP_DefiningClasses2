using System;
using System.Collections;
using System.Text;
//task 8 - Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
public class Matrix<T>
{
    private T[,] table;
    private int rows;
    private int columns;

    public Matrix(int row, int col)
    {
        if (row < 1 || col < 1)
        {
            throw new IndexOutOfRangeException("Invalid indexes to creater a matrix. row and col have to be >=1");
        }
        else
        {
            this.rows = row;
            this.columns = col;
            this.table = new T[row, col];
        }
    }

    //task 9 - Implement an indexer this[row, col] to access the inner matrix cells.

    public T this[int r, int c]
    {
        get
        {
            if (r < 0 || r >= this.rows || c < 0 || c >= this.columns)
            {
                throw new IndexOutOfRangeException("The index of row and/or column are/is out of the range.");
            }
            else
            {
                return this.table[r, c];
            }
        }
        set
        {
            if (r < 0 || r >= this.rows || c < 0 || c >= this.columns)
            {
                throw new IndexOutOfRangeException("The index of row and/or column are/is out of the range.");
            }
            else
            {
                this.table[r, c] = value;
            }
        }
    }

    //Task 10 - Implement the operators + and - (addition and subtraction of matrices of the same size) 
    //and * for matrix multiplication. Throw an exception when the operation cannot be performed. 
    //Implement the true operator (check for non-zero elements).

    public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
    {
        if (a.rows != b.rows || a.columns != b.columns)
        {
            throw new FormatException("Matrixes must have same dimensions!");

        }
        else
        {
            Matrix<T> result = new Matrix<T>(a.rows, a.columns);

            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.columns; j++)
                {
                    result[i, j] = (dynamic)a[i, j] + (dynamic)b[i, j];
                }
            }
            return result;
        }
    }

    public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
    {
        if (a.rows != b.rows || a.columns != b.columns)
        {
            throw new FormatException("Matrixes must have same dimensions!");

        }
        else
        {
            Matrix<T> result = new Matrix<T>(a.rows, a.columns);

            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.columns; j++)
                {
                    result[i, j] = (dynamic)a[i, j] - (dynamic)b[i, j];
                }
            }
            return result;
        }
    }

    public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
    {
        if (a.columns != b.rows)
        {
            throw new FormatException("It is not possible to multiply these matrixes.");
        }
        else
        {
            Matrix<T> result = new Matrix<T>(a.rows, b.columns);
            for (int i = 0; i < a.rows; i++)
            {

                for (int j = 0; j < b.columns; j++)
                {
                    for (int m = 0; m < a.columns; m++)
                    {
                        result[i, j] += (dynamic)a[i, m] * (dynamic)b[m, j];
                    }
                }

            }
            return result;
        }

    }

    public static bool operator true(Matrix<T> a)
    {
        foreach (var item in a.table)
        {
            if ((dynamic)item != default(T))
            {
                return true;
                
            }
        }
        return false;
    }
   public static bool operator false(Matrix<T> a)
    {
        foreach (var item in a.table)
        {
            if ((dynamic)item != default(T))
            {
                return true;

            }
        }
        return false;
    }

    public override string ToString()
    {
        int maxLength = 0;
        foreach (var item in this.table)
        {
            if (item.ToString().Length > maxLength)
            {
                maxLength = item.ToString().Length; //check for the matrix element with maximal length
            }
        }
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.columns; j++)
            {
                output.Append(this[i, j].ToString().PadLeft(maxLength + 1)); //use maximal length to align the elements
            }
            output.Append("\n");
        }
        return output.ToString();
    }

    public static void CheckForNonZeroElements(Matrix<T> matrix) //test true-false operator
    {
        if (matrix)
        {
            Console.WriteLine("The matrix is a NON Zero matrix.");
        }
        else
        {
            Console.WriteLine("This matrix contains only zeros.");
        }
    }
}
