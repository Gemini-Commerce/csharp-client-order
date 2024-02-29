# # OrderCreateOrderRequest


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId**| **string** |   |
**Number**| **string** |   |
**Channel**| **string** |   | [optional]
**Market**| **string** |   |
**Locale**| **string** |   |
**Items**| [**List<OrderOrderDataItem>**](OrderOrderDataItem.md) |   |
**PaymentsInfo**| [**List<OrderDataPaymentInfo>**](OrderDataPaymentInfo.md) |   | [optional]
**ShipmentsInfo**| [**List<OrderDataShipmentInfo>**](OrderDataShipmentInfo.md) |   | [optional]
**Promotions**| [**List<OrderDataPromotionInfo>**](OrderDataPromotionInfo.md) |   | [optional]
**Payments**| [**List<CreateOrderRequestInitialPayment>**](CreateOrderRequestInitialPayment.md) |   | [optional]
**Currency**| **OrderCurrency** |  for more information please, see Model/OrderCurrency.php  |
**Subtotals**| [**Dictionary<string, OrderDataSubtotal>**](OrderDataSubtotal.md) |   |
**Totals**| [**Dictionary<string, OrderDataTotal>**](OrderDataTotal.md) |   |
**VatIncluded**| **bool** |   |
**BillingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   |
**ShippingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   |
**CustomerInfo**| [**OrderDataCustomerInfo**](OrderDataCustomerInfo.md) |   |
**CartGrn**| **string** |   | [optional]
**OnHold**| **bool** |   | [optional]
**Notes**| **string** |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

