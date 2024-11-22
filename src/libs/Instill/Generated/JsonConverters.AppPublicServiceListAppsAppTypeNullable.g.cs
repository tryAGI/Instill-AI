#nullable enable

namespace Instill.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppPublicServiceListAppsAppTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Instill.AppPublicServiceListAppsAppType?>
    {
        /// <inheritdoc />
        public override global::Instill.AppPublicServiceListAppsAppType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Instill.AppPublicServiceListAppsAppTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Instill.AppPublicServiceListAppsAppType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Instill.AppPublicServiceListAppsAppType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Instill.AppPublicServiceListAppsAppTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
