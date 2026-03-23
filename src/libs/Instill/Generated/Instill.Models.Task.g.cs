
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
        /// Conversational Text Generation - generate text as responses to a dialog input.
        /// </summary>
        Chat,
        /// <summary>
        /// Image Classification - classify images into predefined categories.
        /// </summary>
        Classification,
        /// <summary>
        /// Completion Text Generation - generate text following the input prompt.
        /// </summary>
        Completion,
        /// <summary>
        /// Custom - custom task type for free form input/output.
        /// </summary>
        Custom,
        /// <summary>
        /// Object Detection - detect and localize multiple objects in images.
        /// </summary>
        Detection,
        /// <summary>
        /// Embedding - generate an embedding (a representation as coordinates) from a multimodal input.
        /// </summary>
        Embedding,
        /// <summary>
        /// Image to Image - generate an image from another image.
        /// </summary>
        ImageToImage,
        /// <summary>
        /// Instance Segmentation - detect, localize and delineate multiple objects in images.
        /// </summary>
        InstanceSegmentation,
        /// <summary>
        /// Keypoint Detection - detect and localize multiple keypoints of objects in images.
        /// </summary>
        Keypoint,
        /// <summary>
        /// OCR (Optical Character Recognition) - detect and recognize text in images.
        /// </summary>
        Ocr,
        /// <summary>
        /// Semantic Segmentation - classify image pixels into predefined categories.
        /// </summary>
        SemanticSegmentation,
        /// <summary>
        /// Speech Recognition - transcribe the words in an audio input.
        /// </summary>
        SpeechRecognition,
        /// <summary>
        /// Text to Image - generate images from input text prompts.
        /// </summary>
        TextToImage,
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
                Task.Chat => "TASK_CHAT",
                Task.Classification => "TASK_CLASSIFICATION",
                Task.Completion => "TASK_COMPLETION",
                Task.Custom => "TASK_CUSTOM",
                Task.Detection => "TASK_DETECTION",
                Task.Embedding => "TASK_EMBEDDING",
                Task.ImageToImage => "TASK_IMAGE_TO_IMAGE",
                Task.InstanceSegmentation => "TASK_INSTANCE_SEGMENTATION",
                Task.Keypoint => "TASK_KEYPOINT",
                Task.Ocr => "TASK_OCR",
                Task.SemanticSegmentation => "TASK_SEMANTIC_SEGMENTATION",
                Task.SpeechRecognition => "TASK_SPEECH_RECOGNITION",
                Task.TextToImage => "TASK_TEXT_TO_IMAGE",
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
                "TASK_CHAT" => Task.Chat,
                "TASK_CLASSIFICATION" => Task.Classification,
                "TASK_COMPLETION" => Task.Completion,
                "TASK_CUSTOM" => Task.Custom,
                "TASK_DETECTION" => Task.Detection,
                "TASK_EMBEDDING" => Task.Embedding,
                "TASK_IMAGE_TO_IMAGE" => Task.ImageToImage,
                "TASK_INSTANCE_SEGMENTATION" => Task.InstanceSegmentation,
                "TASK_KEYPOINT" => Task.Keypoint,
                "TASK_OCR" => Task.Ocr,
                "TASK_SEMANTIC_SEGMENTATION" => Task.SemanticSegmentation,
                "TASK_SPEECH_RECOGNITION" => Task.SpeechRecognition,
                "TASK_TEXT_TO_IMAGE" => Task.TextToImage,
                _ => null,
            };
        }
    }
}