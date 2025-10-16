
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
        TYPETEXT,
        /// <summary>
        /// PDF
        /// </summary>
        TYPEPDF,
        /// <summary>
        /// MARKDOWN
        /// </summary>
        TYPEMARKDOWN,
        /// <summary>
        /// HTML
        /// </summary>
        TYPEHTML,
        /// <summary>
        /// CSV
        /// </summary>
        TYPECSV,
        /// <summary>
        /// Microsoft Office document types
        /// </summary>
        TYPEDOCX,
        /// <summary>
        /// Microsoft Office document types
        /// </summary>
        TYPEDOC,
        /// <summary>
        /// PPT
        /// </summary>
        TYPEPPT,
        /// <summary>
        /// PPTX
        /// </summary>
        TYPEPPTX,
        /// <summary>
        /// XLS
        /// </summary>
        TYPEXLS,
        /// <summary>
        /// XLSX
        /// </summary>
        TYPEXLSX,
        /// <summary>
        /// Image types (supported by pipeline-backend/pkg/data/image.go)
        /// </summary>
        TYPEPNG,
        /// <summary>
        /// JPEG
        /// </summary>
        TYPEJPEG,
        /// <summary>
        /// JPG
        /// </summary>
        TYPEJPG,
        /// <summary>
        /// GIF
        /// </summary>
        TYPEGIF,
        /// <summary>
        /// WEBP
        /// </summary>
        TYPEWEBP,
        /// <summary>
        /// TIFF
        /// </summary>
        TYPETIFF,
        /// <summary>
        /// BMP
        /// </summary>
        TYPEBMP,
        /// <summary>
        /// HEIC
        /// </summary>
        TYPEHEIC,
        /// <summary>
        /// HEIF
        /// </summary>
        TYPEHEIF,
        /// <summary>
        /// AVIF
        /// </summary>
        TYPEAVIF,
        /// <summary>
        /// Audio types (supported by pipeline-backend/pkg/data/audio.go)
        /// </summary>
        TYPEMP3,
        /// <summary>
        /// WAV
        /// </summary>
        TYPEWAV,
        /// <summary>
        /// AAC
        /// </summary>
        TYPEAAC,
        /// <summary>
        /// OGG
        /// </summary>
        TYPEOGG,
        /// <summary>
        /// FLAC
        /// </summary>
        TYPEFLAC,
        /// <summary>
        /// M4A
        /// </summary>
        TYPEM4A,
        /// <summary>
        /// WMA
        /// </summary>
        TYPEWMA,
        /// <summary>
        /// AIFF
        /// </summary>
        TYPEAIFF,
        /// <summary>
        /// Video types (supported by pipeline-backend/pkg/data/video.go)
        /// </summary>
        TYPEMP4,
        /// <summary>
        /// AVIF
        /// </summary>
        TYPEAVI,
        /// <summary>
        /// MOV
        /// </summary>
        TYPEMOV,
        /// <summary>
        /// WEBM (video)
        /// </summary>
        TYPEWEBMVIDEO,
        /// <summary>
        /// MKV
        /// </summary>
        TYPEMKV,
        /// <summary>
        /// FLV
        /// </summary>
        TYPEFLV,
        /// <summary>
        /// WMV
        /// </summary>
        TYPEWMV,
        /// <summary>
        /// MPEG
        /// </summary>
        TYPEMPEG,
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
                FileType.TYPETEXT => "TYPE_TEXT",
                FileType.TYPEPDF => "TYPE_PDF",
                FileType.TYPEMARKDOWN => "TYPE_MARKDOWN",
                FileType.TYPEHTML => "TYPE_HTML",
                FileType.TYPECSV => "TYPE_CSV",
                FileType.TYPEDOCX => "TYPE_DOCX",
                FileType.TYPEDOC => "TYPE_DOC",
                FileType.TYPEPPT => "TYPE_PPT",
                FileType.TYPEPPTX => "TYPE_PPTX",
                FileType.TYPEXLS => "TYPE_XLS",
                FileType.TYPEXLSX => "TYPE_XLSX",
                FileType.TYPEPNG => "TYPE_PNG",
                FileType.TYPEJPEG => "TYPE_JPEG",
                FileType.TYPEJPG => "TYPE_JPG",
                FileType.TYPEGIF => "TYPE_GIF",
                FileType.TYPEWEBP => "TYPE_WEBP",
                FileType.TYPETIFF => "TYPE_TIFF",
                FileType.TYPEBMP => "TYPE_BMP",
                FileType.TYPEHEIC => "TYPE_HEIC",
                FileType.TYPEHEIF => "TYPE_HEIF",
                FileType.TYPEAVIF => "TYPE_AVIF",
                FileType.TYPEMP3 => "TYPE_MP3",
                FileType.TYPEWAV => "TYPE_WAV",
                FileType.TYPEAAC => "TYPE_AAC",
                FileType.TYPEOGG => "TYPE_OGG",
                FileType.TYPEFLAC => "TYPE_FLAC",
                FileType.TYPEM4A => "TYPE_M4A",
                FileType.TYPEWMA => "TYPE_WMA",
                FileType.TYPEAIFF => "TYPE_AIFF",
                FileType.TYPEMP4 => "TYPE_MP4",
                FileType.TYPEAVI => "TYPE_AVI",
                FileType.TYPEMOV => "TYPE_MOV",
                FileType.TYPEWEBMVIDEO => "TYPE_WEBM_VIDEO",
                FileType.TYPEMKV => "TYPE_MKV",
                FileType.TYPEFLV => "TYPE_FLV",
                FileType.TYPEWMV => "TYPE_WMV",
                FileType.TYPEMPEG => "TYPE_MPEG",
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
                "TYPE_TEXT" => FileType.TYPETEXT,
                "TYPE_PDF" => FileType.TYPEPDF,
                "TYPE_MARKDOWN" => FileType.TYPEMARKDOWN,
                "TYPE_HTML" => FileType.TYPEHTML,
                "TYPE_CSV" => FileType.TYPECSV,
                "TYPE_DOCX" => FileType.TYPEDOCX,
                "TYPE_DOC" => FileType.TYPEDOC,
                "TYPE_PPT" => FileType.TYPEPPT,
                "TYPE_PPTX" => FileType.TYPEPPTX,
                "TYPE_XLS" => FileType.TYPEXLS,
                "TYPE_XLSX" => FileType.TYPEXLSX,
                "TYPE_PNG" => FileType.TYPEPNG,
                "TYPE_JPEG" => FileType.TYPEJPEG,
                "TYPE_JPG" => FileType.TYPEJPG,
                "TYPE_GIF" => FileType.TYPEGIF,
                "TYPE_WEBP" => FileType.TYPEWEBP,
                "TYPE_TIFF" => FileType.TYPETIFF,
                "TYPE_BMP" => FileType.TYPEBMP,
                "TYPE_HEIC" => FileType.TYPEHEIC,
                "TYPE_HEIF" => FileType.TYPEHEIF,
                "TYPE_AVIF" => FileType.TYPEAVIF,
                "TYPE_MP3" => FileType.TYPEMP3,
                "TYPE_WAV" => FileType.TYPEWAV,
                "TYPE_AAC" => FileType.TYPEAAC,
                "TYPE_OGG" => FileType.TYPEOGG,
                "TYPE_FLAC" => FileType.TYPEFLAC,
                "TYPE_M4A" => FileType.TYPEM4A,
                "TYPE_WMA" => FileType.TYPEWMA,
                "TYPE_AIFF" => FileType.TYPEAIFF,
                "TYPE_MP4" => FileType.TYPEMP4,
                "TYPE_AVI" => FileType.TYPEAVI,
                "TYPE_MOV" => FileType.TYPEMOV,
                "TYPE_WEBM_VIDEO" => FileType.TYPEWEBMVIDEO,
                "TYPE_MKV" => FileType.TYPEMKV,
                "TYPE_FLV" => FileType.TYPEFLV,
                "TYPE_WMV" => FileType.TYPEWMV,
                "TYPE_MPEG" => FileType.TYPEMPEG,
                _ => null,
            };
        }
    }
}