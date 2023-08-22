using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class RiyadBankMigsResponse
{
    public int Id { get; set; }

    public int RiyadBankMigsRequestId { get; set; }

    public string? Vpc3Dseci { get; set; }

    public string? Vpc3Dsxid { get; set; }

    public string? Vpc3Dsenrolled { get; set; }

    public string? Vpc3Dsstatus { get; set; }

    public string? AvsresultCode { get; set; }

    public string? AcqAvsrespCode { get; set; }

    public string? AcqCscrespCode { get; set; }

    public string? AcqResponseCode { get; set; }

    public decimal Amount { get; set; }

    public string? AuthorizeId { get; set; }

    public string? BatchNo { get; set; }

    public string? CscresultCode { get; set; }

    public string? Card { get; set; }

    public string? CardNum { get; set; }

    public string? Command { get; set; }

    public string? Locale { get; set; }

    public string? MerchTxnRef { get; set; }

    public string? MerchantId { get; set; }

    public string? Message { get; set; }

    public string? OrderInfo { get; set; }

    public string? ReceiptNo { get; set; }

    public string? SecureHash { get; set; }

    public string? SecureHashType { get; set; }

    public string? TransactionNo { get; set; }

    public string? TxnResponseCode { get; set; }

    public string? VerSecurityLevel { get; set; }

    public string? VerStatus { get; set; }

    public string? VerToken { get; set; }

    public string? VerType { get; set; }

    public string? Version { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsCancelled { get; set; }

    public DateTime? CancelationDate { get; set; }

    public string? CancelledBy { get; set; }

    public virtual RiyadBankMigsRequest RiyadBankMigsRequest { get; set; } = null!;
}
