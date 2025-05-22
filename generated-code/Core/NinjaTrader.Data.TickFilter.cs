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
        public double FilterBadTicksPercent { get; set; }
        /// <summary>
        /// Gets or sets the LastPrice.
        /// </summary>
        [DataMember]
        public double LastPrice { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public double Price { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnTick method.
        /// </summary>
        /// <returns>bool</returns>
        public bool OnTick()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
