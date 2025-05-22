[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class Deserializer : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Adapter.
        /// </summary>
        [DataMember]
        public NinjaTrader.Adapter.IAdapter Adapter { get; set; }
        /// <summary>
        /// Gets or sets the Api.
        /// </summary>
        [DataMember]
        public NinjaTrader.Server.Api Api { get; set; }
        /// <summary>
        /// Gets or sets the Bytes.
        /// </summary>
        [DataMember]
        public System.Byte[] Bytes { get; set; }
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.IConnection Connection { get; set; }
        /// <summary>
        /// Gets or sets the DontProcessRealtimeData.
        /// </summary>
        [DataMember]
        public bool DontProcessRealtimeData { get; set; }
        /// <summary>
        /// Gets or sets the LargeString.
        /// </summary>
        [DataMember]
        public System.Text.StringBuilder LargeString { get; set; }
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public int Length { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.NinjaTraderProxy NT { get; set; }
        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        [DataMember]
        public int Position { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Deserialize method.
        /// </summary>
        /// <param name="bytes">System.Byte[]</param>
        /// <param name="offset">int</param>
        /// <param name="length">int</param>
        public void Deserialize(System.Byte[] bytes, int offset, int length)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Deserialize method.
        /// </summary>
        /// <param name="verifyEntitlement">bool</param>
        /// <returns>object</returns>
        public object Deserialize(bool verifyEntitlement)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnError method.
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="extra">string</param>
        public void OnError(string key, string extra)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadBoolean method.
        /// </summary>
        /// <returns>bool</returns>
        public bool ReadBoolean()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadByte method.
        /// </summary>
        /// <returns>byte</returns>
        public byte ReadByte()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadDateTime method.
        /// </summary>
        /// <returns>System.DateTime</returns>
        public System.DateTime ReadDateTime()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadDateTimeUtc method.
        /// </summary>
        /// <returns>System.DateTime</returns>
        public System.DateTime ReadDateTimeUtc()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadDouble method.
        /// </summary>
        /// <returns>double</returns>
        public double ReadDouble()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadInt32 method.
        /// </summary>
        /// <returns>int</returns>
        public int ReadInt32()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadInt64 method.
        /// </summary>
        /// <returns>long</returns>
        public long ReadInt64()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadServerId method.
        /// </summary>
        /// <returns>int</returns>
        public int ReadServerId()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadString method.
        /// </summary>
        /// <returns>string</returns>
        public string ReadString()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadUInt16 method.
        /// </summary>
        /// <returns>ushort</returns>
        public ushort ReadUInt16()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
