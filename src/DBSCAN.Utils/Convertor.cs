using System;
using System.Numerics;
using VL.Lib.Mathematics;
using Dbscan;

namespace DBSCAN.Utils
{
    /// <summary>
    /// Class implementing IPointData to use VL's Vector2 with DBSCAN plugin
    /// </summary>
    public static class Convertor
    {


        
        public static Dbscan.Point FromVector(Stride.Core.Mathematics.Vector2 Point)
        {
            return new Dbscan.Point(Point.X, Point.Y);
        }

        

        
        public static Stride.Core.Mathematics.Vector2 ToVector2(Dbscan.Point point)
        {
            return new Stride.Core.Mathematics.Vector2((float)point.X, (float)point.Y);
        }
    }
}