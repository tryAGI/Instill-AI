
#nullable enable

namespace Instill
{
    /// <summary>
    /// - CATALOG_TYPE_PERSISTENT: PERSISTENT<br/>
    ///  - CATALOG_TYPE_EPHEMERAL: EPHEMERAL
    /// </summary>
    public enum CatalogType
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
    public static class CatalogTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CatalogType value)
        {
            return value switch
            {
                CatalogType.Persistent => "CATALOG_TYPE_PERSISTENT",
                CatalogType.Ephemeral => "CATALOG_TYPE_EPHEMERAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CatalogType? ToEnum(string value)
        {
            return value switch
            {
                "CATALOG_TYPE_PERSISTENT" => CatalogType.Persistent,
                "CATALOG_TYPE_EPHEMERAL" => CatalogType.Ephemeral,
                _ => null,
            };
        }
    }
}