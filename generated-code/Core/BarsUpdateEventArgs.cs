[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsUpdateEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsSeries.
        /// </summary>
        [DataMember]
        public BarsSeries BarsSeries { get; set; }
        /// <summary>
        /// Gets or sets the MaxIndex.
        /// </summary>
        [DataMember]
        public Int32 MaxIndex { get; set; }
        /// <summary>
        /// Gets or sets the MinIndex.
        /// </summary>
        [DataMember]
        public Int32 MinIndex { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
