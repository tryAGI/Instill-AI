
#nullable enable

namespace Instill
{
    /// <summary>
    /// - FILE_PROCESS_STATUS_NOTSTARTED: NOTSTARTED<br/>
    ///  - FILE_PROCESS_STATUS_PROCESSING: file is being processed (parallel architecture: conversion + summarization)<br/>
    ///  - FILE_PROCESS_STATUS_CHUNKING: file is chunking<br/>
    ///  - FILE_PROCESS_STATUS_EMBEDDING: file is embedding<br/>
    ///  - FILE_PROCESS_STATUS_COMPLETED: completed<br/>
    ///  - FILE_PROCESS_STATUS_FAILED: failed
    /// </summary>
    public enum FileProcessStatus
    {
        /// <summary>
        /// NOTSTARTED
        /// </summary>
        Notstarted,
        /// <summary>
        /// file is being processed (parallel architecture: conversion + summarization)
        /// </summary>
        Processing,
        /// <summary>
        /// file is chunking
        /// </summary>
        Chunking,
        /// <summary>
        /// file is embedding
        /// </summary>
        Embedding,
        /// <summary>
        /// completed
        /// </summary>
        Completed,
        /// <summary>
        /// failed
        /// </summary>
        Failed,
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
                FileProcessStatus.Notstarted => "FILE_PROCESS_STATUS_NOTSTARTED",
                FileProcessStatus.Processing => "FILE_PROCESS_STATUS_PROCESSING",
                FileProcessStatus.Chunking => "FILE_PROCESS_STATUS_CHUNKING",
                FileProcessStatus.Embedding => "FILE_PROCESS_STATUS_EMBEDDING",
                FileProcessStatus.Completed => "FILE_PROCESS_STATUS_COMPLETED",
                FileProcessStatus.Failed => "FILE_PROCESS_STATUS_FAILED",
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
                "FILE_PROCESS_STATUS_NOTSTARTED" => FileProcessStatus.Notstarted,
                "FILE_PROCESS_STATUS_PROCESSING" => FileProcessStatus.Processing,
                "FILE_PROCESS_STATUS_CHUNKING" => FileProcessStatus.Chunking,
                "FILE_PROCESS_STATUS_EMBEDDING" => FileProcessStatus.Embedding,
                "FILE_PROCESS_STATUS_COMPLETED" => FileProcessStatus.Completed,
                "FILE_PROCESS_STATUS_FAILED" => FileProcessStatus.Failed,
                _ => null,
            };
        }
    }
}