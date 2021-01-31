using System;

namespace TestDomain
{
    [Serializable]
    public class Msg
    {
        public string Id { get; private set; } = string.Empty;

        public string Content { get; private set; } = string.Empty;

        public Msg(string id, string content)
        {
            Id = id;
            Content = content;
        }
    }
}
