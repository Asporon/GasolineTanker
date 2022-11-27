using System.Runtime.Serialization;

namespace GasolineTanker
{
    [Serializable]
    internal class TruckNotFoundException : ApplicationException
    {
        public TruckNotFoundException(int i) : base($"Не найден объект по позиции {i}") { }
        public TruckNotFoundException() : base() { }
        public TruckNotFoundException(string message) : base(message) { }
        public TruckNotFoundException(string message, Exception exception) : base(message, exception) { }
        protected TruckNotFoundException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
    }
}
