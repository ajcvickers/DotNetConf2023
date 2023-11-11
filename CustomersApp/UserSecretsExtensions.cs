using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.Configuration.UserSecrets;

public class UserSecrets
{
    public static string Read(string key)
        => JsonSerializer.Deserialize<Dictionary<string, string>>(
            File.ReadAllText(PathHelper.GetSecretsPathFromSecretsId(
                typeof(UserSecrets).Assembly.GetCustomAttribute<UserSecretsIdAttribute>()!
                    .UserSecretsId)))![key];
}