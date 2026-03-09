
#nullable enable

namespace Instill
{
    /// <summary>
    /// - STORAGE_PROVIDER_MINIO: Use MinIO as the storage backend (default)<br/>
    ///  - STORAGE_PROVIDER_GCS: Use Google Cloud Storage as the storage backend
    /// </summary>
    public enum StorageProvider
    {
        /// <summary>
        /// Use MinIO as the storage backend (default)
        /// </summary>
        Minio,
        /// <summary>
        /// Use Google Cloud Storage as the storage backend
        /// </summary>
        Gcs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorageProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageProvider value)
        {
            return value switch
            {
                StorageProvider.Minio => "STORAGE_PROVIDER_MINIO",
                StorageProvider.Gcs => "STORAGE_PROVIDER_GCS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageProvider? ToEnum(string value)
        {
            return value switch
            {
                "STORAGE_PROVIDER_MINIO" => StorageProvider.Minio,
                "STORAGE_PROVIDER_GCS" => StorageProvider.Gcs,
                _ => null,
            };
        }
    }
}