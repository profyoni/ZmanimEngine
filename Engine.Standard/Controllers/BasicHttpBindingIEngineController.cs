// <copyright file="BasicHttpBindingIEngineController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Engine.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Engine.Standard;
    using Engine.Standard.Authentication;
    using Engine.Standard.Http.Client;
    using Engine.Standard.Http.Request;
    using Engine.Standard.Http.Response;
    using Engine.Standard.Utilities;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// BasicHttpBindingIEngineController.
    /// </summary>
    public class BasicHttpBindingIEngineController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicHttpBindingIEngineController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal BasicHttpBindingIEngineController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// GetDay EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.IEngineGetDayOutputMessage response from the API call.</returns>
        public Models.IEngineGetDayOutputMessage GetDay(
                Models.IEngineGetDayInputMessage body)
        {
            Task<Models.IEngineGetDayOutputMessage> t = this.GetDayAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetDay EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IEngineGetDayOutputMessage response from the API call.</returns>
        public async Task<Models.IEngineGetDayOutputMessage> GetDayAsync(
                Models.IEngineGetDayInputMessage body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/GetDay");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/xml" },
                { "content-type", "application/xml; charset=utf-8" },
            };

            // append body params.
            var bodyText = XmlUtility.ToXml(body, "IEngine_GetDay_InputMessage");

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return XmlUtility.FromXml<Models.IEngineGetDayOutputMessage>(response.Body, "IEngine_GetDay_OutputMessage");
        }

        /// <summary>
        /// SearchGps EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.IEngineSearchGpsOutputMessage response from the API call.</returns>
        public Models.IEngineSearchGpsOutputMessage SearchGps(
                Models.IEngineSearchGpsInputMessage body)
        {
            Task<Models.IEngineSearchGpsOutputMessage> t = this.SearchGpsAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// SearchGps EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IEngineSearchGpsOutputMessage response from the API call.</returns>
        public async Task<Models.IEngineSearchGpsOutputMessage> SearchGpsAsync(
                Models.IEngineSearchGpsInputMessage body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/SearchGps");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/xml" },
                { "content-type", "application/xml; charset=utf-8" },
            };

            // append body params.
            var bodyText = XmlUtility.ToXml(body, "IEngine_SearchGps_InputMessage");

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return XmlUtility.FromXml<Models.IEngineSearchGpsOutputMessage>(response.Body, "IEngine_SearchGps_OutputMessage");
        }

        /// <summary>
        /// SearchPostal EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.IEngineSearchPostalOutputMessage response from the API call.</returns>
        public Models.IEngineSearchPostalOutputMessage SearchPostal(
                Models.IEngineSearchPostalInputMessage body)
        {
            Task<Models.IEngineSearchPostalOutputMessage> t = this.SearchPostalAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// SearchPostal EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IEngineSearchPostalOutputMessage response from the API call.</returns>
        public async Task<Models.IEngineSearchPostalOutputMessage> SearchPostalAsync(
                Models.IEngineSearchPostalInputMessage body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/SearchPostal");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/xml" },
                { "content-type", "application/xml; charset=utf-8" },
            };

            // append body params.
            var bodyText = XmlUtility.ToXml(body, "IEngine_SearchPostal_InputMessage");

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return XmlUtility.FromXml<Models.IEngineSearchPostalOutputMessage>(response.Body, "IEngine_SearchPostal_OutputMessage");
        }
    }
}