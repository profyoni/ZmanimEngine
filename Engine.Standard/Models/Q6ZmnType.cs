// <copyright file="Q6ZmnType.cs" company="APIMatic">
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
    /// Q6ZmnType.
    /// </summary>
    [XmlRootAttribute("ZmnType")]
    public class Q6ZmnType : IXmlSerializable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Q6ZmnType"/> class.
        /// </summary>
        public Q6ZmnType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Q6ZmnType"/> class.
        /// </summary>
        /// <param name="candles">Candles.</param>
        /// <param name="candles10">Candles10.</param>
        /// <param name="candles15">Candles15.</param>
        /// <param name="candles18">Candles18.</param>
        /// <param name="candles20">Candles20.</param>
        /// <param name="candles22">Candles22.</param>
        /// <param name="candles30">Candles30.</param>
        /// <param name="candles40">Candles40.</param>
        /// <param name="chametzBurnBenIsh72ToFastTuc">ChametzBurnBenIsh72ToFastTuc.</param>
        /// <param name="chametzBurnBenIsh72ToGra180">ChametzBurnBenIsh72ToGra180.</param>
        /// <param name="chametzBurnBenIsh72ToGra180propdn">ChametzBurnBenIsh72ToGra180propdn.</param>
        /// <param name="chametzBurnBenIsh72ToGra180proprs">ChametzBurnBenIsh72ToGra180proprs.</param>
        /// <param name="chametzBurnBenIsh72ToShabbos">ChametzBurnBenIsh72ToShabbos.</param>
        /// <param name="chametzBurnBenIsh72proprsToRaful">ChametzBurnBenIsh72proprsToRaful.</param>
        /// <param name="chametzBurnBenIsh90ToFastTuc">ChametzBurnBenIsh90ToFastTuc.</param>
        /// <param name="chametzBurnGra">ChametzBurnGra.</param>
        /// <param name="chametzBurnMA72">ChametzBurnMA72.</param>
        /// <param name="chametzBurnMA72fix">ChametzBurnMA72fix.</param>
        /// <param name="chametzBurnMA72propdn">ChametzBurnMA72propdn.</param>
        /// <param name="chametzBurnMA72proprs">ChametzBurnMA72proprs.</param>
        /// <param name="chametzBurnMA90">ChametzBurnMA90.</param>
        /// <param name="chametzBurnRMF">ChametzBurnRMF.</param>
        /// <param name="chametzEatBenIsh72ToFastTuc">ChametzEatBenIsh72ToFastTuc.</param>
        /// <param name="chametzEatBenIsh72ToGra180">ChametzEatBenIsh72ToGra180.</param>
        /// <param name="chametzEatBenIsh72ToGra180propdn">ChametzEatBenIsh72ToGra180propdn.</param>
        /// <param name="chametzEatBenIsh72ToGra180proprs">ChametzEatBenIsh72ToGra180proprs.</param>
        /// <param name="chametzEatBenIsh72ToShabbos">ChametzEatBenIsh72ToShabbos.</param>
        /// <param name="chametzEatBenIsh72proprsToRaful">ChametzEatBenIsh72proprsToRaful.</param>
        /// <param name="chametzEatBenIsh90ToFastTuc">ChametzEatBenIsh90ToFastTuc.</param>
        /// <param name="chametzEatGra">ChametzEatGra.</param>
        /// <param name="chametzEatMA72">ChametzEatMA72.</param>
        /// <param name="chametzEatMA72fix">ChametzEatMA72fix.</param>
        /// <param name="chametzEatMA72propdn">ChametzEatMA72propdn.</param>
        /// <param name="chametzEatMA72proprs">ChametzEatMA72proprs.</param>
        /// <param name="chametzEatMA90">ChametzEatMA90.</param>
        /// <param name="chametzEatRMF">ChametzEatRMF.</param>
        /// <param name="currentTime">CurrentTime.</param>
        /// <param name="dawn72">Dawn72.</param>
        /// <param name="dawn72fix">Dawn72fix.</param>
        /// <param name="dawn72propdn">Dawn72propdn.</param>
        /// <param name="dawn72proprs">Dawn72proprs.</param>
        /// <param name="dawn90">Dawn90.</param>
        /// <param name="dawnBenIsh72ToGra180propdn">DawnBenIsh72ToGra180propdn.</param>
        /// <param name="dawnRMF">DawnRMF.</param>
        /// <param name="ketanaBenIsh72ToFastTuc">KetanaBenIsh72ToFastTuc.</param>
        /// <param name="ketanaBenIsh72ToGra180">KetanaBenIsh72ToGra180.</param>
        /// <param name="ketanaBenIsh72ToGra180propdn">KetanaBenIsh72ToGra180propdn.</param>
        /// <param name="ketanaBenIsh72ToGra180proprs">KetanaBenIsh72ToGra180proprs.</param>
        /// <param name="ketanaBenIsh72ToShabbos">KetanaBenIsh72ToShabbos.</param>
        /// <param name="ketanaBenIsh72proprsToRaful">KetanaBenIsh72proprsToRaful.</param>
        /// <param name="ketanaBenIsh90ToFastTuc">KetanaBenIsh90ToFastTuc.</param>
        /// <param name="ketanaGra">KetanaGra.</param>
        /// <param name="ketanaMA72">KetanaMA72.</param>
        /// <param name="ketanaMA72fix">KetanaMA72fix.</param>
        /// <param name="ketanaMA72propdn">KetanaMA72propdn.</param>
        /// <param name="ketanaMA72proprs">KetanaMA72proprs.</param>
        /// <param name="ketanaMA90">KetanaMA90.</param>
        /// <param name="mealBenIsh72ToFastTuc">MealBenIsh72ToFastTuc.</param>
        /// <param name="mealBenIsh72ToGra180">MealBenIsh72ToGra180.</param>
        /// <param name="mealBenIsh72ToGra180propdn">MealBenIsh72ToGra180propdn.</param>
        /// <param name="mealBenIsh72ToGra180proprs">MealBenIsh72ToGra180proprs.</param>
        /// <param name="mealBenIsh72ToShabbos">MealBenIsh72ToShabbos.</param>
        /// <param name="mealBenIsh72proprsToRaful">MealBenIsh72proprsToRaful.</param>
        /// <param name="mealBenIsh90ToFastTuc">MealBenIsh90ToFastTuc.</param>
        /// <param name="mealGra">MealGra.</param>
        /// <param name="mealMA72">MealMA72.</param>
        /// <param name="mealMA72fix">MealMA72fix.</param>
        /// <param name="mealMA72propdn">MealMA72propdn.</param>
        /// <param name="mealMA72proprs">MealMA72proprs.</param>
        /// <param name="mealMA90">MealMA90.</param>
        /// <param name="midday">Midday.</param>
        /// <param name="middayBenIsh72proprsToRaful">MiddayBenIsh72proprsToRaful.</param>
        /// <param name="middayRMF">MiddayRMF.</param>
        /// <param name="midnight">Midnight.</param>
        /// <param name="mincha30fix">Mincha30fix.</param>
        /// <param name="minchaBenIsh72ToFastTuc">MinchaBenIsh72ToFastTuc.</param>
        /// <param name="minchaBenIsh72ToGra180">MinchaBenIsh72ToGra180.</param>
        /// <param name="minchaBenIsh72ToGra180propdn">MinchaBenIsh72ToGra180propdn.</param>
        /// <param name="minchaBenIsh72ToGra180proprs">MinchaBenIsh72ToGra180proprs.</param>
        /// <param name="minchaBenIsh72ToShabbos">MinchaBenIsh72ToShabbos.</param>
        /// <param name="minchaBenIsh72proprsToRaful">MinchaBenIsh72proprsToRaful.</param>
        /// <param name="minchaBenIsh90ToFastTuc">MinchaBenIsh90ToFastTuc.</param>
        /// <param name="minchaGra">MinchaGra.</param>
        /// <param name="minchaMA72">MinchaMA72.</param>
        /// <param name="minchaMA72fix">MinchaMA72fix.</param>
        /// <param name="minchaMA72propdn">MinchaMA72propdn.</param>
        /// <param name="minchaMA72proprs">MinchaMA72proprs.</param>
        /// <param name="minchaMA90">MinchaMA90.</param>
        /// <param name="minchaStrict">MinchaStrict.</param>
        /// <param name="mussafBenIsh72ToFastTuc">MussafBenIsh72ToFastTuc.</param>
        /// <param name="mussafBenIsh72ToGra180">MussafBenIsh72ToGra180.</param>
        /// <param name="mussafBenIsh72ToGra180propdn">MussafBenIsh72ToGra180propdn.</param>
        /// <param name="mussafBenIsh72ToGra180proprs">MussafBenIsh72ToGra180proprs.</param>
        /// <param name="mussafBenIsh72ToShabbos">MussafBenIsh72ToShabbos.</param>
        /// <param name="mussafBenIsh72proprsToRaful">MussafBenIsh72proprsToRaful.</param>
        /// <param name="mussafBenIsh90ToFastTuc">MussafBenIsh90ToFastTuc.</param>
        /// <param name="mussafGra">MussafGra.</param>
        /// <param name="mussafMA72">MussafMA72.</param>
        /// <param name="mussafMA72fix">MussafMA72fix.</param>
        /// <param name="mussafMA72propdn">MussafMA72propdn.</param>
        /// <param name="mussafMA72proprs">MussafMA72proprs.</param>
        /// <param name="mussafMA90">MussafMA90.</param>
        /// <param name="night40fix">Night40fix.</param>
        /// <param name="night50fix">Night50fix.</param>
        /// <param name="night60fix">Night60fix.</param>
        /// <param name="night72">Night72.</param>
        /// <param name="night72fix">Night72fix.</param>
        /// <param name="night72fixLevel">Night72fixLevel.</param>
        /// <param name="night72propdn">Night72propdn.</param>
        /// <param name="night72proprs">Night72proprs.</param>
        /// <param name="night90">Night90.</param>
        /// <param name="nightAgudas">NightAgudas.</param>
        /// <param name="nightBenIsh72ToGra180propdn">NightBenIsh72ToGra180propdn.</param>
        /// <param name="nightBenIsh72ToGra180proprs">NightBenIsh72ToGra180proprs.</param>
        /// <param name="nightChazonIsh">NightChazonIsh.</param>
        /// <param name="nightFastRMF">NightFastRMF.</param>
        /// <param name="nightFastTuc">NightFastTuc.</param>
        /// <param name="nightGra180">NightGra180.</param>
        /// <param name="nightGra225">NightGra225.</param>
        /// <param name="nightGra240">NightGra240.</param>
        /// <param name="nightMoed">NightMoed.</param>
        /// <param name="nightRadun">NightRadun.</param>
        /// <param name="nightRaful">NightRaful.</param>
        /// <param name="nightShabbos">NightShabbos.</param>
        /// <param name="nightZalman">NightZalman.</param>
        /// <param name="plagBenIsh72ToFastTuc">PlagBenIsh72ToFastTuc.</param>
        /// <param name="plagBenIsh72ToGra180">PlagBenIsh72ToGra180.</param>
        /// <param name="plagBenIsh72ToGra180propdn">PlagBenIsh72ToGra180propdn.</param>
        /// <param name="plagBenIsh72ToGra180proprs">PlagBenIsh72ToGra180proprs.</param>
        /// <param name="plagBenIsh72ToShabbos">PlagBenIsh72ToShabbos.</param>
        /// <param name="plagBenIsh72proprsToRaful">PlagBenIsh72proprsToRaful.</param>
        /// <param name="plagBenIsh90ToFastTuc">PlagBenIsh90ToFastTuc.</param>
        /// <param name="plagGra">PlagGra.</param>
        /// <param name="plagMA72">PlagMA72.</param>
        /// <param name="plagMA72fix">PlagMA72fix.</param>
        /// <param name="plagMA72propdn">PlagMA72propdn.</param>
        /// <param name="plagMA72proprs">PlagMA72proprs.</param>
        /// <param name="plagMA90">PlagMA90.</param>
        /// <param name="propBenIsh72ToFastTuc">PropBenIsh72ToFastTuc.</param>
        /// <param name="propBenIsh72ToGra180">PropBenIsh72ToGra180.</param>
        /// <param name="propBenIsh72ToGra180propdn">PropBenIsh72ToGra180propdn.</param>
        /// <param name="propBenIsh72ToGra180proprs">PropBenIsh72ToGra180proprs.</param>
        /// <param name="propBenIsh72ToShabbos">PropBenIsh72ToShabbos.</param>
        /// <param name="propBenIsh72proprsToRaful">PropBenIsh72proprsToRaful.</param>
        /// <param name="propBenIsh90ToFastTuc">PropBenIsh90ToFastTuc.</param>
        /// <param name="propGra">PropGra.</param>
        /// <param name="propMA72">PropMA72.</param>
        /// <param name="propMA72fix">PropMA72fix.</param>
        /// <param name="propMA72propdn">PropMA72propdn.</param>
        /// <param name="propMA72proprs">PropMA72proprs.</param>
        /// <param name="propMA90">PropMA90.</param>
        /// <param name="propRiseToSetElevated">PropRiseToSetElevated.</param>
        /// <param name="propRmfMorning">PropRmfMorning.</param>
        /// <param name="shachrisBenIsh72ToFastTuc">ShachrisBenIsh72ToFastTuc.</param>
        /// <param name="shachrisBenIsh72ToGra180">ShachrisBenIsh72ToGra180.</param>
        /// <param name="shachrisBenIsh72ToGra180propdn">ShachrisBenIsh72ToGra180propdn.</param>
        /// <param name="shachrisBenIsh72ToGra180proprs">ShachrisBenIsh72ToGra180proprs.</param>
        /// <param name="shachrisBenIsh72ToShabbos">ShachrisBenIsh72ToShabbos.</param>
        /// <param name="shachrisBenIsh72proprsToRaful">ShachrisBenIsh72proprsToRaful.</param>
        /// <param name="shachrisBenIsh90ToFastTuc">ShachrisBenIsh90ToFastTuc.</param>
        /// <param name="shachrisGra">ShachrisGra.</param>
        /// <param name="shachrisMA72">ShachrisMA72.</param>
        /// <param name="shachrisMA72fix">ShachrisMA72fix.</param>
        /// <param name="shachrisMA72propdn">ShachrisMA72propdn.</param>
        /// <param name="shachrisMA72proprs">ShachrisMA72proprs.</param>
        /// <param name="shachrisMA90">ShachrisMA90.</param>
        /// <param name="shachrisRMF">ShachrisRMF.</param>
        /// <param name="shemaBenIsh72ToFastTuc">ShemaBenIsh72ToFastTuc.</param>
        /// <param name="shemaBenIsh72ToGra180">ShemaBenIsh72ToGra180.</param>
        /// <param name="shemaBenIsh72ToGra180propdn">ShemaBenIsh72ToGra180propdn.</param>
        /// <param name="shemaBenIsh72ToGra180proprs">ShemaBenIsh72ToGra180proprs.</param>
        /// <param name="shemaBenIsh72ToShabbos">ShemaBenIsh72ToShabbos.</param>
        /// <param name="shemaBenIsh72proprsToRaful">ShemaBenIsh72proprsToRaful.</param>
        /// <param name="shemaBenIsh90ToFastTuc">ShemaBenIsh90ToFastTuc.</param>
        /// <param name="shemaGra">ShemaGra.</param>
        /// <param name="shemaMA72">ShemaMA72.</param>
        /// <param name="shemaMA72fix">ShemaMA72fix.</param>
        /// <param name="shemaMA72propdn">ShemaMA72propdn.</param>
        /// <param name="shemaMA72proprs">ShemaMA72proprs.</param>
        /// <param name="shemaMA90">ShemaMA90.</param>
        /// <param name="shemaRMF">ShemaRMF.</param>
        /// <param name="sunriseDefault">SunriseDefault.</param>
        /// <param name="sunriseElevated">SunriseElevated.</param>
        /// <param name="sunriseLevel">SunriseLevel.</param>
        /// <param name="sunsetDefault">SunsetDefault.</param>
        /// <param name="sunsetElevated">SunsetElevated.</param>
        /// <param name="sunsetLevel">SunsetLevel.</param>
        /// <param name="tomorrow2Night72fix">Tomorrow2Night72fix.</param>
        /// <param name="tomorrow2Night72propdn">Tomorrow2Night72propdn.</param>
        /// <param name="tomorrow2NightChazonIsh">Tomorrow2NightChazonIsh.</param>
        /// <param name="tomorrow2NightShabbos">Tomorrow2NightShabbos.</param>
        /// <param name="tomorrow2SunsetDefault">Tomorrow2SunsetDefault.</param>
        /// <param name="tomorrow2SunsetElevated">Tomorrow2SunsetElevated.</param>
        /// <param name="tomorrow2SunsetLevel">Tomorrow2SunsetLevel.</param>
        /// <param name="tomorrowNight72fix">TomorrowNight72fix.</param>
        /// <param name="tomorrowNight72propdn">TomorrowNight72propdn.</param>
        /// <param name="tomorrowNightChazonIsh">TomorrowNightChazonIsh.</param>
        /// <param name="tomorrowNightShabbos">TomorrowNightShabbos.</param>
        /// <param name="tomorrowSunriseDefault">TomorrowSunriseDefault.</param>
        /// <param name="tomorrowSunriseElevated">TomorrowSunriseElevated.</param>
        /// <param name="tomorrowSunriseLevel">TomorrowSunriseLevel.</param>
        /// <param name="tomorrowSunsetDefault">TomorrowSunsetDefault.</param>
        /// <param name="tomorrowSunsetElevated">TomorrowSunsetElevated.</param>
        /// <param name="tomorrowSunsetLevel">TomorrowSunsetLevel.</param>
        /// <param name="yakir062">Yakir062.</param>
        /// <param name="yakir069">Yakir069.</param>
        /// <param name="yakir102">Yakir102.</param>
        /// <param name="yakir110">Yakir110.</param>
        /// <param name="yakir115">Yakir115.</param>
        /// <param name="yakir120">Yakir120.</param>
        /// <param name="yakirDefault">YakirDefault.</param>
        public Q6ZmnType(
            DateTime? candles = null,
            DateTime? candles10 = null,
            DateTime? candles15 = null,
            DateTime? candles18 = null,
            DateTime? candles20 = null,
            DateTime? candles22 = null,
            DateTime? candles30 = null,
            DateTime? candles40 = null,
            DateTime? chametzBurnBenIsh72ToFastTuc = null,
            DateTime? chametzBurnBenIsh72ToGra180 = null,
            DateTime? chametzBurnBenIsh72ToGra180propdn = null,
            DateTime? chametzBurnBenIsh72ToGra180proprs = null,
            DateTime? chametzBurnBenIsh72ToShabbos = null,
            DateTime? chametzBurnBenIsh72proprsToRaful = null,
            DateTime? chametzBurnBenIsh90ToFastTuc = null,
            DateTime? chametzBurnGra = null,
            DateTime? chametzBurnMA72 = null,
            DateTime? chametzBurnMA72fix = null,
            DateTime? chametzBurnMA72propdn = null,
            DateTime? chametzBurnMA72proprs = null,
            DateTime? chametzBurnMA90 = null,
            DateTime? chametzBurnRMF = null,
            DateTime? chametzEatBenIsh72ToFastTuc = null,
            DateTime? chametzEatBenIsh72ToGra180 = null,
            DateTime? chametzEatBenIsh72ToGra180propdn = null,
            DateTime? chametzEatBenIsh72ToGra180proprs = null,
            DateTime? chametzEatBenIsh72ToShabbos = null,
            DateTime? chametzEatBenIsh72proprsToRaful = null,
            DateTime? chametzEatBenIsh90ToFastTuc = null,
            DateTime? chametzEatGra = null,
            DateTime? chametzEatMA72 = null,
            DateTime? chametzEatMA72fix = null,
            DateTime? chametzEatMA72propdn = null,
            DateTime? chametzEatMA72proprs = null,
            DateTime? chametzEatMA90 = null,
            DateTime? chametzEatRMF = null,
            DateTime? currentTime = null,
            DateTime? dawn72 = null,
            DateTime? dawn72fix = null,
            DateTime? dawn72propdn = null,
            DateTime? dawn72proprs = null,
            DateTime? dawn90 = null,
            DateTime? dawnBenIsh72ToGra180propdn = null,
            DateTime? dawnRMF = null,
            DateTime? ketanaBenIsh72ToFastTuc = null,
            DateTime? ketanaBenIsh72ToGra180 = null,
            DateTime? ketanaBenIsh72ToGra180propdn = null,
            DateTime? ketanaBenIsh72ToGra180proprs = null,
            DateTime? ketanaBenIsh72ToShabbos = null,
            DateTime? ketanaBenIsh72proprsToRaful = null,
            DateTime? ketanaBenIsh90ToFastTuc = null,
            DateTime? ketanaGra = null,
            DateTime? ketanaMA72 = null,
            DateTime? ketanaMA72fix = null,
            DateTime? ketanaMA72propdn = null,
            DateTime? ketanaMA72proprs = null,
            DateTime? ketanaMA90 = null,
            DateTime? mealBenIsh72ToFastTuc = null,
            DateTime? mealBenIsh72ToGra180 = null,
            DateTime? mealBenIsh72ToGra180propdn = null,
            DateTime? mealBenIsh72ToGra180proprs = null,
            DateTime? mealBenIsh72ToShabbos = null,
            DateTime? mealBenIsh72proprsToRaful = null,
            DateTime? mealBenIsh90ToFastTuc = null,
            DateTime? mealGra = null,
            DateTime? mealMA72 = null,
            DateTime? mealMA72fix = null,
            DateTime? mealMA72propdn = null,
            DateTime? mealMA72proprs = null,
            DateTime? mealMA90 = null,
            DateTime? midday = null,
            DateTime? middayBenIsh72proprsToRaful = null,
            DateTime? middayRMF = null,
            DateTime? midnight = null,
            DateTime? mincha30fix = null,
            DateTime? minchaBenIsh72ToFastTuc = null,
            DateTime? minchaBenIsh72ToGra180 = null,
            DateTime? minchaBenIsh72ToGra180propdn = null,
            DateTime? minchaBenIsh72ToGra180proprs = null,
            DateTime? minchaBenIsh72ToShabbos = null,
            DateTime? minchaBenIsh72proprsToRaful = null,
            DateTime? minchaBenIsh90ToFastTuc = null,
            DateTime? minchaGra = null,
            DateTime? minchaMA72 = null,
            DateTime? minchaMA72fix = null,
            DateTime? minchaMA72propdn = null,
            DateTime? minchaMA72proprs = null,
            DateTime? minchaMA90 = null,
            DateTime? minchaStrict = null,
            DateTime? mussafBenIsh72ToFastTuc = null,
            DateTime? mussafBenIsh72ToGra180 = null,
            DateTime? mussafBenIsh72ToGra180propdn = null,
            DateTime? mussafBenIsh72ToGra180proprs = null,
            DateTime? mussafBenIsh72ToShabbos = null,
            DateTime? mussafBenIsh72proprsToRaful = null,
            DateTime? mussafBenIsh90ToFastTuc = null,
            DateTime? mussafGra = null,
            DateTime? mussafMA72 = null,
            DateTime? mussafMA72fix = null,
            DateTime? mussafMA72propdn = null,
            DateTime? mussafMA72proprs = null,
            DateTime? mussafMA90 = null,
            DateTime? night40fix = null,
            DateTime? night50fix = null,
            DateTime? night60fix = null,
            DateTime? night72 = null,
            DateTime? night72fix = null,
            DateTime? night72fixLevel = null,
            DateTime? night72propdn = null,
            DateTime? night72proprs = null,
            DateTime? night90 = null,
            DateTime? nightAgudas = null,
            DateTime? nightBenIsh72ToGra180propdn = null,
            DateTime? nightBenIsh72ToGra180proprs = null,
            DateTime? nightChazonIsh = null,
            DateTime? nightFastRMF = null,
            DateTime? nightFastTuc = null,
            DateTime? nightGra180 = null,
            DateTime? nightGra225 = null,
            DateTime? nightGra240 = null,
            DateTime? nightMoed = null,
            DateTime? nightRadun = null,
            DateTime? nightRaful = null,
            DateTime? nightShabbos = null,
            DateTime? nightZalman = null,
            DateTime? plagBenIsh72ToFastTuc = null,
            DateTime? plagBenIsh72ToGra180 = null,
            DateTime? plagBenIsh72ToGra180propdn = null,
            DateTime? plagBenIsh72ToGra180proprs = null,
            DateTime? plagBenIsh72ToShabbos = null,
            DateTime? plagBenIsh72proprsToRaful = null,
            DateTime? plagBenIsh90ToFastTuc = null,
            DateTime? plagGra = null,
            DateTime? plagMA72 = null,
            DateTime? plagMA72fix = null,
            DateTime? plagMA72propdn = null,
            DateTime? plagMA72proprs = null,
            DateTime? plagMA90 = null,
            long? propBenIsh72ToFastTuc = null,
            long? propBenIsh72ToGra180 = null,
            long? propBenIsh72ToGra180propdn = null,
            long? propBenIsh72ToGra180proprs = null,
            long? propBenIsh72ToShabbos = null,
            long? propBenIsh72proprsToRaful = null,
            long? propBenIsh90ToFastTuc = null,
            long? propGra = null,
            long? propMA72 = null,
            long? propMA72fix = null,
            long? propMA72propdn = null,
            long? propMA72proprs = null,
            long? propMA90 = null,
            long? propRiseToSetElevated = null,
            long? propRmfMorning = null,
            DateTime? shachrisBenIsh72ToFastTuc = null,
            DateTime? shachrisBenIsh72ToGra180 = null,
            DateTime? shachrisBenIsh72ToGra180propdn = null,
            DateTime? shachrisBenIsh72ToGra180proprs = null,
            DateTime? shachrisBenIsh72ToShabbos = null,
            DateTime? shachrisBenIsh72proprsToRaful = null,
            DateTime? shachrisBenIsh90ToFastTuc = null,
            DateTime? shachrisGra = null,
            DateTime? shachrisMA72 = null,
            DateTime? shachrisMA72fix = null,
            DateTime? shachrisMA72propdn = null,
            DateTime? shachrisMA72proprs = null,
            DateTime? shachrisMA90 = null,
            DateTime? shachrisRMF = null,
            DateTime? shemaBenIsh72ToFastTuc = null,
            DateTime? shemaBenIsh72ToGra180 = null,
            DateTime? shemaBenIsh72ToGra180propdn = null,
            DateTime? shemaBenIsh72ToGra180proprs = null,
            DateTime? shemaBenIsh72ToShabbos = null,
            DateTime? shemaBenIsh72proprsToRaful = null,
            DateTime? shemaBenIsh90ToFastTuc = null,
            DateTime? shemaGra = null,
            DateTime? shemaMA72 = null,
            DateTime? shemaMA72fix = null,
            DateTime? shemaMA72propdn = null,
            DateTime? shemaMA72proprs = null,
            DateTime? shemaMA90 = null,
            DateTime? shemaRMF = null,
            DateTime? sunriseDefault = null,
            DateTime? sunriseElevated = null,
            DateTime? sunriseLevel = null,
            DateTime? sunsetDefault = null,
            DateTime? sunsetElevated = null,
            DateTime? sunsetLevel = null,
            DateTime? tomorrow2Night72fix = null,
            DateTime? tomorrow2Night72propdn = null,
            DateTime? tomorrow2NightChazonIsh = null,
            DateTime? tomorrow2NightShabbos = null,
            DateTime? tomorrow2SunsetDefault = null,
            DateTime? tomorrow2SunsetElevated = null,
            DateTime? tomorrow2SunsetLevel = null,
            DateTime? tomorrowNight72fix = null,
            DateTime? tomorrowNight72propdn = null,
            DateTime? tomorrowNightChazonIsh = null,
            DateTime? tomorrowNightShabbos = null,
            DateTime? tomorrowSunriseDefault = null,
            DateTime? tomorrowSunriseElevated = null,
            DateTime? tomorrowSunriseLevel = null,
            DateTime? tomorrowSunsetDefault = null,
            DateTime? tomorrowSunsetElevated = null,
            DateTime? tomorrowSunsetLevel = null,
            DateTime? yakir062 = null,
            DateTime? yakir069 = null,
            DateTime? yakir102 = null,
            DateTime? yakir110 = null,
            DateTime? yakir115 = null,
            DateTime? yakir120 = null,
            DateTime? yakirDefault = null)
        {
            this.Candles = candles;
            this.Candles10 = candles10;
            this.Candles15 = candles15;
            this.Candles18 = candles18;
            this.Candles20 = candles20;
            this.Candles22 = candles22;
            this.Candles30 = candles30;
            this.Candles40 = candles40;
            this.ChametzBurnBenIsh72ToFastTuc = chametzBurnBenIsh72ToFastTuc;
            this.ChametzBurnBenIsh72ToGra180 = chametzBurnBenIsh72ToGra180;
            this.ChametzBurnBenIsh72ToGra180propdn = chametzBurnBenIsh72ToGra180propdn;
            this.ChametzBurnBenIsh72ToGra180proprs = chametzBurnBenIsh72ToGra180proprs;
            this.ChametzBurnBenIsh72ToShabbos = chametzBurnBenIsh72ToShabbos;
            this.ChametzBurnBenIsh72proprsToRaful = chametzBurnBenIsh72proprsToRaful;
            this.ChametzBurnBenIsh90ToFastTuc = chametzBurnBenIsh90ToFastTuc;
            this.ChametzBurnGra = chametzBurnGra;
            this.ChametzBurnMA72 = chametzBurnMA72;
            this.ChametzBurnMA72fix = chametzBurnMA72fix;
            this.ChametzBurnMA72propdn = chametzBurnMA72propdn;
            this.ChametzBurnMA72proprs = chametzBurnMA72proprs;
            this.ChametzBurnMA90 = chametzBurnMA90;
            this.ChametzBurnRMF = chametzBurnRMF;
            this.ChametzEatBenIsh72ToFastTuc = chametzEatBenIsh72ToFastTuc;
            this.ChametzEatBenIsh72ToGra180 = chametzEatBenIsh72ToGra180;
            this.ChametzEatBenIsh72ToGra180propdn = chametzEatBenIsh72ToGra180propdn;
            this.ChametzEatBenIsh72ToGra180proprs = chametzEatBenIsh72ToGra180proprs;
            this.ChametzEatBenIsh72ToShabbos = chametzEatBenIsh72ToShabbos;
            this.ChametzEatBenIsh72proprsToRaful = chametzEatBenIsh72proprsToRaful;
            this.ChametzEatBenIsh90ToFastTuc = chametzEatBenIsh90ToFastTuc;
            this.ChametzEatGra = chametzEatGra;
            this.ChametzEatMA72 = chametzEatMA72;
            this.ChametzEatMA72fix = chametzEatMA72fix;
            this.ChametzEatMA72propdn = chametzEatMA72propdn;
            this.ChametzEatMA72proprs = chametzEatMA72proprs;
            this.ChametzEatMA90 = chametzEatMA90;
            this.ChametzEatRMF = chametzEatRMF;
            this.CurrentTime = currentTime;
            this.Dawn72 = dawn72;
            this.Dawn72fix = dawn72fix;
            this.Dawn72propdn = dawn72propdn;
            this.Dawn72proprs = dawn72proprs;
            this.Dawn90 = dawn90;
            this.DawnBenIsh72ToGra180propdn = dawnBenIsh72ToGra180propdn;
            this.DawnRMF = dawnRMF;
            this.KetanaBenIsh72ToFastTuc = ketanaBenIsh72ToFastTuc;
            this.KetanaBenIsh72ToGra180 = ketanaBenIsh72ToGra180;
            this.KetanaBenIsh72ToGra180propdn = ketanaBenIsh72ToGra180propdn;
            this.KetanaBenIsh72ToGra180proprs = ketanaBenIsh72ToGra180proprs;
            this.KetanaBenIsh72ToShabbos = ketanaBenIsh72ToShabbos;
            this.KetanaBenIsh72proprsToRaful = ketanaBenIsh72proprsToRaful;
            this.KetanaBenIsh90ToFastTuc = ketanaBenIsh90ToFastTuc;
            this.KetanaGra = ketanaGra;
            this.KetanaMA72 = ketanaMA72;
            this.KetanaMA72fix = ketanaMA72fix;
            this.KetanaMA72propdn = ketanaMA72propdn;
            this.KetanaMA72proprs = ketanaMA72proprs;
            this.KetanaMA90 = ketanaMA90;
            this.MealBenIsh72ToFastTuc = mealBenIsh72ToFastTuc;
            this.MealBenIsh72ToGra180 = mealBenIsh72ToGra180;
            this.MealBenIsh72ToGra180propdn = mealBenIsh72ToGra180propdn;
            this.MealBenIsh72ToGra180proprs = mealBenIsh72ToGra180proprs;
            this.MealBenIsh72ToShabbos = mealBenIsh72ToShabbos;
            this.MealBenIsh72proprsToRaful = mealBenIsh72proprsToRaful;
            this.MealBenIsh90ToFastTuc = mealBenIsh90ToFastTuc;
            this.MealGra = mealGra;
            this.MealMA72 = mealMA72;
            this.MealMA72fix = mealMA72fix;
            this.MealMA72propdn = mealMA72propdn;
            this.MealMA72proprs = mealMA72proprs;
            this.MealMA90 = mealMA90;
            this.Midday = midday;
            this.MiddayBenIsh72proprsToRaful = middayBenIsh72proprsToRaful;
            this.MiddayRMF = middayRMF;
            this.Midnight = midnight;
            this.Mincha30fix = mincha30fix;
            this.MinchaBenIsh72ToFastTuc = minchaBenIsh72ToFastTuc;
            this.MinchaBenIsh72ToGra180 = minchaBenIsh72ToGra180;
            this.MinchaBenIsh72ToGra180propdn = minchaBenIsh72ToGra180propdn;
            this.MinchaBenIsh72ToGra180proprs = minchaBenIsh72ToGra180proprs;
            this.MinchaBenIsh72ToShabbos = minchaBenIsh72ToShabbos;
            this.MinchaBenIsh72proprsToRaful = minchaBenIsh72proprsToRaful;
            this.MinchaBenIsh90ToFastTuc = minchaBenIsh90ToFastTuc;
            this.MinchaGra = minchaGra;
            this.MinchaMA72 = minchaMA72;
            this.MinchaMA72fix = minchaMA72fix;
            this.MinchaMA72propdn = minchaMA72propdn;
            this.MinchaMA72proprs = minchaMA72proprs;
            this.MinchaMA90 = minchaMA90;
            this.MinchaStrict = minchaStrict;
            this.MussafBenIsh72ToFastTuc = mussafBenIsh72ToFastTuc;
            this.MussafBenIsh72ToGra180 = mussafBenIsh72ToGra180;
            this.MussafBenIsh72ToGra180propdn = mussafBenIsh72ToGra180propdn;
            this.MussafBenIsh72ToGra180proprs = mussafBenIsh72ToGra180proprs;
            this.MussafBenIsh72ToShabbos = mussafBenIsh72ToShabbos;
            this.MussafBenIsh72proprsToRaful = mussafBenIsh72proprsToRaful;
            this.MussafBenIsh90ToFastTuc = mussafBenIsh90ToFastTuc;
            this.MussafGra = mussafGra;
            this.MussafMA72 = mussafMA72;
            this.MussafMA72fix = mussafMA72fix;
            this.MussafMA72propdn = mussafMA72propdn;
            this.MussafMA72proprs = mussafMA72proprs;
            this.MussafMA90 = mussafMA90;
            this.Night40fix = night40fix;
            this.Night50fix = night50fix;
            this.Night60fix = night60fix;
            this.Night72 = night72;
            this.Night72fix = night72fix;
            this.Night72fixLevel = night72fixLevel;
            this.Night72propdn = night72propdn;
            this.Night72proprs = night72proprs;
            this.Night90 = night90;
            this.NightAgudas = nightAgudas;
            this.NightBenIsh72ToGra180propdn = nightBenIsh72ToGra180propdn;
            this.NightBenIsh72ToGra180proprs = nightBenIsh72ToGra180proprs;
            this.NightChazonIsh = nightChazonIsh;
            this.NightFastRMF = nightFastRMF;
            this.NightFastTuc = nightFastTuc;
            this.NightGra180 = nightGra180;
            this.NightGra225 = nightGra225;
            this.NightGra240 = nightGra240;
            this.NightMoed = nightMoed;
            this.NightRadun = nightRadun;
            this.NightRaful = nightRaful;
            this.NightShabbos = nightShabbos;
            this.NightZalman = nightZalman;
            this.PlagBenIsh72ToFastTuc = plagBenIsh72ToFastTuc;
            this.PlagBenIsh72ToGra180 = plagBenIsh72ToGra180;
            this.PlagBenIsh72ToGra180propdn = plagBenIsh72ToGra180propdn;
            this.PlagBenIsh72ToGra180proprs = plagBenIsh72ToGra180proprs;
            this.PlagBenIsh72ToShabbos = plagBenIsh72ToShabbos;
            this.PlagBenIsh72proprsToRaful = plagBenIsh72proprsToRaful;
            this.PlagBenIsh90ToFastTuc = plagBenIsh90ToFastTuc;
            this.PlagGra = plagGra;
            this.PlagMA72 = plagMA72;
            this.PlagMA72fix = plagMA72fix;
            this.PlagMA72propdn = plagMA72propdn;
            this.PlagMA72proprs = plagMA72proprs;
            this.PlagMA90 = plagMA90;
            this.PropBenIsh72ToFastTuc = propBenIsh72ToFastTuc;
            this.PropBenIsh72ToGra180 = propBenIsh72ToGra180;
            this.PropBenIsh72ToGra180propdn = propBenIsh72ToGra180propdn;
            this.PropBenIsh72ToGra180proprs = propBenIsh72ToGra180proprs;
            this.PropBenIsh72ToShabbos = propBenIsh72ToShabbos;
            this.PropBenIsh72proprsToRaful = propBenIsh72proprsToRaful;
            this.PropBenIsh90ToFastTuc = propBenIsh90ToFastTuc;
            this.PropGra = propGra;
            this.PropMA72 = propMA72;
            this.PropMA72fix = propMA72fix;
            this.PropMA72propdn = propMA72propdn;
            this.PropMA72proprs = propMA72proprs;
            this.PropMA90 = propMA90;
            this.PropRiseToSetElevated = propRiseToSetElevated;
            this.PropRmfMorning = propRmfMorning;
            this.ShachrisBenIsh72ToFastTuc = shachrisBenIsh72ToFastTuc;
            this.ShachrisBenIsh72ToGra180 = shachrisBenIsh72ToGra180;
            this.ShachrisBenIsh72ToGra180propdn = shachrisBenIsh72ToGra180propdn;
            this.ShachrisBenIsh72ToGra180proprs = shachrisBenIsh72ToGra180proprs;
            this.ShachrisBenIsh72ToShabbos = shachrisBenIsh72ToShabbos;
            this.ShachrisBenIsh72proprsToRaful = shachrisBenIsh72proprsToRaful;
            this.ShachrisBenIsh90ToFastTuc = shachrisBenIsh90ToFastTuc;
            this.ShachrisGra = shachrisGra;
            this.ShachrisMA72 = shachrisMA72;
            this.ShachrisMA72fix = shachrisMA72fix;
            this.ShachrisMA72propdn = shachrisMA72propdn;
            this.ShachrisMA72proprs = shachrisMA72proprs;
            this.ShachrisMA90 = shachrisMA90;
            this.ShachrisRMF = shachrisRMF;
            this.ShemaBenIsh72ToFastTuc = shemaBenIsh72ToFastTuc;
            this.ShemaBenIsh72ToGra180 = shemaBenIsh72ToGra180;
            this.ShemaBenIsh72ToGra180propdn = shemaBenIsh72ToGra180propdn;
            this.ShemaBenIsh72ToGra180proprs = shemaBenIsh72ToGra180proprs;
            this.ShemaBenIsh72ToShabbos = shemaBenIsh72ToShabbos;
            this.ShemaBenIsh72proprsToRaful = shemaBenIsh72proprsToRaful;
            this.ShemaBenIsh90ToFastTuc = shemaBenIsh90ToFastTuc;
            this.ShemaGra = shemaGra;
            this.ShemaMA72 = shemaMA72;
            this.ShemaMA72fix = shemaMA72fix;
            this.ShemaMA72propdn = shemaMA72propdn;
            this.ShemaMA72proprs = shemaMA72proprs;
            this.ShemaMA90 = shemaMA90;
            this.ShemaRMF = shemaRMF;
            this.SunriseDefault = sunriseDefault;
            this.SunriseElevated = sunriseElevated;
            this.SunriseLevel = sunriseLevel;
            this.SunsetDefault = sunsetDefault;
            this.SunsetElevated = sunsetElevated;
            this.SunsetLevel = sunsetLevel;
            this.Tomorrow2Night72fix = tomorrow2Night72fix;
            this.Tomorrow2Night72propdn = tomorrow2Night72propdn;
            this.Tomorrow2NightChazonIsh = tomorrow2NightChazonIsh;
            this.Tomorrow2NightShabbos = tomorrow2NightShabbos;
            this.Tomorrow2SunsetDefault = tomorrow2SunsetDefault;
            this.Tomorrow2SunsetElevated = tomorrow2SunsetElevated;
            this.Tomorrow2SunsetLevel = tomorrow2SunsetLevel;
            this.TomorrowNight72fix = tomorrowNight72fix;
            this.TomorrowNight72propdn = tomorrowNight72propdn;
            this.TomorrowNightChazonIsh = tomorrowNightChazonIsh;
            this.TomorrowNightShabbos = tomorrowNightShabbos;
            this.TomorrowSunriseDefault = tomorrowSunriseDefault;
            this.TomorrowSunriseElevated = tomorrowSunriseElevated;
            this.TomorrowSunriseLevel = tomorrowSunriseLevel;
            this.TomorrowSunsetDefault = tomorrowSunsetDefault;
            this.TomorrowSunsetElevated = tomorrowSunsetElevated;
            this.TomorrowSunsetLevel = tomorrowSunsetLevel;
            this.Yakir062 = yakir062;
            this.Yakir069 = yakir069;
            this.Yakir102 = yakir102;
            this.Yakir110 = yakir110;
            this.Yakir115 = yakir115;
            this.Yakir120 = yakir120;
            this.YakirDefault = yakirDefault;
        }

        /// <summary>
        /// Gets or sets Candles.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Candles", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Candles")]
        public DateTime? Candles { get; set; }

        /// <summary>
        /// Gets or sets Candles10.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Candles10", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Candles10")]
        public DateTime? Candles10 { get; set; }

        /// <summary>
        /// Gets or sets Candles15.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Candles15", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Candles15")]
        public DateTime? Candles15 { get; set; }

        /// <summary>
        /// Gets or sets Candles18.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Candles18", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Candles18")]
        public DateTime? Candles18 { get; set; }

        /// <summary>
        /// Gets or sets Candles20.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Candles20", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Candles20")]
        public DateTime? Candles20 { get; set; }

        /// <summary>
        /// Gets or sets Candles22.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Candles22", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Candles22")]
        public DateTime? Candles22 { get; set; }

        /// <summary>
        /// Gets or sets Candles30.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Candles30", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Candles30")]
        public DateTime? Candles30 { get; set; }

        /// <summary>
        /// Gets or sets Candles40.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Candles40", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Candles40")]
        public DateTime? Candles40 { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnBenIsh72ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnBenIsh72ToFastTuc")]
        public DateTime? ChametzBurnBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnBenIsh72ToGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnBenIsh72ToGra180")]
        public DateTime? ChametzBurnBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnBenIsh72ToGra180propdn")]
        public DateTime? ChametzBurnBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnBenIsh72ToGra180proprs")]
        public DateTime? ChametzBurnBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnBenIsh72ToShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnBenIsh72ToShabbos")]
        public DateTime? ChametzBurnBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnBenIsh72proprsToRaful")]
        public DateTime? ChametzBurnBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnBenIsh90ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnBenIsh90ToFastTuc")]
        public DateTime? ChametzBurnBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnGra.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnGra")]
        public DateTime? ChametzBurnGra { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnMA72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnMA72")]
        public DateTime? ChametzBurnMA72 { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnMA72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnMA72fix")]
        public DateTime? ChametzBurnMA72fix { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnMA72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnMA72propdn")]
        public DateTime? ChametzBurnMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnMA72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnMA72proprs")]
        public DateTime? ChametzBurnMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnMA90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnMA90")]
        public DateTime? ChametzBurnMA90 { get; set; }

        /// <summary>
        /// Gets or sets ChametzBurnRMF.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzBurnRMF", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzBurnRMF")]
        public DateTime? ChametzBurnRMF { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatBenIsh72ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatBenIsh72ToFastTuc")]
        public DateTime? ChametzEatBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatBenIsh72ToGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatBenIsh72ToGra180")]
        public DateTime? ChametzEatBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatBenIsh72ToGra180propdn")]
        public DateTime? ChametzEatBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatBenIsh72ToGra180proprs")]
        public DateTime? ChametzEatBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatBenIsh72ToShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatBenIsh72ToShabbos")]
        public DateTime? ChametzEatBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatBenIsh72proprsToRaful")]
        public DateTime? ChametzEatBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatBenIsh90ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatBenIsh90ToFastTuc")]
        public DateTime? ChametzEatBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatGra.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatGra")]
        public DateTime? ChametzEatGra { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatMA72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatMA72")]
        public DateTime? ChametzEatMA72 { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatMA72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatMA72fix")]
        public DateTime? ChametzEatMA72fix { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatMA72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatMA72propdn")]
        public DateTime? ChametzEatMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatMA72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatMA72proprs")]
        public DateTime? ChametzEatMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatMA90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatMA90")]
        public DateTime? ChametzEatMA90 { get; set; }

        /// <summary>
        /// Gets or sets ChametzEatRMF.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ChametzEatRMF", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ChametzEatRMF")]
        public DateTime? ChametzEatRMF { get; set; }

        /// <summary>
        /// Gets or sets CurrentTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("CurrentTime", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("CurrentTime")]
        public DateTime? CurrentTime { get; set; }

        /// <summary>
        /// Gets or sets Dawn72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Dawn72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Dawn72")]
        public DateTime? Dawn72 { get; set; }

        /// <summary>
        /// Gets or sets Dawn72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Dawn72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Dawn72fix")]
        public DateTime? Dawn72fix { get; set; }

        /// <summary>
        /// Gets or sets Dawn72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Dawn72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Dawn72propdn")]
        public DateTime? Dawn72propdn { get; set; }

        /// <summary>
        /// Gets or sets Dawn72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Dawn72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Dawn72proprs")]
        public DateTime? Dawn72proprs { get; set; }

        /// <summary>
        /// Gets or sets Dawn90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Dawn90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Dawn90")]
        public DateTime? Dawn90 { get; set; }

        /// <summary>
        /// Gets or sets DawnBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("DawnBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("DawnBenIsh72ToGra180propdn")]
        public DateTime? DawnBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets DawnRMF.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("DawnRMF", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("DawnRMF")]
        public DateTime? DawnRMF { get; set; }

        /// <summary>
        /// Gets or sets KetanaBenIsh72ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaBenIsh72ToFastTuc")]
        public DateTime? KetanaBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets KetanaBenIsh72ToGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaBenIsh72ToGra180")]
        public DateTime? KetanaBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets KetanaBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaBenIsh72ToGra180propdn")]
        public DateTime? KetanaBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets KetanaBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaBenIsh72ToGra180proprs")]
        public DateTime? KetanaBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets KetanaBenIsh72ToShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaBenIsh72ToShabbos")]
        public DateTime? KetanaBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets KetanaBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaBenIsh72proprsToRaful")]
        public DateTime? KetanaBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets KetanaBenIsh90ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaBenIsh90ToFastTuc")]
        public DateTime? KetanaBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets KetanaGra.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaGra")]
        public DateTime? KetanaGra { get; set; }

        /// <summary>
        /// Gets or sets KetanaMA72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaMA72")]
        public DateTime? KetanaMA72 { get; set; }

        /// <summary>
        /// Gets or sets KetanaMA72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaMA72fix")]
        public DateTime? KetanaMA72fix { get; set; }

        /// <summary>
        /// Gets or sets KetanaMA72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaMA72propdn")]
        public DateTime? KetanaMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets KetanaMA72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaMA72proprs")]
        public DateTime? KetanaMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets KetanaMA90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("KetanaMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("KetanaMA90")]
        public DateTime? KetanaMA90 { get; set; }

        /// <summary>
        /// Gets or sets MealBenIsh72ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealBenIsh72ToFastTuc")]
        public DateTime? MealBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets MealBenIsh72ToGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealBenIsh72ToGra180")]
        public DateTime? MealBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets MealBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealBenIsh72ToGra180propdn")]
        public DateTime? MealBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets MealBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealBenIsh72ToGra180proprs")]
        public DateTime? MealBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets MealBenIsh72ToShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealBenIsh72ToShabbos")]
        public DateTime? MealBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets MealBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealBenIsh72proprsToRaful")]
        public DateTime? MealBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets MealBenIsh90ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealBenIsh90ToFastTuc")]
        public DateTime? MealBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets MealGra.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealGra")]
        public DateTime? MealGra { get; set; }

        /// <summary>
        /// Gets or sets MealMA72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealMA72")]
        public DateTime? MealMA72 { get; set; }

        /// <summary>
        /// Gets or sets MealMA72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealMA72fix")]
        public DateTime? MealMA72fix { get; set; }

        /// <summary>
        /// Gets or sets MealMA72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealMA72propdn")]
        public DateTime? MealMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets MealMA72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealMA72proprs")]
        public DateTime? MealMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets MealMA90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MealMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MealMA90")]
        public DateTime? MealMA90 { get; set; }

        /// <summary>
        /// Gets or sets Midday.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Midday", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Midday")]
        public DateTime? Midday { get; set; }

        /// <summary>
        /// Gets or sets MiddayBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MiddayBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MiddayBenIsh72proprsToRaful")]
        public DateTime? MiddayBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets MiddayRMF.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MiddayRMF", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MiddayRMF")]
        public DateTime? MiddayRMF { get; set; }

        /// <summary>
        /// Gets or sets Midnight.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Midnight", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Midnight")]
        public DateTime? Midnight { get; set; }

        /// <summary>
        /// Gets or sets Mincha30fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Mincha30fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Mincha30fix")]
        public DateTime? Mincha30fix { get; set; }

        /// <summary>
        /// Gets or sets MinchaBenIsh72ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaBenIsh72ToFastTuc")]
        public DateTime? MinchaBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets MinchaBenIsh72ToGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaBenIsh72ToGra180")]
        public DateTime? MinchaBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets MinchaBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaBenIsh72ToGra180propdn")]
        public DateTime? MinchaBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets MinchaBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaBenIsh72ToGra180proprs")]
        public DateTime? MinchaBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets MinchaBenIsh72ToShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaBenIsh72ToShabbos")]
        public DateTime? MinchaBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets MinchaBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaBenIsh72proprsToRaful")]
        public DateTime? MinchaBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets MinchaBenIsh90ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaBenIsh90ToFastTuc")]
        public DateTime? MinchaBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets MinchaGra.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaGra")]
        public DateTime? MinchaGra { get; set; }

        /// <summary>
        /// Gets or sets MinchaMA72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaMA72")]
        public DateTime? MinchaMA72 { get; set; }

        /// <summary>
        /// Gets or sets MinchaMA72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaMA72fix")]
        public DateTime? MinchaMA72fix { get; set; }

        /// <summary>
        /// Gets or sets MinchaMA72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaMA72propdn")]
        public DateTime? MinchaMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets MinchaMA72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaMA72proprs")]
        public DateTime? MinchaMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets MinchaMA90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaMA90")]
        public DateTime? MinchaMA90 { get; set; }

        /// <summary>
        /// Gets or sets MinchaStrict.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MinchaStrict", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MinchaStrict")]
        public DateTime? MinchaStrict { get; set; }

        /// <summary>
        /// Gets or sets MussafBenIsh72ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafBenIsh72ToFastTuc")]
        public DateTime? MussafBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets MussafBenIsh72ToGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafBenIsh72ToGra180")]
        public DateTime? MussafBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets MussafBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafBenIsh72ToGra180propdn")]
        public DateTime? MussafBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets MussafBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafBenIsh72ToGra180proprs")]
        public DateTime? MussafBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets MussafBenIsh72ToShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafBenIsh72ToShabbos")]
        public DateTime? MussafBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets MussafBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafBenIsh72proprsToRaful")]
        public DateTime? MussafBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets MussafBenIsh90ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafBenIsh90ToFastTuc")]
        public DateTime? MussafBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets MussafGra.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafGra")]
        public DateTime? MussafGra { get; set; }

        /// <summary>
        /// Gets or sets MussafMA72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafMA72")]
        public DateTime? MussafMA72 { get; set; }

        /// <summary>
        /// Gets or sets MussafMA72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafMA72fix")]
        public DateTime? MussafMA72fix { get; set; }

        /// <summary>
        /// Gets or sets MussafMA72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafMA72propdn")]
        public DateTime? MussafMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets MussafMA72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafMA72proprs")]
        public DateTime? MussafMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets MussafMA90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("MussafMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("MussafMA90")]
        public DateTime? MussafMA90 { get; set; }

        /// <summary>
        /// Gets or sets Night40fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Night40fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Night40fix")]
        public DateTime? Night40fix { get; set; }

        /// <summary>
        /// Gets or sets Night50fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Night50fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Night50fix")]
        public DateTime? Night50fix { get; set; }

        /// <summary>
        /// Gets or sets Night60fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Night60fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Night60fix")]
        public DateTime? Night60fix { get; set; }

        /// <summary>
        /// Gets or sets Night72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Night72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Night72")]
        public DateTime? Night72 { get; set; }

        /// <summary>
        /// Gets or sets Night72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Night72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Night72fix")]
        public DateTime? Night72fix { get; set; }

        /// <summary>
        /// Gets or sets Night72fixLevel.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Night72fixLevel", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Night72fixLevel")]
        public DateTime? Night72fixLevel { get; set; }

        /// <summary>
        /// Gets or sets Night72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Night72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Night72propdn")]
        public DateTime? Night72propdn { get; set; }

        /// <summary>
        /// Gets or sets Night72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Night72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Night72proprs")]
        public DateTime? Night72proprs { get; set; }

        /// <summary>
        /// Gets or sets Night90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Night90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Night90")]
        public DateTime? Night90 { get; set; }

        /// <summary>
        /// Gets or sets NightAgudas.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightAgudas", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightAgudas")]
        public DateTime? NightAgudas { get; set; }

        /// <summary>
        /// Gets or sets NightBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightBenIsh72ToGra180propdn")]
        public DateTime? NightBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets NightBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightBenIsh72ToGra180proprs")]
        public DateTime? NightBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets NightChazonIsh.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightChazonIsh", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightChazonIsh")]
        public DateTime? NightChazonIsh { get; set; }

        /// <summary>
        /// Gets or sets NightFastRMF.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightFastRMF", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightFastRMF")]
        public DateTime? NightFastRMF { get; set; }

        /// <summary>
        /// Gets or sets NightFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightFastTuc")]
        public DateTime? NightFastTuc { get; set; }

        /// <summary>
        /// Gets or sets NightGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightGra180")]
        public DateTime? NightGra180 { get; set; }

        /// <summary>
        /// Gets or sets NightGra225.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightGra225", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightGra225")]
        public DateTime? NightGra225 { get; set; }

        /// <summary>
        /// Gets or sets NightGra240.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightGra240", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightGra240")]
        public DateTime? NightGra240 { get; set; }

        /// <summary>
        /// Gets or sets NightMoed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightMoed", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightMoed")]
        public DateTime? NightMoed { get; set; }

        /// <summary>
        /// Gets or sets NightRadun.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightRadun", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightRadun")]
        public DateTime? NightRadun { get; set; }

        /// <summary>
        /// Gets or sets NightRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightRaful")]
        public DateTime? NightRaful { get; set; }

        /// <summary>
        /// Gets or sets NightShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightShabbos")]
        public DateTime? NightShabbos { get; set; }

        /// <summary>
        /// Gets or sets NightZalman.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("NightZalman", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("NightZalman")]
        public DateTime? NightZalman { get; set; }

        /// <summary>
        /// Gets or sets PlagBenIsh72ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagBenIsh72ToFastTuc")]
        public DateTime? PlagBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets PlagBenIsh72ToGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagBenIsh72ToGra180")]
        public DateTime? PlagBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets PlagBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagBenIsh72ToGra180propdn")]
        public DateTime? PlagBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets PlagBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagBenIsh72ToGra180proprs")]
        public DateTime? PlagBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets PlagBenIsh72ToShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagBenIsh72ToShabbos")]
        public DateTime? PlagBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets PlagBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagBenIsh72proprsToRaful")]
        public DateTime? PlagBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets PlagBenIsh90ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagBenIsh90ToFastTuc")]
        public DateTime? PlagBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets PlagGra.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagGra")]
        public DateTime? PlagGra { get; set; }

        /// <summary>
        /// Gets or sets PlagMA72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagMA72")]
        public DateTime? PlagMA72 { get; set; }

        /// <summary>
        /// Gets or sets PlagMA72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagMA72fix")]
        public DateTime? PlagMA72fix { get; set; }

        /// <summary>
        /// Gets or sets PlagMA72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagMA72propdn")]
        public DateTime? PlagMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets PlagMA72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagMA72proprs")]
        public DateTime? PlagMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets PlagMA90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("PlagMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PlagMA90")]
        public DateTime? PlagMA90 { get; set; }

        /// <summary>
        /// Gets or sets PropBenIsh72ToFastTuc.
        /// </summary>
        [JsonProperty("PropBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropBenIsh72ToFastTuc")]
        public long? PropBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets PropBenIsh72ToGra180.
        /// </summary>
        [JsonProperty("PropBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropBenIsh72ToGra180")]
        public long? PropBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets PropBenIsh72ToGra180propdn.
        /// </summary>
        [JsonProperty("PropBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropBenIsh72ToGra180propdn")]
        public long? PropBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets PropBenIsh72ToGra180proprs.
        /// </summary>
        [JsonProperty("PropBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropBenIsh72ToGra180proprs")]
        public long? PropBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets PropBenIsh72ToShabbos.
        /// </summary>
        [JsonProperty("PropBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropBenIsh72ToShabbos")]
        public long? PropBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets PropBenIsh72proprsToRaful.
        /// </summary>
        [JsonProperty("PropBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropBenIsh72proprsToRaful")]
        public long? PropBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets PropBenIsh90ToFastTuc.
        /// </summary>
        [JsonProperty("PropBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropBenIsh90ToFastTuc")]
        public long? PropBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets PropGra.
        /// </summary>
        [JsonProperty("PropGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropGra")]
        public long? PropGra { get; set; }

        /// <summary>
        /// Gets or sets PropMA72.
        /// </summary>
        [JsonProperty("PropMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropMA72")]
        public long? PropMA72 { get; set; }

        /// <summary>
        /// Gets or sets PropMA72fix.
        /// </summary>
        [JsonProperty("PropMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropMA72fix")]
        public long? PropMA72fix { get; set; }

        /// <summary>
        /// Gets or sets PropMA72propdn.
        /// </summary>
        [JsonProperty("PropMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropMA72propdn")]
        public long? PropMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets PropMA72proprs.
        /// </summary>
        [JsonProperty("PropMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropMA72proprs")]
        public long? PropMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets PropMA90.
        /// </summary>
        [JsonProperty("PropMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropMA90")]
        public long? PropMA90 { get; set; }

        /// <summary>
        /// Gets or sets PropRiseToSetElevated.
        /// </summary>
        [JsonProperty("PropRiseToSetElevated", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropRiseToSetElevated")]
        public long? PropRiseToSetElevated { get; set; }

        /// <summary>
        /// Gets or sets PropRmfMorning.
        /// </summary>
        [JsonProperty("PropRmfMorning", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("PropRmfMorning")]
        public long? PropRmfMorning { get; set; }

        /// <summary>
        /// Gets or sets ShachrisBenIsh72ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisBenIsh72ToFastTuc")]
        public DateTime? ShachrisBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets ShachrisBenIsh72ToGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisBenIsh72ToGra180")]
        public DateTime? ShachrisBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets ShachrisBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisBenIsh72ToGra180propdn")]
        public DateTime? ShachrisBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets ShachrisBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisBenIsh72ToGra180proprs")]
        public DateTime? ShachrisBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets ShachrisBenIsh72ToShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisBenIsh72ToShabbos")]
        public DateTime? ShachrisBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets ShachrisBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisBenIsh72proprsToRaful")]
        public DateTime? ShachrisBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets ShachrisBenIsh90ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisBenIsh90ToFastTuc")]
        public DateTime? ShachrisBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets ShachrisGra.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisGra")]
        public DateTime? ShachrisGra { get; set; }

        /// <summary>
        /// Gets or sets ShachrisMA72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisMA72")]
        public DateTime? ShachrisMA72 { get; set; }

        /// <summary>
        /// Gets or sets ShachrisMA72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisMA72fix")]
        public DateTime? ShachrisMA72fix { get; set; }

        /// <summary>
        /// Gets or sets ShachrisMA72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisMA72propdn")]
        public DateTime? ShachrisMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets ShachrisMA72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisMA72proprs")]
        public DateTime? ShachrisMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets ShachrisMA90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisMA90")]
        public DateTime? ShachrisMA90 { get; set; }

        /// <summary>
        /// Gets or sets ShachrisRMF.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShachrisRMF", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShachrisRMF")]
        public DateTime? ShachrisRMF { get; set; }

        /// <summary>
        /// Gets or sets ShemaBenIsh72ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaBenIsh72ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaBenIsh72ToFastTuc")]
        public DateTime? ShemaBenIsh72ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets ShemaBenIsh72ToGra180.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaBenIsh72ToGra180", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaBenIsh72ToGra180")]
        public DateTime? ShemaBenIsh72ToGra180 { get; set; }

        /// <summary>
        /// Gets or sets ShemaBenIsh72ToGra180propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaBenIsh72ToGra180propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaBenIsh72ToGra180propdn")]
        public DateTime? ShemaBenIsh72ToGra180propdn { get; set; }

        /// <summary>
        /// Gets or sets ShemaBenIsh72ToGra180proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaBenIsh72ToGra180proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaBenIsh72ToGra180proprs")]
        public DateTime? ShemaBenIsh72ToGra180proprs { get; set; }

        /// <summary>
        /// Gets or sets ShemaBenIsh72ToShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaBenIsh72ToShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaBenIsh72ToShabbos")]
        public DateTime? ShemaBenIsh72ToShabbos { get; set; }

        /// <summary>
        /// Gets or sets ShemaBenIsh72proprsToRaful.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaBenIsh72proprsToRaful", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaBenIsh72proprsToRaful")]
        public DateTime? ShemaBenIsh72proprsToRaful { get; set; }

        /// <summary>
        /// Gets or sets ShemaBenIsh90ToFastTuc.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaBenIsh90ToFastTuc", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaBenIsh90ToFastTuc")]
        public DateTime? ShemaBenIsh90ToFastTuc { get; set; }

        /// <summary>
        /// Gets or sets ShemaGra.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaGra", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaGra")]
        public DateTime? ShemaGra { get; set; }

        /// <summary>
        /// Gets or sets ShemaMA72.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaMA72", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaMA72")]
        public DateTime? ShemaMA72 { get; set; }

        /// <summary>
        /// Gets or sets ShemaMA72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaMA72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaMA72fix")]
        public DateTime? ShemaMA72fix { get; set; }

        /// <summary>
        /// Gets or sets ShemaMA72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaMA72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaMA72propdn")]
        public DateTime? ShemaMA72propdn { get; set; }

        /// <summary>
        /// Gets or sets ShemaMA72proprs.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaMA72proprs", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaMA72proprs")]
        public DateTime? ShemaMA72proprs { get; set; }

        /// <summary>
        /// Gets or sets ShemaMA90.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaMA90", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaMA90")]
        public DateTime? ShemaMA90 { get; set; }

        /// <summary>
        /// Gets or sets ShemaRMF.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ShemaRMF", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("ShemaRMF")]
        public DateTime? ShemaRMF { get; set; }

        /// <summary>
        /// Gets or sets SunriseDefault.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("SunriseDefault", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SunriseDefault")]
        public DateTime? SunriseDefault { get; set; }

        /// <summary>
        /// Gets or sets SunriseElevated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("SunriseElevated", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SunriseElevated")]
        public DateTime? SunriseElevated { get; set; }

        /// <summary>
        /// Gets or sets SunriseLevel.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("SunriseLevel", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SunriseLevel")]
        public DateTime? SunriseLevel { get; set; }

        /// <summary>
        /// Gets or sets SunsetDefault.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("SunsetDefault", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SunsetDefault")]
        public DateTime? SunsetDefault { get; set; }

        /// <summary>
        /// Gets or sets SunsetElevated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("SunsetElevated", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SunsetElevated")]
        public DateTime? SunsetElevated { get; set; }

        /// <summary>
        /// Gets or sets SunsetLevel.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("SunsetLevel", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("SunsetLevel")]
        public DateTime? SunsetLevel { get; set; }

        /// <summary>
        /// Gets or sets Tomorrow2Night72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Tomorrow2Night72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Tomorrow2Night72fix")]
        public DateTime? Tomorrow2Night72fix { get; set; }

        /// <summary>
        /// Gets or sets Tomorrow2Night72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Tomorrow2Night72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Tomorrow2Night72propdn")]
        public DateTime? Tomorrow2Night72propdn { get; set; }

        /// <summary>
        /// Gets or sets Tomorrow2NightChazonIsh.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Tomorrow2NightChazonIsh", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Tomorrow2NightChazonIsh")]
        public DateTime? Tomorrow2NightChazonIsh { get; set; }

        /// <summary>
        /// Gets or sets Tomorrow2NightShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Tomorrow2NightShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Tomorrow2NightShabbos")]
        public DateTime? Tomorrow2NightShabbos { get; set; }

        /// <summary>
        /// Gets or sets Tomorrow2SunsetDefault.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Tomorrow2SunsetDefault", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Tomorrow2SunsetDefault")]
        public DateTime? Tomorrow2SunsetDefault { get; set; }

        /// <summary>
        /// Gets or sets Tomorrow2SunsetElevated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Tomorrow2SunsetElevated", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Tomorrow2SunsetElevated")]
        public DateTime? Tomorrow2SunsetElevated { get; set; }

        /// <summary>
        /// Gets or sets Tomorrow2SunsetLevel.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Tomorrow2SunsetLevel", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Tomorrow2SunsetLevel")]
        public DateTime? Tomorrow2SunsetLevel { get; set; }

        /// <summary>
        /// Gets or sets TomorrowNight72fix.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowNight72fix", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowNight72fix")]
        public DateTime? TomorrowNight72fix { get; set; }

        /// <summary>
        /// Gets or sets TomorrowNight72propdn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowNight72propdn", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowNight72propdn")]
        public DateTime? TomorrowNight72propdn { get; set; }

        /// <summary>
        /// Gets or sets TomorrowNightChazonIsh.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowNightChazonIsh", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowNightChazonIsh")]
        public DateTime? TomorrowNightChazonIsh { get; set; }

        /// <summary>
        /// Gets or sets TomorrowNightShabbos.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowNightShabbos", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowNightShabbos")]
        public DateTime? TomorrowNightShabbos { get; set; }

        /// <summary>
        /// Gets or sets TomorrowSunriseDefault.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowSunriseDefault", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowSunriseDefault")]
        public DateTime? TomorrowSunriseDefault { get; set; }

        /// <summary>
        /// Gets or sets TomorrowSunriseElevated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowSunriseElevated", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowSunriseElevated")]
        public DateTime? TomorrowSunriseElevated { get; set; }

        /// <summary>
        /// Gets or sets TomorrowSunriseLevel.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowSunriseLevel", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowSunriseLevel")]
        public DateTime? TomorrowSunriseLevel { get; set; }

        /// <summary>
        /// Gets or sets TomorrowSunsetDefault.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowSunsetDefault", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowSunsetDefault")]
        public DateTime? TomorrowSunsetDefault { get; set; }

        /// <summary>
        /// Gets or sets TomorrowSunsetElevated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowSunsetElevated", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowSunsetElevated")]
        public DateTime? TomorrowSunsetElevated { get; set; }

        /// <summary>
        /// Gets or sets TomorrowSunsetLevel.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("TomorrowSunsetLevel", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("TomorrowSunsetLevel")]
        public DateTime? TomorrowSunsetLevel { get; set; }

        /// <summary>
        /// Gets or sets Yakir062.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Yakir062", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Yakir062")]
        public DateTime? Yakir062 { get; set; }

        /// <summary>
        /// Gets or sets Yakir069.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Yakir069", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Yakir069")]
        public DateTime? Yakir069 { get; set; }

        /// <summary>
        /// Gets or sets Yakir102.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Yakir102", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Yakir102")]
        public DateTime? Yakir102 { get; set; }

        /// <summary>
        /// Gets or sets Yakir110.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Yakir110", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Yakir110")]
        public DateTime? Yakir110 { get; set; }

        /// <summary>
        /// Gets or sets Yakir115.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Yakir115", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Yakir115")]
        public DateTime? Yakir115 { get; set; }

        /// <summary>
        /// Gets or sets Yakir120.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("Yakir120", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("Yakir120")]
        public DateTime? Yakir120 { get; set; }

        /// <summary>
        /// Gets or sets YakirDefault.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("YakirDefault", NullValueHandling = NullValueHandling.Ignore)]
        [XmlElement("YakirDefault")]
        public DateTime? YakirDefault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Q6ZmnType : ({string.Join(", ", toStringOutput)})";
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

            return obj is Q6ZmnType other &&
                ((this.Candles == null && other.Candles == null) || (this.Candles?.Equals(other.Candles) == true)) &&
                ((this.Candles10 == null && other.Candles10 == null) || (this.Candles10?.Equals(other.Candles10) == true)) &&
                ((this.Candles15 == null && other.Candles15 == null) || (this.Candles15?.Equals(other.Candles15) == true)) &&
                ((this.Candles18 == null && other.Candles18 == null) || (this.Candles18?.Equals(other.Candles18) == true)) &&
                ((this.Candles20 == null && other.Candles20 == null) || (this.Candles20?.Equals(other.Candles20) == true)) &&
                ((this.Candles22 == null && other.Candles22 == null) || (this.Candles22?.Equals(other.Candles22) == true)) &&
                ((this.Candles30 == null && other.Candles30 == null) || (this.Candles30?.Equals(other.Candles30) == true)) &&
                ((this.Candles40 == null && other.Candles40 == null) || (this.Candles40?.Equals(other.Candles40) == true)) &&
                ((this.ChametzBurnBenIsh72ToFastTuc == null && other.ChametzBurnBenIsh72ToFastTuc == null) || (this.ChametzBurnBenIsh72ToFastTuc?.Equals(other.ChametzBurnBenIsh72ToFastTuc) == true)) &&
                ((this.ChametzBurnBenIsh72ToGra180 == null && other.ChametzBurnBenIsh72ToGra180 == null) || (this.ChametzBurnBenIsh72ToGra180?.Equals(other.ChametzBurnBenIsh72ToGra180) == true)) &&
                ((this.ChametzBurnBenIsh72ToGra180propdn == null && other.ChametzBurnBenIsh72ToGra180propdn == null) || (this.ChametzBurnBenIsh72ToGra180propdn?.Equals(other.ChametzBurnBenIsh72ToGra180propdn) == true)) &&
                ((this.ChametzBurnBenIsh72ToGra180proprs == null && other.ChametzBurnBenIsh72ToGra180proprs == null) || (this.ChametzBurnBenIsh72ToGra180proprs?.Equals(other.ChametzBurnBenIsh72ToGra180proprs) == true)) &&
                ((this.ChametzBurnBenIsh72ToShabbos == null && other.ChametzBurnBenIsh72ToShabbos == null) || (this.ChametzBurnBenIsh72ToShabbos?.Equals(other.ChametzBurnBenIsh72ToShabbos) == true)) &&
                ((this.ChametzBurnBenIsh72proprsToRaful == null && other.ChametzBurnBenIsh72proprsToRaful == null) || (this.ChametzBurnBenIsh72proprsToRaful?.Equals(other.ChametzBurnBenIsh72proprsToRaful) == true)) &&
                ((this.ChametzBurnBenIsh90ToFastTuc == null && other.ChametzBurnBenIsh90ToFastTuc == null) || (this.ChametzBurnBenIsh90ToFastTuc?.Equals(other.ChametzBurnBenIsh90ToFastTuc) == true)) &&
                ((this.ChametzBurnGra == null && other.ChametzBurnGra == null) || (this.ChametzBurnGra?.Equals(other.ChametzBurnGra) == true)) &&
                ((this.ChametzBurnMA72 == null && other.ChametzBurnMA72 == null) || (this.ChametzBurnMA72?.Equals(other.ChametzBurnMA72) == true)) &&
                ((this.ChametzBurnMA72fix == null && other.ChametzBurnMA72fix == null) || (this.ChametzBurnMA72fix?.Equals(other.ChametzBurnMA72fix) == true)) &&
                ((this.ChametzBurnMA72propdn == null && other.ChametzBurnMA72propdn == null) || (this.ChametzBurnMA72propdn?.Equals(other.ChametzBurnMA72propdn) == true)) &&
                ((this.ChametzBurnMA72proprs == null && other.ChametzBurnMA72proprs == null) || (this.ChametzBurnMA72proprs?.Equals(other.ChametzBurnMA72proprs) == true)) &&
                ((this.ChametzBurnMA90 == null && other.ChametzBurnMA90 == null) || (this.ChametzBurnMA90?.Equals(other.ChametzBurnMA90) == true)) &&
                ((this.ChametzBurnRMF == null && other.ChametzBurnRMF == null) || (this.ChametzBurnRMF?.Equals(other.ChametzBurnRMF) == true)) &&
                ((this.ChametzEatBenIsh72ToFastTuc == null && other.ChametzEatBenIsh72ToFastTuc == null) || (this.ChametzEatBenIsh72ToFastTuc?.Equals(other.ChametzEatBenIsh72ToFastTuc) == true)) &&
                ((this.ChametzEatBenIsh72ToGra180 == null && other.ChametzEatBenIsh72ToGra180 == null) || (this.ChametzEatBenIsh72ToGra180?.Equals(other.ChametzEatBenIsh72ToGra180) == true)) &&
                ((this.ChametzEatBenIsh72ToGra180propdn == null && other.ChametzEatBenIsh72ToGra180propdn == null) || (this.ChametzEatBenIsh72ToGra180propdn?.Equals(other.ChametzEatBenIsh72ToGra180propdn) == true)) &&
                ((this.ChametzEatBenIsh72ToGra180proprs == null && other.ChametzEatBenIsh72ToGra180proprs == null) || (this.ChametzEatBenIsh72ToGra180proprs?.Equals(other.ChametzEatBenIsh72ToGra180proprs) == true)) &&
                ((this.ChametzEatBenIsh72ToShabbos == null && other.ChametzEatBenIsh72ToShabbos == null) || (this.ChametzEatBenIsh72ToShabbos?.Equals(other.ChametzEatBenIsh72ToShabbos) == true)) &&
                ((this.ChametzEatBenIsh72proprsToRaful == null && other.ChametzEatBenIsh72proprsToRaful == null) || (this.ChametzEatBenIsh72proprsToRaful?.Equals(other.ChametzEatBenIsh72proprsToRaful) == true)) &&
                ((this.ChametzEatBenIsh90ToFastTuc == null && other.ChametzEatBenIsh90ToFastTuc == null) || (this.ChametzEatBenIsh90ToFastTuc?.Equals(other.ChametzEatBenIsh90ToFastTuc) == true)) &&
                ((this.ChametzEatGra == null && other.ChametzEatGra == null) || (this.ChametzEatGra?.Equals(other.ChametzEatGra) == true)) &&
                ((this.ChametzEatMA72 == null && other.ChametzEatMA72 == null) || (this.ChametzEatMA72?.Equals(other.ChametzEatMA72) == true)) &&
                ((this.ChametzEatMA72fix == null && other.ChametzEatMA72fix == null) || (this.ChametzEatMA72fix?.Equals(other.ChametzEatMA72fix) == true)) &&
                ((this.ChametzEatMA72propdn == null && other.ChametzEatMA72propdn == null) || (this.ChametzEatMA72propdn?.Equals(other.ChametzEatMA72propdn) == true)) &&
                ((this.ChametzEatMA72proprs == null && other.ChametzEatMA72proprs == null) || (this.ChametzEatMA72proprs?.Equals(other.ChametzEatMA72proprs) == true)) &&
                ((this.ChametzEatMA90 == null && other.ChametzEatMA90 == null) || (this.ChametzEatMA90?.Equals(other.ChametzEatMA90) == true)) &&
                ((this.ChametzEatRMF == null && other.ChametzEatRMF == null) || (this.ChametzEatRMF?.Equals(other.ChametzEatRMF) == true)) &&
                ((this.CurrentTime == null && other.CurrentTime == null) || (this.CurrentTime?.Equals(other.CurrentTime) == true)) &&
                ((this.Dawn72 == null && other.Dawn72 == null) || (this.Dawn72?.Equals(other.Dawn72) == true)) &&
                ((this.Dawn72fix == null && other.Dawn72fix == null) || (this.Dawn72fix?.Equals(other.Dawn72fix) == true)) &&
                ((this.Dawn72propdn == null && other.Dawn72propdn == null) || (this.Dawn72propdn?.Equals(other.Dawn72propdn) == true)) &&
                ((this.Dawn72proprs == null && other.Dawn72proprs == null) || (this.Dawn72proprs?.Equals(other.Dawn72proprs) == true)) &&
                ((this.Dawn90 == null && other.Dawn90 == null) || (this.Dawn90?.Equals(other.Dawn90) == true)) &&
                ((this.DawnBenIsh72ToGra180propdn == null && other.DawnBenIsh72ToGra180propdn == null) || (this.DawnBenIsh72ToGra180propdn?.Equals(other.DawnBenIsh72ToGra180propdn) == true)) &&
                ((this.DawnRMF == null && other.DawnRMF == null) || (this.DawnRMF?.Equals(other.DawnRMF) == true)) &&
                ((this.KetanaBenIsh72ToFastTuc == null && other.KetanaBenIsh72ToFastTuc == null) || (this.KetanaBenIsh72ToFastTuc?.Equals(other.KetanaBenIsh72ToFastTuc) == true)) &&
                ((this.KetanaBenIsh72ToGra180 == null && other.KetanaBenIsh72ToGra180 == null) || (this.KetanaBenIsh72ToGra180?.Equals(other.KetanaBenIsh72ToGra180) == true)) &&
                ((this.KetanaBenIsh72ToGra180propdn == null && other.KetanaBenIsh72ToGra180propdn == null) || (this.KetanaBenIsh72ToGra180propdn?.Equals(other.KetanaBenIsh72ToGra180propdn) == true)) &&
                ((this.KetanaBenIsh72ToGra180proprs == null && other.KetanaBenIsh72ToGra180proprs == null) || (this.KetanaBenIsh72ToGra180proprs?.Equals(other.KetanaBenIsh72ToGra180proprs) == true)) &&
                ((this.KetanaBenIsh72ToShabbos == null && other.KetanaBenIsh72ToShabbos == null) || (this.KetanaBenIsh72ToShabbos?.Equals(other.KetanaBenIsh72ToShabbos) == true)) &&
                ((this.KetanaBenIsh72proprsToRaful == null && other.KetanaBenIsh72proprsToRaful == null) || (this.KetanaBenIsh72proprsToRaful?.Equals(other.KetanaBenIsh72proprsToRaful) == true)) &&
                ((this.KetanaBenIsh90ToFastTuc == null && other.KetanaBenIsh90ToFastTuc == null) || (this.KetanaBenIsh90ToFastTuc?.Equals(other.KetanaBenIsh90ToFastTuc) == true)) &&
                ((this.KetanaGra == null && other.KetanaGra == null) || (this.KetanaGra?.Equals(other.KetanaGra) == true)) &&
                ((this.KetanaMA72 == null && other.KetanaMA72 == null) || (this.KetanaMA72?.Equals(other.KetanaMA72) == true)) &&
                ((this.KetanaMA72fix == null && other.KetanaMA72fix == null) || (this.KetanaMA72fix?.Equals(other.KetanaMA72fix) == true)) &&
                ((this.KetanaMA72propdn == null && other.KetanaMA72propdn == null) || (this.KetanaMA72propdn?.Equals(other.KetanaMA72propdn) == true)) &&
                ((this.KetanaMA72proprs == null && other.KetanaMA72proprs == null) || (this.KetanaMA72proprs?.Equals(other.KetanaMA72proprs) == true)) &&
                ((this.KetanaMA90 == null && other.KetanaMA90 == null) || (this.KetanaMA90?.Equals(other.KetanaMA90) == true)) &&
                ((this.MealBenIsh72ToFastTuc == null && other.MealBenIsh72ToFastTuc == null) || (this.MealBenIsh72ToFastTuc?.Equals(other.MealBenIsh72ToFastTuc) == true)) &&
                ((this.MealBenIsh72ToGra180 == null && other.MealBenIsh72ToGra180 == null) || (this.MealBenIsh72ToGra180?.Equals(other.MealBenIsh72ToGra180) == true)) &&
                ((this.MealBenIsh72ToGra180propdn == null && other.MealBenIsh72ToGra180propdn == null) || (this.MealBenIsh72ToGra180propdn?.Equals(other.MealBenIsh72ToGra180propdn) == true)) &&
                ((this.MealBenIsh72ToGra180proprs == null && other.MealBenIsh72ToGra180proprs == null) || (this.MealBenIsh72ToGra180proprs?.Equals(other.MealBenIsh72ToGra180proprs) == true)) &&
                ((this.MealBenIsh72ToShabbos == null && other.MealBenIsh72ToShabbos == null) || (this.MealBenIsh72ToShabbos?.Equals(other.MealBenIsh72ToShabbos) == true)) &&
                ((this.MealBenIsh72proprsToRaful == null && other.MealBenIsh72proprsToRaful == null) || (this.MealBenIsh72proprsToRaful?.Equals(other.MealBenIsh72proprsToRaful) == true)) &&
                ((this.MealBenIsh90ToFastTuc == null && other.MealBenIsh90ToFastTuc == null) || (this.MealBenIsh90ToFastTuc?.Equals(other.MealBenIsh90ToFastTuc) == true)) &&
                ((this.MealGra == null && other.MealGra == null) || (this.MealGra?.Equals(other.MealGra) == true)) &&
                ((this.MealMA72 == null && other.MealMA72 == null) || (this.MealMA72?.Equals(other.MealMA72) == true)) &&
                ((this.MealMA72fix == null && other.MealMA72fix == null) || (this.MealMA72fix?.Equals(other.MealMA72fix) == true)) &&
                ((this.MealMA72propdn == null && other.MealMA72propdn == null) || (this.MealMA72propdn?.Equals(other.MealMA72propdn) == true)) &&
                ((this.MealMA72proprs == null && other.MealMA72proprs == null) || (this.MealMA72proprs?.Equals(other.MealMA72proprs) == true)) &&
                ((this.MealMA90 == null && other.MealMA90 == null) || (this.MealMA90?.Equals(other.MealMA90) == true)) &&
                ((this.Midday == null && other.Midday == null) || (this.Midday?.Equals(other.Midday) == true)) &&
                ((this.MiddayBenIsh72proprsToRaful == null && other.MiddayBenIsh72proprsToRaful == null) || (this.MiddayBenIsh72proprsToRaful?.Equals(other.MiddayBenIsh72proprsToRaful) == true)) &&
                ((this.MiddayRMF == null && other.MiddayRMF == null) || (this.MiddayRMF?.Equals(other.MiddayRMF) == true)) &&
                ((this.Midnight == null && other.Midnight == null) || (this.Midnight?.Equals(other.Midnight) == true)) &&
                ((this.Mincha30fix == null && other.Mincha30fix == null) || (this.Mincha30fix?.Equals(other.Mincha30fix) == true)) &&
                ((this.MinchaBenIsh72ToFastTuc == null && other.MinchaBenIsh72ToFastTuc == null) || (this.MinchaBenIsh72ToFastTuc?.Equals(other.MinchaBenIsh72ToFastTuc) == true)) &&
                ((this.MinchaBenIsh72ToGra180 == null && other.MinchaBenIsh72ToGra180 == null) || (this.MinchaBenIsh72ToGra180?.Equals(other.MinchaBenIsh72ToGra180) == true)) &&
                ((this.MinchaBenIsh72ToGra180propdn == null && other.MinchaBenIsh72ToGra180propdn == null) || (this.MinchaBenIsh72ToGra180propdn?.Equals(other.MinchaBenIsh72ToGra180propdn) == true)) &&
                ((this.MinchaBenIsh72ToGra180proprs == null && other.MinchaBenIsh72ToGra180proprs == null) || (this.MinchaBenIsh72ToGra180proprs?.Equals(other.MinchaBenIsh72ToGra180proprs) == true)) &&
                ((this.MinchaBenIsh72ToShabbos == null && other.MinchaBenIsh72ToShabbos == null) || (this.MinchaBenIsh72ToShabbos?.Equals(other.MinchaBenIsh72ToShabbos) == true)) &&
                ((this.MinchaBenIsh72proprsToRaful == null && other.MinchaBenIsh72proprsToRaful == null) || (this.MinchaBenIsh72proprsToRaful?.Equals(other.MinchaBenIsh72proprsToRaful) == true)) &&
                ((this.MinchaBenIsh90ToFastTuc == null && other.MinchaBenIsh90ToFastTuc == null) || (this.MinchaBenIsh90ToFastTuc?.Equals(other.MinchaBenIsh90ToFastTuc) == true)) &&
                ((this.MinchaGra == null && other.MinchaGra == null) || (this.MinchaGra?.Equals(other.MinchaGra) == true)) &&
                ((this.MinchaMA72 == null && other.MinchaMA72 == null) || (this.MinchaMA72?.Equals(other.MinchaMA72) == true)) &&
                ((this.MinchaMA72fix == null && other.MinchaMA72fix == null) || (this.MinchaMA72fix?.Equals(other.MinchaMA72fix) == true)) &&
                ((this.MinchaMA72propdn == null && other.MinchaMA72propdn == null) || (this.MinchaMA72propdn?.Equals(other.MinchaMA72propdn) == true)) &&
                ((this.MinchaMA72proprs == null && other.MinchaMA72proprs == null) || (this.MinchaMA72proprs?.Equals(other.MinchaMA72proprs) == true)) &&
                ((this.MinchaMA90 == null && other.MinchaMA90 == null) || (this.MinchaMA90?.Equals(other.MinchaMA90) == true)) &&
                ((this.MinchaStrict == null && other.MinchaStrict == null) || (this.MinchaStrict?.Equals(other.MinchaStrict) == true)) &&
                ((this.MussafBenIsh72ToFastTuc == null && other.MussafBenIsh72ToFastTuc == null) || (this.MussafBenIsh72ToFastTuc?.Equals(other.MussafBenIsh72ToFastTuc) == true)) &&
                ((this.MussafBenIsh72ToGra180 == null && other.MussafBenIsh72ToGra180 == null) || (this.MussafBenIsh72ToGra180?.Equals(other.MussafBenIsh72ToGra180) == true)) &&
                ((this.MussafBenIsh72ToGra180propdn == null && other.MussafBenIsh72ToGra180propdn == null) || (this.MussafBenIsh72ToGra180propdn?.Equals(other.MussafBenIsh72ToGra180propdn) == true)) &&
                ((this.MussafBenIsh72ToGra180proprs == null && other.MussafBenIsh72ToGra180proprs == null) || (this.MussafBenIsh72ToGra180proprs?.Equals(other.MussafBenIsh72ToGra180proprs) == true)) &&
                ((this.MussafBenIsh72ToShabbos == null && other.MussafBenIsh72ToShabbos == null) || (this.MussafBenIsh72ToShabbos?.Equals(other.MussafBenIsh72ToShabbos) == true)) &&
                ((this.MussafBenIsh72proprsToRaful == null && other.MussafBenIsh72proprsToRaful == null) || (this.MussafBenIsh72proprsToRaful?.Equals(other.MussafBenIsh72proprsToRaful) == true)) &&
                ((this.MussafBenIsh90ToFastTuc == null && other.MussafBenIsh90ToFastTuc == null) || (this.MussafBenIsh90ToFastTuc?.Equals(other.MussafBenIsh90ToFastTuc) == true)) &&
                ((this.MussafGra == null && other.MussafGra == null) || (this.MussafGra?.Equals(other.MussafGra) == true)) &&
                ((this.MussafMA72 == null && other.MussafMA72 == null) || (this.MussafMA72?.Equals(other.MussafMA72) == true)) &&
                ((this.MussafMA72fix == null && other.MussafMA72fix == null) || (this.MussafMA72fix?.Equals(other.MussafMA72fix) == true)) &&
                ((this.MussafMA72propdn == null && other.MussafMA72propdn == null) || (this.MussafMA72propdn?.Equals(other.MussafMA72propdn) == true)) &&
                ((this.MussafMA72proprs == null && other.MussafMA72proprs == null) || (this.MussafMA72proprs?.Equals(other.MussafMA72proprs) == true)) &&
                ((this.MussafMA90 == null && other.MussafMA90 == null) || (this.MussafMA90?.Equals(other.MussafMA90) == true)) &&
                ((this.Night40fix == null && other.Night40fix == null) || (this.Night40fix?.Equals(other.Night40fix) == true)) &&
                ((this.Night50fix == null && other.Night50fix == null) || (this.Night50fix?.Equals(other.Night50fix) == true)) &&
                ((this.Night60fix == null && other.Night60fix == null) || (this.Night60fix?.Equals(other.Night60fix) == true)) &&
                ((this.Night72 == null && other.Night72 == null) || (this.Night72?.Equals(other.Night72) == true)) &&
                ((this.Night72fix == null && other.Night72fix == null) || (this.Night72fix?.Equals(other.Night72fix) == true)) &&
                ((this.Night72fixLevel == null && other.Night72fixLevel == null) || (this.Night72fixLevel?.Equals(other.Night72fixLevel) == true)) &&
                ((this.Night72propdn == null && other.Night72propdn == null) || (this.Night72propdn?.Equals(other.Night72propdn) == true)) &&
                ((this.Night72proprs == null && other.Night72proprs == null) || (this.Night72proprs?.Equals(other.Night72proprs) == true)) &&
                ((this.Night90 == null && other.Night90 == null) || (this.Night90?.Equals(other.Night90) == true)) &&
                ((this.NightAgudas == null && other.NightAgudas == null) || (this.NightAgudas?.Equals(other.NightAgudas) == true)) &&
                ((this.NightBenIsh72ToGra180propdn == null && other.NightBenIsh72ToGra180propdn == null) || (this.NightBenIsh72ToGra180propdn?.Equals(other.NightBenIsh72ToGra180propdn) == true)) &&
                ((this.NightBenIsh72ToGra180proprs == null && other.NightBenIsh72ToGra180proprs == null) || (this.NightBenIsh72ToGra180proprs?.Equals(other.NightBenIsh72ToGra180proprs) == true)) &&
                ((this.NightChazonIsh == null && other.NightChazonIsh == null) || (this.NightChazonIsh?.Equals(other.NightChazonIsh) == true)) &&
                ((this.NightFastRMF == null && other.NightFastRMF == null) || (this.NightFastRMF?.Equals(other.NightFastRMF) == true)) &&
                ((this.NightFastTuc == null && other.NightFastTuc == null) || (this.NightFastTuc?.Equals(other.NightFastTuc) == true)) &&
                ((this.NightGra180 == null && other.NightGra180 == null) || (this.NightGra180?.Equals(other.NightGra180) == true)) &&
                ((this.NightGra225 == null && other.NightGra225 == null) || (this.NightGra225?.Equals(other.NightGra225) == true)) &&
                ((this.NightGra240 == null && other.NightGra240 == null) || (this.NightGra240?.Equals(other.NightGra240) == true)) &&
                ((this.NightMoed == null && other.NightMoed == null) || (this.NightMoed?.Equals(other.NightMoed) == true)) &&
                ((this.NightRadun == null && other.NightRadun == null) || (this.NightRadun?.Equals(other.NightRadun) == true)) &&
                ((this.NightRaful == null && other.NightRaful == null) || (this.NightRaful?.Equals(other.NightRaful) == true)) &&
                ((this.NightShabbos == null && other.NightShabbos == null) || (this.NightShabbos?.Equals(other.NightShabbos) == true)) &&
                ((this.NightZalman == null && other.NightZalman == null) || (this.NightZalman?.Equals(other.NightZalman) == true)) &&
                ((this.PlagBenIsh72ToFastTuc == null && other.PlagBenIsh72ToFastTuc == null) || (this.PlagBenIsh72ToFastTuc?.Equals(other.PlagBenIsh72ToFastTuc) == true)) &&
                ((this.PlagBenIsh72ToGra180 == null && other.PlagBenIsh72ToGra180 == null) || (this.PlagBenIsh72ToGra180?.Equals(other.PlagBenIsh72ToGra180) == true)) &&
                ((this.PlagBenIsh72ToGra180propdn == null && other.PlagBenIsh72ToGra180propdn == null) || (this.PlagBenIsh72ToGra180propdn?.Equals(other.PlagBenIsh72ToGra180propdn) == true)) &&
                ((this.PlagBenIsh72ToGra180proprs == null && other.PlagBenIsh72ToGra180proprs == null) || (this.PlagBenIsh72ToGra180proprs?.Equals(other.PlagBenIsh72ToGra180proprs) == true)) &&
                ((this.PlagBenIsh72ToShabbos == null && other.PlagBenIsh72ToShabbos == null) || (this.PlagBenIsh72ToShabbos?.Equals(other.PlagBenIsh72ToShabbos) == true)) &&
                ((this.PlagBenIsh72proprsToRaful == null && other.PlagBenIsh72proprsToRaful == null) || (this.PlagBenIsh72proprsToRaful?.Equals(other.PlagBenIsh72proprsToRaful) == true)) &&
                ((this.PlagBenIsh90ToFastTuc == null && other.PlagBenIsh90ToFastTuc == null) || (this.PlagBenIsh90ToFastTuc?.Equals(other.PlagBenIsh90ToFastTuc) == true)) &&
                ((this.PlagGra == null && other.PlagGra == null) || (this.PlagGra?.Equals(other.PlagGra) == true)) &&
                ((this.PlagMA72 == null && other.PlagMA72 == null) || (this.PlagMA72?.Equals(other.PlagMA72) == true)) &&
                ((this.PlagMA72fix == null && other.PlagMA72fix == null) || (this.PlagMA72fix?.Equals(other.PlagMA72fix) == true)) &&
                ((this.PlagMA72propdn == null && other.PlagMA72propdn == null) || (this.PlagMA72propdn?.Equals(other.PlagMA72propdn) == true)) &&
                ((this.PlagMA72proprs == null && other.PlagMA72proprs == null) || (this.PlagMA72proprs?.Equals(other.PlagMA72proprs) == true)) &&
                ((this.PlagMA90 == null && other.PlagMA90 == null) || (this.PlagMA90?.Equals(other.PlagMA90) == true)) &&
                ((this.PropBenIsh72ToFastTuc == null && other.PropBenIsh72ToFastTuc == null) || (this.PropBenIsh72ToFastTuc?.Equals(other.PropBenIsh72ToFastTuc) == true)) &&
                ((this.PropBenIsh72ToGra180 == null && other.PropBenIsh72ToGra180 == null) || (this.PropBenIsh72ToGra180?.Equals(other.PropBenIsh72ToGra180) == true)) &&
                ((this.PropBenIsh72ToGra180propdn == null && other.PropBenIsh72ToGra180propdn == null) || (this.PropBenIsh72ToGra180propdn?.Equals(other.PropBenIsh72ToGra180propdn) == true)) &&
                ((this.PropBenIsh72ToGra180proprs == null && other.PropBenIsh72ToGra180proprs == null) || (this.PropBenIsh72ToGra180proprs?.Equals(other.PropBenIsh72ToGra180proprs) == true)) &&
                ((this.PropBenIsh72ToShabbos == null && other.PropBenIsh72ToShabbos == null) || (this.PropBenIsh72ToShabbos?.Equals(other.PropBenIsh72ToShabbos) == true)) &&
                ((this.PropBenIsh72proprsToRaful == null && other.PropBenIsh72proprsToRaful == null) || (this.PropBenIsh72proprsToRaful?.Equals(other.PropBenIsh72proprsToRaful) == true)) &&
                ((this.PropBenIsh90ToFastTuc == null && other.PropBenIsh90ToFastTuc == null) || (this.PropBenIsh90ToFastTuc?.Equals(other.PropBenIsh90ToFastTuc) == true)) &&
                ((this.PropGra == null && other.PropGra == null) || (this.PropGra?.Equals(other.PropGra) == true)) &&
                ((this.PropMA72 == null && other.PropMA72 == null) || (this.PropMA72?.Equals(other.PropMA72) == true)) &&
                ((this.PropMA72fix == null && other.PropMA72fix == null) || (this.PropMA72fix?.Equals(other.PropMA72fix) == true)) &&
                ((this.PropMA72propdn == null && other.PropMA72propdn == null) || (this.PropMA72propdn?.Equals(other.PropMA72propdn) == true)) &&
                ((this.PropMA72proprs == null && other.PropMA72proprs == null) || (this.PropMA72proprs?.Equals(other.PropMA72proprs) == true)) &&
                ((this.PropMA90 == null && other.PropMA90 == null) || (this.PropMA90?.Equals(other.PropMA90) == true)) &&
                ((this.PropRiseToSetElevated == null && other.PropRiseToSetElevated == null) || (this.PropRiseToSetElevated?.Equals(other.PropRiseToSetElevated) == true)) &&
                ((this.PropRmfMorning == null && other.PropRmfMorning == null) || (this.PropRmfMorning?.Equals(other.PropRmfMorning) == true)) &&
                ((this.ShachrisBenIsh72ToFastTuc == null && other.ShachrisBenIsh72ToFastTuc == null) || (this.ShachrisBenIsh72ToFastTuc?.Equals(other.ShachrisBenIsh72ToFastTuc) == true)) &&
                ((this.ShachrisBenIsh72ToGra180 == null && other.ShachrisBenIsh72ToGra180 == null) || (this.ShachrisBenIsh72ToGra180?.Equals(other.ShachrisBenIsh72ToGra180) == true)) &&
                ((this.ShachrisBenIsh72ToGra180propdn == null && other.ShachrisBenIsh72ToGra180propdn == null) || (this.ShachrisBenIsh72ToGra180propdn?.Equals(other.ShachrisBenIsh72ToGra180propdn) == true)) &&
                ((this.ShachrisBenIsh72ToGra180proprs == null && other.ShachrisBenIsh72ToGra180proprs == null) || (this.ShachrisBenIsh72ToGra180proprs?.Equals(other.ShachrisBenIsh72ToGra180proprs) == true)) &&
                ((this.ShachrisBenIsh72ToShabbos == null && other.ShachrisBenIsh72ToShabbos == null) || (this.ShachrisBenIsh72ToShabbos?.Equals(other.ShachrisBenIsh72ToShabbos) == true)) &&
                ((this.ShachrisBenIsh72proprsToRaful == null && other.ShachrisBenIsh72proprsToRaful == null) || (this.ShachrisBenIsh72proprsToRaful?.Equals(other.ShachrisBenIsh72proprsToRaful) == true)) &&
                ((this.ShachrisBenIsh90ToFastTuc == null && other.ShachrisBenIsh90ToFastTuc == null) || (this.ShachrisBenIsh90ToFastTuc?.Equals(other.ShachrisBenIsh90ToFastTuc) == true)) &&
                ((this.ShachrisGra == null && other.ShachrisGra == null) || (this.ShachrisGra?.Equals(other.ShachrisGra) == true)) &&
                ((this.ShachrisMA72 == null && other.ShachrisMA72 == null) || (this.ShachrisMA72?.Equals(other.ShachrisMA72) == true)) &&
                ((this.ShachrisMA72fix == null && other.ShachrisMA72fix == null) || (this.ShachrisMA72fix?.Equals(other.ShachrisMA72fix) == true)) &&
                ((this.ShachrisMA72propdn == null && other.ShachrisMA72propdn == null) || (this.ShachrisMA72propdn?.Equals(other.ShachrisMA72propdn) == true)) &&
                ((this.ShachrisMA72proprs == null && other.ShachrisMA72proprs == null) || (this.ShachrisMA72proprs?.Equals(other.ShachrisMA72proprs) == true)) &&
                ((this.ShachrisMA90 == null && other.ShachrisMA90 == null) || (this.ShachrisMA90?.Equals(other.ShachrisMA90) == true)) &&
                ((this.ShachrisRMF == null && other.ShachrisRMF == null) || (this.ShachrisRMF?.Equals(other.ShachrisRMF) == true)) &&
                ((this.ShemaBenIsh72ToFastTuc == null && other.ShemaBenIsh72ToFastTuc == null) || (this.ShemaBenIsh72ToFastTuc?.Equals(other.ShemaBenIsh72ToFastTuc) == true)) &&
                ((this.ShemaBenIsh72ToGra180 == null && other.ShemaBenIsh72ToGra180 == null) || (this.ShemaBenIsh72ToGra180?.Equals(other.ShemaBenIsh72ToGra180) == true)) &&
                ((this.ShemaBenIsh72ToGra180propdn == null && other.ShemaBenIsh72ToGra180propdn == null) || (this.ShemaBenIsh72ToGra180propdn?.Equals(other.ShemaBenIsh72ToGra180propdn) == true)) &&
                ((this.ShemaBenIsh72ToGra180proprs == null && other.ShemaBenIsh72ToGra180proprs == null) || (this.ShemaBenIsh72ToGra180proprs?.Equals(other.ShemaBenIsh72ToGra180proprs) == true)) &&
                ((this.ShemaBenIsh72ToShabbos == null && other.ShemaBenIsh72ToShabbos == null) || (this.ShemaBenIsh72ToShabbos?.Equals(other.ShemaBenIsh72ToShabbos) == true)) &&
                ((this.ShemaBenIsh72proprsToRaful == null && other.ShemaBenIsh72proprsToRaful == null) || (this.ShemaBenIsh72proprsToRaful?.Equals(other.ShemaBenIsh72proprsToRaful) == true)) &&
                ((this.ShemaBenIsh90ToFastTuc == null && other.ShemaBenIsh90ToFastTuc == null) || (this.ShemaBenIsh90ToFastTuc?.Equals(other.ShemaBenIsh90ToFastTuc) == true)) &&
                ((this.ShemaGra == null && other.ShemaGra == null) || (this.ShemaGra?.Equals(other.ShemaGra) == true)) &&
                ((this.ShemaMA72 == null && other.ShemaMA72 == null) || (this.ShemaMA72?.Equals(other.ShemaMA72) == true)) &&
                ((this.ShemaMA72fix == null && other.ShemaMA72fix == null) || (this.ShemaMA72fix?.Equals(other.ShemaMA72fix) == true)) &&
                ((this.ShemaMA72propdn == null && other.ShemaMA72propdn == null) || (this.ShemaMA72propdn?.Equals(other.ShemaMA72propdn) == true)) &&
                ((this.ShemaMA72proprs == null && other.ShemaMA72proprs == null) || (this.ShemaMA72proprs?.Equals(other.ShemaMA72proprs) == true)) &&
                ((this.ShemaMA90 == null && other.ShemaMA90 == null) || (this.ShemaMA90?.Equals(other.ShemaMA90) == true)) &&
                ((this.ShemaRMF == null && other.ShemaRMF == null) || (this.ShemaRMF?.Equals(other.ShemaRMF) == true)) &&
                ((this.SunriseDefault == null && other.SunriseDefault == null) || (this.SunriseDefault?.Equals(other.SunriseDefault) == true)) &&
                ((this.SunriseElevated == null && other.SunriseElevated == null) || (this.SunriseElevated?.Equals(other.SunriseElevated) == true)) &&
                ((this.SunriseLevel == null && other.SunriseLevel == null) || (this.SunriseLevel?.Equals(other.SunriseLevel) == true)) &&
                ((this.SunsetDefault == null && other.SunsetDefault == null) || (this.SunsetDefault?.Equals(other.SunsetDefault) == true)) &&
                ((this.SunsetElevated == null && other.SunsetElevated == null) || (this.SunsetElevated?.Equals(other.SunsetElevated) == true)) &&
                ((this.SunsetLevel == null && other.SunsetLevel == null) || (this.SunsetLevel?.Equals(other.SunsetLevel) == true)) &&
                ((this.Tomorrow2Night72fix == null && other.Tomorrow2Night72fix == null) || (this.Tomorrow2Night72fix?.Equals(other.Tomorrow2Night72fix) == true)) &&
                ((this.Tomorrow2Night72propdn == null && other.Tomorrow2Night72propdn == null) || (this.Tomorrow2Night72propdn?.Equals(other.Tomorrow2Night72propdn) == true)) &&
                ((this.Tomorrow2NightChazonIsh == null && other.Tomorrow2NightChazonIsh == null) || (this.Tomorrow2NightChazonIsh?.Equals(other.Tomorrow2NightChazonIsh) == true)) &&
                ((this.Tomorrow2NightShabbos == null && other.Tomorrow2NightShabbos == null) || (this.Tomorrow2NightShabbos?.Equals(other.Tomorrow2NightShabbos) == true)) &&
                ((this.Tomorrow2SunsetDefault == null && other.Tomorrow2SunsetDefault == null) || (this.Tomorrow2SunsetDefault?.Equals(other.Tomorrow2SunsetDefault) == true)) &&
                ((this.Tomorrow2SunsetElevated == null && other.Tomorrow2SunsetElevated == null) || (this.Tomorrow2SunsetElevated?.Equals(other.Tomorrow2SunsetElevated) == true)) &&
                ((this.Tomorrow2SunsetLevel == null && other.Tomorrow2SunsetLevel == null) || (this.Tomorrow2SunsetLevel?.Equals(other.Tomorrow2SunsetLevel) == true)) &&
                ((this.TomorrowNight72fix == null && other.TomorrowNight72fix == null) || (this.TomorrowNight72fix?.Equals(other.TomorrowNight72fix) == true)) &&
                ((this.TomorrowNight72propdn == null && other.TomorrowNight72propdn == null) || (this.TomorrowNight72propdn?.Equals(other.TomorrowNight72propdn) == true)) &&
                ((this.TomorrowNightChazonIsh == null && other.TomorrowNightChazonIsh == null) || (this.TomorrowNightChazonIsh?.Equals(other.TomorrowNightChazonIsh) == true)) &&
                ((this.TomorrowNightShabbos == null && other.TomorrowNightShabbos == null) || (this.TomorrowNightShabbos?.Equals(other.TomorrowNightShabbos) == true)) &&
                ((this.TomorrowSunriseDefault == null && other.TomorrowSunriseDefault == null) || (this.TomorrowSunriseDefault?.Equals(other.TomorrowSunriseDefault) == true)) &&
                ((this.TomorrowSunriseElevated == null && other.TomorrowSunriseElevated == null) || (this.TomorrowSunriseElevated?.Equals(other.TomorrowSunriseElevated) == true)) &&
                ((this.TomorrowSunriseLevel == null && other.TomorrowSunriseLevel == null) || (this.TomorrowSunriseLevel?.Equals(other.TomorrowSunriseLevel) == true)) &&
                ((this.TomorrowSunsetDefault == null && other.TomorrowSunsetDefault == null) || (this.TomorrowSunsetDefault?.Equals(other.TomorrowSunsetDefault) == true)) &&
                ((this.TomorrowSunsetElevated == null && other.TomorrowSunsetElevated == null) || (this.TomorrowSunsetElevated?.Equals(other.TomorrowSunsetElevated) == true)) &&
                ((this.TomorrowSunsetLevel == null && other.TomorrowSunsetLevel == null) || (this.TomorrowSunsetLevel?.Equals(other.TomorrowSunsetLevel) == true)) &&
                ((this.Yakir062 == null && other.Yakir062 == null) || (this.Yakir062?.Equals(other.Yakir062) == true)) &&
                ((this.Yakir069 == null && other.Yakir069 == null) || (this.Yakir069?.Equals(other.Yakir069) == true)) &&
                ((this.Yakir102 == null && other.Yakir102 == null) || (this.Yakir102?.Equals(other.Yakir102) == true)) &&
                ((this.Yakir110 == null && other.Yakir110 == null) || (this.Yakir110?.Equals(other.Yakir110) == true)) &&
                ((this.Yakir115 == null && other.Yakir115 == null) || (this.Yakir115?.Equals(other.Yakir115) == true)) &&
                ((this.Yakir120 == null && other.Yakir120 == null) || (this.Yakir120?.Equals(other.Yakir120) == true)) &&
                ((this.YakirDefault == null && other.YakirDefault == null) || (this.YakirDefault?.Equals(other.YakirDefault) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Candles = {(this.Candles == null ? "null" : this.Candles.ToString())}");
            toStringOutput.Add($"this.Candles10 = {(this.Candles10 == null ? "null" : this.Candles10.ToString())}");
            toStringOutput.Add($"this.Candles15 = {(this.Candles15 == null ? "null" : this.Candles15.ToString())}");
            toStringOutput.Add($"this.Candles18 = {(this.Candles18 == null ? "null" : this.Candles18.ToString())}");
            toStringOutput.Add($"this.Candles20 = {(this.Candles20 == null ? "null" : this.Candles20.ToString())}");
            toStringOutput.Add($"this.Candles22 = {(this.Candles22 == null ? "null" : this.Candles22.ToString())}");
            toStringOutput.Add($"this.Candles30 = {(this.Candles30 == null ? "null" : this.Candles30.ToString())}");
            toStringOutput.Add($"this.Candles40 = {(this.Candles40 == null ? "null" : this.Candles40.ToString())}");
            toStringOutput.Add($"this.ChametzBurnBenIsh72ToFastTuc = {(this.ChametzBurnBenIsh72ToFastTuc == null ? "null" : this.ChametzBurnBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.ChametzBurnBenIsh72ToGra180 = {(this.ChametzBurnBenIsh72ToGra180 == null ? "null" : this.ChametzBurnBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.ChametzBurnBenIsh72ToGra180propdn = {(this.ChametzBurnBenIsh72ToGra180propdn == null ? "null" : this.ChametzBurnBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.ChametzBurnBenIsh72ToGra180proprs = {(this.ChametzBurnBenIsh72ToGra180proprs == null ? "null" : this.ChametzBurnBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.ChametzBurnBenIsh72ToShabbos = {(this.ChametzBurnBenIsh72ToShabbos == null ? "null" : this.ChametzBurnBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.ChametzBurnBenIsh72proprsToRaful = {(this.ChametzBurnBenIsh72proprsToRaful == null ? "null" : this.ChametzBurnBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.ChametzBurnBenIsh90ToFastTuc = {(this.ChametzBurnBenIsh90ToFastTuc == null ? "null" : this.ChametzBurnBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.ChametzBurnGra = {(this.ChametzBurnGra == null ? "null" : this.ChametzBurnGra.ToString())}");
            toStringOutput.Add($"this.ChametzBurnMA72 = {(this.ChametzBurnMA72 == null ? "null" : this.ChametzBurnMA72.ToString())}");
            toStringOutput.Add($"this.ChametzBurnMA72fix = {(this.ChametzBurnMA72fix == null ? "null" : this.ChametzBurnMA72fix.ToString())}");
            toStringOutput.Add($"this.ChametzBurnMA72propdn = {(this.ChametzBurnMA72propdn == null ? "null" : this.ChametzBurnMA72propdn.ToString())}");
            toStringOutput.Add($"this.ChametzBurnMA72proprs = {(this.ChametzBurnMA72proprs == null ? "null" : this.ChametzBurnMA72proprs.ToString())}");
            toStringOutput.Add($"this.ChametzBurnMA90 = {(this.ChametzBurnMA90 == null ? "null" : this.ChametzBurnMA90.ToString())}");
            toStringOutput.Add($"this.ChametzBurnRMF = {(this.ChametzBurnRMF == null ? "null" : this.ChametzBurnRMF.ToString())}");
            toStringOutput.Add($"this.ChametzEatBenIsh72ToFastTuc = {(this.ChametzEatBenIsh72ToFastTuc == null ? "null" : this.ChametzEatBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.ChametzEatBenIsh72ToGra180 = {(this.ChametzEatBenIsh72ToGra180 == null ? "null" : this.ChametzEatBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.ChametzEatBenIsh72ToGra180propdn = {(this.ChametzEatBenIsh72ToGra180propdn == null ? "null" : this.ChametzEatBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.ChametzEatBenIsh72ToGra180proprs = {(this.ChametzEatBenIsh72ToGra180proprs == null ? "null" : this.ChametzEatBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.ChametzEatBenIsh72ToShabbos = {(this.ChametzEatBenIsh72ToShabbos == null ? "null" : this.ChametzEatBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.ChametzEatBenIsh72proprsToRaful = {(this.ChametzEatBenIsh72proprsToRaful == null ? "null" : this.ChametzEatBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.ChametzEatBenIsh90ToFastTuc = {(this.ChametzEatBenIsh90ToFastTuc == null ? "null" : this.ChametzEatBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.ChametzEatGra = {(this.ChametzEatGra == null ? "null" : this.ChametzEatGra.ToString())}");
            toStringOutput.Add($"this.ChametzEatMA72 = {(this.ChametzEatMA72 == null ? "null" : this.ChametzEatMA72.ToString())}");
            toStringOutput.Add($"this.ChametzEatMA72fix = {(this.ChametzEatMA72fix == null ? "null" : this.ChametzEatMA72fix.ToString())}");
            toStringOutput.Add($"this.ChametzEatMA72propdn = {(this.ChametzEatMA72propdn == null ? "null" : this.ChametzEatMA72propdn.ToString())}");
            toStringOutput.Add($"this.ChametzEatMA72proprs = {(this.ChametzEatMA72proprs == null ? "null" : this.ChametzEatMA72proprs.ToString())}");
            toStringOutput.Add($"this.ChametzEatMA90 = {(this.ChametzEatMA90 == null ? "null" : this.ChametzEatMA90.ToString())}");
            toStringOutput.Add($"this.ChametzEatRMF = {(this.ChametzEatRMF == null ? "null" : this.ChametzEatRMF.ToString())}");
            toStringOutput.Add($"this.CurrentTime = {(this.CurrentTime == null ? "null" : this.CurrentTime.ToString())}");
            toStringOutput.Add($"this.Dawn72 = {(this.Dawn72 == null ? "null" : this.Dawn72.ToString())}");
            toStringOutput.Add($"this.Dawn72fix = {(this.Dawn72fix == null ? "null" : this.Dawn72fix.ToString())}");
            toStringOutput.Add($"this.Dawn72propdn = {(this.Dawn72propdn == null ? "null" : this.Dawn72propdn.ToString())}");
            toStringOutput.Add($"this.Dawn72proprs = {(this.Dawn72proprs == null ? "null" : this.Dawn72proprs.ToString())}");
            toStringOutput.Add($"this.Dawn90 = {(this.Dawn90 == null ? "null" : this.Dawn90.ToString())}");
            toStringOutput.Add($"this.DawnBenIsh72ToGra180propdn = {(this.DawnBenIsh72ToGra180propdn == null ? "null" : this.DawnBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.DawnRMF = {(this.DawnRMF == null ? "null" : this.DawnRMF.ToString())}");
            toStringOutput.Add($"this.KetanaBenIsh72ToFastTuc = {(this.KetanaBenIsh72ToFastTuc == null ? "null" : this.KetanaBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.KetanaBenIsh72ToGra180 = {(this.KetanaBenIsh72ToGra180 == null ? "null" : this.KetanaBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.KetanaBenIsh72ToGra180propdn = {(this.KetanaBenIsh72ToGra180propdn == null ? "null" : this.KetanaBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.KetanaBenIsh72ToGra180proprs = {(this.KetanaBenIsh72ToGra180proprs == null ? "null" : this.KetanaBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.KetanaBenIsh72ToShabbos = {(this.KetanaBenIsh72ToShabbos == null ? "null" : this.KetanaBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.KetanaBenIsh72proprsToRaful = {(this.KetanaBenIsh72proprsToRaful == null ? "null" : this.KetanaBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.KetanaBenIsh90ToFastTuc = {(this.KetanaBenIsh90ToFastTuc == null ? "null" : this.KetanaBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.KetanaGra = {(this.KetanaGra == null ? "null" : this.KetanaGra.ToString())}");
            toStringOutput.Add($"this.KetanaMA72 = {(this.KetanaMA72 == null ? "null" : this.KetanaMA72.ToString())}");
            toStringOutput.Add($"this.KetanaMA72fix = {(this.KetanaMA72fix == null ? "null" : this.KetanaMA72fix.ToString())}");
            toStringOutput.Add($"this.KetanaMA72propdn = {(this.KetanaMA72propdn == null ? "null" : this.KetanaMA72propdn.ToString())}");
            toStringOutput.Add($"this.KetanaMA72proprs = {(this.KetanaMA72proprs == null ? "null" : this.KetanaMA72proprs.ToString())}");
            toStringOutput.Add($"this.KetanaMA90 = {(this.KetanaMA90 == null ? "null" : this.KetanaMA90.ToString())}");
            toStringOutput.Add($"this.MealBenIsh72ToFastTuc = {(this.MealBenIsh72ToFastTuc == null ? "null" : this.MealBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.MealBenIsh72ToGra180 = {(this.MealBenIsh72ToGra180 == null ? "null" : this.MealBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.MealBenIsh72ToGra180propdn = {(this.MealBenIsh72ToGra180propdn == null ? "null" : this.MealBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.MealBenIsh72ToGra180proprs = {(this.MealBenIsh72ToGra180proprs == null ? "null" : this.MealBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.MealBenIsh72ToShabbos = {(this.MealBenIsh72ToShabbos == null ? "null" : this.MealBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.MealBenIsh72proprsToRaful = {(this.MealBenIsh72proprsToRaful == null ? "null" : this.MealBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.MealBenIsh90ToFastTuc = {(this.MealBenIsh90ToFastTuc == null ? "null" : this.MealBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.MealGra = {(this.MealGra == null ? "null" : this.MealGra.ToString())}");
            toStringOutput.Add($"this.MealMA72 = {(this.MealMA72 == null ? "null" : this.MealMA72.ToString())}");
            toStringOutput.Add($"this.MealMA72fix = {(this.MealMA72fix == null ? "null" : this.MealMA72fix.ToString())}");
            toStringOutput.Add($"this.MealMA72propdn = {(this.MealMA72propdn == null ? "null" : this.MealMA72propdn.ToString())}");
            toStringOutput.Add($"this.MealMA72proprs = {(this.MealMA72proprs == null ? "null" : this.MealMA72proprs.ToString())}");
            toStringOutput.Add($"this.MealMA90 = {(this.MealMA90 == null ? "null" : this.MealMA90.ToString())}");
            toStringOutput.Add($"this.Midday = {(this.Midday == null ? "null" : this.Midday.ToString())}");
            toStringOutput.Add($"this.MiddayBenIsh72proprsToRaful = {(this.MiddayBenIsh72proprsToRaful == null ? "null" : this.MiddayBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.MiddayRMF = {(this.MiddayRMF == null ? "null" : this.MiddayRMF.ToString())}");
            toStringOutput.Add($"this.Midnight = {(this.Midnight == null ? "null" : this.Midnight.ToString())}");
            toStringOutput.Add($"this.Mincha30fix = {(this.Mincha30fix == null ? "null" : this.Mincha30fix.ToString())}");
            toStringOutput.Add($"this.MinchaBenIsh72ToFastTuc = {(this.MinchaBenIsh72ToFastTuc == null ? "null" : this.MinchaBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.MinchaBenIsh72ToGra180 = {(this.MinchaBenIsh72ToGra180 == null ? "null" : this.MinchaBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.MinchaBenIsh72ToGra180propdn = {(this.MinchaBenIsh72ToGra180propdn == null ? "null" : this.MinchaBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.MinchaBenIsh72ToGra180proprs = {(this.MinchaBenIsh72ToGra180proprs == null ? "null" : this.MinchaBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.MinchaBenIsh72ToShabbos = {(this.MinchaBenIsh72ToShabbos == null ? "null" : this.MinchaBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.MinchaBenIsh72proprsToRaful = {(this.MinchaBenIsh72proprsToRaful == null ? "null" : this.MinchaBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.MinchaBenIsh90ToFastTuc = {(this.MinchaBenIsh90ToFastTuc == null ? "null" : this.MinchaBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.MinchaGra = {(this.MinchaGra == null ? "null" : this.MinchaGra.ToString())}");
            toStringOutput.Add($"this.MinchaMA72 = {(this.MinchaMA72 == null ? "null" : this.MinchaMA72.ToString())}");
            toStringOutput.Add($"this.MinchaMA72fix = {(this.MinchaMA72fix == null ? "null" : this.MinchaMA72fix.ToString())}");
            toStringOutput.Add($"this.MinchaMA72propdn = {(this.MinchaMA72propdn == null ? "null" : this.MinchaMA72propdn.ToString())}");
            toStringOutput.Add($"this.MinchaMA72proprs = {(this.MinchaMA72proprs == null ? "null" : this.MinchaMA72proprs.ToString())}");
            toStringOutput.Add($"this.MinchaMA90 = {(this.MinchaMA90 == null ? "null" : this.MinchaMA90.ToString())}");
            toStringOutput.Add($"this.MinchaStrict = {(this.MinchaStrict == null ? "null" : this.MinchaStrict.ToString())}");
            toStringOutput.Add($"this.MussafBenIsh72ToFastTuc = {(this.MussafBenIsh72ToFastTuc == null ? "null" : this.MussafBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.MussafBenIsh72ToGra180 = {(this.MussafBenIsh72ToGra180 == null ? "null" : this.MussafBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.MussafBenIsh72ToGra180propdn = {(this.MussafBenIsh72ToGra180propdn == null ? "null" : this.MussafBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.MussafBenIsh72ToGra180proprs = {(this.MussafBenIsh72ToGra180proprs == null ? "null" : this.MussafBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.MussafBenIsh72ToShabbos = {(this.MussafBenIsh72ToShabbos == null ? "null" : this.MussafBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.MussafBenIsh72proprsToRaful = {(this.MussafBenIsh72proprsToRaful == null ? "null" : this.MussafBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.MussafBenIsh90ToFastTuc = {(this.MussafBenIsh90ToFastTuc == null ? "null" : this.MussafBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.MussafGra = {(this.MussafGra == null ? "null" : this.MussafGra.ToString())}");
            toStringOutput.Add($"this.MussafMA72 = {(this.MussafMA72 == null ? "null" : this.MussafMA72.ToString())}");
            toStringOutput.Add($"this.MussafMA72fix = {(this.MussafMA72fix == null ? "null" : this.MussafMA72fix.ToString())}");
            toStringOutput.Add($"this.MussafMA72propdn = {(this.MussafMA72propdn == null ? "null" : this.MussafMA72propdn.ToString())}");
            toStringOutput.Add($"this.MussafMA72proprs = {(this.MussafMA72proprs == null ? "null" : this.MussafMA72proprs.ToString())}");
            toStringOutput.Add($"this.MussafMA90 = {(this.MussafMA90 == null ? "null" : this.MussafMA90.ToString())}");
            toStringOutput.Add($"this.Night40fix = {(this.Night40fix == null ? "null" : this.Night40fix.ToString())}");
            toStringOutput.Add($"this.Night50fix = {(this.Night50fix == null ? "null" : this.Night50fix.ToString())}");
            toStringOutput.Add($"this.Night60fix = {(this.Night60fix == null ? "null" : this.Night60fix.ToString())}");
            toStringOutput.Add($"this.Night72 = {(this.Night72 == null ? "null" : this.Night72.ToString())}");
            toStringOutput.Add($"this.Night72fix = {(this.Night72fix == null ? "null" : this.Night72fix.ToString())}");
            toStringOutput.Add($"this.Night72fixLevel = {(this.Night72fixLevel == null ? "null" : this.Night72fixLevel.ToString())}");
            toStringOutput.Add($"this.Night72propdn = {(this.Night72propdn == null ? "null" : this.Night72propdn.ToString())}");
            toStringOutput.Add($"this.Night72proprs = {(this.Night72proprs == null ? "null" : this.Night72proprs.ToString())}");
            toStringOutput.Add($"this.Night90 = {(this.Night90 == null ? "null" : this.Night90.ToString())}");
            toStringOutput.Add($"this.NightAgudas = {(this.NightAgudas == null ? "null" : this.NightAgudas.ToString())}");
            toStringOutput.Add($"this.NightBenIsh72ToGra180propdn = {(this.NightBenIsh72ToGra180propdn == null ? "null" : this.NightBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.NightBenIsh72ToGra180proprs = {(this.NightBenIsh72ToGra180proprs == null ? "null" : this.NightBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.NightChazonIsh = {(this.NightChazonIsh == null ? "null" : this.NightChazonIsh.ToString())}");
            toStringOutput.Add($"this.NightFastRMF = {(this.NightFastRMF == null ? "null" : this.NightFastRMF.ToString())}");
            toStringOutput.Add($"this.NightFastTuc = {(this.NightFastTuc == null ? "null" : this.NightFastTuc.ToString())}");
            toStringOutput.Add($"this.NightGra180 = {(this.NightGra180 == null ? "null" : this.NightGra180.ToString())}");
            toStringOutput.Add($"this.NightGra225 = {(this.NightGra225 == null ? "null" : this.NightGra225.ToString())}");
            toStringOutput.Add($"this.NightGra240 = {(this.NightGra240 == null ? "null" : this.NightGra240.ToString())}");
            toStringOutput.Add($"this.NightMoed = {(this.NightMoed == null ? "null" : this.NightMoed.ToString())}");
            toStringOutput.Add($"this.NightRadun = {(this.NightRadun == null ? "null" : this.NightRadun.ToString())}");
            toStringOutput.Add($"this.NightRaful = {(this.NightRaful == null ? "null" : this.NightRaful.ToString())}");
            toStringOutput.Add($"this.NightShabbos = {(this.NightShabbos == null ? "null" : this.NightShabbos.ToString())}");
            toStringOutput.Add($"this.NightZalman = {(this.NightZalman == null ? "null" : this.NightZalman.ToString())}");
            toStringOutput.Add($"this.PlagBenIsh72ToFastTuc = {(this.PlagBenIsh72ToFastTuc == null ? "null" : this.PlagBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.PlagBenIsh72ToGra180 = {(this.PlagBenIsh72ToGra180 == null ? "null" : this.PlagBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.PlagBenIsh72ToGra180propdn = {(this.PlagBenIsh72ToGra180propdn == null ? "null" : this.PlagBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.PlagBenIsh72ToGra180proprs = {(this.PlagBenIsh72ToGra180proprs == null ? "null" : this.PlagBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.PlagBenIsh72ToShabbos = {(this.PlagBenIsh72ToShabbos == null ? "null" : this.PlagBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.PlagBenIsh72proprsToRaful = {(this.PlagBenIsh72proprsToRaful == null ? "null" : this.PlagBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.PlagBenIsh90ToFastTuc = {(this.PlagBenIsh90ToFastTuc == null ? "null" : this.PlagBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.PlagGra = {(this.PlagGra == null ? "null" : this.PlagGra.ToString())}");
            toStringOutput.Add($"this.PlagMA72 = {(this.PlagMA72 == null ? "null" : this.PlagMA72.ToString())}");
            toStringOutput.Add($"this.PlagMA72fix = {(this.PlagMA72fix == null ? "null" : this.PlagMA72fix.ToString())}");
            toStringOutput.Add($"this.PlagMA72propdn = {(this.PlagMA72propdn == null ? "null" : this.PlagMA72propdn.ToString())}");
            toStringOutput.Add($"this.PlagMA72proprs = {(this.PlagMA72proprs == null ? "null" : this.PlagMA72proprs.ToString())}");
            toStringOutput.Add($"this.PlagMA90 = {(this.PlagMA90 == null ? "null" : this.PlagMA90.ToString())}");
            toStringOutput.Add($"this.PropBenIsh72ToFastTuc = {(this.PropBenIsh72ToFastTuc == null ? "null" : this.PropBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.PropBenIsh72ToGra180 = {(this.PropBenIsh72ToGra180 == null ? "null" : this.PropBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.PropBenIsh72ToGra180propdn = {(this.PropBenIsh72ToGra180propdn == null ? "null" : this.PropBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.PropBenIsh72ToGra180proprs = {(this.PropBenIsh72ToGra180proprs == null ? "null" : this.PropBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.PropBenIsh72ToShabbos = {(this.PropBenIsh72ToShabbos == null ? "null" : this.PropBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.PropBenIsh72proprsToRaful = {(this.PropBenIsh72proprsToRaful == null ? "null" : this.PropBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.PropBenIsh90ToFastTuc = {(this.PropBenIsh90ToFastTuc == null ? "null" : this.PropBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.PropGra = {(this.PropGra == null ? "null" : this.PropGra.ToString())}");
            toStringOutput.Add($"this.PropMA72 = {(this.PropMA72 == null ? "null" : this.PropMA72.ToString())}");
            toStringOutput.Add($"this.PropMA72fix = {(this.PropMA72fix == null ? "null" : this.PropMA72fix.ToString())}");
            toStringOutput.Add($"this.PropMA72propdn = {(this.PropMA72propdn == null ? "null" : this.PropMA72propdn.ToString())}");
            toStringOutput.Add($"this.PropMA72proprs = {(this.PropMA72proprs == null ? "null" : this.PropMA72proprs.ToString())}");
            toStringOutput.Add($"this.PropMA90 = {(this.PropMA90 == null ? "null" : this.PropMA90.ToString())}");
            toStringOutput.Add($"this.PropRiseToSetElevated = {(this.PropRiseToSetElevated == null ? "null" : this.PropRiseToSetElevated.ToString())}");
            toStringOutput.Add($"this.PropRmfMorning = {(this.PropRmfMorning == null ? "null" : this.PropRmfMorning.ToString())}");
            toStringOutput.Add($"this.ShachrisBenIsh72ToFastTuc = {(this.ShachrisBenIsh72ToFastTuc == null ? "null" : this.ShachrisBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.ShachrisBenIsh72ToGra180 = {(this.ShachrisBenIsh72ToGra180 == null ? "null" : this.ShachrisBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.ShachrisBenIsh72ToGra180propdn = {(this.ShachrisBenIsh72ToGra180propdn == null ? "null" : this.ShachrisBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.ShachrisBenIsh72ToGra180proprs = {(this.ShachrisBenIsh72ToGra180proprs == null ? "null" : this.ShachrisBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.ShachrisBenIsh72ToShabbos = {(this.ShachrisBenIsh72ToShabbos == null ? "null" : this.ShachrisBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.ShachrisBenIsh72proprsToRaful = {(this.ShachrisBenIsh72proprsToRaful == null ? "null" : this.ShachrisBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.ShachrisBenIsh90ToFastTuc = {(this.ShachrisBenIsh90ToFastTuc == null ? "null" : this.ShachrisBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.ShachrisGra = {(this.ShachrisGra == null ? "null" : this.ShachrisGra.ToString())}");
            toStringOutput.Add($"this.ShachrisMA72 = {(this.ShachrisMA72 == null ? "null" : this.ShachrisMA72.ToString())}");
            toStringOutput.Add($"this.ShachrisMA72fix = {(this.ShachrisMA72fix == null ? "null" : this.ShachrisMA72fix.ToString())}");
            toStringOutput.Add($"this.ShachrisMA72propdn = {(this.ShachrisMA72propdn == null ? "null" : this.ShachrisMA72propdn.ToString())}");
            toStringOutput.Add($"this.ShachrisMA72proprs = {(this.ShachrisMA72proprs == null ? "null" : this.ShachrisMA72proprs.ToString())}");
            toStringOutput.Add($"this.ShachrisMA90 = {(this.ShachrisMA90 == null ? "null" : this.ShachrisMA90.ToString())}");
            toStringOutput.Add($"this.ShachrisRMF = {(this.ShachrisRMF == null ? "null" : this.ShachrisRMF.ToString())}");
            toStringOutput.Add($"this.ShemaBenIsh72ToFastTuc = {(this.ShemaBenIsh72ToFastTuc == null ? "null" : this.ShemaBenIsh72ToFastTuc.ToString())}");
            toStringOutput.Add($"this.ShemaBenIsh72ToGra180 = {(this.ShemaBenIsh72ToGra180 == null ? "null" : this.ShemaBenIsh72ToGra180.ToString())}");
            toStringOutput.Add($"this.ShemaBenIsh72ToGra180propdn = {(this.ShemaBenIsh72ToGra180propdn == null ? "null" : this.ShemaBenIsh72ToGra180propdn.ToString())}");
            toStringOutput.Add($"this.ShemaBenIsh72ToGra180proprs = {(this.ShemaBenIsh72ToGra180proprs == null ? "null" : this.ShemaBenIsh72ToGra180proprs.ToString())}");
            toStringOutput.Add($"this.ShemaBenIsh72ToShabbos = {(this.ShemaBenIsh72ToShabbos == null ? "null" : this.ShemaBenIsh72ToShabbos.ToString())}");
            toStringOutput.Add($"this.ShemaBenIsh72proprsToRaful = {(this.ShemaBenIsh72proprsToRaful == null ? "null" : this.ShemaBenIsh72proprsToRaful.ToString())}");
            toStringOutput.Add($"this.ShemaBenIsh90ToFastTuc = {(this.ShemaBenIsh90ToFastTuc == null ? "null" : this.ShemaBenIsh90ToFastTuc.ToString())}");
            toStringOutput.Add($"this.ShemaGra = {(this.ShemaGra == null ? "null" : this.ShemaGra.ToString())}");
            toStringOutput.Add($"this.ShemaMA72 = {(this.ShemaMA72 == null ? "null" : this.ShemaMA72.ToString())}");
            toStringOutput.Add($"this.ShemaMA72fix = {(this.ShemaMA72fix == null ? "null" : this.ShemaMA72fix.ToString())}");
            toStringOutput.Add($"this.ShemaMA72propdn = {(this.ShemaMA72propdn == null ? "null" : this.ShemaMA72propdn.ToString())}");
            toStringOutput.Add($"this.ShemaMA72proprs = {(this.ShemaMA72proprs == null ? "null" : this.ShemaMA72proprs.ToString())}");
            toStringOutput.Add($"this.ShemaMA90 = {(this.ShemaMA90 == null ? "null" : this.ShemaMA90.ToString())}");
            toStringOutput.Add($"this.ShemaRMF = {(this.ShemaRMF == null ? "null" : this.ShemaRMF.ToString())}");
            toStringOutput.Add($"this.SunriseDefault = {(this.SunriseDefault == null ? "null" : this.SunriseDefault.ToString())}");
            toStringOutput.Add($"this.SunriseElevated = {(this.SunriseElevated == null ? "null" : this.SunriseElevated.ToString())}");
            toStringOutput.Add($"this.SunriseLevel = {(this.SunriseLevel == null ? "null" : this.SunriseLevel.ToString())}");
            toStringOutput.Add($"this.SunsetDefault = {(this.SunsetDefault == null ? "null" : this.SunsetDefault.ToString())}");
            toStringOutput.Add($"this.SunsetElevated = {(this.SunsetElevated == null ? "null" : this.SunsetElevated.ToString())}");
            toStringOutput.Add($"this.SunsetLevel = {(this.SunsetLevel == null ? "null" : this.SunsetLevel.ToString())}");
            toStringOutput.Add($"this.Tomorrow2Night72fix = {(this.Tomorrow2Night72fix == null ? "null" : this.Tomorrow2Night72fix.ToString())}");
            toStringOutput.Add($"this.Tomorrow2Night72propdn = {(this.Tomorrow2Night72propdn == null ? "null" : this.Tomorrow2Night72propdn.ToString())}");
            toStringOutput.Add($"this.Tomorrow2NightChazonIsh = {(this.Tomorrow2NightChazonIsh == null ? "null" : this.Tomorrow2NightChazonIsh.ToString())}");
            toStringOutput.Add($"this.Tomorrow2NightShabbos = {(this.Tomorrow2NightShabbos == null ? "null" : this.Tomorrow2NightShabbos.ToString())}");
            toStringOutput.Add($"this.Tomorrow2SunsetDefault = {(this.Tomorrow2SunsetDefault == null ? "null" : this.Tomorrow2SunsetDefault.ToString())}");
            toStringOutput.Add($"this.Tomorrow2SunsetElevated = {(this.Tomorrow2SunsetElevated == null ? "null" : this.Tomorrow2SunsetElevated.ToString())}");
            toStringOutput.Add($"this.Tomorrow2SunsetLevel = {(this.Tomorrow2SunsetLevel == null ? "null" : this.Tomorrow2SunsetLevel.ToString())}");
            toStringOutput.Add($"this.TomorrowNight72fix = {(this.TomorrowNight72fix == null ? "null" : this.TomorrowNight72fix.ToString())}");
            toStringOutput.Add($"this.TomorrowNight72propdn = {(this.TomorrowNight72propdn == null ? "null" : this.TomorrowNight72propdn.ToString())}");
            toStringOutput.Add($"this.TomorrowNightChazonIsh = {(this.TomorrowNightChazonIsh == null ? "null" : this.TomorrowNightChazonIsh.ToString())}");
            toStringOutput.Add($"this.TomorrowNightShabbos = {(this.TomorrowNightShabbos == null ? "null" : this.TomorrowNightShabbos.ToString())}");
            toStringOutput.Add($"this.TomorrowSunriseDefault = {(this.TomorrowSunriseDefault == null ? "null" : this.TomorrowSunriseDefault.ToString())}");
            toStringOutput.Add($"this.TomorrowSunriseElevated = {(this.TomorrowSunriseElevated == null ? "null" : this.TomorrowSunriseElevated.ToString())}");
            toStringOutput.Add($"this.TomorrowSunriseLevel = {(this.TomorrowSunriseLevel == null ? "null" : this.TomorrowSunriseLevel.ToString())}");
            toStringOutput.Add($"this.TomorrowSunsetDefault = {(this.TomorrowSunsetDefault == null ? "null" : this.TomorrowSunsetDefault.ToString())}");
            toStringOutput.Add($"this.TomorrowSunsetElevated = {(this.TomorrowSunsetElevated == null ? "null" : this.TomorrowSunsetElevated.ToString())}");
            toStringOutput.Add($"this.TomorrowSunsetLevel = {(this.TomorrowSunsetLevel == null ? "null" : this.TomorrowSunsetLevel.ToString())}");
            toStringOutput.Add($"this.Yakir062 = {(this.Yakir062 == null ? "null" : this.Yakir062.ToString())}");
            toStringOutput.Add($"this.Yakir069 = {(this.Yakir069 == null ? "null" : this.Yakir069.ToString())}");
            toStringOutput.Add($"this.Yakir102 = {(this.Yakir102 == null ? "null" : this.Yakir102.ToString())}");
            toStringOutput.Add($"this.Yakir110 = {(this.Yakir110 == null ? "null" : this.Yakir110.ToString())}");
            toStringOutput.Add($"this.Yakir115 = {(this.Yakir115 == null ? "null" : this.Yakir115.ToString())}");
            toStringOutput.Add($"this.Yakir120 = {(this.Yakir120 == null ? "null" : this.Yakir120.ToString())}");
            toStringOutput.Add($"this.YakirDefault = {(this.YakirDefault == null ? "null" : this.YakirDefault.ToString())}");
        }

        /// <summary>
        /// Creates a new class instance from the given XDocument.
        /// </summary>
        /// <param name="xDoc">The xDocument.</param>
        /// <returns>A new class instance.</returns>
        public static Q6ZmnType FromXml(XDocument xDoc)
        {
            var candles = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Candles").Value).GetValueOrDefault();
            var candles10 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Candles10").Value).GetValueOrDefault();
            var candles15 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Candles15").Value).GetValueOrDefault();
            var candles18 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Candles18").Value).GetValueOrDefault();
            var candles20 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Candles20").Value).GetValueOrDefault();
            var candles22 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Candles22").Value).GetValueOrDefault();
            var candles30 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Candles30").Value).GetValueOrDefault();
            var candles40 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Candles40").Value).GetValueOrDefault();
            var chametzBurnBenIsh72ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnBenIsh72ToFastTuc").Value).GetValueOrDefault();
            var chametzBurnBenIsh72ToGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnBenIsh72ToGra180").Value).GetValueOrDefault();
            var chametzBurnBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var chametzBurnBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var chametzBurnBenIsh72ToShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnBenIsh72ToShabbos").Value).GetValueOrDefault();
            var chametzBurnBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var chametzBurnBenIsh90ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnBenIsh90ToFastTuc").Value).GetValueOrDefault();
            var chametzBurnGra = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnGra").Value).GetValueOrDefault();
            var chametzBurnMA72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnMA72").Value).GetValueOrDefault();
            var chametzBurnMA72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnMA72fix").Value).GetValueOrDefault();
            var chametzBurnMA72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnMA72propdn").Value).GetValueOrDefault();
            var chametzBurnMA72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnMA72proprs").Value).GetValueOrDefault();
            var chametzBurnMA90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnMA90").Value).GetValueOrDefault();
            var chametzBurnRMF = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzBurnRMF").Value).GetValueOrDefault();
            var chametzEatBenIsh72ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatBenIsh72ToFastTuc").Value).GetValueOrDefault();
            var chametzEatBenIsh72ToGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatBenIsh72ToGra180").Value).GetValueOrDefault();
            var chametzEatBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var chametzEatBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var chametzEatBenIsh72ToShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatBenIsh72ToShabbos").Value).GetValueOrDefault();
            var chametzEatBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var chametzEatBenIsh90ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatBenIsh90ToFastTuc").Value).GetValueOrDefault();
            var chametzEatGra = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatGra").Value).GetValueOrDefault();
            var chametzEatMA72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatMA72").Value).GetValueOrDefault();
            var chametzEatMA72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatMA72fix").Value).GetValueOrDefault();
            var chametzEatMA72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatMA72propdn").Value).GetValueOrDefault();
            var chametzEatMA72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatMA72proprs").Value).GetValueOrDefault();
            var chametzEatMA90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatMA90").Value).GetValueOrDefault();
            var chametzEatRMF = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ChametzEatRMF").Value).GetValueOrDefault();
            var currentTime = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("CurrentTime").Value).GetValueOrDefault();
            var dawn72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Dawn72").Value).GetValueOrDefault();
            var dawn72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Dawn72fix").Value).GetValueOrDefault();
            var dawn72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Dawn72propdn").Value).GetValueOrDefault();
            var dawn72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Dawn72proprs").Value).GetValueOrDefault();
            var dawn90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Dawn90").Value).GetValueOrDefault();
            var dawnBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("DawnBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var dawnRMF = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("DawnRMF").Value).GetValueOrDefault();
            var ketanaBenIsh72ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaBenIsh72ToFastTuc").Value).GetValueOrDefault();
            var ketanaBenIsh72ToGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaBenIsh72ToGra180").Value).GetValueOrDefault();
            var ketanaBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var ketanaBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var ketanaBenIsh72ToShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaBenIsh72ToShabbos").Value).GetValueOrDefault();
            var ketanaBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var ketanaBenIsh90ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaBenIsh90ToFastTuc").Value).GetValueOrDefault();
            var ketanaGra = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaGra").Value).GetValueOrDefault();
            var ketanaMA72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaMA72").Value).GetValueOrDefault();
            var ketanaMA72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaMA72fix").Value).GetValueOrDefault();
            var ketanaMA72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaMA72propdn").Value).GetValueOrDefault();
            var ketanaMA72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaMA72proprs").Value).GetValueOrDefault();
            var ketanaMA90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("KetanaMA90").Value).GetValueOrDefault();
            var mealBenIsh72ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealBenIsh72ToFastTuc").Value).GetValueOrDefault();
            var mealBenIsh72ToGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealBenIsh72ToGra180").Value).GetValueOrDefault();
            var mealBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var mealBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var mealBenIsh72ToShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealBenIsh72ToShabbos").Value).GetValueOrDefault();
            var mealBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var mealBenIsh90ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealBenIsh90ToFastTuc").Value).GetValueOrDefault();
            var mealGra = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealGra").Value).GetValueOrDefault();
            var mealMA72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealMA72").Value).GetValueOrDefault();
            var mealMA72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealMA72fix").Value).GetValueOrDefault();
            var mealMA72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealMA72propdn").Value).GetValueOrDefault();
            var mealMA72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealMA72proprs").Value).GetValueOrDefault();
            var mealMA90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MealMA90").Value).GetValueOrDefault();
            var midday = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Midday").Value).GetValueOrDefault();
            var middayBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MiddayBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var middayRMF = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MiddayRMF").Value).GetValueOrDefault();
            var midnight = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Midnight").Value).GetValueOrDefault();
            var mincha30fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Mincha30fix").Value).GetValueOrDefault();
            var minchaBenIsh72ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaBenIsh72ToFastTuc").Value).GetValueOrDefault();
            var minchaBenIsh72ToGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaBenIsh72ToGra180").Value).GetValueOrDefault();
            var minchaBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var minchaBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var minchaBenIsh72ToShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaBenIsh72ToShabbos").Value).GetValueOrDefault();
            var minchaBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var minchaBenIsh90ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaBenIsh90ToFastTuc").Value).GetValueOrDefault();
            var minchaGra = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaGra").Value).GetValueOrDefault();
            var minchaMA72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaMA72").Value).GetValueOrDefault();
            var minchaMA72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaMA72fix").Value).GetValueOrDefault();
            var minchaMA72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaMA72propdn").Value).GetValueOrDefault();
            var minchaMA72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaMA72proprs").Value).GetValueOrDefault();
            var minchaMA90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaMA90").Value).GetValueOrDefault();
            var minchaStrict = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MinchaStrict").Value).GetValueOrDefault();
            var mussafBenIsh72ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafBenIsh72ToFastTuc").Value).GetValueOrDefault();
            var mussafBenIsh72ToGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafBenIsh72ToGra180").Value).GetValueOrDefault();
            var mussafBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var mussafBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var mussafBenIsh72ToShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafBenIsh72ToShabbos").Value).GetValueOrDefault();
            var mussafBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var mussafBenIsh90ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafBenIsh90ToFastTuc").Value).GetValueOrDefault();
            var mussafGra = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafGra").Value).GetValueOrDefault();
            var mussafMA72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafMA72").Value).GetValueOrDefault();
            var mussafMA72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafMA72fix").Value).GetValueOrDefault();
            var mussafMA72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafMA72propdn").Value).GetValueOrDefault();
            var mussafMA72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafMA72proprs").Value).GetValueOrDefault();
            var mussafMA90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("MussafMA90").Value).GetValueOrDefault();
            var night40fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Night40fix").Value).GetValueOrDefault();
            var night50fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Night50fix").Value).GetValueOrDefault();
            var night60fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Night60fix").Value).GetValueOrDefault();
            var night72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Night72").Value).GetValueOrDefault();
            var night72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Night72fix").Value).GetValueOrDefault();
            var night72fixLevel = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Night72fixLevel").Value).GetValueOrDefault();
            var night72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Night72propdn").Value).GetValueOrDefault();
            var night72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Night72proprs").Value).GetValueOrDefault();
            var night90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Night90").Value).GetValueOrDefault();
            var nightAgudas = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightAgudas").Value).GetValueOrDefault();
            var nightBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var nightBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var nightChazonIsh = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightChazonIsh").Value).GetValueOrDefault();
            var nightFastRMF = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightFastRMF").Value).GetValueOrDefault();
            var nightFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightFastTuc").Value).GetValueOrDefault();
            var nightGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightGra180").Value).GetValueOrDefault();
            var nightGra225 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightGra225").Value).GetValueOrDefault();
            var nightGra240 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightGra240").Value).GetValueOrDefault();
            var nightMoed = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightMoed").Value).GetValueOrDefault();
            var nightRadun = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightRadun").Value).GetValueOrDefault();
            var nightRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightRaful").Value).GetValueOrDefault();
            var nightShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightShabbos").Value).GetValueOrDefault();
            var nightZalman = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("NightZalman").Value).GetValueOrDefault();
            var plagBenIsh72ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagBenIsh72ToFastTuc").Value).GetValueOrDefault();
            var plagBenIsh72ToGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagBenIsh72ToGra180").Value).GetValueOrDefault();
            var plagBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var plagBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var plagBenIsh72ToShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagBenIsh72ToShabbos").Value).GetValueOrDefault();
            var plagBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var plagBenIsh90ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagBenIsh90ToFastTuc").Value).GetValueOrDefault();
            var plagGra = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagGra").Value).GetValueOrDefault();
            var plagMA72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagMA72").Value).GetValueOrDefault();
            var plagMA72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagMA72fix").Value).GetValueOrDefault();
            var plagMA72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagMA72propdn").Value).GetValueOrDefault();
            var plagMA72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagMA72proprs").Value).GetValueOrDefault();
            var plagMA90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("PlagMA90").Value).GetValueOrDefault();
            var propBenIsh72ToFastTuc = (long?)xDoc.Root.Element("PropBenIsh72ToFastTuc");
            var propBenIsh72ToGra180 = (long?)xDoc.Root.Element("PropBenIsh72ToGra180");
            var propBenIsh72ToGra180propdn = (long?)xDoc.Root.Element("PropBenIsh72ToGra180propdn");
            var propBenIsh72ToGra180proprs = (long?)xDoc.Root.Element("PropBenIsh72ToGra180proprs");
            var propBenIsh72ToShabbos = (long?)xDoc.Root.Element("PropBenIsh72ToShabbos");
            var propBenIsh72proprsToRaful = (long?)xDoc.Root.Element("PropBenIsh72proprsToRaful");
            var propBenIsh90ToFastTuc = (long?)xDoc.Root.Element("PropBenIsh90ToFastTuc");
            var propGra = (long?)xDoc.Root.Element("PropGra");
            var propMA72 = (long?)xDoc.Root.Element("PropMA72");
            var propMA72fix = (long?)xDoc.Root.Element("PropMA72fix");
            var propMA72propdn = (long?)xDoc.Root.Element("PropMA72propdn");
            var propMA72proprs = (long?)xDoc.Root.Element("PropMA72proprs");
            var propMA90 = (long?)xDoc.Root.Element("PropMA90");
            var propRiseToSetElevated = (long?)xDoc.Root.Element("PropRiseToSetElevated");
            var propRmfMorning = (long?)xDoc.Root.Element("PropRmfMorning");
            var shachrisBenIsh72ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisBenIsh72ToFastTuc").Value).GetValueOrDefault();
            var shachrisBenIsh72ToGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisBenIsh72ToGra180").Value).GetValueOrDefault();
            var shachrisBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var shachrisBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var shachrisBenIsh72ToShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisBenIsh72ToShabbos").Value).GetValueOrDefault();
            var shachrisBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var shachrisBenIsh90ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisBenIsh90ToFastTuc").Value).GetValueOrDefault();
            var shachrisGra = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisGra").Value).GetValueOrDefault();
            var shachrisMA72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisMA72").Value).GetValueOrDefault();
            var shachrisMA72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisMA72fix").Value).GetValueOrDefault();
            var shachrisMA72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisMA72propdn").Value).GetValueOrDefault();
            var shachrisMA72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisMA72proprs").Value).GetValueOrDefault();
            var shachrisMA90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisMA90").Value).GetValueOrDefault();
            var shachrisRMF = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShachrisRMF").Value).GetValueOrDefault();
            var shemaBenIsh72ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaBenIsh72ToFastTuc").Value).GetValueOrDefault();
            var shemaBenIsh72ToGra180 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaBenIsh72ToGra180").Value).GetValueOrDefault();
            var shemaBenIsh72ToGra180propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaBenIsh72ToGra180propdn").Value).GetValueOrDefault();
            var shemaBenIsh72ToGra180proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaBenIsh72ToGra180proprs").Value).GetValueOrDefault();
            var shemaBenIsh72ToShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaBenIsh72ToShabbos").Value).GetValueOrDefault();
            var shemaBenIsh72proprsToRaful = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaBenIsh72proprsToRaful").Value).GetValueOrDefault();
            var shemaBenIsh90ToFastTuc = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaBenIsh90ToFastTuc").Value).GetValueOrDefault();
            var shemaGra = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaGra").Value).GetValueOrDefault();
            var shemaMA72 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaMA72").Value).GetValueOrDefault();
            var shemaMA72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaMA72fix").Value).GetValueOrDefault();
            var shemaMA72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaMA72propdn").Value).GetValueOrDefault();
            var shemaMA72proprs = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaMA72proprs").Value).GetValueOrDefault();
            var shemaMA90 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaMA90").Value).GetValueOrDefault();
            var shemaRMF = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("ShemaRMF").Value).GetValueOrDefault();
            var sunriseDefault = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("SunriseDefault").Value).GetValueOrDefault();
            var sunriseElevated = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("SunriseElevated").Value).GetValueOrDefault();
            var sunriseLevel = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("SunriseLevel").Value).GetValueOrDefault();
            var sunsetDefault = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("SunsetDefault").Value).GetValueOrDefault();
            var sunsetElevated = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("SunsetElevated").Value).GetValueOrDefault();
            var sunsetLevel = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("SunsetLevel").Value).GetValueOrDefault();
            var tomorrow2Night72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Tomorrow2Night72fix").Value).GetValueOrDefault();
            var tomorrow2Night72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Tomorrow2Night72propdn").Value).GetValueOrDefault();
            var tomorrow2NightChazonIsh = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Tomorrow2NightChazonIsh").Value).GetValueOrDefault();
            var tomorrow2NightShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Tomorrow2NightShabbos").Value).GetValueOrDefault();
            var tomorrow2SunsetDefault = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Tomorrow2SunsetDefault").Value).GetValueOrDefault();
            var tomorrow2SunsetElevated = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Tomorrow2SunsetElevated").Value).GetValueOrDefault();
            var tomorrow2SunsetLevel = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Tomorrow2SunsetLevel").Value).GetValueOrDefault();
            var tomorrowNight72fix = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowNight72fix").Value).GetValueOrDefault();
            var tomorrowNight72propdn = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowNight72propdn").Value).GetValueOrDefault();
            var tomorrowNightChazonIsh = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowNightChazonIsh").Value).GetValueOrDefault();
            var tomorrowNightShabbos = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowNightShabbos").Value).GetValueOrDefault();
            var tomorrowSunriseDefault = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowSunriseDefault").Value).GetValueOrDefault();
            var tomorrowSunriseElevated = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowSunriseElevated").Value).GetValueOrDefault();
            var tomorrowSunriseLevel = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowSunriseLevel").Value).GetValueOrDefault();
            var tomorrowSunsetDefault = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowSunsetDefault").Value).GetValueOrDefault();
            var tomorrowSunsetElevated = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowSunsetElevated").Value).GetValueOrDefault();
            var tomorrowSunsetLevel = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("TomorrowSunsetLevel").Value).GetValueOrDefault();
            var yakir062 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Yakir062").Value).GetValueOrDefault();
            var yakir069 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Yakir069").Value).GetValueOrDefault();
            var yakir102 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Yakir102").Value).GetValueOrDefault();
            var yakir110 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Yakir110").Value).GetValueOrDefault();
            var yakir115 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Yakir115").Value).GetValueOrDefault();
            var yakir120 = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("Yakir120").Value).GetValueOrDefault();
            var yakirDefault = Rfc3339DateTimeXmlUtility.StringToRfc3339Date(xDoc.Root.Element("YakirDefault").Value).GetValueOrDefault();
            return new Q6ZmnType(
                candles,
                candles10,
                candles15,
                candles18,
                candles20,
                candles22,
                candles30,
                candles40,
                chametzBurnBenIsh72ToFastTuc,
                chametzBurnBenIsh72ToGra180,
                chametzBurnBenIsh72ToGra180propdn,
                chametzBurnBenIsh72ToGra180proprs,
                chametzBurnBenIsh72ToShabbos,
                chametzBurnBenIsh72proprsToRaful,
                chametzBurnBenIsh90ToFastTuc,
                chametzBurnGra,
                chametzBurnMA72,
                chametzBurnMA72fix,
                chametzBurnMA72propdn,
                chametzBurnMA72proprs,
                chametzBurnMA90,
                chametzBurnRMF,
                chametzEatBenIsh72ToFastTuc,
                chametzEatBenIsh72ToGra180,
                chametzEatBenIsh72ToGra180propdn,
                chametzEatBenIsh72ToGra180proprs,
                chametzEatBenIsh72ToShabbos,
                chametzEatBenIsh72proprsToRaful,
                chametzEatBenIsh90ToFastTuc,
                chametzEatGra,
                chametzEatMA72,
                chametzEatMA72fix,
                chametzEatMA72propdn,
                chametzEatMA72proprs,
                chametzEatMA90,
                chametzEatRMF,
                currentTime,
                dawn72,
                dawn72fix,
                dawn72propdn,
                dawn72proprs,
                dawn90,
                dawnBenIsh72ToGra180propdn,
                dawnRMF,
                ketanaBenIsh72ToFastTuc,
                ketanaBenIsh72ToGra180,
                ketanaBenIsh72ToGra180propdn,
                ketanaBenIsh72ToGra180proprs,
                ketanaBenIsh72ToShabbos,
                ketanaBenIsh72proprsToRaful,
                ketanaBenIsh90ToFastTuc,
                ketanaGra,
                ketanaMA72,
                ketanaMA72fix,
                ketanaMA72propdn,
                ketanaMA72proprs,
                ketanaMA90,
                mealBenIsh72ToFastTuc,
                mealBenIsh72ToGra180,
                mealBenIsh72ToGra180propdn,
                mealBenIsh72ToGra180proprs,
                mealBenIsh72ToShabbos,
                mealBenIsh72proprsToRaful,
                mealBenIsh90ToFastTuc,
                mealGra,
                mealMA72,
                mealMA72fix,
                mealMA72propdn,
                mealMA72proprs,
                mealMA90,
                midday,
                middayBenIsh72proprsToRaful,
                middayRMF,
                midnight,
                mincha30fix,
                minchaBenIsh72ToFastTuc,
                minchaBenIsh72ToGra180,
                minchaBenIsh72ToGra180propdn,
                minchaBenIsh72ToGra180proprs,
                minchaBenIsh72ToShabbos,
                minchaBenIsh72proprsToRaful,
                minchaBenIsh90ToFastTuc,
                minchaGra,
                minchaMA72,
                minchaMA72fix,
                minchaMA72propdn,
                minchaMA72proprs,
                minchaMA90,
                minchaStrict,
                mussafBenIsh72ToFastTuc,
                mussafBenIsh72ToGra180,
                mussafBenIsh72ToGra180propdn,
                mussafBenIsh72ToGra180proprs,
                mussafBenIsh72ToShabbos,
                mussafBenIsh72proprsToRaful,
                mussafBenIsh90ToFastTuc,
                mussafGra,
                mussafMA72,
                mussafMA72fix,
                mussafMA72propdn,
                mussafMA72proprs,
                mussafMA90,
                night40fix,
                night50fix,
                night60fix,
                night72,
                night72fix,
                night72fixLevel,
                night72propdn,
                night72proprs,
                night90,
                nightAgudas,
                nightBenIsh72ToGra180propdn,
                nightBenIsh72ToGra180proprs,
                nightChazonIsh,
                nightFastRMF,
                nightFastTuc,
                nightGra180,
                nightGra225,
                nightGra240,
                nightMoed,
                nightRadun,
                nightRaful,
                nightShabbos,
                nightZalman,
                plagBenIsh72ToFastTuc,
                plagBenIsh72ToGra180,
                plagBenIsh72ToGra180propdn,
                plagBenIsh72ToGra180proprs,
                plagBenIsh72ToShabbos,
                plagBenIsh72proprsToRaful,
                plagBenIsh90ToFastTuc,
                plagGra,
                plagMA72,
                plagMA72fix,
                plagMA72propdn,
                plagMA72proprs,
                plagMA90,
                propBenIsh72ToFastTuc,
                propBenIsh72ToGra180,
                propBenIsh72ToGra180propdn,
                propBenIsh72ToGra180proprs,
                propBenIsh72ToShabbos,
                propBenIsh72proprsToRaful,
                propBenIsh90ToFastTuc,
                propGra,
                propMA72,
                propMA72fix,
                propMA72propdn,
                propMA72proprs,
                propMA90,
                propRiseToSetElevated,
                propRmfMorning,
                shachrisBenIsh72ToFastTuc,
                shachrisBenIsh72ToGra180,
                shachrisBenIsh72ToGra180propdn,
                shachrisBenIsh72ToGra180proprs,
                shachrisBenIsh72ToShabbos,
                shachrisBenIsh72proprsToRaful,
                shachrisBenIsh90ToFastTuc,
                shachrisGra,
                shachrisMA72,
                shachrisMA72fix,
                shachrisMA72propdn,
                shachrisMA72proprs,
                shachrisMA90,
                shachrisRMF,
                shemaBenIsh72ToFastTuc,
                shemaBenIsh72ToGra180,
                shemaBenIsh72ToGra180propdn,
                shemaBenIsh72ToGra180proprs,
                shemaBenIsh72ToShabbos,
                shemaBenIsh72proprsToRaful,
                shemaBenIsh90ToFastTuc,
                shemaGra,
                shemaMA72,
                shemaMA72fix,
                shemaMA72propdn,
                shemaMA72proprs,
                shemaMA90,
                shemaRMF,
                sunriseDefault,
                sunriseElevated,
                sunriseLevel,
                sunsetDefault,
                sunsetElevated,
                sunsetLevel,
                tomorrow2Night72fix,
                tomorrow2Night72propdn,
                tomorrow2NightChazonIsh,
                tomorrow2NightShabbos,
                tomorrow2SunsetDefault,
                tomorrow2SunsetElevated,
                tomorrow2SunsetLevel,
                tomorrowNight72fix,
                tomorrowNight72propdn,
                tomorrowNightChazonIsh,
                tomorrowNightShabbos,
                tomorrowSunriseDefault,
                tomorrowSunriseElevated,
                tomorrowSunriseLevel,
                tomorrowSunsetDefault,
                tomorrowSunsetElevated,
                tomorrowSunsetLevel,
                yakir062,
                yakir069,
                yakir102,
                yakir110,
                yakir115,
                yakir120,
                yakirDefault);
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
            if (this.Candles != null)
            {
                writer.WriteElementString("Candles", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Candles));
            }

            if (this.Candles10 != null)
            {
                writer.WriteElementString("Candles10", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Candles10));
            }

            if (this.Candles15 != null)
            {
                writer.WriteElementString("Candles15", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Candles15));
            }

            if (this.Candles18 != null)
            {
                writer.WriteElementString("Candles18", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Candles18));
            }

            if (this.Candles20 != null)
            {
                writer.WriteElementString("Candles20", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Candles20));
            }

            if (this.Candles22 != null)
            {
                writer.WriteElementString("Candles22", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Candles22));
            }

            if (this.Candles30 != null)
            {
                writer.WriteElementString("Candles30", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Candles30));
            }

            if (this.Candles40 != null)
            {
                writer.WriteElementString("Candles40", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Candles40));
            }

            if (this.ChametzBurnBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("ChametzBurnBenIsh72ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnBenIsh72ToFastTuc));
            }

            if (this.ChametzBurnBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("ChametzBurnBenIsh72ToGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnBenIsh72ToGra180));
            }

            if (this.ChametzBurnBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("ChametzBurnBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnBenIsh72ToGra180propdn));
            }

            if (this.ChametzBurnBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("ChametzBurnBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnBenIsh72ToGra180proprs));
            }

            if (this.ChametzBurnBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("ChametzBurnBenIsh72ToShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnBenIsh72ToShabbos));
            }

            if (this.ChametzBurnBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("ChametzBurnBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnBenIsh72proprsToRaful));
            }

            if (this.ChametzBurnBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("ChametzBurnBenIsh90ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnBenIsh90ToFastTuc));
            }

            if (this.ChametzBurnGra != null)
            {
                writer.WriteElementString("ChametzBurnGra", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnGra));
            }

            if (this.ChametzBurnMA72 != null)
            {
                writer.WriteElementString("ChametzBurnMA72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnMA72));
            }

            if (this.ChametzBurnMA72fix != null)
            {
                writer.WriteElementString("ChametzBurnMA72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnMA72fix));
            }

            if (this.ChametzBurnMA72propdn != null)
            {
                writer.WriteElementString("ChametzBurnMA72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnMA72propdn));
            }

            if (this.ChametzBurnMA72proprs != null)
            {
                writer.WriteElementString("ChametzBurnMA72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnMA72proprs));
            }

            if (this.ChametzBurnMA90 != null)
            {
                writer.WriteElementString("ChametzBurnMA90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnMA90));
            }

            if (this.ChametzBurnRMF != null)
            {
                writer.WriteElementString("ChametzBurnRMF", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzBurnRMF));
            }

            if (this.ChametzEatBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("ChametzEatBenIsh72ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatBenIsh72ToFastTuc));
            }

            if (this.ChametzEatBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("ChametzEatBenIsh72ToGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatBenIsh72ToGra180));
            }

            if (this.ChametzEatBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("ChametzEatBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatBenIsh72ToGra180propdn));
            }

            if (this.ChametzEatBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("ChametzEatBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatBenIsh72ToGra180proprs));
            }

            if (this.ChametzEatBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("ChametzEatBenIsh72ToShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatBenIsh72ToShabbos));
            }

            if (this.ChametzEatBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("ChametzEatBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatBenIsh72proprsToRaful));
            }

            if (this.ChametzEatBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("ChametzEatBenIsh90ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatBenIsh90ToFastTuc));
            }

            if (this.ChametzEatGra != null)
            {
                writer.WriteElementString("ChametzEatGra", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatGra));
            }

            if (this.ChametzEatMA72 != null)
            {
                writer.WriteElementString("ChametzEatMA72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatMA72));
            }

            if (this.ChametzEatMA72fix != null)
            {
                writer.WriteElementString("ChametzEatMA72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatMA72fix));
            }

            if (this.ChametzEatMA72propdn != null)
            {
                writer.WriteElementString("ChametzEatMA72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatMA72propdn));
            }

            if (this.ChametzEatMA72proprs != null)
            {
                writer.WriteElementString("ChametzEatMA72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatMA72proprs));
            }

            if (this.ChametzEatMA90 != null)
            {
                writer.WriteElementString("ChametzEatMA90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatMA90));
            }

            if (this.ChametzEatRMF != null)
            {
                writer.WriteElementString("ChametzEatRMF", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ChametzEatRMF));
            }

            if (this.CurrentTime != null)
            {
                writer.WriteElementString("CurrentTime", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.CurrentTime));
            }

            if (this.Dawn72 != null)
            {
                writer.WriteElementString("Dawn72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Dawn72));
            }

            if (this.Dawn72fix != null)
            {
                writer.WriteElementString("Dawn72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Dawn72fix));
            }

            if (this.Dawn72propdn != null)
            {
                writer.WriteElementString("Dawn72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Dawn72propdn));
            }

            if (this.Dawn72proprs != null)
            {
                writer.WriteElementString("Dawn72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Dawn72proprs));
            }

            if (this.Dawn90 != null)
            {
                writer.WriteElementString("Dawn90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Dawn90));
            }

            if (this.DawnBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("DawnBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.DawnBenIsh72ToGra180propdn));
            }

            if (this.DawnRMF != null)
            {
                writer.WriteElementString("DawnRMF", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.DawnRMF));
            }

            if (this.KetanaBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("KetanaBenIsh72ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaBenIsh72ToFastTuc));
            }

            if (this.KetanaBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("KetanaBenIsh72ToGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaBenIsh72ToGra180));
            }

            if (this.KetanaBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("KetanaBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaBenIsh72ToGra180propdn));
            }

            if (this.KetanaBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("KetanaBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaBenIsh72ToGra180proprs));
            }

            if (this.KetanaBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("KetanaBenIsh72ToShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaBenIsh72ToShabbos));
            }

            if (this.KetanaBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("KetanaBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaBenIsh72proprsToRaful));
            }

            if (this.KetanaBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("KetanaBenIsh90ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaBenIsh90ToFastTuc));
            }

            if (this.KetanaGra != null)
            {
                writer.WriteElementString("KetanaGra", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaGra));
            }

            if (this.KetanaMA72 != null)
            {
                writer.WriteElementString("KetanaMA72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaMA72));
            }

            if (this.KetanaMA72fix != null)
            {
                writer.WriteElementString("KetanaMA72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaMA72fix));
            }

            if (this.KetanaMA72propdn != null)
            {
                writer.WriteElementString("KetanaMA72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaMA72propdn));
            }

            if (this.KetanaMA72proprs != null)
            {
                writer.WriteElementString("KetanaMA72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaMA72proprs));
            }

            if (this.KetanaMA90 != null)
            {
                writer.WriteElementString("KetanaMA90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.KetanaMA90));
            }

            if (this.MealBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("MealBenIsh72ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealBenIsh72ToFastTuc));
            }

            if (this.MealBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("MealBenIsh72ToGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealBenIsh72ToGra180));
            }

            if (this.MealBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("MealBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealBenIsh72ToGra180propdn));
            }

            if (this.MealBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("MealBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealBenIsh72ToGra180proprs));
            }

            if (this.MealBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("MealBenIsh72ToShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealBenIsh72ToShabbos));
            }

            if (this.MealBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("MealBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealBenIsh72proprsToRaful));
            }

            if (this.MealBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("MealBenIsh90ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealBenIsh90ToFastTuc));
            }

            if (this.MealGra != null)
            {
                writer.WriteElementString("MealGra", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealGra));
            }

            if (this.MealMA72 != null)
            {
                writer.WriteElementString("MealMA72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealMA72));
            }

            if (this.MealMA72fix != null)
            {
                writer.WriteElementString("MealMA72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealMA72fix));
            }

            if (this.MealMA72propdn != null)
            {
                writer.WriteElementString("MealMA72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealMA72propdn));
            }

            if (this.MealMA72proprs != null)
            {
                writer.WriteElementString("MealMA72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealMA72proprs));
            }

            if (this.MealMA90 != null)
            {
                writer.WriteElementString("MealMA90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MealMA90));
            }

            if (this.Midday != null)
            {
                writer.WriteElementString("Midday", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Midday));
            }

            if (this.MiddayBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("MiddayBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MiddayBenIsh72proprsToRaful));
            }

            if (this.MiddayRMF != null)
            {
                writer.WriteElementString("MiddayRMF", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MiddayRMF));
            }

            if (this.Midnight != null)
            {
                writer.WriteElementString("Midnight", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Midnight));
            }

            if (this.Mincha30fix != null)
            {
                writer.WriteElementString("Mincha30fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Mincha30fix));
            }

            if (this.MinchaBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("MinchaBenIsh72ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaBenIsh72ToFastTuc));
            }

            if (this.MinchaBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("MinchaBenIsh72ToGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaBenIsh72ToGra180));
            }

            if (this.MinchaBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("MinchaBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaBenIsh72ToGra180propdn));
            }

            if (this.MinchaBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("MinchaBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaBenIsh72ToGra180proprs));
            }

            if (this.MinchaBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("MinchaBenIsh72ToShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaBenIsh72ToShabbos));
            }

            if (this.MinchaBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("MinchaBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaBenIsh72proprsToRaful));
            }

            if (this.MinchaBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("MinchaBenIsh90ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaBenIsh90ToFastTuc));
            }

            if (this.MinchaGra != null)
            {
                writer.WriteElementString("MinchaGra", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaGra));
            }

            if (this.MinchaMA72 != null)
            {
                writer.WriteElementString("MinchaMA72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaMA72));
            }

            if (this.MinchaMA72fix != null)
            {
                writer.WriteElementString("MinchaMA72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaMA72fix));
            }

            if (this.MinchaMA72propdn != null)
            {
                writer.WriteElementString("MinchaMA72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaMA72propdn));
            }

            if (this.MinchaMA72proprs != null)
            {
                writer.WriteElementString("MinchaMA72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaMA72proprs));
            }

            if (this.MinchaMA90 != null)
            {
                writer.WriteElementString("MinchaMA90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaMA90));
            }

            if (this.MinchaStrict != null)
            {
                writer.WriteElementString("MinchaStrict", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MinchaStrict));
            }

            if (this.MussafBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("MussafBenIsh72ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafBenIsh72ToFastTuc));
            }

            if (this.MussafBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("MussafBenIsh72ToGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafBenIsh72ToGra180));
            }

            if (this.MussafBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("MussafBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafBenIsh72ToGra180propdn));
            }

            if (this.MussafBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("MussafBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafBenIsh72ToGra180proprs));
            }

            if (this.MussafBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("MussafBenIsh72ToShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafBenIsh72ToShabbos));
            }

            if (this.MussafBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("MussafBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafBenIsh72proprsToRaful));
            }

            if (this.MussafBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("MussafBenIsh90ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafBenIsh90ToFastTuc));
            }

            if (this.MussafGra != null)
            {
                writer.WriteElementString("MussafGra", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafGra));
            }

            if (this.MussafMA72 != null)
            {
                writer.WriteElementString("MussafMA72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafMA72));
            }

            if (this.MussafMA72fix != null)
            {
                writer.WriteElementString("MussafMA72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafMA72fix));
            }

            if (this.MussafMA72propdn != null)
            {
                writer.WriteElementString("MussafMA72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafMA72propdn));
            }

            if (this.MussafMA72proprs != null)
            {
                writer.WriteElementString("MussafMA72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafMA72proprs));
            }

            if (this.MussafMA90 != null)
            {
                writer.WriteElementString("MussafMA90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.MussafMA90));
            }

            if (this.Night40fix != null)
            {
                writer.WriteElementString("Night40fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Night40fix));
            }

            if (this.Night50fix != null)
            {
                writer.WriteElementString("Night50fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Night50fix));
            }

            if (this.Night60fix != null)
            {
                writer.WriteElementString("Night60fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Night60fix));
            }

            if (this.Night72 != null)
            {
                writer.WriteElementString("Night72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Night72));
            }

            if (this.Night72fix != null)
            {
                writer.WriteElementString("Night72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Night72fix));
            }

            if (this.Night72fixLevel != null)
            {
                writer.WriteElementString("Night72fixLevel", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Night72fixLevel));
            }

            if (this.Night72propdn != null)
            {
                writer.WriteElementString("Night72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Night72propdn));
            }

            if (this.Night72proprs != null)
            {
                writer.WriteElementString("Night72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Night72proprs));
            }

            if (this.Night90 != null)
            {
                writer.WriteElementString("Night90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Night90));
            }

            if (this.NightAgudas != null)
            {
                writer.WriteElementString("NightAgudas", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightAgudas));
            }

            if (this.NightBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("NightBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightBenIsh72ToGra180propdn));
            }

            if (this.NightBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("NightBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightBenIsh72ToGra180proprs));
            }

            if (this.NightChazonIsh != null)
            {
                writer.WriteElementString("NightChazonIsh", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightChazonIsh));
            }

            if (this.NightFastRMF != null)
            {
                writer.WriteElementString("NightFastRMF", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightFastRMF));
            }

            if (this.NightFastTuc != null)
            {
                writer.WriteElementString("NightFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightFastTuc));
            }

            if (this.NightGra180 != null)
            {
                writer.WriteElementString("NightGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightGra180));
            }

            if (this.NightGra225 != null)
            {
                writer.WriteElementString("NightGra225", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightGra225));
            }

            if (this.NightGra240 != null)
            {
                writer.WriteElementString("NightGra240", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightGra240));
            }

            if (this.NightMoed != null)
            {
                writer.WriteElementString("NightMoed", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightMoed));
            }

            if (this.NightRadun != null)
            {
                writer.WriteElementString("NightRadun", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightRadun));
            }

            if (this.NightRaful != null)
            {
                writer.WriteElementString("NightRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightRaful));
            }

            if (this.NightShabbos != null)
            {
                writer.WriteElementString("NightShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightShabbos));
            }

            if (this.NightZalman != null)
            {
                writer.WriteElementString("NightZalman", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.NightZalman));
            }

            if (this.PlagBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("PlagBenIsh72ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagBenIsh72ToFastTuc));
            }

            if (this.PlagBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("PlagBenIsh72ToGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagBenIsh72ToGra180));
            }

            if (this.PlagBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("PlagBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagBenIsh72ToGra180propdn));
            }

            if (this.PlagBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("PlagBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagBenIsh72ToGra180proprs));
            }

            if (this.PlagBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("PlagBenIsh72ToShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagBenIsh72ToShabbos));
            }

            if (this.PlagBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("PlagBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagBenIsh72proprsToRaful));
            }

            if (this.PlagBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("PlagBenIsh90ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagBenIsh90ToFastTuc));
            }

            if (this.PlagGra != null)
            {
                writer.WriteElementString("PlagGra", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagGra));
            }

            if (this.PlagMA72 != null)
            {
                writer.WriteElementString("PlagMA72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagMA72));
            }

            if (this.PlagMA72fix != null)
            {
                writer.WriteElementString("PlagMA72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagMA72fix));
            }

            if (this.PlagMA72propdn != null)
            {
                writer.WriteElementString("PlagMA72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagMA72propdn));
            }

            if (this.PlagMA72proprs != null)
            {
                writer.WriteElementString("PlagMA72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagMA72proprs));
            }

            if (this.PlagMA90 != null)
            {
                writer.WriteElementString("PlagMA90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.PlagMA90));
            }

            if (this.PropBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("PropBenIsh72ToFastTuc", this.PropBenIsh72ToFastTuc.ToString());
            }

            if (this.PropBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("PropBenIsh72ToGra180", this.PropBenIsh72ToGra180.ToString());
            }

            if (this.PropBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("PropBenIsh72ToGra180propdn", this.PropBenIsh72ToGra180propdn.ToString());
            }

            if (this.PropBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("PropBenIsh72ToGra180proprs", this.PropBenIsh72ToGra180proprs.ToString());
            }

            if (this.PropBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("PropBenIsh72ToShabbos", this.PropBenIsh72ToShabbos.ToString());
            }

            if (this.PropBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("PropBenIsh72proprsToRaful", this.PropBenIsh72proprsToRaful.ToString());
            }

            if (this.PropBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("PropBenIsh90ToFastTuc", this.PropBenIsh90ToFastTuc.ToString());
            }

            if (this.PropGra != null)
            {
                writer.WriteElementString("PropGra", this.PropGra.ToString());
            }

            if (this.PropMA72 != null)
            {
                writer.WriteElementString("PropMA72", this.PropMA72.ToString());
            }

            if (this.PropMA72fix != null)
            {
                writer.WriteElementString("PropMA72fix", this.PropMA72fix.ToString());
            }

            if (this.PropMA72propdn != null)
            {
                writer.WriteElementString("PropMA72propdn", this.PropMA72propdn.ToString());
            }

            if (this.PropMA72proprs != null)
            {
                writer.WriteElementString("PropMA72proprs", this.PropMA72proprs.ToString());
            }

            if (this.PropMA90 != null)
            {
                writer.WriteElementString("PropMA90", this.PropMA90.ToString());
            }

            if (this.PropRiseToSetElevated != null)
            {
                writer.WriteElementString("PropRiseToSetElevated", this.PropRiseToSetElevated.ToString());
            }

            if (this.PropRmfMorning != null)
            {
                writer.WriteElementString("PropRmfMorning", this.PropRmfMorning.ToString());
            }

            if (this.ShachrisBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("ShachrisBenIsh72ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisBenIsh72ToFastTuc));
            }

            if (this.ShachrisBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("ShachrisBenIsh72ToGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisBenIsh72ToGra180));
            }

            if (this.ShachrisBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("ShachrisBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisBenIsh72ToGra180propdn));
            }

            if (this.ShachrisBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("ShachrisBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisBenIsh72ToGra180proprs));
            }

            if (this.ShachrisBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("ShachrisBenIsh72ToShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisBenIsh72ToShabbos));
            }

            if (this.ShachrisBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("ShachrisBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisBenIsh72proprsToRaful));
            }

            if (this.ShachrisBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("ShachrisBenIsh90ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisBenIsh90ToFastTuc));
            }

            if (this.ShachrisGra != null)
            {
                writer.WriteElementString("ShachrisGra", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisGra));
            }

            if (this.ShachrisMA72 != null)
            {
                writer.WriteElementString("ShachrisMA72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisMA72));
            }

            if (this.ShachrisMA72fix != null)
            {
                writer.WriteElementString("ShachrisMA72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisMA72fix));
            }

            if (this.ShachrisMA72propdn != null)
            {
                writer.WriteElementString("ShachrisMA72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisMA72propdn));
            }

            if (this.ShachrisMA72proprs != null)
            {
                writer.WriteElementString("ShachrisMA72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisMA72proprs));
            }

            if (this.ShachrisMA90 != null)
            {
                writer.WriteElementString("ShachrisMA90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisMA90));
            }

            if (this.ShachrisRMF != null)
            {
                writer.WriteElementString("ShachrisRMF", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShachrisRMF));
            }

            if (this.ShemaBenIsh72ToFastTuc != null)
            {
                writer.WriteElementString("ShemaBenIsh72ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaBenIsh72ToFastTuc));
            }

            if (this.ShemaBenIsh72ToGra180 != null)
            {
                writer.WriteElementString("ShemaBenIsh72ToGra180", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaBenIsh72ToGra180));
            }

            if (this.ShemaBenIsh72ToGra180propdn != null)
            {
                writer.WriteElementString("ShemaBenIsh72ToGra180propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaBenIsh72ToGra180propdn));
            }

            if (this.ShemaBenIsh72ToGra180proprs != null)
            {
                writer.WriteElementString("ShemaBenIsh72ToGra180proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaBenIsh72ToGra180proprs));
            }

            if (this.ShemaBenIsh72ToShabbos != null)
            {
                writer.WriteElementString("ShemaBenIsh72ToShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaBenIsh72ToShabbos));
            }

            if (this.ShemaBenIsh72proprsToRaful != null)
            {
                writer.WriteElementString("ShemaBenIsh72proprsToRaful", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaBenIsh72proprsToRaful));
            }

            if (this.ShemaBenIsh90ToFastTuc != null)
            {
                writer.WriteElementString("ShemaBenIsh90ToFastTuc", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaBenIsh90ToFastTuc));
            }

            if (this.ShemaGra != null)
            {
                writer.WriteElementString("ShemaGra", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaGra));
            }

            if (this.ShemaMA72 != null)
            {
                writer.WriteElementString("ShemaMA72", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaMA72));
            }

            if (this.ShemaMA72fix != null)
            {
                writer.WriteElementString("ShemaMA72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaMA72fix));
            }

            if (this.ShemaMA72propdn != null)
            {
                writer.WriteElementString("ShemaMA72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaMA72propdn));
            }

            if (this.ShemaMA72proprs != null)
            {
                writer.WriteElementString("ShemaMA72proprs", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaMA72proprs));
            }

            if (this.ShemaMA90 != null)
            {
                writer.WriteElementString("ShemaMA90", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaMA90));
            }

            if (this.ShemaRMF != null)
            {
                writer.WriteElementString("ShemaRMF", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.ShemaRMF));
            }

            if (this.SunriseDefault != null)
            {
                writer.WriteElementString("SunriseDefault", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.SunriseDefault));
            }

            if (this.SunriseElevated != null)
            {
                writer.WriteElementString("SunriseElevated", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.SunriseElevated));
            }

            if (this.SunriseLevel != null)
            {
                writer.WriteElementString("SunriseLevel", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.SunriseLevel));
            }

            if (this.SunsetDefault != null)
            {
                writer.WriteElementString("SunsetDefault", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.SunsetDefault));
            }

            if (this.SunsetElevated != null)
            {
                writer.WriteElementString("SunsetElevated", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.SunsetElevated));
            }

            if (this.SunsetLevel != null)
            {
                writer.WriteElementString("SunsetLevel", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.SunsetLevel));
            }

            if (this.Tomorrow2Night72fix != null)
            {
                writer.WriteElementString("Tomorrow2Night72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Tomorrow2Night72fix));
            }

            if (this.Tomorrow2Night72propdn != null)
            {
                writer.WriteElementString("Tomorrow2Night72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Tomorrow2Night72propdn));
            }

            if (this.Tomorrow2NightChazonIsh != null)
            {
                writer.WriteElementString("Tomorrow2NightChazonIsh", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Tomorrow2NightChazonIsh));
            }

            if (this.Tomorrow2NightShabbos != null)
            {
                writer.WriteElementString("Tomorrow2NightShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Tomorrow2NightShabbos));
            }

            if (this.Tomorrow2SunsetDefault != null)
            {
                writer.WriteElementString("Tomorrow2SunsetDefault", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Tomorrow2SunsetDefault));
            }

            if (this.Tomorrow2SunsetElevated != null)
            {
                writer.WriteElementString("Tomorrow2SunsetElevated", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Tomorrow2SunsetElevated));
            }

            if (this.Tomorrow2SunsetLevel != null)
            {
                writer.WriteElementString("Tomorrow2SunsetLevel", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Tomorrow2SunsetLevel));
            }

            if (this.TomorrowNight72fix != null)
            {
                writer.WriteElementString("TomorrowNight72fix", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowNight72fix));
            }

            if (this.TomorrowNight72propdn != null)
            {
                writer.WriteElementString("TomorrowNight72propdn", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowNight72propdn));
            }

            if (this.TomorrowNightChazonIsh != null)
            {
                writer.WriteElementString("TomorrowNightChazonIsh", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowNightChazonIsh));
            }

            if (this.TomorrowNightShabbos != null)
            {
                writer.WriteElementString("TomorrowNightShabbos", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowNightShabbos));
            }

            if (this.TomorrowSunriseDefault != null)
            {
                writer.WriteElementString("TomorrowSunriseDefault", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowSunriseDefault));
            }

            if (this.TomorrowSunriseElevated != null)
            {
                writer.WriteElementString("TomorrowSunriseElevated", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowSunriseElevated));
            }

            if (this.TomorrowSunriseLevel != null)
            {
                writer.WriteElementString("TomorrowSunriseLevel", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowSunriseLevel));
            }

            if (this.TomorrowSunsetDefault != null)
            {
                writer.WriteElementString("TomorrowSunsetDefault", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowSunsetDefault));
            }

            if (this.TomorrowSunsetElevated != null)
            {
                writer.WriteElementString("TomorrowSunsetElevated", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowSunsetElevated));
            }

            if (this.TomorrowSunsetLevel != null)
            {
                writer.WriteElementString("TomorrowSunsetLevel", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.TomorrowSunsetLevel));
            }

            if (this.Yakir062 != null)
            {
                writer.WriteElementString("Yakir062", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Yakir062));
            }

            if (this.Yakir069 != null)
            {
                writer.WriteElementString("Yakir069", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Yakir069));
            }

            if (this.Yakir102 != null)
            {
                writer.WriteElementString("Yakir102", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Yakir102));
            }

            if (this.Yakir110 != null)
            {
                writer.WriteElementString("Yakir110", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Yakir110));
            }

            if (this.Yakir115 != null)
            {
                writer.WriteElementString("Yakir115", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Yakir115));
            }

            if (this.Yakir120 != null)
            {
                writer.WriteElementString("Yakir120", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.Yakir120));
            }

            if (this.YakirDefault != null)
            {
                writer.WriteElementString("YakirDefault", Rfc3339DateTimeXmlUtility.Rfc3339DateToString(this.YakirDefault));
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

            this.Candles = obj.Candles;
            this.Candles10 = obj.Candles10;
            this.Candles15 = obj.Candles15;
            this.Candles18 = obj.Candles18;
            this.Candles20 = obj.Candles20;
            this.Candles22 = obj.Candles22;
            this.Candles30 = obj.Candles30;
            this.Candles40 = obj.Candles40;
            this.ChametzBurnBenIsh72ToFastTuc = obj.ChametzBurnBenIsh72ToFastTuc;
            this.ChametzBurnBenIsh72ToGra180 = obj.ChametzBurnBenIsh72ToGra180;
            this.ChametzBurnBenIsh72ToGra180propdn = obj.ChametzBurnBenIsh72ToGra180propdn;
            this.ChametzBurnBenIsh72ToGra180proprs = obj.ChametzBurnBenIsh72ToGra180proprs;
            this.ChametzBurnBenIsh72ToShabbos = obj.ChametzBurnBenIsh72ToShabbos;
            this.ChametzBurnBenIsh72proprsToRaful = obj.ChametzBurnBenIsh72proprsToRaful;
            this.ChametzBurnBenIsh90ToFastTuc = obj.ChametzBurnBenIsh90ToFastTuc;
            this.ChametzBurnGra = obj.ChametzBurnGra;
            this.ChametzBurnMA72 = obj.ChametzBurnMA72;
            this.ChametzBurnMA72fix = obj.ChametzBurnMA72fix;
            this.ChametzBurnMA72propdn = obj.ChametzBurnMA72propdn;
            this.ChametzBurnMA72proprs = obj.ChametzBurnMA72proprs;
            this.ChametzBurnMA90 = obj.ChametzBurnMA90;
            this.ChametzBurnRMF = obj.ChametzBurnRMF;
            this.ChametzEatBenIsh72ToFastTuc = obj.ChametzEatBenIsh72ToFastTuc;
            this.ChametzEatBenIsh72ToGra180 = obj.ChametzEatBenIsh72ToGra180;
            this.ChametzEatBenIsh72ToGra180propdn = obj.ChametzEatBenIsh72ToGra180propdn;
            this.ChametzEatBenIsh72ToGra180proprs = obj.ChametzEatBenIsh72ToGra180proprs;
            this.ChametzEatBenIsh72ToShabbos = obj.ChametzEatBenIsh72ToShabbos;
            this.ChametzEatBenIsh72proprsToRaful = obj.ChametzEatBenIsh72proprsToRaful;
            this.ChametzEatBenIsh90ToFastTuc = obj.ChametzEatBenIsh90ToFastTuc;
            this.ChametzEatGra = obj.ChametzEatGra;
            this.ChametzEatMA72 = obj.ChametzEatMA72;
            this.ChametzEatMA72fix = obj.ChametzEatMA72fix;
            this.ChametzEatMA72propdn = obj.ChametzEatMA72propdn;
            this.ChametzEatMA72proprs = obj.ChametzEatMA72proprs;
            this.ChametzEatMA90 = obj.ChametzEatMA90;
            this.ChametzEatRMF = obj.ChametzEatRMF;
            this.CurrentTime = obj.CurrentTime;
            this.Dawn72 = obj.Dawn72;
            this.Dawn72fix = obj.Dawn72fix;
            this.Dawn72propdn = obj.Dawn72propdn;
            this.Dawn72proprs = obj.Dawn72proprs;
            this.Dawn90 = obj.Dawn90;
            this.DawnBenIsh72ToGra180propdn = obj.DawnBenIsh72ToGra180propdn;
            this.DawnRMF = obj.DawnRMF;
            this.KetanaBenIsh72ToFastTuc = obj.KetanaBenIsh72ToFastTuc;
            this.KetanaBenIsh72ToGra180 = obj.KetanaBenIsh72ToGra180;
            this.KetanaBenIsh72ToGra180propdn = obj.KetanaBenIsh72ToGra180propdn;
            this.KetanaBenIsh72ToGra180proprs = obj.KetanaBenIsh72ToGra180proprs;
            this.KetanaBenIsh72ToShabbos = obj.KetanaBenIsh72ToShabbos;
            this.KetanaBenIsh72proprsToRaful = obj.KetanaBenIsh72proprsToRaful;
            this.KetanaBenIsh90ToFastTuc = obj.KetanaBenIsh90ToFastTuc;
            this.KetanaGra = obj.KetanaGra;
            this.KetanaMA72 = obj.KetanaMA72;
            this.KetanaMA72fix = obj.KetanaMA72fix;
            this.KetanaMA72propdn = obj.KetanaMA72propdn;
            this.KetanaMA72proprs = obj.KetanaMA72proprs;
            this.KetanaMA90 = obj.KetanaMA90;
            this.MealBenIsh72ToFastTuc = obj.MealBenIsh72ToFastTuc;
            this.MealBenIsh72ToGra180 = obj.MealBenIsh72ToGra180;
            this.MealBenIsh72ToGra180propdn = obj.MealBenIsh72ToGra180propdn;
            this.MealBenIsh72ToGra180proprs = obj.MealBenIsh72ToGra180proprs;
            this.MealBenIsh72ToShabbos = obj.MealBenIsh72ToShabbos;
            this.MealBenIsh72proprsToRaful = obj.MealBenIsh72proprsToRaful;
            this.MealBenIsh90ToFastTuc = obj.MealBenIsh90ToFastTuc;
            this.MealGra = obj.MealGra;
            this.MealMA72 = obj.MealMA72;
            this.MealMA72fix = obj.MealMA72fix;
            this.MealMA72propdn = obj.MealMA72propdn;
            this.MealMA72proprs = obj.MealMA72proprs;
            this.MealMA90 = obj.MealMA90;
            this.Midday = obj.Midday;
            this.MiddayBenIsh72proprsToRaful = obj.MiddayBenIsh72proprsToRaful;
            this.MiddayRMF = obj.MiddayRMF;
            this.Midnight = obj.Midnight;
            this.Mincha30fix = obj.Mincha30fix;
            this.MinchaBenIsh72ToFastTuc = obj.MinchaBenIsh72ToFastTuc;
            this.MinchaBenIsh72ToGra180 = obj.MinchaBenIsh72ToGra180;
            this.MinchaBenIsh72ToGra180propdn = obj.MinchaBenIsh72ToGra180propdn;
            this.MinchaBenIsh72ToGra180proprs = obj.MinchaBenIsh72ToGra180proprs;
            this.MinchaBenIsh72ToShabbos = obj.MinchaBenIsh72ToShabbos;
            this.MinchaBenIsh72proprsToRaful = obj.MinchaBenIsh72proprsToRaful;
            this.MinchaBenIsh90ToFastTuc = obj.MinchaBenIsh90ToFastTuc;
            this.MinchaGra = obj.MinchaGra;
            this.MinchaMA72 = obj.MinchaMA72;
            this.MinchaMA72fix = obj.MinchaMA72fix;
            this.MinchaMA72propdn = obj.MinchaMA72propdn;
            this.MinchaMA72proprs = obj.MinchaMA72proprs;
            this.MinchaMA90 = obj.MinchaMA90;
            this.MinchaStrict = obj.MinchaStrict;
            this.MussafBenIsh72ToFastTuc = obj.MussafBenIsh72ToFastTuc;
            this.MussafBenIsh72ToGra180 = obj.MussafBenIsh72ToGra180;
            this.MussafBenIsh72ToGra180propdn = obj.MussafBenIsh72ToGra180propdn;
            this.MussafBenIsh72ToGra180proprs = obj.MussafBenIsh72ToGra180proprs;
            this.MussafBenIsh72ToShabbos = obj.MussafBenIsh72ToShabbos;
            this.MussafBenIsh72proprsToRaful = obj.MussafBenIsh72proprsToRaful;
            this.MussafBenIsh90ToFastTuc = obj.MussafBenIsh90ToFastTuc;
            this.MussafGra = obj.MussafGra;
            this.MussafMA72 = obj.MussafMA72;
            this.MussafMA72fix = obj.MussafMA72fix;
            this.MussafMA72propdn = obj.MussafMA72propdn;
            this.MussafMA72proprs = obj.MussafMA72proprs;
            this.MussafMA90 = obj.MussafMA90;
            this.Night40fix = obj.Night40fix;
            this.Night50fix = obj.Night50fix;
            this.Night60fix = obj.Night60fix;
            this.Night72 = obj.Night72;
            this.Night72fix = obj.Night72fix;
            this.Night72fixLevel = obj.Night72fixLevel;
            this.Night72propdn = obj.Night72propdn;
            this.Night72proprs = obj.Night72proprs;
            this.Night90 = obj.Night90;
            this.NightAgudas = obj.NightAgudas;
            this.NightBenIsh72ToGra180propdn = obj.NightBenIsh72ToGra180propdn;
            this.NightBenIsh72ToGra180proprs = obj.NightBenIsh72ToGra180proprs;
            this.NightChazonIsh = obj.NightChazonIsh;
            this.NightFastRMF = obj.NightFastRMF;
            this.NightFastTuc = obj.NightFastTuc;
            this.NightGra180 = obj.NightGra180;
            this.NightGra225 = obj.NightGra225;
            this.NightGra240 = obj.NightGra240;
            this.NightMoed = obj.NightMoed;
            this.NightRadun = obj.NightRadun;
            this.NightRaful = obj.NightRaful;
            this.NightShabbos = obj.NightShabbos;
            this.NightZalman = obj.NightZalman;
            this.PlagBenIsh72ToFastTuc = obj.PlagBenIsh72ToFastTuc;
            this.PlagBenIsh72ToGra180 = obj.PlagBenIsh72ToGra180;
            this.PlagBenIsh72ToGra180propdn = obj.PlagBenIsh72ToGra180propdn;
            this.PlagBenIsh72ToGra180proprs = obj.PlagBenIsh72ToGra180proprs;
            this.PlagBenIsh72ToShabbos = obj.PlagBenIsh72ToShabbos;
            this.PlagBenIsh72proprsToRaful = obj.PlagBenIsh72proprsToRaful;
            this.PlagBenIsh90ToFastTuc = obj.PlagBenIsh90ToFastTuc;
            this.PlagGra = obj.PlagGra;
            this.PlagMA72 = obj.PlagMA72;
            this.PlagMA72fix = obj.PlagMA72fix;
            this.PlagMA72propdn = obj.PlagMA72propdn;
            this.PlagMA72proprs = obj.PlagMA72proprs;
            this.PlagMA90 = obj.PlagMA90;
            this.PropBenIsh72ToFastTuc = obj.PropBenIsh72ToFastTuc;
            this.PropBenIsh72ToGra180 = obj.PropBenIsh72ToGra180;
            this.PropBenIsh72ToGra180propdn = obj.PropBenIsh72ToGra180propdn;
            this.PropBenIsh72ToGra180proprs = obj.PropBenIsh72ToGra180proprs;
            this.PropBenIsh72ToShabbos = obj.PropBenIsh72ToShabbos;
            this.PropBenIsh72proprsToRaful = obj.PropBenIsh72proprsToRaful;
            this.PropBenIsh90ToFastTuc = obj.PropBenIsh90ToFastTuc;
            this.PropGra = obj.PropGra;
            this.PropMA72 = obj.PropMA72;
            this.PropMA72fix = obj.PropMA72fix;
            this.PropMA72propdn = obj.PropMA72propdn;
            this.PropMA72proprs = obj.PropMA72proprs;
            this.PropMA90 = obj.PropMA90;
            this.PropRiseToSetElevated = obj.PropRiseToSetElevated;
            this.PropRmfMorning = obj.PropRmfMorning;
            this.ShachrisBenIsh72ToFastTuc = obj.ShachrisBenIsh72ToFastTuc;
            this.ShachrisBenIsh72ToGra180 = obj.ShachrisBenIsh72ToGra180;
            this.ShachrisBenIsh72ToGra180propdn = obj.ShachrisBenIsh72ToGra180propdn;
            this.ShachrisBenIsh72ToGra180proprs = obj.ShachrisBenIsh72ToGra180proprs;
            this.ShachrisBenIsh72ToShabbos = obj.ShachrisBenIsh72ToShabbos;
            this.ShachrisBenIsh72proprsToRaful = obj.ShachrisBenIsh72proprsToRaful;
            this.ShachrisBenIsh90ToFastTuc = obj.ShachrisBenIsh90ToFastTuc;
            this.ShachrisGra = obj.ShachrisGra;
            this.ShachrisMA72 = obj.ShachrisMA72;
            this.ShachrisMA72fix = obj.ShachrisMA72fix;
            this.ShachrisMA72propdn = obj.ShachrisMA72propdn;
            this.ShachrisMA72proprs = obj.ShachrisMA72proprs;
            this.ShachrisMA90 = obj.ShachrisMA90;
            this.ShachrisRMF = obj.ShachrisRMF;
            this.ShemaBenIsh72ToFastTuc = obj.ShemaBenIsh72ToFastTuc;
            this.ShemaBenIsh72ToGra180 = obj.ShemaBenIsh72ToGra180;
            this.ShemaBenIsh72ToGra180propdn = obj.ShemaBenIsh72ToGra180propdn;
            this.ShemaBenIsh72ToGra180proprs = obj.ShemaBenIsh72ToGra180proprs;
            this.ShemaBenIsh72ToShabbos = obj.ShemaBenIsh72ToShabbos;
            this.ShemaBenIsh72proprsToRaful = obj.ShemaBenIsh72proprsToRaful;
            this.ShemaBenIsh90ToFastTuc = obj.ShemaBenIsh90ToFastTuc;
            this.ShemaGra = obj.ShemaGra;
            this.ShemaMA72 = obj.ShemaMA72;
            this.ShemaMA72fix = obj.ShemaMA72fix;
            this.ShemaMA72propdn = obj.ShemaMA72propdn;
            this.ShemaMA72proprs = obj.ShemaMA72proprs;
            this.ShemaMA90 = obj.ShemaMA90;
            this.ShemaRMF = obj.ShemaRMF;
            this.SunriseDefault = obj.SunriseDefault;
            this.SunriseElevated = obj.SunriseElevated;
            this.SunriseLevel = obj.SunriseLevel;
            this.SunsetDefault = obj.SunsetDefault;
            this.SunsetElevated = obj.SunsetElevated;
            this.SunsetLevel = obj.SunsetLevel;
            this.Tomorrow2Night72fix = obj.Tomorrow2Night72fix;
            this.Tomorrow2Night72propdn = obj.Tomorrow2Night72propdn;
            this.Tomorrow2NightChazonIsh = obj.Tomorrow2NightChazonIsh;
            this.Tomorrow2NightShabbos = obj.Tomorrow2NightShabbos;
            this.Tomorrow2SunsetDefault = obj.Tomorrow2SunsetDefault;
            this.Tomorrow2SunsetElevated = obj.Tomorrow2SunsetElevated;
            this.Tomorrow2SunsetLevel = obj.Tomorrow2SunsetLevel;
            this.TomorrowNight72fix = obj.TomorrowNight72fix;
            this.TomorrowNight72propdn = obj.TomorrowNight72propdn;
            this.TomorrowNightChazonIsh = obj.TomorrowNightChazonIsh;
            this.TomorrowNightShabbos = obj.TomorrowNightShabbos;
            this.TomorrowSunriseDefault = obj.TomorrowSunriseDefault;
            this.TomorrowSunriseElevated = obj.TomorrowSunriseElevated;
            this.TomorrowSunriseLevel = obj.TomorrowSunriseLevel;
            this.TomorrowSunsetDefault = obj.TomorrowSunsetDefault;
            this.TomorrowSunsetElevated = obj.TomorrowSunsetElevated;
            this.TomorrowSunsetLevel = obj.TomorrowSunsetLevel;
            this.Yakir062 = obj.Yakir062;
            this.Yakir069 = obj.Yakir069;
            this.Yakir102 = obj.Yakir102;
            this.Yakir110 = obj.Yakir110;
            this.Yakir115 = obj.Yakir115;
            this.Yakir120 = obj.Yakir120;
            this.YakirDefault = obj.YakirDefault;
        }
    }
}