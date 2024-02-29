# # OrderOrderData


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt**| **DateTime** |   | [optional] [readonly]
**UpdatedAt**| **DateTime** |   | [optional] [readonly]
**Id**| **string** |   | [optional] [readonly]
**Grn**| **string** |   | [optional] [readonly]
**Number**| **string** |   | [optional]
**Status**| **string** |   | [optional] [readonly]
**Channel**| **string** |   | [optional]
**Market**| **string** |   | [optional]
**Locale**| **string** |   |
**AdditionalInfo**| **Object** |   | [optional]
**Documents**| [**List<OrderDataDocument>**](OrderDataDocument.md) |   | [optional]
**Items**| [**List<OrderOrderDataItem>**](OrderOrderDataItem.md) |   | [optional]
**Payments**| [**List<OrderPayment>**](OrderPayment.md) |   | [optional]
**Shipments**| [**List<OrderShipment>**](OrderShipment.md) |   | [optional]
**PaymentsInfo**| [**List<OrderDataPaymentInfo>**](OrderDataPaymentInfo.md) |   | [optional]
**ShipmentsInfo**| [**List<OrderDataShipmentInfo>**](OrderDataShipmentInfo.md) |   | [optional]
**Promotions**| [**List<OrderDataPromotionInfo>**](OrderDataPromotionInfo.md) |   | [optional]
**Currency**| **OrderCurrency** |  for more information please, see Model/OrderCurrency.php  | [optional]
**Subtotals**| [**Dictionary<string, OrderDataSubtotal>**](OrderDataSubtotal.md) |   | [optional]
**Totals**| [**Dictionary<string, OrderDataTotal>**](OrderDataTotal.md) |   | [optional]
**VatIncluded**| **bool** |   | [optional]
**BillingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   | [optional]
**ShippingAddress**| [**OrderPostalAddress**](OrderPostalAddress.md) |   | [optional]
**CustomerInfo**| [**OrderDataCustomerInfo**](OrderDataCustomerInfo.md) |   | [optional]
**CartGrn**| **string** |   | [optional]
**OnHold**| **bool** |   | [optional]
**HistoryEvents**| [**List<OrderDataHistory>**](OrderDataHistory.md) |   | [optional]
**Fulfillments**| [**List<OrderFulfillment>**](OrderFulfillment.md) |   | [optional] [readonly]
**Notes**| **string** |   | [optional]
**IsDeleted**| **bool** | this field is used to delete an order in \&quot;soft-delete mode\&quot;. This field must be used from get/list endpoint to exclude these orders.  | [optional]
**InsertedAt**| **DateTime** | this field is used to save the original created_at order date. The created_at field is used to filter data.  | [optional] [readonly]
**DeletedAt**| **DateTime** |   | [optional] [readonly]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

