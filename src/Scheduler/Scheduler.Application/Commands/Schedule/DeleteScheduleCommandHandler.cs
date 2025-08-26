using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;

namespace Scheduler.Application.Commands.Schedule;

internal sealed class DeleteScheduleCommandHandler : IRequestHandler<DeleteScheduleCommand, Unit>
{
    private readonly IScheduleRepository _scheduleRepository;
    private readonly IMapper _mapper;

    public DeleteScheduleCommandHandler(
        IScheduleRepository scheduleRepository,
        IMapper mapper
    )
    {
        _scheduleRepository = scheduleRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteScheduleCommand command, CancellationToken cancellationToken)
    {
        var id = command.Request.Id;
        await _scheduleRepository.DeleteAsync(id, cancellationToken);

        return Unit.Value;
    }
}