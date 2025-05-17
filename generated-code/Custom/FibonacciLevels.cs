[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class FibonacciLevels : PriceLevelContainer
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AnchorLineStroke.
        /// </summary>
        [DataMember]
        public Stroke AnchorLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the StartAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor StartAnchor { get; set; }
        /// <summary>
        /// Gets or sets the EndAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor EndAnchor { get; set; }
        /// <summary>
        /// Gets or sets the PriceLevelOpacity.
        /// </summary>
        [DataMember]
        public Int32 PriceLevelOpacity { get; set; }
        /// <summary>
        /// Gets or sets the Anchors.
        /// </summary>
        [DataMember]
        public IEnumerable<ChartAnchor> Anchors { get; set; }
        /// <summary>
        /// Gets or sets the SupportsAlerts.
        /// </summary>
        [DataMember]
        public Boolean SupportsAlerts { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetAlertConditionItems method.
        /// </summary>
        /// <returns>IEnumerable`1</returns>
        public IEnumerable<AlertConditionItem> GetAlertConditionItems();
        #endregion
    }
}
