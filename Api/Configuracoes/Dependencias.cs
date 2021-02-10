using Microsoft.Extensions.DependencyInjection;

namespace Api.Configuracoes
{
    public static class Dependencias
    {
        public static void ConfigurarInjecoesDependencia(IServiceCollection servicos)
        {
            ConfigurarCamadaRepositorios(servicos);
            ConfigurarCamadaServico(servicos);
        }

        private static void ConfigurarCamadaRepositorios(IServiceCollection servicos)
        {
            
        }

        private static void ConfigurarCamadaServico(IServiceCollection servicos)
        {
            
        }
    }
}
