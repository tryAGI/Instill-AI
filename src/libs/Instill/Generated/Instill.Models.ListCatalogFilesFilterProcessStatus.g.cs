
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
        FILEPROCESSSTATUSNOTSTARTED,
        /// <summary>
        /// file is waiting for embedding process
        /// </summary>
        FILEPROCESSSTATUSWAITING,
        /// <summary>
        /// file is converting
        /// </summary>
        FILEPROCESSSTATUSCONVERTING,
        /// <summary>
        /// file is chunking
        /// </summary>
        FILEPROCESSSTATUSCHUNKING,
        /// <summary>
        /// file is embedding
        /// </summary>
        FILEPROCESSSTATUSEMBEDDING,
        /// <summary>
        /// completed
        /// </summary>
        FILEPROCESSSTATUSCOMPLETED,
        /// <summary>
        /// failed
        /// </summary>
        FILEPROCESSSTATUSFAILED,
        /// <summary>
        /// file is summarizing
        /// </summary>
        FILEPROCESSSTATUSSUMMARIZING,
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
                ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSNOTSTARTED => "FILE_PROCESS_STATUS_NOTSTARTED",
                ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSWAITING => "FILE_PROCESS_STATUS_WAITING",
                ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSCONVERTING => "FILE_PROCESS_STATUS_CONVERTING",
                ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSCHUNKING => "FILE_PROCESS_STATUS_CHUNKING",
                ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSEMBEDDING => "FILE_PROCESS_STATUS_EMBEDDING",
                ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSCOMPLETED => "FILE_PROCESS_STATUS_COMPLETED",
                ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSFAILED => "FILE_PROCESS_STATUS_FAILED",
                ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSSUMMARIZING => "FILE_PROCESS_STATUS_SUMMARIZING",
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
                "FILE_PROCESS_STATUS_NOTSTARTED" => ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSNOTSTARTED,
                "FILE_PROCESS_STATUS_WAITING" => ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSWAITING,
                "FILE_PROCESS_STATUS_CONVERTING" => ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSCONVERTING,
                "FILE_PROCESS_STATUS_CHUNKING" => ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSCHUNKING,
                "FILE_PROCESS_STATUS_EMBEDDING" => ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSEMBEDDING,
                "FILE_PROCESS_STATUS_COMPLETED" => ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSCOMPLETED,
                "FILE_PROCESS_STATUS_FAILED" => ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSFAILED,
                "FILE_PROCESS_STATUS_SUMMARIZING" => ListCatalogFilesFilterProcessStatus.FILEPROCESSSTATUSSUMMARIZING,
                _ => null,
            };
        }
    }
}