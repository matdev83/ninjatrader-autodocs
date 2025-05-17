[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class CollateralStatus : IMessage<CollateralStatus>, IMessage, IEquatable<CollateralStatus>, IDeepCloneable<CollateralStatus>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<CollateralStatus> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the SubscriptionId.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> SubscriptionId { get; set; }
        /// <summary>
        /// Gets or sets the IsSnapshot.
        /// </summary>
        [DataMember]
        public Boolean IsSnapshot { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int32 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public String Currency { get; set; }
        /// <summary>
        /// Gets or sets the TotalMargin.
        /// </summary>
        [DataMember]
        public Double TotalMargin { get; set; }
        /// <summary>
        /// Gets or sets the PurchasingPower.
        /// </summary>
        [DataMember]
        public Double PurchasingPower { get; set; }
        /// <summary>
        /// Gets or sets the Ote.
        /// </summary>
        [DataMember]
        public Double Ote { get; set; }
        /// <summary>
        /// Gets or sets the Mvo.
        /// </summary>
        [DataMember]
        public Double Mvo { get; set; }
        /// <summary>
        /// Gets or sets the Mvf.
        /// </summary>
        [DataMember]
        public Double Mvf { get; set; }
        /// <summary>
        /// Gets or sets the MarginCredit.
        /// </summary>
        [DataMember]
        public Double MarginCredit { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>CollateralStatus</returns>
        public CollateralStatus Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">CollateralStatus</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(CollateralStatus other);
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
        /// <param name="other">CollateralStatus</param>
        public Void MergeFrom(CollateralStatus other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
