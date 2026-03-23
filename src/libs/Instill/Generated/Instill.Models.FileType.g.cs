
#nullable enable

namespace Instill
{
    /// <summary>
    /// - TYPE_TEXT: Text-based document types<br/>
    /// text<br/>
    ///  - TYPE_MARKDOWN: MARKDOWN<br/>
    ///  - TYPE_HTML: HTML<br/>
    ///  - TYPE_CSV: CSV<br/>
    ///  - TYPE_JSON: JSON<br/>
    ///  - TYPE_PDF: Container-based document types<br/>
    /// PDF<br/>
    ///  - TYPE_DOC: DOC<br/>
    ///  - TYPE_DOCX: DOCX<br/>
    ///  - TYPE_PPT: PPT<br/>
    ///  - TYPE_PPTX: PPTX<br/>
    ///  - TYPE_XLS: XLS<br/>
    ///  - TYPE_XLSX: XLSX<br/>
    ///  - TYPE_PNG: Image types<br/>
    /// PNG<br/>
    ///  - TYPE_JPEG: JPEG<br/>
    ///  - TYPE_GIF: GIF<br/>
    ///  - TYPE_WEBP: WEBP<br/>
    ///  - TYPE_TIFF: TIFF<br/>
    ///  - TYPE_BMP: BMP<br/>
    ///  - TYPE_HEIC: HEIC<br/>
    ///  - TYPE_HEIF: HEIF<br/>
    ///  - TYPE_AVIF: AVIF<br/>
    ///  - TYPE_SVG: SVG<br/>
    ///  - TYPE_MP3: Audio types<br/>
    /// MP3<br/>
    ///  - TYPE_WAV: WAV<br/>
    ///  - TYPE_AAC: AAC<br/>
    ///  - TYPE_OGG: OGG<br/>
    ///  - TYPE_FLAC: FLAC<br/>
    ///  - TYPE_M4A: M4A<br/>
    ///  - TYPE_WMA: WMA<br/>
    ///  - TYPE_AIFF: AIFF<br/>
    ///  - TYPE_WEBM_AUDIO: WEBM (audio)<br/>
    ///  - TYPE_MP4: Video types<br/>
    /// MP4<br/>
    ///  - TYPE_AVI: AVI<br/>
    ///  - TYPE_MOV: MOV<br/>
    ///  - TYPE_MKV: MKV<br/>
    ///  - TYPE_FLV: FLV<br/>
    ///  - TYPE_WMV: WMV<br/>
    ///  - TYPE_MPEG: MPEG<br/>
    ///  - TYPE_WEBM_VIDEO: WEBM (video)
    /// </summary>
    public enum FileType
    {
        /// <summary>
        /// AAC
        /// </summary>
        TypeAac,
        /// <summary>
        /// AIFF
        /// </summary>
        TypeAiff,
        /// <summary>
        /// AVIF
        /// </summary>
        TypeAvi,
        /// <summary>
        /// AVIF
        /// </summary>
        TypeAvif,
        /// <summary>
        /// BMP
        /// </summary>
        TypeBmp,
        /// <summary>
        /// CSV
        /// </summary>
        TypeCsv,
        /// <summary>
        /// DOC
        /// </summary>
        TypeDoc,
        /// <summary>
        /// DOCX
        /// </summary>
        TypeDocx,
        /// <summary>
        /// FLAC
        /// </summary>
        TypeFlac,
        /// <summary>
        /// FLV
        /// </summary>
        TypeFlv,
        /// <summary>
        /// GIF
        /// </summary>
        TypeGif,
        /// <summary>
        /// HEIC
        /// </summary>
        TypeHeic,
        /// <summary>
        /// HEIF
        /// </summary>
        TypeHeif,
        /// <summary>
        /// HTML
        /// </summary>
        TypeHtml,
        /// <summary>
        /// JPEG
        /// </summary>
        TypeJpeg,
        /// <summary>
        /// JSON
        /// </summary>
        TypeJson,
        /// <summary>
        /// M4A
        /// </summary>
        TypeM4a,
        /// <summary>
        /// MARKDOWN
        /// </summary>
        TypeMarkdown,
        /// <summary>
        /// MKV
        /// </summary>
        TypeMkv,
        /// <summary>
        /// MOV
        /// </summary>
        TypeMov,
        /// <summary>
        /// Audio types
        /// </summary>
        TypeMp3,
        /// <summary>
        /// Video types
        /// </summary>
        TypeMp4,
        /// <summary>
        /// MPEG
        /// </summary>
        TypeMpeg,
        /// <summary>
        /// OGG
        /// </summary>
        TypeOgg,
        /// <summary>
        /// Container-based document types
        /// </summary>
        TypePdf,
        /// <summary>
        /// Image types
        /// </summary>
        TypePng,
        /// <summary>
        /// PPT
        /// </summary>
        TypePpt,
        /// <summary>
        /// PPTX
        /// </summary>
        TypePptx,
        /// <summary>
        /// SVG
        /// </summary>
        TypeSvg,
        /// <summary>
        /// Text-based document types
        /// </summary>
        TypeText,
        /// <summary>
        /// TIFF
        /// </summary>
        TypeTiff,
        /// <summary>
        /// WAV
        /// </summary>
        TypeWav,
        /// <summary>
        /// WEBM (audio)
        /// </summary>
        TypeWebmAudio,
        /// <summary>
        /// WEBM (video)
        /// </summary>
        TypeWebmVideo,
        /// <summary>
        /// WEBP
        /// </summary>
        TypeWebp,
        /// <summary>
        /// WMA
        /// </summary>
        TypeWma,
        /// <summary>
        /// WMV
        /// </summary>
        TypeWmv,
        /// <summary>
        /// XLS
        /// </summary>
        TypeXls,
        /// <summary>
        /// XLSX
        /// </summary>
        TypeXlsx,
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
                FileType.TypeAac => "TYPE_AAC",
                FileType.TypeAiff => "TYPE_AIFF",
                FileType.TypeAvi => "TYPE_AVI",
                FileType.TypeAvif => "TYPE_AVIF",
                FileType.TypeBmp => "TYPE_BMP",
                FileType.TypeCsv => "TYPE_CSV",
                FileType.TypeDoc => "TYPE_DOC",
                FileType.TypeDocx => "TYPE_DOCX",
                FileType.TypeFlac => "TYPE_FLAC",
                FileType.TypeFlv => "TYPE_FLV",
                FileType.TypeGif => "TYPE_GIF",
                FileType.TypeHeic => "TYPE_HEIC",
                FileType.TypeHeif => "TYPE_HEIF",
                FileType.TypeHtml => "TYPE_HTML",
                FileType.TypeJpeg => "TYPE_JPEG",
                FileType.TypeJson => "TYPE_JSON",
                FileType.TypeM4a => "TYPE_M4A",
                FileType.TypeMarkdown => "TYPE_MARKDOWN",
                FileType.TypeMkv => "TYPE_MKV",
                FileType.TypeMov => "TYPE_MOV",
                FileType.TypeMp3 => "TYPE_MP3",
                FileType.TypeMp4 => "TYPE_MP4",
                FileType.TypeMpeg => "TYPE_MPEG",
                FileType.TypeOgg => "TYPE_OGG",
                FileType.TypePdf => "TYPE_PDF",
                FileType.TypePng => "TYPE_PNG",
                FileType.TypePpt => "TYPE_PPT",
                FileType.TypePptx => "TYPE_PPTX",
                FileType.TypeSvg => "TYPE_SVG",
                FileType.TypeText => "TYPE_TEXT",
                FileType.TypeTiff => "TYPE_TIFF",
                FileType.TypeWav => "TYPE_WAV",
                FileType.TypeWebmAudio => "TYPE_WEBM_AUDIO",
                FileType.TypeWebmVideo => "TYPE_WEBM_VIDEO",
                FileType.TypeWebp => "TYPE_WEBP",
                FileType.TypeWma => "TYPE_WMA",
                FileType.TypeWmv => "TYPE_WMV",
                FileType.TypeXls => "TYPE_XLS",
                FileType.TypeXlsx => "TYPE_XLSX",
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
                "TYPE_AAC" => FileType.TypeAac,
                "TYPE_AIFF" => FileType.TypeAiff,
                "TYPE_AVI" => FileType.TypeAvi,
                "TYPE_AVIF" => FileType.TypeAvif,
                "TYPE_BMP" => FileType.TypeBmp,
                "TYPE_CSV" => FileType.TypeCsv,
                "TYPE_DOC" => FileType.TypeDoc,
                "TYPE_DOCX" => FileType.TypeDocx,
                "TYPE_FLAC" => FileType.TypeFlac,
                "TYPE_FLV" => FileType.TypeFlv,
                "TYPE_GIF" => FileType.TypeGif,
                "TYPE_HEIC" => FileType.TypeHeic,
                "TYPE_HEIF" => FileType.TypeHeif,
                "TYPE_HTML" => FileType.TypeHtml,
                "TYPE_JPEG" => FileType.TypeJpeg,
                "TYPE_JSON" => FileType.TypeJson,
                "TYPE_M4A" => FileType.TypeM4a,
                "TYPE_MARKDOWN" => FileType.TypeMarkdown,
                "TYPE_MKV" => FileType.TypeMkv,
                "TYPE_MOV" => FileType.TypeMov,
                "TYPE_MP3" => FileType.TypeMp3,
                "TYPE_MP4" => FileType.TypeMp4,
                "TYPE_MPEG" => FileType.TypeMpeg,
                "TYPE_OGG" => FileType.TypeOgg,
                "TYPE_PDF" => FileType.TypePdf,
                "TYPE_PNG" => FileType.TypePng,
                "TYPE_PPT" => FileType.TypePpt,
                "TYPE_PPTX" => FileType.TypePptx,
                "TYPE_SVG" => FileType.TypeSvg,
                "TYPE_TEXT" => FileType.TypeText,
                "TYPE_TIFF" => FileType.TypeTiff,
                "TYPE_WAV" => FileType.TypeWav,
                "TYPE_WEBM_AUDIO" => FileType.TypeWebmAudio,
                "TYPE_WEBM_VIDEO" => FileType.TypeWebmVideo,
                "TYPE_WEBP" => FileType.TypeWebp,
                "TYPE_WMA" => FileType.TypeWma,
                "TYPE_WMV" => FileType.TypeWmv,
                "TYPE_XLS" => FileType.TypeXls,
                "TYPE_XLSX" => FileType.TypeXlsx,
                _ => null,
            };
        }
    }
}