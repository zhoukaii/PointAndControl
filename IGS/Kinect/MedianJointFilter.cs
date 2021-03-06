﻿using PointAndControl.Helperclasses;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace PointAndControl.Kinect
{
    public class MedianJointFilter : ISkeletonJointFilter
    {
   

        //Median vector filterting Paper: Noise reduction by vector median filtering by Yike Liu
        public Point3D[] jointFilter(List<Point3D[]> jointLists)
        {

            Point3D[] filtered = new Point3D[4];
            double minDist = 0;
            int indexOfMinDist = 0;
            double[] distArray = new double[jointLists.Count];
            List<double> distanceList = new List<double>();
         
            for (int jointMarker = 0; jointMarker < jointLists[0].Length; jointMarker++)
            {

                minDist = double.MaxValue;
                indexOfMinDist = 0;
                
                for (int i = 0; i < jointLists.Count; i++)
                {
                    for (int j = i+1; j <  jointLists.Count; j++)
                    {
                            double tmpDist = IgsMath.l2Norm(jointLists[i][jointMarker] - jointLists[j][jointMarker]);
                            distArray[i] += tmpDist;
                            distArray[j] += tmpDist;
                    }

                    if (minDist > distArray[i])
                    {
                        minDist = distArray[i];
                        indexOfMinDist = i;
                    }
                }
               
                filtered[jointMarker] = jointLists[indexOfMinDist][jointMarker];
                distArray = new double[jointLists.Count];
                
            }

            return filtered;
        }

      

    }
}
