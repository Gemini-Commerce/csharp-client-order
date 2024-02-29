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
    /// OrderListFulfillmentsResponse
    /// </summary>
    [DataContract(Name = "orderListFulfillmentsResponse")]
    public partial class OrderListFulfillmentsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderListFulfillmentsResponse" /> class.
        /// </summary>
        /// <param name="fulfillments">fulfillments.</param>
        public OrderListFulfillmentsResponse(List<OrderFulfillment> fulfillments = default(List<OrderFulfillment>))
        {
            this.Fulfillments = fulfillments;
        }

        /// <summary>
        /// Gets or Sets Fulfillments
        /// </summary>
        [DataMember(Name = "fulfillments", EmitDefaultValue = false)]
        public List<OrderFulfillment> Fulfillments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderListFulfillmentsResponse {\n");
            sb.Append("  Fulfillments: ").Append(Fulfillments).Append("\n");
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
