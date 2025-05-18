[Serializable]
[DataContract]
namespace NinjaTrader.ServerAtm
{
    public partial class UserAtmDictionary
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public Int32 Count { get; set; }
        /// <summary>
        /// Gets or sets the Instance.
        /// </summary>
        [DataMember]
        public UserAtmDictionary Instance { get; set; }
        /// <summary>
        /// Gets or sets the Keys.
        /// </summary>
        [DataMember]
        public ICollection<String> Keys { get; set; }
        /// <summary>
        /// Gets or sets the LastUpdated.
        /// </summary>
        [DataMember]
        public DateTime LastUpdated { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public List<ServerAtmStrategy> Item { get; set; }
        /// <summary>
        /// Gets or sets the UpdatedAt.
        /// </summary>
        [DataMember]
        public Int64 UpdatedAt { get; set; }
        /// <summary>
        /// Gets or sets the Values.
        /// </summary>
        [DataMember]
        public ICollection<List<ServerAtmStrategy>> Values { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="key">String</param>
        /// <param name="value">List`1</param>
        public Void Add(String key, List<ServerAtmStrategy> value);
        /// <summary>
        /// Clear method.
        /// </summary>
        public Void Clear();
        /// <summary>
        /// ContainsKey method.
        /// </summary>
        /// <param name="key">String</param>
        /// <returns>Boolean</returns>
        public Boolean ContainsKey(String key);
        /// <summary>
        /// FromJson method.
        /// </summary>
        /// <param name="jsonString">String</param>
        public Void FromJson(String jsonString);
        /// <summary>
        /// RaiseUpdateEvent method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="templateName">String</param>
        public Void RaiseUpdateEvent(Object sender, String templateName);
        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="key">String</param>
        /// <returns>Boolean</returns>
        public Boolean Remove(String key);
        /// <summary>
        /// RetrieveUserAtmTemplates method.
        /// </summary>
        /// <param name="accessToken">String</param>
        /// <param name="userId">Int64</param>
        /// <param name="user">String</param>
        /// <returns>Task</returns>
        public Task RetrieveUserAtmTemplates(String accessToken, Int64 userId, String user);
        /// <summary>
        /// ToJson method.
        /// </summary>
        /// <param name="key">String</param>
        /// <returns>JsonObject</returns>
        public JsonObject ToJson(String key);
        /// <summary>
        /// ToJson method.
        /// </summary>
        /// <returns>JsonObject</returns>
        public JsonObject ToJson();
        /// <summary>
        /// TryGetValue method.
        /// </summary>
        /// <param name="key">String</param>
        /// <param name="value">List`1&</param>
        /// <returns>Boolean</returns>
        public Boolean TryGetValue(String key, List`1& value);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
