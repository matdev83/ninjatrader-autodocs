[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class ChangedEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the NinjaScriptBase.
        /// </summary>
        [DataMember]
        public NinjaScriptBase NinjaScriptBase { get; set; }
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
