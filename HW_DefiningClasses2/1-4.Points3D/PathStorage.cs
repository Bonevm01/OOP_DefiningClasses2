using System;
using System.IO;

//task 4 - Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.
public static class PathStorage
{
    public static void SavePathTXT(Path path)
    {
        StreamWriter myFile = new StreamWriter(@"../../save.txt");
        using (myFile)
        {
            foreach (var item in path.storage)
            {
                string newPoint = item.ToString();
                myFile.WriteLine(newPoint);
            }
        }
    }

    public static void LoadPathTXT(string path, Path listOfPoints)
    {

        StreamReader myFile = new StreamReader(path);
        using (myFile)
        {
            string line = myFile.ReadLine();

            while (line!=null)
            {
                string[] temp = line.Split(new char[] {',',' '}, StringSplitOptions.RemoveEmptyEntries);
                int[] coordinates = new int[temp.Length];
                for (int i = 0; i < coordinates.Length; i++)
                {
                    coordinates[i] = int.Parse(temp[i]);
                }
                Point3D nextPoint = new Point3D(coordinates[0], coordinates[1], coordinates[2]);
                listOfPoints.AddPoint(nextPoint);
                line = myFile.ReadLine();
            }
        }
    }

}
