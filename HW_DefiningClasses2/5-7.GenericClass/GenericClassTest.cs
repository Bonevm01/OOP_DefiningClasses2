using System;

class GenericClassTest
{
    static void Main()
    {
        GenericList<int> firstList = new GenericList<int>(5);

        //Test Adding elements
        firstList.Add(3);
        firstList.Add(4);
        firstList.Add(2);

        Console.WriteLine(firstList); //test ToString()
        Console.WriteLine("Generic element on position 0 is equal to {0}", firstList[0]); //Test accessing element by index

        //Test removing element by index
        firstList.Remove(1);
        Console.WriteLine("The list after removing element on position 1 is:");
        Console.WriteLine(firstList);

        firstList.Add(7);
        firstList.Add(-5);

        Console.WriteLine("The list after adding two new elements is:");
        Console.WriteLine(firstList);

        //Test inserting element by index
        firstList.Insert(8, 1);
        Console.WriteLine("The list after inserting new element on position 1 is:");
        Console.WriteLine(firstList);

        firstList.Insert(-2, 4);

        Console.WriteLine("The list after inserting a new element on position 4:");
        Console.WriteLine(firstList);

        firstList.Add(-12);
        Console.WriteLine("after adding a new element:");
        Console.WriteLine(firstList);

        firstList.Remove(3);
        Console.WriteLine("after removing position 3");
        Console.WriteLine(firstList);

        firstList.Add(18);
        Console.WriteLine("after adding a new element:");
        Console.WriteLine(firstList);

        //test finding element by its value
        Console.Write("What value are you looking for: ");
        int input = int.Parse(Console.ReadLine());
        int position = firstList.Find(input);
        Console.WriteLine(position == -1 ? "Your inut is not part of this array" : string.Format("The position of {0} is {1}", input, position));

        //test Min and Max
        int min = firstList.Min();
        Console.WriteLine( "The minimal element in the list is {0}", min);
        int max = firstList.Max();
        Console.WriteLine("The maximal element in the list is {0}", max);

        //test clearing the list
        firstList.Clear();
        Console.WriteLine("The array after clearing contains:");
        Console.WriteLine(firstList);

        firstList.Add(9);
        Console.WriteLine("After adding a new element in the cleared array:");
        Console.WriteLine(firstList);


        //Test with strings
        Console.WriteLine();
        Console.WriteLine("Generic list of strings");
        GenericList<string> secondList = new GenericList<string>(3);
        secondList.Add("abv");
        secondList.Add("mnb");
        secondList.Add("bvc");
        Console.WriteLine(secondList);
        secondList.Add("Length+");
        Console.WriteLine(secondList);
        secondList.Remove(2);
        Console.WriteLine(secondList);
        secondList.Insert("alabala", 1);
        Console.WriteLine(secondList);

        //test Min and Max
        string minstr = secondList.Min();
        Console.WriteLine("The minimal element in the list is {0}", minstr);
        string maxstr = secondList.Max();
        Console.WriteLine("The maximal element in the list is {0}", maxstr);
    }
}
