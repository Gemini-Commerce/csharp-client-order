/*
 * order Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = order.Client.OpenAPIDateConverter;

namespace order.Model
{
    /// <summary>
    /// Defines OrderDataSubtotalCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderDataSubtotalCode
    {
        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// Enum PAYMENT for value: PAYMENT
        /// </summary>
        [EnumMember(Value = "PAYMENT")]
        PAYMENT,

        /// <summary>
        /// Enum SHIPMENT for value: SHIPMENT
        /// </summary>
        [EnumMember(Value = "SHIPMENT")]
        SHIPMENT,

        /// <summary>
        /// Enum TAX for value: TAX
        /// </summary>
        [EnumMember(Value = "TAX")]
        TAX,

        /// <summary>
        /// Enum ITEMS for value: ITEMS
        /// </summary>
        [EnumMember(Value = "ITEMS")]
        ITEMS,

        /// <summary>
        /// Enum ITEMSDISCOUNTED for value: ITEMS_DISCOUNTED
        /// </summary>
        [EnumMember(Value = "ITEMS_DISCOUNTED")]
        ITEMSDISCOUNTED,

        /// <summary>
        /// Enum DISCOUNT for value: DISCOUNT
        /// </summary>
        [EnumMember(Value = "DISCOUNT")]
        DISCOUNT
    }

}
