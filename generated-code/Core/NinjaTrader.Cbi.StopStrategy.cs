[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class StopStrategy : NinjaTrader.NinjaScript.IDisplayNameProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AutoBreakEvenPlus.
        /// </summary>
        [DataMember]
        public double AutoBreakEvenPlus { get; set; }
        /// <summary>
        /// Gets or sets the AutoBreakEvenProfitTrigger.
        /// </summary>
        [DataMember]
        public double AutoBreakEvenProfitTrigger { get; set; }
        /// <summary>
        /// Gets or sets the AutoTrailSteps.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.AutoTrailStep[] AutoTrailSteps { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the DisplayNameExtended.
        /// </summary>
        [DataMember]
        public string DisplayNameExtended { get; set; }
        /// <summary>
        /// Gets or sets the IsSimStopEnabled.
        /// </summary>
        [DataMember]
        public bool IsSimStopEnabled { get; set; }
        /// <summary>
        /// Gets or sets the VolumeTrigger.
        /// </summary>
        [DataMember]
        public int VolumeTrigger { get; set; }
        /// <summary>
        /// Gets or sets the Template.
        /// </summary>
        [DataMember]
        public string Template { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="stopStrategy">NinjaTrader.Cbi.StopStrategy</param>
        public void CopyTo(NinjaTrader.Cbi.StopStrategy stopStrategy)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="stopStrategy">NinjaTrader.Cbi.StopStrategy</param>
        /// <returns>bool</returns>
        public bool IsEqual(NinjaTrader.Cbi.StopStrategy stopStrategy)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
