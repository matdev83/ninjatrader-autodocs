[Serializable]
[DataContract]
namespace Shared1
{
    public partial class GooglePushNotif : IMessage<GooglePushNotif>, IMessage, IEquatable<GooglePushNotif>, IDeepCloneable<GooglePushNotif>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<GooglePushNotif> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the RegistrationToken.
        /// </summary>
        [DataMember]
        public String RegistrationToken { get; set; }
        /// <summary>
        /// Gets or sets the SenderId.
        /// </summary>
        [DataMember]
        public String SenderId { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>GooglePushNotif</returns>
        public GooglePushNotif Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">GooglePushNotif</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(GooglePushNotif other);
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
        /// <param name="other">GooglePushNotif</param>
        public Void MergeFrom(GooglePushNotif other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
