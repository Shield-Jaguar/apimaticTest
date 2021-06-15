/*
 * YoutubeLib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

package localhost5001.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import java.time.LocalDateTime;
import localhost5001.DateTimeHelper;

/**
 * This is a model class for WeatherForecast type.
 */
public class WeatherForecast {
    private LocalDateTime date;
    private int temperatureC;
    private int temperatureF;
    private String summary;

    /**
     * Default constructor.
     */
    public WeatherForecast() {
    }

    /**
     * Initialization constructor.
     * @param  date  LocalDateTime value for date.
     * @param  temperatureC  int value for temperatureC.
     * @param  temperatureF  int value for temperatureF.
     * @param  summary  String value for summary.
     */
    public WeatherForecast(
            LocalDateTime date,
            int temperatureC,
            int temperatureF,
            String summary) {
        this.date = date;
        this.temperatureC = temperatureC;
        this.temperatureF = temperatureF;
        this.summary = summary;
    }

    /**
     * Getter for Date.
     * The time when forecast was taken
     * @return Returns the LocalDateTime
     */
    @JsonGetter("date")
    @JsonSerialize(using = DateTimeHelper.Rfc8601DateTimeSerializer.class)
    public LocalDateTime getDate() {
        return date;
    }

    /**
     * Setter for Date.
     * The time when forecast was taken
     * @param date Value for LocalDateTime
     */
    @JsonSetter("date")
    @JsonDeserialize(using = DateTimeHelper.Rfc8601DateTimeDeserializer.class)
    public void setDate(LocalDateTime date) {
        this.date = date;
    }

    /**
     * Getter for TemperatureC.
     * the value of temperature in Centigrade
     * @return Returns the int
     */
    @JsonGetter("temperatureC")
    public int getTemperatureC() {
        return temperatureC;
    }

    /**
     * Setter for TemperatureC.
     * the value of temperature in Centigrade
     * @param temperatureC Value for int
     */
    @JsonSetter("temperatureC")
    public void setTemperatureC(int temperatureC) {
        this.temperatureC = temperatureC;
    }

    /**
     * Getter for TemperatureF.
     * the value of temperature in Fahrenheit
     * @return Returns the int
     */
    @JsonGetter("temperatureF")
    public int getTemperatureF() {
        return temperatureF;
    }

    /**
     * Setter for TemperatureF.
     * the value of temperature in Fahrenheit
     * @param temperatureF Value for int
     */
    @JsonSetter("temperatureF")
    private void setTemperatureF(int temperatureF) {
        this.temperatureF = temperatureF;
    }

    /**
     * Getter for Summary.
     * @return Returns the String
     */
    @JsonGetter("summary")
    public String getSummary() {
        return summary;
    }

    /**
     * Setter for Summary.
     * @param summary Value for String
     */
    @JsonSetter("summary")
    private void setSummary(String summary) {
        this.summary = summary;
    }

    /**
     * Converts this WeatherForecast into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "WeatherForecast [" + "date=" + date + ", temperatureC=" + temperatureC
                + ", temperatureF=" + temperatureF + ", summary=" + summary + "]";
    }

    /**
     * Builds a new {@link WeatherForecast.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link WeatherForecast.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(date, temperatureC, temperatureF, summary);
        return builder;
    }

    /**
     * Class to build instances of {@link WeatherForecast}.
     */
    public static class Builder {
        private LocalDateTime date;
        private int temperatureC;
        private int temperatureF;
        private String summary;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  date  LocalDateTime value for date.
         * @param  temperatureC  int value for temperatureC.
         * @param  temperatureF  int value for temperatureF.
         * @param  summary  String value for summary.
         */
        public Builder(LocalDateTime date, int temperatureC, int temperatureF, String summary) {
            this.date = date;
            this.temperatureC = temperatureC;
            this.temperatureF = temperatureF;
            this.summary = summary;
        }

        /**
         * Setter for date.
         * @param  date  LocalDateTime value for date.
         * @return Builder
         */
        public Builder date(LocalDateTime date) {
            this.date = date;
            return this;
        }

        /**
         * Setter for temperatureC.
         * @param  temperatureC  int value for temperatureC.
         * @return Builder
         */
        public Builder temperatureC(int temperatureC) {
            this.temperatureC = temperatureC;
            return this;
        }

        /**
         * Setter for temperatureF.
         * @param  temperatureF  int value for temperatureF.
         * @return Builder
         */
        public Builder temperatureF(int temperatureF) {
            this.temperatureF = temperatureF;
            return this;
        }

        /**
         * Setter for summary.
         * @param  summary  String value for summary.
         * @return Builder
         */
        public Builder summary(String summary) {
            this.summary = summary;
            return this;
        }

        /**
         * Builds a new {@link WeatherForecast} object using the set fields.
         * @return {@link WeatherForecast}
         */
        public WeatherForecast build() {
            return new WeatherForecast(date, temperatureC, temperatureF, summary);
        }
    }
}