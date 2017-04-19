using Services.Directory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Car_Scheduler.Controllers
{

    //TODO: Implement Authentication
    [RoutePrefix("api/cars")]
    public class CarsController : BaseController
    {
        private readonly CarsService _carsService;

        public CarsController(CarsService carsService)
        {
            _carsService = carsService;
        }

        [Route("")]
        public IHttpActionResult GetCars()
        {
            var userId = "1";
            return ResponseJSON(_carsService.GetCars(userId));
        }

        // GET: api/Cars/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cars
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cars/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cars/5
        public void Delete(int id)
        {
        }
    }
}
