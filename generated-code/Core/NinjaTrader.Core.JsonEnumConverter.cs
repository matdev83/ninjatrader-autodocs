[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class JsonEnumConverter<TEnum> where TEnum : struct, System.Enum, System.ValueType : System.Text.Json.Serialization.JsonConverter<TEnum>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// CanConvert method.
        /// </summary>
        /// <param name="type">System.Type</param>
        /// <returns>bool</returns>
        public bool CanConvert(System.Type type)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Read method.
        /// </summary>
        /// <param name="reader">System.Text.Json.Utf8JsonReader&</param>
        /// <param name="typeToConvert">System.Type</param>
        /// <param name="options">System.Text.Json.JsonSerializerOptions</param>
        /// <returns>TEnum</returns>
        public TEnum Read(System.Text.Json.Utf8JsonReader& reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Write method.
        /// </summary>
        /// <param name="writer">System.Text.Json.Utf8JsonWriter</param>
        /// <param name="value">TEnum</param>
        /// <param name="options">System.Text.Json.JsonSerializerOptions</param>
        public void Write(System.Text.Json.Utf8JsonWriter writer, TEnum value, System.Text.Json.JsonSerializerOptions options)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
