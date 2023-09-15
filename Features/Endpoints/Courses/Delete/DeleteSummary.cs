
namespace mersad_dev.Features.Endpoints.Courses.Delete;

public class DeleteSummary : Summary<Endpoints>
{
    public DeleteSummary()
    {
        Summary = "Delete an course.";
        Description = "Delete an course.";
        Response(204, "The course was deleted successfully");
        Response(404, "The course was not found.");
    }

}