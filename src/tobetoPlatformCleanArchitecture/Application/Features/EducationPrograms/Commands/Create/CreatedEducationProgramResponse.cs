using Core.Application.Responses;

namespace Application.Features.EducationPrograms.Commands.Create;

public class CreatedEducationProgramResponse : IResponse
{
    public int Id { get; set; }
    public int CollegeId { get; set; }
    public string Name { get; set; }
    public bool Visibility { get; set; }
}