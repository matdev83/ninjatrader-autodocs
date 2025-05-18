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
        public Boolean PenaltyCaptcha { get; set; }
        /// <summary>
        /// Gets or sets the PenaltyTicket.
        /// </summary>
        [DataMember]
        public String PenaltyTicket { get; set; }
        /// <summary>
        /// Gets or sets the PenaltyTime.
        /// </summary>
        [DataMember]
        public Int32 PenaltyTime { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
