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
    /// OrderDataShipmentInfo
    /// </summary>
    [DataContract(Name = "OrderDataShipmentInfo")]
    public partial class OrderDataShipmentInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDataShipmentInfo" /> class.
        /// </summary>
        /// <param name="reference">reference.</param>
        /// <param name="code">code.</param>
        /// <param name="method">method.</param>
        /// <param name="title">title.</param>
        /// <param name="additionalInfo">additionalInfo.</param>
        /// <param name="amount">amount.</param>
        /// <param name="fee">fee.</param>
        /// <param name="vatAmount">vatAmount.</param>
        /// <param name="vatPercentage">vatPercentage.</param>
        /// <param name="vatInaccurate">vatInaccurate.</param>
        /// <param name="vatCalculated">vatCalculated.</param>
        /// <param name="grn">grn.</param>
        /// <param name="fromAddress">fromAddress.</param>
        /// <param name="returnAddress">returnAddress.</param>
        public OrderDataShipmentInfo(string reference = default(string), string code = default(string), string method = default(string), string title = default(string), string additionalInfo = default(string), OrderMoney amount = default(OrderMoney), OrderMoney fee = default(OrderMoney), OrderMoney vatAmount = default(OrderMoney), float vatPercentage = default(float), bool vatInaccurate = default(bool), bool vatCalculated = default(bool), string grn = default(string), OrderPostalAddress fromAddress = default(OrderPostalAddress), OrderPostalAddress returnAddress = default(OrderPostalAddress))
        {
            this.Reference = reference;
            this.Code = code;
            this.Method = method;
            this.Title = title;
            this.AdditionalInfo = additionalInfo;
            this.Amount = amount;
            this.Fee = fee;
            this.VatAmount = vatAmount;
            this.VatPercentage = vatPercentage;
            this.VatInaccurate = vatInaccurate;
            this.VatCalculated = vatCalculated;
            this.Grn = grn;
            this.FromAddress = fromAddress;
            this.ReturnAddress = returnAddress;
        }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

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
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public OrderMoney Fee { get; set; }

        /// <summary>
        /// Gets or Sets VatAmount
        /// </summary>
        [DataMember(Name = "vatAmount", EmitDefaultValue = false)]
        public OrderMoney VatAmount { get; set; }

        /// <summary>
        /// Gets or Sets VatPercentage
        /// </summary>
        [DataMember(Name = "vatPercentage", EmitDefaultValue = false)]
        public float VatPercentage { get; set; }

        /// <summary>
        /// Gets or Sets VatInaccurate
        /// </summary>
        [DataMember(Name = "vatInaccurate", EmitDefaultValue = true)]
        public bool VatInaccurate { get; set; }

        /// <summary>
        /// Gets or Sets VatCalculated
        /// </summary>
        [DataMember(Name = "vatCalculated", EmitDefaultValue = true)]
        public bool VatCalculated { get; set; }

        /// <summary>
        /// Gets or Sets Grn
        /// </summary>
        [DataMember(Name = "grn", EmitDefaultValue = false)]
        public string Grn { get; set; }

        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name = "fromAddress", EmitDefaultValue = false)]
        public OrderPostalAddress FromAddress { get; set; }

        /// <summary>
        /// Gets or Sets ReturnAddress
        /// </summary>
        [DataMember(Name = "returnAddress", EmitDefaultValue = false)]
        public OrderPostalAddress ReturnAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDataShipmentInfo {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  VatAmount: ").Append(VatAmount).Append("\n");
            sb.Append("  VatPercentage: ").Append(VatPercentage).Append("\n");
            sb.Append("  VatInaccurate: ").Append(VatInaccurate).Append("\n");
            sb.Append("  VatCalculated: ").Append(VatCalculated).Append("\n");
            sb.Append("  Grn: ").Append(Grn).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
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
