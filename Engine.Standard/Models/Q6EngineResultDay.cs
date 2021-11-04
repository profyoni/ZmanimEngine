// <copyright file="Q6EngineResultDay.cs" company="APIMatic">
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
    using System.Xml.Serialization;
    using Engine.Standard;
    using Engine.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Q6EngineResultDay.
    /// </summary>
    [XmlRootAttribute("Engine.ResultDay")]
    public class Q6EngineResultDay
    {
        private string copyright;
        private string errMsg;
        private string html;
        private string lang;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Copyright", false },
            { "ErrMsg", false },
            { "Html", false },
            { "Lang", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineResultDay"/> class.
        /// </summary>
        public Q6EngineResultDay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineResultDay"/> class.
        /// </summary>
        /// <param name="copyright">Copyright.</param>
        /// <param name="errMsg">ErrMsg.</param>
        /// <param name="html">Html.</param>
        /// <param name="lang">Lang.</param>
        /// <param name="place">Place.</param>
        /// <param name="time">Time.</param>
        /// <param name="zman">Zman.</param>
        public Q6EngineResultDay(
            string copyright = null,
            string errMsg = null,
            string html = null,
            string lang = null,
            Models.Q6EngineLocationInfo place = null,
            Models.Q6EngineDateInfo time = null,
            Models.Q6ZmnType zman = null)
        {
            if (copyright != null)
            {
                this.Copyright = copyright;
            }

            if (errMsg != null)
            {
                this.ErrMsg = errMsg;
            }

            if (html != null)
            {
                this.Html = html;
            }

            if (lang != null)
            {
                this.Lang = lang;
            }

            this.Place = place;
            this.Time = time;
            this.Zman = zman;
        }

        /// <summary>
        /// Gets or sets Copyright.
        /// </summary>
        [JsonProperty("Copyright")]
        [XmlElement("Copyright")]
        public string Copyright
        {
            get
            {
                return this.copyright;
            }

            set
            {
                this.shouldSerialize["Copyright"] = true;
                this.copyright = value;
            }
        }

        /// <summary>
        /// Gets or sets ErrMsg.
        /// </summary>
        [JsonProperty("ErrMsg")]
        [XmlElement("ErrMsg")]
        public string ErrMsg
        {
            get
            {
                return this.errMsg;
            }

            set
            {
                this.shouldSerialize["ErrMsg"] = true;
                this.errMsg = value;
            }
        }

        /// <summary>
        /// Gets or sets Html.
        /// </summary>
        [JsonProperty("Html")]
        [XmlElement("Html")]
        public string Html
        {
            get
            {
                return this.html;
            }

            set
            {
                this.shouldSerialize["Html"] = true;
                this.html = value;
            }
        }

        /// <summary>
        /// Gets or sets Lang.
        /// </summary>
        [JsonProperty("Lang")]
        [XmlElement("Lang")]
        public string Lang
        {
            get
            {
                return this.lang;
            }

            set
            {
                this.shouldSerialize["Lang"] = true;
                this.lang = value;
            }
        }

        /// <summary>
        /// Gets or sets Place.
        /// </summary>
        [JsonProperty("Place", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Place")]
        public Models.Q6EngineLocationInfo Place { get; set; }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [JsonProperty("Time", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Time")]
        public Models.Q6EngineDateInfo Time { get; set; }

        /// <summary>
        /// Gets or sets Zman.
        /// </summary>
        [JsonProperty("Zman", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Zman")]
        public Models.Q6ZmnType Zman { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Q6EngineResultDay : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCopyright()
        {
            this.shouldSerialize["Copyright"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrMsg()
        {
            this.shouldSerialize["ErrMsg"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHtml()
        {
            this.shouldSerialize["Html"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLang()
        {
            this.shouldSerialize["Lang"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCopyright()
        {
            return this.shouldSerialize["Copyright"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrMsg()
        {
            return this.shouldSerialize["ErrMsg"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHtml()
        {
            return this.shouldSerialize["Html"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLang()
        {
            return this.shouldSerialize["Lang"];
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

            return obj is Q6EngineResultDay other &&
                ((this.Copyright == null && other.Copyright == null) || (this.Copyright?.Equals(other.Copyright) == true)) &&
                ((this.ErrMsg == null && other.ErrMsg == null) || (this.ErrMsg?.Equals(other.ErrMsg) == true)) &&
                ((this.Html == null && other.Html == null) || (this.Html?.Equals(other.Html) == true)) &&
                ((this.Lang == null && other.Lang == null) || (this.Lang?.Equals(other.Lang) == true)) &&
                ((this.Place == null && other.Place == null) || (this.Place?.Equals(other.Place) == true)) &&
                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                ((this.Zman == null && other.Zman == null) || (this.Zman?.Equals(other.Zman) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Copyright = {(this.Copyright == null ? "null" : this.Copyright == string.Empty ? "" : this.Copyright)}");
            toStringOutput.Add($"this.ErrMsg = {(this.ErrMsg == null ? "null" : this.ErrMsg == string.Empty ? "" : this.ErrMsg)}");
            toStringOutput.Add($"this.Html = {(this.Html == null ? "null" : this.Html == string.Empty ? "" : this.Html)}");
            toStringOutput.Add($"this.Lang = {(this.Lang == null ? "null" : this.Lang == string.Empty ? "" : this.Lang)}");
            toStringOutput.Add($"this.Place = {(this.Place == null ? "null" : this.Place.ToString())}");
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time.ToString())}");
            toStringOutput.Add($"this.Zman = {(this.Zman == null ? "null" : this.Zman.ToString())}");
        }
    }
}