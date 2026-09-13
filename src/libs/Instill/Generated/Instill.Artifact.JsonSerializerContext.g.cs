
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Instill
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Any))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UserProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Chunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ChunkType), TypeInfoPropertyName = "ChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.KnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.EmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileType), TypeInfoPropertyName = "FileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileProcessStatus), TypeInfoPropertyName = "FileProcessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileVisibility), TypeInfoPropertyName = "FileVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileMediaType), TypeInfoPropertyName = "FileMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetChunkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetObjectDownloadURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Object), TypeInfoPropertyName = "Object_Instill_Object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetObjectUploadURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1betaUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.KnowledgeBaseType), TypeInfoPropertyName = "KnowledgeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Owner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Chunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.OrganizationProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.OrganizationStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Unit), TypeInfoPropertyName = "Unit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Ranker), TypeInfoPropertyName = "Ranker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ReprocessFileBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ReprocessFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.SearchChunksBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.SearchChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.SimilarityChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.SimilarityChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateChunkBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateChunkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateObjectBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateObjectBodyObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RpcStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Any>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceUpdateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceUpdateFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceListFilesView), TypeInfoPropertyName = "ArtifactPublicServiceListFilesView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceGetFileView), TypeInfoPropertyName = "ArtifactPublicServiceGetFileView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceGetFileStorageProvider), TypeInfoPropertyName = "ArtifactPublicServiceGetFileStorageProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceGetChunkChunkType), TypeInfoPropertyName = "ArtifactPublicServiceGetChunkChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ChunkType?), TypeInfoPropertyName = "NullableChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileType?), TypeInfoPropertyName = "NullableFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileProcessStatus?), TypeInfoPropertyName = "NullableFileProcessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileVisibility?), TypeInfoPropertyName = "NullableFileVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileMediaType?), TypeInfoPropertyName = "NullableFileMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.KnowledgeBaseType?), TypeInfoPropertyName = "NullableKnowledgeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Unit?), TypeInfoPropertyName = "NullableUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Ranker?), TypeInfoPropertyName = "NullableRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceListFilesView?), TypeInfoPropertyName = "NullableArtifactPublicServiceListFilesView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceGetFileView?), TypeInfoPropertyName = "NullableArtifactPublicServiceGetFileView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceGetFileStorageProvider?), TypeInfoPropertyName = "NullableArtifactPublicServiceGetFileStorageProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceGetChunkChunkType?), TypeInfoPropertyName = "NullableArtifactPublicServiceGetChunkChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Chunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.SimilarityChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Any>))]
    internal sealed partial class ArtifactSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArtifactSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ArtifactSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ArtifactSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Instill.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Instill.ChunkType)

                    || typeToConvert == typeof(global::Instill.ChunkType?)

                    || typeToConvert == typeof(global::Instill.FileType)

                    || typeToConvert == typeof(global::Instill.FileType?)

                    || typeToConvert == typeof(global::Instill.FileVisibility)

                    || typeToConvert == typeof(global::Instill.FileVisibility?)

                    || typeToConvert == typeof(global::Instill.FileMediaType)

                    || typeToConvert == typeof(global::Instill.FileMediaType?)

                    || typeToConvert == typeof(global::Instill.FileProcessStatus)

                    || typeToConvert == typeof(global::Instill.FileProcessStatus?)

                    || typeToConvert == typeof(global::Instill.KnowledgeBaseType)

                    || typeToConvert == typeof(global::Instill.KnowledgeBaseType?)

                    || typeToConvert == typeof(global::Instill.Ranker)

                    || typeToConvert == typeof(global::Instill.Ranker?)

                    || typeToConvert == typeof(global::Instill.Unit)

                    || typeToConvert == typeof(global::Instill.Unit?)

                    || typeToConvert == typeof(global::Instill.ArtifactPublicServiceListFilesView)

                    || typeToConvert == typeof(global::Instill.ArtifactPublicServiceListFilesView?)

                    || typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetFileView)

                    || typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetFileView?)

                    || typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetFileStorageProvider)

                    || typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetFileStorageProvider?)

                    || typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetChunkChunkType)

                    || typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetChunkChunkType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Instill.ChunkType))
                {
                    return new global::Instill.JsonConverters.ChunkTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ChunkType?))
                {
                    return new global::Instill.JsonConverters.ChunkTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.FileType))
                {
                    return new global::Instill.JsonConverters.FileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.FileType?))
                {
                    return new global::Instill.JsonConverters.FileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.FileVisibility))
                {
                    return new global::Instill.JsonConverters.FileVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.FileVisibility?))
                {
                    return new global::Instill.JsonConverters.FileVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.FileMediaType))
                {
                    return new global::Instill.JsonConverters.FileMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.FileMediaType?))
                {
                    return new global::Instill.JsonConverters.FileMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.FileProcessStatus))
                {
                    return new global::Instill.JsonConverters.FileProcessStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.FileProcessStatus?))
                {
                    return new global::Instill.JsonConverters.FileProcessStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.KnowledgeBaseType))
                {
                    return new global::Instill.JsonConverters.KnowledgeBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.KnowledgeBaseType?))
                {
                    return new global::Instill.JsonConverters.KnowledgeBaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.Ranker))
                {
                    return new global::Instill.JsonConverters.RankerJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.Ranker?))
                {
                    return new global::Instill.JsonConverters.RankerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.Unit))
                {
                    return new global::Instill.JsonConverters.UnitJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.Unit?))
                {
                    return new global::Instill.JsonConverters.UnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ArtifactPublicServiceListFilesView))
                {
                    return new global::Instill.JsonConverters.ArtifactPublicServiceListFilesViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ArtifactPublicServiceListFilesView?))
                {
                    return new global::Instill.JsonConverters.ArtifactPublicServiceListFilesViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetFileView))
                {
                    return new global::Instill.JsonConverters.ArtifactPublicServiceGetFileViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetFileView?))
                {
                    return new global::Instill.JsonConverters.ArtifactPublicServiceGetFileViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetFileStorageProvider))
                {
                    return new global::Instill.JsonConverters.ArtifactPublicServiceGetFileStorageProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetFileStorageProvider?))
                {
                    return new global::Instill.JsonConverters.ArtifactPublicServiceGetFileStorageProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetChunkChunkType))
                {
                    return new global::Instill.JsonConverters.ArtifactPublicServiceGetChunkChunkTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ArtifactPublicServiceGetChunkChunkType?))
                {
                    return new global::Instill.JsonConverters.ArtifactPublicServiceGetChunkChunkTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ArtifactSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}