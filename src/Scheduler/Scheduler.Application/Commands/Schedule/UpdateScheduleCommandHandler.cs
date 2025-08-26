using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.Schedule;

internal sealed class UpdateScheduleCommandHandler : IRequestHandler<UpdateScheduleCommand, Unit>
{
    private readonly IScheduleRepository _scheduleRepository;
    private readonly IMapper _mapper;

    public UpdateScheduleCommandHandler(
        IScheduleRepository scheduleRepository,
        IMapper mapper
    )
    {
        _scheduleRepository = scheduleRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateScheduleCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<ScheduleEntity>(request);
        await _scheduleRepository.UpdateAsync(entity, cancellationToken);

        return Unit.Value;
    }
}
