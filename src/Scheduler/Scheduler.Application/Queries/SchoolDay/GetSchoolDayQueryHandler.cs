using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.SchoolDay;

namespace Scheduler.Application.Queries.SchoolDay;

internal sealed class GetSchoolDayQueryHandler : IRequestHandler<GetSchoolDayQuery, GetSchoolDayResponse>
{
    private readonly ISchoolDayRepository _schoolDayRepository;
    private readonly IMapper _mapper;

    public GetSchoolDayQueryHandler(
        ISchoolDayRepository schoolDayRepository,
        IMapper mapper
    )
    {
        _schoolDayRepository = schoolDayRepository;
        _mapper = mapper;
    }

    public async Task<GetSchoolDayResponse> Handle(GetSchoolDayQuery query, CancellationToken cancellationToken)
    {
        var id = query.Request.Id;
        var entity = await _schoolDayRepository.GetByIdAsync(id, cancellationToken);
        var response = _mapper.Map<GetSchoolDayResponse>(entity);

        return response;
    }
}
