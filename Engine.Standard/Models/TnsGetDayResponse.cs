// <copyright file="TnsGetDayResponse.cs" company="APIMatic">
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
    /// TnsGetDayResponse.
    /// </summary>
    [XmlRootAttribute("GetDayResponse")]
    public class TnsGetDayResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TnsGetDayResponse"/> class.
        /// </summary>
        public TnsGetDayResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TnsGetDayResponse"/> class.
        /// </summary>
        /// <param name="getDayResult">GetDayResult.</param>
        public TnsGetDayResponse(
            Models.Q6EngineResultDay getDayResult = null)
        {
            this.GetDayResult = getDayResult;
        }

        /// <summary>
        /// Gets or sets GetDayResult.
        /// </summary>
        [JsonProperty("GetDayResult", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("GetDayResult")]
        public Models.Q6EngineResultDay GetDayResult { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TnsGetDayResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is TnsGetDayResponse other &&
                ((this.GetDayResult == null && other.GetDayResult == null) || (this.GetDayResult?.Equals(other.GetDayResult) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GetDayResult = {(this.GetDayResult == null ? "null" : this.GetDayResult.ToString())}");
        }
    }
}