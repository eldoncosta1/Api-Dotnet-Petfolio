using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;
public class ResponseShortPetsJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetTypeEnum Type { get; set; }
}
