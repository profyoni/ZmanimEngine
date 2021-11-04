// <copyright file="Q6EngineDateInfo.cs" company="APIMatic">
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
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    using Engine.Standard;
    using Engine.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Q6EngineDateInfo.
    /// </summary>
    [XmlRootAttribute("Engine.DateInfo")]
    public class Q6EngineDateInfo : IXmlSerializable
    {
        private string dafYomi;
        private string dafYomiPage;
        private string dafYomiTract;
        private string dateCivilLong;
        private string dateFullLong;
        private string dateFullShort;
        private string dateJewish;
        private string dateJewishLong;
        private string dateJewishShort;
        private string dateSemiLong;
        private string dateSemiShort;
        private string holiday;
        private string holidayShort;
        private string parsha;
        private string parshaAndHoliday;
        private string parshaShort;
        private string tomorrowParsha;
        private string tomorrowParshaOrHoliday;
        private string weekday;
        private string weekdayShort;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "DafYomi", false },
            { "DafYomiPage", false },
            { "DafYomiTract", false },
            { "DateCivilLong", false },
            { "DateFullLong", false },
            { "DateFullShort", false },
            { "DateJewish", false },
            { "DateJewishLong", false },
            { "DateJewishShort", false },
            { "DateSemiLong", false },
            { "DateSemiShort", false },
            { "Holiday", false },
            { "HolidayShort", false },
            { "Parsha", false },
            { "ParshaAndHoliday", false },
            { "ParshaShort", false },
            { "TomorrowParsha", false },
            { "TomorrowParshaOrHoliday", false },
            { "Weekday", false },
            { "WeekdayShort", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineDateInfo"/> class.
        /// </summary>
        public Q6EngineDateInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6EngineDateInfo"/> class.
        /// </summary>
        /// <param name="dafYomi">DafYomi.</param>
        /// <param name="dafYomiPage">DafYomiPage.</param>
        /// <param name="dafYomiTract">DafYomiTract.</param>
        /// <param name="dateCivil">DateCivil.</param>
        /// <param name="dateCivilLong">DateCivilLong.</param>
        /// <param name="dateFullLong">DateFullLong.</param>
        /// <param name="dateFullShort">DateFullShort.</param>
        /// <param name="dateJewish">DateJewish.</param>
        /// <param name="dateJewishLong">DateJewishLong.</param>
        /// <param name="dateJewishShort">DateJewishShort.</param>
        /// <param name="dateSemiLong">DateSemiLong.</param>
        /// <param name="dateSemiShort">DateSemiShort.</param>
        /// <param name="daylightTime">DaylightTime.</param>
        /// <param name="holiday">Holiday.</param>
        /// <param name="holidayShort">HolidayShort.</param>
        /// <param name="isAsaraBiteves">IsAsaraBiteves.</param>
        /// <param name="isCholHamoed">IsCholHamoed.</param>
        /// <param name="isErevPesach">IsErevPesach.</param>
        /// <param name="isErevShabbos">IsErevShabbos.</param>
        /// <param name="isErevTishaBav">IsErevTishaBav.</param>
        /// <param name="isErevYomKipper">IsErevYomKipper.</param>
        /// <param name="isErevYomTov">IsErevYomTov.</param>
        /// <param name="isFastDay">IsFastDay.</param>
        /// <param name="isRoshChodesh">IsRoshChodesh.</param>
        /// <param name="isShabbos">IsShabbos.</param>
        /// <param name="isShivaAsarBitammuz">IsShivaAsarBitammuz.</param>
        /// <param name="isTaanisEsther">IsTaanisEsther.</param>
        /// <param name="isTishaBav">IsTishaBav.</param>
        /// <param name="isTuBeshvat">IsTuBeshvat.</param>
        /// <param name="isTzomGedalia">IsTzomGedalia.</param>
        /// <param name="isYomKipper">IsYomKipper.</param>
        /// <param name="isYomTov">IsYomTov.</param>
        /// <param name="omer">Omer.</param>
        /// <param name="parsha">Parsha.</param>
        /// <param name="parshaAndHoliday">ParshaAndHoliday.</param>
        /// <param name="parshaShort">ParshaShort.</param>
        /// <param name="tomorrowNightIsYomTov">TomorrowNightIsYomTov.</param>
        /// <param name="tomorrowParsha">TomorrowParsha.</param>
        /// <param name="tomorrowParshaOrHoliday">TomorrowParshaOrHoliday.</param>
        /// <param name="tonightIsYomTov">TonightIsYomTov.</param>
        /// <param name="weekday">Weekday.</param>
        /// <param name="weekdayShort">WeekdayShort.</param>
        public Q6EngineDateInfo(
            string dafYomi = null,
            string dafYomiPage = null,
            string dafYomiTract = null,
            DateTime? dateCivil = null,
            string dateCivilLong = null,
            string dateFullLong = null,
            string dateFullShort = null,
            string dateJewish = null,
            string dateJewishLong = null,
            string dateJewishShort = null,
            string dateSemiLong = null,
            string dateSemiShort = null,
            int? daylightTime = null,
            string holiday = null,
            string holidayShort = null,
            bool? isAsaraBiteves = null,
            bool? isCholHamoed = null,
            bool? isErevPesach = null,
            bool? isErevShabbos = null,
            bool? isErevTishaBav = null,
            bool? isErevYomKipper = null,
            bool? isErevYomTov = null,
            bool? isFastDay = null,
            bool? isRoshChodesh = null,
            bool? isShabbos = null,
            bool? isShivaAsarBitammuz = null,
            bool? isTaanisEsther = null,
            bool? isTishaBav = null,
            bool? isTuBeshvat = null,
            bool? isTzomGedalia = null,
            bool? isYomKipper = null,
            bool? isYomTov = null,
            int? omer = null,
            string parsha = null,
            string parshaAndHoliday = null,
            string parshaShort = null,
            bool? tomorrowNightIsYomTov = null,
            string tomorrowParsha = null,
            string tomorrowParshaOrHoliday = null,
            bool? tonightIsYomTov = null,
            string weekday = null,
            string weekdayShort = null)
        {
            if (dafYomi != null)
            {
                this.DafYomi = dafYomi;
            }

            if (dafYomiPage != null)
            {
                this.DafYomiPage = dafYomiPage;
            }

            if (dafYomiTract != null)
            {
                this.DafYomiTract = dafYomiTract;
            }

            this.DateCivil = dateCivil;
            if (dateCivilLong != null)
            {
                this.DateCivilLong = dateCivilLong;
            }

            if (dateFullLong != null)
            {
                this.DateFullLong = dateFullLong;
            }

            if (dateFullShort != null)
            {
                this.DateFullShort = dateFullShort;
            }

            if (dateJewish != null)
            {
                this.DateJewish = dateJewish;
            }

            if (dateJewishLong != null)
            {
                this.DateJewishLong = dateJewishLong;
            }

            if (dateJewishShort != null)
            {
                this.DateJewishShort = dateJewishShort;
            }

            if (dateSemiLong != null)
            {
                this.DateSemiLong = dateSemiLong;
            }

            if (dateSemiShort != null)
            {
                this.DateSemiShort = dateSemiShort;
            }

            this.DaylightTime = daylightTime;
            if (holiday != null)
            {
                this.Holiday = holiday;
            }

            if (holidayShort != null)
            {
                this.HolidayShort = holidayShort;
            }

            this.IsAsaraBiteves = isAsaraBiteves;
            this.IsCholHamoed = isCholHamoed;
            this.IsErevPesach = isErevPesach;
            this.IsErevShabbos = isErevShabbos;
            this.IsErevTishaBav = isErevTishaBav;
            this.IsErevYomKipper = isErevYomKipper;
            this.IsErevYomTov = isErevYomTov;
            this.IsFastDay = isFastDay;
            this.IsRoshChodesh = isRoshChodesh;
            this.IsShabbos = isShabbos;
            this.IsShivaAsarBitammuz = isShivaAsarBitammuz;
            this.IsTaanisEsther = isTaanisEsther;
            this.IsTishaBav = isTishaBav;
            this.IsTuBeshvat = isTuBeshvat;
            this.IsTzomGedalia = isTzomGedalia;
            this.IsYomKipper = isYomKipper;
            this.IsYomTov = isYomTov;
            this.Omer = omer;
            if (parsha != null)
            {
                this.Parsha = parsha;
            }

            if (parshaAndHoliday != null)
            {
                this.ParshaAndHoliday = parshaAndHoliday;
            }

            if (parshaShort != null)
            {
                this.ParshaShort = parshaShort;
            }

            this.TomorrowNightIsYomTov = tomorrowNightIsYomTov;
            if (tomorrowParsha != null)
            {
                this.TomorrowParsha = tomorrowParsha;
            }

            if (tomorrowParshaOrHoliday != null)
            {
                this.TomorrowParshaOrHoliday = tomorrowParshaOrHoliday;
            }

            this.TonightIsYomTov = tonightIsYomTov;
            if (weekday != null)
            {
                this.Weekday = weekday;
            }

            if (weekdayShort != null)
            {
                this.WeekdayShort = weekdayShort;
            }

        }

        /// <summary>
        /// Gets or sets DafYomi.
        /// </summary>
        [JsonProperty("DafYomi")]
        [XmlElement("DafYomi")]
        public string DafYomi
        {
            get
            {
                return this.dafYomi;
            }

            set
            {
                this.shouldSerialize["DafYomi"] = true;
                this.dafYomi = value;
            }
        }

        /// <summary>
        /// Gets or sets DafYomiPage.
        /// </summary>
        [JsonProperty("DafYomiPage")]
        [XmlElement("DafYomiPage")]
        public string DafYomiPage
        {
            get
            {
                return this.dafYomiPage;
            }

            set
            {
                this.shouldSerialize["DafYomiPage"] = true;
                this.dafYomiPage = value;
            }
        }

        /// <summary>
        /// Gets or sets DafYomiTract.
        /// </summary>
        [JsonProperty("DafYomiTract")]
        [XmlElement("DafYomiTract")]
        public string DafYomiTract
        {
            get
            {
                return this.dafYomiTract;
            }

            set
            {
                this.shouldSerialize["DafYomiTract"] = true;
                this.dafYomiTract = value;
            }
        }

        /// <summary>
        /// Gets or sets DateCivil.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("DateCivil", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("DateCivil")]
        public DateTime? DateCivil { get; set; }

        /// <summary>
        /// Gets or sets DateCivilLong.
        /// </summary>
        [JsonProperty("DateCivilLong")]
        [XmlElement("DateCivilLong")]
        public string DateCivilLong
        {
            get
            {
                return this.dateCivilLong;
            }

            set
            {
                this.shouldSerialize["DateCivilLong"] = true;
                this.dateCivilLong = value;
            }
        }

        /// <summary>
        /// Gets or sets DateFullLong.
        /// </summary>
        [JsonProperty("DateFullLong")]
        [XmlElement("DateFullLong")]
        public string DateFullLong
        {
            get
            {
                return this.dateFullLong;
            }

            set
            {
                this.shouldSerialize["DateFullLong"] = true;
                this.dateFullLong = value;
            }
        }

        /// <summary>
        /// Gets or sets DateFullShort.
        /// </summary>
        [JsonProperty("DateFullShort")]
        [XmlElement("DateFullShort")]
        public string DateFullShort
        {
            get
            {
                return this.dateFullShort;
            }

            set
            {
                this.shouldSerialize["DateFullShort"] = true;
                this.dateFullShort = value;
            }
        }

        /// <summary>
        /// Gets or sets DateJewish.
        /// </summary>
        [JsonProperty("DateJewish")]
        [XmlElement("DateJewish")]
        public string DateJewish
        {
            get
            {
                return this.dateJewish;
            }

            set
            {
                this.shouldSerialize["DateJewish"] = true;
                this.dateJewish = value;
            }
        }

        /// <summary>
        /// Gets or sets DateJewishLong.
        /// </summary>
        [JsonProperty("DateJewishLong")]
        [XmlElement("DateJewishLong")]
        public string DateJewishLong
        {
            get
            {
                return this.dateJewishLong;
            }

            set
            {
                this.shouldSerialize["DateJewishLong"] = true;
                this.dateJewishLong = value;
            }
        }

        /// <summary>
        /// Gets or sets DateJewishShort.
        /// </summary>
        [JsonProperty("DateJewishShort")]
        [XmlElement("DateJewishShort")]
        public string DateJewishShort
        {
            get
            {
                return this.dateJewishShort;
            }

            set
            {
                this.shouldSerialize["DateJewishShort"] = true;
                this.dateJewishShort = value;
            }
        }

        /// <summary>
        /// Gets or sets DateSemiLong.
        /// </summary>
        [JsonProperty("DateSemiLong")]
        [XmlElement("DateSemiLong")]
        public string DateSemiLong
        {
            get
            {
                return this.dateSemiLong;
            }

            set
            {
                this.shouldSerialize["DateSemiLong"] = true;
                this.dateSemiLong = value;
            }
        }

        /// <summary>
        /// Gets or sets DateSemiShort.
        /// </summary>
        [JsonProperty("DateSemiShort")]
        [XmlElement("DateSemiShort")]
        public string DateSemiShort
        {
            get
            {
                return this.dateSemiShort;
            }

            set
            {
                this.shouldSerialize["DateSemiShort"] = true;
                this.dateSemiShort = value;
            }
        }

        /// <summary>
        /// Gets or sets DaylightTime.
        /// </summary>
        [JsonProperty("DaylightTime", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("DaylightTime")]
        public int? DaylightTime { get; set; }

        /// <summary>
        /// Gets or sets Holiday.
        /// </summary>
        [JsonProperty("Holiday")]
        [XmlElement("Holiday")]
        public string Holiday
        {
            get
            {
                return this.holiday;
            }

            set
            {
                this.shouldSerialize["Holiday"] = true;
                this.holiday = value;
            }
        }

        /// <summary>
        /// Gets or sets HolidayShort.
        /// </summary>
        [JsonProperty("HolidayShort")]
        [XmlElement("HolidayShort")]
        public string HolidayShort
        {
            get
            {
                return this.holidayShort;
            }

            set
            {
                this.shouldSerialize["HolidayShort"] = true;
                this.holidayShort = value;
            }
        }

        /// <summary>
        /// Gets or sets IsAsaraBiteves.
        /// </summary>
        [JsonProperty("IsAsaraBiteves", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsAsaraBiteves")]
        public bool? IsAsaraBiteves { get; set; }

        /// <summary>
        /// Gets or sets IsCholHamoed.
        /// </summary>
        [JsonProperty("IsCholHamoed", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsCholHamoed")]
        public bool? IsCholHamoed { get; set; }

        /// <summary>
        /// Gets or sets IsErevPesach.
        /// </summary>
        [JsonProperty("IsErevPesach", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsErevPesach")]
        public bool? IsErevPesach { get; set; }

        /// <summary>
        /// Gets or sets IsErevShabbos.
        /// </summary>
        [JsonProperty("IsErevShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsErevShabbos")]
        public bool? IsErevShabbos { get; set; }

        /// <summary>
        /// Gets or sets IsErevTishaBav.
        /// </summary>
        [JsonProperty("IsErevTishaBav", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsErevTishaBav")]
        public bool? IsErevTishaBav { get; set; }

        /// <summary>
        /// Gets or sets IsErevYomKipper.
        /// </summary>
        [JsonProperty("IsErevYomKipper", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsErevYomKipper")]
        public bool? IsErevYomKipper { get; set; }

        /// <summary>
        /// Gets or sets IsErevYomTov.
        /// </summary>
        [JsonProperty("IsErevYomTov", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsErevYomTov")]
        public bool? IsErevYomTov { get; set; }

        /// <summary>
        /// Gets or sets IsFastDay.
        /// </summary>
        [JsonProperty("IsFastDay", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsFastDay")]
        public bool? IsFastDay { get; set; }

        /// <summary>
        /// Gets or sets IsRoshChodesh.
        /// </summary>
        [JsonProperty("IsRoshChodesh", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsRoshChodesh")]
        public bool? IsRoshChodesh { get; set; }

        /// <summary>
        /// Gets or sets IsShabbos.
        /// </summary>
        [JsonProperty("IsShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsShabbos")]
        public bool? IsShabbos { get; set; }

        /// <summary>
        /// Gets or sets IsShivaAsarBitammuz.
        /// </summary>
        [JsonProperty("IsShivaAsarBitammuz", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsShivaAsarBitammuz")]
        public bool? IsShivaAsarBitammuz { get; set; }

        /// <summary>
        /// Gets or sets IsTaanisEsther.
        /// </summary>
        [JsonProperty("IsTaanisEsther", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsTaanisEsther")]
        public bool? IsTaanisEsther { get; set; }

        /// <summary>
        /// Gets or sets IsTishaBav.
        /// </summary>
        [JsonProperty("IsTishaBav", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsTishaBav")]
        public bool? IsTishaBav { get; set; }

        /// <summary>
        /// Gets or sets IsTuBeshvat.
        /// </summary>
        [JsonProperty("IsTuBeshvat", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsTuBeshvat")]
        public bool? IsTuBeshvat { get; set; }

        /// <summary>
        /// Gets or sets IsTzomGedalia.
        /// </summary>
        [JsonProperty("IsTzomGedalia", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsTzomGedalia")]
        public bool? IsTzomGedalia { get; set; }

        /// <summary>
        /// Gets or sets IsYomKipper.
        /// </summary>
        [JsonProperty("IsYomKipper", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsYomKipper")]
        public bool? IsYomKipper { get; set; }

        /// <summary>
        /// Gets or sets IsYomTov.
        /// </summary>
        [JsonProperty("IsYomTov", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("IsYomTov")]
        public bool? IsYomTov { get; set; }

        /// <summary>
        /// Gets or sets Omer.
        /// </summary>
        [JsonProperty("Omer", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Omer")]
        public int? Omer { get; set; }

        /// <summary>
        /// Gets or sets Parsha.
        /// </summary>
        [JsonProperty("Parsha")]
        [XmlElement("Parsha")]
        public string Parsha
        {
            get
            {
                return this.parsha;
            }

            set
            {
                this.shouldSerialize["Parsha"] = true;
                this.parsha = value;
            }
        }

        /// <summary>
        /// Gets or sets ParshaAndHoliday.
        /// </summary>
        [JsonProperty("ParshaAndHoliday")]
        [XmlElement("ParshaAndHoliday")]
        public string ParshaAndHoliday
        {
            get
            {
                return this.parshaAndHoliday;
            }

            set
            {
                this.shouldSerialize["ParshaAndHoliday"] = true;
                this.parshaAndHoliday = value;
            }
        }

        /// <summary>
        /// Gets or sets ParshaShort.
        /// </summary>
        [JsonProperty("ParshaShort")]
        [XmlElement("ParshaShort")]
        public string ParshaShort
        {
            get
            {
                return this.parshaShort;
            }

            set
            {
                this.shouldSerialize["ParshaShort"] = true;
                this.parshaShort = value;
            }
        }

        /// <summary>
        /// Gets or sets TomorrowNightIsYomTov.
        /// </summary>
        [JsonProperty("TomorrowNightIsYomTov", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowNightIsYomTov")]
        public bool? TomorrowNightIsYomTov { get; set; }

        /// <summary>
        /// Gets or sets TomorrowParsha.
        /// </summary>
        [JsonProperty("TomorrowParsha")]
        [XmlElement("TomorrowParsha")]
        public string TomorrowParsha
        {
            get
            {
                return this.tomorrowParsha;
            }

            set
            {
                this.shouldSerialize["TomorrowParsha"] = true;
                this.tomorrowParsha = value;
            }
        }

        /// <summary>
        /// Gets or sets TomorrowParshaOrHoliday.
        /// </summary>
        [JsonProperty("TomorrowParshaOrHoliday")]
        [XmlElement("TomorrowParshaOrHoliday")]
        public string TomorrowParshaOrHoliday
        {
            get
            {
                return this.tomorrowParshaOrHoliday;
            }

            set
            {
                this.shouldSerialize["TomorrowParshaOrHoliday"] = true;
                this.tomorrowParshaOrHoliday = value;
            }
        }

        /// <summary>
        /// Gets or sets TonightIsYomTov.
        /// </summary>
        [JsonProperty("TonightIsYomTov", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TonightIsYomTov")]
        public bool? TonightIsYomTov { get; set; }

        /// <summary>
        /// Gets or sets Weekday.
        /// </summary>
        [JsonProperty("Weekday")]
        [XmlElement("Weekday")]
        public string Weekday
        {
            get
            {
                return this.weekday;
            }

            set
            {
                this.shouldSerialize["Weekday"] = true;
                this.weekday = value;
            }
        }

        /// <summary>
        /// Gets or sets WeekdayShort.
        /// </summary>
        [JsonProperty("WeekdayShort")]
        [XmlElement("WeekdayShort")]
        public string WeekdayShort
        {
            get
            {
                return this.weekdayShort;
            }

            set
            {
                this.shouldSerialize["WeekdayShort"] = true;
                this.weekdayShort = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Q6EngineDateInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDafYomi()
        {
            this.shouldSerialize["DafYomi"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDafYomiPage()
        {
            this.shouldSerialize["DafYomiPage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDafYomiTract()
        {
            this.shouldSerialize["DafYomiTract"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateCivilLong()
        {
            this.shouldSerialize["DateCivilLong"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateFullLong()
        {
            this.shouldSerialize["DateFullLong"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateFullShort()
        {
            this.shouldSerialize["DateFullShort"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateJewish()
        {
            this.shouldSerialize["DateJewish"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateJewishLong()
        {
            this.shouldSerialize["DateJewishLong"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateJewishShort()
        {
            this.shouldSerialize["DateJewishShort"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateSemiLong()
        {
            this.shouldSerialize["DateSemiLong"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateSemiShort()
        {
            this.shouldSerialize["DateSemiShort"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHoliday()
        {
            this.shouldSerialize["Holiday"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHolidayShort()
        {
            this.shouldSerialize["HolidayShort"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParsha()
        {
            this.shouldSerialize["Parsha"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParshaAndHoliday()
        {
            this.shouldSerialize["ParshaAndHoliday"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParshaShort()
        {
            this.shouldSerialize["ParshaShort"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTomorrowParsha()
        {
            this.shouldSerialize["TomorrowParsha"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTomorrowParshaOrHoliday()
        {
            this.shouldSerialize["TomorrowParshaOrHoliday"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetWeekday()
        {
            this.shouldSerialize["Weekday"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetWeekdayShort()
        {
            this.shouldSerialize["WeekdayShort"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDafYomi()
        {
            return this.shouldSerialize["DafYomi"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDafYomiPage()
        {
            return this.shouldSerialize["DafYomiPage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDafYomiTract()
        {
            return this.shouldSerialize["DafYomiTract"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateCivilLong()
        {
            return this.shouldSerialize["DateCivilLong"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateFullLong()
        {
            return this.shouldSerialize["DateFullLong"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateFullShort()
        {
            return this.shouldSerialize["DateFullShort"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateJewish()
        {
            return this.shouldSerialize["DateJewish"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateJewishLong()
        {
            return this.shouldSerialize["DateJewishLong"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateJewishShort()
        {
            return this.shouldSerialize["DateJewishShort"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateSemiLong()
        {
            return this.shouldSerialize["DateSemiLong"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateSemiShort()
        {
            return this.shouldSerialize["DateSemiShort"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHoliday()
        {
            return this.shouldSerialize["Holiday"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHolidayShort()
        {
            return this.shouldSerialize["HolidayShort"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParsha()
        {
            return this.shouldSerialize["Parsha"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParshaAndHoliday()
        {
            return this.shouldSerialize["ParshaAndHoliday"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParshaShort()
        {
            return this.shouldSerialize["ParshaShort"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTomorrowParsha()
        {
            return this.shouldSerialize["TomorrowParsha"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTomorrowParshaOrHoliday()
        {
            return this.shouldSerialize["TomorrowParshaOrHoliday"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeekday()
        {
            return this.shouldSerialize["Weekday"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeekdayShort()
        {
            return this.shouldSerialize["WeekdayShort"];
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

            return obj is Q6EngineDateInfo other &&
                ((this.DafYomi == null && other.DafYomi == null) || (this.DafYomi?.Equals(other.DafYomi) == true)) &&
                ((this.DafYomiPage == null && other.DafYomiPage == null) || (this.DafYomiPage?.Equals(other.DafYomiPage) == true)) &&
                ((this.DafYomiTract == null && other.DafYomiTract == null) || (this.DafYomiTract?.Equals(other.DafYomiTract) == true)) &&
                ((this.DateCivil == null && other.DateCivil == null) || (this.DateCivil?.Equals(other.DateCivil) == true)) &&
                ((this.DateCivilLong == null && other.DateCivilLong == null) || (this.DateCivilLong?.Equals(other.DateCivilLong) == true)) &&
                ((this.DateFullLong == null && other.DateFullLong == null) || (this.DateFullLong?.Equals(other.DateFullLong) == true)) &&
                ((this.DateFullShort == null && other.DateFullShort == null) || (this.DateFullShort?.Equals(other.DateFullShort) == true)) &&
                ((this.DateJewish == null && other.DateJewish == null) || (this.DateJewish?.Equals(other.DateJewish) == true)) &&
                ((this.DateJewishLong == null && other.DateJewishLong == null) || (this.DateJewishLong?.Equals(other.DateJewishLong) == true)) &&
                ((this.DateJewishShort == null && other.DateJewishShort == null) || (this.DateJewishShort?.Equals(other.DateJewishShort) == true)) &&
                ((this.DateSemiLong == null && other.DateSemiLong == null) || (this.DateSemiLong?.Equals(other.DateSemiLong) == true)) &&
                ((this.DateSemiShort == null && other.DateSemiShort == null) || (this.DateSemiShort?.Equals(other.DateSemiShort) == true)) &&
                ((this.DaylightTime == null && other.DaylightTime == null) || (this.DaylightTime?.Equals(other.DaylightTime) == true)) &&
                ((this.Holiday == null && other.Holiday == null) || (this.Holiday?.Equals(other.Holiday) == true)) &&
                ((this.HolidayShort == null && other.HolidayShort == null) || (this.HolidayShort?.Equals(other.HolidayShort) == true)) &&
                ((this.IsAsaraBiteves == null && other.IsAsaraBiteves == null) || (this.IsAsaraBiteves?.Equals(other.IsAsaraBiteves) == true)) &&
                ((this.IsCholHamoed == null && other.IsCholHamoed == null) || (this.IsCholHamoed?.Equals(other.IsCholHamoed) == true)) &&
                ((this.IsErevPesach == null && other.IsErevPesach == null) || (this.IsErevPesach?.Equals(other.IsErevPesach) == true)) &&
                ((this.IsErevShabbos == null && other.IsErevShabbos == null) || (this.IsErevShabbos?.Equals(other.IsErevShabbos) == true)) &&
                ((this.IsErevTishaBav == null && other.IsErevTishaBav == null) || (this.IsErevTishaBav?.Equals(other.IsErevTishaBav) == true)) &&
                ((this.IsErevYomKipper == null && other.IsErevYomKipper == null) || (this.IsErevYomKipper?.Equals(other.IsErevYomKipper) == true)) &&
                ((this.IsErevYomTov == null && other.IsErevYomTov == null) || (this.IsErevYomTov?.Equals(other.IsErevYomTov) == true)) &&
                ((this.IsFastDay == null && other.IsFastDay == null) || (this.IsFastDay?.Equals(other.IsFastDay) == true)) &&
                ((this.IsRoshChodesh == null && other.IsRoshChodesh == null) || (this.IsRoshChodesh?.Equals(other.IsRoshChodesh) == true)) &&
                ((this.IsShabbos == null && other.IsShabbos == null) || (this.IsShabbos?.Equals(other.IsShabbos) == true)) &&
                ((this.IsShivaAsarBitammuz == null && other.IsShivaAsarBitammuz == null) || (this.IsShivaAsarBitammuz?.Equals(other.IsShivaAsarBitammuz) == true)) &&
                ((this.IsTaanisEsther == null && other.IsTaanisEsther == null) || (this.IsTaanisEsther?.Equals(other.IsTaanisEsther) == true)) &&
                ((this.IsTishaBav == null && other.IsTishaBav == null) || (this.IsTishaBav?.Equals(other.IsTishaBav) == true)) &&
                ((this.IsTuBeshvat == null && other.IsTuBeshvat == null) || (this.IsTuBeshvat?.Equals(other.IsTuBeshvat) == true)) &&
                ((this.IsTzomGedalia == null && other.IsTzomGedalia == null) || (this.IsTzomGedalia?.Equals(other.IsTzomGedalia) == true)) &&
                ((this.IsYomKipper == null && other.IsYomKipper == null) || (this.IsYomKipper?.Equals(other.IsYomKipper) == true)) &&
                ((this.IsYomTov == null && other.IsYomTov == null) || (this.IsYomTov?.Equals(other.IsYomTov) == true)) &&
                ((this.Omer == null && other.Omer == null) || (this.Omer?.Equals(other.Omer) == true)) &&
                ((this.Parsha == null && other.Parsha == null) || (this.Parsha?.Equals(other.Parsha) == true)) &&
                ((this.ParshaAndHoliday == null && other.ParshaAndHoliday == null) || (this.ParshaAndHoliday?.Equals(other.ParshaAndHoliday) == true)) &&
                ((this.ParshaShort == null && other.ParshaShort == null) || (this.ParshaShort?.Equals(other.ParshaShort) == true)) &&
                ((this.TomorrowNightIsYomTov == null && other.TomorrowNightIsYomTov == null) || (this.TomorrowNightIsYomTov?.Equals(other.TomorrowNightIsYomTov) == true)) &&
                ((this.TomorrowParsha == null && other.TomorrowParsha == null) || (this.TomorrowParsha?.Equals(other.TomorrowParsha) == true)) &&
                ((this.TomorrowParshaOrHoliday == null && other.TomorrowParshaOrHoliday == null) || (this.TomorrowParshaOrHoliday?.Equals(other.TomorrowParshaOrHoliday) == true)) &&
                ((this.TonightIsYomTov == null && other.TonightIsYomTov == null) || (this.TonightIsYomTov?.Equals(other.TonightIsYomTov) == true)) &&
                ((this.Weekday == null && other.Weekday == null) || (this.Weekday?.Equals(other.Weekday) == true)) &&
                ((this.WeekdayShort == null && other.WeekdayShort == null) || (this.WeekdayShort?.Equals(other.WeekdayShort) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DafYomi = {(this.DafYomi == null ? "null" : this.DafYomi == string.Empty ? "" : this.DafYomi)}");
            toStringOutput.Add($"this.DafYomiPage = {(this.DafYomiPage == null ? "null" : this.DafYomiPage == string.Empty ? "" : this.DafYomiPage)}");
            toStringOutput.Add($"this.DafYomiTract = {(this.DafYomiTract == null ? "null" : this.DafYomiTract == string.Empty ? "" : this.DafYomiTract)}");
            toStringOutput.Add($"this.DateCivil = {(this.DateCivil == null ? "null" : this.DateCivil.ToString())}");
            toStringOutput.Add($"this.DateCivilLong = {(this.DateCivilLong == null ? "null" : this.DateCivilLong == string.Empty ? "" : this.DateCivilLong)}");
            toStringOutput.Add($"this.DateFullLong = {(this.DateFullLong == null ? "null" : this.DateFullLong == string.Empty ? "" : this.DateFullLong)}");
            toStringOutput.Add($"this.DateFullShort = {(this.DateFullShort == null ? "null" : this.DateFullShort == string.Empty ? "" : this.DateFullShort)}");
            toStringOutput.Add($"this.DateJewish = {(this.DateJewish == null ? "null" : this.DateJewish == string.Empty ? "" : this.DateJewish)}");
            toStringOutput.Add($"this.DateJewishLong = {(this.DateJewishLong == null ? "null" : this.DateJewishLong == string.Empty ? "" : this.DateJewishLong)}");
            toStringOutput.Add($"this.DateJewishShort = {(this.DateJewishShort == null ? "null" : this.DateJewishShort == string.Empty ? "" : this.DateJewishShort)}");
            toStringOutput.Add($"this.DateSemiLong = {(this.DateSemiLong == null ? "null" : this.DateSemiLong == string.Empty ? "" : this.DateSemiLong)}");
            toStringOutput.Add($"this.DateSemiShort = {(this.DateSemiShort == null ? "null" : this.DateSemiShort == string.Empty ? "" : this.DateSemiShort)}");
            toStringOutput.Add($"this.DaylightTime = {(this.DaylightTime == null ? "null" : this.DaylightTime.ToString())}");
            toStringOutput.Add($"this.Holiday = {(this.Holiday == null ? "null" : this.Holiday == string.Empty ? "" : this.Holiday)}");
            toStringOutput.Add($"this.HolidayShort = {(this.HolidayShort == null ? "null" : this.HolidayShort == string.Empty ? "" : this.HolidayShort)}");
            toStringOutput.Add($"this.IsAsaraBiteves = {(this.IsAsaraBiteves == null ? "null" : this.IsAsaraBiteves.ToString())}");
            toStringOutput.Add($"this.IsCholHamoed = {(this.IsCholHamoed == null ? "null" : this.IsCholHamoed.ToString())}");
            toStringOutput.Add($"this.IsErevPesach = {(this.IsErevPesach == null ? "null" : this.IsErevPesach.ToString())}");
            toStringOutput.Add($"this.IsErevShabbos = {(this.IsErevShabbos == null ? "null" : this.IsErevShabbos.ToString())}");
            toStringOutput.Add($"this.IsErevTishaBav = {(this.IsErevTishaBav == null ? "null" : this.IsErevTishaBav.ToString())}");
            toStringOutput.Add($"this.IsErevYomKipper = {(this.IsErevYomKipper == null ? "null" : this.IsErevYomKipper.ToString())}");
            toStringOutput.Add($"this.IsErevYomTov = {(this.IsErevYomTov == null ? "null" : this.IsErevYomTov.ToString())}");
            toStringOutput.Add($"this.IsFastDay = {(this.IsFastDay == null ? "null" : this.IsFastDay.ToString())}");
            toStringOutput.Add($"this.IsRoshChodesh = {(this.IsRoshChodesh == null ? "null" : this.IsRoshChodesh.ToString())}");
            toStringOutput.Add($"this.IsShabbos = {(this.IsShabbos == null ? "null" : this.IsShabbos.ToString())}");
            toStringOutput.Add($"this.IsShivaAsarBitammuz = {(this.IsShivaAsarBitammuz == null ? "null" : this.IsShivaAsarBitammuz.ToString())}");
            toStringOutput.Add($"this.IsTaanisEsther = {(this.IsTaanisEsther == null ? "null" : this.IsTaanisEsther.ToString())}");
            toStringOutput.Add($"this.IsTishaBav = {(this.IsTishaBav == null ? "null" : this.IsTishaBav.ToString())}");
            toStringOutput.Add($"this.IsTuBeshvat = {(this.IsTuBeshvat == null ? "null" : this.IsTuBeshvat.ToString())}");
            toStringOutput.Add($"this.IsTzomGedalia = {(this.IsTzomGedalia == null ? "null" : this.IsTzomGedalia.ToString())}");
            toStringOutput.Add($"this.IsYomKipper = {(this.IsYomKipper == null ? "null" : this.IsYomKipper.ToString())}");
            toStringOutput.Add($"this.IsYomTov = {(this.IsYomTov == null ? "null" : this.IsYomTov.ToString())}");
            toStringOutput.Add($"this.Omer = {(this.Omer == null ? "null" : this.Omer.ToString())}");
            toStringOutput.Add($"this.Parsha = {(this.Parsha == null ? "null" : this.Parsha == string.Empty ? "" : this.Parsha)}");
            toStringOutput.Add($"this.ParshaAndHoliday = {(this.ParshaAndHoliday == null ? "null" : this.ParshaAndHoliday == string.Empty ? "" : this.ParshaAndHoliday)}");
            toStringOutput.Add($"this.ParshaShort = {(this.ParshaShort == null ? "null" : this.ParshaShort == string.Empty ? "" : this.ParshaShort)}");
            toStringOutput.Add($"this.TomorrowNightIsYomTov = {(this.TomorrowNightIsYomTov == null ? "null" : this.TomorrowNightIsYomTov.ToString())}");
            toStringOutput.Add($"this.TomorrowParsha = {(this.TomorrowParsha == null ? "null" : this.TomorrowParsha == string.Empty ? "" : this.TomorrowParsha)}");
            toStringOutput.Add($"this.TomorrowParshaOrHoliday = {(this.TomorrowParshaOrHoliday == null ? "null" : this.TomorrowParshaOrHoliday == string.Empty ? "" : this.TomorrowParshaOrHoliday)}");
            toStringOutput.Add($"this.TonightIsYomTov = {(this.TonightIsYomTov == null ? "null" : this.TonightIsYomTov.ToString())}");
            toStringOutput.Add($"this.Weekday = {(this.Weekday == null ? "null" : this.Weekday == string.Empty ? "" : this.Weekday)}");
            toStringOutput.Add($"this.WeekdayShort = {(this.WeekdayShort == null ? "null" : this.WeekdayShort == string.Empty ? "" : this.WeekdayShort)}");
        }

        /// <summary>
        /// Creates a new class instance from the given XDocument.
        /// </summary>
        /// <param name="xDoc">The xDocument.</param>
        /// <returns>A new class instance.</returns>
        public static Q6EngineDateInfo FromXml(XDocument xDoc)
        {
            var dafYomi = (string)xDoc.Root.Element("DafYomi");
            var dafYomiPage = (string)xDoc.Root.Element("DafYomiPage");
            var dafYomiTract = (string)xDoc.Root.Element("DafYomiTract");
            var dateCivil = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("DateCivil").Value).GetValueOrDefault();
            var dateCivilLong = (string)xDoc.Root.Element("DateCivilLong");
            var dateFullLong = (string)xDoc.Root.Element("DateFullLong");
            var dateFullShort = (string)xDoc.Root.Element("DateFullShort");
            var dateJewish = (string)xDoc.Root.Element("DateJewish");
            var dateJewishLong = (string)xDoc.Root.Element("DateJewishLong");
            var dateJewishShort = (string)xDoc.Root.Element("DateJewishShort");
            var dateSemiLong = (string)xDoc.Root.Element("DateSemiLong");
            var dateSemiShort = (string)xDoc.Root.Element("DateSemiShort");
            var daylightTime = (int?)xDoc.Root.Element("DaylightTime");
            var holiday = (string)xDoc.Root.Element("Holiday");
            var holidayShort = (string)xDoc.Root.Element("HolidayShort");
            var isAsaraBiteves = (bool?)xDoc.Root.Element("IsAsaraBiteves");
            var isCholHamoed = (bool?)xDoc.Root.Element("IsCholHamoed");
            var isErevPesach = (bool?)xDoc.Root.Element("IsErevPesach");
            var isErevShabbos = (bool?)xDoc.Root.Element("IsErevShabbos");
            var isErevTishaBav = (bool?)xDoc.Root.Element("IsErevTishaBav");
            var isErevYomKipper = (bool?)xDoc.Root.Element("IsErevYomKipper");
            var isErevYomTov = (bool?)xDoc.Root.Element("IsErevYomTov");
            var isFastDay = (bool?)xDoc.Root.Element("IsFastDay");
            var isRoshChodesh = (bool?)xDoc.Root.Element("IsRoshChodesh");
            var isShabbos = (bool?)xDoc.Root.Element("IsShabbos");
            var isShivaAsarBitammuz = (bool?)xDoc.Root.Element("IsShivaAsarBitammuz");
            var isTaanisEsther = (bool?)xDoc.Root.Element("IsTaanisEsther");
            var isTishaBav = (bool?)xDoc.Root.Element("IsTishaBav");
            var isTuBeshvat = (bool?)xDoc.Root.Element("IsTuBeshvat");
            var isTzomGedalia = (bool?)xDoc.Root.Element("IsTzomGedalia");
            var isYomKipper = (bool?)xDoc.Root.Element("IsYomKipper");
            var isYomTov = (bool?)xDoc.Root.Element("IsYomTov");
            var omer = (int?)xDoc.Root.Element("Omer");
            var parsha = (string)xDoc.Root.Element("Parsha");
            var parshaAndHoliday = (string)xDoc.Root.Element("ParshaAndHoliday");
            var parshaShort = (string)xDoc.Root.Element("ParshaShort");
            var tomorrowNightIsYomTov = (bool?)xDoc.Root.Element("TomorrowNightIsYomTov");
            var tomorrowParsha = (string)xDoc.Root.Element("TomorrowParsha");
            var tomorrowParshaOrHoliday = (string)xDoc.Root.Element("TomorrowParshaOrHoliday");
            var tonightIsYomTov = (bool?)xDoc.Root.Element("TonightIsYomTov");
            var weekday = (string)xDoc.Root.Element("Weekday");
            var weekdayShort = (string)xDoc.Root.Element("WeekdayShort");
            return new Q6EngineDateInfo(//shouldSerialize,
                dafYomi,
                dafYomiPage,
                dafYomiTract,
                dateCivil,
                dateCivilLong,
                dateFullLong,
                dateFullShort,
                dateJewish,
                dateJewishLong,
                dateJewishShort,
                dateSemiLong,
                dateSemiShort,
                daylightTime,
                holiday,
                holidayShort,
                isAsaraBiteves,
                isCholHamoed,
                isErevPesach,
                isErevShabbos,
                isErevTishaBav,
                isErevYomKipper,
                isErevYomTov,
                isFastDay,
                isRoshChodesh,
                isShabbos,
                isShivaAsarBitammuz,
                isTaanisEsther,
                isTishaBav,
                isTuBeshvat,
                isTzomGedalia,
                isYomKipper,
                isYomTov,
                omer,
                parsha,
                parshaAndHoliday,
                parshaShort,
                tomorrowNightIsYomTov,
                tomorrowParsha,
                tomorrowParshaOrHoliday,
                tonightIsYomTov,
                weekday,
                weekdayShort);
        }

        /// <summary>
        /// Returns xml schema.
        /// </summary>
        /// <returns>Xml schema object.</returns>
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Writes data to the XmlWriter.
        /// </summary>
        /// <param name="writer">XmlWriter object.</param>
        public void WriteXml(XmlWriter writer)
        {
            if (this.DafYomi != null)
            {
                writer.WriteElementString("DafYomi", this.DafYomi);
            }

            if (this.DafYomiPage != null)
            {
                writer.WriteElementString("DafYomiPage", this.DafYomiPage);
            }

            if (this.DafYomiTract != null)
            {
                writer.WriteElementString("DafYomiTract", this.DafYomiTract);
            }

            if (this.DateCivil != null)
            {
                writer.WriteElementString("DateCivil", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.DateCivil));
            }

            if (this.DateCivilLong != null)
            {
                writer.WriteElementString("DateCivilLong", this.DateCivilLong);
            }

            if (this.DateFullLong != null)
            {
                writer.WriteElementString("DateFullLong", this.DateFullLong);
            }

            if (this.DateFullShort != null)
            {
                writer.WriteElementString("DateFullShort", this.DateFullShort);
            }

            if (this.DateJewish != null)
            {
                writer.WriteElementString("DateJewish", this.DateJewish);
            }

            if (this.DateJewishLong != null)
            {
                writer.WriteElementString("DateJewishLong", this.DateJewishLong);
            }

            if (this.DateJewishShort != null)
            {
                writer.WriteElementString("DateJewishShort", this.DateJewishShort);
            }

            if (this.DateSemiLong != null)
            {
                writer.WriteElementString("DateSemiLong", this.DateSemiLong);
            }

            if (this.DateSemiShort != null)
            {
                writer.WriteElementString("DateSemiShort", this.DateSemiShort);
            }

            if (this.DaylightTime != null)
            {
                writer.WriteElementString("DaylightTime", this.DaylightTime.ToString());
            }

            if (this.Holiday != null)
            {
                writer.WriteElementString("Holiday", this.Holiday);
            }

            if (this.HolidayShort != null)
            {
                writer.WriteElementString("HolidayShort", this.HolidayShort);
            }

            if (this.IsAsaraBiteves != null)
            {
                writer.WriteElementString("IsAsaraBiteves", this.IsAsaraBiteves.ToString());
            }

            if (this.IsCholHamoed != null)
            {
                writer.WriteElementString("IsCholHamoed", this.IsCholHamoed.ToString());
            }

            if (this.IsErevPesach != null)
            {
                writer.WriteElementString("IsErevPesach", this.IsErevPesach.ToString());
            }

            if (this.IsErevShabbos != null)
            {
                writer.WriteElementString("IsErevShabbos", this.IsErevShabbos.ToString());
            }

            if (this.IsErevTishaBav != null)
            {
                writer.WriteElementString("IsErevTishaBav", this.IsErevTishaBav.ToString());
            }

            if (this.IsErevYomKipper != null)
            {
                writer.WriteElementString("IsErevYomKipper", this.IsErevYomKipper.ToString());
            }

            if (this.IsErevYomTov != null)
            {
                writer.WriteElementString("IsErevYomTov", this.IsErevYomTov.ToString());
            }

            if (this.IsFastDay != null)
            {
                writer.WriteElementString("IsFastDay", this.IsFastDay.ToString());
            }

            if (this.IsRoshChodesh != null)
            {
                writer.WriteElementString("IsRoshChodesh", this.IsRoshChodesh.ToString());
            }

            if (this.IsShabbos != null)
            {
                writer.WriteElementString("IsShabbos", this.IsShabbos.ToString());
            }

            if (this.IsShivaAsarBitammuz != null)
            {
                writer.WriteElementString("IsShivaAsarBitammuz", this.IsShivaAsarBitammuz.ToString());
            }

            if (this.IsTaanisEsther != null)
            {
                writer.WriteElementString("IsTaanisEsther", this.IsTaanisEsther.ToString());
            }

            if (this.IsTishaBav != null)
            {
                writer.WriteElementString("IsTishaBav", this.IsTishaBav.ToString());
            }

            if (this.IsTuBeshvat != null)
            {
                writer.WriteElementString("IsTuBeshvat", this.IsTuBeshvat.ToString());
            }

            if (this.IsTzomGedalia != null)
            {
                writer.WriteElementString("IsTzomGedalia", this.IsTzomGedalia.ToString());
            }

            if (this.IsYomKipper != null)
            {
                writer.WriteElementString("IsYomKipper", this.IsYomKipper.ToString());
            }

            if (this.IsYomTov != null)
            {
                writer.WriteElementString("IsYomTov", this.IsYomTov.ToString());
            }

            if (this.Omer != null)
            {
                writer.WriteElementString("Omer", this.Omer.ToString());
            }

            if (this.Parsha != null)
            {
                writer.WriteElementString("Parsha", this.Parsha);
            }

            if (this.ParshaAndHoliday != null)
            {
                writer.WriteElementString("ParshaAndHoliday", this.ParshaAndHoliday);
            }

            if (this.ParshaShort != null)
            {
                writer.WriteElementString("ParshaShort", this.ParshaShort);
            }

            if (this.TomorrowNightIsYomTov != null)
            {
                writer.WriteElementString("TomorrowNightIsYomTov", this.TomorrowNightIsYomTov.ToString());
            }

            if (this.TomorrowParsha != null)
            {
                writer.WriteElementString("TomorrowParsha", this.TomorrowParsha);
            }

            if (this.TomorrowParshaOrHoliday != null)
            {
                writer.WriteElementString("TomorrowParshaOrHoliday", this.TomorrowParshaOrHoliday);
            }

            if (this.TonightIsYomTov != null)
            {
                writer.WriteElementString("TonightIsYomTov", this.TonightIsYomTov.ToString());
            }

            if (this.Weekday != null)
            {
                writer.WriteElementString("Weekday", this.Weekday);
            }

            if (this.WeekdayShort != null)
            {
                writer.WriteElementString("WeekdayShort", this.WeekdayShort);
            }
        }

        /// <summary>
        /// Loads values from the given XmlReader object.
        /// </summary>
        /// <param name="reader">XmlReader object.</param>
        public void ReadXml(XmlReader reader)
        {
            var xmlStr = reader.ReadOuterXml();
            XDocument xDoc = XDocument.Parse(xmlStr);
            var obj = FromXml(xDoc);

            this.DafYomi = obj.DafYomi;
            this.DafYomiPage = obj.DafYomiPage;
            this.DafYomiTract = obj.DafYomiTract;
            this.DateCivil = obj.DateCivil;
            this.DateCivilLong = obj.DateCivilLong;
            this.DateFullLong = obj.DateFullLong;
            this.DateFullShort = obj.DateFullShort;
            this.DateJewish = obj.DateJewish;
            this.DateJewishLong = obj.DateJewishLong;
            this.DateJewishShort = obj.DateJewishShort;
            this.DateSemiLong = obj.DateSemiLong;
            this.DateSemiShort = obj.DateSemiShort;
            this.DaylightTime = obj.DaylightTime;
            this.Holiday = obj.Holiday;
            this.HolidayShort = obj.HolidayShort;
            this.IsAsaraBiteves = obj.IsAsaraBiteves;
            this.IsCholHamoed = obj.IsCholHamoed;
            this.IsErevPesach = obj.IsErevPesach;
            this.IsErevShabbos = obj.IsErevShabbos;
            this.IsErevTishaBav = obj.IsErevTishaBav;
            this.IsErevYomKipper = obj.IsErevYomKipper;
            this.IsErevYomTov = obj.IsErevYomTov;
            this.IsFastDay = obj.IsFastDay;
            this.IsRoshChodesh = obj.IsRoshChodesh;
            this.IsShabbos = obj.IsShabbos;
            this.IsShivaAsarBitammuz = obj.IsShivaAsarBitammuz;
            this.IsTaanisEsther = obj.IsTaanisEsther;
            this.IsTishaBav = obj.IsTishaBav;
            this.IsTuBeshvat = obj.IsTuBeshvat;
            this.IsTzomGedalia = obj.IsTzomGedalia;
            this.IsYomKipper = obj.IsYomKipper;
            this.IsYomTov = obj.IsYomTov;
            this.Omer = obj.Omer;
            this.Parsha = obj.Parsha;
            this.ParshaAndHoliday = obj.ParshaAndHoliday;
            this.ParshaShort = obj.ParshaShort;
            this.TomorrowNightIsYomTov = obj.TomorrowNightIsYomTov;
            this.TomorrowParsha = obj.TomorrowParsha;
            this.TomorrowParshaOrHoliday = obj.TomorrowParshaOrHoliday;
            this.TonightIsYomTov = obj.TonightIsYomTov;
            this.Weekday = obj.Weekday;
            this.WeekdayShort = obj.WeekdayShort;
        }
    }
}