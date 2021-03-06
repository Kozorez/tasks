﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        double x;
        double y;
        double z;
        
        public Vector()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        
        public Vector(double a, double b, double c)
        {
            x = a;
            y = b;
            z = c;
        }
        
        public static Vector operator +(Vector ob1, Vector ob2)
        {
            Vector result = new Vector();
            result.x = ob1.x + ob2.x;
            result.y = ob1.y + ob2.y;
            result.z = ob1.z + ob2.z;
            return result;
        }
        
        public static Vector operator -(Vector ob1, Vector ob2)
        {
            Vector result = new Vector();
            result.x = ob1.x - ob2.x;
            result.y = ob1.y - ob2.y;
            result.z = ob1.z - ob2.z;
            return result;
        }
        
        public static double operator *(Vector ob1, Vector ob2)
        {
            return ob1.x * ob2.x + ob1.y * ob2.y + ob1.z * ob2.z;
        }
        
        public static Vector operator *(Vector ob1, double a)
        {
            Vector result = new Vector();
            result.x = ob1.x * a;
            result.y = ob1.y * a;
            result.z = ob1.z * a;
            return result;
        }
        
        public static Vector operator *(double a, Vector ob1)
        {
            Vector result = new Vector();
            result.x = a * ob1.x;
            result.y = a * ob1.y;
            result.z = a * ob1.z;
            return result;
        }
        
        double Length()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }
        
        Vector crossProduct(Vector ob1)
        {
            Vector result = new Vector();
            result.x = y * ob1.z - z * ob1.y;
            result.y = z * ob1.x - x * ob1.z;
            result.z = x * ob1.y - y * ob1.x;
            return result;
        }
        
        static double tripleProduct(Vector ob1, Vector ob2, Vector ob3)
        {
            return ob1 * ob2.crossProduct(ob3);
        }
        
        static double cos(Vector ob1, Vector ob2)
        {
            return (ob1 * ob2) / (ob1.Length() * ob2.Length());
        }
        
        static bool isPerpendicular(Vector ob1, Vector ob2)
        {
            if (ob1 * ob2 == 0)
            {
                return true;
            }
            return false;
        }
        
        static bool isCollinear(Vector ob1, Vector ob2)
        {
            if (ob2.x != 0 && ob2.y != 0 && ob2.z != 0)
            {
                Vector ob3 = ob1.crossProduct(ob2);
                if (ob3.x == 0 && ob3.y == 0 && ob3.z == 0)
                {
                    return true;
                }
            }
            return false;
        }
        
        static bool isComplanar(Vector ob1, Vector ob2, Vector ob3)
        {
            if (tripleProduct(ob1, ob2, ob3) == 0)
            {
                return true;
            }
            return false;
        }
        
        void show()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
        
        static void Main(string[] args)
        {}
    }
}
