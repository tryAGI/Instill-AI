#nullable enable

namespace Instill.JsonConverters
{
    /// <inheritdoc />
    public sealed class MembershipStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Instill.MembershipState>
    {
        /// <inheritdoc />
        public override global::Instill.MembershipState Read(
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
                        return global::Instill.MembershipStateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Instill.MembershipState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Instill.MembershipState);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Instill.MembershipState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Instill.MembershipStateExtensions.ToValueString(value));
        }
    }
}
