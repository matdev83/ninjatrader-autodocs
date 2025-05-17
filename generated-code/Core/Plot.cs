[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class Plot : Stroke
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AutoWidth.
        /// </summary>
        [DataMember]
        public Boolean AutoWidth { get; set; }
        /// <summary>
        /// Gets or sets the Max.
        /// </summary>
        [DataMember]
        public Double Max { get; set; }
        /// <summary>
        /// Gets or sets the Min.
        /// </summary>
        [DataMember]
        public Double Min { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
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
        public String StringFormat { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="stroke">Stroke</param>
        public Void CopyTo(Stroke stroke);
        #endregion
    }
}
