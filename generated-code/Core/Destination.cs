[Serializable]
[DataContract]
namespace Shared1
{
    public partial class Destination : IMessage<Destination>, IMessage, IEquatable<Destination>, IDeepCloneable<Destination>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<Destination> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the ApplePushNotif.
        /// </summary>
        [DataMember]
        public ApplePushNotif ApplePushNotif { get; set; }
        /// <summary>
        /// Gets or sets the GooglePushNotif.
        /// </summary>
        [DataMember]
        public GooglePushNotif GooglePushNotif { get; set; }
        /// <summary>
        /// Gets or sets the EmailNotif.
        /// </summary>
        [DataMember]
        public EmailNotif EmailNotif { get; set; }
        /// <summary>
        /// Gets or sets the SmsNotif.
        /// </summary>
        [DataMember]
        public SmsNotif SmsNotif { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Destination</returns>
        public Destination Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Destination</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Destination other);
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
        /// <param name="other">Destination</param>
        public Void MergeFrom(Destination other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
