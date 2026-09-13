
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RunStatus), TypeInfoPropertyName = "RunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteModelVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetModelDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetModelOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.LongrunningOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetModelVersionOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1betaUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Hardware))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Owner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListAvailableRegionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Region>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Region))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelDefinitionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ModelDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelRunsByRequesterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ModelRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListPublicModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Task), TypeInfoPropertyName = "Task2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelVisibility), TypeInfoPropertyName = "ModelVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaReleaseStage), TypeInfoPropertyName = "V1alphaReleaseStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RunSource), TypeInfoPropertyName = "RunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaState), TypeInfoPropertyName = "V1alphaState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.OrganizationProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.OrganizationStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Hardware>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RenameModelBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RenameModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncModelBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncModelVersionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncModelVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerModelBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerModelVersionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerModelVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.WatchModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.WatchModelVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RpcStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Any>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaGetOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceUpdateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListModelDefinitionsView), TypeInfoPropertyName = "ModelPublicServiceListModelDefinitionsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelDefinitionView), TypeInfoPropertyName = "ModelPublicServiceGetModelDefinitionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListPublicModelsView), TypeInfoPropertyName = "ModelPublicServiceListPublicModelsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListPublicModelsVisibility), TypeInfoPropertyName = "ModelPublicServiceListPublicModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListModelsView), TypeInfoPropertyName = "ModelPublicServiceListModelsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListModelsVisibility), TypeInfoPropertyName = "ModelPublicServiceListModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelView), TypeInfoPropertyName = "ModelPublicServiceGetModelView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelVersionOperationView), TypeInfoPropertyName = "ModelPublicServiceGetModelVersionOperationView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelOperationView), TypeInfoPropertyName = "ModelPublicServiceGetModelOperationView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RunStatus?), TypeInfoPropertyName = "NullableRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Task?), TypeInfoPropertyName = "NullableTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelVisibility?), TypeInfoPropertyName = "NullableModelVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaReleaseStage?), TypeInfoPropertyName = "NullableV1alphaReleaseStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RunSource?), TypeInfoPropertyName = "NullableRunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaState?), TypeInfoPropertyName = "NullableV1alphaState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListModelDefinitionsView?), TypeInfoPropertyName = "NullableModelPublicServiceListModelDefinitionsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelDefinitionView?), TypeInfoPropertyName = "NullableModelPublicServiceGetModelDefinitionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListPublicModelsView?), TypeInfoPropertyName = "NullableModelPublicServiceListPublicModelsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListPublicModelsVisibility?), TypeInfoPropertyName = "NullableModelPublicServiceListPublicModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListModelsView?), TypeInfoPropertyName = "NullableModelPublicServiceListModelsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListModelsVisibility?), TypeInfoPropertyName = "NullableModelPublicServiceListModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelView?), TypeInfoPropertyName = "NullableModelPublicServiceGetModelView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelVersionOperationView?), TypeInfoPropertyName = "NullableModelPublicServiceGetModelVersionOperationView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelOperationView?), TypeInfoPropertyName = "NullableModelPublicServiceGetModelOperationView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Region>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ModelDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ModelRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Hardware>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Any>))]
    internal sealed partial class ModelSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModelSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModelSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Instill.ModelVisibility)

                    || typeToConvert == typeof(global::Instill.ModelVisibility?)

                    || typeToConvert == typeof(global::Instill.RunSource)

                    || typeToConvert == typeof(global::Instill.RunSource?)

                    || typeToConvert == typeof(global::Instill.RunStatus)

                    || typeToConvert == typeof(global::Instill.RunStatus?)

                    || typeToConvert == typeof(global::Instill.Task)

                    || typeToConvert == typeof(global::Instill.Task?)

                    || typeToConvert == typeof(global::Instill.V1alphaReleaseStage)

                    || typeToConvert == typeof(global::Instill.V1alphaReleaseStage?)

                    || typeToConvert == typeof(global::Instill.V1alphaState)

                    || typeToConvert == typeof(global::Instill.V1alphaState?)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListModelDefinitionsView)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListModelDefinitionsView?)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelDefinitionView)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelDefinitionView?)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListPublicModelsView)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListPublicModelsView?)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListPublicModelsVisibility)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListPublicModelsVisibility?)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListModelsView)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListModelsView?)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListModelsVisibility)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceListModelsVisibility?)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelView)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelView?)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelVersionOperationView)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelVersionOperationView?)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelOperationView)

                    || typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelOperationView?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Instill.ModelVisibility))
                {
                    return new global::Instill.JsonConverters.ModelVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelVisibility?))
                {
                    return new global::Instill.JsonConverters.ModelVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.RunSource))
                {
                    return new global::Instill.JsonConverters.RunSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.RunSource?))
                {
                    return new global::Instill.JsonConverters.RunSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.RunStatus))
                {
                    return new global::Instill.JsonConverters.RunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.RunStatus?))
                {
                    return new global::Instill.JsonConverters.RunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.Task))
                {
                    return new global::Instill.JsonConverters.TaskJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.Task?))
                {
                    return new global::Instill.JsonConverters.TaskNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.V1alphaReleaseStage))
                {
                    return new global::Instill.JsonConverters.V1alphaReleaseStageJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.V1alphaReleaseStage?))
                {
                    return new global::Instill.JsonConverters.V1alphaReleaseStageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.V1alphaState))
                {
                    return new global::Instill.JsonConverters.V1alphaStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.V1alphaState?))
                {
                    return new global::Instill.JsonConverters.V1alphaStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListModelDefinitionsView))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListModelDefinitionsViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListModelDefinitionsView?))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListModelDefinitionsViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelDefinitionView))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceGetModelDefinitionViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelDefinitionView?))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceGetModelDefinitionViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListPublicModelsView))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListPublicModelsViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListPublicModelsView?))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListPublicModelsViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListPublicModelsVisibility))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListPublicModelsVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListPublicModelsVisibility?))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListPublicModelsVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListModelsView))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListModelsViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListModelsView?))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListModelsViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListModelsVisibility))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListModelsVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceListModelsVisibility?))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceListModelsVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelView))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceGetModelViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelView?))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceGetModelViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelVersionOperationView))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceGetModelVersionOperationViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelVersionOperationView?))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceGetModelVersionOperationViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelOperationView))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceGetModelOperationViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ModelPublicServiceGetModelOperationView?))
                {
                    return new global::Instill.JsonConverters.ModelPublicServiceGetModelOperationViewNullableJsonConverter();
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
                    0 => new ModelSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}