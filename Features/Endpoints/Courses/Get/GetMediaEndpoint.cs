using mersad_dev.Utility;
using Microsoft.AspNetCore.Mvc;
using FastEndpoints;
namespace mersad_dev.Features.Endpoints.Courses.Get;

public class GetMediaEndpoint : Endpoint<MediaRequest>
{

    private readonly ByteFileUtility _byteFileUtility;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public GetMediaEndpoint(ByteFileUtility byteFileUtility, IHttpContextAccessor httpContextAccessor)
    {
        _byteFileUtility = byteFileUtility;
        _httpContextAccessor = httpContextAccessor;
    }
    public override void Configure()
    {
        Get("Media/{entity}/{fileName}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MediaRequest req, CancellationToken ct)
    {
        var fileInfo = new System.IO.FileInfo(_byteFileUtility.GetFileFullPath(req.fileName, req.entity));
        try
        {
            await SendFileAsync(fileInfo, cancellation: ct);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex);
        }
    }

}