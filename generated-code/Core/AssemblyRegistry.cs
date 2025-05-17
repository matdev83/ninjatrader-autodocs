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
        public Int32 Count { get; set; }
        /// <summary>
        /// Gets or sets the Keys.
        /// </summary>
        [DataMember]
        public String[] Keys { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public Assembly Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="assemblyName">String</param>
        /// <param name="assembly">Assembly</param>
        public Void Add(String assemblyName, Assembly assembly);
        /// <summary>
        /// Clear method.
        /// </summary>
        public Void Clear();
        /// <summary>
        /// GetDerivedTypes method.
        /// </summary>
        /// <param name="superClass">Type</param>
        /// <returns>Type[]</returns>
        public Type[] GetDerivedTypes(Type superClass);
        /// <summary>
        /// GetDerivedTypes method.
        /// </summary>
        /// <param name="superClass">Type</param>
        /// <param name="evalBrowsable">Boolean</param>
        /// <returns>Type[]</returns>
        public Type[] GetDerivedTypes(Type superClass, Boolean evalBrowsable);
        /// <summary>
        /// GetType method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Type</returns>
        public Type GetType(String name);
        /// <summary>
        /// IsNinjaTraderCustomAssembly method.
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>Boolean</returns>
        public Boolean IsNinjaTraderCustomAssembly(Type type);
        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="key">String</param>
        /// <returns>Boolean</returns>
        public Boolean Remove(String key);
        /// <summary>
        /// TryGetValue method.
        /// </summary>
        /// <param name="key">String</param>
        /// <param name="value">Assembly&</param>
        /// <returns>Boolean</returns>
        public Boolean TryGetValue(String key, Assembly& value);
        #endregion
    }
}
