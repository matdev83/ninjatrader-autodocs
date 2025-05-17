[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class GannAngleContainer : DrawingTool
    {
        #region Properties
        /// <summary>
        /// Gets or sets the GannAngles.
        /// </summary>
        [DataMember]
        public List<GannAngle> GannAngles { get; set; }
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
