namespace DependencyInjection.Models
{
    public interface IUtilityService
    {
        string RandomColor();
        string ValidateEmail(string email);
    }
}