[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class Draw
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// AndrewsPitchfork method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>AndrewsPitchfork</returns>
        public AndrewsPitchfork AndrewsPitchfork(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// AndrewsPitchfork method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>AndrewsPitchfork</returns>
        public AndrewsPitchfork AndrewsPitchfork(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// AndrewsPitchfork method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>AndrewsPitchfork</returns>
        public AndrewsPitchfork AndrewsPitchfork(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y, Boolean isGlobal, String templateName);
        /// <summary>
        /// AndrewsPitchfork method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>AndrewsPitchfork</returns>
        public AndrewsPitchfork AndrewsPitchfork(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y, Boolean isGlobal, String templateName);
        /// <summary>
        /// Arc method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Arc</returns>
        public Arc Arc(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush);
        /// <summary>
        /// Arc method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Arc</returns>
        public Arc Arc(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush);
        /// <summary>
        /// Arc method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>Arc</returns>
        public Arc Arc(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// Arc method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>Arc</returns>
        public Arc Arc(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// Arc method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Arc</returns>
        public Arc Arc(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// Arc method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Arc</returns>
        public Arc Arc(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// Arc method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Arc</returns>
        public Arc Arc(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Arc method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Arc</returns>
        public Arc Arc(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// ArrowDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>ArrowDown</returns>
        public ArrowDown ArrowDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush);
        /// <summary>
        /// ArrowDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>ArrowDown</returns>
        public ArrowDown ArrowDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush);
        /// <summary>
        /// ArrowDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ArrowDown</returns>
        public ArrowDown ArrowDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// ArrowDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ArrowDown</returns>
        public ArrowDown ArrowDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// ArrowDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>ArrowDown</returns>
        public ArrowDown ArrowDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// ArrowDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>ArrowDown</returns>
        public ArrowDown ArrowDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// ArrowUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>ArrowUp</returns>
        public ArrowUp ArrowUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush);
        /// <summary>
        /// ArrowUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>ArrowUp</returns>
        public ArrowUp ArrowUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush);
        /// <summary>
        /// ArrowUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ArrowUp</returns>
        public ArrowUp ArrowUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// ArrowUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ArrowUp</returns>
        public ArrowUp ArrowUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// ArrowUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>ArrowUp</returns>
        public ArrowUp ArrowUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// ArrowUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>ArrowUp</returns>
        public ArrowUp ArrowUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// Diamond method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Diamond</returns>
        public Diamond Diamond(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush);
        /// <summary>
        /// Diamond method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Diamond</returns>
        public Diamond Diamond(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush);
        /// <summary>
        /// Diamond method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Diamond</returns>
        public Diamond Diamond(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Diamond method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Diamond</returns>
        public Diamond Diamond(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Diamond method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Diamond</returns>
        public Diamond Diamond(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// Diamond method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Diamond</returns>
        public Diamond Diamond(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// Dot method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Dot</returns>
        public Dot Dot(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush);
        /// <summary>
        /// Dot method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Dot</returns>
        public Dot Dot(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush);
        /// <summary>
        /// Dot method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Dot</returns>
        public Dot Dot(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Dot method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Dot</returns>
        public Dot Dot(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Dot method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Dot</returns>
        public Dot Dot(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// Dot method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Dot</returns>
        public Dot Dot(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// Square method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Square</returns>
        public Square Square(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush);
        /// <summary>
        /// Square method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Square</returns>
        public Square Square(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush);
        /// <summary>
        /// Square method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Square</returns>
        public Square Square(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Square method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Square</returns>
        public Square Square(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Square method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Square</returns>
        public Square Square(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// Square method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Square</returns>
        public Square Square(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// TriangleDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>TriangleDown</returns>
        public TriangleDown TriangleDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush);
        /// <summary>
        /// TriangleDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>TriangleDown</returns>
        public TriangleDown TriangleDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush);
        /// <summary>
        /// TriangleDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>TriangleDown</returns>
        public TriangleDown TriangleDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// TriangleDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>TriangleDown</returns>
        public TriangleDown TriangleDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// TriangleDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TriangleDown</returns>
        public TriangleDown TriangleDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// TriangleDown method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TriangleDown</returns>
        public TriangleDown TriangleDown(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// TriangleUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>TriangleUp</returns>
        public TriangleUp TriangleUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush);
        /// <summary>
        /// TriangleUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>TriangleUp</returns>
        public TriangleUp TriangleUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush);
        /// <summary>
        /// TriangleUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>TriangleUp</returns>
        public TriangleUp TriangleUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// TriangleUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>TriangleUp</returns>
        public TriangleUp TriangleUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// TriangleUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TriangleUp</returns>
        public TriangleUp TriangleUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// TriangleUp method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TriangleUp</returns>
        public TriangleUp TriangleUp(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// FibonacciCircle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <returns>FibonacciCircle</returns>
        public FibonacciCircle FibonacciCircle(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY);
        /// <summary>
        /// FibonacciCircle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <returns>FibonacciCircle</returns>
        public FibonacciCircle FibonacciCircle(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY);
        /// <summary>
        /// FibonacciCircle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>FibonacciCircle</returns>
        public FibonacciCircle FibonacciCircle(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// FibonacciCircle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>FibonacciCircle</returns>
        public FibonacciCircle FibonacciCircle(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// FibonacciExtensions method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="extensionBarsAgo">Int32</param>
        /// <param name="extensionY">Double</param>
        /// <returns>FibonacciExtensions</returns>
        public FibonacciExtensions FibonacciExtensions(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Int32 extensionBarsAgo, Double extensionY);
        /// <summary>
        /// FibonacciExtensions method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="extensionTime">DateTime</param>
        /// <param name="extensionY">Double</param>
        /// <returns>FibonacciExtensions</returns>
        public FibonacciExtensions FibonacciExtensions(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, DateTime extensionTime, Double extensionY);
        /// <summary>
        /// FibonacciExtensions method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="extensionTime">DateTime</param>
        /// <param name="extensionY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>FibonacciExtensions</returns>
        public FibonacciExtensions FibonacciExtensions(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, DateTime extensionTime, Double extensionY, Boolean isGlobal, String templateName);
        /// <summary>
        /// FibonacciExtensions method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="extensionBarsAgo">Int32</param>
        /// <param name="extensionY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>FibonacciExtensions</returns>
        public FibonacciExtensions FibonacciExtensions(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Int32 extensionBarsAgo, Double extensionY, Boolean isGlobal, String templateName);
        /// <summary>
        /// FibonacciRetracements method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <returns>FibonacciRetracements</returns>
        public FibonacciRetracements FibonacciRetracements(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY);
        /// <summary>
        /// FibonacciRetracements method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <returns>FibonacciRetracements</returns>
        public FibonacciRetracements FibonacciRetracements(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY);
        /// <summary>
        /// FibonacciRetracements method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>FibonacciRetracements</returns>
        public FibonacciRetracements FibonacciRetracements(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// FibonacciRetracements method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>FibonacciRetracements</returns>
        public FibonacciRetracements FibonacciRetracements(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// FibonacciTimeExtensions method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <returns>FibonacciTimeExtensions</returns>
        public FibonacciTimeExtensions FibonacciTimeExtensions(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY);
        /// <summary>
        /// FibonacciTimeExtensions method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <returns>FibonacciTimeExtensions</returns>
        public FibonacciTimeExtensions FibonacciTimeExtensions(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY);
        /// <summary>
        /// FibonacciTimeExtensions method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>FibonacciTimeExtensions</returns>
        public FibonacciTimeExtensions FibonacciTimeExtensions(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// FibonacciTimeExtensions method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>FibonacciTimeExtensions</returns>
        public FibonacciTimeExtensions FibonacciTimeExtensions(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// GannFan method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <returns>GannFan</returns>
        public GannFan GannFan(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y);
        /// <summary>
        /// GannFan method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <returns>GannFan</returns>
        public GannFan GannFan(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y);
        /// <summary>
        /// GannFan method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>GannFan</returns>
        public GannFan GannFan(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 barsAgo, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// GannFan method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>GannFan</returns>
        public GannFan GannFan(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime time, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// ArrowLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>ArrowLine</returns>
        public ArrowLine ArrowLine(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush);
        /// <summary>
        /// ArrowLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>ArrowLine</returns>
        public ArrowLine ArrowLine(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush);
        /// <summary>
        /// ArrowLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>ArrowLine</returns>
        public ArrowLine ArrowLine(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// ArrowLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ArrowLine</returns>
        public ArrowLine ArrowLine(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// ArrowLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ArrowLine</returns>
        public ArrowLine ArrowLine(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// ArrowLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>ArrowLine</returns>
        public ArrowLine ArrowLine(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// ArrowLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>ArrowLine</returns>
        public ArrowLine ArrowLine(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// ExtendedLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>ExtendedLine</returns>
        public ExtendedLine ExtendedLine(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// HorizontalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>HorizontalLine</returns>
        public HorizontalLine HorizontalLine(NinjaScriptBase owner, String tag, Double y, Brush brush);
        /// <summary>
        /// HorizontalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>HorizontalLine</returns>
        public HorizontalLine HorizontalLine(NinjaScriptBase owner, String tag, Double y, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// HorizontalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>HorizontalLine</returns>
        public HorizontalLine HorizontalLine(NinjaScriptBase owner, String tag, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// HorizontalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>HorizontalLine</returns>
        public HorizontalLine HorizontalLine(NinjaScriptBase owner, String tag, Double y, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// HorizontalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>HorizontalLine</returns>
        public HorizontalLine HorizontalLine(NinjaScriptBase owner, String tag, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// HorizontalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>HorizontalLine</returns>
        public HorizontalLine HorizontalLine(NinjaScriptBase owner, String tag, Boolean isAutoScale, Double y, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// HorizontalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoscale">Boolean</param>
        /// <param name="y">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>HorizontalLine</returns>
        public HorizontalLine HorizontalLine(NinjaScriptBase owner, String tag, Boolean isAutoscale, Double y, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Line method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Line</returns>
        public Line Line(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush);
        /// <summary>
        /// Line method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>Line</returns>
        public Line Line(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// Line method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>Line</returns>
        public Line Line(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// Line method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Line</returns>
        public Line Line(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// Line method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Line</returns>
        public Line Line(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// Line method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="templateName">String</param>
        /// <returns>Line</returns>
        public Line Line(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, String templateName);
        /// <summary>
        /// Line method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="templateName">String</param>
        /// <returns>Line</returns>
        public Line Line(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, String templateName);
        /// <summary>
        /// Line method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Line</returns>
        public Line Line(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Line method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Line</returns>
        public Line Line(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// VerticalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="time">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <returns>VerticalLine</returns>
        public VerticalLine VerticalLine(NinjaScriptBase owner, String tag, DateTime time, Brush brush);
        /// <summary>
        /// VerticalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="time">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>VerticalLine</returns>
        public VerticalLine VerticalLine(NinjaScriptBase owner, String tag, DateTime time, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// VerticalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <returns>VerticalLine</returns>
        public VerticalLine VerticalLine(NinjaScriptBase owner, String tag, Int32 barsAgo, Brush brush);
        /// <summary>
        /// VerticalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>VerticalLine</returns>
        public VerticalLine VerticalLine(NinjaScriptBase owner, String tag, Int32 barsAgo, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// VerticalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="time">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>VerticalLine</returns>
        public VerticalLine VerticalLine(NinjaScriptBase owner, String tag, DateTime time, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// VerticalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>VerticalLine</returns>
        public VerticalLine VerticalLine(NinjaScriptBase owner, String tag, Int32 barsAgo, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// VerticalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>VerticalLine</returns>
        public VerticalLine VerticalLine(NinjaScriptBase owner, String tag, Int32 barsAgo, Boolean isGlobal, String templateName);
        /// <summary>
        /// VerticalLine method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="time">DateTime</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>VerticalLine</returns>
        public VerticalLine VerticalLine(NinjaScriptBase owner, String tag, DateTime time, Boolean isGlobal, String templateName);
        /// <summary>
        /// Ray method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Ray</returns>
        public Ray Ray(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush);
        /// <summary>
        /// Ray method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>Ray</returns>
        public Ray Ray(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// Ray method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Ray</returns>
        public Ray Ray(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush);
        /// <summary>
        /// Ray method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <returns>Ray</returns>
        public Ray Ray(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width);
        /// <summary>
        /// Ray method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Ray</returns>
        public Ray Ray(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// Ray method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="width">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Ray</returns>
        public Ray Ray(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, DashStyleHelper dashStyle, Int32 width, Boolean drawOnPricePanel);
        /// <summary>
        /// Ray method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Ray</returns>
        public Ray Ray(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Ray method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Ray</returns>
        public Ray Ray(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// PathTool method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <returns>PathTool</returns>
        public PathTool PathTool(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y);
        /// <summary>
        /// PathTool method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <returns>PathTool</returns>
        public PathTool PathTool(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y);
        /// <summary>
        /// PathTool method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4BarsAgo">Int32</param>
        /// <param name="anchor4Y">Double</param>
        /// <returns>PathTool</returns>
        public PathTool PathTool(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y, Int32 anchor4BarsAgo, Double anchor4Y);
        /// <summary>
        /// PathTool method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4Time">DateTime</param>
        /// <param name="anchor4Y">Double</param>
        /// <returns>PathTool</returns>
        public PathTool PathTool(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y, DateTime anchor4Time, Double anchor4Y);
        /// <summary>
        /// PathTool method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4BarsAgo">Int32</param>
        /// <param name="anchor4Y">Double</param>
        /// <param name="anchor5BarsAgo">Int32</param>
        /// <param name="anchor5Y">Double</param>
        /// <returns>PathTool</returns>
        public PathTool PathTool(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y, Int32 anchor4BarsAgo, Double anchor4Y, Int32 anchor5BarsAgo, Double anchor5Y);
        /// <summary>
        /// PathTool method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4Time">DateTime</param>
        /// <param name="anchor4Y">Double</param>
        /// <param name="anchor5Time">DateTime</param>
        /// <param name="anchor5Y">Double</param>
        /// <returns>PathTool</returns>
        public PathTool PathTool(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y, DateTime anchor4Time, Double anchor4Y, DateTime anchor5Time, Double anchor5Y);
        /// <summary>
        /// PathTool method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="chartAnchors">List`1</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <returns>PathTool</returns>
        public PathTool PathTool(NinjaScriptBase owner, String tag, Boolean isAutoScale, List<ChartAnchor> chartAnchors, Brush brush, DashStyleHelper dashStyle);
        /// <summary>
        /// PathTool method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="chartAnchors">List`1</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>PathTool</returns>
        public PathTool PathTool(NinjaScriptBase owner, String tag, Boolean isAutoScale, List<ChartAnchor> chartAnchors, Boolean isGlobal, String templateName);
        /// <summary>
        /// Polygon method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4BarsAgo">Int32</param>
        /// <param name="anchor4Y">Double</param>
        /// <returns>Polygon</returns>
        public Polygon Polygon(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y, Int32 anchor4BarsAgo, Double anchor4Y);
        /// <summary>
        /// Polygon method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4Time">DateTime</param>
        /// <param name="anchor4Y">Double</param>
        /// <returns>Polygon</returns>
        public Polygon Polygon(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y, DateTime anchor4Time, Double anchor4Y);
        /// <summary>
        /// Polygon method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4BarsAgo">Int32</param>
        /// <param name="anchor4Y">Double</param>
        /// <param name="anchor5BarsAgo">Int32</param>
        /// <param name="anchor5Y">Double</param>
        /// <returns>Polygon</returns>
        public Polygon Polygon(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y, Int32 anchor4BarsAgo, Double anchor4Y, Int32 anchor5BarsAgo, Double anchor5Y);
        /// <summary>
        /// Polygon method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4Time">DateTime</param>
        /// <param name="anchor4Y">Double</param>
        /// <param name="anchor5Time">DateTime</param>
        /// <param name="anchor5Y">Double</param>
        /// <returns>Polygon</returns>
        public Polygon Polygon(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y, DateTime anchor4Time, Double anchor4Y, DateTime anchor5Time, Double anchor5Y);
        /// <summary>
        /// Polygon method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4BarsAgo">Int32</param>
        /// <param name="anchor4Y">Double</param>
        /// <param name="anchor5BarsAgo">Int32</param>
        /// <param name="anchor5Y">Double</param>
        /// <param name="anchor6BarsAgo">Int32</param>
        /// <param name="anchor6Y">Double</param>
        /// <returns>Polygon</returns>
        public Polygon Polygon(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y, Int32 anchor4BarsAgo, Double anchor4Y, Int32 anchor5BarsAgo, Double anchor5Y, Int32 anchor6BarsAgo, Double anchor6Y);
        /// <summary>
        /// Polygon method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="anchor4Time">DateTime</param>
        /// <param name="anchor4Y">Double</param>
        /// <param name="anchor5Time">DateTime</param>
        /// <param name="anchor5Y">Double</param>
        /// <param name="anchor6Time">DateTime</param>
        /// <param name="anchor6Y">Double</param>
        /// <returns>Polygon</returns>
        public Polygon Polygon(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y, DateTime anchor4Time, Double anchor4Y, DateTime anchor5Time, Double anchor5Y, DateTime anchor6Time, Double anchor6Y);
        /// <summary>
        /// Polygon method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="chartAnchors">List`1</param>
        /// <param name="brush">Brush</param>
        /// <param name="dashStyle">DashStyleHelper</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Polygon</returns>
        public Polygon Polygon(NinjaScriptBase owner, String tag, Boolean isAutoScale, List<ChartAnchor> chartAnchors, Brush brush, DashStyleHelper dashStyle, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Polygon method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="chartAnchors">List`1</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Polygon</returns>
        public Polygon Polygon(NinjaScriptBase owner, String tag, Boolean isAutoScale, List<ChartAnchor> chartAnchors, Boolean isGlobal, String templateName);
        /// <summary>
        /// Region method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="series">ISeries`1</param>
        /// <param name="price">Double</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="displacement">Int32</param>
        /// <returns>Region</returns>
        public Region Region(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, ISeries<Double> series, Double price, Brush areaBrush, Int32 areaOpacity, Int32 displacement);
        /// <summary>
        /// Region method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="series1">ISeries`1</param>
        /// <param name="series2">ISeries`1</param>
        /// <param name="outlineBrush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="displacement">Int32</param>
        /// <returns>Region</returns>
        public Region Region(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, ISeries<Double> series1, ISeries<Double> series2, Brush outlineBrush, Brush areaBrush, Int32 areaOpacity, Int32 displacement);
        /// <summary>
        /// Region method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="series">ISeries`1</param>
        /// <param name="price">Double</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Region</returns>
        public Region Region(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, ISeries<Double> series, Double price, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Region method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="series1">ISeries`1</param>
        /// <param name="series2">ISeries`1</param>
        /// <param name="outlineBrush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Region</returns>
        public Region Region(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, ISeries<Double> series1, ISeries<Double> series2, Brush outlineBrush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// RegionHighlightX method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <returns>RegionHighlightX</returns>
        public RegionHighlightX RegionHighlightX(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Brush brush);
        /// <summary>
        /// RegionHighlightX method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <returns>RegionHighlightX</returns>
        public RegionHighlightX RegionHighlightX(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Brush brush);
        /// <summary>
        /// RegionHighlightX method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>RegionHighlightX</returns>
        public RegionHighlightX RegionHighlightX(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// RegionHighlightX method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>RegionHighlightX</returns>
        public RegionHighlightX RegionHighlightX(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// RegionHighlightX method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>RegionHighlightX</returns>
        public RegionHighlightX RegionHighlightX(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Boolean isGlobal, String templateName);
        /// <summary>
        /// RegionHighlightX method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>RegionHighlightX</returns>
        public RegionHighlightX RegionHighlightX(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Boolean isGlobal, String templateName);
        /// <summary>
        /// RegionHighlightY method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startY">Double</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>RegionHighlightY</returns>
        public RegionHighlightY RegionHighlightY(NinjaScriptBase owner, String tag, Double startY, Double endY, Brush brush);
        /// <summary>
        /// RegionHighlightY method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startY">Double</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>RegionHighlightY</returns>
        public RegionHighlightY RegionHighlightY(NinjaScriptBase owner, String tag, Boolean isAutoScale, Double startY, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// RegionHighlightY method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startY">Double</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>RegionHighlightY</returns>
        public RegionHighlightY RegionHighlightY(NinjaScriptBase owner, String tag, Double startY, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// RegressionChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <returns>RegressionChannel</returns>
        public RegressionChannel RegressionChannel(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Brush brush);
        /// <summary>
        /// RegressionChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <returns>RegressionChannel</returns>
        public RegressionChannel RegressionChannel(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Brush brush);
        /// <summary>
        /// RegressionChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="upperBrush">Brush</param>
        /// <param name="upperDashStyle">DashStyleHelper</param>
        /// <param name="upperWidth">Int32</param>
        /// <param name="middleBrush">Brush</param>
        /// <param name="middleDashStyle">DashStyleHelper</param>
        /// <param name="middleWidth">Int32</param>
        /// <param name="lowerBrush">Brush</param>
        /// <param name="lowerDashStyle">DashStyleHelper</param>
        /// <param name="lowerWidth">Int32</param>
        /// <returns>RegressionChannel</returns>
        public RegressionChannel RegressionChannel(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Int32 endBarsAgo, Brush upperBrush, DashStyleHelper upperDashStyle, Int32 upperWidth, Brush middleBrush, DashStyleHelper middleDashStyle, Int32 middleWidth, Brush lowerBrush, DashStyleHelper lowerDashStyle, Int32 lowerWidth);
        /// <summary>
        /// RegressionChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="upperBrush">Brush</param>
        /// <param name="upperDashStyle">DashStyleHelper</param>
        /// <param name="upperWidth">Int32</param>
        /// <param name="middleBrush">Brush</param>
        /// <param name="middleDashStyle">DashStyleHelper</param>
        /// <param name="middleWidth">Int32</param>
        /// <param name="lowerBrush">Brush</param>
        /// <param name="lowerDashStyle">DashStyleHelper</param>
        /// <param name="lowerWidth">Int32</param>
        /// <returns>RegressionChannel</returns>
        public RegressionChannel RegressionChannel(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, DateTime endTime, Brush upperBrush, DashStyleHelper upperDashStyle, Int32 upperWidth, Brush middleBrush, DashStyleHelper middleDashStyle, Int32 middleWidth, Brush lowerBrush, DashStyleHelper lowerDashStyle, Int32 lowerWidth);
        /// <summary>
        /// RegressionChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>RegressionChannel</returns>
        public RegressionChannel RegressionChannel(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Boolean isGlobal, String templateName);
        /// <summary>
        /// RegressionChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>RegressionChannel</returns>
        public RegressionChannel RegressionChannel(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Boolean isGlobal, String templateName);
        /// <summary>
        /// RiskReward method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="entryTime">DateTime</param>
        /// <param name="entryY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="ratio">Double</param>
        /// <param name="isStop">Boolean</param>
        /// <returns>RiskReward</returns>
        public RiskReward RiskReward(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime entryTime, Double entryY, DateTime endTime, Double endY, Double ratio, Boolean isStop);
        /// <summary>
        /// RiskReward method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="entryBarsAgo">Int32</param>
        /// <param name="entryY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="ratio">Double</param>
        /// <param name="isStop">Boolean</param>
        /// <returns>RiskReward</returns>
        public RiskReward RiskReward(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 entryBarsAgo, Double entryY, Int32 endBarsAgo, Double endY, Double ratio, Boolean isStop);
        /// <summary>
        /// RiskReward method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="entryTime">DateTime</param>
        /// <param name="entryY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="ratio">Double</param>
        /// <param name="isStop">Boolean</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>RiskReward</returns>
        public RiskReward RiskReward(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime entryTime, Double entryY, DateTime endTime, Double endY, Double ratio, Boolean isStop, Boolean isGlobal, String templateName);
        /// <summary>
        /// RiskReward method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="entryBarsAgo">Int32</param>
        /// <param name="entryY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="ratio">Double</param>
        /// <param name="isStop">Boolean</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>RiskReward</returns>
        public RiskReward RiskReward(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 entryBarsAgo, Double entryY, Int32 endBarsAgo, Double endY, Double ratio, Boolean isStop, Boolean isGlobal, String templateName);
        /// <summary>
        /// Ruler method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="textBarsAgo">Int32</param>
        /// <param name="textY">Double</param>
        /// <returns>Ruler</returns>
        public Ruler Ruler(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Int32 textBarsAgo, Double textY);
        /// <summary>
        /// Ruler method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="textTime">DateTime</param>
        /// <param name="textY">Double</param>
        /// <returns>Ruler</returns>
        public Ruler Ruler(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, DateTime textTime, Double textY);
        /// <summary>
        /// Ruler method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="textBarsAgo">Int32</param>
        /// <param name="textY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Ruler</returns>
        public Ruler Ruler(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Int32 textBarsAgo, Double textY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Ruler method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="textTime">DateTime</param>
        /// <param name="textY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Ruler</returns>
        public Ruler Ruler(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, DateTime textTime, Double textY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity, Boolean drawOnPricePanel);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity, Boolean drawOnPricePanel);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Ellipse method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Ellipse</returns>
        public Ellipse Ellipse(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Rectangle</returns>
        public Rectangle Rectangle(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush);
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Rectangle</returns>
        public Rectangle Rectangle(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush);
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Rectangle</returns>
        public Rectangle Rectangle(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Rectangle</returns>
        public Rectangle Rectangle(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Rectangle</returns>
        public Rectangle Rectangle(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Rectangle</returns>
        public Rectangle Rectangle(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity, Boolean drawOnPricePanel);
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Rectangle</returns>
        public Rectangle Rectangle(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime endTime, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity, Boolean drawOnPricePanel);
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Rectangle</returns>
        public Rectangle Rectangle(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Rectangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Rectangle</returns>
        public Rectangle Rectangle(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Triangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="middleBarsAgo">Int32</param>
        /// <param name="middleY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Triangle</returns>
        public Triangle Triangle(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 middleBarsAgo, Double middleY, Int32 endBarsAgo, Double endY, Brush brush);
        /// <summary>
        /// Triangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="middleTime">DateTime</param>
        /// <param name="middleY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <returns>Triangle</returns>
        public Triangle Triangle(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime middleTime, Double middleY, DateTime endTime, Double endY, Brush brush);
        /// <summary>
        /// Triangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="middleBarsAgo">Int32</param>
        /// <param name="middleY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Triangle</returns>
        public Triangle Triangle(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 middleBarsAgo, Double middleY, Int32 endBarsAgo, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Triangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="midTime">DateTime</param>
        /// <param name="middleY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Triangle</returns>
        public Triangle Triangle(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime midTime, Double middleY, DateTime endTime, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Triangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="middleBarsAgo">Int32</param>
        /// <param name="middleY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Triangle</returns>
        public Triangle Triangle(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 middleBarsAgo, Double middleY, Int32 endBarsAgo, Double endY, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// Triangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="middleBarsAgo">Int32</param>
        /// <param name="middleY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Triangle</returns>
        public Triangle Triangle(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 startBarsAgo, Double startY, Int32 middleBarsAgo, Double middleY, Int32 endBarsAgo, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity, Boolean drawOnPricePanel);
        /// <summary>
        /// Triangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="midTime">DateTime</param>
        /// <param name="middleY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>Triangle</returns>
        public Triangle Triangle(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime startTime, Double startY, DateTime midTime, Double middleY, DateTime endTime, Double endY, Brush brush, Brush areaBrush, Int32 areaOpacity, Boolean drawOnPricePanel);
        /// <summary>
        /// Triangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="startY">Double</param>
        /// <param name="middleBarsAgo">Int32</param>
        /// <param name="middleY">Double</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Triangle</returns>
        public Triangle Triangle(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Double startY, Int32 middleBarsAgo, Double middleY, Int32 endBarsAgo, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Triangle method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="startY">Double</param>
        /// <param name="middleTime">DateTime</param>
        /// <param name="middleY">Double</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="endY">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Triangle</returns>
        public Triangle Triangle(NinjaScriptBase owner, String tag, DateTime startTime, Double startY, DateTime middleTime, Double middleY, DateTime endTime, Double endY, Boolean isGlobal, String templateName);
        /// <summary>
        /// Text method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="text">String</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <returns>Text</returns>
        public Text Text(NinjaScriptBase owner, String tag, String text, Int32 barsAgo, Double y);
        /// <summary>
        /// Text method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="text">String</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="textBrush">Brush</param>
        /// <returns>Text</returns>
        public Text Text(NinjaScriptBase owner, String tag, String text, Int32 barsAgo, Double y, Brush textBrush);
        /// <summary>
        /// Text method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="text">String</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Text</returns>
        public Text Text(NinjaScriptBase owner, String tag, String text, Int32 barsAgo, Double y, Boolean isGlobal, String templateName);
        /// <summary>
        /// Text method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="text">String</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="yPixelOffset">Int32</param>
        /// <param name="textBrush">Brush</param>
        /// <param name="font">SimpleFont</param>
        /// <param name="alignment">TextAlignment</param>
        /// <param name="outlineBrush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Text</returns>
        public Text Text(NinjaScriptBase owner, String tag, Boolean isAutoScale, String text, Int32 barsAgo, Double y, Int32 yPixelOffset, Brush textBrush, SimpleFont font, TextAlignment alignment, Brush outlineBrush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Text method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="text">String</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="yPixelOffset">Int32</param>
        /// <param name="textBrush">Brush</param>
        /// <param name="font">SimpleFont</param>
        /// <param name="alignment">TextAlignment</param>
        /// <param name="outlineBrush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>Text</returns>
        public Text Text(NinjaScriptBase owner, String tag, Boolean isAutoScale, String text, DateTime time, Double y, Int32 yPixelOffset, Brush textBrush, SimpleFont font, TextAlignment alignment, Brush outlineBrush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// Text method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="text">String</param>
        /// <param name="barsAgo">Int32</param>
        /// <param name="y">Double</param>
        /// <param name="yPixelOffset">Int32</param>
        /// <param name="textBrush">Brush</param>
        /// <param name="font">SimpleFont</param>
        /// <param name="alignment">TextAlignment</param>
        /// <param name="outlineBrush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="outlineDashStyle">DashStyleHelper</param>
        /// <param name="outlineWidth">Int32</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Text</returns>
        public Text Text(NinjaScriptBase owner, String tag, Boolean isAutoScale, String text, Int32 barsAgo, Double y, Int32 yPixelOffset, Brush textBrush, SimpleFont font, TextAlignment alignment, Brush outlineBrush, Brush areaBrush, Int32 areaOpacity, DashStyleHelper outlineDashStyle, Int32 outlineWidth, Boolean isGlobal, String templateName);
        /// <summary>
        /// Text method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="text">String</param>
        /// <param name="time">DateTime</param>
        /// <param name="y">Double</param>
        /// <param name="yPixelOffset">Int32</param>
        /// <param name="textBrush">Brush</param>
        /// <param name="font">SimpleFont</param>
        /// <param name="alignment">TextAlignment</param>
        /// <param name="outlineBrush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="outlineDashStyle">DashStyleHelper</param>
        /// <param name="outlineWidth">Int32</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>Text</returns>
        public Text Text(NinjaScriptBase owner, String tag, Boolean isAutoScale, String text, DateTime time, Double y, Int32 yPixelOffset, Brush textBrush, SimpleFont font, TextAlignment alignment, Brush outlineBrush, Brush areaBrush, Int32 areaOpacity, DashStyleHelper outlineDashStyle, Int32 outlineWidth, Boolean isGlobal, String templateName);
        /// <summary>
        /// TextFixed method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="text">String</param>
        /// <param name="textPosition">TextPosition</param>
        /// <param name="textBrush">Brush</param>
        /// <param name="font">SimpleFont</param>
        /// <param name="outlineBrush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>TextFixed</returns>
        public TextFixed TextFixed(NinjaScriptBase owner, String tag, String text, TextPosition textPosition, Brush textBrush, SimpleFont font, Brush outlineBrush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// TextFixed method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="text">String</param>
        /// <param name="textPosition">TextPosition</param>
        /// <param name="textBrush">Brush</param>
        /// <param name="font">SimpleFont</param>
        /// <param name="outlineBrush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="outlineDashStyle">DashStyleHelper</param>
        /// <param name="outlineWidth">Int32</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TextFixed</returns>
        public TextFixed TextFixed(NinjaScriptBase owner, String tag, String text, TextPosition textPosition, Brush textBrush, SimpleFont font, Brush outlineBrush, Brush areaBrush, Int32 areaOpacity, DashStyleHelper outlineDashStyle, Int32 outlineWidth, Boolean isGlobal, String templateName);
        /// <summary>
        /// TextFixed method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="text">String</param>
        /// <param name="textPosition">TextPosition</param>
        /// <returns>TextFixed</returns>
        public TextFixed TextFixed(NinjaScriptBase owner, String tag, String text, TextPosition textPosition);
        /// <summary>
        /// TextFixed method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="text">String</param>
        /// <param name="textPosition">TextPosition</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TextFixed</returns>
        public TextFixed TextFixed(NinjaScriptBase owner, String tag, String text, TextPosition textPosition, Boolean isGlobal, String templateName);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Brush brush);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Brush brush);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Brush brush, Brush areaBrush, Int32 areaOpacity);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Brush brush, Brush areaBrush, Int32 areaOpacity, Boolean drawOnPricePanel);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Brush brush, Boolean drawOnPricePanel);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="brush">Brush</param>
        /// <param name="areaBrush">Brush</param>
        /// <param name="areaOpacity">Int32</param>
        /// <param name="drawOnPricePanel">Boolean</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Brush brush, Brush areaBrush, Int32 areaOpacity, Boolean drawOnPricePanel);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, Int32 startBarsAgo, Int32 endBarsAgo, Boolean isGlobal, String templateName);
        /// <summary>
        /// TimeCycles method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="startTime">DateTime</param>
        /// <param name="endTime">DateTime</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TimeCycles</returns>
        public TimeCycles TimeCycles(NinjaScriptBase owner, String tag, DateTime startTime, DateTime endTime, Boolean isGlobal, String templateName);
        /// <summary>
        /// TrendChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <returns>TrendChannel</returns>
        public TrendChannel TrendChannel(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y);
        /// <summary>
        /// TrendChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <returns>TrendChannel</returns>
        public TrendChannel TrendChannel(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y);
        /// <summary>
        /// TrendChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1BarsAgo">Int32</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2BarsAgo">Int32</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3BarsAgo">Int32</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TrendChannel</returns>
        public TrendChannel TrendChannel(NinjaScriptBase owner, String tag, Boolean isAutoScale, Int32 anchor1BarsAgo, Double anchor1Y, Int32 anchor2BarsAgo, Double anchor2Y, Int32 anchor3BarsAgo, Double anchor3Y, Boolean isGlobal, String templateName);
        /// <summary>
        /// TrendChannel method.
        /// </summary>
        /// <param name="owner">NinjaScriptBase</param>
        /// <param name="tag">String</param>
        /// <param name="isAutoScale">Boolean</param>
        /// <param name="anchor1Time">DateTime</param>
        /// <param name="anchor1Y">Double</param>
        /// <param name="anchor2Time">DateTime</param>
        /// <param name="anchor2Y">Double</param>
        /// <param name="anchor3Time">DateTime</param>
        /// <param name="anchor3Y">Double</param>
        /// <param name="isGlobal">Boolean</param>
        /// <param name="templateName">String</param>
        /// <returns>TrendChannel</returns>
        public TrendChannel TrendChannel(NinjaScriptBase owner, String tag, Boolean isAutoScale, DateTime anchor1Time, Double anchor1Y, DateTime anchor2Time, Double anchor2Y, DateTime anchor3Time, Double anchor3Y, Boolean isGlobal, String templateName);
        #endregion
    }
}
