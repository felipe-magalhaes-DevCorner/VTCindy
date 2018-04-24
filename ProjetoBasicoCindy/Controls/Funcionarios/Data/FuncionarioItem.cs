using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    /// <summary>
    /// Gather information about funcionarios
    /// </summary>
    public class FuncionarioItem
    {
        public FuncionarioItem(int idFuncionario, Image funcPic, string name, string cpf, string identidade, string sexo, DateTime dataNascimento, string rua, string numero, string complemento, string bairro, string observacao, string cidade, string estado, string cep, string telefone, bool inativo, DocumentosPictureCollection documentos = null, OnibusItemCollection onibus = null)
        {
            _idFuncionario = idFuncionario;
            _funcPic = funcPic;
            _name = name;
            _cpf = cpf;
            _identidade = identidade;
            _sexo = sexo;
            _dataNascimento = dataNascimento;
            _rua = rua;
            _numero = numero;
            _complemento = complemento;
            _bairro = bairro;
            _observacao = observacao;
            _cidade = cidade;
            _estado = estado;
            _cep = cep;
            _telefone = telefone;
            _inativo = inativo;
            _documentos = documentos;
            _onibus = onibus;
            


        }


        public int _idFuncionario { get; set; }
        public Image _funcPic { get; set; }
        public string _name { get; set; }
        public string _cpf { get; set; }
        public string _identidade { get; set; }
        public string _sexo { get; set; }
        public DateTime _dataNascimento { get; set; }
        public string _rua { get; set; }
        public string _numero { get; set; }
        public string _complemento { get; set; }
        public string _bairro { get; set; }
        public string _observacao { get; set; }
        public string _cidade { get; set; }
        public string _estado { get; set; }
        public string _cep { get; set; }
        public DocumentosPictureCollection _documentos { get; set; }
        public string _telefone { get; set; }
        public OnibusItemCollection _onibus { get; set; }
        public bool _inativo { get; set; }

    }   





}

