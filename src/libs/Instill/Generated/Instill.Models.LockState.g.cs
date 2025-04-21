
#nullable enable

namespace Instill
{
    /// <summary>
    /// The lock state of a cell.<br/>
    ///  - LOCK_STATE_LOCKED: The cell is locked.<br/>
    ///  - LOCK_STATE_UNLOCKED: The cell is unlocked.
    /// </summary>
    public enum LockState
    {
        /// <summary>
        /// The cell is locked.
        /// </summary>
        LOCKED,
        /// <summary>
        /// The cell is unlocked.
        /// </summary>
        UNLOCKED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LockStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LockState value)
        {
            return value switch
            {
                LockState.LOCKED => "LOCK_STATE_LOCKED",
                LockState.UNLOCKED => "LOCK_STATE_UNLOCKED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LockState? ToEnum(string value)
        {
            return value switch
            {
                "LOCK_STATE_LOCKED" => LockState.LOCKED,
                "LOCK_STATE_UNLOCKED" => LockState.UNLOCKED,
                _ => null,
            };
        }
    }
}