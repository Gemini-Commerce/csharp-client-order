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
    /// OrderCalculateRefundRequest
    /// </summary>
    [DataContract(Name = "orderCalculateRefundRequest")]
    public partial class OrderCalculateRefundRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCalculateRefundRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderCalculateRefundRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCalculateRefundRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="paymentId">paymentId (required).</param>
        /// <param name="items">items.</param>
        /// <param name="shipping">Boolean indicating whether to calculate refund for shipping..</param>
        public OrderCalculateRefundRequest(string tenantId = default(string), string paymentId = default(string), List<OrderRefundItem> items = default(List<OrderRefundItem>), bool shipping = default(bool))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for OrderCalculateRefundRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "paymentId" is required (not null)
            if (paymentId == null)
            {
                throw new ArgumentNullException("paymentId is a required property for OrderCalculateRefundRequest and cannot be null");
            }
            this.PaymentId = paymentId;
            this.Items = items;
            this.Shipping = shipping;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentId
        /// </summary>
        [DataMember(Name = "paymentId", IsRequired = true, EmitDefaultValue = true)]
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<OrderRefundItem> Items { get; set; }

        /// <summary>
        /// Boolean indicating whether to calculate refund for shipping.
        /// </summary>
        /// <value>Boolean indicating whether to calculate refund for shipping.</value>
        [DataMember(Name = "shipping", EmitDefaultValue = true)]
        public bool Shipping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCalculateRefundRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
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
