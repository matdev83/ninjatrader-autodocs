[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class StrategyStopOrderParameters : IMessage<StrategyStopOrderParameters>, IMessage, IEquatable<StrategyStopOrderParameters>, IDeepCloneable<StrategyStopOrderParameters>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<StrategyStopOrderParameters> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the NodeIndex.
        /// </summary>
        [DataMember]
        public UInt32 NodeIndex { get; set; }
        /// <summary>
        /// Gets or sets the StopSide.
        /// </summary>
        [DataMember]
        public UInt32 StopSide { get; set; }
        /// <summary>
        /// Gets or sets the ReplenishOnPrimaryFill.
        /// </summary>
        [DataMember]
        public Boolean ReplenishOnPrimaryFill { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>StrategyStopOrderParameters</returns>
        public StrategyStopOrderParameters Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">StrategyStopOrderParameters</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(StrategyStopOrderParameters other);
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
        /// <param name="other">StrategyStopOrderParameters</param>
        public Void MergeFrom(StrategyStopOrderParameters other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
