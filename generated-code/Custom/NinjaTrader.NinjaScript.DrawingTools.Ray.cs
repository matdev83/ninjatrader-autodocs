[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class Ray : NinjaTrader.NinjaScript.DrawingTools.Line
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public object Icon { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
