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
        public int Count { get; set; }
        /// <summary>
        /// Gets or sets the Instance.
        /// </summary>
        [DataMember]
        public NinjaTrader.ServerAtm.UserAtmDictionary Instance { get; set; }
        /// <summary>
        /// Gets or sets the Keys.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.ICollection<string> Keys { get; set; }
        /// <summary>
        /// Gets or sets the LastUpdated.
        /// </summary>
        [DataMember]
        public System.DateTime LastUpdated { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.ServerAtm.ServerAtmStrategy> Item { get; set; }
        /// <summary>
        /// Gets or sets the UpdatedAt.
        /// </summary>
        [DataMember]
        public long UpdatedAt { get; set; }
        /// <summary>
        /// Gets or sets the Values.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.ICollection<System.Collections.Generic.List<NinjaTrader.ServerAtm.ServerAtmStrategy>> Values { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="value">System.Collections.Generic.List<NinjaTrader.ServerAtm.ServerAtmStrategy></param>
        public void Add(string key, System.Collections.Generic.List<NinjaTrader.ServerAtm.ServerAtmStrategy> value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Clear method.
        /// </summary>
        public void Clear()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ContainsKey method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>bool</returns>
        public bool ContainsKey(string key)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FromJson method.
        /// </summary>
        /// <param name="jsonString">string</param>
        public void FromJson(string jsonString)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RaiseUpdateEvent method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="templateName">string</param>
        public void RaiseUpdateEvent(object sender, string templateName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>bool</returns>
        public bool Remove(string key)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RetrieveUserAtmTemplates method.
        /// </summary>
        /// <param name="accessToken">string</param>
        /// <param name="userId">long</param>
        /// <param name="user">string</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task RetrieveUserAtmTemplates(string accessToken, long userId, string user)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToJson method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>System.Text.Json.Nodes.JsonObject</returns>
        public System.Text.Json.Nodes.JsonObject ToJson(string key)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToJson method.
        /// </summary>
        /// <returns>System.Text.Json.Nodes.JsonObject</returns>
        public System.Text.Json.Nodes.JsonObject ToJson()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TryGetValue method.
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="value">System.Collections.Generic.List`1<NinjaTrader.ServerAtm.ServerAtmStrategy>&</param>
        /// <returns>bool</returns>
        public bool TryGetValue(string key, System.Collections.Generic.List`1<NinjaTrader.ServerAtm.ServerAtmStrategy>& value)
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
