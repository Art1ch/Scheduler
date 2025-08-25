using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.Faculty;

internal sealed class CreateFacultyCommandHandler : IRequestHandler<CreateFacultyCommand, Unit>
{
    private readonly IFacultyRepository _facultyRepository;
    private readonly IMapper _mapper;

    public CreateFacultyCommandHandler(
        IFacultyRepository facultyRepository,
        IMapper mapper
    )
    {
        _facultyRepository = facultyRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateFacultyCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<FacultyEntity>(request);
        await _facultyRepository.AddAsync(entity, cancellationToken);

        return Unit.Value;
    }
}
