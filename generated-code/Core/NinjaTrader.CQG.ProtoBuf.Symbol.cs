[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class Symbol : IMessage<Symbol>, IMessage, IEquatable<Symbol>, IDeepCloneable<Symbol>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<Symbol> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public String Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the CfiCode.
        /// </summary>
        [DataMember]
        public String CfiCode { get; set; }
        /// <summary>
        /// Gets or sets the HasChildSymbols.
        /// </summary>
        [DataMember]
        public Boolean HasChildSymbols { get; set; }
        /// <summary>
        /// Gets or sets the ContractMetadata.
        /// </summary>
        [DataMember]
        public ContractMetadata ContractMetadata { get; set; }
        /// <summary>
        /// Gets or sets the Deleted.
        /// </summary>
        [DataMember]
        public Boolean Deleted { get; set; }
        /// <summary>
        /// Gets or sets the LastTradingDate.
        /// </summary>
        [DataMember]
        public Int64 LastTradingDate { get; set; }
        /// <summary>
        /// Gets or sets the MaturityMonthYear.
        /// </summary>
        [DataMember]
        public String MaturityMonthYear { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentGroupName.
        /// </summary>
        [DataMember]
        public String InstrumentGroupName { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Symbol</returns>
        public Symbol Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Symbol</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Symbol other);
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
        /// <param name="other">Symbol</param>
        public Void MergeFrom(Symbol other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
