using System;
using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata;


public struct Vector
{
    public int x;
    public int y;
    public int z;
    public Vector(int x, int y, int z)
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
            Vector v1 = new Vector(2,3,4);
            Vector v2 = new Vector(5,6,7);
            Vector v3= v1+ v2;
            Console.WriteLine($"v3:\tx={v3.x}\ty={v3.y}\tz={v3.z}\t");
            Vector v4= v1* v2;
            Console.WriteLine($"v4:\tx={v4.x}\ty={v4.y}\tz={v4.z}\t");
            Vector v5= 5*v1;
            Console.WriteLine($"v5:\tx={v5.x}\ty={v5.y}\tz={v5.z}\t");
            if (v5 == v1) Console.WriteLine("Это правда");
            Console.WriteLine("Это ложь");
        }
    }
}