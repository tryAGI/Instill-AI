
#nullable enable

namespace Instill
{
    /// <summary>
    /// ReleaseStage defines the stage of a release.<br/>
    ///  - RELEASE_STAGE_ALPHA: Alpha.<br/>
    ///  - RELEASE_STAGE_BETA: Beta.<br/>
    ///  - RELEASE_STAGE_GENERALLY_AVAILABLE: Generally available.<br/>
    ///  - RELEASE_STAGE_CUSTOM: Custom.
    /// </summary>
    public enum V1alphaReleaseStage
    {
        /// <summary>
        /// Alpha.
        /// </summary>
        ReleaseStageAlpha,
        /// <summary>
        /// Beta.
        /// </summary>
        ReleaseStageBeta,
        /// <summary>
        /// Custom.
        /// </summary>
        ReleaseStageCustom,
        /// <summary>
        /// Generally available.
        /// </summary>
        ReleaseStageGenerallyAvailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1alphaReleaseStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1alphaReleaseStage value)
        {
            return value switch
            {
                V1alphaReleaseStage.ReleaseStageAlpha => "RELEASE_STAGE_ALPHA",
                V1alphaReleaseStage.ReleaseStageBeta => "RELEASE_STAGE_BETA",
                V1alphaReleaseStage.ReleaseStageCustom => "RELEASE_STAGE_CUSTOM",
                V1alphaReleaseStage.ReleaseStageGenerallyAvailable => "RELEASE_STAGE_GENERALLY_AVAILABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1alphaReleaseStage? ToEnum(string value)
        {
            return value switch
            {
                "RELEASE_STAGE_ALPHA" => V1alphaReleaseStage.ReleaseStageAlpha,
                "RELEASE_STAGE_BETA" => V1alphaReleaseStage.ReleaseStageBeta,
                "RELEASE_STAGE_CUSTOM" => V1alphaReleaseStage.ReleaseStageCustom,
                "RELEASE_STAGE_GENERALLY_AVAILABLE" => V1alphaReleaseStage.ReleaseStageGenerallyAvailable,
                _ => null,
            };
        }
    }
}