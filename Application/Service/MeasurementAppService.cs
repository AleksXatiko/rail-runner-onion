using RailRunnerArchitecture.Application.Port;
using RailRunnerArchitecture.Domain.Model;
using RailRunnerArchitecture.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Application.Service
{
    public class MeasurementAppService : IMeasurementService
    {
        private MeasurementService domainService;

        private IJointsRepo joints;

        private IMissionRepo missions;

        private IMeasurementRepo measurements;

        public MeasurementAppService(MeasurementService domainService, IJointsRepo joints, IMissionRepo missions, IMeasurementRepo measurements)
        {
            this.domainService = domainService;
            this.joints = joints;
            this.missions = missions;
            this.measurements = measurements;
        }

        public IEnumerable<Measurement> GetMeasurements(long missionId)
        {
            Mission mission = missions.GetById(missionId);
            return measurements.GetByMission(mission);
        }

        public void RegisterMeasurement(long missionId, Measurement measurement)
        {
            Mission mission = missions.GetById(missionId);

            var joint = joints.GetBySectionAndRail(mission.Span, mission.LeftRail)
                .Where(x => domainService.Close(x.Position, measurement.Position))
                .FirstOrDefault(null);
            if (joint != null)
            {
                domainService.AddMeasurement(joint, measurement);
                joints.Save();
            }
            else
            {
                throw new InvalidOperationException("Could not identify measured joint");
            }
        }
    }
}
