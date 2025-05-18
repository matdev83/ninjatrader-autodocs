[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class VerticalLine : Line
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Anchors.
        /// </summary>
        [DataMember]
        public IEnumerable<ChartAnchor> Anchors { get; set; }
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the SupportsAlerts.
        /// </summary>
        [DataMember]
        public Boolean SupportsAlerts { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
