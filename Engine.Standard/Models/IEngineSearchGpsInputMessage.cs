// <copyright file="IEngineSearchGpsInputMessage.cs" company="APIMatic">
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
    /// IEngineSearchGpsInputMessage.
    /// </summary>
    [XmlRootAttribute("IEngine_SearchGps_InputMessage")]
    public class IEngineSearchGpsInputMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineSearchGpsInputMessage"/> class.
        /// </summary>
        public IEngineSearchGpsInputMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineSearchGpsInputMessage"/> class.
        /// </summary>
        /// <param name="searchGps">SearchGps.</param>
        public IEngineSearchGpsInputMessage(
            Models.TnsSearchGps searchGps)
        {
            this.SearchGps = searchGps;
        }

        /// <summary>
        /// Gets or sets SearchGps.
        /// </summary>
        [JsonProperty("SearchGps")]
        [XmlElement("SearchGps")]
        public Models.TnsSearchGps SearchGps { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IEngineSearchGpsInputMessage : ({string.Join(", ", toStringOutput)})";
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

            return obj is IEngineSearchGpsInputMessage other &&
                ((this.SearchGps == null && other.SearchGps == null) || (this.SearchGps?.Equals(other.SearchGps) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SearchGps = {(this.SearchGps == null ? "null" : this.SearchGps.ToString())}");
        }
    }
}