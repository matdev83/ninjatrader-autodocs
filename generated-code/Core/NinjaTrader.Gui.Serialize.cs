[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class Serialize
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// BrushToString method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <returns>String</returns>
        public String BrushToString(Brush brush);
        /// <summary>
        /// BrushToString method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <param name="resourceKey">Object</param>
        /// <returns>String</returns>
        public String BrushToString(Brush brush, Object resourceKey);
        /// <summary>
        /// PenToString method.
        /// </summary>
        /// <param name="pen">Pen</param>
        /// <returns>String</returns>
        public String PenToString(Pen pen);
        /// <summary>
        /// PenToString method.
        /// </summary>
        /// <param name="pen">Pen</param>
        /// <param name="resourceKey">Object</param>
        /// <returns>String</returns>
        public String PenToString(Pen pen, Object resourceKey);
        /// <summary>
        /// StringToBrush method.
        /// </summary>
        /// <param name="value">String</param>
        /// <returns>Brush</returns>
        public Brush StringToBrush(String value);
        /// <summary>
        /// StringToBrush method.
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="resourceKey">Object</param>
        /// <returns>Brush</returns>
        public Brush StringToBrush(String value, Object resourceKey);
        /// <summary>
        /// StringToPen method.
        /// </summary>
        /// <param name="value">String</param>
        /// <returns>Pen</returns>
        public Pen StringToPen(String value);
        /// <summary>
        /// StringToPen method.
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="resourceKey">Object</param>
        /// <returns>Pen</returns>
        public Pen StringToPen(String value, Object resourceKey);
        #endregion
    }
}
