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
        public NinjaTrader.Data.Session Constraint { get; set; }
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        [DataMember]
        public System.DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the IsEarlyEnd.
        /// </summary>
        [DataMember]
        public bool IsEarlyEnd { get; set; }
        /// <summary>
        /// Gets or sets the IsLateBegin.
        /// </summary>
        [DataMember]
        public bool IsLateBegin { get; set; }
        /// <summary>
        /// Gets or sets the Sessions.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Data.Session> Sessions { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
