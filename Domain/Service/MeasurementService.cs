using RailRunnerArchitecture.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Domain.Service
{
    public class MeasurementService
    {
        private double CloseLatitude = 0.001;
        private double CloseLongitude = 0.001;

        public MeasurementService()
        {
        }

        public MeasurementService(double closeLatitude, double closeLongitude)
        {
            CloseLatitude = closeLatitude;
            CloseLongitude = closeLongitude;
        }

        public void AddMeasurement(Joint joint, Measurement measurement)
        {
            measurement.Described = joint;
            joint.Measurements.Add(measurement);
        }

        public bool Close(GeoPosition a, GeoPosition b)
        {
            return Math.Abs(a.Latitude - b.Latitude) < CloseLatitude
                && Math.Abs(a.Longitude - b.Longitude) < CloseLongitude;
        } 
    }
}
