# Getting Started with Youtube

## Getting Started

### Install the Package

The SDK is available as a NuGet that you can search for and install using the NuGet GUI. You can also use the following command on the Package Manager Console:

```csharp
Install-Package abc -Version 1.0.1
```

You can also view the NuGet at:
https://www.nuget.org/packages/abc/1.0.1

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package abc --version 1.0.1
```

### Initialize the API Client

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |

The API client can be initialized as follows:

```csharp
Youtube.Standard.YoutubeClient client = new Youtube.Standard.YoutubeClient();
```

Parameters for retries can be configured through the HttpClientConfiguration in the API Client:

| Parameters | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `NumberOfRetries` | `int` | Number of times the request is retried.<br>*Default*: `0` |
| `BackoffFactor` | `int` | Exponential backoff factor for duration between retry calls.<br>*Default*: `2` |
| `RetryInterval` | `double` | The time interval between the endpoint calls.<br>*Default*: `1` |
| `BackoffMax` | `TimeSpan` | The maximum back off time.<br>*Default*: `TimeSpan.FromSeconds(0)` |
| `StatusCodesToRetry` | `IList<int>` | List of Http status codes to invoke retry.<br>*Default*: `new List<int> { 408, 413, 429, 500, 502, 503, 504, 521, 522, 524, }` |
| `RequestMethodsToRetry` | `IList<HttpMethod>` | List of Http request methods to invoke retry.<br>*Default*: `new List<string> { "GET", "PUT", }.Select(val => new HttpMethod(val))` |

### API Errors

Here is the list of errors that the API might throw.

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | dfgdfgdfgdfgdsfg | [`ProblemDetailsException`](#problem-details) |

## Client Class Documentation

### YoutubeClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

#### Controllers

| Name | Description |
|  --- | --- |
| APIController | Gets APIController controller. |

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | `IHttpClientConfiguration` |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the YoutubeClient using the values provided for the builder. | `Builder` |

### YoutubeClient Builder Class

Class to build instances of YoutubeClient.

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `AccessTokenCredentials(IAccessTokenCredentials accessTokenCredentials)` | Gets the access token to use with OAuth 2 authentication. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Country(string country)` | Country code in ISO 3166-1-alpha-2 standard | `Builder` |
| `Scheme(Models.SchemeEnum scheme)` | Scheme value. | `Builder` |
| `Host(string host)` | Host value. | `Builder` |
| `Port(string port)` | Port value. | `Builder` |
| `Path(string path)` | Path value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `AccessTokenCredentials(IAccessTokenCredentials accessTokenCredentials)` | Gets the access token to use with OAuth 2 authentication. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Auth(AuthManager auth)` | Gets the AuthManager. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `AccessTokenCredentials(IAccessTokenCredentials accessTokenCredentials)` | Gets the access token to use with OAuth 2 authentication. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Country(string country)` | Country code in ISO 3166-1-alpha-2 standard | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Country(string country)` | Country code in ISO 3166-1-alpha-2 standard | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Country(string country)` | Country code in ISO 3166-1-alpha-2 standard | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `AccessTokenCredentials(IAccessTokenCredentials accessTokenCredentials)` | Gets the access token to use with OAuth 2 authentication. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |

## API Reference

### List of APIs

* [API](#api)

### API

#### Overview

##### Get instance

An instance of the `APIController` class can be accessed from the API Client.

```
APIController aPIController = client.APIController;
```

#### Get Forcast

get list of 5 random forcasts

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetForcastAsync(
    string param = "String.Empty")
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `param` | `string` | Query, Optional | default string parameter<br>**Default**: `"String.Empty"` |

##### Response Type

`Task<dynamic>`

##### Example Usage

```csharp
string param = "my value for error";

try
{
    dynamic result = await aPIController.GetForcastAsync(param);
}
catch (ApiException e){};
```

##### Example Response

```
[
  {
    "date": "2021-05-27T10:33:06.7728939+05:00",
    "temperatureC": -7,
    "temperatureF": 20,
    "summary": "Scorching"
  },
  {
    "date": "2021-05-28T10:33:06.7729006+05:00",
    "temperatureC": 6,
    "temperatureF": 42,
    "summary": "Bracing"
  }
]
```

##### Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Test error message | [`ProblemDetailsException`](#problem-details) |
| 404 | not found | `ApiException` |

## Model Reference

### Structures

* [Weather Forecast](#weather-forecast)
* [Weather Forcase Json Imported](#weather-forcase-json-imported)
* [Field Parameter Validator](#field-parameter-validator)

#### Weather Forecast

##### Class Name

`WeatherForecast`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Date` | `DateTime` | Required | The time when forecast was taken |
| `TemperatureC` | `int` | Required | the value of temperature in Centigrade |
| `TemperatureF` | `int` | Required, Constant | the value of temperature in Fahrenheit |
| `Summary` | `string` | Required, Constant | - |

##### Example (as JSON)

```json
{
  "date": "2021-05-27T10:33:06.7728939+05:00",
  "temperatureC": -7,
  "temperatureF": 20,
  "summary": "Scorching"
}
```

#### Weather Forcase Json Imported

##### Class Name

`WeatherForcaseJsonImported`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Date` | `string` | Required | - |
| `TemperatureC` | `int` | Required | - |
| `TemperatureF` | `int` | Required | - |
| `Summary` | `string` | Required | - |

##### Example (as JSON)

```json
{
  "date": "2021-05-27T10:33:06.7728939+05:00",
  "temperatureC": -7,
  "temperatureF": 20,
  "summary": "Scorching"
}
```

#### Field Parameter Validator

##### Class Name

`FieldParameterValidator`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Precision` | `double` | Required | **Constraints**: `> 0`, `< 600`, *Multiple Of*: `10`, *Total Digits*: `1000`, *Fraction Digits*: `2` |
| `MString` | `List<string>` | Optional, Constant | **Constraints**: *Minimum Items*: `5`, *Maximum Items*: `200`, *Minimum Length*: `3`, *Maximum Length*: `10`, *Pattern*: `/^[A-Z]+$/i` |
| `UnixFormatDateTime` | `DateTime` | Required | - |
| `MObject` | `object` | Required | - |
| `Int64` | `long` | Required | **Constraints**: `> 23`, `< 23`, *Multiple Of*: `3`, *Total Digits*: `23`, *Fraction Digits*: `23`, *Pattern*: `2` |

##### Example (as JSON)

```json
{
  "Precision": 229.08,
  "UnixFormatDateTime": 1480809600,
  "Object": {
    "key1": "val1",
    "key2": "val2"
  },
  "Int64": 10
}
```

### Enumerations

* [Test Enum](#test-enum)

#### Test Enum

This is the test description of enum00

##### Class Name

`TestEnum`

##### Fields

| Name | Description |
|  --- | --- |
| `FirstFiled` | Test description of first filed |
| `SecondField` | Test description of Second filed |
| `ThirdValue` |  |

### Exceptions

* [Problem Details](#problem-details)

#### Problem Details

##### Class Name

`ProblemDetailsException`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | - |
| `Title` | `string` | Required, Constant | - |
| `Status` | `int` | Required, Constant | - |
| `TraceId` | `string` | Required, Constant | - |

##### Example (as JSON)

```json
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "Bad Request",
  "status": 400,
  "traceId": "00-3dd0a6221d0ccd48ad5eb89a9cf3df71-91763b2e58fa4742-00"
}
```

## Utility Classes Documentation

### ApiHelper Class

HttpRequest stores necessary information about the http request.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpMethod | The HTTP verb to use for this request. | `HttpMethod` |
| QueryUrl | The query url for the http request. | `string` |
| QueryParameters | Query parameters collection for the current http request. | `Dictionary<string, object>` |
| Headers | Headers collection for the current http request. | `Dictionary<string, string>` |
| FormParameters | Form parameters for the current http request. | `List<KeyValuePair<string, object>>` |
| Body | Optional raw string to send as request body. | `object` |
| Username | Optional username for Basic Auth. | `string` |
| Password | Optional password for Basic Auth. | `string` |

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `DeepCloneObject<T>(T obj)` | Creates a deep clone of an object by serializing it into a json string and then deserializing back into an object. | `T` |
| `JsonSerialize(object obj, JsonConverter converter = null)` | JSON Serialization of a given object. | `string` |
| `JsonDeserialize<T>(string json, JsonConverter converter = null)` | JSON Deserialization of the given json string. | `T` |

### CustomDateTimeConverter Class

Extends from IsoDateTimeConverter to allow a custom DateTime format.

#### Constructors

| Name | Description |
|  --- | --- |
| `CustomDateTimeConverter(string format)` | Initializes a new instance of the <see cref="CustomDateTimeConverter"/> class. |

### ListDateTimeConverter Class

Extends from JsonConverter, allows the use of a custom converter.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| `Converter` | Gets or sets the JsonConverter. | `JsonConverter` |

#### Constructors

| Name | Description |
|  --- | --- |
| `ListDateTimeConverter()` | Initializes a new instance of the <see cref="ListDateTimeConverter"/> class. |
| `ListDateTimeConverter(Type converter)` | Initializes a new instance of the <see cref="ListDateTimeConverter"/> class. |
| `ListDateTimeConverter(Type converter, string format)` | Initializes a new instance of the <see cref="ListDateTimeConverter"/> class. |

### UnixDateTimeConverter Class

Extends from DateTimeConverterBase, uses unix DateTime format.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| DateTimeStyles | Gets or sets DateTimeStyles. | `DateTimeStyles` |

## Common Code Documentation

### HttpRequest Class

HttpResponse stores necessary information about the http response.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| StatusCode | Gets the HTTP Status code of the http response. | `int` |
| Headers | Gets the headers of the http response. | `Dictionary<string, string>` |
| RawBody | Gets the stream of the body. | `Stream` |

#### Constructors

| Name | Description |
|  --- | --- |
| `HttpRequest(HttpMethod method, string queryUrl)` | Constructor to initialize the http request object. |
| `HttpRequest(HttpMethod method, string queryUrl, Dictionary<string, string> headers, string username, string password, Dictionary<string, object> queryParameters = null)` | Constructor to initialize the http request with headers and optional Basic auth params. |
| `HttpRequest(HttpMethod method, string queryUrl, Dictionary<string, string> headers, object body, string username, string password, Dictionary<string, object> queryParameters = null)` | Constructor to initialize the http request with headers, body and optional Basic auth params. |
| `HttpRequest(HttpMethod method, string queryUrl, Dictionary<string, string> headers, List<KeyValuePair<string, Object>> formParameters, string username, string password, Dictionary<string, object> queryParameters = null)` | Constructor to initialize the http request with headers, form parameters and optional Basic auth params. |

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `AddHeaders(Dictionary<string, string> HeadersToAdd)` | Concatenate values from a Dictionary to this object. | `Dictionary<string, string>` |
| `AddQueryParameters(Dictionary<string, object> queryParamaters)` | Concatenate values from a Dictionary to query parameters dictionary. | `void` |

### HttpResponse Class

HttpResponse stores necessary information about the http response.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| StatusCode | Gets the HTTP Status code of the http response. | `int` |
| Headers | Gets the headers of the http response. | `Dictionary<string, string>` |
| RawBody | Gets the stream of the body. | `Stream` |

#### Constructors

| Name | Description |
|  --- | --- |
| `HttpResponse(int statusCode, Dictionary<string, string> headers, Stream rawBody)` | Initializes a new instance of the <see cref="HttpResponse"/> class. |

### HttpStringResponse Class

HttpStringResponse inherits from HttpResponse and has additional property of string body.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| StatusCode | Gets the HTTP Status code of the http response. | `int` |
| Headers | Gets the headers of the http response. | `Dictionary<string, string>` |
| Body | Gets the raw string body of the http response. | `string` |

#### Constructors

| Name | Description |
|  --- | --- |
| `HttpStringResponse(int statusCode, Dictionary<string, string> headers, Stream rawBody, string body) : base(statusCode, headers, rawBody)` | Initializes a new instance of the <see cref="HttpStringResponse"/> class. |

### HttpContext Class

Represents the contextual information of HTTP request and response.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| Request | Gets the http request in the current context. | `HttpRequest` |
| Response | Gets the http response in the current context. | `HttpResponse` |

#### Constructors

| Name | Description |
|  --- | --- |
| `HttpContext(HttpRequest request, HttpResponse response)` | Initializes a new instance of the <see cref="HttpContext"/> class. |

### HttpClientConfiguration Class

HttpClientConfiguration represents the current state of the Http Client.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| Timeout | Http client timeout. | `TimeSpan` |
| NumberOfRetries | Number of times the request is retried. | `int` |
| BackoffFactor | Exponential backoff factor for duration between retry calls. | `int` |
| RetryInterval | The time interval between the endpoint calls. | `double` |
| BackoffMax | The maximum back off time. | `TimeSpan` |
| StatusCodesToRetry | List of Http status codes to invoke retry. | `IList<int>` |
| RequestMethodsToRetry | List of Http request methods to invoke retry. | `IList<HttpMethod>` |

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `ToBuilder()` | Creates an object of the HttpClientConfiguration using the values provided for the builder. | `Builder` |

### HttpClientConfiguration Builder Class

Class to build instances of HttpClientConfiguration.

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `NumberOfRetries(int numberOfRetries)` | Number of times the request is retried. | `Builder` |
| `BackoffFactor(int backoffFactor)` | Exponential backoff factor for duration between retry calls. | `Builder` |
| `RetryInterval(double retryInterval)` | The time interval between the endpoint calls. | `Builder` |
| `BackoffMax(TimeSpan backoffMax)` | The maximum back off time. | `Builder` |
| `StatusCodesToRetry(IList<int> statusCodesToRetry)` | List of Http status codes to invoke retry. | `Builder` |
| `RequestMethodsToRetry(IList<HttpMethod> requestMethodsToRetry)` | List of Http request methods to invoke retry. | `Builder` |
| `Build()` | Builds a new HttpClientConfiguration object using the set fields. | `HttpClientConfiguration` |

### IAuthManager Class

IAuthManager adds the authenticaion layer to the http calls.

#### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `Apply(HttpRequest httpRequest)` | Add authentication information to the HTTP Request. | `HttpRequest` |
| `ApplyAsync(HttpRequest httpRequest)` | Asynchronously add authentication information to the HTTP Request. | `Task<HttpRequest>` |

### ApiException Class

This is the base class for all exceptions that represent an error response from the server.

#### Properties

| Name | Description | Type |
|  --- | --- | --- |
| ResponseCode | Gets the HTTP response code from the API request. | `int` |
| HttpContext | Gets or sets the HttpContext for the request and response. | `HttpContext` |

#### Constructors

| Name | Description |
|  --- | --- |
| `ApiException(string reason, HttpContext context)` | Initializes a new instance of the <see cref="ApiException"/> class. |

