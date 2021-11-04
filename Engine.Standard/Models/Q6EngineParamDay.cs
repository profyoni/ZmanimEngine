// <copyright file="Q6EngineParamDay.cs" company="APIMatic">
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
    /// Q6EngineParamDay.
    /// </summary>
    [XmlRootAttribute("Engine.ParamDay")]
    public class Q6EngineParamDay : IXmlSerializable
    {
        private string coding;
        private string key;
        private string language;
        private string locationID;
        private string user;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Coding", false },
            { "Key", false },
            { "Language", false },
            { "LocationID", false },
            { "User", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineParamDay"/> class.
        /// </summary>
        public Q6EngineParamDay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineParamDay"/> class.
        /// </summary>
        /// <param name="coding">Coding.</param>
        /// <param name="inputDate">InputDate.</param>
        /// <param name="key">Key.</param>
        /// <param name="language">Language.</param>
        /// <param name="locationID">LocationID.</param>
        /// <param name="user">User.</param>
        public Q6EngineParamDay(
            string coding = null,
            DateTime? inputDate = null,
            string key = null,
            string language = null,
            string locationID = null,
            string user = null)
        {
            if (coding != null)
            {
                this.Coding = coding;
            }

            this.InputDate = inputDate;
            if (key != null)
            {
                this.Key = key;
            }

            if (language != null)
            {
                this.Language = language;
            }

            if (locationID != null)
            {
                this.LocationID = locationID;
            }

            if (user != null)
            {
                this.User = user;
            }

        }

        /// <summary>
        /// Gets or sets Coding.
        /// </summary>
        [JsonProperty("Coding")]
        [XmlElement("Coding")]
        public string Coding
        {
            get
            {
                return this.coding;
            }

            set
            {
                this.shouldSerialize["Coding"] = true;
                this.coding = value;
            }
        }

        /// <summary>
        /// Gets or sets InputDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("InputDate", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("InputDate")]
        public DateTime? InputDate { get; set; }

        /// <summary>
        /// Gets or sets Key.
        /// </summary>
        [JsonProperty("Key")]
        [XmlElement("Key")]
        public string Key
        {
            get
            {
                return this.key;
            }

            set
            {
                this.shouldSerialize["Key"] = true;
                this.key = value;
            }
        }

        /// <summary>
        /// Gets or sets Language.
        /// </summary>
        [JsonProperty("Language")]
        [XmlElement("Language")]
        public string Language
        {
            get
            {
                return this.language;
            }

            set
            {
                this.shouldSerialize["Language"] = true;
                this.language = value;
            }
        }

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
        /// Gets or sets User.
        /// </summary>
        [JsonProperty("User")]
        [XmlElement("User")]
        public string User
        {
            get
            {
                return this.user;
            }

            set
            {
                this.shouldSerialize["User"] = true;
                this.user = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Q6EngineParamDay : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCoding()
        {
            this.shouldSerialize["Coding"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetKey()
        {
            this.shouldSerialize["Key"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLanguage()
        {
            this.shouldSerialize["Language"] = false;
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
        public void UnsetUser()
        {
            this.shouldSerialize["User"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCoding()
        {
            return this.shouldSerialize["Coding"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeKey()
        {
            return this.shouldSerialize["Key"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLanguage()
        {
            return this.shouldSerialize["Language"];
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
        public bool ShouldSerializeUser()
        {
            return this.shouldSerialize["User"];
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

            return obj is Q6EngineParamDay other &&
                ((this.Coding == null && other.Coding == null) || (this.Coding?.Equals(other.Coding) == true)) &&
                ((this.InputDate == null && other.InputDate == null) || (this.InputDate?.Equals(other.InputDate) == true)) &&
                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true)) &&
                ((this.Language == null && other.Language == null) || (this.Language?.Equals(other.Language) == true)) &&
                ((this.LocationID == null && other.LocationID == null) || (this.LocationID?.Equals(other.LocationID) == true)) &&
                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Coding = {(this.Coding == null ? "null" : this.Coding == string.Empty ? "" : this.Coding)}");
            toStringOutput.Add($"this.InputDate = {(this.InputDate == null ? "null" : this.InputDate.ToString())}");
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key == string.Empty ? "" : this.Key)}");
            toStringOutput.Add($"this.Language = {(this.Language == null ? "null" : this.Language == string.Empty ? "" : this.Language)}");
            toStringOutput.Add($"this.LocationID = {(this.LocationID == null ? "null" : this.LocationID == string.Empty ? "" : this.LocationID)}");
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User == string.Empty ? "" : this.User)}");
        }

        /// <summary>
        /// Creates a new class instance from the given XDocument.
        /// </summary>
        /// <param name="xDoc">The xDocument.</param>
        /// <returns>A new class instance.</returns>
        public static Q6EngineParamDay FromXml(XDocument xDoc)
        {
            var coding = (string)xDoc.Root.Element("Coding");
            var inputDate = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("InputDate").Value).GetValueOrDefault();
            var key = (string)xDoc.Root.Element("Key");
            var language = (string)xDoc.Root.Element("Language");
            var locationID = (string)xDoc.Root.Element("LocationID");
            var user = (string)xDoc.Root.Element("User");
            return new Q6EngineParamDay(//shouldSerialize,
                coding,
                inputDate,
                key,
                language,
                locationID,
                user);
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
            if (this.Coding != null)
            {
                writer.WriteElementString("Coding", this.Coding);
            }

            if (this.InputDate != null)
            {
                writer.WriteElementString("InputDate", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.InputDate));
            }

            if (this.Key != null)
            {
                writer.WriteElementString("Key", this.Key);
            }

            if (this.Language != null)
            {
                writer.WriteElementString("Language", this.Language);
            }

            if (this.LocationID != null)
            {
                writer.WriteElementString("LocationID", this.LocationID);
            }

            if (this.User != null)
            {
                writer.WriteElementString("User", this.User);
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

            this.Coding = obj.Coding;
            this.InputDate = obj.InputDate;
            this.Key = obj.Key;
            this.Language = obj.Language;
            this.LocationID = obj.LocationID;
            this.User = obj.User;
        }
    }
}