namespace Neural_Network.Core
{
    public class ShapeException : System.Exception
    {
        public ShapeException() : base("The size of the matrix or vector is incorrect.") { }
        public ShapeException(string message) : base(message) { }
        public ShapeException(string message, System.Exception inner) : base(message, inner) { }
        protected ShapeException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}