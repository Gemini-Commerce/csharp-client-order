# # OrderShipment


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt**| **DateTime** |   | [optional] [readonly]
**UpdatedAt**| **DateTime** |   | [optional] [readonly]
**OrderId**| **string** |   | [optional]
**Id**| **string** |   | [optional]
**Status**| **string** |   | [optional]
**Items**| [**List<OrderShipmentItem>**](OrderShipmentItem.md) |   | [optional]
**Address**| [**OrderPostalAddress**](OrderPostalAddress.md) |   | [optional]
**FromAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   | [optional]
**ReturnAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   | [optional]
**Tracking**| [**List<ShipmentTracking>**](ShipmentTracking.md) |   | [optional]
**ReturnTracking**| [**List<ShipmentTracking>**](ShipmentTracking.md) |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

