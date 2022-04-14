namespace Masa.BuildingBlocks.SearchEngine.AutoComplete.Response;
public class DeleteMultiResponse : ResponseBase
{
    public List<DeleteRangeResponseItems> Data { get; set; }

    public DeleteMultiResponse(bool isValid, string message) : base(isValid, message)
    {

    }
}
