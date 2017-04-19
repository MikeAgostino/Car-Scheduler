using Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Directory
{
    public class CarsService
    {
        //get the Data Layer

        public CarsService()
        {
            //initialize the DB context
        }

        public ModelResponse<List<CarDto>> GetCars(string userId)
        {
            var response = new ModelResponse<List<CarDto>>();

            return response;
        }
    }
}