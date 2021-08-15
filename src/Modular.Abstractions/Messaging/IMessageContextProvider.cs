namespace Modular.Abstractions.Messaging
{
    public interface IMessageContextProvider
    {
        IMessageContext Get(IMessage message);
    }
}