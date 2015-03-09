﻿using numl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace IGS.KNN
{
    class NormalSample
    {

        [Feature]
        public double directionX { get; set; }
        [Feature]
        public double directionY { get; set; }
        [Feature]
        public double directionZ { get; set; }

        [Feature]
        public double shoulderX { get; set; }
        [Feature]
        public double shoulderY { get; set; }
        [Feature]
        public double shoulderZ { get; set; }
        [Label]
        public String sampleDeviceName { get; set; }

        public NormalSample(Point3D shoulder, Vector3D direction)
        {
            directionX = direction.X;
            directionY = direction.Y;
            directionZ = direction.Z;

            shoulderX = shoulder.X;
            shoulderY = shoulder.Y;
            shoulderZ = shoulder.Z;

            sampleDeviceName = "";
        }

        public NormalSample(Point3D shoulder, Vector3D direction, String sampleDeviceName)
        {
            directionX = direction.X;
            directionY = direction.Y;
            directionZ = direction.Z;

            shoulderX = shoulder.X;
            shoulderY = shoulder.Y;
            shoulderZ = shoulder.Z;

            this.sampleDeviceName = sampleDeviceName;
        }
    }
}
