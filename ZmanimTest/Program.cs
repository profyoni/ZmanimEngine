using System;

namespace ZmanimTest
{

	class Program
	{
		static internal void Foo() { }
		static void Main(string [] args)
        {
			var app = new ZmanimTest.Program();
			app.Page_Load(null,null);
		
		}    

const string APIURL = "https://api.myzmanim.com/engine1.svc";
		const string APIUSER = "fillin";
		const string APIKEY = "fillin";

		protected void Page_Load(object sender, System.EventArgs e)
		{
			string LocationID = null;

			//Look up the locationID for the desired place: (Uncomment one of the following examples)
			LocationID = FindPostal("11559");     //Typical US zip code
												  //LocationID = FindPostal("M6B2K9");   //Typical Canadian postal code
												  //LocationID = FindPostal("NW118AU");  //Typical UK postcode
												  //LocationID = FindPostal("90500");    //Typical 5-digit Israel Mikud code
												  //LocationID = FindPostal("JFK");      //Typical airport code
												  //LocationID = FindPostal("27526341"); //Typical MyZmanim LocationID
												  //LocationID = FindGps(48.86413211779521324, 2.32941612345133754);   //Typical GPS coordinates

			//Display Zmanim information for said location:
			DisplayZmanim(LocationID);
		}

		public EngineClient CreateApiInstance()
		{
			System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding();
			System.ServiceModel.EndpointAddress address = new System.ServiceModel.EndpointAddress(APIURL);
			if (APIURL.Contains("https://"))
				binding.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
			EngineClient Client = new EngineClient(binding, address);
			return Client;
		}

		public void DisplayZmanim(string pLocationID)
		{
			EngineClient ZmanimAPI = CreateApiInstance();
			EngineParamDay Params = new EngineParamDay();
			EngineResultDay Day = new EngineResultDay();

			Params.User = APIUSER;
			Params.Key = APIKEY;
			Params.Coding = "CS";
			Params.Language = "en";     // Can be set to any MZ-supported language: he|es|fr|de|ru|pt
			Params.InputDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Unspecified);
			Params.LocationID = pLocationID;

			try
			{
				Day = ZmanimAPI.GetDay(Params);     // You may also use: GetDayAsync()
			}
			catch (System.ServiceModel.CommunicationException cex)
			{
				UnableToConnect(cex.Message);
			}
			catch (Exception ex)
			{
				SomethingWrong(ex.Message);
			}

			if (Day.ErrMsg != null)
			{
				Console.Write("Error: " + Day.ErrMsg);
				return;
			}


			Console.Write("    \n" + Day.Place.Name);
			Console.Write("    \n" + Day.Time.DateSemiLong);
			Console.Write("    \n" + Day.Time.Weekday);
			if (Day.Zman.CurrentTime != default(DateTime))     // Display the current time if available and applicable. (A value of default indicates the time is not available.)
				Console.Write("    \n" + Day.Zman.CurrentTime.ToString("t"));
			if ((Day.Time.ParshaAndHoliday != ""))
				Console.Write("\n" + Day.Time.ParshaAndHoliday);
			if ((Day.Time.Omer != 0))
				Console.Write("\nOmer count " + Day.Time.Omer.ToString());
			switch (Day.Time.DaylightTime)
			{
				case 0:
					Console.Write("\nStandard Time");
					break;
				case 1:
					Console.Write("\nDaylight Saving Time");
					break;
				case 2:
					Console.Write("\nAdd 1 hr for DST when applicable.");
					break;
				case 3:
					Console.Write("\nAdd 1 hr for DST if/when applicable");
					break;
			}
			Console.Write("\n-----------");
			Console.Write("\nDawn: " + Day.Zman.Dawn72.ToString("t"));
			Console.Write("\nEarliest Talis (" + Day.Place.YakirDegreesDefault + "&deg;): " + Day.Zman.YakirDefault.ToString("t"));
			Console.Write("\nSunrise: " + Day.Zman.SunriseDefault.ToString("T"));
			Console.Write("\nShema MA: " + Day.Zman.ShemaMA72.ToString("t"));
			Console.Write("\nShema Gra: " + Day.Zman.ShemaGra.ToString("t"));
			Console.Write("\nShachris Gra: " + Day.Zman.ShachrisGra.ToString("t"));
			Console.Write("\nMidday: " + Day.Zman.Midday.ToString("t"));
			Console.Write("\nEarliest Mincha: " + Day.Zman.MinchaStrict.ToString("t"));
			Console.Write("\nPlag Hamincha: " + Day.Zman.PlagGra.ToString("t"));
			if (Day.Zman.Candles != default(DateTime))     // Display candlelighting time if available and applicable.
				Console.Write("\nCandlelighting (" + Day.Place.CandlelightingMinutes + " min): " + Day.Zman.Candles.ToString("t"));
			Console.Write("\nSunset: " + Day.Zman.SunsetDefault.ToString("t"));
			Console.Write("\nNight 3 stars: " + Day.Zman.NightShabbos.ToString("t"));
			Console.Write("\nNight 72 minutes: " + Day.Zman.Night72fix.ToString("t"));
			Console.Write("\n");
			Console.Write("\nMinyan for Mincha at: " + Day.Zman.SunsetDefault.AddMinutes(-20).ToString("t"));
			Console.Write("\n");
			Console.Write("\nPowered by <a href='http://www.myZmanim.com/'>MyZmanim</a>");
			Console.Write("</div>");

			Console.Write("\n");
			Console.Write("\nMEMBERS ");
			Console.Write("\n=========================");
			Console.Write("\nPlace.LocationID: " + Day.Place.LocationID);
			Console.Write("\nPlace.Name: " + Day.Place.Name);
			Console.Write("\nPlace.NameShort: " + Day.Place.NameShort);
			Console.Write("\nPlace.Country: " + Day.Place.Country);
			Console.Write("\nPlace.State: " + Day.Place.State);
			Console.Write("\nPlace.County: " + Day.Place.County);
			Console.Write("\nPlace.City: " + Day.Place.City);
			Console.Write("\nPlace.PostalCode: " + Day.Place.PostalCode);
			Console.Write("\nPlace.DavenDirectionGC: " + Day.Place.DavenDirectionGC);
			Console.Write("\nPlace.DavenDirectionRL: " + Day.Place.DavenDirectionRL);
			Console.Write("\nPlace.CandlelightingMinutes: " + Day.Place.CandlelightingMinutes);
			Console.Write("\nPlace.YakirDegreesDefault: " + Day.Place.YakirDegreesDefault);
			Console.Write("\nPlace.ElevationObserver: " + Day.Place.ElevationObserver);
			Console.Write("\nPlace.ElevationWest: " + Day.Place.ElevationWest);
			Console.Write("\nPlace.ElevationEast: " + Day.Place.ElevationEast);
			Console.Write("\nPlace.ObservesDST: " + Day.Place.ObservesDST);
			Console.Write("\nPlace.AirportCode: " + Day.Place.AirportCode);
			Console.Write("\nPlace.CityHebrew: " + Day.Place.CityHebrew);
			Console.Write("\n");
			Console.Write("\nTime.DateCivil: " + Day.Time.DateCivil.ToString("yyyy-MM-dd"));
			Console.Write("\nTime.DateCivilLong: " + Day.Time.DateCivilLong);
			Console.Write("\nTime.DateJewish: " + Day.Time.DateJewish);
			Console.Write("\nTime.DateJewishLong: " + Day.Time.DateJewishLong);
			Console.Write("\nTime.DateJewishShort: " + Day.Time.DateJewishShort);
			Console.Write("\nTime.DateFullLong: " + Day.Time.DateFullLong);
			Console.Write("\nTime.DateFullShort: " + Day.Time.DateFullShort);
			Console.Write("\nTime.DateSemiLong: " + Day.Time.DateSemiLong);
			Console.Write("\nTime.DateSemiShort: " + Day.Time.DateSemiShort);
			Console.Write("\nTime.Weekday: " + Day.Time.Weekday);
			Console.Write("\nTime.WeekdayShort: " + Day.Time.WeekdayShort);
			Console.Write("\nTime.Omer: " + Day.Time.Omer);
			Console.Write("\nTime.DafYomiTract: " + Day.Time.DafYomiTract);
			Console.Write("\nTime.DafYomiPage: " + Day.Time.DafYomiPage);
			Console.Write("\nTime.DafYomi: " + Day.Time.DafYomi);
			Console.Write("\nTime.DaylightTime: " + Day.Time.DaylightTime);
			Console.Write("\nTime.Parsha: " + Day.Time.Parsha);
			Console.Write("\nTime.ParshaShort: " + Day.Time.ParshaShort);
			Console.Write("\nTime.Holiday: " + Day.Time.Holiday);
			Console.Write("\nTime.HolidayShort: " + Day.Time.HolidayShort);
			Console.Write("\nTime.ParshaAndHoliday: " + Day.Time.ParshaAndHoliday);
			Console.Write("\nTime.TomorrowParsha: " + Day.Time.TomorrowParsha);
			Console.Write("\nTime.TomorrowParshaOrHoliday: " + Day.Time.TomorrowParshaOrHoliday);
			Console.Write("\n");
			Console.Write("\nTime.IsShabbos: " + Day.Time.IsShabbos);
			Console.Write("\nTime.IsYomTov: " + Day.Time.IsYomTov);
			Console.Write("\nTime.IsCholHamoed: " + Day.Time.IsCholHamoed);
			Console.Write("\nTime.IsYomKipper: " + Day.Time.IsYomKipper);
			Console.Write("\nTime.IsTishaBav: " + Day.Time.IsTishaBav);
			Console.Write("\nTime.IsErevTishaBav: " + Day.Time.IsErevTishaBav);
			Console.Write("\nTime.IsShivaAsarBitammuz: " + Day.Time.IsShivaAsarBitammuz);
			Console.Write("\nTime.IsTaanisEsther: " + Day.Time.IsTaanisEsther);
			Console.Write("\nTime.IsTzomGedalia: " + Day.Time.IsTzomGedalia);
			Console.Write("\nTime.IsAsaraBiteves: " + Day.Time.IsAsaraBiteves);
			Console.Write("\nTime.IsFastDay: " + Day.Time.IsFastDay);
			Console.Write("\nTime.IsErevPesach: " + Day.Time.IsErevPesach);
			Console.Write("\nTime.IsRoshChodesh: " + Day.Time.IsRoshChodesh);
			Console.Write("\nTime.IsTuBeshvat: " + Day.Time.IsTuBeshvat);
			Console.Write("\nTime.IsErevShabbos: " + Day.Time.IsErevShabbos);
			Console.Write("\nTime.IsErevYomTov: " + Day.Time.IsErevYomTov);
			Console.Write("\nTime.IsErevYomKipper: " + Day.Time.IsErevYomKipper);
			Console.Write("\nTime.TonightIsYomTov: " + Day.Time.TonightIsYomTov);
			Console.Write("\nTime.TomorrowNightIsYomTov: " + Day.Time.TomorrowNightIsYomTov);
			Console.Write("\n");
			Console.Write("\nZman.Dawn90: " + Day.Zman.Dawn90.ToString("t"));
			Console.Write("\nZman.Dawn72: " + Day.Zman.Dawn72.ToString("t"));
			Console.Write("\nZman.Dawn72fix: " + Day.Zman.Dawn72fix.ToString("t"));
			Console.Write("\nZman.DawnRMF: " + Day.Zman.DawnRMF.ToString("t"));
			Console.Write("\nZman.Yakir115: " + Day.Zman.Yakir115.ToString("t"));
			Console.Write("\nZman.Yakir110: " + Day.Zman.Yakir110.ToString("t"));
			Console.Write("\nZman.Yakir102: " + Day.Zman.Yakir102.ToString("t"));
			Console.Write("\nZman.YakirDefault: " + Day.Zman.YakirDefault.ToString("t"));
			Console.Write("\nZman.SunriseLevel: " + Day.Zman.SunriseLevel.ToString("T"));
			Console.Write("\nZman.SunriseElevated: " + Day.Zman.SunriseElevated.ToString("T"));
			Console.Write("\nZman.SunriseDefault: " + Day.Zman.SunriseDefault.ToString("T"));
			Console.Write("\nZman.ShemaBenIsh90ToFastTuc: " + Day.Zman.ShemaBenIsh90ToFastTuc.ToString("t"));
			Console.Write("\nZman.ShemaBenIsh72ToFastTuc: " + Day.Zman.ShemaBenIsh72ToFastTuc.ToString("t"));
			Console.Write("\nZman.ShemaBenIsh72ToShabbos: " + Day.Zman.ShemaBenIsh72ToShabbos.ToString("t"));
			Console.Write("\nZman.ShemaMA90: " + Day.Zman.ShemaMA90.ToString("t"));
			Console.Write("\nZman.ShemaMA72: " + Day.Zman.ShemaMA72.ToString("t"));
			Console.Write("\nZman.ShemaMA72fix: " + Day.Zman.ShemaMA72fix.ToString("t"));
			Console.Write("\nZman.ShemaGra: " + Day.Zman.ShemaGra.ToString("t"));
			Console.Write("\nZman.ShemaRMF: " + Day.Zman.ShemaRMF.ToString("t"));
			Console.Write("\nZman.ShachrisMA90: " + Day.Zman.ShachrisMA90.ToString("t"));
			Console.Write("\nZman.ShachrisMA72: " + Day.Zman.ShachrisMA72.ToString("t"));
			Console.Write("\nZman.ShachrisMA72fix: " + Day.Zman.ShachrisMA72fix.ToString("t"));
			Console.Write("\nZman.ShachrisGra: " + Day.Zman.ShachrisGra.ToString("t"));
			Console.Write("\nZman.ShachrisRMF: " + Day.Zman.ShachrisRMF.ToString("t"));
			Console.Write("\nZman.Midday: " + Day.Zman.Midday.ToString("t"));
			Console.Write("\nZman.MiddayRMF: " + Day.Zman.MiddayRMF.ToString("t"));
			Console.Write("\nZman.MinchaGra: " + Day.Zman.MinchaGra.ToString("t"));
			Console.Write("\nZman.Mincha30fix: " + Day.Zman.Mincha30fix.ToString("t"));
			Console.Write("\nZman.MinchaMA72fix: " + Day.Zman.MinchaMA72fix.ToString("t"));
			Console.Write("\nZman.MinchaStrict: " + Day.Zman.MinchaStrict.ToString("t"));
			Console.Write("\nZman.KetanaGra: " + Day.Zman.KetanaGra.ToString("t"));
			Console.Write("\nZman.KetanaMA72fix: " + Day.Zman.KetanaMA72fix.ToString("t"));
			Console.Write("\nZman.PlagGra: " + Day.Zman.PlagGra.ToString("t"));
			Console.Write("\nZman.PlagMA72fix: " + Day.Zman.PlagMA72fix.ToString("t"));
			Console.Write("\nZman.PlagBenIsh90ToFastTuc: " + Day.Zman.PlagBenIsh90ToFastTuc.ToString("t"));
			Console.Write("\nZman.PlagBenIsh72ToFastTuc: " + Day.Zman.PlagBenIsh72ToFastTuc.ToString("t"));
			Console.Write("\nZman.PlagBenIsh72ToShabbos: " + Day.Zman.PlagBenIsh72ToShabbos.ToString("t"));
			Console.Write("\nZman.SunsetLevel: " + Day.Zman.SunsetLevel.ToString("t"));
			Console.Write("\nZman.SunsetElevated: " + Day.Zman.SunsetElevated.ToString("t"));
			Console.Write("\nZman.SunsetDefault: " + Day.Zman.SunsetDefault.ToString("t"));
			Console.Write("\nZman.NightGra180: " + Day.Zman.NightGra180.ToString("t"));
			Console.Write("\nZman.NightGra225: " + Day.Zman.NightGra225.ToString("t"));
			Console.Write("\nZman.NightGra240: " + Day.Zman.NightGra240.ToString("t"));
			Console.Write("\nZman.NightZalman: " + Day.Zman.NightZalman.ToString("t"));
			Console.Write("\nZman.NightFastTuc: " + Day.Zman.NightFastTuc.ToString("t"));
			Console.Write("\nZman.NightFastRMF: " + Day.Zman.NightFastRMF.ToString("t"));
			Console.Write("\nZman.NightMoed: " + Day.Zman.NightMoed.ToString("t"));
			Console.Write("\nZman.NightShabbos: " + Day.Zman.NightShabbos.ToString("t"));
			Console.Write("\nZman.NightChazonIsh: " + Day.Zman.NightChazonIsh.ToString("t"));
			Console.Write("\nZman.Night50fix: " + Day.Zman.Night50fix.ToString("t"));
			Console.Write("\nZman.Night60fix: " + Day.Zman.Night60fix.ToString("t"));
			Console.Write("\nZman.Night72: " + Day.Zman.Night72.ToString("t"));
			Console.Write("\nZman.Night72fix: " + Day.Zman.Night72fix.ToString("t"));
			Console.Write("\nZman.Night72fixLevel: " + Day.Zman.Night72fixLevel.ToString("t"));
			Console.Write("\nZman.Night90: " + Day.Zman.Night90.ToString("t"));
			Console.Write("\nZman.Midnight: " + Day.Zman.Midnight.ToString("t"));
			Console.Write("\n");
			Console.Write("\nZman.ChametzEatGra: " + Day.Zman.ChametzEatGra.ToString("t"));
			Console.Write("\nZman.ChametzEatMA72: " + Day.Zman.ChametzEatMA72.ToString("t"));
			Console.Write("\nZman.ChametzEatMA72fix: " + Day.Zman.ChametzEatMA72fix.ToString("t"));
			Console.Write("\nZman.ChametzEatRMF: " + Day.Zman.ChametzEatRMF.ToString("t"));
			Console.Write("\nZman.ChametzBurnGra: " + Day.Zman.ChametzBurnGra.ToString("t"));
			Console.Write("\nZman.ChametzBurnMA72: " + Day.Zman.ChametzBurnMA72.ToString("t"));
			Console.Write("\nZman.ChametzBurnMA72fix: " + Day.Zman.ChametzBurnMA72fix.ToString("t"));
			Console.Write("\nZman.ChametzBurnRMF: " + Day.Zman.ChametzBurnRMF.ToString("t"));
			Console.Write("\n");
			Console.Write("\nZman.TomorrowNightShabbos: " + Day.Zman.TomorrowNightShabbos.ToString("t"));
			Console.Write("\nZman.TomorrowSunriseLevel: " + Day.Zman.TomorrowSunriseLevel.ToString("T"));
			Console.Write("\nZman.TomorrowSunriseElevated: " + Day.Zman.TomorrowSunriseElevated.ToString("T"));
			Console.Write("\nZman.TomorrowSunriseDefault: " + Day.Zman.TomorrowSunriseDefault.ToString("T"));
			Console.Write("\nZman.TomorrowSunsetLevel: " + Day.Zman.TomorrowSunsetLevel.ToString("t"));
			Console.Write("\nZman.TomorrowSunsetElevated: " + Day.Zman.TomorrowSunsetElevated.ToString("t"));
			Console.Write("\nZman.TomorrowSunsetDefault: " + Day.Zman.TomorrowSunsetDefault.ToString("t"));
			Console.Write("\nZman.TomorrowNight72fix: " + Day.Zman.TomorrowNight72fix.ToString("t"));
			Console.Write("\nZman.TomorrowNightChazonIsh: " + Day.Zman.TomorrowNightChazonIsh.ToString("t"));
			Console.Write("\nZman.Tomorrow2NightShabbos: " + Day.Zman.Tomorrow2NightShabbos.ToString("t"));
			Console.Write("\nZman.Tomorrow2SunsetLevel: " + Day.Zman.Tomorrow2SunsetLevel.ToString("t"));
			Console.Write("\nZman.Tomorrow2SunsetElevated: " + Day.Zman.Tomorrow2SunsetElevated.ToString("t"));
			Console.Write("\nZman.Tomorrow2SunsetDefault: " + Day.Zman.Tomorrow2SunsetDefault.ToString("t"));
			Console.Write("\nZman.Tomorrow2Night72fix: " + Day.Zman.Tomorrow2Night72fix.ToString("t"));
			Console.Write("\nZman.Tomorrow2NightChazonIsh: " + Day.Zman.Tomorrow2NightChazonIsh.ToString("t"));
			Console.Write("\n");
			Console.Write("\nZman.PropGra: " + TimeSpan.FromTicks(Day.Zman.PropGra).TotalMinutes.ToString("N1"));
			Console.Write("\nZman.PropMA72: " + TimeSpan.FromTicks(Day.Zman.PropMA72).TotalMinutes.ToString("N1"));
			Console.Write("\nZman.PropMA72fix: " + TimeSpan.FromTicks(Day.Zman.PropMA72fix).TotalMinutes.ToString("N1"));
			Console.Write("\nZman.PropMA90: " + TimeSpan.FromTicks(Day.Zman.PropMA90).TotalMinutes.ToString("N1"));
			Console.Write("\nZman.PropRmfMorning: " + TimeSpan.FromTicks(Day.Zman.PropRmfMorning).TotalMinutes.ToString("N1"));
			Console.Write("\nZman.PropBenIsh90ToFastTuc: " + TimeSpan.FromTicks(Day.Zman.PropBenIsh90ToFastTuc).TotalMinutes.ToString("N1"));
			Console.Write("\nZman.PropBenIsh72ToFastTuc: " + TimeSpan.FromTicks(Day.Zman.PropBenIsh72ToFastTuc).TotalMinutes.ToString("N1"));
			Console.Write("\nZman.PropBenIsh72ToShabbos: " + TimeSpan.FromTicks(Day.Zman.PropBenIsh72ToShabbos).TotalMinutes.ToString("N1"));
			Console.Write("\n");
			Console.Write("\n" + Day.Copyright);
			Console.Write("</body>");
			Console.Write("</html>");

			ZmanimAPI.Close();
		}


		public string FindPostal(string pPostalCode)
		{
			EngineClient ZmanimAPI = CreateApiInstance();
			EngineParamPostal Params = new EngineParamPostal();
			EngineResultPostal Result = new EngineResultPostal();

			//Pass the client's time zone (ignoring DST). Optional, but if provided, is sometimes used to resolve ambiguous queries.
			double ClientTimeZone = TimeZone.CurrentTimeZone.GetUtcOffset(new DateTime()).TotalHours;

			Params.User = APIUSER;
			Params.Key = APIKEY;
			Params.Coding = "CS";
			Params.TimeZone = ClientTimeZone;
			Params.Query = pPostalCode;

			try
			{
				Result = ZmanimAPI.SearchPostal(Params);     // You may also use: SearchPostalAsync()
			}
			catch (System.ServiceModel.CommunicationException cex)
			{
				UnableToConnect(cex.Message);
			}
			catch (Exception ex)
			{
				SomethingWrong(ex.Message);
			}

			if (Result.ErrMsg != null)
			{
				Console.Write("Error: " + Result.ErrMsg);
				return null;
			}

			ZmanimAPI.Close();

			return Result.LocationID;
		}


		public string FindGps(double Latitude, double Longitude)
		{
			EngineClient ZmanimAPI = CreateApiInstance();

			EngineParamGps Params = new EngineParamGps();
			EngineCoordinates Coordinates = new EngineCoordinates();
			EngineResultGps Result = new EngineResultGps();

			Params.User = APIUSER;
			Params.Key = APIKEY;
			Params.Coding = "CS";
			Coordinates.Lat = Latitude;
			Coordinates.Lon = Longitude;
			Params.Point = Coordinates;

			try
			{
				Result = ZmanimAPI.SearchGps(Params);     // You may also use: SearchGpsAsync()
			}
			catch (System.ServiceModel.CommunicationException cex)
			{
				UnableToConnect(cex.Message);
			}
			catch (Exception ex)
			{
				SomethingWrong(ex.Message);
			}

			if (Result.ErrMsg != null)
			{
				Console.Write("Error: " + Result.ErrMsg);
				return null;
			}

			ZmanimAPI.Close();

			return Result.LocationID;
		}


		public void UnableToConnect(string ErrDetail)
		{
			Console.Write("\nError: Unable to reach MyZmanim. Confirm that you have a working internet connection. If problem persists contact MyZmanim .");
			Console.Write("\nDetails: " + ErrDetail);

		}


		public void SomethingWrong(string ErrDetail)
		{
			Console.Write("\nSomething unexpected went wrong. If problem persists contact MyZmanim .");
			Console.Write("\nDetails: " + ErrDetail);

		}




    }
}
