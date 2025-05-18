[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class BrushExtensions
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="brush1">Brush</param>
        /// <param name="brush2">Brush</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(Brush brush1, Brush brush2);
        /// <summary>
        /// IsDefault method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <param name="resourceKey">Object</param>
        /// <returns>Boolean</returns>
        public Boolean IsDefault(Brush brush, Object resourceKey);
        /// <summary>
        /// IsTransparent method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <returns>Boolean</returns>
        public Boolean IsTransparent(Brush brush);
        /// <summary>
        /// ToXElement method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <returns>XElement</returns>
        public XElement ToXElement(Brush brush);
        /// <summary>
        /// ToBrush method.
        /// </summary>
        /// <param name="rootElement">XElement</param>
        /// <returns>Brush</returns>
        public Brush ToBrush(XElement rootElement);
        /// <summary>
        /// ToFrozenBrush method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <returns>Brush</returns>
        public Brush ToFrozenBrush(Brush brush);
        #endregion
    }
}
