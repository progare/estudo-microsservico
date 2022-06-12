using AwesomeGym.Core.Interfaces.Servicos;
using System;
using System.Threading.Tasks;

namespace AwesomeGym.Infrastructure.Servicos
{
    public class AzureFileStorageService : IFileStorageService
    {
        public Task AdicionarArquivo(byte[] content, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
