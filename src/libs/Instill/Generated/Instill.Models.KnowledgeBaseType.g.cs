
#nullable enable

namespace Instill
{
    /// <summary>
    /// - KNOWLEDGE_BASE_TYPE_PERSISTENT: PERSISTENT<br/>
    ///  - KNOWLEDGE_BASE_TYPE_EPHEMERAL: EPHEMERAL
    /// </summary>
    public enum KnowledgeBaseType
    {
        /// <summary>
        /// PERSISTENT
        /// </summary>
        Persistent,
        /// <summary>
        /// EPHEMERAL
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseType value)
        {
            return value switch
            {
                KnowledgeBaseType.Persistent => "KNOWLEDGE_BASE_TYPE_PERSISTENT",
                KnowledgeBaseType.Ephemeral => "KNOWLEDGE_BASE_TYPE_EPHEMERAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseType? ToEnum(string value)
        {
            return value switch
            {
                "KNOWLEDGE_BASE_TYPE_PERSISTENT" => KnowledgeBaseType.Persistent,
                "KNOWLEDGE_BASE_TYPE_EPHEMERAL" => KnowledgeBaseType.Ephemeral,
                _ => null,
            };
        }
    }
}