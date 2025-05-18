[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class JsonEnumConverter`1 : JsonConverter<TEnum>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// CanConvert method.
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>Boolean</returns>
        public Boolean CanConvert(Type type);
        /// <summary>
        /// Read method.
        /// </summary>
        /// <param name="reader">Utf8JsonReader&</param>
        /// <param name="typeToConvert">Type</param>
        /// <param name="options">JsonSerializerOptions</param>
        /// <returns>TEnum</returns>
        public TEnum Read(Utf8JsonReader& reader, Type typeToConvert, JsonSerializerOptions options);
        /// <summary>
        /// Write method.
        /// </summary>
        /// <param name="writer">Utf8JsonWriter</param>
        /// <param name="value">TEnum</param>
        /// <param name="options">JsonSerializerOptions</param>
        public Void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options);
        #endregion
    }
}
