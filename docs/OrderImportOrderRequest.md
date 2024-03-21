# # OrderImportOrderRequest


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId**| **string** |   |
**CreatedAt**| **DateTime** |   | [optional]
**Number**| **string** |   |
**Channel**| **string** |   | [optional]
**Market**| **string** |   |
**Locale**| **string** |   |
**CustomerInfo**| [**OrderDataCustomerInfo**](OrderDataCustomerInfo.md) |   |
**ShippingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   |
**BillingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   |
**Payments**| [**List<ImportOrderRequestImportedPayment>**](ImportOrderRequestImportedPayment.md) |   |
**PaymentsInfo**| [**List<OrderDataPaymentInfo>**](OrderDataPaymentInfo.md) |   |
**ShipmentsInfo**| [**List<OrderDataShipmentInfo>**](OrderDataShipmentInfo.md) |   |
**Items**| [**List<OrderOrderDataItem>**](OrderOrderDataItem.md) |   |
**Subtotals**| [**Dictionary<string, OrderDataSubtotal>**](OrderDataSubtotal.md) |   |
**Totals**| [**Dictionary<string, OrderDataTotal>**](OrderDataTotal.md) |   |
**Status**| **string** |   |
**Currency**| **OrderCurrency** |  for more information please, see Model/OrderCurrency.php  |
**VatIncluded**| **bool** |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

