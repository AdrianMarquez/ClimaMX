using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

using System.Web;

using System.Net;

namespace ConsoleApplication1.Models
{
    //[DataContract]
    public class Registro
    {
     //   [DataMember(Name = "CityId")]
        public String CityId { get; set; }
        //[DataMember(Name = "Name")]
        public String Name { get; set; }
        //[DataMember(Name = "StateAbbr")]
        public String StateAbbr { get; set; }
        //[DataMember(Name = "DayNumber")]
        public Int32 DayNumber { get; set; }
        //[DataMember(Name = "ValidDateUtc")]
        public String ValidDateUtc { get; set; }
        //[DataMember(Name = "LocalValidDate")]
        public String LocalValidDate { get; set; }
        //[DataMember(Name = "HiTempF")]
        public Double HiTempF { get; set; }
        //[DataMember(Name = "LowTempF")]
        public Double LowTempF { get; set; }
        //[DataMember(Name = "HiTempC")]
        public Double HiTempC { get; set; }
        //[DataMember(Name = "LowTempC")]
        public Double LowTempC { get; set; }
        //[DataMember(Name = "PhraseDay")]
        public String PhraseDay { get; set; }
        //[DataMember(Name = "PhraseNight")]
        public String PhraseNight { get; set; }
        //[DataMember(Name = "SkyText")]
        public String SkyText { get; set; }
        //[DataMember(Name = "ProbabilityOfPrecip")]
        public Int32 ProbabilityOfPrecip { get; set; }
        //[DataMember(Name = "RelativeHumidity")]
        public Double RelativeHumidity { get; set; }
        //[DataMember(Name = "WindSpeedMph")]
        public Double WindSpeedMph { get; set; }
        //[DataMember(Name = "WindSpeedKm")]
        public Double WindSpeedKm { get; set; }
        //[DataMember(Name = "WindDirection")]
        public Int32 WindDirection { get; set; }
        //[DataMember(Name = "WindDirectionCardinal")]
        public String WindDirectionCardinal { get; set; }
        //[DataMember(Name = "CloudCoverage")]
        public Int32 CloudCoverage { get; set; }
        //[DataMember(Name = "UvIndex")]
        public Int32 UvIndex { get; set; }
        //[DataMember(Name = "UvDescription")]
        public String UvDescription { get; set; }
        //[DataMember(Name = "IconCode")]
        public Int32 IconCode { get; set; }
        //[DataMember(Name = "IconCodeNight")]
        public Int32 IconCodeNight { get; set; }
        //[DataMember(Name = "SkyTextNight")]
        public String SkyTextNight { get; set; }
        //[DataMember(Name = "Latitud")]
        public Double Latitude { get; set; }
        //[DataMember(Name = "Longitud")]
        public Double Longitude { get; set; }

        public List<Registro> datos { get; set; }
    }
}
