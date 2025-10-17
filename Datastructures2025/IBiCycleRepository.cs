namespace Datastructures2025
{
    public interface IBiCycleRepository
    {
        int Count { get; }

        void Add(BiCycle bicycle);
        void Remove(string sno);
        BiCycle? Search(string sno);
<<<<<<< HEAD
        void Update(string sno, BiCycle updatedBicycle);
=======
        void Update(BiCycle updatedBicycle);

>>>>>>> 6a8d0e3f42e4741c8ca6ddb66c3fdc3450579d71
        void PrintAll();
    }
}