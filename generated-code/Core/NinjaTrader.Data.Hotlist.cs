[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class Hotlist
    {
        #region Properties
        /// <summary>
        /// Gets or sets the HotlistItems.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Data.HotlistItem> HotlistItems { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ClearCache method.
        /// </summary>
        public void ClearCache()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetHotlists method.
        /// </summary>
        /// <param name="callback">System.Action<NinjaTrader.Data.Hotlist[], ErrorCode, string></param>
        public void GetHotlists(System.Action<NinjaTrader.Data.Hotlist[], ErrorCode, string> callback)
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
