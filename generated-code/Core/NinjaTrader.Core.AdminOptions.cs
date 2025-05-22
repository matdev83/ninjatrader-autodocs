[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class AdminOptions : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DisableUI.
        /// </summary>
        [DataMember]
        public bool DisableUI { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfWorkerThreads.
        /// </summary>
        [DataMember]
        public int NumberOfWorkerThreads { get; set; }
        /// <summary>
        /// Gets or sets the RecordSimFeedData.
        /// </summary>
        [DataMember]
        public bool RecordSimFeedData { get; set; }
        /// <summary>
        /// Gets or sets the UseLegacyCompiler.
        /// </summary>
        [DataMember]
        public bool UseLegacyCompiler { get; set; }
        /// <summary>
        /// Gets or sets the ChartCrosshairType.
        /// </summary>
        [DataMember]
        public ChartCrosshairType ChartCrosshairType { get; set; }
        /// <summary>
        /// Gets or sets the ChartPerformanceOutput.
        /// </summary>
        [DataMember]
        public bool ChartPerformanceOutput { get; set; }
        /// <summary>
        /// Gets or sets the ChartRefreshInterval.
        /// </summary>
        [DataMember]
        public int ChartRefreshInterval { get; set; }
        /// <summary>
        /// Gets or sets the ChartForceSoftwareRendering.
        /// </summary>
        [DataMember]
        public bool ChartForceSoftwareRendering { get; set; }
        /// <summary>
        /// Gets or sets the ChartShowThumbnails.
        /// </summary>
        [DataMember]
        public bool ChartShowThumbnails { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels.
        /// </summary>
        [DataMember]
        public TraceLevels TraceLevels { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="options">NinjaTrader.Core.AdminOptions</param>
        public void CopyTo(NinjaTrader.Core.AdminOptions options)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
