
#nullable enable

namespace Instill
{
    /// <summary>
    /// - CITATION_EXTRACT_METHOD_TYPE_SELF: self generated<br/>
    ///  - CITATION_EXTRACT_METHOD_TYPE_WEB: extract from web search tool<br/>
    ///  - CITATION_EXTRACT_METHOD_TYPE_RAG: extract from RAG tool<br/>
    ///  - CITATION_EXTRACT_METHOD_TYPE_DEEP_ANALYSIS: extract from deep analysis tool
    /// </summary>
    public enum CitationExtractMethodType
    {
        /// <summary>
        /// self generated
        /// </summary>
        SELF,
        /// <summary>
        /// extract from web search tool
        /// </summary>
        WEB,
        /// <summary>
        /// extract from RAG tool
        /// </summary>
        RAG,
        /// <summary>
        /// extract from deep analysis tool
        /// </summary>
        DEEPANALYSIS,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationExtractMethodTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationExtractMethodType value)
        {
            return value switch
            {
                CitationExtractMethodType.SELF => "CITATION_EXTRACT_METHOD_TYPE_SELF",
                CitationExtractMethodType.WEB => "CITATION_EXTRACT_METHOD_TYPE_WEB",
                CitationExtractMethodType.RAG => "CITATION_EXTRACT_METHOD_TYPE_RAG",
                CitationExtractMethodType.DEEPANALYSIS => "CITATION_EXTRACT_METHOD_TYPE_DEEP_ANALYSIS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationExtractMethodType? ToEnum(string value)
        {
            return value switch
            {
                "CITATION_EXTRACT_METHOD_TYPE_SELF" => CitationExtractMethodType.SELF,
                "CITATION_EXTRACT_METHOD_TYPE_WEB" => CitationExtractMethodType.WEB,
                "CITATION_EXTRACT_METHOD_TYPE_RAG" => CitationExtractMethodType.RAG,
                "CITATION_EXTRACT_METHOD_TYPE_DEEP_ANALYSIS" => CitationExtractMethodType.DEEPANALYSIS,
                _ => null,
            };
        }
    }
}