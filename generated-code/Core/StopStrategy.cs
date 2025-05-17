[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class StopStrategy : IDisplayNameProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AutoBreakEvenPlus.
        /// </summary>
        [DataMember]
        public Double AutoBreakEvenPlus { get; set; }
        /// <summary>
        /// Gets or sets the AutoBreakEvenProfitTrigger.
        /// </summary>
        [DataMember]
        public Double AutoBreakEvenProfitTrigger { get; set; }
        /// <summary>
        /// Gets or sets the AutoTrailSteps.
        /// </summary>
        [DataMember]
        public AutoTrailStep[] AutoTrailSteps { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the DisplayNameExtended.
        /// </summary>
        [DataMember]
        public String DisplayNameExtended { get; set; }
        /// <summary>
        /// Gets or sets the IsSimStopEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsSimStopEnabled { get; set; }
        /// <summary>
        /// Gets or sets the VolumeTrigger.
        /// </summary>
        [DataMember]
        public Int32 VolumeTrigger { get; set; }
        /// <summary>
        /// Gets or sets the Template.
        /// </summary>
        [DataMember]
        public String Template { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="stopStrategy">StopStrategy</param>
        public Void CopyTo(StopStrategy stopStrategy);
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="stopStrategy">StopStrategy</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(StopStrategy stopStrategy);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
