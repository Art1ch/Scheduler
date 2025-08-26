using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.SchoolDay;

internal sealed class CreateSchoolDayCommandHandler : IRequestHandler<CreateSchoolDayCommand, Unit>
{
    private readonly ISchoolDayRepository _schoolDayRepository;
    private readonly IMapper _mapper;

    public CreateSchoolDayCommandHandler(
        ISchoolDayRepository schoolDayRepository,
        IMapper mapper
    )
    {
        _schoolDayRepository = schoolDayRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateSchoolDayCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<SchoolDayEntity>(request);
        await _schoolDayRepository.AddAsync(entity, cancellationToken);

        return Unit.Value;
    }
}
