// <copyright file="IEngineGetDayOutputMessage.cs" company="APIMatic">
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
    /// IEngineGetDayOutputMessage.
    /// </summary>
    [XmlRootAttribute("IEngine_GetDay_OutputMessage")]
    public class IEngineGetDayOutputMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineGetDayOutputMessage"/> class.
        /// </summary>
        public IEngineGetDayOutputMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IEngineGetDayOutputMessage"/> class.
        /// </summary>
        /// <param name="getDayResponse">GetDayResponse.</param>
        public IEngineGetDayOutputMessage(
            Models.TnsGetDayResponse getDayResponse)
        {
            this.GetDayResponse = getDayResponse;
        }

        /// <summary>
        /// Gets or sets GetDayResponse.
        /// </summary>
        [JsonProperty("GetDayResponse")]
        [XmlElement("GetDayResponse")]
        public Models.TnsGetDayResponse GetDayResponse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IEngineGetDayOutputMessage : ({string.Join(", ", toStringOutput)})";
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

            return obj is IEngineGetDayOutputMessage other &&
                ((this.GetDayResponse == null && other.GetDayResponse == null) || (this.GetDayResponse?.Equals(other.GetDayResponse) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GetDayResponse = {(this.GetDayResponse == null ? "null" : this.GetDayResponse.ToString())}");
        }
    }
}