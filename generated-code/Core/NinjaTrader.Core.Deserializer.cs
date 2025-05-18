[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class Deserializer : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Adapter.
        /// </summary>
        [DataMember]
        public IAdapter Adapter { get; set; }
        /// <summary>
        /// Gets or sets the Api.
        /// </summary>
        [DataMember]
        public Api Api { get; set; }
        /// <summary>
        /// Gets or sets the Bytes.
        /// </summary>
        [DataMember]
        public Byte[] Bytes { get; set; }
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public IConnection Connection { get; set; }
        /// <summary>
        /// Gets or sets the DontProcessRealtimeData.
        /// </summary>
        [DataMember]
        public Boolean DontProcessRealtimeData { get; set; }
        /// <summary>
        /// Gets or sets the LargeString.
        /// </summary>
        [DataMember]
        public StringBuilder LargeString { get; set; }
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public Int32 Length { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTraderProxy NT { get; set; }
        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        [DataMember]
        public Int32 Position { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Deserialize method.
        /// </summary>
        /// <param name="bytes">Byte[]</param>
        /// <param name="offset">Int32</param>
        /// <param name="length">Int32</param>
        public Void Deserialize(Byte[] bytes, Int32 offset, Int32 length);
        /// <summary>
        /// Deserialize method.
        /// </summary>
        /// <param name="verifyEntitlement">Boolean</param>
        /// <returns>Object</returns>
        public Object Deserialize(Boolean verifyEntitlement);
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// OnError method.
        /// </summary>
        /// <param name="key">String</param>
        /// <param name="extra">String</param>
        public Void OnError(String key, String extra);
        /// <summary>
        /// ReadBoolean method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean ReadBoolean();
        /// <summary>
        /// ReadByte method.
        /// </summary>
        /// <returns>Byte</returns>
        public Byte ReadByte();
        /// <summary>
        /// ReadDateTime method.
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime ReadDateTime();
        /// <summary>
        /// ReadDateTimeUtc method.
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime ReadDateTimeUtc();
        /// <summary>
        /// ReadDouble method.
        /// </summary>
        /// <returns>Double</returns>
        public Double ReadDouble();
        /// <summary>
        /// ReadInt32 method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 ReadInt32();
        /// <summary>
        /// ReadInt64 method.
        /// </summary>
        /// <returns>Int64</returns>
        public Int64 ReadInt64();
        /// <summary>
        /// ReadServerId method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 ReadServerId();
        /// <summary>
        /// ReadString method.
        /// </summary>
        /// <returns>String</returns>
        public String ReadString();
        /// <summary>
        /// ReadUInt16 method.
        /// </summary>
        /// <returns>UInt16</returns>
        public UInt16 ReadUInt16();
        #endregion
    }
}
