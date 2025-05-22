[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class AssemblyRegistry
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public int Count { get; set; }
        /// <summary>
        /// Gets or sets the Keys.
        /// </summary>
        [DataMember]
        public System.String[] Keys { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public System.Reflection.Assembly Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="assemblyName">string</param>
        /// <param name="assembly">System.Reflection.Assembly</param>
        public void Add(string assemblyName, System.Reflection.Assembly assembly)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Clear method.
        /// </summary>
        public void Clear()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetDerivedTypes method.
        /// </summary>
        /// <param name="superClass">System.Type</param>
        /// <returns>System.Type[]</returns>
        public System.Type[] GetDerivedTypes(System.Type superClass)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetDerivedTypes method.
        /// </summary>
        /// <param name="superClass">System.Type</param>
        /// <param name="evalBrowsable">bool</param>
        /// <returns>System.Type[]</returns>
        public System.Type[] GetDerivedTypes(System.Type superClass, bool evalBrowsable)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetType method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>System.Type</returns>
        public System.Type GetType(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsNinjaTraderCustomAssembly method.
        /// </summary>
        /// <param name="type">System.Type</param>
        /// <returns>bool</returns>
        public bool IsNinjaTraderCustomAssembly(System.Type type)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>bool</returns>
        public bool Remove(string key)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TryGetValue method.
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="value">System.Reflection.Assembly&</param>
        /// <returns>bool</returns>
        public bool TryGetValue(string key, System.Reflection.Assembly& value)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
