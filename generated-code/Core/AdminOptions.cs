[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class AdminOptions : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DisableUI.
        /// </summary>
        [DataMember]
        public Boolean DisableUI { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfWorkerThreads.
        /// </summary>
        [DataMember]
        public Int32 NumberOfWorkerThreads { get; set; }
        /// <summary>
        /// Gets or sets the RecordSimFeedData.
        /// </summary>
        [DataMember]
        public Boolean RecordSimFeedData { get; set; }
        /// <summary>
        /// Gets or sets the UseLegacyCompiler.
        /// </summary>
        [DataMember]
        public Boolean UseLegacyCompiler { get; set; }
        /// <summary>
        /// Gets or sets the ChartCrosshairType.
        /// </summary>
        [DataMember]
        public ChartCrosshairType ChartCrosshairType { get; set; }
        /// <summary>
        /// Gets or sets the ChartPerformanceOutput.
        /// </summary>
        [DataMember]
        public Boolean ChartPerformanceOutput { get; set; }
        /// <summary>
        /// Gets or sets the ChartRefreshInterval.
        /// </summary>
        [DataMember]
        public Int32 ChartRefreshInterval { get; set; }
        /// <summary>
        /// Gets or sets the ChartForceSoftwareRendering.
        /// </summary>
        [DataMember]
        public Boolean ChartForceSoftwareRendering { get; set; }
        /// <summary>
        /// Gets or sets the ChartShowThumbnails.
        /// </summary>
        [DataMember]
        public Boolean ChartShowThumbnails { get; set; }
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
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="options">AdminOptions</param>
        public Void CopyTo(AdminOptions options);
        #endregion
    }
}
