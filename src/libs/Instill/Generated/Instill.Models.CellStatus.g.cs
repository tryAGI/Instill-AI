
#nullable enable

namespace Instill
{
    /// <summary>
    /// CellStatus represents the status of a cell.<br/>
    ///  - CELL_STATUS_IDLE: The cell is idle.<br/>
    ///  - CELL_STATUS_UPLOADING: The cell is uploading (only for file cells).<br/>
    ///  - CELL_STATUS_PENDING: The cell is pending.<br/>
    ///  - CELL_STATUS_PROCESSING: The cell is processing.<br/>
    ///  - CELL_STATUS_FAILED: The cell is failed.<br/>
    ///  - CELL_STATUS_COMPLETED: The cell is completed.
    /// </summary>
    public enum CellStatus
    {
        /// <summary>
        /// The cell is idle.
        /// </summary>
        IDLE,
        /// <summary>
        /// The cell is uploading (only for file cells).
        /// </summary>
        UPLOADING,
        /// <summary>
        /// The cell is pending.
        /// </summary>
        PENDING,
        /// <summary>
        /// The cell is processing.
        /// </summary>
        PROCESSING,
        /// <summary>
        /// The cell is failed.
        /// </summary>
        FAILED,
        /// <summary>
        /// The cell is completed.
        /// </summary>
        COMPLETED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CellStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CellStatus value)
        {
            return value switch
            {
                CellStatus.IDLE => "CELL_STATUS_IDLE",
                CellStatus.UPLOADING => "CELL_STATUS_UPLOADING",
                CellStatus.PENDING => "CELL_STATUS_PENDING",
                CellStatus.PROCESSING => "CELL_STATUS_PROCESSING",
                CellStatus.FAILED => "CELL_STATUS_FAILED",
                CellStatus.COMPLETED => "CELL_STATUS_COMPLETED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CellStatus? ToEnum(string value)
        {
            return value switch
            {
                "CELL_STATUS_IDLE" => CellStatus.IDLE,
                "CELL_STATUS_UPLOADING" => CellStatus.UPLOADING,
                "CELL_STATUS_PENDING" => CellStatus.PENDING,
                "CELL_STATUS_PROCESSING" => CellStatus.PROCESSING,
                "CELL_STATUS_FAILED" => CellStatus.FAILED,
                "CELL_STATUS_COMPLETED" => CellStatus.COMPLETED,
                _ => null,
            };
        }
    }
}