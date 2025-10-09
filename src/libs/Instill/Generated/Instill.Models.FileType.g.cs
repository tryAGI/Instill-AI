
#nullable enable

namespace Instill
{
    /// <summary>
    /// - FILE_TYPE_TEXT: Text-based document types<br/>
    /// text<br/>
    ///  - FILE_TYPE_PDF: PDF<br/>
    ///  - FILE_TYPE_MARKDOWN: MARKDOWN<br/>
    ///  - FILE_TYPE_HTML: HTML<br/>
    ///  - FILE_TYPE_CSV: CSV<br/>
    ///  - FILE_TYPE_DOCX: Microsoft Office document types<br/>
    /// DOCX<br/>
    ///  - FILE_TYPE_DOC: DOC<br/>
    ///  - FILE_TYPE_PPT: PPT<br/>
    ///  - FILE_TYPE_PPTX: PPTX<br/>
    ///  - FILE_TYPE_XLS: XLS<br/>
    ///  - FILE_TYPE_XLSX: XLSX<br/>
    ///  - FILE_TYPE_PNG: Image types (supported by pipeline-backend/pkg/data/image.go)<br/>
    /// PNG<br/>
    ///  - FILE_TYPE_JPEG: JPEG<br/>
    ///  - FILE_TYPE_JPG: JPG<br/>
    ///  - FILE_TYPE_GIF: GIF<br/>
    ///  - FILE_TYPE_WEBP: WEBP<br/>
    ///  - FILE_TYPE_TIFF: TIFF<br/>
    ///  - FILE_TYPE_BMP: BMP<br/>
    ///  - FILE_TYPE_HEIC: HEIC<br/>
    ///  - FILE_TYPE_HEIF: HEIF<br/>
    ///  - FILE_TYPE_AVIF: AVIF<br/>
    ///  - FILE_TYPE_MP3: Audio types (supported by pipeline-backend/pkg/data/audio.go)<br/>
    /// MP3<br/>
    ///  - FILE_TYPE_WAV: WAV<br/>
    ///  - FILE_TYPE_AAC: AAC<br/>
    ///  - FILE_TYPE_OGG: OGG<br/>
    ///  - FILE_TYPE_FLAC: FLAC<br/>
    ///  - FILE_TYPE_M4A: M4A<br/>
    ///  - FILE_TYPE_WMA: WMA<br/>
    ///  - FILE_TYPE_AIFF: AIFF<br/>
    ///  - FILE_TYPE_MP4: Video types (supported by pipeline-backend/pkg/data/video.go)<br/>
    /// MP4<br/>
    ///  - FILE_TYPE_AVI: AVI<br/>
    ///  - FILE_TYPE_MOV: MOV<br/>
    ///  - FILE_TYPE_WEBM_VIDEO: WEBM (video)<br/>
    ///  - FILE_TYPE_MKV: MKV<br/>
    ///  - FILE_TYPE_FLV: FLV<br/>
    ///  - FILE_TYPE_WMV: WMV<br/>
    ///  - FILE_TYPE_MPEG: MPEG
    /// </summary>
    public enum FileType
    {
        /// <summary>
        /// Text-based document types
        /// </summary>
        TEXT,
        /// <summary>
        /// PDF
        /// </summary>
        PDF,
        /// <summary>
        /// MARKDOWN
        /// </summary>
        MARKDOWN,
        /// <summary>
        /// HTML
        /// </summary>
        HTML,
        /// <summary>
        /// CSV
        /// </summary>
        CSV,
        /// <summary>
        /// Microsoft Office document types
        /// </summary>
        DOCX,
        /// <summary>
        /// Microsoft Office document types
        /// </summary>
        DOC,
        /// <summary>
        /// PPT
        /// </summary>
        PPT,
        /// <summary>
        /// PPTX
        /// </summary>
        PPTX,
        /// <summary>
        /// XLS
        /// </summary>
        XLS,
        /// <summary>
        /// XLSX
        /// </summary>
        XLSX,
        /// <summary>
        /// Image types (supported by pipeline-backend/pkg/data/image.go)
        /// </summary>
        PNG,
        /// <summary>
        /// JPEG
        /// </summary>
        JPEG,
        /// <summary>
        /// JPG
        /// </summary>
        JPG,
        /// <summary>
        /// GIF
        /// </summary>
        GIF,
        /// <summary>
        /// WEBP
        /// </summary>
        WEBP,
        /// <summary>
        /// TIFF
        /// </summary>
        TIFF,
        /// <summary>
        /// BMP
        /// </summary>
        BMP,
        /// <summary>
        /// HEIC
        /// </summary>
        HEIC,
        /// <summary>
        /// HEIF
        /// </summary>
        HEIF,
        /// <summary>
        /// AVIF
        /// </summary>
        AVIF,
        /// <summary>
        /// Audio types (supported by pipeline-backend/pkg/data/audio.go)
        /// </summary>
        MP3,
        /// <summary>
        /// WAV
        /// </summary>
        WAV,
        /// <summary>
        /// AAC
        /// </summary>
        AAC,
        /// <summary>
        /// OGG
        /// </summary>
        OGG,
        /// <summary>
        /// FLAC
        /// </summary>
        FLAC,
        /// <summary>
        /// M4A
        /// </summary>
        M4A,
        /// <summary>
        /// WMA
        /// </summary>
        WMA,
        /// <summary>
        /// AIFF
        /// </summary>
        AIFF,
        /// <summary>
        /// Video types (supported by pipeline-backend/pkg/data/video.go)
        /// </summary>
        MP4,
        /// <summary>
        /// AVIF
        /// </summary>
        AVI,
        /// <summary>
        /// MOV
        /// </summary>
        MOV,
        /// <summary>
        /// WEBM (video)
        /// </summary>
        WEBMVIDEO,
        /// <summary>
        /// MKV
        /// </summary>
        MKV,
        /// <summary>
        /// FLV
        /// </summary>
        FLV,
        /// <summary>
        /// WMV
        /// </summary>
        WMV,
        /// <summary>
        /// MPEG
        /// </summary>
        MPEG,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileType value)
        {
            return value switch
            {
                FileType.TEXT => "FILE_TYPE_TEXT",
                FileType.PDF => "FILE_TYPE_PDF",
                FileType.MARKDOWN => "FILE_TYPE_MARKDOWN",
                FileType.HTML => "FILE_TYPE_HTML",
                FileType.CSV => "FILE_TYPE_CSV",
                FileType.DOCX => "FILE_TYPE_DOCX",
                FileType.DOC => "FILE_TYPE_DOC",
                FileType.PPT => "FILE_TYPE_PPT",
                FileType.PPTX => "FILE_TYPE_PPTX",
                FileType.XLS => "FILE_TYPE_XLS",
                FileType.XLSX => "FILE_TYPE_XLSX",
                FileType.PNG => "FILE_TYPE_PNG",
                FileType.JPEG => "FILE_TYPE_JPEG",
                FileType.JPG => "FILE_TYPE_JPG",
                FileType.GIF => "FILE_TYPE_GIF",
                FileType.WEBP => "FILE_TYPE_WEBP",
                FileType.TIFF => "FILE_TYPE_TIFF",
                FileType.BMP => "FILE_TYPE_BMP",
                FileType.HEIC => "FILE_TYPE_HEIC",
                FileType.HEIF => "FILE_TYPE_HEIF",
                FileType.AVIF => "FILE_TYPE_AVIF",
                FileType.MP3 => "FILE_TYPE_MP3",
                FileType.WAV => "FILE_TYPE_WAV",
                FileType.AAC => "FILE_TYPE_AAC",
                FileType.OGG => "FILE_TYPE_OGG",
                FileType.FLAC => "FILE_TYPE_FLAC",
                FileType.M4A => "FILE_TYPE_M4A",
                FileType.WMA => "FILE_TYPE_WMA",
                FileType.AIFF => "FILE_TYPE_AIFF",
                FileType.MP4 => "FILE_TYPE_MP4",
                FileType.AVI => "FILE_TYPE_AVI",
                FileType.MOV => "FILE_TYPE_MOV",
                FileType.WEBMVIDEO => "FILE_TYPE_WEBM_VIDEO",
                FileType.MKV => "FILE_TYPE_MKV",
                FileType.FLV => "FILE_TYPE_FLV",
                FileType.WMV => "FILE_TYPE_WMV",
                FileType.MPEG => "FILE_TYPE_MPEG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileType? ToEnum(string value)
        {
            return value switch
            {
                "FILE_TYPE_TEXT" => FileType.TEXT,
                "FILE_TYPE_PDF" => FileType.PDF,
                "FILE_TYPE_MARKDOWN" => FileType.MARKDOWN,
                "FILE_TYPE_HTML" => FileType.HTML,
                "FILE_TYPE_CSV" => FileType.CSV,
                "FILE_TYPE_DOCX" => FileType.DOCX,
                "FILE_TYPE_DOC" => FileType.DOC,
                "FILE_TYPE_PPT" => FileType.PPT,
                "FILE_TYPE_PPTX" => FileType.PPTX,
                "FILE_TYPE_XLS" => FileType.XLS,
                "FILE_TYPE_XLSX" => FileType.XLSX,
                "FILE_TYPE_PNG" => FileType.PNG,
                "FILE_TYPE_JPEG" => FileType.JPEG,
                "FILE_TYPE_JPG" => FileType.JPG,
                "FILE_TYPE_GIF" => FileType.GIF,
                "FILE_TYPE_WEBP" => FileType.WEBP,
                "FILE_TYPE_TIFF" => FileType.TIFF,
                "FILE_TYPE_BMP" => FileType.BMP,
                "FILE_TYPE_HEIC" => FileType.HEIC,
                "FILE_TYPE_HEIF" => FileType.HEIF,
                "FILE_TYPE_AVIF" => FileType.AVIF,
                "FILE_TYPE_MP3" => FileType.MP3,
                "FILE_TYPE_WAV" => FileType.WAV,
                "FILE_TYPE_AAC" => FileType.AAC,
                "FILE_TYPE_OGG" => FileType.OGG,
                "FILE_TYPE_FLAC" => FileType.FLAC,
                "FILE_TYPE_M4A" => FileType.M4A,
                "FILE_TYPE_WMA" => FileType.WMA,
                "FILE_TYPE_AIFF" => FileType.AIFF,
                "FILE_TYPE_MP4" => FileType.MP4,
                "FILE_TYPE_AVI" => FileType.AVI,
                "FILE_TYPE_MOV" => FileType.MOV,
                "FILE_TYPE_WEBM_VIDEO" => FileType.WEBMVIDEO,
                "FILE_TYPE_MKV" => FileType.MKV,
                "FILE_TYPE_FLV" => FileType.FLV,
                "FILE_TYPE_WMV" => FileType.WMV,
                "FILE_TYPE_MPEG" => FileType.MPEG,
                _ => null,
            };
        }
    }
}