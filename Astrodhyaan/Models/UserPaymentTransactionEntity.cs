using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Astrodhyaan.Models
{

    [DataContract(IsReference = true)]
    public partial class UserPaymentTransactionEntity
    {
        
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long UserId { get; set; }
        [DataMember]
        public string TransactionType { get; set; }
        [DataMember]
        public string TransactionId { get; set; }
        [DataMember]
        public string PaymentMode { get; set; }
        [DataMember]
        public string CouponCode { get; set; }
        [DataMember]
        public long LoyaltyPoints { get; set; }
        [DataMember]
        public decimal? OfferDiscountPercent { get; set; }
        [DataMember]
        public string CardNumber { get; set; }
        [DataMember]
        public string CardName { get; set; }
        [DataMember]
        public string CardExpiry { get; set; }
        [DataMember]
        public long CardCVV { get; set; }
        [DataMember]
        public string BankName { get; set; }
        [DataMember]
        public string WalletType { get; set; }
        [DataMember]
        public string UPIId { get; set; }
        [DataMember]
        public string QRCode { get; set; }
        [DataMember]
        public string EMIType { get; set; }
        [DataMember]
        public string PayLaterType { get; set; }
        [DataMember]
        public decimal? DiscountAmount { get; set; }        
        [DataMember]
        public string TransactionRefId { get; set; }
        [DataMember]
        public decimal? TransactionAmount { get; set; }
        [DataMember]
        public decimal? TransactionGST { get; set; }
        [DataMember]
        public decimal? TransactionPayableAmount { get; set; }
        [DataMember]
        public DateTime? TransactionDateTime { get; set; }
        [DataMember]
        public string TransactionStatus { get; set; }
        [DataMember]
        public string TransactionRemarks { get; set; }
        [DataMember]
        public string TransactionRefundStatus { get; set; }
        [DataMember]
        public decimal? TransactionRefundAmount { get; set; }
        [DataMember]
        public decimal? TransactionRefundGST { get; set; }
        [DataMember]
        public string TransactionRefundRemarks { get; set; }
        [DataMember]
        public DateTime? TransactionRefundDateTime { get; set; }
    }
}
