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
    /// OrderHoldOrderRequest
    /// </summary>
    [DataContract(Name = "orderHoldOrderRequest")]
    public partial class OrderHoldOrderRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderHoldOrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderHoldOrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderHoldOrderRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="orderId">orderId (required).</param>
        /// <param name="reason">reason.</param>
        public OrderHoldOrderRequest(string tenantId = default(string), string orderId = default(string), string reason = default(string))
        {
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new ArgumentNullException("orderId is a required property for OrderHoldOrderRequest and cannot be null");
            }
            this.OrderId = orderId;
            this.TenantId = tenantId;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "orderId", IsRequired = true, EmitDefaultValue = true)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderHoldOrderRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
