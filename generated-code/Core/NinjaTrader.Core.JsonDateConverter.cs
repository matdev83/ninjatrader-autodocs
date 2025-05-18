[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class JsonDateConverter : JsonConverter<DateTime>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Read method.
        /// </summary>
        /// <param name="reader">Utf8JsonReader&</param>
        /// <param name="typeToConvert">Type</param>
        /// <param name="options">JsonSerializerOptions</param>
        /// <returns>DateTime</returns>
        public DateTime Read(Utf8JsonReader& reader, Type typeToConvert, JsonSerializerOptions options);
        /// <summary>
        /// Write method.
        /// </summary>
        /// <param name="writer">Utf8JsonWriter</param>
        /// <param name="dateTimeValue">DateTime</param>
        /// <param name="options">JsonSerializerOptions</param>
        public Void Write(Utf8JsonWriter writer, DateTime dateTimeValue, JsonSerializerOptions options);
        #endregion
    }
}
