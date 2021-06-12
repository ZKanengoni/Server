namespace Server
{
    class NoteBlock: Resource
    {
        public NoteBlock(int newCount): base(newCount)
        {
            resourceType = "Note Block";
            classType = this;
        }
    }
}