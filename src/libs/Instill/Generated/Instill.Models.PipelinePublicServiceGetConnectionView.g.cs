
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceGetConnectionView
    {
        /// <summary>
        /// Default view.
        /// </summary>
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceGetConnectionViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceGetConnectionView value)
        {
            return value switch
            {
                PipelinePublicServiceGetConnectionView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceGetConnectionView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceGetConnectionView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceGetConnectionView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceGetConnectionView.ViewFull,
                _ => null,
            };
        }
    }
}