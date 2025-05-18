[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class DrawingToolTile : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Top.
        /// </summary>
        [DataMember]
        public Double Top { get; set; }
        /// <summary>
        /// Gets or sets the Left.
        /// </summary>
        [DataMember]
        public Double Left { get; set; }
        /// <summary>
        /// Gets or sets the IsVisibleOnlyFocused.
        /// </summary>
        [DataMember]
        public Boolean IsVisibleOnlyFocused { get; set; }
        /// <summary>
        /// Gets or sets the SelectedTypes.
        /// </summary>
        [DataMember]
        public XElement SelectedTypes { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfRows.
        /// </summary>
        [DataMember]
        public Int32 NumberOfRows { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        #endregion
    }
}
