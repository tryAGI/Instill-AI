
#nullable enable

namespace Instill
{
    /// <summary>
    /// - FILE_PROCESS_STATUS_NOTSTARTED: NOTSTARTED<br/>
    ///  - FILE_PROCESS_STATUS_WAITING: file is waiting for embedding process (deprecated - sequential architecture)<br/>
    ///  - FILE_PROCESS_STATUS_CONVERTING: file is converting (deprecated - sequential architecture)<br/>
    ///  - FILE_PROCESS_STATUS_CHUNKING: file is chunking<br/>
    ///  - FILE_PROCESS_STATUS_EMBEDDING: file is embedding<br/>
    ///  - FILE_PROCESS_STATUS_COMPLETED: completed<br/>
    ///  - FILE_PROCESS_STATUS_FAILED: failed<br/>
    ///  - FILE_PROCESS_STATUS_SUMMARIZING: file is summarizing (deprecated - sequential architecture)<br/>
    ///  - FILE_PROCESS_STATUS_PROCESSING: file is being processed (parallel architecture: conversion + summarization)
    /// </summary>
    public enum FileProcessStatus
    {
        /// <summary>
        /// NOTSTARTED
        /// </summary>
        NOTSTARTED,
        /// <summary>
        /// file is waiting for embedding process (deprecated - sequential architecture)
        /// </summary>
        WAITING,
        /// <summary>
        /// file is converting (deprecated - sequential architecture)
        /// </summary>
        CONVERTING,
        /// <summary>
        /// file is chunking
        /// </summary>
        CHUNKING,
        /// <summary>
        /// file is embedding
        /// </summary>
        EMBEDDING,
        /// <summary>
        /// completed
        /// </summary>
        COMPLETED,
        /// <summary>
        /// failed
        /// </summary>
        FAILED,
        /// <summary>
        /// file is summarizing (deprecated - sequential architecture)
        /// </summary>
        SUMMARIZING,
        /// <summary>
        /// file is being processed (parallel architecture: conversion + summarization)
        /// </summary>
        PROCESSING,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileProcessStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileProcessStatus value)
        {
            return value switch
            {
                FileProcessStatus.NOTSTARTED => "FILE_PROCESS_STATUS_NOTSTARTED",
                FileProcessStatus.WAITING => "FILE_PROCESS_STATUS_WAITING",
                FileProcessStatus.CONVERTING => "FILE_PROCESS_STATUS_CONVERTING",
                FileProcessStatus.CHUNKING => "FILE_PROCESS_STATUS_CHUNKING",
                FileProcessStatus.EMBEDDING => "FILE_PROCESS_STATUS_EMBEDDING",
                FileProcessStatus.COMPLETED => "FILE_PROCESS_STATUS_COMPLETED",
                FileProcessStatus.FAILED => "FILE_PROCESS_STATUS_FAILED",
                FileProcessStatus.SUMMARIZING => "FILE_PROCESS_STATUS_SUMMARIZING",
                FileProcessStatus.PROCESSING => "FILE_PROCESS_STATUS_PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileProcessStatus? ToEnum(string value)
        {
            return value switch
            {
                "FILE_PROCESS_STATUS_NOTSTARTED" => FileProcessStatus.NOTSTARTED,
                "FILE_PROCESS_STATUS_WAITING" => FileProcessStatus.WAITING,
                "FILE_PROCESS_STATUS_CONVERTING" => FileProcessStatus.CONVERTING,
                "FILE_PROCESS_STATUS_CHUNKING" => FileProcessStatus.CHUNKING,
                "FILE_PROCESS_STATUS_EMBEDDING" => FileProcessStatus.EMBEDDING,
                "FILE_PROCESS_STATUS_COMPLETED" => FileProcessStatus.COMPLETED,
                "FILE_PROCESS_STATUS_FAILED" => FileProcessStatus.FAILED,
                "FILE_PROCESS_STATUS_SUMMARIZING" => FileProcessStatus.SUMMARIZING,
                "FILE_PROCESS_STATUS_PROCESSING" => FileProcessStatus.PROCESSING,
                _ => null,
            };
        }
    }
}