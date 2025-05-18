[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class IndicatorBase : NinjaScriptBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the InputPlot.
        /// </summary>
        [DataMember]
        public Int32 InputPlot { get; set; }
        /// <summary>
        /// Gets or sets the IsChartOnly.
        /// </summary>
        [DataMember]
        public Boolean IsChartOnly { get; set; }
        /// <summary>
        /// Gets or sets the IsCreatedByStrategy.
        /// </summary>
        [DataMember]
        public Boolean IsCreatedByStrategy { get; set; }
        /// <summary>
        /// Gets or sets the IsOwnedByChart.
        /// </summary>
        [DataMember]
        public Boolean IsOwnedByChart { get; set; }
        /// <summary>
        /// Gets or sets the IsSuspended.
        /// </summary>
        [DataMember]
        public Boolean IsSuspended { get; set; }
        /// <summary>
        /// Gets or sets the IsTradingHoursBreakLineVisible.
        /// </summary>
        [DataMember]
        public Boolean IsTradingHoursBreakLineVisible { get; set; }
        /// <summary>
        /// Gets or sets the TrackedOrders.
        /// </summary>
        [DataMember]
        public List<TrackedOrder> TrackedOrders { get; set; }
        /// <summary>
        /// Gets or sets the DefaultName.
        /// </summary>
        [DataMember]
        public String DefaultName { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the DrawHorizontalGridLines.
        /// </summary>
        [DataMember]
        public Boolean DrawHorizontalGridLines { get; set; }
        /// <summary>
        /// Gets or sets the DrawVerticalGridLines.
        /// </summary>
        [DataMember]
        public Boolean DrawVerticalGridLines { get; set; }
        /// <summary>
        /// Gets or sets the DrawOnPricePanel.
        /// </summary>
        [DataMember]
        public Boolean DrawOnPricePanel { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the PaintPriceMarkers.
        /// </summary>
        [DataMember]
        public Boolean PaintPriceMarkers { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// RestoreInputFromXml method.
        /// </summary>
        /// <param name="node">XContainer</param>
        public Void RestoreInputFromXml(XContainer node);
        /// <summary>
        /// SaveInputToXml method.
        /// </summary>
        /// <returns>XElement</returns>
        public XElement SaveInputToXml();
        /// <summary>
        /// PropagateIsSuspendedToChildren method.
        /// </summary>
        public Void PropagateIsSuspendedToChildren();
        /// <summary>
        /// UpdateTrackedOrderPrice method.
        /// </summary>
        /// <param name="forceOffsetUpdate">Boolean</param>
        public Void UpdateTrackedOrderPrice(Boolean forceOffsetUpdate);
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// GetDisplayName method.
        /// </summary>
        /// <param name="useDefaultLogic">Boolean</param>
        /// <param name="trim">Boolean</param>
        /// <returns>String</returns>
        public String GetDisplayName(Boolean useDefaultLogic, Boolean trim);
        /// <summary>
        /// GetDisplayName method.
        /// </summary>
        /// <param name="useDefaultLogic">Boolean</param>
        /// <param name="generateCode">Boolean</param>
        /// <param name="trim">Boolean</param>
        /// <returns>String</returns>
        public String GetDisplayName(Boolean useDefaultLogic, Boolean generateCode, Boolean trim);
        /// <summary>
        /// RestoreFromXml method.
        /// </summary>
        /// <param name="element">XElement</param>
        public Void RestoreFromXml(XElement element);
        /// <summary>
        /// SaveToXml method.
        /// </summary>
        /// <param name="element">XElement</param>
        public Void SaveToXml(XElement element);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
