[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class MMMTimingShortTradeRTYwithADXFilter : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the malen.
        /// </summary>
        [DataMember]
        public Int32 malen { get; set; }
        /// <summary>
        /// Gets or sets the devmult.
        /// </summary>
        [DataMember]
        public Double devmult { get; set; }
        /// <summary>
        /// Gets or sets the atrlen.
        /// </summary>
        [DataMember]
        public Int32 atrlen { get; set; }
        /// <summary>
        /// Gets or sets the atrmult.
        /// </summary>
        [DataMember]
        public Double atrmult { get; set; }
        /// <summary>
        /// Gets or sets the slarmult.
        /// </summary>
        [DataMember]
        public Double slarmult { get; set; }
        /// <summary>
        /// Gets or sets the trendmalen.
        /// </summary>
        [DataMember]
        public Int32 trendmalen { get; set; }
        /// <summary>
        /// Gets or sets the minvix.
        /// </summary>
        [DataMember]
        public Double minvix { get; set; }
        /// <summary>
        /// Gets or sets the maxvix.
        /// </summary>
        [DataMember]
        public Double maxvix { get; set; }
        /// <summary>
        /// Gets or sets the dmaxpriceratio.
        /// </summary>
        [DataMember]
        public Double dmaxpriceratio { get; set; }
        /// <summary>
        /// Gets or sets the dilen.
        /// </summary>
        [DataMember]
        public Int32 dilen { get; set; }
        /// <summary>
        /// Gets or sets the adxlen.
        /// </summary>
        [DataMember]
        public Int32 adxlen { get; set; }
        /// <summary>
        /// Gets or sets the mindom.
        /// </summary>
        [DataMember]
        public Int32 mindom { get; set; }
        /// <summary>
        /// Gets or sets the maxdom.
        /// </summary>
        [DataMember]
        public Int32 maxdom { get; set; }
        /// <summary>
        /// Gets or sets the dmalen.
        /// </summary>
        [DataMember]
        public Int32 dmalen { get; set; }
        /// <summary>
        /// Gets or sets the starth.
        /// </summary>
        [DataMember]
        public Int32 starth { get; set; }
        /// <summary>
        /// Gets or sets the startm.
        /// </summary>
        [DataMember]
        public Int32 startm { get; set; }
        /// <summary>
        /// Gets or sets the endh.
        /// </summary>
        [DataMember]
        public Int32 endh { get; set; }
        /// <summary>
        /// Gets or sets the endm.
        /// </summary>
        [DataMember]
        public Int32 endm { get; set; }
        /// <summary>
        /// Gets or sets the quith.
        /// </summary>
        [DataMember]
        public Int32 quith { get; set; }
        /// <summary>
        /// Gets or sets the quitm.
        /// </summary>
        [DataMember]
        public Int32 quitm { get; set; }
        /// <summary>
        /// Gets or sets the limitonetradeperday.
        /// </summary>
        [DataMember]
        public Boolean limitonetradeperday { get; set; }
        /// <summary>
        /// Gets or sets the longmon.
        /// </summary>
        [DataMember]
        public Boolean longmon { get; set; }
        /// <summary>
        /// Gets or sets the longtue.
        /// </summary>
        [DataMember]
        public Boolean longtue { get; set; }
        /// <summary>
        /// Gets or sets the longwed.
        /// </summary>
        [DataMember]
        public Boolean longwed { get; set; }
        /// <summary>
        /// Gets or sets the longthu.
        /// </summary>
        [DataMember]
        public Boolean longthu { get; set; }
        /// <summary>
        /// Gets or sets the longfri.
        /// </summary>
        [DataMember]
        public Boolean longfri { get; set; }
        /// <summary>
        /// Gets or sets the month1.
        /// </summary>
        [DataMember]
        public Boolean month1 { get; set; }
        /// <summary>
        /// Gets or sets the month2.
        /// </summary>
        [DataMember]
        public Boolean month2 { get; set; }
        /// <summary>
        /// Gets or sets the month3.
        /// </summary>
        [DataMember]
        public Boolean month3 { get; set; }
        /// <summary>
        /// Gets or sets the month4.
        /// </summary>
        [DataMember]
        public Boolean month4 { get; set; }
        /// <summary>
        /// Gets or sets the month5.
        /// </summary>
        [DataMember]
        public Boolean month5 { get; set; }
        /// <summary>
        /// Gets or sets the month6.
        /// </summary>
        [DataMember]
        public Boolean month6 { get; set; }
        /// <summary>
        /// Gets or sets the month7.
        /// </summary>
        [DataMember]
        public Boolean month7 { get; set; }
        /// <summary>
        /// Gets or sets the month8.
        /// </summary>
        [DataMember]
        public Boolean month8 { get; set; }
        /// <summary>
        /// Gets or sets the month9.
        /// </summary>
        [DataMember]
        public Boolean month9 { get; set; }
        /// <summary>
        /// Gets or sets the month10.
        /// </summary>
        [DataMember]
        public Boolean month10 { get; set; }
        /// <summary>
        /// Gets or sets the month11.
        /// </summary>
        [DataMember]
        public Boolean month11 { get; set; }
        /// <summary>
        /// Gets or sets the month12.
        /// </summary>
        [DataMember]
        public Boolean month12 { get; set; }
        /// <summary>
        /// Gets or sets the maxAdxAllowed.
        /// </summary>
        [DataMember]
        public Double maxAdxAllowed { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
