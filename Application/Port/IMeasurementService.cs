using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RailRunnerArchitecture.Domain.Model;

namespace RailRunnerArchitecture.Application.Port
{
    public interface IMeasurementService
    {
        void RegisterMeasurement(long missionId, Measurement measurement);

        IEnumerable<Measurement> GetMeasurements(long missionId);
    }
}