using System.Threading.Tasks;

namespace ef_minimal_example.console;

public interface ICommand
{
    Task Execute();
}