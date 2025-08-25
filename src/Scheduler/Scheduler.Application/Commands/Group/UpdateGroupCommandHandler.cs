using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.Group;

internal sealed class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand, Unit>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public UpdateGroupCommandHandler(
        IGroupRepository groupRepository,
        IMapper mapper
    )
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateGroupCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<GroupEntity>(request);
        await _groupRepository.UpdateAsync(entity, cancellationToken);

        return Unit.Value;
    }
}
