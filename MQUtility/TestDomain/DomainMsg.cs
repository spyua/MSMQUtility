using System;

namespace TestDomain
{
    [Serializable]
    public class DomainMsg
    {
        public string Id { get; private set; } = string.Empty;

        public string Content { get; private set; } = string.Empty;

        public DomainMsg(string id, string content)
        {
            Id = id;
            Content = content;
        }
    }
}
