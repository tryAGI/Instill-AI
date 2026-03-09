
#nullable enable

namespace Instill
{
    /// <summary>
    /// Method defines how the connection is set up.<br/>
    ///  - METHOD_DICTIONARY: Key-value collection. The user is responsible of fetching the connection<br/>
    /// details from the 3rd party service.<br/>
    ///  - METHOD_OAUTH: Access token created via OAuth 2.0 authorization.
    /// </summary>
    public enum PipelineV1betaConnectionMethod
    {
        /// <summary>
        /// Key-value collection. The user is responsible of fetching the connection
        /// </summary>
        MethodDictionary,
        /// <summary>
        /// Access token created via OAuth 2.0 authorization.
        /// </summary>
        MethodOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineV1betaConnectionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineV1betaConnectionMethod value)
        {
            return value switch
            {
                PipelineV1betaConnectionMethod.MethodDictionary => "METHOD_DICTIONARY",
                PipelineV1betaConnectionMethod.MethodOauth => "METHOD_OAUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineV1betaConnectionMethod? ToEnum(string value)
        {
            return value switch
            {
                "METHOD_DICTIONARY" => PipelineV1betaConnectionMethod.MethodDictionary,
                "METHOD_OAUTH" => PipelineV1betaConnectionMethod.MethodOauth,
                _ => null,
            };
        }
    }
}