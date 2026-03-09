
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCatalogFilesFilterProcessStatus
    {
        /// <summary>
        /// NOTSTARTED
        /// </summary>
        FileProcessStatusNotstarted,
        /// <summary>
        /// file is waiting for embedding process (deprecated - sequential architecture)
        /// </summary>
        FileProcessStatusWaiting,
        /// <summary>
        /// file is converting (deprecated - sequential architecture)
        /// </summary>
        FileProcessStatusConverting,
        /// <summary>
        /// file is chunking
        /// </summary>
        FileProcessStatusChunking,
        /// <summary>
        /// file is embedding
        /// </summary>
        FileProcessStatusEmbedding,
        /// <summary>
        /// completed
        /// </summary>
        FileProcessStatusCompleted,
        /// <summary>
        /// failed
        /// </summary>
        FileProcessStatusFailed,
        /// <summary>
        /// file is summarizing (deprecated - sequential architecture)
        /// </summary>
        FileProcessStatusSummarizing,
        /// <summary>
        /// file is being processed (parallel architecture: conversion + summarization)
        /// </summary>
        FileProcessStatusProcessing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCatalogFilesFilterProcessStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCatalogFilesFilterProcessStatus value)
        {
            return value switch
            {
                ListCatalogFilesFilterProcessStatus.FileProcessStatusNotstarted => "FILE_PROCESS_STATUS_NOTSTARTED",
                ListCatalogFilesFilterProcessStatus.FileProcessStatusWaiting => "FILE_PROCESS_STATUS_WAITING",
                ListCatalogFilesFilterProcessStatus.FileProcessStatusConverting => "FILE_PROCESS_STATUS_CONVERTING",
                ListCatalogFilesFilterProcessStatus.FileProcessStatusChunking => "FILE_PROCESS_STATUS_CHUNKING",
                ListCatalogFilesFilterProcessStatus.FileProcessStatusEmbedding => "FILE_PROCESS_STATUS_EMBEDDING",
                ListCatalogFilesFilterProcessStatus.FileProcessStatusCompleted => "FILE_PROCESS_STATUS_COMPLETED",
                ListCatalogFilesFilterProcessStatus.FileProcessStatusFailed => "FILE_PROCESS_STATUS_FAILED",
                ListCatalogFilesFilterProcessStatus.FileProcessStatusSummarizing => "FILE_PROCESS_STATUS_SUMMARIZING",
                ListCatalogFilesFilterProcessStatus.FileProcessStatusProcessing => "FILE_PROCESS_STATUS_PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCatalogFilesFilterProcessStatus? ToEnum(string value)
        {
            return value switch
            {
                "FILE_PROCESS_STATUS_NOTSTARTED" => ListCatalogFilesFilterProcessStatus.FileProcessStatusNotstarted,
                "FILE_PROCESS_STATUS_WAITING" => ListCatalogFilesFilterProcessStatus.FileProcessStatusWaiting,
                "FILE_PROCESS_STATUS_CONVERTING" => ListCatalogFilesFilterProcessStatus.FileProcessStatusConverting,
                "FILE_PROCESS_STATUS_CHUNKING" => ListCatalogFilesFilterProcessStatus.FileProcessStatusChunking,
                "FILE_PROCESS_STATUS_EMBEDDING" => ListCatalogFilesFilterProcessStatus.FileProcessStatusEmbedding,
                "FILE_PROCESS_STATUS_COMPLETED" => ListCatalogFilesFilterProcessStatus.FileProcessStatusCompleted,
                "FILE_PROCESS_STATUS_FAILED" => ListCatalogFilesFilterProcessStatus.FileProcessStatusFailed,
                "FILE_PROCESS_STATUS_SUMMARIZING" => ListCatalogFilesFilterProcessStatus.FileProcessStatusSummarizing,
                "FILE_PROCESS_STATUS_PROCESSING" => ListCatalogFilesFilterProcessStatus.FileProcessStatusProcessing,
                _ => null,
            };
        }
    }
}