using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.Group;

internal sealed class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, Unit>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public CreateGroupCommandHandler(
        IGroupRepository groupRepository,
        IMapper mapper
    )
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateGroupCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<GroupEntity>(request);
        await _groupRepository.AddAsync(entity, cancellationToken);

        return Unit.Value;
    }
}