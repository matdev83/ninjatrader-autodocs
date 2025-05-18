[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class OrderRequest : IMessage<OrderRequest>, IMessage, IEquatable<OrderRequest>, IDeepCloneable<OrderRequest>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<OrderRequest> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the RequestId.
        /// </summary>
        [DataMember]
        public UInt32 RequestId { get; set; }
        /// <summary>
        /// Gets or sets the NewOrder.
        /// </summary>
        [DataMember]
        public NewOrder NewOrder { get; set; }
        /// <summary>
        /// Gets or sets the ModifyOrder.
        /// </summary>
        [DataMember]
        public ModifyOrder ModifyOrder { get; set; }
        /// <summary>
        /// Gets or sets the CancelOrder.
        /// </summary>
        [DataMember]
        public CancelOrder CancelOrder { get; set; }
        /// <summary>
        /// Gets or sets the CancelAllOrders.
        /// </summary>
        [DataMember]
        public CancelAllOrders CancelAllOrders { get; set; }
        /// <summary>
        /// Gets or sets the SuspendOrder.
        /// </summary>
        [DataMember]
        public SuspendOrder SuspendOrder { get; set; }
        /// <summary>
        /// Gets or sets the ActivateOrder.
        /// </summary>
        [DataMember]
        public ActivateOrder ActivateOrder { get; set; }
        /// <summary>
        /// Gets or sets the ModifyUserAttributes.
        /// </summary>
        [DataMember]
        public ModifyUserAttributes ModifyUserAttributes { get; set; }
        /// <summary>
        /// Gets or sets the NewCompoundOrder.
        /// </summary>
        [DataMember]
        public NewCompoundOrder NewCompoundOrder { get; set; }
        /// <summary>
        /// Gets or sets the SyntheticLiquidate.
        /// </summary>
        [DataMember]
        public SyntheticLiquidate SyntheticLiquidate { get; set; }
        /// <summary>
        /// Gets or sets the SyntheticScratch.
        /// </summary>
        [DataMember]
        public SyntheticScratch SyntheticScratch { get; set; }
        /// <summary>
        /// Gets or sets the GoMarket.
        /// </summary>
        [DataMember]
        public GoMarket GoMarket { get; set; }
        /// <summary>
        /// Gets or sets the OnBehalfOfUser.
        /// </summary>
        [DataMember]
        public String OnBehalfOfUser { get; set; }
        /// <summary>
        /// Gets or sets the ClientRegulatoryAlgorithmId.
        /// </summary>
        [DataMember]
        public UInt32 ClientRegulatoryAlgorithmId { get; set; }
        /// <summary>
        /// Gets or sets the MifidAlgorithmId.
        /// </summary>
        [DataMember]
        public String MifidAlgorithmId { get; set; }
        /// <summary>
        /// Gets or sets the MifidAlgorithmIdType.
        /// </summary>
        [DataMember]
        public UInt32 MifidAlgorithmIdType { get; set; }
        /// <summary>
        /// Gets or sets the OverrideExecutionWithinFirmWithNore.
        /// </summary>
        [DataMember]
        public Boolean OverrideExecutionWithinFirmWithNore { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>OrderRequest</returns>
        public OrderRequest Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">OrderRequest</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(OrderRequest other);
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 GetHashCode();
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// WriteTo method.
        /// </summary>
        /// <param name="output">CodedOutputStream</param>
        public Void WriteTo(CodedOutputStream output);
        /// <summary>
        /// CalculateSize method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 CalculateSize();
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="other">OrderRequest</param>
        public Void MergeFrom(OrderRequest other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
