using AutoMapper;
using MediatR;
using Scheduler.Application.Contracts.Repositories;
using Scheduler.Application.Responses.SchoolDay;

namespace Scheduler.Application.Queries.SchoolDay;

internal sealed class GetSchoolDayFullQueryHandler
    : IRequestHandler<GetSchoolDayFullQuery, GetSchoolDayFullResponse>
{
    private readonly ISchoolDayRepository _schoolDayRepository;
    private readonly IMapper _mapper;

    public GetSchoolDayFullQueryHandler(
        ISchoolDayRepository schoolDayRepository,
        IMapper mapper
    )
    {
        _schoolDayRepository = schoolDayRepository;
        _mapper = mapper;
    }

    public async Task<GetSchoolDayFullResponse> Handle(
        GetSchoolDayFullQuery query,
        CancellationToken cancellationToken
    )
    {
        var id = query.Request.Id;
        var entity = await _schoolDayRepository.GetFullAsync(id, cancellationToken);
        var response = _mapper.Map<GetSchoolDayFullResponse>(entity);

        return response;
    }
}