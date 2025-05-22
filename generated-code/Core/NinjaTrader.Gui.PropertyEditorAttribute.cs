[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class PropertyEditorAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EditorType.
        /// </summary>
        [DataMember]
        public string EditorType { get; set; }
        /// <summary>
        /// Gets or sets the Filter.
        /// </summary>
        [DataMember]
        public string Filter { get; set; }
        /// <summary>
        /// Gets or sets the InitialDirectory.
        /// </summary>
        [DataMember]
        public string InitialDirectory { get; set; }
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        [DataMember]
        public string Title { get; set; }
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
