public class UserSessionService
{
    public string CurrentUser { get; set; } = "";
    public bool IsLoggedIn => !string.IsNullOrWhiteSpace(CurrentUser);

    public void Login(string userName)
    {
        CurrentUser = userName;
    }

    public void Logout()
    {
        CurrentUser = "";
    }
}