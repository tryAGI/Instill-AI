
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
        /// file is chunking
        /// </summary>
        Chunking,
        /// <summary>
        /// completed
        /// </summary>
        Completed,
        /// <summary>
        /// file is embedding
        /// </summary>
        Embedding,
        /// <summary>
        /// failed
        /// </summary>
        Failed,
        /// <summary>
        /// NOTSTARTED
        /// </summary>
        Notstarted,
        /// <summary>
        /// file is being processed (parallel architecture: conversion + summarization)
        /// </summary>
        Processing,
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
                FileProcessStatus.Chunking => "FILE_PROCESS_STATUS_CHUNKING",
                FileProcessStatus.Completed => "FILE_PROCESS_STATUS_COMPLETED",
                FileProcessStatus.Embedding => "FILE_PROCESS_STATUS_EMBEDDING",
                FileProcessStatus.Failed => "FILE_PROCESS_STATUS_FAILED",
                FileProcessStatus.Notstarted => "FILE_PROCESS_STATUS_NOTSTARTED",
                FileProcessStatus.Processing => "FILE_PROCESS_STATUS_PROCESSING",
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
                "FILE_PROCESS_STATUS_CHUNKING" => FileProcessStatus.Chunking,
                "FILE_PROCESS_STATUS_COMPLETED" => FileProcessStatus.Completed,
                "FILE_PROCESS_STATUS_EMBEDDING" => FileProcessStatus.Embedding,
                "FILE_PROCESS_STATUS_FAILED" => FileProcessStatus.Failed,
                "FILE_PROCESS_STATUS_NOTSTARTED" => FileProcessStatus.Notstarted,
                "FILE_PROCESS_STATUS_PROCESSING" => FileProcessStatus.Processing,
                _ => null,
            };
        }
    }
}