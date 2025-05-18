[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.StrategyGenerator
{
    public partial class GeneratedStrategyLogicBase : ICloneable
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// FromXml method.
        /// </summary>
        /// <param name="xml">XElement</param>
        public Void FromXml(XElement xml);
        /// <summary>
        /// OnBarUpdate method.
        /// </summary>
        /// <param name="strategy">StrategyBase</param>
        public Void OnBarUpdate(StrategyBase strategy);
        /// <summary>
        /// OnStateChange method.
        /// </summary>
        /// <param name="strategy">StrategyBase</param>
        public Void OnStateChange(StrategyBase strategy);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <param name="templateStrategy">StrategyBase</param>
        /// <returns>String</returns>
        public String ToString(StrategyBase templateStrategy);
        /// <summary>
        /// ToXml method.
        /// </summary>
        /// <returns>XElement</returns>
        public XElement ToXml();
        /// <summary>
        /// CreateInstance method.
        /// </summary>
        /// <param name="xml">XElement</param>
        /// <returns>GeneratedStrategyLogicBase</returns>
        public GeneratedStrategyLogicBase CreateInstance(XElement xml);
        #endregion
    }
}
