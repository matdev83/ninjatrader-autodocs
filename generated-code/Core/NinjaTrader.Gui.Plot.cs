[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class Plot : NinjaTrader.Gui.Stroke
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AutoWidth.
        /// </summary>
        [DataMember]
        public bool AutoWidth { get; set; }
        /// <summary>
        /// Gets or sets the Max.
        /// </summary>
        [DataMember]
        public double Max { get; set; }
        /// <summary>
        /// Gets or sets the Min.
        /// </summary>
        [DataMember]
        public double Min { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle.
        /// </summary>
        [DataMember]
        public PlotStyle PlotStyle { get; set; }
        /// <summary>
        /// Gets or sets the StateCreatedIn.
        /// </summary>
        [DataMember]
        public State StateCreatedIn { get; set; }
        /// <summary>
        /// Gets or sets the StringFormat.
        /// </summary>
        [DataMember]
        public string StringFormat { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="stroke">NinjaTrader.Gui.Stroke</param>
        public void CopyTo(NinjaTrader.Gui.Stroke stroke)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
