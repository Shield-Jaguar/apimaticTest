// <copyright file="WeatherForcaseJsonImported.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Youtube.Standard.Models
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
    using Youtube.Standard.Utilities;

    /// <summary>
    /// WeatherForcaseJsonImported.
    /// </summary>
    public class WeatherForcaseJsonImported
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForcaseJsonImported"/> class.
        /// </summary>
        public WeatherForcaseJsonImported()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForcaseJsonImported"/> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="temperatureC">temperatureC.</param>
        /// <param name="temperatureF">temperatureF.</param>
        /// <param name="summary">summary.</param>
        public WeatherForcaseJsonImported(
            string date,
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
        /// Gets or sets Date.
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets TemperatureC.
        /// </summary>
        [JsonProperty("temperatureC")]
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets or sets TemperatureF.
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

            return $"WeatherForcaseJsonImported : ({string.Join(", ", toStringOutput)})";
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

            return obj is WeatherForcaseJsonImported other &&
                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true)) &&
                this.TemperatureC.Equals(other.TemperatureC) &&
                this.TemperatureF.Equals(other.TemperatureF) &&
                ((this.Summary == null && other.Summary == null) || (this.Summary?.Equals(other.Summary) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 765866798;

            if (this.Date != null)
            {
               hashCode += this.Date.GetHashCode();
            }

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
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date == string.Empty ? "" : this.Date)}");
            toStringOutput.Add($"this.TemperatureC = {this.TemperatureC}");
            toStringOutput.Add($"this.TemperatureF = {this.TemperatureF}");
            toStringOutput.Add($"this.Summary = {(this.Summary == null ? "null" : this.Summary == string.Empty ? "" : this.Summary)}");
        }
    }
}