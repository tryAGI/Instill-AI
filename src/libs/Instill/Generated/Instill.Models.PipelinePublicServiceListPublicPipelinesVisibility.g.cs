
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceListPublicPipelinesVisibility
    {
        /// <summary>
        /// Only the user can see the pipeline.
        /// </summary>
        VisibilityPrivate,
        /// <summary>
        /// Other users can see the pipeline.
        /// </summary>
        VisibilityPublic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceListPublicPipelinesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListPublicPipelinesVisibility value)
        {
            return value switch
            {
                PipelinePublicServiceListPublicPipelinesVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                PipelinePublicServiceListPublicPipelinesVisibility.VisibilityPublic => "VISIBILITY_PUBLIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListPublicPipelinesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_PRIVATE" => PipelinePublicServiceListPublicPipelinesVisibility.VisibilityPrivate,
                "VISIBILITY_PUBLIC" => PipelinePublicServiceListPublicPipelinesVisibility.VisibilityPublic,
                _ => null,
            };
        }
    }
}