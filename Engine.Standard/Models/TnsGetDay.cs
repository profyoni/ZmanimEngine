// <copyright file="TnsGetDay.cs" company="APIMatic">
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
    /// TnsGetDay.
    /// </summary>
    [XmlRootAttribute("GetDay")]
    public class TnsGetDay
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TnsGetDay"/> class.
        /// </summary>
        public TnsGetDay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TnsGetDay"/> class.
        /// </summary>
        /// <param name="param">Param.</param>
        public TnsGetDay(
            Models.Q6EngineParamDay param = null)
        {
            this.Param = param;
        }

        /// <summary>
        /// Gets or sets Param.
        /// </summary>
        [JsonProperty("Param", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Param")]
        public Models.Q6EngineParamDay Param { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TnsGetDay : ({string.Join(", ", toStringOutput)})";
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

            return obj is TnsGetDay other &&
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