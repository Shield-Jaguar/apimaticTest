# Getting Started with Youtube

## Getting Started

### Building

You must have Python `2 >=2.7.9` or Python `3 >=3.4` installed on your system to install and run this SDK. This SDK package depends on other Python packages like nose, jsonpickle etc. These dependencies are defined in the `requirements.txt` file that comes with the SDK.To resolve these dependencies, you can use the PIP Dependency manager. Install it by following steps at [https://pip.pypa.io/en/stable/installing/](https://pip.pypa.io/en/stable/installing/).

Python and PIP executables should be defined in your PATH. Open command prompt and type `pip --version`. This should display the version of the PIP Dependency Manager installed if your installation was successful and the paths are properly defined.

* Using command line, navigate to the directory containing the generated files (including `requirements.txt`) for the SDK.
* Run the command `pip install -r requirements.txt`. This should install all the required dependencies.

![Building SDK - Step 1](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&step=installDependencies)

### Installation

The following section explains how to use the youtube library in a new project.

#### 1. Open Project in an IDE

Open up a Python IDE like PyCharm. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.

![Open project in PyCharm - Step 1](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&step=pyCharm)

Click on `Open` in PyCharm to browse to your generated SDK directory and then click `OK`.

![Open project in PyCharm - Step 2](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&step=openProject0)

The project files will be displayed in the side bar as follows:

![Open project in PyCharm - Step 3](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&projectName=youtube&step=openProject1)

#### 2. Add a new Test Project

Create a new directory by right clicking on the solution name as shown below:

![Add a new project in PyCharm - Step 1](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&projectName=youtube&step=createDirectory)

Name the directory as "test".

![Add a new project in PyCharm - Step 2](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&step=nameDirectory)

Add a python file to this project.

![Add a new project in PyCharm - Step 3](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&projectName=youtube&step=createFile)

Name it "testSDK".

![Add a new project in PyCharm - Step 4](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&projectName=youtube&step=nameFile)

In your python file you will be required to import the generated python library using the following code lines

```python
from youtube.youtube_client import YoutubeClient
```

![Add a new project in PyCharm - Step 5](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&projectName=youtube&libraryName=youtube.youtube_client&className=YoutubeClient&step=projectFiles)

After this you can write code to instantiate an API client object, get a controller object and  make API calls. Sample code is given in the subsequent sections.

#### 3. Run the Test Project

To run the file within your test project, right click on your Python file inside your Test project and click on `Run`

![Run Test Project - Step 1](https://apidocs.io/illustration/python?workspaceFolder=Youtube-Python&projectName=youtube&libraryName=youtube.youtube_client&className=YoutubeClient&step=runProject)

### Initialize the API Client

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `timeout` | `float` | The value to use for connection timeout. <br> **Default: 60** |
| `max_retries` | `int` | The number of times to retry an endpoint call if it fails. <br> **Default: 0** |
| `backoff_factor` | `float` | A backoff factor to apply between attempts after the second try. <br> **Default: 2** |
| `retry_statuses` | `Array of int` | The http statuses on which retry is to be done. <br> **Default: [408, 413, 429, 500, 502, 503, 504, 521, 522, 524]** |
| `retry_methods` | `Array of string` | The http methods on which retry is to be done. <br> **Default: ['GET', 'PUT']** |

The API client can be initialized as follows:

```python
from youtube.youtube_client import YoutubeClient
from youtube.configuration import Environment

client = YoutubeClient(
    environment = ,)
```

### API Errors

Here is the list of errors that the API might throw.

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | dfgdfgdfgdfgdsfg | [`ProblemDetailsException`](#problem-details) |

## Client Class Documentation

### Youtube Client

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| api | Gets APIController |

## API Reference

### List of APIs

* [API](#api)

### API

#### Overview

##### Get instance

An instance of the `APIController` class can be accessed from the API Client.

```
client_controller = client.client
```

#### Get Forcast

get list of 5 random forcasts

:information_source: **Note** This endpoint does not require authentication.

```python
def get_forcast(self,
               param='String.Empty')
```

##### Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `param` | `string` | Query, Optional | default string parameter<br>**Default**: `'String.Empty'` |

##### Response Type

`mixed`

##### Example Usage

```python
param = 'my value for error'
result = client_controller.get_forcast(param)
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
| 404 | not found | `APIException` |

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
| `date` | `datetime` | Required | The time when forecast was taken |
| `temperature_c` | `int` | Required | the value of temperature in Centigrade |
| `temperature_f` | `int` | Required, Constant | the value of temperature in Fahrenheit |
| `summary` | `string` | Required, Constant | - |

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
| `date` | `string` | Required | - |
| `temperature_c` | `int` | Required | - |
| `temperature_f` | `int` | Required | - |
| `summary` | `string` | Required | - |

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
| `precision` | `float` | Required | **Constraints**: `> 0`, `< 600`, *Multiple Of*: `10`, *Total Digits*: `1000`, *Fraction Digits*: `2` |
| `string` | `List of string` | Optional, Constant | **Constraints**: *Minimum Items*: `5`, *Maximum Items*: `200`, *Minimum Length*: `3`, *Maximum Length*: `10`, *Pattern*: `/^[A-Z]+$/i` |
| `unix_format_date_time` | `datetime` | Required | - |
| `object` | `object` | Required | - |
| `int_64` | `long\|int` | Required | **Constraints**: `> 23`, `< 23`, *Multiple Of*: `3`, *Total Digits*: `23`, *Fraction Digits*: `23`, *Pattern*: `2` |

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
| `FIRSTFILED` | Test description of first filed |
| `SECONDFIELD` | Test description of Second filed |
| `THIRD_VALUE` |  |

### Exceptions

* [Problem Details](#problem-details)

#### Problem Details

##### Class Name

`ProblemDetailsException`

##### Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mtype` | `string` | Required, Constant | - |
| `title` | `string` | Required, Constant | - |
| `status` | `int` | Required, Constant | - |
| `trace_id` | `string` | Required, Constant | - |

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

### ApiHelper

A utility class for processing API Calls. Also contains classes for supporting standard datetime formats.

#### Methods

| Name | Description |
|  --- | --- |
| json_deserialize | Deserializes a JSON string to a Python dictionary. |

#### Classes

| Name | Description |
|  --- | --- |
| HttpDateTime | A wrapper for datetime to support HTTP date format. |
| UnixDateTime | A wrapper for datetime to support Unix date format. |
| RFC3339DateTime | A wrapper for datetime to support RFC3339 format. |

## Common Code Documentation

### HttpResponse

Http response received.

#### Parameters

| Name | Type | Description |
|  --- | --- | --- |
| status_code | int | The status code returned by the server. |
| reason_phrase | str | The reason phrase returned by the server. |
| headers | dict | Response headers. |
| text | str | Response body. |
| request | HttpRequest | The request that resulted in this response. |

### HttpRequest

Represents a single Http Request.

#### Parameters

| Name | Type | Tag | Description |
|  --- | --- | --- | --- |
| http_method | HttpMethodEnum |  | The HTTP method of the request. |
| query_url | str |  | The endpoint URL for the API request. |
| headers | dict | optional | Request headers. |
| query_parameters | dict | optional | Query parameters to add in the URL. |
| parameters | dict &#124; str | optional | Request body, either as a serialized string or else a list of parameters to form encode. |
| files | dict | optional | Files to be sent with the request. |

