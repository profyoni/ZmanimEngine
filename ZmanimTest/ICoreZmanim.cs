using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// posted to https://gist.github.com/profyoni/94cafa3a73bd794dfe2d08b5462cbd15
namespace ZmanimTest
{
    interface ICoreZmanim
    {
        void SetLocation(double longitude, double latitude);
        DateTime GetSunrise(DateTime date);
        DateTime GetSunset(DateTime date);
    }

    class SRSS
    {
        public DateTime sunrise, sunset;
    }

    class InterpolatedMockZmanim : ICoreZmanim
    {
        DateTime june = new DateTime(1, 6, 21);
        DateTime dec = new DateTime(1, 12, 21);
        DateTime juneSunrise = new DateTime(1, 6, 21, 4, 29, 0);
        DateTime juneSunset = new DateTime(1, 6, 21, 7, 31, 0);
        public DateTime GetSunrise(DateTime date)
        {
            var daysSinceJuneEq = (int)(date - june).TotalDays;
            return juneSunrise.AddMinutes(
                (date > june && date < dec ? 1 : -1) *daysSinceJuneEq);
        }

        public DateTime GetSunset(DateTime date)
        {
            var daysSinceJuneEq = (int)(date - june).TotalDays;
            return juneSunset.AddMinutes(
                (date > june && date < dec ? -1 : 1) * daysSinceJuneEq);
        }

        public (DateTime, DateTime) GetSunriseAndSunset(DateTime date)
        {
            var daysSinceJuneEq = (int)(date - june).TotalDays;

            return (
                juneSunrise.AddMinutes((date > june && date < dec ? 1 : -1) * daysSinceJuneEq),
                juneSunset.AddMinutes((date > june && date < dec ? -1 : 1) * daysSinceJuneEq)
            );
        }

        public void SetLocation(double longitude, double latitude)
        {
            throw new NotImplementedException();
        }
    }

    class ZmanimPdfGenerator
    {
        private ICoreZmanim coreZmanim;

        ZmanimPdfGenerator(ICoreZmanim coreZmanim)
        {
            this.coreZmanim = coreZmanim;
        }

        /**TODO*/
    }
}
