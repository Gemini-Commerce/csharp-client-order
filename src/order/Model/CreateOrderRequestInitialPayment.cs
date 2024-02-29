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
    /// CreateOrderRequestInitialPayment
    /// </summary>
    [DataContract(Name = "CreateOrderRequestInitialPayment")]
    public partial class CreateOrderRequestInitialPayment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestInitialPayment" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="additionalInfo">additionalInfo.</param>
        /// <param name="amount">amount.</param>
        /// <param name="ccInfo">ccInfo.</param>
        /// <param name="transaction">transaction.</param>
        public CreateOrderRequestInitialPayment(string code = default(string), string additionalInfo = default(string), OrderMoney amount = default(OrderMoney), PaymentCcInfo ccInfo = default(PaymentCcInfo), InitialPaymentInitialTransaction transaction = default(InitialPaymentInitialTransaction))
        {
            this.Code = code;
            this.AdditionalInfo = additionalInfo;
            this.Amount = amount;
            this.CcInfo = ccInfo;
            this.Transaction = transaction;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInfo
        /// </summary>
        [DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public OrderMoney Amount { get; set; }

        /// <summary>
        /// Gets or Sets CcInfo
        /// </summary>
        [DataMember(Name = "ccInfo", EmitDefaultValue = false)]
        public PaymentCcInfo CcInfo { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public InitialPaymentInitialTransaction Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateOrderRequestInitialPayment {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CcInfo: ").Append(CcInfo).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
