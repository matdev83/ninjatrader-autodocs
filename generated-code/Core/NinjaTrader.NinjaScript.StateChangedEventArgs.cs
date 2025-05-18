[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class StateChangedEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AtmStrategy.
        /// </summary>
        [DataMember]
        public AtmStrategy AtmStrategy { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public State State { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
