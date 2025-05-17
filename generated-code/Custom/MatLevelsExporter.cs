[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class MatLevelsExporter : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SaveDirectory.
        /// </summary>
        [DataMember]
        public String SaveDirectory { get; set; }
        /// <summary>
        /// Gets or sets the MaxVpocCalculationDaysBack.
        /// </summary>
        [DataMember]
        public Int32 MaxVpocCalculationDaysBack { get; set; }
        /// <summary>
        /// Gets or sets the VerboseDebugging.
        /// </summary>
        [DataMember]
        public Boolean VerboseDebugging { get; set; }
        /// <summary>
        /// Gets or sets the EuOpenHour.
        /// </summary>
        [DataMember]
        public Int32 EuOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the EuOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 EuOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the DisplayEuORDuringUsSession.
        /// </summary>
        [DataMember]
        public Boolean DisplayEuORDuringUsSession { get; set; }
        /// <summary>
        /// Gets or sets the LondonOpenHour.
        /// </summary>
        [DataMember]
        public Int32 LondonOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the LondonOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 LondonOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the UsOpenHour.
        /// </summary>
        [DataMember]
        public Int32 UsOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the UsOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 UsOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the NewSessionHour.
        /// </summary>
        [DataMember]
        public Int32 NewSessionHour { get; set; }
        /// <summary>
        /// Gets or sets the SettleHour.
        /// </summary>
        [DataMember]
        public Int32 SettleHour { get; set; }
        /// <summary>
        /// Gets or sets the SettleMinute.
        /// </summary>
        [DataMember]
        public Int32 SettleMinute { get; set; }
        /// <summary>
        /// Gets or sets the CmeCurrencyEuOpenHour.
        /// </summary>
        [DataMember]
        public Int32 CmeCurrencyEuOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the CmeCurrencyEuOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 CmeCurrencyEuOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the CmeCurrencyLondonOpenHour.
        /// </summary>
        [DataMember]
        public Int32 CmeCurrencyLondonOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the CmeCurrencyLondonOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 CmeCurrencyLondonOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the CmeCurrencyUsOpenHour.
        /// </summary>
        [DataMember]
        public Int32 CmeCurrencyUsOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the CmeCurrencyUsOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 CmeCurrencyUsOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the CmeCurrencyNewSessionHour.
        /// </summary>
        [DataMember]
        public Int32 CmeCurrencyNewSessionHour { get; set; }
        /// <summary>
        /// Gets or sets the CmeCurrencySettleHour.
        /// </summary>
        [DataMember]
        public Int32 CmeCurrencySettleHour { get; set; }
        /// <summary>
        /// Gets or sets the CmeCurrencySettleMinute.
        /// </summary>
        [DataMember]
        public Int32 CmeCurrencySettleMinute { get; set; }
        /// <summary>
        /// Gets or sets the CbotBondEuOpenHour.
        /// </summary>
        [DataMember]
        public Int32 CbotBondEuOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the CbotBondEuOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 CbotBondEuOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the CbotBondLondonOpenHour.
        /// </summary>
        [DataMember]
        public Int32 CbotBondLondonOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the CbotBondLondonOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 CbotBondLondonOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the CbotBondUsOpenHour.
        /// </summary>
        [DataMember]
        public Int32 CbotBondUsOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the CbotBondUsOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 CbotBondUsOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the CbotBondNewSessionHour.
        /// </summary>
        [DataMember]
        public Int32 CbotBondNewSessionHour { get; set; }
        /// <summary>
        /// Gets or sets the CbotBondSettleHour.
        /// </summary>
        [DataMember]
        public Int32 CbotBondSettleHour { get; set; }
        /// <summary>
        /// Gets or sets the CbotBondSettleMinute.
        /// </summary>
        [DataMember]
        public Int32 CbotBondSettleMinute { get; set; }
        /// <summary>
        /// Gets or sets the EurexIndexEuOpenHour.
        /// </summary>
        [DataMember]
        public Int32 EurexIndexEuOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexIndexEuOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 EurexIndexEuOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the EurexIndexLondonOpenHour.
        /// </summary>
        [DataMember]
        public Int32 EurexIndexLondonOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexIndexLondonOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 EurexIndexLondonOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the EurexIndexUsOpenHour.
        /// </summary>
        [DataMember]
        public Int32 EurexIndexUsOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexIndexUsOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 EurexIndexUsOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the EurexIndexNewSessionHour.
        /// </summary>
        [DataMember]
        public Int32 EurexIndexNewSessionHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexIndexSettleHour.
        /// </summary>
        [DataMember]
        public Int32 EurexIndexSettleHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexIndexSettleMinute.
        /// </summary>
        [DataMember]
        public Int32 EurexIndexSettleMinute { get; set; }
        /// <summary>
        /// Gets or sets the EurexBondEuOpenHour.
        /// </summary>
        [DataMember]
        public Int32 EurexBondEuOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexBondEuOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 EurexBondEuOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the EurexBondLondonOpenHour.
        /// </summary>
        [DataMember]
        public Int32 EurexBondLondonOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexBondLondonOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 EurexBondLondonOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the EurexBondUsOpenHour.
        /// </summary>
        [DataMember]
        public Int32 EurexBondUsOpenHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexBondUsOpenMinute.
        /// </summary>
        [DataMember]
        public Int32 EurexBondUsOpenMinute { get; set; }
        /// <summary>
        /// Gets or sets the EurexBondNewSessionHour.
        /// </summary>
        [DataMember]
        public Int32 EurexBondNewSessionHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexBondSettleHour.
        /// </summary>
        [DataMember]
        public Int32 EurexBondSettleHour { get; set; }
        /// <summary>
        /// Gets or sets the EurexBondSettleMinute.
        /// </summary>
        [DataMember]
        public Int32 EurexBondSettleMinute { get; set; }
        /// <summary>
        /// Gets or sets the DisplayAsianSessionHL.
        /// </summary>
        [DataMember]
        public Boolean DisplayAsianSessionHL { get; set; }
        /// <summary>
        /// Gets or sets the DisplayUsSessionAverageRange15.
        /// </summary>
        [DataMember]
        public Boolean DisplayUsSessionAverageRange15 { get; set; }
        /// <summary>
        /// Gets or sets the DisplayUsSessionAverageRange60.
        /// </summary>
        [DataMember]
        public Boolean DisplayUsSessionAverageRange60 { get; set; }
        /// <summary>
        /// Gets or sets the DisplayUsSessionTargets.
        /// </summary>
        [DataMember]
        public Boolean DisplayUsSessionTargets { get; set; }
        /// <summary>
        /// Gets or sets the Target1.
        /// </summary>
        [DataMember]
        public Double Target1 { get; set; }
        /// <summary>
        /// Gets or sets the Target2.
        /// </summary>
        [DataMember]
        public Double Target2 { get; set; }
        /// <summary>
        /// Gets or sets the Target3.
        /// </summary>
        [DataMember]
        public Double Target3 { get; set; }
        /// <summary>
        /// Gets or sets the Target4.
        /// </summary>
        [DataMember]
        public Double Target4 { get; set; }
        /// <summary>
        /// Gets or sets the Target5.
        /// </summary>
        [DataMember]
        public Double Target5 { get; set; }
        /// <summary>
        /// Gets or sets the Target6.
        /// </summary>
        [DataMember]
        public Double Target6 { get; set; }
        /// <summary>
        /// Gets or sets the DisplayEuSessionTargets.
        /// </summary>
        [DataMember]
        public Boolean DisplayEuSessionTargets { get; set; }
        /// <summary>
        /// Gets or sets the EuTarget1.
        /// </summary>
        [DataMember]
        public Double EuTarget1 { get; set; }
        /// <summary>
        /// Gets or sets the EuTarget2.
        /// </summary>
        [DataMember]
        public Double EuTarget2 { get; set; }
        /// <summary>
        /// Gets or sets the EuTarget3.
        /// </summary>
        [DataMember]
        public Double EuTarget3 { get; set; }
        /// <summary>
        /// Gets or sets the EuTarget4.
        /// </summary>
        [DataMember]
        public Double EuTarget4 { get; set; }
        /// <summary>
        /// Gets or sets the EuTarget5.
        /// </summary>
        [DataMember]
        public Double EuTarget5 { get; set; }
        /// <summary>
        /// Gets or sets the EuTarget6.
        /// </summary>
        [DataMember]
        public Double EuTarget6 { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// RoundToFraction method.
        /// </summary>
        /// <param name="number">Double</param>
        /// <param name="fraction">Double</param>
        /// <returns>Double</returns>
        public Double RoundToFraction(Double number, Double fraction);
        #endregion
    }
}
