
#nullable enable

namespace Instill
{
    /// <summary>
    /// Supported file types by the pipeline-backend.<br/>
    ///  - TYPE_TEXT: Text-based document types<br/>
    /// text<br/>
    ///  - TYPE_PDF: PDF<br/>
    ///  - TYPE_MARKDOWN: MARKDOWN<br/>
    ///  - TYPE_HTML: HTML<br/>
    ///  - TYPE_CSV: CSV<br/>
    ///  - TYPE_DOCX: Microsoft Office document types<br/>
    /// DOCX<br/>
    ///  - TYPE_DOC: DOC<br/>
    ///  - TYPE_PPT: PPT<br/>
    ///  - TYPE_PPTX: PPTX<br/>
    ///  - TYPE_XLS: XLS<br/>
    ///  - TYPE_XLSX: XLSX<br/>
    ///  - TYPE_PNG: Image types (supported by pipeline-backend/pkg/data/image.go)<br/>
    /// PNG<br/>
    ///  - TYPE_JPEG: JPEG<br/>
    ///  - TYPE_JPG: JPG<br/>
    ///  - TYPE_GIF: GIF<br/>
    ///  - TYPE_WEBP: WEBP<br/>
    ///  - TYPE_TIFF: TIFF<br/>
    ///  - TYPE_BMP: BMP<br/>
    ///  - TYPE_HEIC: HEIC<br/>
    ///  - TYPE_HEIF: HEIF<br/>
    ///  - TYPE_AVIF: AVIF<br/>
    ///  - TYPE_MP3: Audio types (supported by pipeline-backend/pkg/data/audio.go)<br/>
    /// MP3<br/>
    ///  - TYPE_WAV: WAV<br/>
    ///  - TYPE_AAC: AAC<br/>
    ///  - TYPE_OGG: OGG<br/>
    ///  - TYPE_FLAC: FLAC<br/>
    ///  - TYPE_M4A: M4A<br/>
    ///  - TYPE_WMA: WMA<br/>
    ///  - TYPE_AIFF: AIFF<br/>
    ///  - TYPE_MP4: Video types (supported by pipeline-backend/pkg/data/video.go)<br/>
    /// MP4<br/>
    ///  - TYPE_AVI: AVI<br/>
    ///  - TYPE_MOV: MOV<br/>
    ///  - TYPE_WEBM_VIDEO: WEBM (video)<br/>
    ///  - TYPE_MKV: MKV<br/>
    ///  - TYPE_FLV: FLV<br/>
    ///  - TYPE_WMV: WMV<br/>
    ///  - TYPE_MPEG: MPEG
    /// </summary>
    public enum FileType
    {
        /// <summary>
        /// Text-based document types
        /// </summary>
        TypeText,
        /// <summary>
        /// PDF
        /// </summary>
        TypePdf,
        /// <summary>
        /// MARKDOWN
        /// </summary>
        TypeMarkdown,
        /// <summary>
        /// HTML
        /// </summary>
        TypeHtml,
        /// <summary>
        /// CSV
        /// </summary>
        TypeCsv,
        /// <summary>
        /// Microsoft Office document types
        /// </summary>
        TypeDocx,
        /// <summary>
        /// Microsoft Office document types
        /// </summary>
        TypeDoc,
        /// <summary>
        /// PPT
        /// </summary>
        TypePpt,
        /// <summary>
        /// PPTX
        /// </summary>
        TypePptx,
        /// <summary>
        /// XLS
        /// </summary>
        TypeXls,
        /// <summary>
        /// XLSX
        /// </summary>
        TypeXlsx,
        /// <summary>
        /// Image types (supported by pipeline-backend/pkg/data/image.go)
        /// </summary>
        TypePng,
        /// <summary>
        /// JPEG
        /// </summary>
        TypeJpeg,
        /// <summary>
        /// JPG
        /// </summary>
        TypeJpg,
        /// <summary>
        /// GIF
        /// </summary>
        TypeGif,
        /// <summary>
        /// WEBP
        /// </summary>
        TypeWebp,
        /// <summary>
        /// TIFF
        /// </summary>
        TypeTiff,
        /// <summary>
        /// BMP
        /// </summary>
        TypeBmp,
        /// <summary>
        /// HEIC
        /// </summary>
        TypeHeic,
        /// <summary>
        /// HEIF
        /// </summary>
        TypeHeif,
        /// <summary>
        /// AVIF
        /// </summary>
        TypeAvif,
        /// <summary>
        /// Audio types (supported by pipeline-backend/pkg/data/audio.go)
        /// </summary>
        TypeMp3,
        /// <summary>
        /// WAV
        /// </summary>
        TypeWav,
        /// <summary>
        /// AAC
        /// </summary>
        TypeAac,
        /// <summary>
        /// OGG
        /// </summary>
        TypeOgg,
        /// <summary>
        /// FLAC
        /// </summary>
        TypeFlac,
        /// <summary>
        /// M4A
        /// </summary>
        TypeM4a,
        /// <summary>
        /// WMA
        /// </summary>
        TypeWma,
        /// <summary>
        /// AIFF
        /// </summary>
        TypeAiff,
        /// <summary>
        /// Video types (supported by pipeline-backend/pkg/data/video.go)
        /// </summary>
        TypeMp4,
        /// <summary>
        /// AVIF
        /// </summary>
        TypeAvi,
        /// <summary>
        /// MOV
        /// </summary>
        TypeMov,
        /// <summary>
        /// WEBM (video)
        /// </summary>
        TypeWebmVideo,
        /// <summary>
        /// MKV
        /// </summary>
        TypeMkv,
        /// <summary>
        /// FLV
        /// </summary>
        TypeFlv,
        /// <summary>
        /// WMV
        /// </summary>
        TypeWmv,
        /// <summary>
        /// MPEG
        /// </summary>
        TypeMpeg,
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
                FileType.TypeText => "TYPE_TEXT",
                FileType.TypePdf => "TYPE_PDF",
                FileType.TypeMarkdown => "TYPE_MARKDOWN",
                FileType.TypeHtml => "TYPE_HTML",
                FileType.TypeCsv => "TYPE_CSV",
                FileType.TypeDocx => "TYPE_DOCX",
                FileType.TypeDoc => "TYPE_DOC",
                FileType.TypePpt => "TYPE_PPT",
                FileType.TypePptx => "TYPE_PPTX",
                FileType.TypeXls => "TYPE_XLS",
                FileType.TypeXlsx => "TYPE_XLSX",
                FileType.TypePng => "TYPE_PNG",
                FileType.TypeJpeg => "TYPE_JPEG",
                FileType.TypeJpg => "TYPE_JPG",
                FileType.TypeGif => "TYPE_GIF",
                FileType.TypeWebp => "TYPE_WEBP",
                FileType.TypeTiff => "TYPE_TIFF",
                FileType.TypeBmp => "TYPE_BMP",
                FileType.TypeHeic => "TYPE_HEIC",
                FileType.TypeHeif => "TYPE_HEIF",
                FileType.TypeAvif => "TYPE_AVIF",
                FileType.TypeMp3 => "TYPE_MP3",
                FileType.TypeWav => "TYPE_WAV",
                FileType.TypeAac => "TYPE_AAC",
                FileType.TypeOgg => "TYPE_OGG",
                FileType.TypeFlac => "TYPE_FLAC",
                FileType.TypeM4a => "TYPE_M4A",
                FileType.TypeWma => "TYPE_WMA",
                FileType.TypeAiff => "TYPE_AIFF",
                FileType.TypeMp4 => "TYPE_MP4",
                FileType.TypeAvi => "TYPE_AVI",
                FileType.TypeMov => "TYPE_MOV",
                FileType.TypeWebmVideo => "TYPE_WEBM_VIDEO",
                FileType.TypeMkv => "TYPE_MKV",
                FileType.TypeFlv => "TYPE_FLV",
                FileType.TypeWmv => "TYPE_WMV",
                FileType.TypeMpeg => "TYPE_MPEG",
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
                "TYPE_TEXT" => FileType.TypeText,
                "TYPE_PDF" => FileType.TypePdf,
                "TYPE_MARKDOWN" => FileType.TypeMarkdown,
                "TYPE_HTML" => FileType.TypeHtml,
                "TYPE_CSV" => FileType.TypeCsv,
                "TYPE_DOCX" => FileType.TypeDocx,
                "TYPE_DOC" => FileType.TypeDoc,
                "TYPE_PPT" => FileType.TypePpt,
                "TYPE_PPTX" => FileType.TypePptx,
                "TYPE_XLS" => FileType.TypeXls,
                "TYPE_XLSX" => FileType.TypeXlsx,
                "TYPE_PNG" => FileType.TypePng,
                "TYPE_JPEG" => FileType.TypeJpeg,
                "TYPE_JPG" => FileType.TypeJpg,
                "TYPE_GIF" => FileType.TypeGif,
                "TYPE_WEBP" => FileType.TypeWebp,
                "TYPE_TIFF" => FileType.TypeTiff,
                "TYPE_BMP" => FileType.TypeBmp,
                "TYPE_HEIC" => FileType.TypeHeic,
                "TYPE_HEIF" => FileType.TypeHeif,
                "TYPE_AVIF" => FileType.TypeAvif,
                "TYPE_MP3" => FileType.TypeMp3,
                "TYPE_WAV" => FileType.TypeWav,
                "TYPE_AAC" => FileType.TypeAac,
                "TYPE_OGG" => FileType.TypeOgg,
                "TYPE_FLAC" => FileType.TypeFlac,
                "TYPE_M4A" => FileType.TypeM4a,
                "TYPE_WMA" => FileType.TypeWma,
                "TYPE_AIFF" => FileType.TypeAiff,
                "TYPE_MP4" => FileType.TypeMp4,
                "TYPE_AVI" => FileType.TypeAvi,
                "TYPE_MOV" => FileType.TypeMov,
                "TYPE_WEBM_VIDEO" => FileType.TypeWebmVideo,
                "TYPE_MKV" => FileType.TypeMkv,
                "TYPE_FLV" => FileType.TypeFlv,
                "TYPE_WMV" => FileType.TypeWmv,
                "TYPE_MPEG" => FileType.TypeMpeg,
                _ => null,
            };
        }
    }
}