// <copyright file="Q6EngineCoordinates.cs" company="APIMatic">
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
    /// Q6EngineCoordinates.
    /// </summary>
    [XmlRootAttribute("Engine.Coordinates")]
    public class Q6EngineCoordinates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineCoordinates"/> class.
        /// </summary>
        public Q6EngineCoordinates()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineCoordinates"/> class.
        /// </summary>
        /// <param name="lat">Lat.</param>
        /// <param name="lon">Lon.</param>
        public Q6EngineCoordinates(
            double? lat = null,
            double? lon = null)
        {
            this.Lat = lat;
            this.Lon = lon;
        }

        /// <summary>
        /// Gets or sets Lat.
        /// </summary>
        [JsonProperty("Lat", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Lat")]
        public double? Lat { get; set; }

        /// <summary>
        /// Gets or sets Lon.
        /// </summary>
        [JsonProperty("Lon", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Lon")]
        public double? Lon { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Q6EngineCoordinates : ({string.Join(", ", toStringOutput)})";
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

            return obj is Q6EngineCoordinates other &&
                ((this.Lat == null && other.Lat == null) || (this.Lat?.Equals(other.Lat) == true)) &&
                ((this.Lon == null && other.Lon == null) || (this.Lon?.Equals(other.Lon) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Lat = {(this.Lat == null ? "null" : this.Lat.ToString())}");
            toStringOutput.Add($"this.Lon = {(this.Lon == null ? "null" : this.Lon.ToString())}");
        }
    }
}