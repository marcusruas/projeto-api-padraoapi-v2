﻿using Comunicacao.ConexaoBanco.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Comunicacao.ConexaoBanco.Implementacao
{
    public class ConexaoBanco : IConexaoBanco
    {
        public string ObterConsultaArquivoSQL(string nomeArquivo)
        {
            return LeitorArquivos.LerArquivoSQL(nomeArquivo);
        }

        public IDbConnection CriarNovaConexao(Banco banco)
        {
            return new SqlConnection(LeitorArquivos.ObterConnectionString(banco));
        }

        public (string, IDbConnection) ObterComandoSQLParaBanco(string nomeArquivo, Banco banco)
        {
            return (
                ObterConsultaArquivoSQL(nomeArquivo),
                CriarNovaConexao(banco)
            );
        }

        private string ObterConnectionString(Banco banco)
        {
            return LeitorArquivos.ObterConnectionString(banco);
        }
    }
}
