[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class JsonDateConverter : System.Text.Json.Serialization.JsonConverter<System.DateTime>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Read method.
        /// </summary>
        /// <param name="reader">System.Text.Json.Utf8JsonReader&</param>
        /// <param name="typeToConvert">System.Type</param>
        /// <param name="options">System.Text.Json.JsonSerializerOptions</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime Read(System.Text.Json.Utf8JsonReader& reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Write method.
        /// </summary>
        /// <param name="writer">System.Text.Json.Utf8JsonWriter</param>
        /// <param name="dateTimeValue">System.DateTime</param>
        /// <param name="options">System.Text.Json.JsonSerializerOptions</param>
        public void Write(System.Text.Json.Utf8JsonWriter writer, System.DateTime dateTimeValue, System.Text.Json.JsonSerializerOptions options)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
