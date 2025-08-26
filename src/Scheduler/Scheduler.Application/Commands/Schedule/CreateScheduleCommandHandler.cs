using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.Schedule;

internal sealed class CreateScheduleCommandHandler : IRequestHandler<CreateScheduleCommand, Unit>
{
    private readonly IScheduleRepository _scheduleRepository;
    private readonly IMapper _mapper;

    public CreateScheduleCommandHandler(
        IScheduleRepository scheduleRepository,
        IMapper mapper
    )
    {
        _scheduleRepository = scheduleRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateScheduleCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<ScheduleEntity>(request);
        await _scheduleRepository.AddAsync(entity, cancellationToken);

        return Unit.Value;
    }
}
