using Core.Application.Responses;

namespace Application.Features.Districts.Queries.GetById;

public class GetByIdDistrictResponse : IResponse
{
    public int Id { get; set; }
    public int CityId { get; set; }
    public string Name { get; set; }
    public int Priority { get; set; }
    public bool Visibility { get; set; }
}