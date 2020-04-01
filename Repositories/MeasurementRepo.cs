using RailRunnerArchitecture.Application.Port;
using RailRunnerArchitecture.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Repositories
{
    public class MeasurementRepo : IMeasurementRepo
    {
        private JointsContext ctx;

        public MeasurementRepo(JointsContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Measurement> GetByMission(Mission mission)
        {
            return ctx.Measurements.Where(x => x.Mission == mission).ToList();
        }
    }
}
