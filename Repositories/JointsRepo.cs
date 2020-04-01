using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailRunnerArchitecture.Application.Port;
using RailRunnerArchitecture.Domain.Model;

namespace RailRunnerArchitecture.Repositories
{
    public class JointsRepo : IJointsRepo
    {
        private JointsContext ctx;

        public JointsRepo(JointsContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Joint> GetAll()
        {
            return ctx.Joints.ToList();
        }

        public Joint GetById(long id)
        {
            return ctx.Joints.Where(x => x.Id == id).Single();
        }

        public IEnumerable<Joint> GetBySectionAndRail(Span span, bool leftRail)
        {
            return ctx.Joints.Where(x => x.Span == span && x.LeftRail == leftRail).ToList();
        }

        public void Save()
        {
            ctx.SaveChanges();
        }
    }
}
