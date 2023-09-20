using System;
using System.Drawing;
using System.Reflection.Metadata;


public struct Vector
{
    int x;
    int y;
    int z;
    Vector(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Vector operator +( Vector v1, Vector v2)
    {
        return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
    }
    public static Vector operator *(Vector v1, Vector v2)
    {
        return new Vector(v1.x * v2.x, v1.y * v2.y, v1.z* v2.z);
    }
    public static Vector operator *(int num, Vector v)
    {

        return new Vector(v.x *num , v.y *num, v.z * num);
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        double a = Math.Sqrt(Math.Pow(v1.x, 2) + Math.Pow(v1.y, 2) + Math.Pow(v1.z, 2));
        double b = Math.Sqrt(Math.Pow(v1.x, 2) + Math.Pow(v1.y, 2) + Math.Pow(v1.z, 2));
        if (a != b) return true;
        return false;
    }
    public static bool operator ==(Vector v1, Vector v2)
    {
         double a= Math.Sqrt(Math.Pow(v1.x , 2) + Math.Pow(v1.y, 2)+ Math.Pow(v1.z, 2));
        double b = Math.Sqrt(Math.Pow(v1.x, 2) + Math.Pow(v1.y, 2) + Math.Pow(v1.z, 2));
        if (a>b) return true;
        return false;
    }
}

namespace part1
{
    class program
    {
        static void Main(string[] args)
        {

        }
    }
}