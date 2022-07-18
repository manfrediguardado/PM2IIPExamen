using System;
using System.Collections.Generic;
using System.Text;


using PM2IIPExamen.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
namespace PM2IIPExamen.Controller
{
    public class sitiosController
    {
        public async static Task<List<apiSitios.SitioC>> ObtenerSitios()
        {
            List<apiSitios.SitioC> listapaises = new List<apiSitios.SitioC>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://cr10.000webhostapp.com/examen/obtener.php");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapaises = JsonConvert.DeserializeObject<List<apiSitios.SitioC>>(contenido);
                }
            }
            return listapaises;
        }
    }

    

}
