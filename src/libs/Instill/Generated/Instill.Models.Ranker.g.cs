
#nullable enable

namespace Instill
{
    /// <summary>
    /// Ranker identifies which Milvus hybrid-search reranker produced the<br/>
    /// scores on a `SearchChunksResponse`. The score distribution depends on<br/>
    /// the reranker, and downstream consumers that apply score-based<br/>
    /// thresholds MUST read this field so they can pick the correct floor<br/>
    /// shape (absolute [0,1] floor for `RANKER_WEIGHTED`; rank-structural<br/>
    /// `1/(k+topK)` floor for `RANKER_RRF`).<br/>
    ///  - RANKER_WEIGHTED: RANKER_WEIGHTED is Milvus' WeightedRanker (dense + BM25 combined<br/>
    /// with static weights); scores are normalised to [0,1].<br/>
    ///  - RANKER_RRF: RANKER_RRF is Reciprocal Rank Fusion with smoothing constant k<br/>
    /// (Milvus default 60); scores live in (0, 2/(k+1)].
    /// </summary>
    public enum Ranker
    {
        /// <summary>
        /// RANKER_RRF is Reciprocal Rank Fusion with smoothing constant k
        /// </summary>
        Rrf,
        /// <summary>
        /// RANKER_WEIGHTED is Milvus' WeightedRanker (dense + BM25 combined
        /// </summary>
        Weighted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Ranker value)
        {
            return value switch
            {
                Ranker.Rrf => "RANKER_RRF",
                Ranker.Weighted => "RANKER_WEIGHTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Ranker? ToEnum(string value)
        {
            return value switch
            {
                "RANKER_RRF" => Ranker.Rrf,
                "RANKER_WEIGHTED" => Ranker.Weighted,
                _ => null,
            };
        }
    }
}