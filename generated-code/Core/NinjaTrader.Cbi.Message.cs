[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Message : ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<Message> All { get; set; }
        /// <summary>
        /// Gets or sets the Broker.
        /// </summary>
        [DataMember]
        public Provider Broker { get; set; }
        /// <summary>
        /// Gets or sets the Client.
        /// </summary>
        [DataMember]
        public MessageClientType Client { get; set; }
        /// <summary>
        /// Gets or sets the Condition.
        /// </summary>
        [DataMember]
        public ConditionType Condition { get; set; }
        /// <summary>
        /// Gets or sets the Enabled.
        /// </summary>
        [DataMember]
        public Boolean Enabled { get; set; }
        /// <summary>
        /// Gets or sets the From.
        /// </summary>
        [DataMember]
        public DateTime From { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the IsNTBrokerage.
        /// </summary>
        [DataMember]
        public Boolean IsNTBrokerage { get; set; }
        /// <summary>
        /// Gets or sets the License.
        /// </summary>
        [DataMember]
        public String License { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public String Text { get; set; }
        /// <summary>
        /// Gets or sets the To.
        /// </summary>
        [DataMember]
        public DateTime To { get; set; }
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [DataMember]
        public String Url { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public String Version { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="id">String</param>
        /// <returns>Message</returns>
        public Message Get(String id);
        /// <summary>
        /// LoadAll method.
        /// </summary>
        public Void LoadAll();
        /// <summary>
        /// Remove method.
        /// </summary>
        public Void Remove();
        /// <summary>
        /// Save method.
        /// </summary>
        public Void Save();
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
