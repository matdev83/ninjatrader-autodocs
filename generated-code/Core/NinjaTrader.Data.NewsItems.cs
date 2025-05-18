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
        public Collection<NewsEventArgs> Items { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="e">NewsEventArgs</param>
        /// <returns>Boolean</returns>
        public Boolean Update(NewsEventArgs e);
        #endregion
    }
}
