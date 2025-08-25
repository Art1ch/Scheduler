using MediatR;
using Scheduler.Application.Contracts.Repositories;

namespace Scheduler.Application.Commands.Group;

internal sealed class DeleteGroupCommandHandler : IRequestHandler<DeleteGroupCommand, Unit>
{
    private readonly IGroupRepository _groupRepository;

    public DeleteGroupCommandHandler(
        IGroupRepository groupRepository
    )
    {
        _groupRepository = groupRepository;
    }

    public async Task<Unit> Handle(DeleteGroupCommand command, CancellationToken cancellationToken)
    {
        var id = command.Request.Id;
        await _groupRepository.DeleteAsync(id, cancellationToken);

        return Unit.Value;
    }
}