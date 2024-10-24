
#nullable enable

namespace Instill
{
    /// <summary>
    /// Method defines how the connection is set up.<br/>
    ///  - METHOD_DICTIONARY: Key-value collection. The user is responsible of fetching the connection<br/>
    /// details from the 3rd party service.<br/>
    ///  - METHOD_OAUTH: Access token created via OAuth 2.0 authorization.
    /// </summary>
    public enum ConnectionMethod
    {
        /// <summary>
        /// Key-value collection. The user is responsible of fetching the connection
        /// </summary>
        METHODDICTIONARY,
        /// <summary>
        /// Access token created via OAuth 2.0 authorization.
        /// </summary>
        METHODOAUTH,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectionMethod value)
        {
            return value switch
            {
                ConnectionMethod.METHODDICTIONARY => "METHOD_DICTIONARY",
                ConnectionMethod.METHODOAUTH => "METHOD_OAUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectionMethod? ToEnum(string value)
        {
            return value switch
            {
                "METHOD_DICTIONARY" => ConnectionMethod.METHODDICTIONARY,
                "METHOD_OAUTH" => ConnectionMethod.METHODOAUTH,
                _ => null,
            };
        }
    }
}