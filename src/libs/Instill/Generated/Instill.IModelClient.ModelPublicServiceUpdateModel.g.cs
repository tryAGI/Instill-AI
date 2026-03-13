#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Update a model<br/>
        /// Updates a model, accessing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the model.<br/>
        /// In REST requests, only the supplied model fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateModelResponse> ModelPublicServiceUpdateModelAsync(
            string modelName,

            global::Instill.ModelPublicServiceUpdateModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a model<br/>
        /// Updates a model, accessing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the model.<br/>
        /// In REST requests, only the supplied model fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="slug">
        /// Field 4: URL-friendly slug (NO prefix).<br/>
        /// If omitted, server generates from display_name.<br/>
        /// Slug is NOT part of resource identity.
        /// </param>
        /// <param name="description">
        /// Field 6: Optional description.
        /// </param>
        /// <param name="modelDefinition">
        /// The model definition that has been used to import the model.
        /// </param>
        /// <param name="configuration">
        /// Model configuration. This field is validated against the model<br/>
        /// specification in the model definition.
        /// </param>
        /// <param name="task">
        /// Model task.
        /// </param>
        /// <param name="visibility">
        /// Model visibility.
        /// </param>
        /// <param name="region">
        /// Region of choice for the particular provider to host the model.
        /// </param>
        /// <param name="hardware">
        /// Hardware of choice to serve the model.
        /// </param>
        /// <param name="tags">
        /// Tags.
        /// </param>
        /// <param name="readme">
        /// README holds the model documentation.
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the model (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the model is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Model profile image in base64 format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateModelResponse> ModelPublicServiceUpdateModelAsync(
            string modelName,
            string displayName,
            string modelDefinition,
            object configuration,
            global::Instill.Task task,
            global::Instill.ModelVisibility visibility,
            string region,
            string hardware,
            string? slug = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? readme = default,
            string? sourceUrl = default,
            string? documentationUrl = default,
            string? license = default,
            string? profileImage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}