
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ArtifactPublicServiceGetFileStorageProvider
    {
        /// <summary>
        /// Returns MinIO
        /// </summary>
        StorageProviderMinio,
        /// <summary>
        /// Uploads file to GCS if not present (with cache
        /// </summary>
        StorageProviderGcs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArtifactPublicServiceGetFileStorageProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtifactPublicServiceGetFileStorageProvider value)
        {
            return value switch
            {
                ArtifactPublicServiceGetFileStorageProvider.StorageProviderMinio => "STORAGE_PROVIDER_MINIO",
                ArtifactPublicServiceGetFileStorageProvider.StorageProviderGcs => "STORAGE_PROVIDER_GCS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtifactPublicServiceGetFileStorageProvider? ToEnum(string value)
        {
            return value switch
            {
                "STORAGE_PROVIDER_MINIO" => ArtifactPublicServiceGetFileStorageProvider.StorageProviderMinio,
                "STORAGE_PROVIDER_GCS" => ArtifactPublicServiceGetFileStorageProvider.StorageProviderGcs,
                _ => null,
            };
        }
    }
}