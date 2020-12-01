using System;
using System.Web.Http;

namespace TimeWebAPI.Controllers
{
    public class TimeZone {

        public string Time { get; set; }
        public string TZone { get =>"utc";} 
    }

    public class TimeController : ApiController
    {
        [HttpPost]
        public TimeZone UTC_Date(DateTime localdate, int timezone)
        {
            DateTime DateToShow;
            DateToShow = localdate.AddHours(timezone);

            // Definimos el objeto a devolver y lo seteamos con la fecha que se quiere mostrar.
            TimeZone Response = new TimeZone();
            
            Response.Time = DateToShow.ToLongTimeString();
            return Response;
        }
    }

}
