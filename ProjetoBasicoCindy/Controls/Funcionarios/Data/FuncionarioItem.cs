using ProjetoBasicoCindy.Exames.Data;
using ProjetoBasicoCindy.Ferias;
using ProjetoBasicoCindy.Vacina;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProjetoBasicoCindy
{
    /// <summary>
    /// Gather information about funcionarios
    /// </summary>
    public class FuncionarioItem
    {
        public FuncionarioItem(int idFuncionario, Image funcPic, string name, string cpf, string identidade, string sexo, DateTime dataNascimento, string rua, string numero, string complemento, string bairro, string observacao, string cidade, string estado, string cep, string telefone, bool inativo, DateTime adimissao, DateTime inativacao,DocumentosPictureCollection documentos = null, OnibusItemCollection onibus = null, FuncionarioVaccinaColletion vacinas = null, FeriasColletionItem ferias = null, ExameItemColletion exames = null )
        {
            IdFuncionario = idFuncionario;
            FuncPic = funcPic;
            Name = name;
            Cpf = cpf;
            Identidade = identidade;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Observacao = observacao;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Telefone = telefone;
            Inativo = inativo;
            Adimissao = adimissao;
            Inativacao = inativacao;
            Documentos = documentos;
            Onibus = onibus;
            Vacinas = vacinas;
            Ferias = ferias;
            Exames = exames;




        }

        private sealed class FuncionarioItemEqualityComparer : IEqualityComparer<FuncionarioItem>
        {
            public bool Equals(FuncionarioItem x, FuncionarioItem y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.IdFuncionario == y.IdFuncionario && Equals(x.FuncPic, y.FuncPic) && string.Equals(x.Name, y.Name) && string.Equals(x.Cpf, y.Cpf) && string.Equals(x.Identidade, y.Identidade) && string.Equals(x.Sexo, y.Sexo) && x.DataNascimento.Equals(y.DataNascimento) && string.Equals(x.Rua, y.Rua) && string.Equals(x.Numero, y.Numero) && string.Equals(x.Complemento, y.Complemento) && string.Equals(x.Bairro, y.Bairro) && string.Equals(x.Observacao, y.Observacao) && string.Equals(x.Cidade, y.Cidade) && string.Equals(x.Estado, y.Estado) && string.Equals(x.Cep, y.Cep) && x.Adimissao.Equals(y.Adimissao) && x.Inativacao.Equals(y.Inativacao) && Equals(x.Documentos, y.Documentos) && string.Equals(x.Telefone, y.Telefone) && Equals(x.Onibus, y.Onibus) && Equals(x.Vacinas, y.Vacinas) && x.Inativo == y.Inativo && Equals(x.Ferias, y.Ferias) && Equals(x.Exames, y.Exames);
            }

            public int GetHashCode(FuncionarioItem obj)
            {
                unchecked
                {
                    var hashCode = obj.IdFuncionario;
                    hashCode = (hashCode * 397) ^ (obj.FuncPic != null ? obj.FuncPic.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Name != null ? obj.Name.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Cpf != null ? obj.Cpf.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Identidade != null ? obj.Identidade.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Sexo != null ? obj.Sexo.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ obj.DataNascimento.GetHashCode();
                    hashCode = (hashCode * 397) ^ (obj.Rua != null ? obj.Rua.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Numero != null ? obj.Numero.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Complemento != null ? obj.Complemento.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Bairro != null ? obj.Bairro.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Observacao != null ? obj.Observacao.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Cidade != null ? obj.Cidade.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Estado != null ? obj.Estado.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Cep != null ? obj.Cep.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ obj.Adimissao.GetHashCode();
                    hashCode = (hashCode * 397) ^ obj.Inativacao.GetHashCode();
                    hashCode = (hashCode * 397) ^ (obj.Documentos != null ? obj.Documentos.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Telefone != null ? obj.Telefone.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Onibus != null ? obj.Onibus.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Vacinas != null ? obj.Vacinas.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ obj.Inativo.GetHashCode();
                    hashCode = (hashCode * 397) ^ (obj.Ferias != null ? obj.Ferias.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (obj.Exames != null ? obj.Exames.GetHashCode() : 0);
                    return hashCode;
                }
            }
        }

        public static IEqualityComparer<FuncionarioItem> FuncionarioItemComparer { get; } = new FuncionarioItemEqualityComparer();


        public int IdFuncionario { get; set; }
        public Image FuncPic { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Identidade { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Observacao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public DateTime Adimissao { get; set; }
        public DateTime Inativacao { get; set; } 
        public DocumentosPictureCollection Documentos { get; set; }
        public string Telefone { get; set; }
        public OnibusItemCollection Onibus { get; set; }
        public FuncionarioVaccinaColletion Vacinas { get; set; }
        public bool Inativo { get; set; }
        public FeriasColletionItem Ferias { get; set; }

        public ExameItemColletion Exames { get; set; }


    }   





}

