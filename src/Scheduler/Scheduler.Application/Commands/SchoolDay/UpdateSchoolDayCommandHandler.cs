using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Core.Entities;

namespace Scheduler.Application.Commands.SchoolDay;

internal sealed class UpdateSchoolDayCommandHandler : IRequestHandler<UpdateSchoolDayCommand, Unit>
{
    private readonly ISchoolDayRepository _schoolDayRepository;
    private readonly IMapper _mapper;

    public UpdateSchoolDayCommandHandler(
        ISchoolDayRepository schoolDayRepository,
        IMapper mapper
    )
    {
        _schoolDayRepository = schoolDayRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateSchoolDayCommand command, CancellationToken cancellationToken)
    {
        var request = command.Request;
        var entity = _mapper.Map<SchoolDayEntity>(request);
        await _schoolDayRepository.UpdateAsync(entity, cancellationToken);

        return Unit.Value;
    }
}
