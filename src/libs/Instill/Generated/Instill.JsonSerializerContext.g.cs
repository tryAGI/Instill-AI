
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
            typeof(global::Instill.JsonConverters.ApiTokenStateJsonConverter),

            typeof(global::Instill.JsonConverters.ApiTokenStateNullableJsonConverter),

            typeof(global::Instill.JsonConverters.CheckNamespaceResponseNamespaceJsonConverter),

            typeof(global::Instill.JsonConverters.CheckNamespaceResponseNamespaceNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ChunkTypeJsonConverter),

            typeof(global::Instill.JsonConverters.ChunkTypeNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ComponentDefinitionReleaseStageJsonConverter),

            typeof(global::Instill.JsonConverters.ComponentDefinitionReleaseStageNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ComponentDefinitionViewJsonConverter),

            typeof(global::Instill.JsonConverters.ComponentDefinitionViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ComponentTypeJsonConverter),

            typeof(global::Instill.JsonConverters.ComponentTypeNullableJsonConverter),

            typeof(global::Instill.JsonConverters.FileTypeJsonConverter),

            typeof(global::Instill.JsonConverters.FileTypeNullableJsonConverter),

            typeof(global::Instill.JsonConverters.FileViewJsonConverter),

            typeof(global::Instill.JsonConverters.FileViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.FileVisibilityJsonConverter),

            typeof(global::Instill.JsonConverters.FileVisibilityNullableJsonConverter),

            typeof(global::Instill.JsonConverters.FileMediaTypeJsonConverter),

            typeof(global::Instill.JsonConverters.FileMediaTypeNullableJsonConverter),

            typeof(global::Instill.JsonConverters.FileProcessStatusJsonConverter),

            typeof(global::Instill.JsonConverters.FileProcessStatusNullableJsonConverter),

            typeof(global::Instill.JsonConverters.KnowledgeBaseTypeJsonConverter),

            typeof(global::Instill.JsonConverters.KnowledgeBaseTypeNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelVisibilityJsonConverter),

            typeof(global::Instill.JsonConverters.ModelVisibilityNullableJsonConverter),

            typeof(global::Instill.JsonConverters.OnboardingStatusJsonConverter),

            typeof(global::Instill.JsonConverters.OnboardingStatusNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelineViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelineViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelineVisibilityJsonConverter),

            typeof(global::Instill.JsonConverters.PipelineVisibilityNullableJsonConverter),

            typeof(global::Instill.JsonConverters.RoleJsonConverter),

            typeof(global::Instill.JsonConverters.RoleNullableJsonConverter),

            typeof(global::Instill.JsonConverters.RunSourceJsonConverter),

            typeof(global::Instill.JsonConverters.RunSourceNullableJsonConverter),

            typeof(global::Instill.JsonConverters.RunStatusJsonConverter),

            typeof(global::Instill.JsonConverters.RunStatusNullableJsonConverter),

            typeof(global::Instill.JsonConverters.StorageProviderJsonConverter),

            typeof(global::Instill.JsonConverters.StorageProviderNullableJsonConverter),

            typeof(global::Instill.JsonConverters.TaskJsonConverter),

            typeof(global::Instill.JsonConverters.TaskNullableJsonConverter),

            typeof(global::Instill.JsonConverters.TraceStatusJsonConverter),

            typeof(global::Instill.JsonConverters.TraceStatusNullableJsonConverter),

            typeof(global::Instill.JsonConverters.UnitJsonConverter),

            typeof(global::Instill.JsonConverters.UnitNullableJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtV1betaConnectionMethodJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtV1betaConnectionMethodNullableJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtV1betaViewJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtV1betaViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelineV1betaConnectionMethodJsonConverter),

            typeof(global::Instill.JsonConverters.PipelineV1betaConnectionMethodNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelineV1betaViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelineV1betaViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.V1alphaReleaseStageJsonConverter),

            typeof(global::Instill.JsonConverters.V1alphaReleaseStageNullableJsonConverter),

            typeof(global::Instill.JsonConverters.V1alphaStateJsonConverter),

            typeof(global::Instill.JsonConverters.V1alphaStateNullableJsonConverter),

            typeof(global::Instill.JsonConverters.V1alphaViewJsonConverter),

            typeof(global::Instill.JsonConverters.V1alphaViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ArtifactPublicServiceListFilesViewJsonConverter),

            typeof(global::Instill.JsonConverters.ArtifactPublicServiceListFilesViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ArtifactPublicServiceGetFileViewJsonConverter),

            typeof(global::Instill.JsonConverters.ArtifactPublicServiceGetFileViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ArtifactPublicServiceGetFileStorageProviderJsonConverter),

            typeof(global::Instill.JsonConverters.ArtifactPublicServiceGetFileStorageProviderNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ArtifactPublicServiceGetChunkChunkTypeJsonConverter),

            typeof(global::Instill.JsonConverters.ArtifactPublicServiceGetChunkChunkTypeNullableJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtPublicServiceListUsersViewJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtPublicServiceListUsersViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtPublicServiceGetUserViewJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtPublicServiceGetUserViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtPublicServiceGetNamespaceConnectionViewJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtPublicServiceGetNamespaceConnectionViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtPublicServiceGetIntegrationViewJsonConverter),

            typeof(global::Instill.JsonConverters.MgmtPublicServiceGetIntegrationViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListModelDefinitionsViewJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListModelDefinitionsViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceGetModelDefinitionViewJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceGetModelDefinitionViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListPublicModelsViewJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListPublicModelsViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListPublicModelsVisibilityJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListPublicModelsVisibilityNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListModelsViewJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListModelsViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListModelsVisibilityJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceListModelsVisibilityNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceGetModelViewJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceGetModelViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceGetModelVersionOperationViewJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceGetModelVersionOperationViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceGetModelOperationViewJsonConverter),

            typeof(global::Instill.JsonConverters.ModelPublicServiceGetModelOperationViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPublicPipelinesViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPublicPipelinesViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPublicPipelinesVisibilityJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPublicPipelinesVisibilityNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPipelinesViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPipelinesViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPipelinesVisibilityJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPipelinesVisibilityNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceGetPipelineViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceGetPipelineViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPipelineReleasesViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListPipelineReleasesViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceGetPipelineReleaseViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceGetPipelineReleaseViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListComponentDefinitionsViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListComponentDefinitionsViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListComponentRunsViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceListComponentRunsViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceGetIntegrationViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceGetIntegrationViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceGetConnectionViewJsonConverter),

            typeof(global::Instill.JsonConverters.PipelinePublicServiceGetConnectionViewNullableJsonConverter),

            typeof(global::Instill.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Chunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ChunkType), TypeInfoPropertyName = "ChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Reference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ClonePipelineBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Sharing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ClonePipelineReleaseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ClonePipelineReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ClonePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ComponentDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Spec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ComponentType), TypeInfoPropertyName = "ComponentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ComponentTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ComponentTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ComponentDefinitionReleaseStage), TypeInfoPropertyName = "ComponentDefinitionReleaseStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ComponentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ComponentEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ComponentDefinitionView), TypeInfoPropertyName = "ComponentDefinitionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ComponentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RunStatus), TypeInfoPropertyName = "RunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.FileReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.KnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateNamespaceSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Secret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreatePipelineReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreatePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Pipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.CreateTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DataSpecification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteModelVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteNamespaceSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeletePipelineReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeletePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.DeleteTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.EmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Endpoints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Instill.WebhookEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.WebhookEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ErrPipelineValidation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.EventSpecification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileType), TypeInfoPropertyName = "FileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileProcessStatus), TypeInfoPropertyName = "FileProcessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Position))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileVisibility), TypeInfoPropertyName = "FileVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileView), TypeInfoPropertyName = "FileView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.FileMediaType), TypeInfoPropertyName = "FileMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetAuthenticatedUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetChunkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetModelDefinitionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetModelOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.LongrunningOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetModelVersionOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetNamespaceSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetObjectDownloadURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Object), TypeInfoPropertyName = "Object_Instill_Object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetObjectUploadURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetPipelineReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.GetUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1betaUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Hardware))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.KnowledgeBaseType), TypeInfoPropertyName = "KnowledgeBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Owner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListAvailableRegionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Region>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Region))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Chunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListComponentDefinitionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ComponentDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListComponentRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ComponentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.PipelineV1betaConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelDefinitionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ModelDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelRunsByRequesterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ModelRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelTriggerChartRecordsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ModelTriggerChartRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelTriggerChartRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListNamespaceConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.MgmtV1betaConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListNamespaceSecretsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Secret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListPipelineReleasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.PipelineRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListPipelineRunsByRequesterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.PipelineRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListPipelineRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListPipelineTriggerChartRecordsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.PipelineTriggerChartRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineTriggerChartRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListPipelinesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Pipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListPublicModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListPublicPipelinesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ApiToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ListUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.V1betaUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Task), TypeInfoPropertyName = "Task2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelVisibility), TypeInfoPropertyName = "ModelVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaReleaseStage), TypeInfoPropertyName = "V1alphaReleaseStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RunSource), TypeInfoPropertyName = "RunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.DateTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaState), TypeInfoPropertyName = "V1alphaState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.OrganizationProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.OrganizationStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PatchAuthenticatedUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineVisibility), TypeInfoPropertyName = "PipelineVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineView), TypeInfoPropertyName = "PipelineView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Unit), TypeInfoPropertyName = "Unit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Hardware>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RenameModelBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RenameModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RenamePipelineBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RenamePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ReprocessFileBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ReprocessFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Role), TypeInfoPropertyName = "Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.SearchChunksBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.SearchChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.SimilarityChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.SimilarityChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ShareCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Instill.SharingUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.SharingUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Instill.DataSpecification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Instill.EventSpecification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.StorageProvider), TypeInfoPropertyName = "StorageProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TestConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TestNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.Trace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.TraceStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TraceStatus), TypeInfoPropertyName = "TraceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncModelBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncModelVersionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncModelVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncPipelineBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.TriggerData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncPipelineReleaseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncPipelineReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerAsyncPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Instill.Trace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerModelBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerModelVersionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerModelVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerPipelineBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerPipelineReleaseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerPipelineReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerPipelineWithStreamBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.TriggerPipelineWithStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateChunkBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateChunkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateNamespaceConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateNamespaceSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateObjectBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateObjectBodyObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdateObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdatePipelineReleaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.UpdatePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ValidatePipelineBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ValidatePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.ErrPipelineValidation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ValidateTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.WatchModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.WatchModelVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.RpcStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaConnectionMethod), TypeInfoPropertyName = "MgmtV1betaConnectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaView), TypeInfoPropertyName = "MgmtV1betaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaGetIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaIntegrationLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaIntegrationOAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaListIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.MgmtV1betaIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtV1betaListPipelineIDsByConnectionIDResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaConnectionMethod), TypeInfoPropertyName = "PipelineV1betaConnectionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaView), TypeInfoPropertyName = "PipelineV1betaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaGetIntegrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaIntegrationLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaIntegrationOAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaListIntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.PipelineV1betaIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelineV1betaListPipelineIDsByConnectionIDResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Instill.Any>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaGetOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1alphaView), TypeInfoPropertyName = "V1alphaView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.V1betaGetOperationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceUpdateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceUpdateFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceUpdateNamespaceConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceUpdateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceUpdatePipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceUpdatePipelineReleaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceUpdateNamespaceSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceUpdateConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceListFilesView), TypeInfoPropertyName = "ArtifactPublicServiceListFilesView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceGetFileView), TypeInfoPropertyName = "ArtifactPublicServiceGetFileView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceGetFileStorageProvider), TypeInfoPropertyName = "ArtifactPublicServiceGetFileStorageProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ArtifactPublicServiceGetChunkChunkType), TypeInfoPropertyName = "ArtifactPublicServiceGetChunkChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceListUsersView), TypeInfoPropertyName = "MgmtPublicServiceListUsersView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceGetUserView), TypeInfoPropertyName = "MgmtPublicServiceGetUserView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceGetNamespaceConnectionView), TypeInfoPropertyName = "MgmtPublicServiceGetNamespaceConnectionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.MgmtPublicServiceGetIntegrationView), TypeInfoPropertyName = "MgmtPublicServiceGetIntegrationView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListModelDefinitionsView), TypeInfoPropertyName = "ModelPublicServiceListModelDefinitionsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelDefinitionView), TypeInfoPropertyName = "ModelPublicServiceGetModelDefinitionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListPublicModelsView), TypeInfoPropertyName = "ModelPublicServiceListPublicModelsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListPublicModelsVisibility), TypeInfoPropertyName = "ModelPublicServiceListPublicModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListModelsView), TypeInfoPropertyName = "ModelPublicServiceListModelsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceListModelsVisibility), TypeInfoPropertyName = "ModelPublicServiceListModelsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelView), TypeInfoPropertyName = "ModelPublicServiceGetModelView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelVersionOperationView), TypeInfoPropertyName = "ModelPublicServiceGetModelVersionOperationView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.ModelPublicServiceGetModelOperationView), TypeInfoPropertyName = "ModelPublicServiceGetModelOperationView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceListPublicPipelinesView), TypeInfoPropertyName = "PipelinePublicServiceListPublicPipelinesView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceListPublicPipelinesVisibility), TypeInfoPropertyName = "PipelinePublicServiceListPublicPipelinesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceListPipelinesView), TypeInfoPropertyName = "PipelinePublicServiceListPipelinesView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceListPipelinesVisibility), TypeInfoPropertyName = "PipelinePublicServiceListPipelinesVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceGetPipelineView), TypeInfoPropertyName = "PipelinePublicServiceGetPipelineView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceListPipelineReleasesView), TypeInfoPropertyName = "PipelinePublicServiceListPipelineReleasesView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceGetPipelineReleaseView), TypeInfoPropertyName = "PipelinePublicServiceGetPipelineReleaseView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceListComponentDefinitionsView), TypeInfoPropertyName = "PipelinePublicServiceListComponentDefinitionsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceListComponentRunsView), TypeInfoPropertyName = "PipelinePublicServiceListComponentRunsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceGetIntegrationView), TypeInfoPropertyName = "PipelinePublicServiceGetIntegrationView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceGetConnectionView), TypeInfoPropertyName = "PipelinePublicServiceGetConnectionView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.PipelinePublicServiceTriggerPipelineWithStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ComponentTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ComponentEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.FileReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Region>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Chunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ComponentDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ComponentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.PipelineV1betaConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ModelDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ModelRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ModelTriggerChartRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ModelVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.MgmtV1betaConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Secret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.PipelineRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.PipelineRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.PipelineTriggerChartRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Pipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ApiToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.V1betaUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.DateTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Hardware>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.SimilarityChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.TraceStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.TriggerData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.ErrPipelineValidation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.MgmtV1betaIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.PipelineV1betaIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Instill.Any>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}