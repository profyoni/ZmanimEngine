// <copyright file="Q6EngineResultGps.cs" company="APIMatic">
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
    /// Q6EngineResultGps.
    /// </summary>
    [XmlRootAttribute("Engine.ResultGps")]
    public class Q6EngineResultGps
    {
        private string errMsg;
        private string locationID;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ErrMsg", false },
            { "LocationID", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineResultGps"/> class.
        /// </summary>
        public Q6EngineResultGps()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineResultGps"/> class.
        /// </summary>
        /// <param name="errMsg">ErrMsg.</param>
        /// <param name="locationID">LocationID.</param>
        public Q6EngineResultGps(
            string errMsg = null,
            string locationID = null)
        {
            if (errMsg != null)
            {
                this.ErrMsg = errMsg;
            }

            if (locationID != null)
            {
                this.LocationID = locationID;
            }

        }

        /// <summary>
        /// Gets or sets ErrMsg.
        /// </summary>
        [JsonProperty("ErrMsg")]
        [XmlElement("ErrMsg")]
        public string ErrMsg
        {
            get
            {
                return this.errMsg;
            }

            set
            {
                this.shouldSerialize["ErrMsg"] = true;
                this.errMsg = value;
            }
        }

        /// <summary>
        /// Gets or sets LocationID.
        /// </summary>
        [JsonProperty("LocationID")]
        [XmlElement("LocationID")]
        public string LocationID
        {
            get
            {
                return this.locationID;
            }

            set
            {
                this.shouldSerialize["LocationID"] = true;
                this.locationID = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Q6EngineResultGps : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrMsg()
        {
            this.shouldSerialize["ErrMsg"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationID()
        {
            this.shouldSerialize["LocationID"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrMsg()
        {
            return this.shouldSerialize["ErrMsg"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationID()
        {
            return this.shouldSerialize["LocationID"];
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

            return obj is Q6EngineResultGps other &&
                ((this.ErrMsg == null && other.ErrMsg == null) || (this.ErrMsg?.Equals(other.ErrMsg) == true)) &&
                ((this.LocationID == null && other.LocationID == null) || (this.LocationID?.Equals(other.LocationID) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ErrMsg = {(this.ErrMsg == null ? "null" : this.ErrMsg == string.Empty ? "" : this.ErrMsg)}");
            toStringOutput.Add($"this.LocationID = {(this.LocationID == null ? "null" : this.LocationID == string.Empty ? "" : this.LocationID)}");
        }
    }
}