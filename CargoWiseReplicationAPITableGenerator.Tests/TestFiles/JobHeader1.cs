namespace YourNamespace
{
	public class JobHeader
	{
		public Guid JH_PK { get; set; }
		public string JH_JobNum { get; set; }
		public string JH_TH_NKQuoteNumber { get; set; }
		public string JH_Status { get; set; }
		public DateTime JH_A_JOP { get; set; }
		public DateTime JH_A_JCL { get; set; }
		public double JH_LocalChargesCFX { get; set; }
		public double JH_AgentChargesCFX { get; set; }
		public string JH_LocalClientInvoicingStyle { get; set; }
		public int JH_UniqueJobInvoiceNumber { get; set; }
		public string JH_PaymentCollectionStatus { get; set; }
		public Guid JH_GB { get; set; }
		public Guid JH_GE { get; set; }
		public Guid JH_GC { get; set; }
		public DateTime JH_SystemCreateTimeUtc { get; set; }
		public string JH_SystemCreateUser { get; set; }
		public string JH_SystemLastEditUser { get; set; }
		public Guid JH_ProfitShareInvoice { get; set; }
		public DateTime JH_JobPlannedStartDate { get; set; }
		public int JH_JobBufferPercentOverride { get; set; }
		public Guid JH_OC_LocalBillingContact { get; set; }
		public DateTime JH_RevenueRecognizedDate { get; set; }
		public Guid JH_ParentID { get; set; }
		public Guid JH_JH_ParentJob { get; set; }
		public string JH_ProfitLossReasonCode { get; set; }
		public Guid JH_OA_LocalChargesAddr { get; set; }
		public Guid JH_OA_AgentCollectAddr { get; set; }
		public string JH_GS_NKRepSales { get; set; }
		public string JH_GS_NKRepOps { get; set; }
		public string JH_HeaderType { get; set; }
		public string JH_Name { get; set; }
		public string JH_Description { get; set; }
		public string JH_JobLocalReference { get; set; }
		public string JH_ARInvoiceReference { get; set; }
		public bool JH_IsProfitSharePosted { get; set; }
		public bool JH_SingleAgentsInvoicePerConsol { get; set; }
		public bool JH_RatingHasBeenRun { get; set; }
		public bool JH_ExcludeFromPeriodicRating { get; set; }
		public bool JH_IsValid { get; set; }
		public string JH_ParentTableCode { get; set; }
		public string JH_HoldReason { get; set; }
		public bool JH_IsActive { get; set; }
		public string JH_ClientContractNumber { get; set; }
		public Guid JH_GB_TaxBranch { get; set; }
		public string JH_Direction { get; set; }
		public bool JH_IsDisbursement { get; set; }
		public string JH_ContainerMode { get; set; }
		public string JH_TransportMode { get; set; }
	}
}
