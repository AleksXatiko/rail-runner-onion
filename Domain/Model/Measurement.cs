using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailRunnerArchitecture.Domain.Model
{
    public class Measurement
    {
        public Joint Described { get; internal set; }

        public Mission Mission { get; private set; }

        public DateTime Time { get; private set; }

        public GeoPosition Position { get; private set; }

        public int Width { get; private set; }

    }
}
