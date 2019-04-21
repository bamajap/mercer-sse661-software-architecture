namespace PiperFiltersExample
{
    public abstract class AutomobileFactory
    {
        public Automobile Create(string vin)
        {
            var automobile = new Automobile(vin);
            Build(ref automobile);
            return automobile;
        }

        protected abstract void Build(ref Automobile a);

        protected static void Success(Automobile a)
        {
            a.Metadata.AppendLine("SUCCESS!");
        }
    }
}