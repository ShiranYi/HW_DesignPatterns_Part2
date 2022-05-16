
namespace HW_DesignPatterns_Part2.Mediator
{
    public interface IFacebookGroup
    {
        void Send (string message, IMember member);
        void Register(IMember member);


    }
}
