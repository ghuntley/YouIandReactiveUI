namespace Book.ViewModels.Samples.Chapter10.Sample03
{
    using ReactiveUI;

    public sealed class DinosaurViewModel : ReactiveObject
    {
        private readonly string name;

        public DinosaurViewModel(
            string name)
        {
            this.name = name;
        }

        public string Name => this.name;
    }
}