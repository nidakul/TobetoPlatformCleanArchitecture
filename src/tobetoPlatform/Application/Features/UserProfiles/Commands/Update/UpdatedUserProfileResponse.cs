using Core.Application.Responses;

namespace Application.Features.UserProfiles.Commands.Update;

public class UpdatedUserProfileResponse : IResponse
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ProfileAddressId { get; set; }
    public int ProfileShareId { get; set; }
    public string NationalIdentity { get; set; }
    public string Phone { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Description { get; set; }
    public string Message { get; set; }
}