/*
 * order Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using order.Model;
using order.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace order.Test.Model
{
    /// <summary>
    ///  Class for testing OrderListOrdersByCustomerRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OrderListOrdersByCustomerRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for OrderListOrdersByCustomerRequest
        //private OrderListOrdersByCustomerRequest instance;

        public OrderListOrdersByCustomerRequestTests()
        {
            // TODO uncomment below to create an instance of OrderListOrdersByCustomerRequest
            //instance = new OrderListOrdersByCustomerRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrderListOrdersByCustomerRequest
        /// </summary>
        [Fact]
        public void OrderListOrdersByCustomerRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" OrderListOrdersByCustomerRequest
            //Assert.IsType<OrderListOrdersByCustomerRequest>(instance);
        }

        /// <summary>
        /// Test the property 'TenantId'
        /// </summary>
        [Fact]
        public void TenantIdTest()
        {
            // TODO unit test for the property 'TenantId'
        }

        /// <summary>
        /// Test the property 'CustomerGrn'
        /// </summary>
        [Fact]
        public void CustomerGrnTest()
        {
            // TODO unit test for the property 'CustomerGrn'
        }

        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Fact]
        public void PageSizeTest()
        {
            // TODO unit test for the property 'PageSize'
        }

        /// <summary>
        /// Test the property 'PageToken'
        /// </summary>
        [Fact]
        public void PageTokenTest()
        {
            // TODO unit test for the property 'PageToken'
        }

        /// <summary>
        /// Test the property 'OrderBy'
        /// </summary>
        [Fact]
        public void OrderByTest()
        {
            // TODO unit test for the property 'OrderBy'
        }
    }
}
