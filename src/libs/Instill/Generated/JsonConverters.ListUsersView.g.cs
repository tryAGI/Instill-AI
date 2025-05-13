#nullable enable

namespace Instill.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListUsersViewJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Instill.ListUsersView>
    {
        /// <inheritdoc />
        public override global::Instill.ListUsersView Read(
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
                        return global::Instill.ListUsersViewExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Instill.ListUsersView)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Instill.ListUsersView);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Instill.ListUsersView value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Instill.ListUsersViewExtensions.ToValueString(value));
        }
    }
}
