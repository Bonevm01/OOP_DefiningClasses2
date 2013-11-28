using System;

//task 1 Create a structure Point3D
public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    

    public Point3D(int x, int y, int z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public string Name
    {
        get
        {
            return string.Format("{0}{1}{2}", this.X, this.Y, this.Z);
        }
    }

       //task 2 - Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
    //Add a static property to return the point O.

    private static readonly Point3D ZeroPoint = new Point3D(0, 0, 0);

    public static Point3D Center
    {
        get { return ZeroPoint; }
    }

    //task 1 - implement Tostring()
    public override string ToString()
    {
        return string.Format("3DPoint {0}{1}{2}: X = {0}; Y = {1}; Z = {2}", this.X, this.Y, this.Z);
    }
}
