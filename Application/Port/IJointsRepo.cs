using RailRunnerArchitecture.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Application.Port
{
    public interface IJointsRepo
    {

        IEnumerable<Joint> GetAll();

        Joint GetById(long id);

        IEnumerable<Joint> GetBySectionAndRail(Span span, bool leftRail);

        void Save();

    }
}
