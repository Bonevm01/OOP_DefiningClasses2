using System;
using System.Collections;
using System.Collections.Generic;

// task 4 - Create a class Path to hold a sequence of points in the 3D space. 
public class Path
{
    public List<Point3D> storage { get; set; }

    public Path()
    {
        this.storage = new List<Point3D>();
    }

    public void AddPoint(Point3D p)
    {
        this.storage.Add(p);
    }



}
