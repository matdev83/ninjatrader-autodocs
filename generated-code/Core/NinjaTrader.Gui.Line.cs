[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class Line : NinjaTrader.Gui.Stroke
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
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
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public double Value { get; set; }
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
