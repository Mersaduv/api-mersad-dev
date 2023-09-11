namespace mersad_dev.Features.Endpoints.Courses.Get;

public class GetSummary : Summary<GetEndpoint>
{
    public GetSummary()
    {
        Summary = "Return a single course by id.";
        Description = "Return a single course by id.";
        Response<Response>(200, "Successfully found and returned the course.");
        Response(404, "The customer does not exist.");
    }

}