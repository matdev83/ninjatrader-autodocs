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
        public Collection<HotlistItem> HotlistItems { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ClearCache method.
        /// </summary>
        public Void ClearCache();
        /// <summary>
        /// GetHotlists method.
        /// </summary>
        /// <param name="callback">Action`3</param>
        public Void GetHotlists(Action<Hotlist[], ErrorCode, String> callback);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
