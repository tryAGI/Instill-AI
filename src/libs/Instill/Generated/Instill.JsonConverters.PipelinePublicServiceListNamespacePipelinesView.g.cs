#nullable enable

namespace Instill.JsonConverters
{
    /// <inheritdoc />
    public sealed class PipelinePublicServiceListNamespacePipelinesViewJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Instill.PipelinePublicServiceListNamespacePipelinesView>
    {
        /// <inheritdoc />
        public override global::Instill.PipelinePublicServiceListNamespacePipelinesView Read(
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
                        return global::Instill.PipelinePublicServiceListNamespacePipelinesViewExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Instill.PipelinePublicServiceListNamespacePipelinesView)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Instill.PipelinePublicServiceListNamespacePipelinesView);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Instill.PipelinePublicServiceListNamespacePipelinesView value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Instill.PipelinePublicServiceListNamespacePipelinesViewExtensions.ToValueString(value));
        }
    }
}
