namespace Schukin.DataExchangeTC
{
    public interface IOutput
    {
        void Write(string line);
        void Write(string[] lines);
    }
}
