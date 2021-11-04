// <copyright file="Q6EngineParamGps.cs" company="APIMatic">
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
    /// Q6EngineParamGps.
    /// </summary>
    [XmlRootAttribute("Engine.ParamGps")]
    public class Q6EngineParamGps
    {
        private string coding;
        private string key;
        private string user;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Coding", false },
            { "Key", false },
            { "User", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineParamGps"/> class.
        /// </summary>
        public Q6EngineParamGps()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineParamGps"/> class.
        /// </summary>
        /// <param name="coding">Coding.</param>
        /// <param name="key">Key.</param>
        /// <param name="point">Point.</param>
        /// <param name="user">User.</param>
        public Q6EngineParamGps(
            string coding = null,
            string key = null,
            Models.Q6EngineCoordinates point = null,
            string user = null)
        {
            if (coding != null)
            {
                this.Coding = coding;
            }

            if (key != null)
            {
                this.Key = key;
            }

            this.Point = point;
            if (user != null)
            {
                this.User = user;
            }

        }

        /// <summary>
        /// Gets or sets Coding.
        /// </summary>
        [JsonProperty("Coding")]
        [XmlElement("Coding")]
        public string Coding
        {
            get
            {
                return this.coding;
            }

            set
            {
                this.shouldSerialize["Coding"] = true;
                this.coding = value;
            }
        }

        /// <summary>
        /// Gets or sets Key.
        /// </summary>
        [JsonProperty("Key")]
        [XmlElement("Key")]
        public string Key
        {
            get
            {
                return this.key;
            }

            set
            {
                this.shouldSerialize["Key"] = true;
                this.key = value;
            }
        }

        /// <summary>
        /// Gets or sets Point.
        /// </summary>
        [JsonProperty("Point", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Point")]
        public Models.Q6EngineCoordinates Point { get; set; }

        /// <summary>
        /// Gets or sets User.
        /// </summary>
        [JsonProperty("User")]
        [XmlElement("User")]
        public string User
        {
            get
            {
                return this.user;
            }

            set
            {
                this.shouldSerialize["User"] = true;
                this.user = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Q6EngineParamGps : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCoding()
        {
            this.shouldSerialize["Coding"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetKey()
        {
            this.shouldSerialize["Key"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUser()
        {
            this.shouldSerialize["User"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCoding()
        {
            return this.shouldSerialize["Coding"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeKey()
        {
            return this.shouldSerialize["Key"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUser()
        {
            return this.shouldSerialize["User"];
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

            return obj is Q6EngineParamGps other &&
                ((this.Coding == null && other.Coding == null) || (this.Coding?.Equals(other.Coding) == true)) &&
                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true)) &&
                ((this.Point == null && other.Point == null) || (this.Point?.Equals(other.Point) == true)) &&
                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Coding = {(this.Coding == null ? "null" : this.Coding == string.Empty ? "" : this.Coding)}");
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key == string.Empty ? "" : this.Key)}");
            toStringOutput.Add($"this.Point = {(this.Point == null ? "null" : this.Point.ToString())}");
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User == string.Empty ? "" : this.User)}");
        }
    }
}