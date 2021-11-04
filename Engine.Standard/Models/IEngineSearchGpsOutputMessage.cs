// <copyright file="IEngineSearchGpsOutputMessage.cs" company="APIMatic">
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
    /// IEngineSearchGpsOutputMessage.
    /// </summary>
    [XmlRootAttribute("IEngine_SearchGps_OutputMessage")]
    public class IEngineSearchGpsOutputMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineSearchGpsOutputMessage"/> class.
        /// </summary>
        public IEngineSearchGpsOutputMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineSearchGpsOutputMessage"/> class.
        /// </summary>
        /// <param name="searchGpsResponse">SearchGpsResponse.</param>
        public IEngineSearchGpsOutputMessage(
            Models.TnsSearchGpsResponse searchGpsResponse)
        {
            this.SearchGpsResponse = searchGpsResponse;
        }

        /// <summary>
        /// Gets or sets SearchGpsResponse.
        /// </summary>
        [JsonProperty("SearchGpsResponse")]
        [XmlElement("SearchGpsResponse")]
        public Models.TnsSearchGpsResponse SearchGpsResponse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IEngineSearchGpsOutputMessage : ({string.Join(", ", toStringOutput)})";
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

            return obj is IEngineSearchGpsOutputMessage other &&
                ((this.SearchGpsResponse == null && other.SearchGpsResponse == null) || (this.SearchGpsResponse?.Equals(other.SearchGpsResponse) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SearchGpsResponse = {(this.SearchGpsResponse == null ? "null" : this.SearchGpsResponse.ToString())}");
        }
    }
}