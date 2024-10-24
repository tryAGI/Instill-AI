
#nullable enable

namespace Instill
{
    /// <summary>
    /// Task enumerates the AI task that a model is designed to solve.<br/>
    ///  - TASK_CLASSIFICATION: Image Classification - classify images into predefined categories.<br/>
    ///  - TASK_DETECTION: Object Detection - detect and localize multiple objects in images.<br/>
    ///  - TASK_KEYPOINT: Keypoint Detection - detect and localize multiple keypoints of objects in images.<br/>
    ///  - TASK_OCR: OCR (Optical Character Recognition) - detect and recognize text in images.<br/>
    ///  - TASK_INSTANCE_SEGMENTATION: Instance Segmentation - detect, localize and delineate multiple objects in images.<br/>
    ///  - TASK_SEMANTIC_SEGMENTATION: Semantic Segmentation - classify image pixels into predefined categories.<br/>
    ///  - TASK_TEXT_TO_IMAGE: Text to Image - generate images from input text prompts.<br/>
    ///  - TASK_IMAGE_TO_IMAGE: Image to Image - generate an image from another image.<br/>
    ///  - TASK_EMBEDDING: Embedding - generate an embedding (a representation as coordinates) from a multimodal input.<br/>
    ///  - TASK_SPEECH_RECOGNITION: Speech Recognition - transcribe the words in an audio input.<br/>
    ///  - TASK_CHAT: Conversational Text Generation - generate text as responses to a dialog input.<br/>
    ///  - TASK_COMPLETION: Completion Text Generation - generate text following the input prompt.<br/>
    ///  - TASK_CUSTOM: Custom - custom task type for free form input/output.
    /// </summary>
    public enum Task
    {
        /// <summary>
        /// Image Classification - classify images into predefined categories.
        /// </summary>
        CLASSIFICATION,
        /// <summary>
        /// Object Detection - detect and localize multiple objects in images.
        /// </summary>
        DETECTION,
        /// <summary>
        /// Keypoint Detection - detect and localize multiple keypoints of objects in images.
        /// </summary>
        KEYPOINT,
        /// <summary>
        /// OCR (Optical Character Recognition) - detect and recognize text in images.
        /// </summary>
        OCR,
        /// <summary>
        /// Instance Segmentation - detect, localize and delineate multiple objects in images.
        /// </summary>
        INSTANCESEGMENTATION,
        /// <summary>
        /// Semantic Segmentation - classify image pixels into predefined categories.
        /// </summary>
        SEMANTICSEGMENTATION,
        /// <summary>
        /// Text to Image - generate images from input text prompts.
        /// </summary>
        TEXTTOIMAGE,
        /// <summary>
        /// Image to Image - generate an image from another image.
        /// </summary>
        IMAGETOIMAGE,
        /// <summary>
        /// Embedding - generate an embedding (a representation as coordinates) from a multimodal input.
        /// </summary>
        EMBEDDING,
        /// <summary>
        /// Speech Recognition - transcribe the words in an audio input.
        /// </summary>
        SPEECHRECOGNITION,
        /// <summary>
        /// Conversational Text Generation - generate text as responses to a dialog input.
        /// </summary>
        CHAT,
        /// <summary>
        /// Completion Text Generation - generate text following the input prompt.
        /// </summary>
        COMPLETION,
        /// <summary>
        /// Custom - custom task type for free form input/output.
        /// </summary>
        CUSTOM,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Task value)
        {
            return value switch
            {
                Task.CLASSIFICATION => "TASK_CLASSIFICATION",
                Task.DETECTION => "TASK_DETECTION",
                Task.KEYPOINT => "TASK_KEYPOINT",
                Task.OCR => "TASK_OCR",
                Task.INSTANCESEGMENTATION => "TASK_INSTANCE_SEGMENTATION",
                Task.SEMANTICSEGMENTATION => "TASK_SEMANTIC_SEGMENTATION",
                Task.TEXTTOIMAGE => "TASK_TEXT_TO_IMAGE",
                Task.IMAGETOIMAGE => "TASK_IMAGE_TO_IMAGE",
                Task.EMBEDDING => "TASK_EMBEDDING",
                Task.SPEECHRECOGNITION => "TASK_SPEECH_RECOGNITION",
                Task.CHAT => "TASK_CHAT",
                Task.COMPLETION => "TASK_COMPLETION",
                Task.CUSTOM => "TASK_CUSTOM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Task? ToEnum(string value)
        {
            return value switch
            {
                "TASK_CLASSIFICATION" => Task.CLASSIFICATION,
                "TASK_DETECTION" => Task.DETECTION,
                "TASK_KEYPOINT" => Task.KEYPOINT,
                "TASK_OCR" => Task.OCR,
                "TASK_INSTANCE_SEGMENTATION" => Task.INSTANCESEGMENTATION,
                "TASK_SEMANTIC_SEGMENTATION" => Task.SEMANTICSEGMENTATION,
                "TASK_TEXT_TO_IMAGE" => Task.TEXTTOIMAGE,
                "TASK_IMAGE_TO_IMAGE" => Task.IMAGETOIMAGE,
                "TASK_EMBEDDING" => Task.EMBEDDING,
                "TASK_SPEECH_RECOGNITION" => Task.SPEECHRECOGNITION,
                "TASK_CHAT" => Task.CHAT,
                "TASK_COMPLETION" => Task.COMPLETION,
                "TASK_CUSTOM" => Task.CUSTOM,
                _ => null,
            };
        }
    }
}