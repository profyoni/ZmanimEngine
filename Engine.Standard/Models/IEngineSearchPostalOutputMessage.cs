// <copyright file="IEngineSearchPostalOutputMessage.cs" company="APIMatic">
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
    /// IEngineSearchPostalOutputMessage.
    /// </summary>
    [XmlRootAttribute("IEngine_SearchPostal_OutputMessage")]
    public class IEngineSearchPostalOutputMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineSearchPostalOutputMessage"/> class.
        /// </summary>
        public IEngineSearchPostalOutputMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineSearchPostalOutputMessage"/> class.
        /// </summary>
        /// <param name="searchPostalResponse">SearchPostalResponse.</param>
        public IEngineSearchPostalOutputMessage(
            Models.TnsSearchPostalResponse searchPostalResponse)
        {
            this.SearchPostalResponse = searchPostalResponse;
        }

        /// <summary>
        /// Gets or sets SearchPostalResponse.
        /// </summary>
        [JsonProperty("SearchPostalResponse")]
        [XmlElement("SearchPostalResponse")]
        public Models.TnsSearchPostalResponse SearchPostalResponse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IEngineSearchPostalOutputMessage : ({string.Join(", ", toStringOutput)})";
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

            return obj is IEngineSearchPostalOutputMessage other &&
                ((this.SearchPostalResponse == null && other.SearchPostalResponse == null) || (this.SearchPostalResponse?.Equals(other.SearchPostalResponse) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SearchPostalResponse = {(this.SearchPostalResponse == null ? "null" : this.SearchPostalResponse.ToString())}");
        }
    }
}