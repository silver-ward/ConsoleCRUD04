using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;

namespace ProjetoAula04.Repositories
{
    /// <summary>
    /// Implementação do repositório de clientes para o banco de dados
    /// </summary>
    public class ClienteRepository : IClienteRepository
    {
        #region Atributos

        private readonly string _connectionString = @"Data Source=localhost,1434;Initial Catalog=master;User ID=sa;Password=Coti@2025;Encrypt=False";

        #endregion

        public void Delete(Guid? id)
        {
            var query = @"
            UPDATE CLIENTE
            SET
                ATIVO = 0
            WHERE
                ID = @ID
            ";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, new
                {
                    @ID = id
                });
            }
        }

        public Cliente? Get(Guid? id)
        {
            var query = @"
                SELECT
                    ID, NOME, EMAIL, DATAHORACRIACAO, DATAHORAALTERACAO, ATIVO
                FROM CLIENTE
                WHERE ID = @ID AND ATIVO = 1
            ";

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Cliente?>(query, new { @ID = id}).FirstOrDefault();
            }
        }

        public List<Cliente>? GetAll()
        {
            var query = @"
                SELECT
                    ID, NOME, EMAIL, DATAHORACRIACAO, DATAHORAALTERACAO, ATIVO
                FROM CLIENTE
                WHERE ATIVO = 1
                ORDER BY NOME
            ";

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Cliente>(query).ToList();
            }
        }

        public void Insert(Cliente cliente)
        {

            var query = @"
                INSERT INTO CLIENTE(ID, NOME, EMAIL, DATAHORACRIACAO, DATAHORAALTERACAO, ATIVO)
                VALUES(@ID, @NOME, @EMAIL, @DATAHORACRIACAO, @DATAHORAALTERACAO, @ATIVO)
            ";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, new
                {
                    @ID = cliente.Id,
                    @NOME = cliente.Nome,
                    @EMAIL = cliente.Email,
                    @DATAHORACRIACAO = cliente.DataHoraCriacao,
                    @DATAHORAALTERACAO = cliente.DataHoraAlteracao,
                    @ATIVO = cliente.Ativo
                });
            }
        }

        public void Update(Cliente cliente)
        {
            var query = @"
            UPDATE CLIENTE
            SET
                NOME = @NOME,
                EMAIL = @EMAIL,
                DATAHORAALTERACAO = @DATAHORAALTERACAO
            WHERE
                ID = @ID
            ";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, new
                {
                    @ID = cliente.Id,
                    @NOME = cliente.Nome,
                    @EMAIL = cliente.Email,
                    @DATAHORAALTERACAO = cliente.DataHoraAlteracao,
                });
            }
        }
    }
}
