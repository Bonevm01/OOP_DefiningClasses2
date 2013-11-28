using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

//task 5 - Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
public class GenericList<T> where T : IComparable<T>
{
    private T[] elements;
    private int count = 0;
    private int maxLength = 0;
    private int firstLength = 0;

    //task 5 - Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
    public GenericList(int capacity)
    {
        this.elements = new T[capacity];
        this.firstLength = capacity;
        maxLength = capacity;
    }

    //task 5 - Implement methods for adding element, accessing element by index, removing element by index, 
    //inserting element at given position, clearing the list, finding element by its value and ToString(). 

    public void Add(T elem)
    {
        if (count >= this.elements.Length)
        {
            ResizeTheArray();
            this.elements[count] = elem;
            count++;
        }
        else
        {
            this.elements[count] = elem;
            count++;
        }
    }

    public T this[int index]
    {
        get
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
            }
            else
            {
                return elements[index];
            }
        }
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= this.elements.Length)
        {
            throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
        }
        else
        {
            List<T> tempor = new List<T>();
            for (int i = 0; i < elements.Length; i++)
            {
                if (i != index)
                {
                    tempor.Add(elements[i]);
                }
            }
            count--;
            Array.Copy(tempor.ToArray(), elements, count);
            elements[count] = default(T);
        }
    }

    public void Insert(T elem, int index)
    {
        if (index < 0 || index >= this.elements.Length)
        {
            throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
        }
        else
        {
            bool isAddet = false;
            List<T> tempor = new List<T>();
            for (int i = 0; i < elements.Length; i++)
            {
                if (i == index && !isAddet)
                {
                    tempor.Add(elem);
                    i--;
                    isAddet = true;
                }
                else
                {
                    tempor.Add(elements[i]);
                }
            }
            count++;
            if (count > maxLength)
            {
                ResizeTheArray();
            }

            Array.Copy(tempor.ToArray(), elements, count);
        }
    }

    public void Clear()
    {
        elements = new T[firstLength]; //The length of the cleared array is equal to the first initialization
        count = 0;

    }

    public int Find(T elem)
    {
        int index = -1;
        index = Array.IndexOf(elements, elem);

        return index;
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append("The generic list contains:");
        foreach (var item in elements)
        {
            output.Append(item);
            output.Append(", ");
        }
        return output.ToString();
    }

    //task 6 - Implement auto-grow functionality: when the internal array is full,
    //create a new array of double size and move all elements to it.
    private void ResizeTheArray()
    {
        T[] tempor = new T[maxLength * 2];
        Array.Copy(elements, tempor, elements.Length);
        elements = tempor;
        maxLength = elements.Length;
    }

    //task 7 - Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
    //You may need to add a generic constraints for the type T.

    public T Min()
    {
        T tempor = this.elements[0];
        for (int i = 0; i < count; i++)
        {
            if (this.elements[i].CompareTo(tempor) == -1)
            {
                tempor = this[i];
            }
        }
        return tempor;
    }
    public T Max()
    {
        T tempor = this.elements[0];
        for (int i = 0; i < count; i++)
        {
            if (this.elements[i].CompareTo(tempor) == 1)
            {
                tempor = this[i];
            }
        }
        return tempor;
    }
}