[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TimePenalty
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PenaltyCaptcha.
        /// </summary>
        [DataMember]
        public bool PenaltyCaptcha { get; set; }
        /// <summary>
        /// Gets or sets the PenaltyTicket.
        /// </summary>
        [DataMember]
        public string PenaltyTicket { get; set; }
        /// <summary>
        /// Gets or sets the PenaltyTime.
        /// </summary>
        [DataMember]
        public int PenaltyTime { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
