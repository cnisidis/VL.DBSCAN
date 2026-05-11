using Dbscan;
using Stride.Core.Mathematics;
using System;
using VL.Core;

namespace DBSCAN.Utils
{
    public record TrackablePoint : IPointData
    {
        readonly private Dbscan.Point _point;
        public Dbscan.Point Point => _point;

        public Stride.Core.Mathematics.Vector2 Position => new Vector2((float)_point.X, (float)_point.Y);

        public TrackablePoint(Stride.Core.Mathematics.Vector2 position)
        {
            _point = new Dbscan.Point(position.X, position.Y);
        }
        


    }

    
}
