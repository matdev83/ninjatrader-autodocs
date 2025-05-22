[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class PlaybackIterator : System.IDisposable, System.Collections.IEnumerator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Current.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs Current { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// MoveNext method.
        /// </summary>
        /// <returns>bool</returns>
        public bool MoveNext()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reset method.
        /// </summary>
        public void Reset()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
