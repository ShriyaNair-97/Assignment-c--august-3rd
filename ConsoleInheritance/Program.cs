using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInheritance
{
    interface IVolume
    {
        double Volume { get; }
    }
    interface IArea
    {
        double SurfaceArea();
    }

    interface ISolid : IArea, IVolume
    {

    }
    abstract class Solid : ISolid
    {
        double radius;
        const double pi = 3.142;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double Pi
        {
            get { return pi; }

        }

        public Solid()
        {

        }
        public Solid(double _radius)

        {
            radius = _radius;

        }
        
        public abstract double Volume
        {
            get;
        }

       
        public abstract double SurfaceArea();



    }
    class Cylinder : Solid
    {
        double height;
        public Cylinder()
        {

        }
        public Cylinder(double _height, double _radius) : base(_radius)
        {
            height = _height;

        }

        public override double Volume
        {
            get
            {
                double volume = Pi * Math.Pow(Radius,2) * height;
                return volume;
            }

        }
        public override double SurfaceArea()
        {
            double surfaceArea = 2 * Pi * Radius * (Radius + height);
            return surfaceArea;
        }
    }
    class Sphere : Solid
    {
        public Sphere()
        {

        }
        public Sphere(double _radius) : base(_radius)
        {

        }
        public override double SurfaceArea()
        {
            double surfaceArea = 4 * Pi * Math.Pow(Radius,2);
            return surfaceArea;
        }
        public override double Volume
        {
            get
            {
                double volume = 4 * Pi * Math.Pow(Radius,3);

                return volume;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(5.6, 3.2);
            Console.WriteLine("Volume of Cylinder : {0}", cylinder.Volume);
            Console.WriteLine("Surface area  of Cylinder:{0}", cylinder.SurfaceArea());
            

            Sphere sphere = new Sphere(3.2);
            Console.WriteLine(" Volume of Sphere :{0}", sphere.Volume);
            Console.WriteLine("Surface area of Sphere : {0}", sphere.SurfaceArea());
           

        }
    }
}
