[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class CircularBuffer<T>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public int Count { get; set; }
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public int Length { get; set; }
        /// <summary>
        /// Gets or sets the IsFull.
        /// </summary>
        [DataMember]
        public bool IsFull { get; set; }
        /// <summary>
        /// Gets or sets the IsEmpty.
        /// </summary>
        [DataMember]
        public bool IsEmpty { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public T Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="item">T</param>
        public void Add(T item)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAll method.
        /// </summary>
        /// <returns>System.Collections.Generic.IEnumerable<T></returns>
        public System.Collections.Generic.IEnumerable<T> GetAll()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetLast method.
        /// </summary>
        /// <param name="num">int</param>
        /// <returns>System.Collections.Generic.IEnumerable<T></returns>
        public System.Collections.Generic.IEnumerable<T> GetLast(int num)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
