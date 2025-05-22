[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class Chunk
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public double TickSize { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
