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
    /// OrderRefund
    /// </summary>
    [DataContract(Name = "orderRefund")]
    public partial class OrderRefund : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRefund" /> class.
        /// </summary>
        /// <param name="paymentId">paymentId.</param>
        /// <param name="id">id.</param>
        /// <param name="items">items.</param>
        /// <param name="amounts">amounts.</param>
        /// <param name="note">note.</param>
        /// <param name="additionalInfo">additionalInfo.</param>
        /// <param name="transactionIds">transactionIds.</param>
        public OrderRefund(string paymentId = default(string), string id = default(string), List<OrderRefundItem> items = default(List<OrderRefundItem>), List<OrderRefundAmount> amounts = default(List<OrderRefundAmount>), string note = default(string), string additionalInfo = default(string), List<string> transactionIds = default(List<string>))
        {
            this.PaymentId = paymentId;
            this.Id = id;
            this.Items = items;
            this.Amounts = amounts;
            this.Note = note;
            this.AdditionalInfo = additionalInfo;
            this.TransactionIds = transactionIds;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PaymentId
        /// </summary>
        [DataMember(Name = "paymentId", EmitDefaultValue = false)]
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<OrderRefundItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets Amounts
        /// </summary>
        [DataMember(Name = "amounts", EmitDefaultValue = false)]
        public List<OrderRefundAmount> Amounts { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInfo
        /// </summary>
        [DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or Sets TransactionIds
        /// </summary>
        [DataMember(Name = "transactionIds", EmitDefaultValue = false)]
        public List<string> TransactionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderRefund {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Amounts: ").Append(Amounts).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  TransactionIds: ").Append(TransactionIds).Append("\n");
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
