using RailRunnerArchitecture.Application.Port;
using RailRunnerArchitecture.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Repositories
{
    public class MissionRepo : IMissionRepo
    {
        private JointsContext ctx;

        public MissionRepo(JointsContext ctx)
        {
            this.ctx = ctx;
        }

        public Mission GetById(long id)
        {
            return ctx.Missions.Where(x => x.Id == id).Single();
        }
    }
}
