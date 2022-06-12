using System.Threading.Tasks;

namespace AwesomeGym.Core.Interfaces.Servicos
{
    public interface IFileStorageService
    {
        Task AdicionarArquivo(byte[] content, string fileName);
    }
}
