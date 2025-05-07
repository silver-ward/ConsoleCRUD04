using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Entities
{
    /// <summary>
    /// Classe de modelo de dados para entidade Cliente
    /// </summary>
    public class Cliente
    {
        #region Propriedades

        public Guid? Id { get; set; }

        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        public string? Nome { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email do cliente.")]
        public string? Email { get; set; }

        public DateTime? DataHoraCriacao { get; set; }

        public DateTime? DataHoraAlteracao { get; set; }

        public bool? Ativo {  get; set; }

        #endregion
    }
}
