using MediatR;
using Scheduler.Application.Contracts.Repositories;

namespace Scheduler.Application.Commands.SchoolDay;

internal sealed class DeleteSchoolDayCommandHandler : IRequestHandler<DeleteSchoolDayCommand, Unit>
{
    private readonly ISchoolDayRepository _schoolDayRepository;

    public DeleteSchoolDayCommandHandler(
        ISchoolDayRepository schoolDayRepository
    )
    {
        _schoolDayRepository = schoolDayRepository;
    }

    public async Task<Unit> Handle(DeleteSchoolDayCommand command, CancellationToken cancellationToken)
    {
        var id = command.Request.Id;
        await _schoolDayRepository.DeleteAsync(id, cancellationToken);

        return Unit.Value;
    }
}