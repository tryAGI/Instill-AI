
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceListPublicPipelinesView
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
    public static class PipelinePublicServiceListPublicPipelinesViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListPublicPipelinesView value)
        {
            return value switch
            {
                PipelinePublicServiceListPublicPipelinesView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceListPublicPipelinesView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceListPublicPipelinesView.ViewRecipe => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListPublicPipelinesView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceListPublicPipelinesView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceListPublicPipelinesView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceListPublicPipelinesView.ViewRecipe,
                _ => null,
            };
        }
    }
}