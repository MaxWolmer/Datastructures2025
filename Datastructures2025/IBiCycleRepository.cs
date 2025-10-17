namespace Datastructures2025
{
    public interface IBiCycleRepository
    {
        int Count { get; }

        void Add(BiCycle bicycle);
        void Remove(string sno);
        BiCycle? Search(string sno);
        void Update(string sno, BiCycle updatedBicycle);
        void PrintAll();
    }
}