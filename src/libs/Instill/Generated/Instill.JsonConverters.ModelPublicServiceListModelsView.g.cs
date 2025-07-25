#nullable enable

namespace Instill.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelPublicServiceListModelsViewJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Instill.ModelPublicServiceListModelsView>
    {
        /// <inheritdoc />
        public override global::Instill.ModelPublicServiceListModelsView Read(
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
                        return global::Instill.ModelPublicServiceListModelsViewExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Instill.ModelPublicServiceListModelsView)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Instill.ModelPublicServiceListModelsView);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Instill.ModelPublicServiceListModelsView value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Instill.ModelPublicServiceListModelsViewExtensions.ToValueString(value));
        }
    }
}
