// <copyright file="ProblemDetailsException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Youtube.Standard.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Youtube.Standard;
    using Youtube.Standard.Http.Client;
    using Youtube.Standard.Models;
    using Youtube.Standard.Utilities;

    /// <summary>
    /// ProblemDetailsException.
    /// </summary>
    public class ProblemDetailsException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemDetailsException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ProblemDetailsException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets TraceId.
        /// </summary>
        [JsonProperty("traceId")]
        public string TraceId { get; set; }
    }
}