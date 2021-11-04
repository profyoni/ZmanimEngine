// <copyright file="Q6EngineLocationInfo.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Engine.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    using Engine.Standard;
    using Engine.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Q6EngineLocationInfo.
    /// </summary>
    [XmlRootAttribute("Engine.LocationInfo")]
    public class Q6EngineLocationInfo : IXmlSerializable
    {
        private string airportCode;
        private string city;
        private string cityHebrew;
        private string country;
        private string county;
        private string locationID;
        private string name;
        private string nameHtml;
        private string nameShort;
        private string observesDST;
        private string postalCode;
        private string state;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AirportCode", false },
            { "City", false },
            { "CityHebrew", false },
            { "Country", false },
            { "County", false },
            { "LocationID", false },
            { "Name", false },
            { "NameHtml", false },
            { "NameShort", false },
            { "ObservesDST", false },
            { "PostalCode", false },
            { "State", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineLocationInfo"/> class.
        /// </summary>
        public Q6EngineLocationInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineLocationInfo"/> class.
        /// </summary>
        /// <param name="airportCode">AirportCode.</param>
        /// <param name="candlelightingMinutes">CandlelightingMinutes.</param>
        /// <param name="city">City.</param>
        /// <param name="cityHebrew">CityHebrew.</param>
        /// <param name="country">Country.</param>
        /// <param name="county">County.</param>
        /// <param name="currentTime">CurrentTime.</param>
        /// <param name="davenDirectionGC">DavenDirectionGC.</param>
        /// <param name="davenDirectionRL">DavenDirectionRL.</param>
        /// <param name="elevationEast">ElevationEast.</param>
        /// <param name="elevationObserver">ElevationObserver.</param>
        /// <param name="elevationWest">ElevationWest.</param>
        /// <param name="locationID">LocationID.</param>
        /// <param name="name">Name.</param>
        /// <param name="nameHtml">NameHtml.</param>
        /// <param name="nameShort">NameShort.</param>
        /// <param name="observesDST">ObservesDST.</param>
        /// <param name="postalCode">PostalCode.</param>
        /// <param name="state">State.</param>
        /// <param name="yakirDegreesDefault">YakirDegreesDefault.</param>
        public Q6EngineLocationInfo(
            string airportCode = null,
            int? candlelightingMinutes = null,
            string city = null,
            string cityHebrew = null,
            string country = null,
            string county = null,
            DateTime? currentTime = null,
            int? davenDirectionGC = null,
            int? davenDirectionRL = null,
            int? elevationEast = null,
            int? elevationObserver = null,
            int? elevationWest = null,
            string locationID = null,
            string name = null,
            string nameHtml = null,
            string nameShort = null,
            string observesDST = null,
            string postalCode = null,
            string state = null,
            double? yakirDegreesDefault = null)
        {
            if (airportCode != null)
            {
                this.AirportCode = airportCode;
            }

            this.CandlelightingMinutes = candlelightingMinutes;
            if (city != null)
            {
                this.City = city;
            }

            if (cityHebrew != null)
            {
                this.CityHebrew = cityHebrew;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (county != null)
            {
                this.County = county;
            }

            this.CurrentTime = currentTime;
            this.DavenDirectionGC = davenDirectionGC;
            this.DavenDirectionRL = davenDirectionRL;
            this.ElevationEast = elevationEast;
            this.ElevationObserver = elevationObserver;
            this.ElevationWest = elevationWest;
            if (locationID != null)
            {
                this.LocationID = locationID;
            }

            if (name != null)
            {
                this.Name = name;
            }

            if (nameHtml != null)
            {
                this.NameHtml = nameHtml;
            }

            if (nameShort != null)
            {
                this.NameShort = nameShort;
            }

            if (observesDST != null)
            {
                this.ObservesDST = observesDST;
            }

            if (postalCode != null)
            {
                this.PostalCode = postalCode;
            }

            if (state != null)
            {
                this.State = state;
            }

            this.YakirDegreesDefault = yakirDegreesDefault;
        }

        /// <summary>
        /// Gets or sets AirportCode.
        /// </summary>
        [JsonProperty("AirportCode")]
        [XmlElement("AirportCode")]
        public string AirportCode
        {
            get
            {
                return this.airportCode;
            }

            set
            {
                this.shouldSerialize["AirportCode"] = true;
                this.airportCode = value;
            }
        }

        /// <summary>
        /// Gets or sets CandlelightingMinutes.
        /// </summary>
        [JsonProperty("CandlelightingMinutes", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("CandlelightingMinutes")]
        public int? CandlelightingMinutes { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("City")]
        [XmlElement("City")]
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.shouldSerialize["City"] = true;
                this.city = value;
            }
        }

        /// <summary>
        /// Gets or sets CityHebrew.
        /// </summary>
        [JsonProperty("CityHebrew")]
        [XmlElement("CityHebrew")]
        public string CityHebrew
        {
            get
            {
                return this.cityHebrew;
            }

            set
            {
                this.shouldSerialize["CityHebrew"] = true;
                this.cityHebrew = value;
            }
        }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("Country")]
        [XmlElement("Country")]
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.shouldSerialize["Country"] = true;
                this.country = value;
            }
        }

        /// <summary>
        /// Gets or sets County.
        /// </summary>
        [JsonProperty("County")]
        [XmlElement("County")]
        public string County
        {
            get
            {
                return this.county;
            }

            set
            {
                this.shouldSerialize["County"] = true;
                this.county = value;
            }
        }

        /// <summary>
        /// Gets or sets CurrentTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("CurrentTime", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("CurrentTime")]
        public DateTime? CurrentTime { get; set; }

        /// <summary>
        /// Gets or sets DavenDirectionGC.
        /// </summary>
        [JsonProperty("DavenDirectionGC", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("DavenDirectionGC")]
        public int? DavenDirectionGC { get; set; }

        /// <summary>
        /// Gets or sets DavenDirectionRL.
        /// </summary>
        [JsonProperty("DavenDirectionRL", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("DavenDirectionRL")]
        public int? DavenDirectionRL { get; set; }

        /// <summary>
        /// Gets or sets ElevationEast.
        /// </summary>
        [JsonProperty("ElevationEast", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ElevationEast")]
        public int? ElevationEast { get; set; }

        /// <summary>
        /// Gets or sets ElevationObserver.
        /// </summary>
        [JsonProperty("ElevationObserver", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ElevationObserver")]
        public int? ElevationObserver { get; set; }

        /// <summary>
        /// Gets or sets ElevationWest.
        /// </summary>
        [JsonProperty("ElevationWest", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ElevationWest")]
        public int? ElevationWest { get; set; }

        /// <summary>
        /// Gets or sets LocationID.
        /// </summary>
        [JsonProperty("LocationID")]
        [XmlElement("LocationID")]
        public string LocationID
        {
            get
            {
                return this.locationID;
            }

            set
            {
                this.shouldSerialize["LocationID"] = true;
                this.locationID = value;
            }
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("Name")]
        [XmlElement("Name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["Name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets NameHtml.
        /// </summary>
        [JsonProperty("NameHtml")]
        [XmlElement("NameHtml")]
        public string NameHtml
        {
            get
            {
                return this.nameHtml;
            }

            set
            {
                this.shouldSerialize["NameHtml"] = true;
                this.nameHtml = value;
            }
        }

        /// <summary>
        /// Gets or sets NameShort.
        /// </summary>
        [JsonProperty("NameShort")]
        [XmlElement("NameShort")]
        public string NameShort
        {
            get
            {
                return this.nameShort;
            }

            set
            {
                this.shouldSerialize["NameShort"] = true;
                this.nameShort = value;
            }
        }

        /// <summary>
        /// Gets or sets ObservesDST.
        /// </summary>
        [JsonProperty("ObservesDST")]
        [XmlElement("ObservesDST")]
        public string ObservesDST
        {
            get
            {
                return this.observesDST;
            }

            set
            {
                this.shouldSerialize["ObservesDST"] = true;
                this.observesDST = value;
            }
        }

        /// <summary>
        /// Gets or sets PostalCode.
        /// </summary>
        [JsonProperty("PostalCode")]
        [XmlElement("PostalCode")]
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }

            set
            {
                this.shouldSerialize["PostalCode"] = true;
                this.postalCode = value;
            }
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("State")]
        [XmlElement("State")]
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.shouldSerialize["State"] = true;
                this.state = value;
            }
        }

        /// <summary>
        /// Gets or sets YakirDegreesDefault.
        /// </summary>
        [JsonProperty("YakirDegreesDefault", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("YakirDegreesDefault")]
        public double? YakirDegreesDefault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Q6EngineLocationInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAirportCode()
        {
            this.shouldSerialize["AirportCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCity()
        {
            this.shouldSerialize["City"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCityHebrew()
        {
            this.shouldSerialize["CityHebrew"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["Country"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCounty()
        {
            this.shouldSerialize["County"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationID()
        {
            this.shouldSerialize["LocationID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["Name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNameHtml()
        {
            this.shouldSerialize["NameHtml"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNameShort()
        {
            this.shouldSerialize["NameShort"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetObservesDST()
        {
            this.shouldSerialize["ObservesDST"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPostalCode()
        {
            this.shouldSerialize["PostalCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetState()
        {
            this.shouldSerialize["State"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAirportCode()
        {
            return this.shouldSerialize["AirportCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCity()
        {
            return this.shouldSerialize["City"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCityHebrew()
        {
            return this.shouldSerialize["CityHebrew"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountry()
        {
            return this.shouldSerialize["Country"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCounty()
        {
            return this.shouldSerialize["County"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationID()
        {
            return this.shouldSerialize["LocationID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["Name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNameHtml()
        {
            return this.shouldSerialize["NameHtml"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNameShort()
        {
            return this.shouldSerialize["NameShort"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeObservesDST()
        {
            return this.shouldSerialize["ObservesDST"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePostalCode()
        {
            return this.shouldSerialize["PostalCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeState()
        {
            return this.shouldSerialize["State"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is Q6EngineLocationInfo other &&
                ((this.AirportCode == null && other.AirportCode == null) || (this.AirportCode?.Equals(other.AirportCode) == true)) &&
                ((this.CandlelightingMinutes == null && other.CandlelightingMinutes == null) || (this.CandlelightingMinutes?.Equals(other.CandlelightingMinutes) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.CityHebrew == null && other.CityHebrew == null) || (this.CityHebrew?.Equals(other.CityHebrew) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.County == null && other.County == null) || (this.County?.Equals(other.County) == true)) &&
                ((this.CurrentTime == null && other.CurrentTime == null) || (this.CurrentTime?.Equals(other.CurrentTime) == true)) &&
                ((this.DavenDirectionGC == null && other.DavenDirectionGC == null) || (this.DavenDirectionGC?.Equals(other.DavenDirectionGC) == true)) &&
                ((this.DavenDirectionRL == null && other.DavenDirectionRL == null) || (this.DavenDirectionRL?.Equals(other.DavenDirectionRL) == true)) &&
                ((this.ElevationEast == null && other.ElevationEast == null) || (this.ElevationEast?.Equals(other.ElevationEast) == true)) &&
                ((this.ElevationObserver == null && other.ElevationObserver == null) || (this.ElevationObserver?.Equals(other.ElevationObserver) == true)) &&
                ((this.ElevationWest == null && other.ElevationWest == null) || (this.ElevationWest?.Equals(other.ElevationWest) == true)) &&
                ((this.LocationID == null && other.LocationID == null) || (this.LocationID?.Equals(other.LocationID) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.NameHtml == null && other.NameHtml == null) || (this.NameHtml?.Equals(other.NameHtml) == true)) &&
                ((this.NameShort == null && other.NameShort == null) || (this.NameShort?.Equals(other.NameShort) == true)) &&
                ((this.ObservesDST == null && other.ObservesDST == null) || (this.ObservesDST?.Equals(other.ObservesDST) == true)) &&
                ((this.PostalCode == null && other.PostalCode == null) || (this.PostalCode?.Equals(other.PostalCode) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.YakirDegreesDefault == null && other.YakirDegreesDefault == null) || (this.YakirDegreesDefault?.Equals(other.YakirDegreesDefault) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AirportCode = {(this.AirportCode == null ? "null" : this.AirportCode == string.Empty ? "" : this.AirportCode)}");
            toStringOutput.Add($"this.CandlelightingMinutes = {(this.CandlelightingMinutes == null ? "null" : this.CandlelightingMinutes.ToString())}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City == string.Empty ? "" : this.City)}");
            toStringOutput.Add($"this.CityHebrew = {(this.CityHebrew == null ? "null" : this.CityHebrew == string.Empty ? "" : this.CityHebrew)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country == string.Empty ? "" : this.Country)}");
            toStringOutput.Add($"this.County = {(this.County == null ? "null" : this.County == string.Empty ? "" : this.County)}");
            toStringOutput.Add($"this.CurrentTime = {(this.CurrentTime == null ? "null" : this.CurrentTime.ToString())}");
            toStringOutput.Add($"this.DavenDirectionGC = {(this.DavenDirectionGC == null ? "null" : this.DavenDirectionGC.ToString())}");
            toStringOutput.Add($"this.DavenDirectionRL = {(this.DavenDirectionRL == null ? "null" : this.DavenDirectionRL.ToString())}");
            toStringOutput.Add($"this.ElevationEast = {(this.ElevationEast == null ? "null" : this.ElevationEast.ToString())}");
            toStringOutput.Add($"this.ElevationObserver = {(this.ElevationObserver == null ? "null" : this.ElevationObserver.ToString())}");
            toStringOutput.Add($"this.ElevationWest = {(this.ElevationWest == null ? "null" : this.ElevationWest.ToString())}");
            toStringOutput.Add($"this.LocationID = {(this.LocationID == null ? "null" : this.LocationID == string.Empty ? "" : this.LocationID)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.NameHtml = {(this.NameHtml == null ? "null" : this.NameHtml == string.Empty ? "" : this.NameHtml)}");
            toStringOutput.Add($"this.NameShort = {(this.NameShort == null ? "null" : this.NameShort == string.Empty ? "" : this.NameShort)}");
            toStringOutput.Add($"this.ObservesDST = {(this.ObservesDST == null ? "null" : this.ObservesDST == string.Empty ? "" : this.ObservesDST)}");
            toStringOutput.Add($"this.PostalCode = {(this.PostalCode == null ? "null" : this.PostalCode == string.Empty ? "" : this.PostalCode)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
            toStringOutput.Add($"this.YakirDegreesDefault = {(this.YakirDegreesDefault == null ? "null" : this.YakirDegreesDefault.ToString())}");
        }

        /// <summary>
        /// Creates a new class instance from the given XDocument.
        /// </summary>
        /// <param name="xDoc">The xDocument.</param>
        /// <returns>A new class instance.</returns>
        public static Q6EngineLocationInfo FromXml(XDocument xDoc)
        {
            var airportCode = (string)xDoc.Root.Element("AirportCode");
            var candlelightingMinutes = (int?)xDoc.Root.Element("CandlelightingMinutes");
            var city = (string)xDoc.Root.Element("City");
            var cityHebrew = (string)xDoc.Root.Element("CityHebrew");
            var country = (string)xDoc.Root.Element("Country");
            var county = (string)xDoc.Root.Element("County");
            var currentTime = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("CurrentTime").Value).GetValueOrDefault();
            var davenDirectionGC = (int?)xDoc.Root.Element("DavenDirectionGC");
            var davenDirectionRL = (int?)xDoc.Root.Element("DavenDirectionRL");
            var elevationEast = (int?)xDoc.Root.Element("ElevationEast");
            var elevationObserver = (int?)xDoc.Root.Element("ElevationObserver");
            var elevationWest = (int?)xDoc.Root.Element("ElevationWest");
            var locationID = (string)xDoc.Root.Element("LocationID");
            var name = (string)xDoc.Root.Element("Name");
            var nameHtml = (string)xDoc.Root.Element("NameHtml");
            var nameShort = (string)xDoc.Root.Element("NameShort");
            var observesDST = (string)xDoc.Root.Element("ObservesDST");
            var postalCode = (string)xDoc.Root.Element("PostalCode");
            var state = (string)xDoc.Root.Element("State");
            var yakirDegreesDefault = (double?)xDoc.Root.Element("YakirDegreesDefault");
            return new Q6EngineLocationInfo(//shouldSerialize,
                airportCode,
                candlelightingMinutes,
                city,
                cityHebrew,
                country,
                county,
                currentTime,
                davenDirectionGC,
                davenDirectionRL,
                elevationEast,
                elevationObserver,
                elevationWest,
                locationID,
                name,
                nameHtml,
                nameShort,
                observesDST,
                postalCode,
                state,
                yakirDegreesDefault);
        }

        /// <summary>
        /// Returns xml schema.
        /// </summary>
        /// <returns>Xml schema object.</returns>
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Writes data to the XmlWriter.
        /// </summary>
        /// <param name="writer">XmlWriter object.</param>
        public void WriteXml(XmlWriter writer)
        {
            if (this.AirportCode != null)
            {
                writer.WriteElementString("AirportCode", this.AirportCode);
            }

            if (this.CandlelightingMinutes != null)
            {
                writer.WriteElementString("CandlelightingMinutes", this.CandlelightingMinutes.ToString());
            }

            if (this.City != null)
            {
                writer.WriteElementString("City", this.City);
            }

            if (this.CityHebrew != null)
            {
                writer.WriteElementString("CityHebrew", this.CityHebrew);
            }

            if (this.Country != null)
            {
                writer.WriteElementString("Country", this.Country);
            }

            if (this.County != null)
            {
                writer.WriteElementString("County", this.County);
            }

            if (this.CurrentTime != null)
            {
                writer.WriteElementString("CurrentTime", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.CurrentTime));
            }

            if (this.DavenDirectionGC != null)
            {
                writer.WriteElementString("DavenDirectionGC", this.DavenDirectionGC.ToString());
            }

            if (this.DavenDirectionRL != null)
            {
                writer.WriteElementString("DavenDirectionRL", this.DavenDirectionRL.ToString());
            }

            if (this.ElevationEast != null)
            {
                writer.WriteElementString("ElevationEast", this.ElevationEast.ToString());
            }

            if (this.ElevationObserver != null)
            {
                writer.WriteElementString("ElevationObserver", this.ElevationObserver.ToString());
            }

            if (this.ElevationWest != null)
            {
                writer.WriteElementString("ElevationWest", this.ElevationWest.ToString());
            }

            if (this.LocationID != null)
            {
                writer.WriteElementString("LocationID", this.LocationID);
            }

            if (this.Name != null)
            {
                writer.WriteElementString("Name", this.Name);
            }

            if (this.NameHtml != null)
            {
                writer.WriteElementString("NameHtml", this.NameHtml);
            }

            if (this.NameShort != null)
            {
                writer.WriteElementString("NameShort", this.NameShort);
            }

            if (this.ObservesDST != null)
            {
                writer.WriteElementString("ObservesDST", this.ObservesDST);
            }

            if (this.PostalCode != null)
            {
                writer.WriteElementString("PostalCode", this.PostalCode);
            }

            if (this.State != null)
            {
                writer.WriteElementString("State", this.State);
            }

            if (this.YakirDegreesDefault != null)
            {
                writer.WriteElementString("YakirDegreesDefault", this.YakirDegreesDefault.ToString());
            }
        }

        /// <summary>
        /// Loads values from the given XmlReader object.
        /// </summary>
        /// <param name="reader">XmlReader object.</param>
        public void ReadXml(XmlReader reader)
        {
            var xmlStr = reader.ReadOuterXml();
            XDocument xDoc = XDocument.Parse(xmlStr);
            var obj = FromXml(xDoc);

            this.AirportCode = obj.AirportCode;
            this.CandlelightingMinutes = obj.CandlelightingMinutes;
            this.City = obj.City;
            this.CityHebrew = obj.CityHebrew;
            this.Country = obj.Country;
            this.County = obj.County;
            this.CurrentTime = obj.CurrentTime;
            this.DavenDirectionGC = obj.DavenDirectionGC;
            this.DavenDirectionRL = obj.DavenDirectionRL;
            this.ElevationEast = obj.ElevationEast;
            this.ElevationObserver = obj.ElevationObserver;
            this.ElevationWest = obj.ElevationWest;
            this.LocationID = obj.LocationID;
            this.Name = obj.Name;
            this.NameHtml = obj.NameHtml;
            this.NameShort = obj.NameShort;
            this.ObservesDST = obj.ObservesDST;
            this.PostalCode = obj.PostalCode;
            this.State = obj.State;
            this.YakirDegreesDefault = obj.YakirDegreesDefault;
        }
    }
}