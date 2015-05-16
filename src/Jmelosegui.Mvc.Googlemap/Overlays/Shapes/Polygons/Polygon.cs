﻿using System;
using System.Collections.Generic;

namespace Jmelosegui.Mvc.Googlemap.Overlays
{
    public class Polygon : Shape, ILocationContainer
    {
        private readonly List<Location> points;
        public Polygon(GoogleMap map): base(map)
        {
            points = new List<Location>();
        }
        
        public IList<Location> Points
        {
            get
            {
                return points.AsReadOnly();
            }
        }

        public virtual void AddPoint(Location point)
        {
            if (point == null) throw new ArgumentNullException("point");
            points.Add(point);
        }

        public override ISerializer CreateSerializer()
        {
            return new PolygonSerializer(this);
        }
    }
}