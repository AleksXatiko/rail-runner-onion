using Microsoft.EntityFrameworkCore;
using RailRunnerArchitecture.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace RailRunnerArchitecture.Repositories
{
    public class JointsContext : DbContext
    {
        public IQueryable<Mission> Missions
        {
            get
            {
                return this.Set<Mission>();
            }
        }

        public IQueryable<Joint> Joints
        {
            get
            {
                return this.Set<Joint>();
            }
        }

        public IQueryable<Measurement> Measurements
        {
            get
            {
                return this.Set<Measurement>();
            }
        }
    }
}