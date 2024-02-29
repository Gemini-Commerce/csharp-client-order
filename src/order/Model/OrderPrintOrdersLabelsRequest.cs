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
    /// OrderPrintOrdersLabelsRequest
    /// </summary>
    [DataContract(Name = "orderPrintOrdersLabelsRequest")]
    public partial class OrderPrintOrdersLabelsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPrintOrdersLabelsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderPrintOrdersLabelsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPrintOrdersLabelsRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="orderNumbers">orderNumbers (required).</param>
        public OrderPrintOrdersLabelsRequest(string tenantId = default(string), List<string> orderNumbers = default(List<string>))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for OrderPrintOrdersLabelsRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "orderNumbers" is required (not null)
            if (orderNumbers == null)
            {
                throw new ArgumentNullException("orderNumbers is a required property for OrderPrintOrdersLabelsRequest and cannot be null");
            }
            this.OrderNumbers = orderNumbers;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets OrderNumbers
        /// </summary>
        [DataMember(Name = "orderNumbers", IsRequired = true, EmitDefaultValue = true)]
        public List<string> OrderNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderPrintOrdersLabelsRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  OrderNumbers: ").Append(OrderNumbers).Append("\n");
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
