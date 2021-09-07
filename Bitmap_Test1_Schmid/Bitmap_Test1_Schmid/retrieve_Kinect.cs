﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;
using System.Drawing;
namespace Bitmap_Test1_Schmid
{
    class retrieve_Kinect
    {
        KinectSensor kinectSensor = null;
        BodyFrameReader bodyFrameReader = null;
        Body[] bodies = null;
        public retrieve_Kinect()
        {
            InitializeKinect();
        }

        public void InitializeKinect()
        {
            kinectSensor = KinectSensor.GetDefault();
            if (kinectSensor != null) //turn on kinect
            {
                kinectSensor.Open();
            }
            else
            {
                bodyFrameReader = kinectSensor.BodyFrameSource.OpenReader();
                if (bodyFrameReader != null)

                {
                    bodyFrameReader.FrameArrived += reader_FrameArrived;
                }
            }
        }

        private void reader_FrameArrived(object sender, BodyFrameArrivedEventArgs e)
        {
            bool dataRecieved = false;
            using (BodyFrame bodyFrame = e.FrameReference.AcquireFrame())
            {
                if (bodyFrame != null)
                {
                    if (bodies == null)
                    {
                        bodies = new Body[bodyFrame.BodyCount];
                    }
                    bodyFrame.GetAndRefreshBodyData(bodies);


                }

                dataRecieved = true;
            }
            if (dataRecieved)
            {
                foreach (Body body in bodies)
                {
                    if (body.IsTracked)
                    {
                        IReadOnlyDictionary<JointType, Joint> joints = body.Joints;
                        Dictionary<JointType, Point> jointPoints = new Dictionary<JointType, Point>();

                        Joint FootRight = joints[JointType.FootRight];
                        Joint FootLeft = joints[JointType.FootLeft];

                        #region Variables for Tracking the feet
                        float rf_distance_x = FootRight.Position.X;
                        float rf_distance_y = FootRight.Position.Y;
                        float rf_distance_z = FootRight.Position.Z;

                        float lf_distance_x = FootLeft.Position.X;
                        float lf_distance_y = FootLeft.Position.Y;
                        float lf_distance_z = FootLeft.Position.Z;

                        #endregion
                        rightFoot = rf_distance_x.ToString() + rf_distance_y.ToString() + rf_distance_z.ToString();

                    }

                }
            }
        }

        private string rightFoot
        {
            get
            {
                return "0";
            }
            set
            {

            }
        }
        private string leftFoot
        {
            get
            {
                return "0";
            }
            set
            {

            }
        }
    }


}
