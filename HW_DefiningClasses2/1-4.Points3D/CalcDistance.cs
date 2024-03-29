﻿using System;

//task 3 - Write a static class with a static method to calculate the distance between two points in the 3D space.

public static class CalcDistance
{
    
    public static double Calculatedistance(Point3D p1, Point3D p2)
    {
        return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y) + (p1.Z - p2.Z) * (p1.Z - p2.Z));
    }

}