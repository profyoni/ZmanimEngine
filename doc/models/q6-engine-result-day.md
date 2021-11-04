
# Q6 Engine Result Day

## Structure

`Q6EngineResultDay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Copyright` | `string` | Optional | - |
| `ErrMsg` | `string` | Optional | - |
| `Html` | `string` | Optional | - |
| `Lang` | `string` | Optional | - |
| `Place` | [`Models.Q6EngineLocationInfo`](/doc/models/q6-engine-location-info.md) | Optional | - |
| `Time` | [`Models.Q6EngineDateInfo`](/doc/models/q6-engine-date-info.md) | Optional | - |
| `Zman` | [`Models.Q6ZmnType`](/doc/models/q6-zmn-type.md) | Optional | - |

## Example (as XML)

```xml
<q6:Engine.ResultDay xmlns:q6="http://schemas.datacontract.org/2004/07/">
  <q6:Place xmlns:q6="http://schemas.datacontract.org/2004/07/" />
  <q6:Time xmlns:q6="http://schemas.datacontract.org/2004/07/" />
  <q6:Zman xmlns:q6="http://schemas.datacontract.org/2004/07/" />
</q6:Engine.ResultDay>
```

