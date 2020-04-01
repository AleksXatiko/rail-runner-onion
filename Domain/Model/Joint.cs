using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Domain.Model
{
    public class Joint
    {
        public long Id { get; private set; }

        public Span Span { get; private set; }

        public GeoPosition Position { get; private set; }

        public bool LeftRail { get; private set; }

        public List<Measurement> Measurements { get; private set; }
  
    }
}
