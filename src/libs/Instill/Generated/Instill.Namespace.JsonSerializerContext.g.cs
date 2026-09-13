
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ApiToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ApiTokenState), TypeInfoPropertyName = "ApiTokenState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.AuthenticatedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.OnboardingStatus), TypeInfoPropertyName = "OnboardingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UserProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CheckNamespaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CheckNamespaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CheckNamespaceResponseNamespace), TypeInfoPropertyName = "CheckNamespaceResponseNamespace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetAuthenticatedUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1betaUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ApiToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.V1betaUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PatchAuthenticatedUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ValidateTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RpcStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Any>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceListUsersView), TypeInfoPropertyName = "MgmtPublicServiceListUsersView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceGetUserView), TypeInfoPropertyName = "MgmtPublicServiceGetUserView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ApiTokenState?), TypeInfoPropertyName = "NullableApiTokenState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.OnboardingStatus?), TypeInfoPropertyName = "NullableOnboardingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CheckNamespaceResponseNamespace?), TypeInfoPropertyName = "NullableCheckNamespaceResponseNamespace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceListUsersView?), TypeInfoPropertyName = "NullableMgmtPublicServiceListUsersView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceGetUserView?), TypeInfoPropertyName = "NullableMgmtPublicServiceGetUserView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ApiToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.V1betaUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Any>))]
    internal sealed partial class NamespaceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NamespaceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static NamespaceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private NamespaceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Instill.ApiTokenState)

                    || typeToConvert == typeof(global::Instill.ApiTokenState?)

                    || typeToConvert == typeof(global::Instill.CheckNamespaceResponseNamespace)

                    || typeToConvert == typeof(global::Instill.CheckNamespaceResponseNamespace?)

                    || typeToConvert == typeof(global::Instill.OnboardingStatus)

                    || typeToConvert == typeof(global::Instill.OnboardingStatus?)

                    || typeToConvert == typeof(global::Instill.MgmtPublicServiceListUsersView)

                    || typeToConvert == typeof(global::Instill.MgmtPublicServiceListUsersView?)

                    || typeToConvert == typeof(global::Instill.MgmtPublicServiceGetUserView)

                    || typeToConvert == typeof(global::Instill.MgmtPublicServiceGetUserView?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Instill.ApiTokenState))
                {
                    return new global::Instill.JsonConverters.ApiTokenStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.ApiTokenState?))
                {
                    return new global::Instill.JsonConverters.ApiTokenStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.CheckNamespaceResponseNamespace))
                {
                    return new global::Instill.JsonConverters.CheckNamespaceResponseNamespaceJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.CheckNamespaceResponseNamespace?))
                {
                    return new global::Instill.JsonConverters.CheckNamespaceResponseNamespaceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.OnboardingStatus))
                {
                    return new global::Instill.JsonConverters.OnboardingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.OnboardingStatus?))
                {
                    return new global::Instill.JsonConverters.OnboardingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.MgmtPublicServiceListUsersView))
                {
                    return new global::Instill.JsonConverters.MgmtPublicServiceListUsersViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.MgmtPublicServiceListUsersView?))
                {
                    return new global::Instill.JsonConverters.MgmtPublicServiceListUsersViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.MgmtPublicServiceGetUserView))
                {
                    return new global::Instill.JsonConverters.MgmtPublicServiceGetUserViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Instill.MgmtPublicServiceGetUserView?))
                {
                    return new global::Instill.JsonConverters.MgmtPublicServiceGetUserViewNullableJsonConverter();
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
                    0 => new NamespaceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}