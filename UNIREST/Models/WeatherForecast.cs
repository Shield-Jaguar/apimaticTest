// <copyright file="WeatherForecast.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace UNIREST.Models
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
    using UNIREST;
    using UNIREST.Utilities;

    /// <summary>
    /// WeatherForecast.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecast"/> class.
        /// </summary>
        public WeatherForecast()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecast"/> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="temperatureC">temperatureC.</param>
        /// <param name="temperatureF">temperatureF.</param>
        /// <param name="summary">summary.</param>
        public WeatherForecast(
            DateTime date,
            int temperatureC,
            int temperatureF,
            string summary)
        {
            this.Date = date;
            this.TemperatureC = temperatureC;
            this.TemperatureF = temperatureF;
            this.Summary = summary;
        }

        /// <summary>
        /// The time when forecast was taken
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// the value of temperature in Centigrade
        /// </summary>
        [JsonProperty("temperatureC")]
        public int TemperatureC { get; set; }

        /// <summary>
        /// the value of temperature in Fahrenheit
        /// </summary>
        [JsonProperty("temperatureF")]
        public int TemperatureF { get; set; }

        /// <summary>
        /// Gets or sets Summary.
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WeatherForecast : ({string.Join(", ", toStringOutput)})";
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

            return obj is WeatherForecast other &&
                this.Date.Equals(other.Date) &&
                this.TemperatureC.Equals(other.TemperatureC) &&
                this.TemperatureF.Equals(other.TemperatureF) &&
                ((this.Summary == null && other.Summary == null) || (this.Summary?.Equals(other.Summary) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 628058490;
            hashCode += this.Date.GetHashCode();
            hashCode += this.TemperatureC.GetHashCode();
            hashCode += this.TemperatureF.GetHashCode();

            if (this.Summary != null)
            {
               hashCode += this.Summary.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Date = {this.Date}");
            toStringOutput.Add($"this.TemperatureC = {this.TemperatureC}");
            toStringOutput.Add($"this.TemperatureF = {this.TemperatureF}");
            toStringOutput.Add($"this.Summary = {(this.Summary == null ? "null" : this.Summary == string.Empty ? "" : this.Summary)}");
        }
    }
}