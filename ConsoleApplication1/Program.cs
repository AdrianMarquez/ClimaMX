using System;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Web.Script.Serialization;
using System.IO.Compression;
using ConsoleApplication1.Models;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro[] listaRegistro;
                 

            //var smn = new ServicioMeteorologicoNacional();
            //var resultado = smn.ObtenerInformacion().GetAwaiter().GetResult();
            //Console.WriteLine("La solicitud regresó un total de {0} registros!", resultado.Count);
            try
            {
                
                string sUrl = "https://smn.cna.gob.mx/webservices/index.php?method=1";
                string Name;
                int numeroDia;
                WebClient client = new WebClient();
                //client.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");

                string str = client.DownloadString(sUrl);
                byte[] resZip = new WebClient().DownloadData(sUrl);
                MemoryStream memory = new MemoryStream(resZip);
                GZipStream ResUnZip = new GZipStream(memory, CompressionMode.Decompress);
                StreamReader reader = new StreamReader(ResUnZip);

                dynamic Res = JsonConvert.DeserializeObject(reader.ReadLine());
                string textojson = Newtonsoft.Json.JsonConvert.SerializeObject(Res);
                //if (textojson.Length != 0)
                
                    JavaScriptSerializer serializer1 = new JavaScriptSerializer();
                    serializer1.MaxJsonLength = 500000000;
                    listaRegistro = serializer1.Deserialize<Registro []>(textojson);

                Console.WriteLine("Bienvenido al Sistema Meteriologico.");
                Console.ReadLine();
                Console.WriteLine("Escriba el nombre de su ciudad.");
                Name=Console.ReadLine();
                Console.WriteLine("Escriba el numero del dia.");
                numeroDia = Convert.ToInt32(Console.ReadLine());


                foreach (var ResFinal in listaRegistro)
                {
                    if (ResFinal.Name == Name && ResFinal.DayNumber==numeroDia) { 
                    Console.WriteLine("\n--------------\nId de la ciudad: " + 
                                        ResFinal.CityId + "\nNombre: " +
                                        ResFinal.Name + "\nAbreviatura: " +
                                        ResFinal.StateAbbr + "\nNúmero del día: " +
                                        ResFinal.DayNumber + "\nFecha UTC: " +
                                        ResFinal.ValidDateUtc + "\nFecha local: " +
                                        ResFinal.LocalValidDate + "\nTemperatura máxima en fahrenheit: " +
                                        ResFinal.HiTempF + "\nTemperatura mínima en fahrenheit: " +
                                        ResFinal.LowTempF + "\nTemperatura máxima en centígrados: " +
                                        ResFinal.HiTempC + "\nTemperatura minima en centrígrados: " +
                                        ResFinal.LowTempC + "\nDescripción del día: " +
                                        ResFinal.PhraseDay + "\nDescripción de la noche: " +
                                        ResFinal.PhraseNight + "\nDescripción del cielo: " +
                                        ResFinal.SkyText + "\nProbabilidad de precipitación(%): " +
                                        ResFinal.ProbabilityOfPrecip + "\nHumedad relativa: " +
                                        ResFinal.RelativeHumidity + "\nVelocidad del viento en millas por hora: " +
                                        ResFinal.WindSpeedMph + "\nVelocidad del viento en kilometros: " +
                                        ResFinal.WindSpeedKm + "\nDirección del viento: " +
                                        ResFinal.WindDirection + "\nDirección del viento en puntos cardinales: " +
                                        ResFinal.WindDirectionCardinal + "\nCovertura de las nubes: " +
                                        ResFinal.CloudCoverage + "\nÍndice Ultravioleta: " +
                                        ResFinal.UvIndex + "\nDescripción de la ultravioleta: " +
                                        ResFinal.UvDescription + "\nCódigo del ícono del día: " +
                                        ResFinal.IconCode + "\nCódigo del ícono de la noche: " +
                                        ResFinal.IconCodeNight + "\nDescripción del cielo por la noche: " +
                                        ResFinal.SkyTextNight + "\nlatitud: " +
                                        ResFinal.Latitude + "\nlongitud: " +
                                        ResFinal.Longitude+ "\n\n");
                        if(ResFinal.CloudCoverage>=0&&ResFinal.CloudCoverage<=2)
                        {
                            Console.WriteLine("Usar Bloqueador solar de 15 fps para proteccion de 80 minutos para piel clara\nUsar Bloqueador solar de 8 fps para proteccion de 110 minutos para piel obscura");
                        }
                        else if (ResFinal.CloudCoverage>=3&&ResFinal.CloudCoverage<=5)
                        {
                            Console.WriteLine("Usar Bloqueador solar de 25 fps para proteccion de 40 minutos para piel clara\nUsar Bloqueador solar de 15 fps para proteccion de 60 minutos para piel obscura");
                        }
                        else if (ResFinal.CloudCoverage >= 6 && ResFinal.CloudCoverage <= 7)
                        {
                            Console.WriteLine("Usar Bloqueador solar de 30 fps para proteccion de 25 minutos para piel clara\nUsar Bloqueador solar de 25 fps para proteccion de 35 minutos para piel obscura");
                        }
                        else if (ResFinal.CloudCoverage >= 8 && ResFinal.CloudCoverage <= 10)
                        {
                            Console.WriteLine("Usar Bloqueador solar de 50+ fps para proteccion de 20 minutos para piel clara\nUsar Bloqueador solar de 30 fps para proteccion de 30 minutos para piel obscura");
                        }
                        else if (ResFinal.CloudCoverage >= 11)
                        {
                            Console.WriteLine("Usar Bloqueador solar de 50+ fps para proteccion de 15 minutos para piel clara\nUsar Bloqueador solar de 50+ fps para proteccion de 25 minutos para piel obscura");
                        }


                    }
                        
                }

                reader.Close();

                Console.ReadLine();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
