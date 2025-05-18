[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class PurchaseAndSalesGroup : IMessage<PurchaseAndSalesGroup>, IMessage, IEquatable<PurchaseAndSalesGroup>, IDeepCloneable<PurchaseAndSalesGroup>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<PurchaseAndSalesGroup> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int32 Id { get; set; }
        /// <summary>
        /// Gets or sets the RealizedProfitLoss.
        /// </summary>
        [DataMember]
        public Double RealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the MatchedTrade.
        /// </summary>
        [DataMember]
        public RepeatedField<MatchedTrade> MatchedTrade { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>PurchaseAndSalesGroup</returns>
        public PurchaseAndSalesGroup Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">PurchaseAndSalesGroup</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(PurchaseAndSalesGroup other);
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
        /// <param name="other">PurchaseAndSalesGroup</param>
        public Void MergeFrom(PurchaseAndSalesGroup other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
