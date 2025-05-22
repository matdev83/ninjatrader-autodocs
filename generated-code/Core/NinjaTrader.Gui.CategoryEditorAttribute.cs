[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class CategoryEditorAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EditorType.
        /// </summary>
        [DataMember]
        public string EditorType { get; set; }
        /// <summary>
        /// Gets or sets the CategoryName.
        /// </summary>
        [DataMember]
        public string CategoryName { get; set; }
        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        [DataMember]
        public System.Type ResourceType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>int</returns>
        public int GetHashCode()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>bool</returns>
        public bool Equals(object obj)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
