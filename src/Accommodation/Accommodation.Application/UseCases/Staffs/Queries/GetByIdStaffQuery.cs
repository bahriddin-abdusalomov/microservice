namespace Accommodation.Application.UseCases.Staffs.Queries;

public class GetByIdStaffQuery : IRequest<Staff>
{
    public long Id { get; set; }
}
