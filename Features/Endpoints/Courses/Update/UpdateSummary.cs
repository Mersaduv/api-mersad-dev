namespace mersad_dev.Features.Endpoints.Courses.Update;

public class UpdateSummary : Summary<Endpoints>
{
    public UpdateSummary()
    {
        Summary = "Update an existing course.";
        Description = "Update an existing course.";
        Response<Response>(204, "The course was successfully updated.");
    }

}