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
    /// PaymentCcInfo
    /// </summary>
    [DataContract(Name = "PaymentCcInfo")]
    public partial class PaymentCcInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCcInfo" /> class.
        /// </summary>
        /// <param name="approval">approval.</param>
        /// <param name="expMonth">expMonth.</param>
        /// <param name="expYear">expYear.</param>
        /// <param name="last4">last4.</param>
        /// <param name="numberEnc">numberEnc.</param>
        /// <param name="owner">owner.</param>
        /// <param name="avsStatus">avsStatus.</param>
        /// <param name="type">card type MasterCard, Visa...</param>
        public PaymentCcInfo(string approval = default(string), int expMonth = default(int), string expYear = default(string), string last4 = default(string), string numberEnc = default(string), string owner = default(string), string avsStatus = default(string), string type = default(string))
        {
            this.Approval = approval;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Last4 = last4;
            this.NumberEnc = numberEnc;
            this.Owner = owner;
            this.AvsStatus = avsStatus;
            this.Type = type;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Approval
        /// </summary>
        [DataMember(Name = "approval", EmitDefaultValue = false)]
        public string Approval { get; set; }

        /// <summary>
        /// Gets or Sets ExpMonth
        /// </summary>
        [DataMember(Name = "expMonth", EmitDefaultValue = false)]
        public int ExpMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpYear
        /// </summary>
        [DataMember(Name = "expYear", EmitDefaultValue = false)]
        public string ExpYear { get; set; }

        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        [DataMember(Name = "last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        /// Gets or Sets NumberEnc
        /// </summary>
        [DataMember(Name = "numberEnc", EmitDefaultValue = false)]
        public string NumberEnc { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets AvsStatus
        /// </summary>
        [DataMember(Name = "avsStatus", EmitDefaultValue = false)]
        public string AvsStatus { get; set; }

        /// <summary>
        /// card type MasterCard, Visa..
        /// </summary>
        /// <value>card type MasterCard, Visa..</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentCcInfo {\n");
            sb.Append("  Approval: ").Append(Approval).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  NumberEnc: ").Append(NumberEnc).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  AvsStatus: ").Append(AvsStatus).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
