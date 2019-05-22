using System;
using System.Collections.Generic;
using System.Net.Http;
//using System.Runtime.Serialization.Json;
using System.IO.Compression;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using System.Web;
using System.Web.Script.Serialization;

namespace ConsoleApplication1
{
    //public class ServicioMeteorologicoNacional
    //{
    //    private String baseUrl = "https://smn.cna.gob.mx";
    //    private HttpClient client { get; set; }
    //    public ServicioMeteorologicoNacional()
    //    {
    //        client = new HttpClient();
    //        client.BaseAddress = new Uri(baseUrl);
    //    }
    //    public async Task<Respuesta> ObtenerInformacion()
    //    {
    //        HttpResponseMessage response = await client.GetAsync("/webservices/?method=1");
    //        Respuesta data = null;
    //        if (response.IsSuccessStatusCode)
    //        {
    //            var serializer = new DataContractJsonSerializer(typeof(Respuesta));
    //            using (var message = await response.Content.ReadAsStreamAsync())
    //            using (var decompressionStream = new GZipStream(message, CompressionMode.Decompress))
    //            {
    //                data = (Respuesta)serializer.ReadObject(decompressionStream);
    //                string textojson = Newtonsoft.Json.JsonConvert.SerializeObject(data);
    //                if (textojson.Length != 0)
    //                {
    //                    JavaScriptSerializer serializer1 = new JavaScriptSerializer();
    //                    Registro listaRegistro = serializer1.Deserialize<Registro>(textojson);

    //                }

    //            }
    //        }
    //        return data;
    //    }
    //}
}
