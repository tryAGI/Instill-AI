
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.PipelineV1betaConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListNamespaceConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.MgmtV1betaConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TestConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TestNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RpcStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaConnectionMethod), TypeInfoPropertyName = "MgmtV1betaConnectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaView), TypeInfoPropertyName = "MgmtV1betaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaListPipelineIDsByConnectionIDResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaConnectionMethod), TypeInfoPropertyName = "PipelineV1betaConnectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaView), TypeInfoPropertyName = "PipelineV1betaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaListPipelineIDsByConnectionIDResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Any>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceUpdateNamespaceConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceUpdateConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceGetNamespaceConnectionView), TypeInfoPropertyName = "MgmtPublicServiceGetNamespaceConnectionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceGetConnectionView), TypeInfoPropertyName = "PipelinePublicServiceGetConnectionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaConnectionMethod?), TypeInfoPropertyName = "NullableMgmtV1betaConnectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaView?), TypeInfoPropertyName = "NullableMgmtV1betaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaConnectionMethod?), TypeInfoPropertyName = "NullablePipelineV1betaConnectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaView?), TypeInfoPropertyName = "NullablePipelineV1betaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceGetNamespaceConnectionView?), TypeInfoPropertyName = "NullableMgmtPublicServiceGetNamespaceConnectionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceGetConnectionView?), TypeInfoPropertyName = "NullablePipelinePublicServiceGetConnectionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.PipelineV1betaConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.MgmtV1betaConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Any>))]
    internal sealed partial class ConnectionSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectionSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ConnectionSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ConnectionSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Instill.MgmtV1betaConnectionMethod)

                    || typeToConvert == typeof(global::Instill.MgmtV1betaConnectionMethod?)

                    || typeToConvert == typeof(global::Instill.MgmtV1betaView)

                    || typeToConvert == typeof(global::Instill.MgmtV1betaView?)

                    || typeToConvert == typeof(global::Instill.PipelineV1betaConnectionMethod)

                    || typeToConvert == typeof(global::Instill.PipelineV1betaConnectionMethod?)

                    || typeToConvert == typeof(global::Instill.PipelineV1betaView)

                    || typeToConvert == typeof(global::Instill.PipelineV1betaView?)

                    || typeToConvert == typeof(global::Instill.MgmtPublicServiceGetNamespaceConnectionView)

                    || typeToConvert == typeof(global::Instill.MgmtPublicServiceGetNamespaceConnectionView?)

                    || typeToConvert == typeof(global::Instill.PipelinePublicServiceGetConnectionView)

                    || typeToConvert == typeof(global::Instill.PipelinePublicServiceGetConnectionView?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Instill.MgmtV1betaConnectionMethod))
                {
                    return new global::Instill.JsonConverters.MgmtV1betaConnectionMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.MgmtV1betaConnectionMethod?))
                {
                    return new global::Instill.JsonConverters.MgmtV1betaConnectionMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.MgmtV1betaView))
                {
                    return new global::Instill.JsonConverters.MgmtV1betaViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.MgmtV1betaView?))
                {
                    return new global::Instill.JsonConverters.MgmtV1betaViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.PipelineV1betaConnectionMethod))
                {
                    return new global::Instill.JsonConverters.PipelineV1betaConnectionMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.PipelineV1betaConnectionMethod?))
                {
                    return new global::Instill.JsonConverters.PipelineV1betaConnectionMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.PipelineV1betaView))
                {
                    return new global::Instill.JsonConverters.PipelineV1betaViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.PipelineV1betaView?))
                {
                    return new global::Instill.JsonConverters.PipelineV1betaViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.MgmtPublicServiceGetNamespaceConnectionView))
                {
                    return new global::Instill.JsonConverters.MgmtPublicServiceGetNamespaceConnectionViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.MgmtPublicServiceGetNamespaceConnectionView?))
                {
                    return new global::Instill.JsonConverters.MgmtPublicServiceGetNamespaceConnectionViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.PipelinePublicServiceGetConnectionView))
                {
                    return new global::Instill.JsonConverters.PipelinePublicServiceGetConnectionViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.PipelinePublicServiceGetConnectionView?))
                {
                    return new global::Instill.JsonConverters.PipelinePublicServiceGetConnectionViewNullableJsonConverter();
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
                    0 => new ConnectionSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}