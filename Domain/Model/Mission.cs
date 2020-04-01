using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Domain.Model
{
    public class Mission
    {
        public long Id { get; internal set; }

        public Span Span { get; private set; }

        public bool LeftRail { get; private set; }

    }
}
