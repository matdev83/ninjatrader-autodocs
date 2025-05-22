[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class NewsItems
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Items.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Data.NewsEventArgs> Items { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="e">NinjaTrader.Data.NewsEventArgs</param>
        /// <returns>bool</returns>
        public bool Update(NinjaTrader.Data.NewsEventArgs e)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
