// <copyright file="IEngineSearchPostalInputMessage.cs" company="APIMatic">
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
    /// IEngineSearchPostalInputMessage.
    /// </summary>
    [XmlRootAttribute("IEngine_SearchPostal_InputMessage")]
    public class IEngineSearchPostalInputMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineSearchPostalInputMessage"/> class.
        /// </summary>
        public IEngineSearchPostalInputMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineSearchPostalInputMessage"/> class.
        /// </summary>
        /// <param name="searchPostal">SearchPostal.</param>
        public IEngineSearchPostalInputMessage(
            Models.TnsSearchPostal searchPostal)
        {
            this.SearchPostal = searchPostal;
        }

        /// <summary>
        /// Gets or sets SearchPostal.
        /// </summary>
        [JsonProperty("SearchPostal")]
        [XmlElement("SearchPostal")]
        public Models.TnsSearchPostal SearchPostal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IEngineSearchPostalInputMessage : ({string.Join(", ", toStringOutput)})";
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

            return obj is IEngineSearchPostalInputMessage other &&
                ((this.SearchPostal == null && other.SearchPostal == null) || (this.SearchPostal?.Equals(other.SearchPostal) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SearchPostal = {(this.SearchPostal == null ? "null" : this.SearchPostal.ToString())}");
        }
    }
}