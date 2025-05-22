[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class DrawingToolPropertyDescriptor : System.ComponentModel.PropertyDescriptor
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Attributes.
        /// </summary>
        [DataMember]
        public System.ComponentModel.AttributeCollection Attributes { get; set; }
        /// <summary>
        /// Gets or sets the ComponentType.
        /// </summary>
        [DataMember]
        public System.Type ComponentType { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the IsReadOnly.
        /// </summary>
        [DataMember]
        public bool IsReadOnly { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the PropertyType.
        /// </summary>
        [DataMember]
        public System.Type PropertyType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CanResetValue method.
        /// </summary>
        /// <param name="component">object</param>
        /// <returns>bool</returns>
        public bool CanResetValue(object component)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ShouldSerializeValue method.
        /// </summary>
        /// <param name="component">object</param>
        /// <returns>bool</returns>
        public bool ShouldSerializeValue(object component)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetValue method.
        /// </summary>
        /// <param name="component">object</param>
        /// <returns>object</returns>
        public object GetValue(object component)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ResetValue method.
        /// </summary>
        /// <param name="component">object</param>
        public void ResetValue(object component)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetValue method.
        /// </summary>
        /// <param name="component">object</param>
        /// <param name="value">object</param>
        public void SetValue(object component, object value)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
