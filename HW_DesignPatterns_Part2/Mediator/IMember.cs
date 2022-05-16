
namespace HW_DesignPatterns_Part2.Mediator
{
    public interface IMember
    {
        void Publish(string message);
        void Receive(string message);
     
    }
}
