namespace Modular.Infrastructure.Security.Encryption;

public interface IHasher
{
    string Hash(string data);
}