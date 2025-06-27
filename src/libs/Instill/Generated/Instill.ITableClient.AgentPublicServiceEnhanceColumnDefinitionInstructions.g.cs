#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Enhance column definition instructions<br/>
        /// Enhances the instructions of a column definition.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.EnhanceColumnDefinitionInstructionsResponse> AgentPublicServiceEnhanceColumnDefinitionInstructionsAsync(
            string namespaceId,
            string tableUid,
            global::Instill.EnhanceColumnDefinitionInstructionsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Enhance column definition instructions<br/>
        /// Enhances the instructions of a column definition.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="columnUid">
        /// The UID of the column to be enhanced.<br/>
        /// Please provide this field if you want to enhance the instruction of an existing column definition.<br/>
        /// Ignore it if you want to enhance the instruction of a non-created column in the new column creation flow.
        /// </param>
        /// <param name="columnDefinition">
        /// The column definition to be enhanced.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.EnhanceColumnDefinitionInstructionsResponse> AgentPublicServiceEnhanceColumnDefinitionInstructionsAsync(
            string namespaceId,
            string tableUid,
            global::Instill.ColumnDefinition columnDefinition,
            string? columnUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}