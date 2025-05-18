[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class Balance : IMessage<Balance>, IMessage, IEquatable<Balance>, IDeepCloneable<Balance>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<Balance> Parser { get; set; }
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
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int32 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public Int64 StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public String Currency { get; set; }
        /// <summary>
        /// Gets or sets the Balance_.
        /// </summary>
        [DataMember]
        public Double Balance_ { get; set; }
        /// <summary>
        /// Gets or sets the TotalValue.
        /// </summary>
        [DataMember]
        public Double TotalValue { get; set; }
        /// <summary>
        /// Gets or sets the Ote.
        /// </summary>
        [DataMember]
        public Double Ote { get; set; }
        /// <summary>
        /// Gets or sets the Upl.
        /// </summary>
        [DataMember]
        public Double Upl { get; set; }
        /// <summary>
        /// Gets or sets the Mvo.
        /// </summary>
        [DataMember]
        public Double Mvo { get; set; }
        /// <summary>
        /// Gets or sets the CashExcess.
        /// </summary>
        [DataMember]
        public Double CashExcess { get; set; }
        /// <summary>
        /// Gets or sets the Collateral.
        /// </summary>
        [DataMember]
        public Double Collateral { get; set; }
        /// <summary>
        /// Gets or sets the InitialMargin.
        /// </summary>
        [DataMember]
        public Double InitialMargin { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Balance</returns>
        public Balance Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Balance</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Balance other);
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
        /// <param name="other">Balance</param>
        public Void MergeFrom(Balance other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
