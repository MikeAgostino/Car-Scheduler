using Services.Dtos;
using System.Net;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Car_Scheduler.Controllers
{
    public class BaseController : ApiController
    {

        public IHttpActionResult Response(HttpStatusCode code, dynamic message)
        {
            return Content(code, message);
        }

        public IHttpActionResult ResponseError(ErrorResponse error)
        {
            return Content(error.StatusCode, error.Message);
        }

        public IHttpActionResult ResponseOK<T>(T content)
        {
            return Content(HttpStatusCode.OK, content);
        }

        public IHttpActionResult ResponseJSON<T>(ModelResponse<T> response) where T : class
        {
            return response.Error != null ? ResponseError(response.Error) :  ResponseOK(response.Model);
        }
    }
}