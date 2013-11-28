using System;

class Pointy3DTest
{
    static void Main()
    {
        //test task 1
        Point3D point1 = new Point3D(2, 3, 5);
        Console.WriteLine(point1);
        //test tasks 2 and 3
        double distance = CalcDistance.Calculatedistance(point1, Point3D.Center);
        Console.WriteLine("The distance between point {1} and the center of the coordinate system is {0:f2}.", distance, point1.Name);
        Point3D point2 = new Point3D(2, 2, 2);
        point2.X = 7; //To test set of Point3D propertiies
        Console.WriteLine(point2);
        distance = CalcDistance.Calculatedistance(point1, point2);
        Console.WriteLine("The distance between point {1} and point {2} is {0:f2}",distance, point1.Name, point2.Name);

        Point3D point3 = new Point3D(-2, 6, 7);

        //test task 4
        Path path3DPoints = new Path();
        path3DPoints.AddPoint(point1);
        path3DPoints.AddPoint(point2);
        path3DPoints.AddPoint(point3); //You could add more Point3D and will see different result in the file save.txt

        //test static method save 3Dpoints in a text file
        PathStorage.SavePathTXT(path3DPoints);
        Console.WriteLine();
        Console.WriteLine("Check the file save.txt in 1-4.Point3d directory of this solution");

        //test static method load 3Dpoints from a text file
        Path loadedList = new Path();
        PathStorage.LoadPathTXT(@"../../load.txt", loadedList);

        Console.WriteLine();
        Console.WriteLine("Points loaded from the file load.txt are:");
        foreach (var item in loadedList.storage)
        {
            Console.WriteLine(item);
        }

    }
}
