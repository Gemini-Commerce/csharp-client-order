# order.Api.OrderApi

All URIs are relative to *https://dom.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApproveOrder**](OrderApi.md#approveorder) | **POST** /order.Order/ApproveOrder | Approve Order |
| [**AssignShipment**](OrderApi.md#assignshipment) | **POST** /order.Order/AssignShipment | Assign Shipment |
| [**CalculateRefund**](OrderApi.md#calculaterefund) | **POST** /order.Order/CalculateRefund | Calculate Refund |
| [**CancelFulfillment**](OrderApi.md#cancelfulfillment) | **POST** /order.Order/CancelFulfillment | Cancel Fulfillment |
| [**CancelOrder**](OrderApi.md#cancelorder) | **POST** /order.Order/CancelOrder | Cancel Order |
| [**CancelShipment**](OrderApi.md#cancelshipment) | **POST** /order.Order/CancelShipment | Cancel Shipment |
| [**CompleteShipmentPacking**](OrderApi.md#completeshipmentpacking) | **POST** /order.Order/CompleteShipmentPacking | Complete Shipment Packing |
| [**CreateFulfillment**](OrderApi.md#createfulfillment) | **POST** /order.Order/CreateFulfillment | Create Fulfillment |
| [**CreateOrder**](OrderApi.md#createorder) | **POST** /order.Order/CreateOrder | Create Order |
| [**CreateOrderHistory**](OrderApi.md#createorderhistory) | **POST** /order.Order/CreateHistory | Create Order History |
| [**CreatePayment**](OrderApi.md#createpayment) | **POST** /order.Order/CreatePayment | Create Payment |
| [**CreatePaymentTransaction**](OrderApi.md#createpaymenttransaction) | **POST** /order.Order/CreatePaymentTransaction | Create Payment Transaction |
| [**CreateRefund**](OrderApi.md#createrefund) | **POST** /order.Order/CreateRefund | Create Refund |
| [**CreateRefundTransaction**](OrderApi.md#createrefundtransaction) | **POST** /order.Order/CreateRefundTransaction | Create Refund Transaction |
| [**CreateShipment**](OrderApi.md#createshipment) | **POST** /order.Order/CreateShipment | Create Shipment |
| [**DeleteOrder**](OrderApi.md#deleteorder) | **POST** /order.Order/DeleteOrder | Delete Order |
| [**GetFulfillment**](OrderApi.md#getfulfillment) | **POST** /order.Order/GetFulfillment | Get Fulfillment |
| [**GetOrder**](OrderApi.md#getorder) | **POST** /order.Order/GetOrder | Get Order |
| [**GetOrderByCartId**](OrderApi.md#getorderbycartid) | **POST** /order.Order/GetOrderByCartId | Get Order by Cart ID |
| [**GetOrderByOrderNumber**](OrderApi.md#getorderbyordernumber) | **POST** /order.Order/GetOrderByOrderNumber | Get Order by Order Number |
| [**GetPayment**](OrderApi.md#getpayment) | **POST** /order.Order/GetPayment | Get Payment |
| [**GetShipment**](OrderApi.md#getshipment) | **POST** /order.Order/GetShipment | Get Shipment |
| [**GetTransaction**](OrderApi.md#gettransaction) | **POST** /order.Order/GetTransaction | Get Transaction |
| [**HoldOrder**](OrderApi.md#holdorder) | **POST** /order.Order/HoldOrder | Hold Order |
| [**ImportOrder**](OrderApi.md#importorder) | **POST** /order.Order/ImportOrder | Import Order |
| [**ListFulfillments**](OrderApi.md#listfulfillments) | **POST** /order.Order/ListFulfillments | List Fulfillments |
| [**ListOrders**](OrderApi.md#listorders) | **POST** /order.Order/ListOrders | List Orders |
| [**ListOrdersByCustomer**](OrderApi.md#listordersbycustomer) | **POST** /order.Order/ListOrdersByCustomer | List Orders by Customer |
| [**ListOrdersByNumbers**](OrderApi.md#listordersbynumbers) | **POST** /order.Order/ListOrdersByNumbers | List Orders by Numbers |
| [**ListShipments**](OrderApi.md#listshipments) | **POST** /order.Order/ListShipments | List Shipments |
| [**OrderAddDocument**](OrderApi.md#orderadddocument) | **POST** /order.Order/AddDocument | Documents |
| [**OrderRemoveDocumentByCode**](OrderApi.md#orderremovedocumentbycode) | **POST** /order.Order/RemoveDocumentByCode |  |
| [**PrintOrdersLabels**](OrderApi.md#printorderslabels) | **POST** /order.Order/PrintOrdersLabels | Print Orders Labels |
| [**QuashFulfillment**](OrderApi.md#quashfulfillment) | **POST** /order.Order/QuashFulfillment | Quash Fulfillment |
| [**QuashShipment**](OrderApi.md#quashshipment) | **POST** /order.Order/QuashShipment | Quash Shipment |
| [**ReceiveFulfillment**](OrderApi.md#receivefulfillment) | **POST** /order.Order/ReceiveFulfillment | Receive Fulfillment |
| [**ReportFulfillmentError**](OrderApi.md#reportfulfillmenterror) | **POST** /order.Order/ReportFulfillmentError | Report Fulfillment Error |
| [**ReportFulfillmentNotResolvable**](OrderApi.md#reportfulfillmentnotresolvable) | **POST** /order.Order/ReportFulfillmentNotResolvable | Report Fulfillment Not Resolvable |
| [**ReportFulfillmentReady**](OrderApi.md#reportfulfillmentready) | **POST** /order.Order/ReportFulfillmentReady | Report Fulfillment Ready |
| [**ReportShipmentDelivery**](OrderApi.md#reportshipmentdelivery) | **POST** /order.Order/ReportShipmentDelivery | Report Shipment Delivery |
| [**ReportShipmentMissingStock**](OrderApi.md#reportshipmentmissingstock) | **POST** /order.Order/ReportShipmentMissingStock | Report Shipment Missing Stock |
| [**ResolveShipmentMissingStock**](OrderApi.md#resolveshipmentmissingstock) | **POST** /order.Order/ResolveShipmentMissingStock | Resolve Shipment Missing Stock |
| [**RetryFulfillment**](OrderApi.md#retryfulfillment) | **POST** /order.Order/RetryFulfillment | Retry Fulfillment |
| [**SearchOrders**](OrderApi.md#searchorders) | **POST** /order.Order/SearchOrders | Search Orders |
| [**SendFulfillment**](OrderApi.md#sendfulfillment) | **POST** /order.Order/SendFulfillment | Send Fulfillment |
| [**SendOrderNotification**](OrderApi.md#sendordernotification) | **POST** /order.Order/SendOrderNotification | Send Order Notification |
| [**StartFulfillmentProcessing**](OrderApi.md#startfulfillmentprocessing) | **POST** /order.Order/StartFulfillmentProcessing | Start Fulfillment Processing |
| [**StartShipmentProcessing**](OrderApi.md#startshipmentprocessing) | **POST** /order.Order/StartShipmentProcessing | Start Shipment Processing |
| [**UnholdOrder**](OrderApi.md#unholdorder) | **POST** /order.Order/UnholdOrder | Unhold Order |
| [**UpdateOrder**](OrderApi.md#updateorder) | **POST** /order.Order/UpdateOrder | Update Order |
| [**UpdatePayment**](OrderApi.md#updatepayment) | **POST** /order.Order/UpdatePayment | Update Payment |

<a id="approveorder"></a>
# **ApproveOrder**
> Object ApproveOrder (OrderApproveOrderRequest body)

Approve Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ApproveOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderApproveOrderRequest(); // OrderApproveOrderRequest | 

            try
            {
                // Approve Order
                Object result = apiInstance.ApproveOrder(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ApproveOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApproveOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve Order
    ApiResponse<Object> response = apiInstance.ApproveOrderWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ApproveOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderApproveOrderRequest**](OrderApproveOrderRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assignshipment"></a>
# **AssignShipment**
> Object AssignShipment (OrderAssignShipmentRequest body)

Assign Shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class AssignShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderAssignShipmentRequest(); // OrderAssignShipmentRequest | 

            try
            {
                // Assign Shipment
                Object result = apiInstance.AssignShipment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.AssignShipment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssignShipmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign Shipment
    ApiResponse<Object> response = apiInstance.AssignShipmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.AssignShipmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderAssignShipmentRequest**](OrderAssignShipmentRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="calculaterefund"></a>
# **CalculateRefund**
> OrderCalculateRefundResponse CalculateRefund (OrderCalculateRefundRequest body)

Calculate Refund

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CalculateRefundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCalculateRefundRequest(); // OrderCalculateRefundRequest | 

            try
            {
                // Calculate Refund
                OrderCalculateRefundResponse result = apiInstance.CalculateRefund(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CalculateRefund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CalculateRefundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Calculate Refund
    ApiResponse<OrderCalculateRefundResponse> response = apiInstance.CalculateRefundWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CalculateRefundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCalculateRefundRequest**](OrderCalculateRefundRequest.md) |  |  |

### Return type

[**OrderCalculateRefundResponse**](OrderCalculateRefundResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cancelfulfillment"></a>
# **CancelFulfillment**
> Object CancelFulfillment (OrderCancelFulfillmentRequest body)

Cancel Fulfillment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CancelFulfillmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCancelFulfillmentRequest(); // OrderCancelFulfillmentRequest | 

            try
            {
                // Cancel Fulfillment
                Object result = apiInstance.CancelFulfillment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CancelFulfillment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelFulfillmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Fulfillment
    ApiResponse<Object> response = apiInstance.CancelFulfillmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CancelFulfillmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCancelFulfillmentRequest**](OrderCancelFulfillmentRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cancelorder"></a>
# **CancelOrder**
> Object CancelOrder (OrderCancelOrderRequest body)

Cancel Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCancelOrderRequest(); // OrderCancelOrderRequest | 

            try
            {
                // Cancel Order
                Object result = apiInstance.CancelOrder(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CancelOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Order
    ApiResponse<Object> response = apiInstance.CancelOrderWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CancelOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCancelOrderRequest**](OrderCancelOrderRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cancelshipment"></a>
# **CancelShipment**
> Object CancelShipment (OrderCancelShipmentRequest body)

Cancel Shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CancelShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCancelShipmentRequest(); // OrderCancelShipmentRequest | 

            try
            {
                // Cancel Shipment
                Object result = apiInstance.CancelShipment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CancelShipment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelShipmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Shipment
    ApiResponse<Object> response = apiInstance.CancelShipmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CancelShipmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCancelShipmentRequest**](OrderCancelShipmentRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="completeshipmentpacking"></a>
# **CompleteShipmentPacking**
> Object CompleteShipmentPacking (OrderCompleteShipmentPackingRequest body)

Complete Shipment Packing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CompleteShipmentPackingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCompleteShipmentPackingRequest(); // OrderCompleteShipmentPackingRequest | 

            try
            {
                // Complete Shipment Packing
                Object result = apiInstance.CompleteShipmentPacking(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CompleteShipmentPacking: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompleteShipmentPackingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Complete Shipment Packing
    ApiResponse<Object> response = apiInstance.CompleteShipmentPackingWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CompleteShipmentPackingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCompleteShipmentPackingRequest**](OrderCompleteShipmentPackingRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfulfillment"></a>
# **CreateFulfillment**
> OrderFulfillment CreateFulfillment (OrderCreateFulfillmentRequest body)

Create Fulfillment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CreateFulfillmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCreateFulfillmentRequest(); // OrderCreateFulfillmentRequest | 

            try
            {
                // Create Fulfillment
                OrderFulfillment result = apiInstance.CreateFulfillment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateFulfillment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFulfillmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Fulfillment
    ApiResponse<OrderFulfillment> response = apiInstance.CreateFulfillmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreateFulfillmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCreateFulfillmentRequest**](OrderCreateFulfillmentRequest.md) |  |  |

### Return type

[**OrderFulfillment**](OrderFulfillment.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createorder"></a>
# **CreateOrder**
> OrderOrderData CreateOrder (OrderCreateOrderRequest body)

Create Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCreateOrderRequest(); // OrderCreateOrderRequest | 

            try
            {
                // Create Order
                OrderOrderData result = apiInstance.CreateOrder(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Order
    ApiResponse<OrderOrderData> response = apiInstance.CreateOrderWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCreateOrderRequest**](OrderCreateOrderRequest.md) |  |  |

### Return type

[**OrderOrderData**](OrderOrderData.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createorderhistory"></a>
# **CreateOrderHistory**
> OrderDataHistory CreateOrderHistory (OrderCreateHistoryRequest body)

Create Order History

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CreateOrderHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCreateHistoryRequest(); // OrderCreateHistoryRequest | 

            try
            {
                // Create Order History
                OrderDataHistory result = apiInstance.CreateOrderHistory(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateOrderHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Order History
    ApiResponse<OrderDataHistory> response = apiInstance.CreateOrderHistoryWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreateOrderHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCreateHistoryRequest**](OrderCreateHistoryRequest.md) |  |  |

### Return type

[**OrderDataHistory**](OrderDataHistory.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpayment"></a>
# **CreatePayment**
> OrderPayment CreatePayment (OrderCreatePaymentRequest body)

Create Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CreatePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCreatePaymentRequest(); // OrderCreatePaymentRequest | 

            try
            {
                // Create Payment
                OrderPayment result = apiInstance.CreatePayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreatePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Payment
    ApiResponse<OrderPayment> response = apiInstance.CreatePaymentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreatePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCreatePaymentRequest**](OrderCreatePaymentRequest.md) |  |  |

### Return type

[**OrderPayment**](OrderPayment.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpaymenttransaction"></a>
# **CreatePaymentTransaction**
> OrderTransaction CreatePaymentTransaction (OrderCreatePaymentTransactionRequest body)

Create Payment Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CreatePaymentTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCreatePaymentTransactionRequest(); // OrderCreatePaymentTransactionRequest | 

            try
            {
                // Create Payment Transaction
                OrderTransaction result = apiInstance.CreatePaymentTransaction(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreatePaymentTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Payment Transaction
    ApiResponse<OrderTransaction> response = apiInstance.CreatePaymentTransactionWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreatePaymentTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCreatePaymentTransactionRequest**](OrderCreatePaymentTransactionRequest.md) |  |  |

### Return type

[**OrderTransaction**](OrderTransaction.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createrefund"></a>
# **CreateRefund**
> OrderRefund CreateRefund (OrderCreateRefundRequest body)

Create Refund

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CreateRefundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCreateRefundRequest(); // OrderCreateRefundRequest | 

            try
            {
                // Create Refund
                OrderRefund result = apiInstance.CreateRefund(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateRefund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRefundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Refund
    ApiResponse<OrderRefund> response = apiInstance.CreateRefundWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreateRefundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCreateRefundRequest**](OrderCreateRefundRequest.md) |  |  |

### Return type

[**OrderRefund**](OrderRefund.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createrefundtransaction"></a>
# **CreateRefundTransaction**
> OrderTransaction CreateRefundTransaction (OrderCreateRefundTransactionRequest body)

Create Refund Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CreateRefundTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCreateRefundTransactionRequest(); // OrderCreateRefundTransactionRequest | 

            try
            {
                // Create Refund Transaction
                OrderTransaction result = apiInstance.CreateRefundTransaction(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateRefundTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRefundTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Refund Transaction
    ApiResponse<OrderTransaction> response = apiInstance.CreateRefundTransactionWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreateRefundTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCreateRefundTransactionRequest**](OrderCreateRefundTransactionRequest.md) |  |  |

### Return type

[**OrderTransaction**](OrderTransaction.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createshipment"></a>
# **CreateShipment**
> OrderShipment CreateShipment (OrderCreateShipmentRequest body)

Create Shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class CreateShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderCreateShipmentRequest(); // OrderCreateShipmentRequest | 

            try
            {
                // Create Shipment
                OrderShipment result = apiInstance.CreateShipment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.CreateShipment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateShipmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Shipment
    ApiResponse<OrderShipment> response = apiInstance.CreateShipmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.CreateShipmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderCreateShipmentRequest**](OrderCreateShipmentRequest.md) |  |  |

### Return type

[**OrderShipment**](OrderShipment.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteorder"></a>
# **DeleteOrder**
> Object DeleteOrder (OrderDeleteOrderRequest body)

Delete Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class DeleteOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderDeleteOrderRequest(); // OrderDeleteOrderRequest | 

            try
            {
                // Delete Order
                Object result = apiInstance.DeleteOrder(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.DeleteOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Order
    ApiResponse<Object> response = apiInstance.DeleteOrderWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.DeleteOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderDeleteOrderRequest**](OrderDeleteOrderRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfulfillment"></a>
# **GetFulfillment**
> OrderFulfillment GetFulfillment (OrderGetFulfillmentRequest body)

Get Fulfillment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class GetFulfillmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderGetFulfillmentRequest(); // OrderGetFulfillmentRequest | 

            try
            {
                // Get Fulfillment
                OrderFulfillment result = apiInstance.GetFulfillment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetFulfillment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFulfillmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Fulfillment
    ApiResponse<OrderFulfillment> response = apiInstance.GetFulfillmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetFulfillmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderGetFulfillmentRequest**](OrderGetFulfillmentRequest.md) |  |  |

### Return type

[**OrderFulfillment**](OrderFulfillment.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorder"></a>
# **GetOrder**
> OrderOrderData GetOrder (OrderGetOrderRequest body)

Get Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class GetOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderGetOrderRequest(); // OrderGetOrderRequest | 

            try
            {
                // Get Order
                OrderOrderData result = apiInstance.GetOrder(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Order
    ApiResponse<OrderOrderData> response = apiInstance.GetOrderWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderGetOrderRequest**](OrderGetOrderRequest.md) |  |  |

### Return type

[**OrderOrderData**](OrderOrderData.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorderbycartid"></a>
# **GetOrderByCartId**
> OrderOrderData GetOrderByCartId (OrderGetOrderByCartIdRequest body)

Get Order by Cart ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class GetOrderByCartIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderGetOrderByCartIdRequest(); // OrderGetOrderByCartIdRequest | 

            try
            {
                // Get Order by Cart ID
                OrderOrderData result = apiInstance.GetOrderByCartId(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderByCartId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderByCartIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Order by Cart ID
    ApiResponse<OrderOrderData> response = apiInstance.GetOrderByCartIdWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetOrderByCartIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderGetOrderByCartIdRequest**](OrderGetOrderByCartIdRequest.md) |  |  |

### Return type

[**OrderOrderData**](OrderOrderData.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorderbyordernumber"></a>
# **GetOrderByOrderNumber**
> OrderOrderData GetOrderByOrderNumber (OrderGetOrderByOrderNumberRequest body)

Get Order by Order Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class GetOrderByOrderNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderGetOrderByOrderNumberRequest(); // OrderGetOrderByOrderNumberRequest | 

            try
            {
                // Get Order by Order Number
                OrderOrderData result = apiInstance.GetOrderByOrderNumber(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderByOrderNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderByOrderNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Order by Order Number
    ApiResponse<OrderOrderData> response = apiInstance.GetOrderByOrderNumberWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetOrderByOrderNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderGetOrderByOrderNumberRequest**](OrderGetOrderByOrderNumberRequest.md) |  |  |

### Return type

[**OrderOrderData**](OrderOrderData.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpayment"></a>
# **GetPayment**
> OrderPayment GetPayment (OrderGetPaymentRequest body)

Get Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class GetPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderGetPaymentRequest(); // OrderGetPaymentRequest | 

            try
            {
                // Get Payment
                OrderPayment result = apiInstance.GetPayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Payment
    ApiResponse<OrderPayment> response = apiInstance.GetPaymentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderGetPaymentRequest**](OrderGetPaymentRequest.md) |  |  |

### Return type

[**OrderPayment**](OrderPayment.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getshipment"></a>
# **GetShipment**
> OrderShipment GetShipment (OrderGetShipmentRequest body)

Get Shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class GetShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderGetShipmentRequest(); // OrderGetShipmentRequest | 

            try
            {
                // Get Shipment
                OrderShipment result = apiInstance.GetShipment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetShipment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetShipmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Shipment
    ApiResponse<OrderShipment> response = apiInstance.GetShipmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetShipmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderGetShipmentRequest**](OrderGetShipmentRequest.md) |  |  |

### Return type

[**OrderShipment**](OrderShipment.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransaction"></a>
# **GetTransaction**
> OrderTransaction GetTransaction (OrderGetTransactionRequest body)

Get Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class GetTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderGetTransactionRequest(); // OrderGetTransactionRequest | 

            try
            {
                // Get Transaction
                OrderTransaction result = apiInstance.GetTransaction(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.GetTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transaction
    ApiResponse<OrderTransaction> response = apiInstance.GetTransactionWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.GetTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderGetTransactionRequest**](OrderGetTransactionRequest.md) |  |  |

### Return type

[**OrderTransaction**](OrderTransaction.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="holdorder"></a>
# **HoldOrder**
> Object HoldOrder (OrderHoldOrderRequest body)

Hold Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class HoldOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderHoldOrderRequest(); // OrderHoldOrderRequest | 

            try
            {
                // Hold Order
                Object result = apiInstance.HoldOrder(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.HoldOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HoldOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Hold Order
    ApiResponse<Object> response = apiInstance.HoldOrderWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.HoldOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderHoldOrderRequest**](OrderHoldOrderRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="importorder"></a>
# **ImportOrder**
> OrderOrderData ImportOrder (OrderImportOrderRequest body)

Import Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ImportOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderImportOrderRequest(); // OrderImportOrderRequest | 

            try
            {
                // Import Order
                OrderOrderData result = apiInstance.ImportOrder(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ImportOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import Order
    ApiResponse<OrderOrderData> response = apiInstance.ImportOrderWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ImportOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderImportOrderRequest**](OrderImportOrderRequest.md) |  |  |

### Return type

[**OrderOrderData**](OrderOrderData.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listfulfillments"></a>
# **ListFulfillments**
> OrderListFulfillmentsResponse ListFulfillments (OrderListFulfillmentsRequest body)

List Fulfillments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ListFulfillmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderListFulfillmentsRequest(); // OrderListFulfillmentsRequest | 

            try
            {
                // List Fulfillments
                OrderListFulfillmentsResponse result = apiInstance.ListFulfillments(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ListFulfillments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFulfillmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Fulfillments
    ApiResponse<OrderListFulfillmentsResponse> response = apiInstance.ListFulfillmentsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ListFulfillmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderListFulfillmentsRequest**](OrderListFulfillmentsRequest.md) |  |  |

### Return type

[**OrderListFulfillmentsResponse**](OrderListFulfillmentsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listorders"></a>
# **ListOrders**
> OrderListOrdersResponse ListOrders (OrderListOrdersRequest body)

List Orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ListOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderListOrdersRequest(); // OrderListOrdersRequest | 

            try
            {
                // List Orders
                OrderListOrdersResponse result = apiInstance.ListOrders(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ListOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Orders
    ApiResponse<OrderListOrdersResponse> response = apiInstance.ListOrdersWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ListOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderListOrdersRequest**](OrderListOrdersRequest.md) |  |  |

### Return type

[**OrderListOrdersResponse**](OrderListOrdersResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listordersbycustomer"></a>
# **ListOrdersByCustomer**
> OrderListOrdersByCustomerResponse ListOrdersByCustomer (OrderListOrdersByCustomerRequest body)

List Orders by Customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ListOrdersByCustomerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderListOrdersByCustomerRequest(); // OrderListOrdersByCustomerRequest | 

            try
            {
                // List Orders by Customer
                OrderListOrdersByCustomerResponse result = apiInstance.ListOrdersByCustomer(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ListOrdersByCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOrdersByCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Orders by Customer
    ApiResponse<OrderListOrdersByCustomerResponse> response = apiInstance.ListOrdersByCustomerWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ListOrdersByCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderListOrdersByCustomerRequest**](OrderListOrdersByCustomerRequest.md) |  |  |

### Return type

[**OrderListOrdersByCustomerResponse**](OrderListOrdersByCustomerResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listordersbynumbers"></a>
# **ListOrdersByNumbers**
> OrderListOrdersByNumbersResponse ListOrdersByNumbers (OrderListOrdersByNumbersRequest body)

List Orders by Numbers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ListOrdersByNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderListOrdersByNumbersRequest(); // OrderListOrdersByNumbersRequest | 

            try
            {
                // List Orders by Numbers
                OrderListOrdersByNumbersResponse result = apiInstance.ListOrdersByNumbers(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ListOrdersByNumbers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOrdersByNumbersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Orders by Numbers
    ApiResponse<OrderListOrdersByNumbersResponse> response = apiInstance.ListOrdersByNumbersWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ListOrdersByNumbersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderListOrdersByNumbersRequest**](OrderListOrdersByNumbersRequest.md) |  |  |

### Return type

[**OrderListOrdersByNumbersResponse**](OrderListOrdersByNumbersResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listshipments"></a>
# **ListShipments**
> OrderListShipmentsResponse ListShipments (OrderListShipmentsRequest body)

List Shipments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ListShipmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderListShipmentsRequest(); // OrderListShipmentsRequest | 

            try
            {
                // List Shipments
                OrderListShipmentsResponse result = apiInstance.ListShipments(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ListShipments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListShipmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Shipments
    ApiResponse<OrderListShipmentsResponse> response = apiInstance.ListShipmentsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ListShipmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderListShipmentsRequest**](OrderListShipmentsRequest.md) |  |  |

### Return type

[**OrderListShipmentsResponse**](OrderListShipmentsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderadddocument"></a>
# **OrderAddDocument**
> Object OrderAddDocument (OrderAddDocumentRequest body)

Documents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class OrderAddDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderAddDocumentRequest(); // OrderAddDocumentRequest | 

            try
            {
                // Documents
                Object result = apiInstance.OrderAddDocument(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderAddDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderAddDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Documents
    ApiResponse<Object> response = apiInstance.OrderAddDocumentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderAddDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderAddDocumentRequest**](OrderAddDocumentRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderremovedocumentbycode"></a>
# **OrderRemoveDocumentByCode**
> Object OrderRemoveDocumentByCode (OrderRemoveDocumentByCodeRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class OrderRemoveDocumentByCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderRemoveDocumentByCodeRequest(); // OrderRemoveDocumentByCodeRequest | 

            try
            {
                Object result = apiInstance.OrderRemoveDocumentByCode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderRemoveDocumentByCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderRemoveDocumentByCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.OrderRemoveDocumentByCodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderRemoveDocumentByCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderRemoveDocumentByCodeRequest**](OrderRemoveDocumentByCodeRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="printorderslabels"></a>
# **PrintOrdersLabels**
> OrderPrintOrdersLabelsResponse PrintOrdersLabels (OrderPrintOrdersLabelsRequest body)

Print Orders Labels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class PrintOrdersLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderPrintOrdersLabelsRequest(); // OrderPrintOrdersLabelsRequest | 

            try
            {
                // Print Orders Labels
                OrderPrintOrdersLabelsResponse result = apiInstance.PrintOrdersLabels(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.PrintOrdersLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintOrdersLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Print Orders Labels
    ApiResponse<OrderPrintOrdersLabelsResponse> response = apiInstance.PrintOrdersLabelsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.PrintOrdersLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderPrintOrdersLabelsRequest**](OrderPrintOrdersLabelsRequest.md) |  |  |

### Return type

[**OrderPrintOrdersLabelsResponse**](OrderPrintOrdersLabelsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="quashfulfillment"></a>
# **QuashFulfillment**
> Object QuashFulfillment (OrderQuashFulfillmentRequest body)

Quash Fulfillment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class QuashFulfillmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderQuashFulfillmentRequest(); // OrderQuashFulfillmentRequest | 

            try
            {
                // Quash Fulfillment
                Object result = apiInstance.QuashFulfillment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.QuashFulfillment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QuashFulfillmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Quash Fulfillment
    ApiResponse<Object> response = apiInstance.QuashFulfillmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.QuashFulfillmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderQuashFulfillmentRequest**](OrderQuashFulfillmentRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="quashshipment"></a>
# **QuashShipment**
> Object QuashShipment (OrderQuashShipmentRequest body)

Quash Shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class QuashShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderQuashShipmentRequest(); // OrderQuashShipmentRequest | 

            try
            {
                // Quash Shipment
                Object result = apiInstance.QuashShipment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.QuashShipment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QuashShipmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Quash Shipment
    ApiResponse<Object> response = apiInstance.QuashShipmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.QuashShipmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderQuashShipmentRequest**](OrderQuashShipmentRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="receivefulfillment"></a>
# **ReceiveFulfillment**
> Object ReceiveFulfillment (OrderReceiveFulfillmentRequest body)

Receive Fulfillment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ReceiveFulfillmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderReceiveFulfillmentRequest(); // OrderReceiveFulfillmentRequest | 

            try
            {
                // Receive Fulfillment
                Object result = apiInstance.ReceiveFulfillment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ReceiveFulfillment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReceiveFulfillmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Receive Fulfillment
    ApiResponse<Object> response = apiInstance.ReceiveFulfillmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ReceiveFulfillmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderReceiveFulfillmentRequest**](OrderReceiveFulfillmentRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reportfulfillmenterror"></a>
# **ReportFulfillmentError**
> Object ReportFulfillmentError (OrderReportFulfillmentErrorRequest body)

Report Fulfillment Error

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ReportFulfillmentErrorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderReportFulfillmentErrorRequest(); // OrderReportFulfillmentErrorRequest | 

            try
            {
                // Report Fulfillment Error
                Object result = apiInstance.ReportFulfillmentError(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ReportFulfillmentError: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportFulfillmentErrorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report Fulfillment Error
    ApiResponse<Object> response = apiInstance.ReportFulfillmentErrorWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ReportFulfillmentErrorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderReportFulfillmentErrorRequest**](OrderReportFulfillmentErrorRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reportfulfillmentnotresolvable"></a>
# **ReportFulfillmentNotResolvable**
> Object ReportFulfillmentNotResolvable (OrderReportFulfillmentNotResolvableRequest body)

Report Fulfillment Not Resolvable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ReportFulfillmentNotResolvableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderReportFulfillmentNotResolvableRequest(); // OrderReportFulfillmentNotResolvableRequest | 

            try
            {
                // Report Fulfillment Not Resolvable
                Object result = apiInstance.ReportFulfillmentNotResolvable(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ReportFulfillmentNotResolvable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportFulfillmentNotResolvableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report Fulfillment Not Resolvable
    ApiResponse<Object> response = apiInstance.ReportFulfillmentNotResolvableWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ReportFulfillmentNotResolvableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderReportFulfillmentNotResolvableRequest**](OrderReportFulfillmentNotResolvableRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reportfulfillmentready"></a>
# **ReportFulfillmentReady**
> Object ReportFulfillmentReady (OrderReportFulfillmentReadyRequest body)

Report Fulfillment Ready

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ReportFulfillmentReadyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderReportFulfillmentReadyRequest(); // OrderReportFulfillmentReadyRequest | 

            try
            {
                // Report Fulfillment Ready
                Object result = apiInstance.ReportFulfillmentReady(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ReportFulfillmentReady: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportFulfillmentReadyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report Fulfillment Ready
    ApiResponse<Object> response = apiInstance.ReportFulfillmentReadyWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ReportFulfillmentReadyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderReportFulfillmentReadyRequest**](OrderReportFulfillmentReadyRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reportshipmentdelivery"></a>
# **ReportShipmentDelivery**
> Object ReportShipmentDelivery (OrderReportShipmentDeliveryRequest body)

Report Shipment Delivery

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ReportShipmentDeliveryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderReportShipmentDeliveryRequest(); // OrderReportShipmentDeliveryRequest | 

            try
            {
                // Report Shipment Delivery
                Object result = apiInstance.ReportShipmentDelivery(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ReportShipmentDelivery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportShipmentDeliveryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report Shipment Delivery
    ApiResponse<Object> response = apiInstance.ReportShipmentDeliveryWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ReportShipmentDeliveryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderReportShipmentDeliveryRequest**](OrderReportShipmentDeliveryRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reportshipmentmissingstock"></a>
# **ReportShipmentMissingStock**
> Object ReportShipmentMissingStock (OrderReportShipmentMissingStockRequest body)

Report Shipment Missing Stock

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ReportShipmentMissingStockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderReportShipmentMissingStockRequest(); // OrderReportShipmentMissingStockRequest | 

            try
            {
                // Report Shipment Missing Stock
                Object result = apiInstance.ReportShipmentMissingStock(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ReportShipmentMissingStock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportShipmentMissingStockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report Shipment Missing Stock
    ApiResponse<Object> response = apiInstance.ReportShipmentMissingStockWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ReportShipmentMissingStockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderReportShipmentMissingStockRequest**](OrderReportShipmentMissingStockRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resolveshipmentmissingstock"></a>
# **ResolveShipmentMissingStock**
> Object ResolveShipmentMissingStock (OrderResolveShipmentMissingStockRequest body)

Resolve Shipment Missing Stock

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class ResolveShipmentMissingStockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderResolveShipmentMissingStockRequest(); // OrderResolveShipmentMissingStockRequest | 

            try
            {
                // Resolve Shipment Missing Stock
                Object result = apiInstance.ResolveShipmentMissingStock(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.ResolveShipmentMissingStock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolveShipmentMissingStockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resolve Shipment Missing Stock
    ApiResponse<Object> response = apiInstance.ResolveShipmentMissingStockWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.ResolveShipmentMissingStockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderResolveShipmentMissingStockRequest**](OrderResolveShipmentMissingStockRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retryfulfillment"></a>
# **RetryFulfillment**
> Object RetryFulfillment (OrderRetryFulfillmentRequest body)

Retry Fulfillment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class RetryFulfillmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderRetryFulfillmentRequest(); // OrderRetryFulfillmentRequest | 

            try
            {
                // Retry Fulfillment
                Object result = apiInstance.RetryFulfillment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.RetryFulfillment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetryFulfillmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retry Fulfillment
    ApiResponse<Object> response = apiInstance.RetryFulfillmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.RetryFulfillmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderRetryFulfillmentRequest**](OrderRetryFulfillmentRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchorders"></a>
# **SearchOrders**
> OrderSearchOrdersResponse SearchOrders (OrderSearchOrdersRequest body)

Search Orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class SearchOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderSearchOrdersRequest(); // OrderSearchOrdersRequest | 

            try
            {
                // Search Orders
                OrderSearchOrdersResponse result = apiInstance.SearchOrders(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.SearchOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Orders
    ApiResponse<OrderSearchOrdersResponse> response = apiInstance.SearchOrdersWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.SearchOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderSearchOrdersRequest**](OrderSearchOrdersRequest.md) |  |  |

### Return type

[**OrderSearchOrdersResponse**](OrderSearchOrdersResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendfulfillment"></a>
# **SendFulfillment**
> Object SendFulfillment (OrderSendFulfillmentRequest body)

Send Fulfillment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class SendFulfillmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderSendFulfillmentRequest(); // OrderSendFulfillmentRequest | 

            try
            {
                // Send Fulfillment
                Object result = apiInstance.SendFulfillment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.SendFulfillment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendFulfillmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Fulfillment
    ApiResponse<Object> response = apiInstance.SendFulfillmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.SendFulfillmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderSendFulfillmentRequest**](OrderSendFulfillmentRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendordernotification"></a>
# **SendOrderNotification**
> Object SendOrderNotification (OrderSendOrderNotificationRequest body)

Send Order Notification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class SendOrderNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderSendOrderNotificationRequest(); // OrderSendOrderNotificationRequest | 

            try
            {
                // Send Order Notification
                Object result = apiInstance.SendOrderNotification(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.SendOrderNotification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendOrderNotificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Order Notification
    ApiResponse<Object> response = apiInstance.SendOrderNotificationWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.SendOrderNotificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderSendOrderNotificationRequest**](OrderSendOrderNotificationRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="startfulfillmentprocessing"></a>
# **StartFulfillmentProcessing**
> Object StartFulfillmentProcessing (OrderStartFulfillmentProcessingRequest body)

Start Fulfillment Processing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class StartFulfillmentProcessingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderStartFulfillmentProcessingRequest(); // OrderStartFulfillmentProcessingRequest | 

            try
            {
                // Start Fulfillment Processing
                Object result = apiInstance.StartFulfillmentProcessing(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.StartFulfillmentProcessing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartFulfillmentProcessingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start Fulfillment Processing
    ApiResponse<Object> response = apiInstance.StartFulfillmentProcessingWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.StartFulfillmentProcessingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderStartFulfillmentProcessingRequest**](OrderStartFulfillmentProcessingRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="startshipmentprocessing"></a>
# **StartShipmentProcessing**
> Object StartShipmentProcessing (OrderStartShipmentProcessingRequest body)

Start Shipment Processing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class StartShipmentProcessingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderStartShipmentProcessingRequest(); // OrderStartShipmentProcessingRequest | 

            try
            {
                // Start Shipment Processing
                Object result = apiInstance.StartShipmentProcessing(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.StartShipmentProcessing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartShipmentProcessingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start Shipment Processing
    ApiResponse<Object> response = apiInstance.StartShipmentProcessingWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.StartShipmentProcessingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderStartShipmentProcessingRequest**](OrderStartShipmentProcessingRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unholdorder"></a>
# **UnholdOrder**
> Object UnholdOrder (OrderUnholdOrderRequest body)

Unhold Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class UnholdOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderUnholdOrderRequest(); // OrderUnholdOrderRequest | 

            try
            {
                // Unhold Order
                Object result = apiInstance.UnholdOrder(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.UnholdOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnholdOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unhold Order
    ApiResponse<Object> response = apiInstance.UnholdOrderWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.UnholdOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderUnholdOrderRequest**](OrderUnholdOrderRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorder"></a>
# **UpdateOrder**
> OrderOrderData UpdateOrder (OrderUpdateOrderRequest body)

Update Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class UpdateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderUpdateOrderRequest(); // OrderUpdateOrderRequest | 

            try
            {
                // Update Order
                OrderOrderData result = apiInstance.UpdateOrder(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.UpdateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Order
    ApiResponse<OrderOrderData> response = apiInstance.UpdateOrderWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.UpdateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderUpdateOrderRequest**](OrderUpdateOrderRequest.md) |  |  |

### Return type

[**OrderOrderData**](OrderOrderData.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepayment"></a>
# **UpdatePayment**
> OrderPayment UpdatePayment (OrderUpdatePaymentRequest body)

Update Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using order.Api;
using order.Client;
using order.Model;

namespace Example
{
    public class UpdatePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dom.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrderApi(config);
            var body = new OrderUpdatePaymentRequest(); // OrderUpdatePaymentRequest | 

            try
            {
                // Update Payment
                OrderPayment result = apiInstance.UpdatePayment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.UpdatePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Payment
    ApiResponse<OrderPayment> response = apiInstance.UpdatePaymentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.UpdatePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**OrderUpdatePaymentRequest**](OrderUpdatePaymentRequest.md) |  |  |

### Return type

[**OrderPayment**](OrderPayment.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

