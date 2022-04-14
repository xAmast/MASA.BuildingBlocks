namespace Masa.BuildingBlocks.SearchEngine.AutoComplete;
public interface IAutoCompleteClient
{
    Task<GetResponse<AutoCompleteDocument<TValue>, TValue>> GetAsync<TValue>(
        string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<GetResponse<TAudoCompleteDocument, TValue>> GetAsync<TAudoCompleteDocument, TValue>(
        string keyword,
        AutoCompleteOptions? options = null,
        CancellationToken cancellationToken = default)
        where TAudoCompleteDocument : AutoCompleteDocument<TValue>;

    Task<SetResponse> SetAsync<TValue>(
        IEnumerable<AutoCompleteDocument<TValue>> results,
        SetOptions? options = null,
        CancellationToken cancellationToken = default);

    Task<SetResponse> SetAsync<TAudoCompleteDocument, TValue>(
        IEnumerable<TAudoCompleteDocument> documents,
        SetOptions? options = null,
        CancellationToken cancellationToken = default) where TAudoCompleteDocument : AutoCompleteDocument<TValue>;

    Task<DeleteResponse> DeleteAsync<TValue>(AutoCompleteDocument<TValue> document);

    Task<DeleteMultiResponse> DeleteMultiAsyncAsync<TValue>(IEnumerable<AutoCompleteDocument<TValue>> documents);

    Task<DeleteResponse> DeleteAsync<TAudoCompleteDocument, TValue>(TAudoCompleteDocument document)
        where TAudoCompleteDocument : AutoCompleteDocument<TValue>;

    Task<DeleteMultiResponse> DeleteMultiAsyncAsync<TAudoCompleteDocument, TValue>(IEnumerable<TAudoCompleteDocument> documents)
        where TAudoCompleteDocument : AutoCompleteDocument<TValue>;
}
