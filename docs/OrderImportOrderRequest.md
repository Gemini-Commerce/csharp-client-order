# # OrderImportOrderRequest


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId**| **string** |   | [optional]
**CreatedAt**| **DateTime** |   | [optional]
**Number**| **string** |   | [optional]
**Channel**| **string** |   | [optional]
**Market**| **string** |   | [optional]
**Locale**| **string** |   | [optional]
**CustomerInfo**| [**OrderDataCustomerInfo**](OrderDataCustomerInfo.md) |   | [optional]
**ShippingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   | [optional]
**BillingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   | [optional]
**Payments**| [**List<ImportOrderRequestImportedPayment>**](ImportOrderRequestImportedPayment.md) |   | [optional]
**PaymentsInfo**| [**List<OrderDataPaymentInfo>**](OrderDataPaymentInfo.md) |   | [optional]
**ShipmentsInfo**| [**List<OrderDataShipmentInfo>**](OrderDataShipmentInfo.md) |   | [optional]
**Items**| [**List<OrderOrderDataItem>**](OrderOrderDataItem.md) |   | [optional]
**Subtotals**| [**Dictionary<string, OrderDataSubtotal>**](OrderDataSubtotal.md) |   | [optional]
**Totals**| [**Dictionary<string, OrderDataTotal>**](OrderDataTotal.md) |   | [optional]
**Status**| **string** |   | [optional]
**Currency**| **OrderCurrency** |  for more information please, see Model/OrderCurrency.php  | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

