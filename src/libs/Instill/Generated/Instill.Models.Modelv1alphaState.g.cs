
#nullable enable

namespace Instill
{
    /// <summary>
    /// State describes the state of a model. See [Deploy<br/>
    /// Models](https://www.instill.tech/docs/latest/model/deploy) for more<br/>
    /// information.<br/>
    ///  - STATE_OFFLINE: Offline is the state when the model instance number is 0.<br/>
    ///  - STATE_ACTIVE: Active is the state when a model is processing requests.<br/>
    ///  - STATE_IDLE: Idle is the state when a model is alive but not processing requests.<br/>
    ///  - STATE_ERROR: Error is the state when the model is undeployable.<br/>
    ///  - STATE_STARTING: Starting is the state when the system is provisioning the necessary<br/>
    /// resources for the model<br/>
    ///  - STATE_SCALING_UP: Scaling Up is the transition state when the system is provisioning compute resource for this model instance.<br/>
    ///  - STATE_SCALING_DOWN: Scaling is the transition state when the system is releasing compute resource for this model instance.
    /// </summary>
    public enum Modelv1alphaState
    {
        /// <summary>
        /// Offline is the state when the model instance number is 0.
        /// </summary>
        STATEOFFLINE,
        /// <summary>
        /// Active is the state when a model is processing requests.
        /// </summary>
        STATEACTIVE,
        /// <summary>
        /// Idle is the state when a model is alive but not processing requests.
        /// </summary>
        STATEIDLE,
        /// <summary>
        /// Error is the state when the model is undeployable.
        /// </summary>
        STATEERROR,
        /// <summary>
        /// Starting is the state when the system is provisioning the necessary
        /// </summary>
        STATESTARTING,
        /// <summary>
        /// Scaling Up is the transition state when the system is provisioning compute resource for this model instance.
        /// </summary>
        STATESCALINGUP,
        /// <summary>
        /// Scaling is the transition state when the system is releasing compute resource for this model instance.
        /// </summary>
        STATESCALINGDOWN,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Modelv1alphaStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Modelv1alphaState value)
        {
            return value switch
            {
                Modelv1alphaState.STATEOFFLINE => "STATE_OFFLINE",
                Modelv1alphaState.STATEACTIVE => "STATE_ACTIVE",
                Modelv1alphaState.STATEIDLE => "STATE_IDLE",
                Modelv1alphaState.STATEERROR => "STATE_ERROR",
                Modelv1alphaState.STATESTARTING => "STATE_STARTING",
                Modelv1alphaState.STATESCALINGUP => "STATE_SCALING_UP",
                Modelv1alphaState.STATESCALINGDOWN => "STATE_SCALING_DOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Modelv1alphaState? ToEnum(string value)
        {
            return value switch
            {
                "STATE_OFFLINE" => Modelv1alphaState.STATEOFFLINE,
                "STATE_ACTIVE" => Modelv1alphaState.STATEACTIVE,
                "STATE_IDLE" => Modelv1alphaState.STATEIDLE,
                "STATE_ERROR" => Modelv1alphaState.STATEERROR,
                "STATE_STARTING" => Modelv1alphaState.STATESTARTING,
                "STATE_SCALING_UP" => Modelv1alphaState.STATESCALINGUP,
                "STATE_SCALING_DOWN" => Modelv1alphaState.STATESCALINGDOWN,
                _ => null,
            };
        }
    }
}