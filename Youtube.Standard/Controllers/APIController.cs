// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Youtube.Standard.Controllers
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
    using Newtonsoft.Json.Converters;
    using Youtube.Standard;
    using Youtube.Standard.Authentication;
    using Youtube.Standard.Exceptions;
    using Youtube.Standard.Http.Client;
    using Youtube.Standard.Http.Request;
    using Youtube.Standard.Http.Response;
    using Youtube.Standard.Utilities;

    /// <summary>
    /// APIController.
    /// </summary>
    public class APIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal APIController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// get list of 5 random forcasts.
        /// </summary>
        /// <param name="param">Optional parameter: default string parameter.</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic GetForcast(
                string param = "String.Empty")
        {
            Task<dynamic> t = this.GetForcastAsync(param);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// get list of 5 random forcasts.
        /// </summary>
        /// <param name="param">Optional parameter: default string parameter.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> GetForcastAsync(
                string param = "String.Empty",
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/WeatherForecast");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "param", (param != null) ? param : "String.Empty" },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new ProblemDetailsException("Test error message", context);
            }

            if (response.StatusCode == 404)
            {
                throw new ApiException("not found", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<dynamic>(response.Body);
        }
    }
}