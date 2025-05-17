[Serializable]
[DataContract]
namespace NinjaTrader.Code
{
    public partial class OutputEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsReset.
        /// </summary>
        [DataMember]
        public Boolean IsReset { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public String Message { get; set; }
        /// <summary>
        /// Gets or sets the OutputTab.
        /// </summary>
        [DataMember]
        public PrintTo OutputTab { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
