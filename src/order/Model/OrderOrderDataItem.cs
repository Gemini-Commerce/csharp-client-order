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
    /// OrderOrderDataItem
    /// </summary>
    [DataContract(Name = "orderOrderDataItem")]
    public partial class OrderOrderDataItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderOrderDataItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="productGrn">productGrn.</param>
        /// <param name="qtyOrdered">qtyOrdered.</param>
        /// <param name="freeQty">freeQty.</param>
        /// <param name="qtyCommitted">qtyCommitted.</param>
        /// <param name="unitSalePrice">unitSalePrice.</param>
        /// <param name="unitListPrice">unitListPrice.</param>
        /// <param name="unitBasePrice">unitBasePrice.</param>
        /// <param name="unitVatAmount">unitVatAmount.</param>
        /// <param name="rowSalePrice">rowSalePrice.</param>
        /// <param name="rowListPrice">rowListPrice.</param>
        /// <param name="rowVatAmount">rowVatAmount.</param>
        /// <param name="discountAmount">discountAmount.</param>
        /// <param name="rowBasePrice">rowBasePrice.</param>
        /// <param name="unitCustomPrice">unitCustomPrice.</param>
        /// <param name="rowCustomPrice">rowCustomPrice.</param>
        /// <param name="vatPercentage">vatPercentage.</param>
        /// <param name="vatInaccurate">vatInaccurate.</param>
        /// <param name="vatCalculated">vatCalculated.</param>
        /// <param name="productName">productName.</param>
        /// <param name="productCode">productCode.</param>
        /// <param name="productSku">productSku.</param>
        /// <param name="productOptions">productOptions.</param>
        /// <param name="productImg">productImg.</param>
        /// <param name="productData">productData.</param>
        /// <param name="shipmentInfoReference">shipmentInfoReference.</param>
        /// <param name="promotionGrn">promotionGrn.</param>
        /// <param name="productIsVirtual">productIsVirtual.</param>
        /// <param name="productConfiguration">productConfiguration.</param>
        public OrderOrderDataItem(string id = default(string), string productGrn = default(string), long qtyOrdered = default(long), long freeQty = default(long), long qtyCommitted = default(long), OrderMoney unitSalePrice = default(OrderMoney), OrderMoney unitListPrice = default(OrderMoney), OrderMoney unitBasePrice = default(OrderMoney), OrderMoney unitVatAmount = default(OrderMoney), OrderMoney rowSalePrice = default(OrderMoney), OrderMoney rowListPrice = default(OrderMoney), OrderMoney rowVatAmount = default(OrderMoney), OrderMoney discountAmount = default(OrderMoney), OrderMoney rowBasePrice = default(OrderMoney), OrderMoney unitCustomPrice = default(OrderMoney), OrderMoney rowCustomPrice = default(OrderMoney), float vatPercentage = default(float), bool vatInaccurate = default(bool), bool vatCalculated = default(bool), string productName = default(string), string productCode = default(string), string productSku = default(string), string productOptions = default(string), string productImg = default(string), string productData = default(string), string shipmentInfoReference = default(string), List<string> promotionGrn = default(List<string>), bool productIsVirtual = default(bool), List<ItemProductConfigurationStep> productConfiguration = default(List<ItemProductConfigurationStep>))
        {
            this.Id = id;
            this.ProductGrn = productGrn;
            this.QtyOrdered = qtyOrdered;
            this.FreeQty = freeQty;
            this.QtyCommitted = qtyCommitted;
            this.UnitSalePrice = unitSalePrice;
            this.UnitListPrice = unitListPrice;
            this.UnitBasePrice = unitBasePrice;
            this.UnitVatAmount = unitVatAmount;
            this.RowSalePrice = rowSalePrice;
            this.RowListPrice = rowListPrice;
            this.RowVatAmount = rowVatAmount;
            this.DiscountAmount = discountAmount;
            this.RowBasePrice = rowBasePrice;
            this.UnitCustomPrice = unitCustomPrice;
            this.RowCustomPrice = rowCustomPrice;
            this.VatPercentage = vatPercentage;
            this.VatInaccurate = vatInaccurate;
            this.VatCalculated = vatCalculated;
            this.ProductName = productName;
            this.ProductCode = productCode;
            this.ProductSku = productSku;
            this.ProductOptions = productOptions;
            this.ProductImg = productImg;
            this.ProductData = productData;
            this.ShipmentInfoReference = shipmentInfoReference;
            this.PromotionGrn = promotionGrn;
            this.ProductIsVirtual = productIsVirtual;
            this.ProductConfiguration = productConfiguration;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProductGrn
        /// </summary>
        [DataMember(Name = "productGrn", EmitDefaultValue = false)]
        public string ProductGrn { get; set; }

        /// <summary>
        /// Gets or Sets QtyOrdered
        /// </summary>
        [DataMember(Name = "qtyOrdered", EmitDefaultValue = false)]
        public long QtyOrdered { get; set; }

        /// <summary>
        /// Gets or Sets FreeQty
        /// </summary>
        [DataMember(Name = "freeQty", EmitDefaultValue = false)]
        public long FreeQty { get; set; }

        /// <summary>
        /// Gets or Sets QtyCommitted
        /// </summary>
        [DataMember(Name = "qtyCommitted", EmitDefaultValue = false)]
        public long QtyCommitted { get; set; }

        /// <summary>
        /// Gets or Sets UnitSalePrice
        /// </summary>
        [DataMember(Name = "unitSalePrice", EmitDefaultValue = false)]
        public OrderMoney UnitSalePrice { get; set; }

        /// <summary>
        /// Gets or Sets UnitListPrice
        /// </summary>
        [DataMember(Name = "unitListPrice", EmitDefaultValue = false)]
        public OrderMoney UnitListPrice { get; set; }

        /// <summary>
        /// Gets or Sets UnitBasePrice
        /// </summary>
        [DataMember(Name = "unitBasePrice", EmitDefaultValue = false)]
        public OrderMoney UnitBasePrice { get; set; }

        /// <summary>
        /// Gets or Sets UnitVatAmount
        /// </summary>
        [DataMember(Name = "unitVatAmount", EmitDefaultValue = false)]
        public OrderMoney UnitVatAmount { get; set; }

        /// <summary>
        /// Gets or Sets RowSalePrice
        /// </summary>
        [DataMember(Name = "rowSalePrice", EmitDefaultValue = false)]
        public OrderMoney RowSalePrice { get; set; }

        /// <summary>
        /// Gets or Sets RowListPrice
        /// </summary>
        [DataMember(Name = "rowListPrice", EmitDefaultValue = false)]
        public OrderMoney RowListPrice { get; set; }

        /// <summary>
        /// Gets or Sets RowVatAmount
        /// </summary>
        [DataMember(Name = "rowVatAmount", EmitDefaultValue = false)]
        public OrderMoney RowVatAmount { get; set; }

        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name = "discountAmount", EmitDefaultValue = false)]
        public OrderMoney DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets RowBasePrice
        /// </summary>
        [DataMember(Name = "rowBasePrice", EmitDefaultValue = false)]
        public OrderMoney RowBasePrice { get; set; }

        /// <summary>
        /// Gets or Sets UnitCustomPrice
        /// </summary>
        [DataMember(Name = "unitCustomPrice", EmitDefaultValue = false)]
        public OrderMoney UnitCustomPrice { get; set; }

        /// <summary>
        /// Gets or Sets RowCustomPrice
        /// </summary>
        [DataMember(Name = "rowCustomPrice", EmitDefaultValue = false)]
        public OrderMoney RowCustomPrice { get; set; }

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
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name = "productName", EmitDefaultValue = false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name = "productCode", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets ProductSku
        /// </summary>
        [DataMember(Name = "productSku", EmitDefaultValue = false)]
        public string ProductSku { get; set; }

        /// <summary>
        /// Gets or Sets ProductOptions
        /// </summary>
        [DataMember(Name = "productOptions", EmitDefaultValue = false)]
        public string ProductOptions { get; set; }

        /// <summary>
        /// Gets or Sets ProductImg
        /// </summary>
        [DataMember(Name = "productImg", EmitDefaultValue = false)]
        public string ProductImg { get; set; }

        /// <summary>
        /// Gets or Sets ProductData
        /// </summary>
        [DataMember(Name = "productData", EmitDefaultValue = false)]
        public string ProductData { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentInfoReference
        /// </summary>
        [DataMember(Name = "shipmentInfoReference", EmitDefaultValue = false)]
        public string ShipmentInfoReference { get; set; }

        /// <summary>
        /// Gets or Sets PromotionGrn
        /// </summary>
        [DataMember(Name = "promotionGrn", EmitDefaultValue = false)]
        public List<string> PromotionGrn { get; set; }

        /// <summary>
        /// Gets or Sets ProductIsVirtual
        /// </summary>
        [DataMember(Name = "productIsVirtual", EmitDefaultValue = true)]
        public bool ProductIsVirtual { get; set; }

        /// <summary>
        /// Gets or Sets ProductConfiguration
        /// </summary>
        [DataMember(Name = "productConfiguration", EmitDefaultValue = false)]
        public List<ItemProductConfigurationStep> ProductConfiguration { get; set; }

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
            sb.Append("class OrderOrderDataItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductGrn: ").Append(ProductGrn).Append("\n");
            sb.Append("  QtyOrdered: ").Append(QtyOrdered).Append("\n");
            sb.Append("  FreeQty: ").Append(FreeQty).Append("\n");
            sb.Append("  QtyCommitted: ").Append(QtyCommitted).Append("\n");
            sb.Append("  UnitSalePrice: ").Append(UnitSalePrice).Append("\n");
            sb.Append("  UnitListPrice: ").Append(UnitListPrice).Append("\n");
            sb.Append("  UnitBasePrice: ").Append(UnitBasePrice).Append("\n");
            sb.Append("  UnitVatAmount: ").Append(UnitVatAmount).Append("\n");
            sb.Append("  RowSalePrice: ").Append(RowSalePrice).Append("\n");
            sb.Append("  RowListPrice: ").Append(RowListPrice).Append("\n");
            sb.Append("  RowVatAmount: ").Append(RowVatAmount).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  RowBasePrice: ").Append(RowBasePrice).Append("\n");
            sb.Append("  UnitCustomPrice: ").Append(UnitCustomPrice).Append("\n");
            sb.Append("  RowCustomPrice: ").Append(RowCustomPrice).Append("\n");
            sb.Append("  VatPercentage: ").Append(VatPercentage).Append("\n");
            sb.Append("  VatInaccurate: ").Append(VatInaccurate).Append("\n");
            sb.Append("  VatCalculated: ").Append(VatCalculated).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ProductSku: ").Append(ProductSku).Append("\n");
            sb.Append("  ProductOptions: ").Append(ProductOptions).Append("\n");
            sb.Append("  ProductImg: ").Append(ProductImg).Append("\n");
            sb.Append("  ProductData: ").Append(ProductData).Append("\n");
            sb.Append("  ShipmentInfoReference: ").Append(ShipmentInfoReference).Append("\n");
            sb.Append("  PromotionGrn: ").Append(PromotionGrn).Append("\n");
            sb.Append("  ProductIsVirtual: ").Append(ProductIsVirtual).Append("\n");
            sb.Append("  ProductConfiguration: ").Append(ProductConfiguration).Append("\n");
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
