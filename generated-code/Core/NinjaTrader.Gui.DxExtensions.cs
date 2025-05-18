[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class DxExtensions
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// ToDxBrush method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <param name="renderTarget">RenderTarget</param>
        /// <returns>Brush</returns>
        public Brush ToDxBrush(Brush brush, RenderTarget renderTarget);
        /// <summary>
        /// ToDxBrush method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <param name="renderTarget">RenderTarget</param>
        /// <param name="opacity">Single</param>
        /// <returns>Brush</returns>
        public Brush ToDxBrush(Brush brush, RenderTarget renderTarget, Single opacity);
        /// <summary>
        /// ToVector2 method.
        /// </summary>
        /// <param name="point">Point</param>
        /// <returns>Vector2</returns>
        public Vector2 ToVector2(Point point);
        /// <summary>
        /// ToDxGradientStopCollection method.
        /// </summary>
        /// <param name="collection">GradientStopCollection</param>
        /// <param name="renderTarget">RenderTarget</param>
        /// <returns>GradientStopCollection</returns>
        public GradientStopCollection ToDxGradientStopCollection(GradientStopCollection collection, RenderTarget renderTarget);
        /// <summary>
        /// TransformBrush method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <param name="rectangleF">RectangleF</param>
        public Void TransformBrush(Brush brush, RectangleF rectangleF);
        /// <summary>
        /// IsValid method.
        /// </summary>
        /// <param name="brush">Brush</param>
        /// <param name="target">RenderTarget</param>
        /// <returns>Boolean</returns>
        public Boolean IsValid(Brush brush, RenderTarget target);
        #endregion
    }
}
