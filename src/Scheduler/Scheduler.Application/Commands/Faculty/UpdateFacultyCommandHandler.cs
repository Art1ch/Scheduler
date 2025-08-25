using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.Faculty;

internal sealed class UpdateFacultyCommandHandler : IRequestHandler<UpdateFacultyCommand, Unit>
{
    private readonly IFacultyRepository _facultyRepository;
    private readonly IMapper _mapper;

    public UpdateFacultyCommandHandler(
        IFacultyRepository facultyRepository,
        IMapper mapper
    )
    {
        _facultyRepository = facultyRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateFacultyCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<FacultyEntity>(request);
        await _facultyRepository.UpdateAsync(entity, cancellationToken);

        return Unit.Value;
    }
}
