#nullable enable

namespace Instill.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelPublicServiceGetModelOperationViewNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Instill.ModelPublicServiceGetModelOperationView?>
    {
        /// <inheritdoc />
        public override global::Instill.ModelPublicServiceGetModelOperationView? Read(
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
                        return global::Instill.ModelPublicServiceGetModelOperationViewExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Instill.ModelPublicServiceGetModelOperationView)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Instill.ModelPublicServiceGetModelOperationView?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Instill.ModelPublicServiceGetModelOperationView? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Instill.ModelPublicServiceGetModelOperationViewExtensions.ToValueString(value.Value));
            }
        }
    }
}
