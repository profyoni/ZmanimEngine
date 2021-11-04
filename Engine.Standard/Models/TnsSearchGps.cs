// <copyright file="TnsSearchGps.cs" company="APIMatic">
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
    /// TnsSearchGps.
    /// </summary>
    [XmlRootAttribute("SearchGps")]
    public class TnsSearchGps
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TnsSearchGps"/> class.
        /// </summary>
        public TnsSearchGps()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TnsSearchGps"/> class.
        /// </summary>
        /// <param name="param">Param.</param>
        public TnsSearchGps(
            Models.Q6EngineParamGps param = null)
        {
            this.Param = param;
        }

        /// <summary>
        /// Gets or sets Param.
        /// </summary>
        [JsonProperty("Param", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Param")]
        public Models.Q6EngineParamGps Param { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TnsSearchGps : ({string.Join(", ", toStringOutput)})";
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

            return obj is TnsSearchGps other &&
                ((this.Param == null && other.Param == null) || (this.Param?.Equals(other.Param) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Param = {(this.Param == null ? "null" : this.Param.ToString())}");
        }
    }
}