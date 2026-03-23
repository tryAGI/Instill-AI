
#nullable enable

namespace Instill
{
    /// <summary>
    /// State describes the state of a model. See [Deploy<br/>
    /// Models](https://instill-ai.dev/docs/latest/model/deploy) for more<br/>
    /// information.<br/>
    ///  - STATE_OFFLINE: Offline is the state when the model instance number is 0.<br/>
    ///  - STATE_ACTIVE: Active is the state when a model is processing requests.<br/>
    ///  - STATE_IDLE: Idle is the state when a model is alive but not processing requests.<br/>
    ///  - STATE_ERROR: Error is the state when the model is undeployable.<br/>
    ///  - STATE_STARTING: Starting is the state when the system is provisioning the necessary<br/>
    /// resources for the model<br/>
    ///  - STATE_SCALING_UP: Scaling Up is the transition state when the system is provisioning compute<br/>
    /// resource for this model instance.<br/>
    ///  - STATE_SCALING_DOWN: Scaling is the transition state when the system is releasing compute<br/>
    /// resource for this model instance.
    /// </summary>
    public enum V1alphaState
    {
        /// <summary>
        /// Active is the state when a model is processing requests.
        /// </summary>
        StateActive,
        /// <summary>
        /// Error is the state when the model is undeployable.
        /// </summary>
        StateError,
        /// <summary>
        /// Idle is the state when a model is alive but not processing requests.
        /// </summary>
        StateIdle,
        /// <summary>
        /// Offline is the state when the model instance number is 0.
        /// </summary>
        StateOffline,
        /// <summary>
        /// Scaling is the transition state when the system is releasing compute
        /// </summary>
        StateScalingDown,
        /// <summary>
        /// Scaling Up is the transition state when the system is provisioning compute
        /// </summary>
        StateScalingUp,
        /// <summary>
        /// Starting is the state when the system is provisioning the necessary
        /// </summary>
        StateStarting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1alphaStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1alphaState value)
        {
            return value switch
            {
                V1alphaState.StateActive => "STATE_ACTIVE",
                V1alphaState.StateError => "STATE_ERROR",
                V1alphaState.StateIdle => "STATE_IDLE",
                V1alphaState.StateOffline => "STATE_OFFLINE",
                V1alphaState.StateScalingDown => "STATE_SCALING_DOWN",
                V1alphaState.StateScalingUp => "STATE_SCALING_UP",
                V1alphaState.StateStarting => "STATE_STARTING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1alphaState? ToEnum(string value)
        {
            return value switch
            {
                "STATE_ACTIVE" => V1alphaState.StateActive,
                "STATE_ERROR" => V1alphaState.StateError,
                "STATE_IDLE" => V1alphaState.StateIdle,
                "STATE_OFFLINE" => V1alphaState.StateOffline,
                "STATE_SCALING_DOWN" => V1alphaState.StateScalingDown,
                "STATE_SCALING_UP" => V1alphaState.StateScalingUp,
                "STATE_STARTING" => V1alphaState.StateStarting,
                _ => null,
            };
        }
    }
}