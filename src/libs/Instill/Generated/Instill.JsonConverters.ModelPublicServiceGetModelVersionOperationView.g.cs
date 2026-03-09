#nullable enable

namespace Instill.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelPublicServiceGetModelVersionOperationViewJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Instill.ModelPublicServiceGetModelVersionOperationView>
    {
        /// <inheritdoc />
        public override global::Instill.ModelPublicServiceGetModelVersionOperationView Read(
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
                        return global::Instill.ModelPublicServiceGetModelVersionOperationViewExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Instill.ModelPublicServiceGetModelVersionOperationView)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Instill.ModelPublicServiceGetModelVersionOperationView);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Instill.ModelPublicServiceGetModelVersionOperationView value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Instill.ModelPublicServiceGetModelVersionOperationViewExtensions.ToValueString(value));
        }
    }
}
