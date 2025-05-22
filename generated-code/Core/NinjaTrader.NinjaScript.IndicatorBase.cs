[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class IndicatorBase : NinjaTrader.NinjaScript.NinjaScriptBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the InputPlot.
        /// </summary>
        [DataMember]
        public int InputPlot { get; set; }
        /// <summary>
        /// Gets or sets the IsChartOnly.
        /// </summary>
        [DataMember]
        public bool IsChartOnly { get; set; }
        /// <summary>
        /// Gets or sets the IsCreatedByStrategy.
        /// </summary>
        [DataMember]
        public bool IsCreatedByStrategy { get; set; }
        /// <summary>
        /// Gets or sets the IsOwnedByChart.
        /// </summary>
        [DataMember]
        public bool IsOwnedByChart { get; set; }
        /// <summary>
        /// Gets or sets the IsSuspended.
        /// </summary>
        [DataMember]
        public bool IsSuspended { get; set; }
        /// <summary>
        /// Gets or sets the IsTradingHoursBreakLineVisible.
        /// </summary>
        [DataMember]
        public bool IsTradingHoursBreakLineVisible { get; set; }
        /// <summary>
        /// Gets or sets the TrackedOrders.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.NinjaScript.TrackedOrder> TrackedOrders { get; set; }
        /// <summary>
        /// Gets or sets the DefaultName.
        /// </summary>
        [DataMember]
        public string DefaultName { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the DrawHorizontalGridLines.
        /// </summary>
        [DataMember]
        public bool DrawHorizontalGridLines { get; set; }
        /// <summary>
        /// Gets or sets the DrawVerticalGridLines.
        /// </summary>
        [DataMember]
        public bool DrawVerticalGridLines { get; set; }
        /// <summary>
        /// Gets or sets the DrawOnPricePanel.
        /// </summary>
        [DataMember]
        public bool DrawOnPricePanel { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the PaintPriceMarkers.
        /// </summary>
        [DataMember]
        public bool PaintPriceMarkers { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// RestoreInputFromXml method.
        /// </summary>
        /// <param name="node">System.Xml.Linq.XContainer</param>
        public void RestoreInputFromXml(System.Xml.Linq.XContainer node)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SaveInputToXml method.
        /// </summary>
        /// <returns>System.Xml.Linq.XElement</returns>
        public System.Xml.Linq.XElement SaveInputToXml()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// PropagateIsSuspendedToChildren method.
        /// </summary>
        public void PropagateIsSuspendedToChildren()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateTrackedOrderPrice method.
        /// </summary>
        /// <param name="forceOffsetUpdate">bool</param>
        public void UpdateTrackedOrderPrice(bool forceOffsetUpdate)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaTrader.NinjaScript.NinjaScript</param>
        public void CopyTo(NinjaTrader.NinjaScript.NinjaScript ninjaScript)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetDisplayName method.
        /// </summary>
        /// <param name="useDefaultLogic">bool</param>
        /// <param name="trim">bool</param>
        /// <returns>string</returns>
        public string GetDisplayName(bool useDefaultLogic, bool trim)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetDisplayName method.
        /// </summary>
        /// <param name="useDefaultLogic">bool</param>
        /// <param name="generateCode">bool</param>
        /// <param name="trim">bool</param>
        /// <returns>string</returns>
        public string GetDisplayName(bool useDefaultLogic, bool generateCode, bool trim)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RestoreFromXml method.
        /// </summary>
        /// <param name="element">System.Xml.Linq.XElement</param>
        public void RestoreFromXml(System.Xml.Linq.XElement element)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SaveToXml method.
        /// </summary>
        /// <param name="element">System.Xml.Linq.XElement</param>
        public void SaveToXml(System.Xml.Linq.XElement element)
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
