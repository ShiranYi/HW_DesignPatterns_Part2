
namespace HW_DesignPatterns_Part2.Mediator
{
    public class Member : IMember
    {
        private readonly IFacebookGroup group;
        private string name;

        public Member(IFacebookGroup group, string name)
        {
            this.group = group;
            this.name = name;
        }
        public void Receive(string message)
        {
            Console.WriteLine($"{name} Get new meggase: {message}");
        }
        public void Publish(string message)
        {
            Console.WriteLine($"New meggase from {name}: {message}\n");
            group.Send(message,this);
        }

        
    }
}



