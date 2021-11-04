# Basic Http Binding I Engine

```csharp
BasicHttpBindingIEngineController basicHttpBindingIEngineController = client.BasicHttpBindingIEngineController;
```

## Class Name

`BasicHttpBindingIEngineController`

## Methods

* [Get Day](/doc/controllers/basic-http-binding-i-engine.md#get-day)
* [Search Gps](/doc/controllers/basic-http-binding-i-engine.md#search-gps)
* [Search Postal](/doc/controllers/basic-http-binding-i-engine.md#search-postal)


# Get Day

```csharp
GetDayAsync(
    Models.IEngineGetDayInputMessage body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.IEngineGetDayInputMessage`](/doc/models/i-engine-get-day-input-message.md) | Body, Required | - |

## Response Type

[`Task<Models.IEngineGetDayOutputMessage>`](/doc/models/i-engine-get-day-output-message.md)

## Example Usage

```csharp
var body = new IEngineGetDayInputMessage();
body.GetDay = new TnsGetDay();

try
{
    IEngineGetDayOutputMessage result = await basicHttpBindingIEngineController.GetDayAsync(body);
}
catch (ApiException e){};
```


# Search Gps

```csharp
SearchGpsAsync(
    Models.IEngineSearchGpsInputMessage body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.IEngineSearchGpsInputMessage`](/doc/models/i-engine-search-gps-input-message.md) | Body, Required | - |

## Response Type

[`Task<Models.IEngineSearchGpsOutputMessage>`](/doc/models/i-engine-search-gps-output-message.md)

## Example Usage

```csharp
var body = new IEngineSearchGpsInputMessage();
body.SearchGps = new TnsSearchGps();

try
{
    IEngineSearchGpsOutputMessage result = await basicHttpBindingIEngineController.SearchGpsAsync(body);
}
catch (ApiException e){};
```


# Search Postal

```csharp
SearchPostalAsync(
    Models.IEngineSearchPostalInputMessage body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Models.IEngineSearchPostalInputMessage`](/doc/models/i-engine-search-postal-input-message.md) | Body, Required | - |

## Response Type

[`Task<Models.IEngineSearchPostalOutputMessage>`](/doc/models/i-engine-search-postal-output-message.md)

## Example Usage

```csharp
var body = new IEngineSearchPostalInputMessage();
body.SearchPostal = new TnsSearchPostal();

try
{
    IEngineSearchPostalOutputMessage result = await basicHttpBindingIEngineController.SearchPostalAsync(body);
}
catch (ApiException e){};
```

