namespace Accommodation.Application.UseCases.Staffs.Commands;

public class DeleteStaffCommand : IRequest<int>
{
    public long Id { get; set; }
}
