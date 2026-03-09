
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceGetPipelineView
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
    public static class PipelinePublicServiceGetPipelineViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceGetPipelineView value)
        {
            return value switch
            {
                PipelinePublicServiceGetPipelineView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceGetPipelineView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceGetPipelineView.ViewRecipe => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceGetPipelineView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceGetPipelineView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceGetPipelineView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceGetPipelineView.ViewRecipe,
                _ => null,
            };
        }
    }
}