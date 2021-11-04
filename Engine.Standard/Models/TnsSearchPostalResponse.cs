// <copyright file="TnsSearchPostalResponse.cs" company="APIMatic">
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
    /// TnsSearchPostalResponse.
    /// </summary>
    [XmlRootAttribute("SearchPostalResponse")]
    public class TnsSearchPostalResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TnsSearchPostalResponse"/> class.
        /// </summary>
        public TnsSearchPostalResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TnsSearchPostalResponse"/> class.
        /// </summary>
        /// <param name="searchPostalResult">SearchPostalResult.</param>
        public TnsSearchPostalResponse(
            Models.Q6EngineResultPostal searchPostalResult = null)
        {
            this.SearchPostalResult = searchPostalResult;
        }

        /// <summary>
        /// Gets or sets SearchPostalResult.
        /// </summary>
        [JsonProperty("SearchPostalResult", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SearchPostalResult")]
        public Models.Q6EngineResultPostal SearchPostalResult { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TnsSearchPostalResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is TnsSearchPostalResponse other &&
                ((this.SearchPostalResult == null && other.SearchPostalResult == null) || (this.SearchPostalResult?.Equals(other.SearchPostalResult) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SearchPostalResult = {(this.SearchPostalResult == null ? "null" : this.SearchPostalResult.ToString())}");
        }
    }
}