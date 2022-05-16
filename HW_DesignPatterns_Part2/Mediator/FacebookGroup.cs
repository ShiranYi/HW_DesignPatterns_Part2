namespace HW_DesignPatterns_Part2.Mediator
{
    public class FacebookGroup : IFacebookGroup
    {
        private readonly List<IMember> members = new List<IMember>();

        public void Register(IMember member)
        {
            members.Add(member);
        }

        public void Send(string message, IMember member)
        {
            foreach (IMember mem in members)
            {
                if (mem != member) mem.Receive(message);
            }
        }

    }
}
