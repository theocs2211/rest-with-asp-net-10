using System.Text.Json;
using System.Text.Json.Serialization;

namespace RestWithASPNET10.JsonSerializers
{
    public class GenderSerializer : JsonConverter<String>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString();
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            string ?formated;
            var v = value.ToLower();

            formated = v == "male" || v == "m" ? "M" :
                       v == "female" || v == "f" ? "F" :
                       null;

            writer.WriteStringValue(formated);
        }
    }
}
