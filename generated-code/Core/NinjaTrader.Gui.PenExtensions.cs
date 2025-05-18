[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class PenExtensions
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="pen1">Pen</param>
        /// <param name="pen2">Pen</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(Pen pen1, Pen pen2);
        /// <summary>
        /// IsDefault method.
        /// </summary>
        /// <param name="pen">Pen</param>
        /// <param name="resourceKey">Object</param>
        /// <returns>Boolean</returns>
        public Boolean IsDefault(Pen pen, Object resourceKey);
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="dashStyle1">DashStyle</param>
        /// <param name="dashStyle2">DashStyle</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(DashStyle dashStyle1, DashStyle dashStyle2);
        #endregion
    }
}
