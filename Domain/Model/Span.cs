using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Domain.Model
{
    public class Span
    {
        public Station From { get; private set; }
        public Station To { get; private set; }
    }
}
