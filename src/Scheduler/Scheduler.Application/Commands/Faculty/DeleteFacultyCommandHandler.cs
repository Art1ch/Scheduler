using MediatR;
using Scheduler.Application.Contracts.Repositories;

namespace Scheduler.Application.Commands.Faculty;

public sealed class DeleteFacultyCommandHandler : IRequestHandler<DeleteFacultyCommand, Unit>
{
    private readonly IFacultyRepository _facultyRepository;

    public DeleteFacultyCommandHandler(
        IFacultyRepository facultyRepository
    )
    {
        _facultyRepository= facultyRepository;
    }

    public async Task<Unit> Handle(DeleteFacultyCommand command, CancellationToken cancellationToken)
    {
        var id = command.Request.Id;
        await _facultyRepository.DeleteAsync(id, cancellationToken);

        return Unit.Value;
    }
}
