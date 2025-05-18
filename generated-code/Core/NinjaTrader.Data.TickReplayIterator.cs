[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class TickReplayIterator : IDisposable, IEnumerator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Current.
        /// </summary>
        [DataMember]
        public ReplayObject Current { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// MoveNext method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean MoveNext();
        /// <summary>
        /// Reset method.
        /// </summary>
        public Void Reset();
        #endregion
    }
}
