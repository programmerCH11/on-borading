namespace RedLab_on_boarding.Generics
{
    internal sealed class TypedNode<T> : Node
    {
        private T data;

        public TypedNode(T data) : this(data, null)
        {
            
        }

        public TypedNode(T data, Node next) : base(next)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return $"{data} - {next}";
        }
    }
}
