[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class OperationEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        [DataMember]
        public Operation Operation { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
