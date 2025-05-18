[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class TickFilter
    {
        #region Properties
        /// <summary>
        /// Gets or sets the FilterBadTicksPercent.
        /// </summary>
        [DataMember]
        public Double FilterBadTicksPercent { get; set; }
        /// <summary>
        /// Gets or sets the LastPrice.
        /// </summary>
        [DataMember]
        public Double LastPrice { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public Double Price { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnTick method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean OnTick();
        #endregion
    }
}
