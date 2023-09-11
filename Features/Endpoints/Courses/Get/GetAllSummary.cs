namespace mersad_dev.Features.Endpoints.Courses.Get;

public class GetAllSummary : Summary<GetAllEndpoint>
{
    #region Constructor

    public GetAllSummary()
    {
        Summary = "Returns all the course.";
        Description = "Returns all the course.";
        Response<Response>(200, "All course was sucessfully created.");
    }

    #endregion
}