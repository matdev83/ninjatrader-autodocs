[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class Line : Stroke
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
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
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Double Value { get; set; }
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
