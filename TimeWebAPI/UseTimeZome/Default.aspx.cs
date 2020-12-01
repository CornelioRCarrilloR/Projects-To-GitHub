using System;
using System.Web.UI;


public partial class _Default : Page
{
   protected void Get_Click(object sender, EventArgs e)
    {
        // Se instancia el objeto que va a acceder al servicio rest (webapi). En este caso ya se encuentra referenciado al proyecto web de C#
        TimeWebAPI.Controllers.TimeController service = new TimeWebAPI.Controllers.TimeController();

        TimeWebAPI.Controllers.TimeZone result;

        // Se define el objeto que va a capturar el resultado de la respuesta del servicio a la vez que se le envían los parámetros obtenidos del webform
        result = service.UTC_Date(DateTime.Parse(txtLocalTime.Text), int.Parse(txtTimeZone.Text));
        
        // Se devuelve la respuesta formateada una vez consumido el servicio, para que el cliente lo pueda visualizar.
        lblUTCtime.Text = "The UTC Time is:  <b>" + result.Time + " <b>" + result.TZone + "<b>"; 

    }
}