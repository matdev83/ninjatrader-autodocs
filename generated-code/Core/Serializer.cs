[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class Serializer
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AreBuffersExceeded.
        /// </summary>
        [DataMember]
        public Boolean AreBuffersExceeded { get; set; }
        /// <summary>
        /// Gets or sets the BytesBuffered.
        /// </summary>
        [DataMember]
        public Int32 BytesBuffered { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTraderProxy NT { get; set; }
        /// <summary>
        /// Gets or sets the NumBuffers.
        /// </summary>
        [DataMember]
        public Int32 NumBuffers { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// FlowControl method.
        /// </summary>
        public Void FlowControl();
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">AtmStrategy</param>
        /// <param name="version">Int32</param>
        public Void Serialize(AtmStrategy o, Int32 version);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">Commission</param>
        public Void Serialize(Commission o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">IConnection</param>
        public Void Serialize(IConnection o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">CustomOrder</param>
        public Void Serialize(CustomOrder o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">HandshakeReply</param>
        public Void Serialize(HandshakeReply o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">HandshakeRequest</param>
        public Void Serialize(HandshakeRequest o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">Hotlist</param>
        public Void Serialize(Hotlist o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">Instrument</param>
        /// <param name="addToRepository">Boolean</param>
        public Void Serialize(Instrument o, Boolean addToRepository);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">InstrumentList</param>
        public Void Serialize(InstrumentList o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">MasterInstrument</param>
        /// <param name="addToRepository">Boolean</param>
        public Void Serialize(MasterInstrument o, Boolean addToRepository);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">Message</param>
        public Void Serialize(Message o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">Order</param>
        public Void Serialize(Order o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">Risk</param>
        public Void Serialize(Risk o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">RolloverCollection</param>
        /// <param name="name">String</param>
        public Void Serialize(RolloverCollection o, String name);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">StartupInfo</param>
        public Void Serialize(StartupInfo o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">StartupInfoComplete</param>
        public Void Serialize(StartupInfoComplete o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">Statistics</param>
        /// <param name="all">Boolean</param>
        public Void Serialize(Statistics o, Boolean all);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">TradingHours</param>
        /// <param name="addToRepository">Boolean</param>
        public Void Serialize(TradingHours o, Boolean addToRepository);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="b">Byte</param>
        public Void Serialize(Byte b);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="array">Byte[]</param>
        public Void Serialize(Byte[] array);
        /// <summary>
        /// SerializeMarkEndOfMessage method.
        /// </summary>
        /// <param name="array">Byte[]</param>
        /// <param name="offset">Int32</param>
        /// <param name="length">Int32</param>
        /// <param name="numEvents">Int32</param>
        public Void SerializeMarkEndOfMessage(Byte[] array, Int32 offset, Int32 length, Int32 numEvents);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">Boolean</param>
        public Void Serialize(Boolean value);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">IUserEntitlement</param>
        public Void Serialize(IUserEntitlement o);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">UInt16</param>
        public Void Serialize(UInt16 value);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">String</param>
        public Void Serialize(String value);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">Double</param>
        public Void Serialize(Double value);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">Int32</param>
        public Void Serialize(Int32 value);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">Int64</param>
        public Void Serialize(Int64 value);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">DateTime</param>
        public Void Serialize(DateTime value);
        /// <summary>
        /// SerializeServerId method.
        /// </summary>
        /// <param name="value">Int32</param>
        public Void SerializeServerId(Int32 value);
        /// <summary>
        /// SerializeToUtc method.
        /// </summary>
        /// <param name="value">DateTime</param>
        public Void SerializeToUtc(DateTime value);
        /// <summary>
        /// ToBytes method.
        /// </summary>
        /// <returns>Byte[]</returns>
        public Byte[] ToBytes();
        #endregion
    }
}
