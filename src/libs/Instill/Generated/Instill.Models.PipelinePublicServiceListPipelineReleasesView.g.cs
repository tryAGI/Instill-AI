
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceListPipelineReleasesView
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
    public static class PipelinePublicServiceListPipelineReleasesViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListPipelineReleasesView value)
        {
            return value switch
            {
                PipelinePublicServiceListPipelineReleasesView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceListPipelineReleasesView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceListPipelineReleasesView.ViewRecipe => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListPipelineReleasesView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceListPipelineReleasesView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceListPipelineReleasesView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceListPipelineReleasesView.ViewRecipe,
                _ => null,
            };
        }
    }
}