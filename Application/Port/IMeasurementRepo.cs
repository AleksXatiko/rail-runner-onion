using RailRunnerArchitecture.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Application.Port
{
    public interface IMeasurementRepo
    {
        IEnumerable<Measurement> GetByMission(Mission mission);
    }
}
