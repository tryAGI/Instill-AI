
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceGetPipelineReleaseView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
        /// <summary>
        /// Contains the recipe of the resource.
        /// </summary>
        ViewRecipe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceGetPipelineReleaseViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceGetPipelineReleaseView value)
        {
            return value switch
            {
                PipelinePublicServiceGetPipelineReleaseView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceGetPipelineReleaseView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceGetPipelineReleaseView.ViewRecipe => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceGetPipelineReleaseView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceGetPipelineReleaseView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceGetPipelineReleaseView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceGetPipelineReleaseView.ViewRecipe,
                _ => null,
            };
        }
    }
}