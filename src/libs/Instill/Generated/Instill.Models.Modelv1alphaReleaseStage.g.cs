
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
    public enum Modelv1alphaReleaseStage
    {
        /// <summary>
        /// Alpha.
        /// </summary>
        RELEASESTAGEALPHA,
        /// <summary>
        /// Beta.
        /// </summary>
        RELEASESTAGEBETA,
        /// <summary>
        /// Generally available.
        /// </summary>
        RELEASESTAGEGENERALLYAVAILABLE,
        /// <summary>
        /// Custom.
        /// </summary>
        RELEASESTAGECUSTOM,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Modelv1alphaReleaseStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Modelv1alphaReleaseStage value)
        {
            return value switch
            {
                Modelv1alphaReleaseStage.RELEASESTAGEALPHA => "RELEASE_STAGE_ALPHA",
                Modelv1alphaReleaseStage.RELEASESTAGEBETA => "RELEASE_STAGE_BETA",
                Modelv1alphaReleaseStage.RELEASESTAGEGENERALLYAVAILABLE => "RELEASE_STAGE_GENERALLY_AVAILABLE",
                Modelv1alphaReleaseStage.RELEASESTAGECUSTOM => "RELEASE_STAGE_CUSTOM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Modelv1alphaReleaseStage? ToEnum(string value)
        {
            return value switch
            {
                "RELEASE_STAGE_ALPHA" => Modelv1alphaReleaseStage.RELEASESTAGEALPHA,
                "RELEASE_STAGE_BETA" => Modelv1alphaReleaseStage.RELEASESTAGEBETA,
                "RELEASE_STAGE_GENERALLY_AVAILABLE" => Modelv1alphaReleaseStage.RELEASESTAGEGENERALLYAVAILABLE,
                "RELEASE_STAGE_CUSTOM" => Modelv1alphaReleaseStage.RELEASESTAGECUSTOM,
                _ => null,
            };
        }
    }
}