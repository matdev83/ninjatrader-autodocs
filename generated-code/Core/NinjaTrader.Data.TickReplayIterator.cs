[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class TickReplayIterator : System.IDisposable, System.Collections.IEnumerator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Current.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.ReplayObject Current { get; set; }
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
