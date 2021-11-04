// <copyright file="TnsSearchGpsResponse.cs" company="APIMatic">
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
    /// TnsSearchGpsResponse.
    /// </summary>
    [XmlRootAttribute("SearchGpsResponse")]
    public class TnsSearchGpsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TnsSearchGpsResponse"/> class.
        /// </summary>
        public TnsSearchGpsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TnsSearchGpsResponse"/> class.
        /// </summary>
        /// <param name="searchGpsResult">SearchGpsResult.</param>
        public TnsSearchGpsResponse(
            Models.Q6EngineResultGps searchGpsResult = null)
        {
            this.SearchGpsResult = searchGpsResult;
        }

        /// <summary>
        /// Gets or sets SearchGpsResult.
        /// </summary>
        [JsonProperty("SearchGpsResult", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SearchGpsResult")]
        public Models.Q6EngineResultGps SearchGpsResult { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TnsSearchGpsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is TnsSearchGpsResponse other &&
                ((this.SearchGpsResult == null && other.SearchGpsResult == null) || (this.SearchGpsResult?.Equals(other.SearchGpsResult) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SearchGpsResult = {(this.SearchGpsResult == null ? "null" : this.SearchGpsResult.ToString())}");
        }
    }
}