using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RailRunnerArchitecture.Application.Port;
using RailRunnerArchitecture.Domain.Model;

namespace RailRunnerArchitecture.Controllers
{
    [Route("api/measurements")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {
        private IMeasurementService measurement;

        public MeasurementController(IMeasurementService measurement)
        {
            this.measurement = measurement;
        }

        [HttpGet("{missionId}")]
        public ActionResult<IEnumerable<Measurement>> Get(long missionId)
        {
            return new ActionResult<IEnumerable<Measurement>>(measurement.GetMeasurements(missionId));
        }

        [HttpPost("{missionId}")]
        public void Post(long missionId, [FromBody] Measurement value)
        {
            measurement.RegisterMeasurement(missionId, value);
        }

    }
}
