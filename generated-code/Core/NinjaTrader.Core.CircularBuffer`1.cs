[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class CircularBuffer`1
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public Int32 Count { get; set; }
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public Int32 Length { get; set; }
        /// <summary>
        /// Gets or sets the IsFull.
        /// </summary>
        [DataMember]
        public Boolean IsFull { get; set; }
        /// <summary>
        /// Gets or sets the IsEmpty.
        /// </summary>
        [DataMember]
        public Boolean IsEmpty { get; set; }
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
        public Void Add(T item);
        /// <summary>
        /// GetAll method.
        /// </summary>
        /// <returns>IEnumerable`1</returns>
        public IEnumerable<T> GetAll();
        /// <summary>
        /// GetLast method.
        /// </summary>
        /// <param name="num">Int32</param>
        /// <returns>IEnumerable`1</returns>
        public IEnumerable<T> GetLast(Int32 num);
        #endregion
    }
}
