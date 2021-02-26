namespace CSharpNews
{
    public class DeconstructClassSample
    {
        public DeconstructClassSample(string name, long mobile)
        {
            (Name, Mobile) = (name, mobile);
        }

        public string Name { get; }
        public long Mobile { get; }

        public void Deconstruct(out string name, out long mobile) =>
            (name, mobile) = (Name, Mobile);
    }
}