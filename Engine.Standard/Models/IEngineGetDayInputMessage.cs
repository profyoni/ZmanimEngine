// <copyright file="IEngineGetDayInputMessage.cs" company="APIMatic">
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
    /// IEngineGetDayInputMessage.
    /// </summary>
    [XmlRootAttribute("IEngine_GetDay_InputMessage")]
    public class IEngineGetDayInputMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineGetDayInputMessage"/> class.
        /// </summary>
        public IEngineGetDayInputMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineGetDayInputMessage"/> class.
        /// </summary>
        /// <param name="getDay">GetDay.</param>
        public IEngineGetDayInputMessage(
            Models.TnsGetDay getDay)
        {
            this.GetDay = getDay;
        }

        /// <summary>
        /// Gets or sets GetDay.
        /// </summary>
        [JsonProperty("GetDay")]
        [XmlElement("GetDay")]
        public Models.TnsGetDay GetDay { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IEngineGetDayInputMessage : ({string.Join(", ", toStringOutput)})";
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

            return obj is IEngineGetDayInputMessage other &&
                ((this.GetDay == null && other.GetDay == null) || (this.GetDay?.Equals(other.GetDay) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GetDay = {(this.GetDay == null ? "null" : this.GetDay.ToString())}");
        }
    }
}