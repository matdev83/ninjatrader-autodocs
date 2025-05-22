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
        public bool AreBuffersExceeded { get; set; }
        /// <summary>
        /// Gets or sets the BytesBuffered.
        /// </summary>
        [DataMember]
        public int BytesBuffered { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.NinjaTraderProxy NT { get; set; }
        /// <summary>
        /// Gets or sets the NumBuffers.
        /// </summary>
        [DataMember]
        public int NumBuffers { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// FlowControl method.
        /// </summary>
        public void FlowControl()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.NinjaScript.AtmStrategy</param>
        /// <param name="version">int</param>
        public void Serialize(NinjaTrader.NinjaScript.AtmStrategy o, int version)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.Commission</param>
        public void Serialize(NinjaTrader.Cbi.Commission o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.IConnection</param>
        public void Serialize(NinjaTrader.Cbi.IConnection o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.CustomOrder</param>
        public void Serialize(NinjaTrader.Cbi.CustomOrder o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.HandshakeReply</param>
        public void Serialize(NinjaTrader.Cbi.HandshakeReply o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.HandshakeRequest</param>
        public void Serialize(NinjaTrader.Cbi.HandshakeRequest o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Data.Hotlist</param>
        public void Serialize(NinjaTrader.Data.Hotlist o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.Instrument</param>
        /// <param name="addToRepository">bool</param>
        public void Serialize(NinjaTrader.Cbi.Instrument o, bool addToRepository)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.InstrumentList</param>
        public void Serialize(NinjaTrader.Cbi.InstrumentList o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.MasterInstrument</param>
        /// <param name="addToRepository">bool</param>
        public void Serialize(NinjaTrader.Cbi.MasterInstrument o, bool addToRepository)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.Message</param>
        public void Serialize(NinjaTrader.Cbi.Message o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.Order</param>
        public void Serialize(NinjaTrader.Cbi.Order o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.Risk</param>
        public void Serialize(NinjaTrader.Cbi.Risk o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.RolloverCollection</param>
        /// <param name="name">string</param>
        public void Serialize(NinjaTrader.Cbi.RolloverCollection o, string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.StartupInfo</param>
        public void Serialize(NinjaTrader.Cbi.StartupInfo o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.StartupInfoComplete</param>
        public void Serialize(NinjaTrader.Cbi.StartupInfoComplete o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Server.Statistics</param>
        /// <param name="all">bool</param>
        public void Serialize(NinjaTrader.Server.Statistics o, bool all)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Data.TradingHours</param>
        /// <param name="addToRepository">bool</param>
        public void Serialize(NinjaTrader.Data.TradingHours o, bool addToRepository)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="b">byte</param>
        public void Serialize(byte b)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="array">System.Byte[]</param>
        public void Serialize(System.Byte[] array)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SerializeMarkEndOfMessage method.
        /// </summary>
        /// <param name="array">System.Byte[]</param>
        /// <param name="offset">int</param>
        /// <param name="length">int</param>
        /// <param name="numEvents">int</param>
        public void SerializeMarkEndOfMessage(System.Byte[] array, int offset, int length, int numEvents)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">bool</param>
        public void Serialize(bool value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="o">NinjaTrader.Cbi.IUserEntitlement</param>
        public void Serialize(NinjaTrader.Cbi.IUserEntitlement o)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">ushort</param>
        public void Serialize(ushort value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">string</param>
        public void Serialize(string value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">double</param>
        public void Serialize(double value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">int</param>
        public void Serialize(int value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">long</param>
        public void Serialize(long value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="value">System.DateTime</param>
        public void Serialize(System.DateTime value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SerializeServerId method.
        /// </summary>
        /// <param name="value">int</param>
        public void SerializeServerId(int value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SerializeToUtc method.
        /// </summary>
        /// <param name="value">System.DateTime</param>
        public void SerializeToUtc(System.DateTime value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToBytes method.
        /// </summary>
        /// <returns>System.Byte[]</returns>
        public System.Byte[] ToBytes()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
