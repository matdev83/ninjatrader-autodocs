[Serializable]
[DataContract]
namespace Shared1
{
    public partial class Text : IMessage<Text>, IMessage, IEquatable<Text>, IDeepCloneable<Text>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<Text> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Key.
        /// </summary>
        [DataMember]
        public String Key { get; set; }
        /// <summary>
        /// Gets or sets the Text_.
        /// </summary>
        [DataMember]
        public String Text_ { get; set; }
        /// <summary>
        /// Gets or sets the Format.
        /// </summary>
        [DataMember]
        public String Format { get; set; }
        /// <summary>
        /// Gets or sets the Param.
        /// </summary>
        [DataMember]
        public RepeatedField<String> Param { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Text</returns>
        public Text Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Text</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Text other);
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
        /// <param name="other">Text</param>
        public Void MergeFrom(Text other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
