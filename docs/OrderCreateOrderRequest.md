# # OrderCreateOrderRequest


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId**| **string** |   | [optional]
**Number**| **string** |   | [optional]
**Channel**| **string** |   | [optional]
**Market**| **string** |   | [optional]
**Locale**| **string** |   | [optional]
**Items**| [**List<OrderOrderDataItem>**](OrderOrderDataItem.md) |   | [optional]
**PaymentsInfo**| [**List<OrderDataPaymentInfo>**](OrderDataPaymentInfo.md) |   | [optional]
**ShipmentsInfo**| [**List<OrderDataShipmentInfo>**](OrderDataShipmentInfo.md) |   | [optional]
**Promotions**| [**List<OrderDataPromotionInfo>**](OrderDataPromotionInfo.md) |   | [optional]
**Payments**| [**List<CreateOrderRequestInitialPayment>**](CreateOrderRequestInitialPayment.md) |   | [optional]
**Currency**| **OrderCurrency** |  for more information please, see Model/OrderCurrency.php  | [optional]
**Subtotals**| [**Dictionary<string, OrderDataSubtotal>**](OrderDataSubtotal.md) |   | [optional]
**Totals**| [**Dictionary<string, OrderDataTotal>**](OrderDataTotal.md) |   | [optional]
**VatIncluded**| **bool** |   | [optional]
**BillingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   | [optional]
**ShippingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   | [optional]
**CustomerInfo**| [**OrderDataCustomerInfo**](OrderDataCustomerInfo.md) |   | [optional]
**CartGrn**| **string** |   | [optional]
**OnHold**| **bool** |   | [optional]
**Notes**| **string** |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

