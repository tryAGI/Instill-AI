
#nullable enable

namespace Instill
{
    /// <summary>
    /// ChatEvent represents an event for a chat.
    /// </summary>
    public sealed partial class ChatEvent
    {
        /// <summary>
        /// The event type.<br/>
        /// In text/event-stream format, this maps to the `event` field.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// The ID of the event.<br/>
        /// In text/event-stream format, this maps to the `id` field.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The chat was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatStartedEvent")]
        public global::Instill.ChatStartedEvent? ChatStartedEvent { get; set; }

        /// <summary>
        /// The chat status was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatStatusUpdatedEvent")]
        public global::Instill.ChatStatusUpdatedEvent? ChatStatusUpdatedEvent { get; set; }

        /// <summary>
        /// The chat output was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatOutputUpdatedEvent")]
        public global::Instill.ChatOutputUpdatedEvent? ChatOutputUpdatedEvent { get; set; }

        /// <summary>
        /// The chat name was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatNameUpdatedEvent")]
        public global::Instill.ChatNameUpdatedEvent? ChatNameUpdatedEvent { get; set; }

        /// <summary>
        /// The chat replan was triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatReplanTriggeredEvent")]
        public global::Instill.ChatReplanTriggeredEvent? ChatReplanTriggeredEvent { get; set; }

        /// <summary>
        /// The chat citation list was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatCitationListUpdatedEvent")]
        public global::Instill.ChatCitationListUpdatedEvent? ChatCitationListUpdatedEvent { get; set; }

        /// <summary>
        /// The table was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatTableCreatedEvent")]
        public global::Instill.ChatTableCreatedEvent? ChatTableCreatedEvent { get; set; }

        /// <summary>
        /// The error was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatErrorUpdatedEvent")]
        public global::Instill.ChatErrorUpdatedEvent? ChatErrorUpdatedEvent { get; set; }

        /// <summary>
        /// The debug output was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatDebugOutputUpdatedEvent")]
        public global::Instill.ChatDebugOutputUpdatedEvent? ChatDebugOutputUpdatedEvent { get; set; }

        /// <summary>
        /// The chat ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatEndedEvent")]
        public global::Instill.ChatEndedEvent? ChatEndedEvent { get; set; }

        /// <summary>
        /// The chat attachments were updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatAttachmentsUpdatedEvent")]
        public global::Instill.ChatAttachmentsUpdatedEvent? ChatAttachmentsUpdatedEvent { get; set; }

        /// <summary>
        /// The chat context was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatContextUpdatedEvent")]
        public global::Instill.ChatContextUpdatedEvent? ChatContextUpdatedEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvent" /> class.
        /// </summary>
        /// <param name="event">
        /// The event type.<br/>
        /// In text/event-stream format, this maps to the `event` field.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// The ID of the event.<br/>
        /// In text/event-stream format, this maps to the `id` field.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="chatStartedEvent">
        /// The chat was started.
        /// </param>
        /// <param name="chatStatusUpdatedEvent">
        /// The chat status was updated.
        /// </param>
        /// <param name="chatOutputUpdatedEvent">
        /// The chat output was updated.
        /// </param>
        /// <param name="chatNameUpdatedEvent">
        /// The chat name was updated.
        /// </param>
        /// <param name="chatReplanTriggeredEvent">
        /// The chat replan was triggered.
        /// </param>
        /// <param name="chatCitationListUpdatedEvent">
        /// The chat citation list was updated.
        /// </param>
        /// <param name="chatTableCreatedEvent">
        /// The table was created.
        /// </param>
        /// <param name="chatErrorUpdatedEvent">
        /// The error was updated.
        /// </param>
        /// <param name="chatDebugOutputUpdatedEvent">
        /// The debug output was updated.
        /// </param>
        /// <param name="chatEndedEvent">
        /// The chat ended.
        /// </param>
        /// <param name="chatAttachmentsUpdatedEvent">
        /// The chat attachments were updated.
        /// </param>
        /// <param name="chatContextUpdatedEvent">
        /// The chat context was updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatEvent(
            string? @event,
            string? id,
            global::Instill.ChatStartedEvent? chatStartedEvent,
            global::Instill.ChatStatusUpdatedEvent? chatStatusUpdatedEvent,
            global::Instill.ChatOutputUpdatedEvent? chatOutputUpdatedEvent,
            global::Instill.ChatNameUpdatedEvent? chatNameUpdatedEvent,
            global::Instill.ChatReplanTriggeredEvent? chatReplanTriggeredEvent,
            global::Instill.ChatCitationListUpdatedEvent? chatCitationListUpdatedEvent,
            global::Instill.ChatTableCreatedEvent? chatTableCreatedEvent,
            global::Instill.ChatErrorUpdatedEvent? chatErrorUpdatedEvent,
            global::Instill.ChatDebugOutputUpdatedEvent? chatDebugOutputUpdatedEvent,
            global::Instill.ChatEndedEvent? chatEndedEvent,
            global::Instill.ChatAttachmentsUpdatedEvent? chatAttachmentsUpdatedEvent,
            global::Instill.ChatContextUpdatedEvent? chatContextUpdatedEvent)
        {
            this.Event = @event;
            this.Id = id;
            this.ChatStartedEvent = chatStartedEvent;
            this.ChatStatusUpdatedEvent = chatStatusUpdatedEvent;
            this.ChatOutputUpdatedEvent = chatOutputUpdatedEvent;
            this.ChatNameUpdatedEvent = chatNameUpdatedEvent;
            this.ChatReplanTriggeredEvent = chatReplanTriggeredEvent;
            this.ChatCitationListUpdatedEvent = chatCitationListUpdatedEvent;
            this.ChatTableCreatedEvent = chatTableCreatedEvent;
            this.ChatErrorUpdatedEvent = chatErrorUpdatedEvent;
            this.ChatDebugOutputUpdatedEvent = chatDebugOutputUpdatedEvent;
            this.ChatEndedEvent = chatEndedEvent;
            this.ChatAttachmentsUpdatedEvent = chatAttachmentsUpdatedEvent;
            this.ChatContextUpdatedEvent = chatContextUpdatedEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvent" /> class.
        /// </summary>
        public ChatEvent()
        {
        }
    }
}