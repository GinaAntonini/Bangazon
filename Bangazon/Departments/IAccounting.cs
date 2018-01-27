namespace Bangazon.Departments
{
    internal interface IAccounting
    {
        bool BusySeason { get; set; }
        string OpenPosition { get; set; }

        void ExtraWork(string openPosition);
        string ToString();
    }
}