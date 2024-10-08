
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
            typeof(global::Instill.JsonConverters.StatusJsonConverter),
            typeof(global::Instill.JsonConverters.StatusNullableJsonConverter),
            typeof(global::Instill.JsonConverters.OnboardingStatusJsonConverter),
            typeof(global::Instill.JsonConverters.OnboardingStatusNullableJsonConverter),
            typeof(global::Instill.JsonConverters.CheckNamespaceAdminResponseNamespaceJsonConverter),
            typeof(global::Instill.JsonConverters.CheckNamespaceAdminResponseNamespaceNullableJsonConverter),
            typeof(global::Instill.JsonConverters.CheckNamespaceByUIDAdminResponseNamespaceJsonConverter),
            typeof(global::Instill.JsonConverters.CheckNamespaceByUIDAdminResponseNamespaceNullableJsonConverter),
            typeof(global::Instill.JsonConverters.CheckNamespaceResponseNamespaceJsonConverter),
            typeof(global::Instill.JsonConverters.CheckNamespaceResponseNamespaceNullableJsonConverter),
            typeof(global::Instill.JsonConverters.UserSubscriptionPlanJsonConverter),
            typeof(global::Instill.JsonConverters.UserSubscriptionPlanNullableJsonConverter),
            typeof(global::Instill.JsonConverters.StripeSubscriptionDetailStatusJsonConverter),
            typeof(global::Instill.JsonConverters.StripeSubscriptionDetailStatusNullableJsonConverter),
            typeof(global::Instill.JsonConverters.MembershipStateJsonConverter),
            typeof(global::Instill.JsonConverters.MembershipStateNullableJsonConverter),
            typeof(global::Instill.JsonConverters.OrganizationSubscriptionPlanJsonConverter),
            typeof(global::Instill.JsonConverters.OrganizationSubscriptionPlanNullableJsonConverter),
            typeof(global::Instill.JsonConverters.ModeJsonConverter),
            typeof(global::Instill.JsonConverters.ModeNullableJsonConverter),
            typeof(global::Instill.JsonConverters.ViewJsonConverter),
            typeof(global::Instill.JsonConverters.ViewNullableJsonConverter),
            typeof(global::Instill.JsonConverters.GetFileCatalogResponseChunkTypeJsonConverter),
            typeof(global::Instill.JsonConverters.GetFileCatalogResponseChunkTypeNullableJsonConverter),
            typeof(global::Instill.JsonConverters.FileTypeJsonConverter),
            typeof(global::Instill.JsonConverters.FileTypeNullableJsonConverter),
            typeof(global::Instill.JsonConverters.FileProcessStatusJsonConverter),
            typeof(global::Instill.JsonConverters.FileProcessStatusNullableJsonConverter),
            typeof(global::Instill.JsonConverters.CatalogRunActionJsonConverter),
            typeof(global::Instill.JsonConverters.CatalogRunActionNullableJsonConverter),
            typeof(global::Instill.JsonConverters.RunStatusJsonConverter),
            typeof(global::Instill.JsonConverters.RunStatusNullableJsonConverter),
            typeof(global::Instill.JsonConverters.RunSourceJsonConverter),
            typeof(global::Instill.JsonConverters.RunSourceNullableJsonConverter),
            typeof(global::Instill.JsonConverters.ListUsersViewJsonConverter),
            typeof(global::Instill.JsonConverters.ListUsersViewNullableJsonConverter),
            typeof(global::Instill.JsonConverters.GetUserViewJsonConverter),
            typeof(global::Instill.JsonConverters.GetUserViewNullableJsonConverter),
            typeof(global::Instill.JsonConverters.ListOrganizationsViewJsonConverter),
            typeof(global::Instill.JsonConverters.ListOrganizationsViewNullableJsonConverter),
            typeof(global::Instill.JsonConverters.GetOrganizationViewJsonConverter),
            typeof(global::Instill.JsonConverters.GetOrganizationViewNullableJsonConverter),
            typeof(global::Instill.JsonConverters.GetUserMembershipViewJsonConverter),
            typeof(global::Instill.JsonConverters.GetUserMembershipViewNullableJsonConverter),
            typeof(global::Instill.JsonConverters.GetOrganizationMembershipViewJsonConverter),
            typeof(global::Instill.JsonConverters.GetOrganizationMembershipViewNullableJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Instill.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}