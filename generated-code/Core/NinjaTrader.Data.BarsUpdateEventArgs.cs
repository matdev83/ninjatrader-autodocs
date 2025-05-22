[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsUpdateEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsSeries.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsSeries BarsSeries { get; set; }
        /// <summary>
        /// Gets or sets the MaxIndex.
        /// </summary>
        [DataMember]
        public int MaxIndex { get; set; }
        /// <summary>
        /// Gets or sets the MinIndex.
        /// </summary>
        [DataMember]
        public int MinIndex { get; set; }
        #endregion
        #region Methods
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
