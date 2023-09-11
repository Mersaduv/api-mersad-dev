namespace mersad_dev.Features.Endpoints.Courses.Create;

public class CreateSummary : Summary<Endpoints>
{
    public CreateSummary()
    {
        Summary = "Creates a new course.";
        Description = "Creates a new course.";
        Response<Response>(201, "course was sucessfully created.");
    }
}