[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class PartialHoliday
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Constraint.
        /// </summary>
        [DataMember]
        public Session Constraint { get; set; }
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the IsEarlyEnd.
        /// </summary>
        [DataMember]
        public Boolean IsEarlyEnd { get; set; }
        /// <summary>
        /// Gets or sets the IsLateBegin.
        /// </summary>
        [DataMember]
        public Boolean IsLateBegin { get; set; }
        /// <summary>
        /// Gets or sets the Sessions.
        /// </summary>
        [DataMember]
        public Collection<Session> Sessions { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
