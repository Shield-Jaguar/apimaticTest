// <copyright file="FieldParameterValidator.cs" company="APIMatic">
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
    /// FieldParameterValidator.
    /// </summary>
    public class FieldParameterValidator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldParameterValidator"/> class.
        /// </summary>
        public FieldParameterValidator()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldParameterValidator"/> class.
        /// </summary>
        /// <param name="precision">Precision.</param>
        /// <param name="unixFormatDateTime">UnixFormatDateTime.</param>
        /// <param name="mObject">Object.</param>
        /// <param name="int64">Int64.</param>
        /// <param name="mString">String.</param>
        public FieldParameterValidator(
            double precision,
            DateTime unixFormatDateTime,
            object mObject,
            long int64,
            List<string> mString = null)
        {
            this.Precision = precision;
            this.MString = mString;
            this.UnixFormatDateTime = unixFormatDateTime;
            this.MObject = mObject;
            this.Int64 = int64;
        }

        /// <summary>
        /// Gets or sets Precision.
        /// </summary>
        [JsonProperty("Precision")]
        public double Precision { get; set; }

        /// <summary>
        /// Gets or sets MString.
        /// </summary>
        [JsonProperty("String", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MString { get; set; }

        /// <summary>
        /// Gets or sets UnixFormatDateTime.
        /// </summary>
        [JsonConverter(typeof(UNIREST.Utilities.UnixDateTimeConverter))]
        [JsonProperty("UnixFormatDateTime")]
        public DateTime UnixFormatDateTime { get; set; }

        /// <summary>
        /// Gets or sets MObject.
        /// </summary>
        [JsonProperty("Object")]
        public object MObject { get; set; }

        /// <summary>
        /// Gets or sets Int64.
        /// </summary>
        [JsonProperty("Int64")]
        public long Int64 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FieldParameterValidator : ({string.Join(", ", toStringOutput)})";
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

            return obj is FieldParameterValidator other &&
                this.Precision.Equals(other.Precision) &&
                ((this.MString == null && other.MString == null) || (this.MString?.Equals(other.MString) == true)) &&
                this.UnixFormatDateTime.Equals(other.UnixFormatDateTime) &&
                ((this.MObject == null && other.MObject == null) || (this.MObject?.Equals(other.MObject) == true)) &&
                this.Int64.Equals(other.Int64);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -900235384;
            hashCode += this.Precision.GetHashCode();

            if (this.MString != null)
            {
               hashCode += this.MString.GetHashCode();
            }

            hashCode += this.UnixFormatDateTime.GetHashCode();

            if (this.MObject != null)
            {
               hashCode += this.MObject.GetHashCode();
            }

            hashCode += this.Int64.GetHashCode();

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Precision = {this.Precision}");
            toStringOutput.Add($"this.MString = {(this.MString == null ? "null" : $"[{string.Join(", ", this.MString)} ]")}");
            toStringOutput.Add($"this.UnixFormatDateTime = {this.UnixFormatDateTime}");
            toStringOutput.Add($"MObject = {(this.MObject == null ? "null" : this.MObject.ToString())}");
            toStringOutput.Add($"this.Int64 = {this.Int64}");
        }
    }
}