[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Message : NinjaTrader.Cbi.ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Message> All { get; set; }
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
        public bool Enabled { get; set; }
        /// <summary>
        /// Gets or sets the From.
        /// </summary>
        [DataMember]
        public System.DateTime From { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public System.Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the IsNTBrokerage.
        /// </summary>
        [DataMember]
        public bool IsNTBrokerage { get; set; }
        /// <summary>
        /// Gets or sets the License.
        /// </summary>
        [DataMember]
        public string License { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public string Text { get; set; }
        /// <summary>
        /// Gets or sets the To.
        /// </summary>
        [DataMember]
        public System.DateTime To { get; set; }
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [DataMember]
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public string Version { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>NinjaTrader.Cbi.Message</returns>
        public NinjaTrader.Cbi.Message Get(string id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// LoadAll method.
        /// </summary>
        public void LoadAll()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Remove method.
        /// </summary>
        public void Remove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">bool</param>
        public void SnapShotPersist(bool updateVersion)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
