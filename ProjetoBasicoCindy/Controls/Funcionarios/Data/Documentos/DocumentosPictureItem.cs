using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBasicoCindy
{
    public class DocumentosPictureItem
    {

        /// <summary>
        /// list of documents, 
        /// type of document _nomeDoc
        /// list of images, front and backpage
        /// bool variable to determine page number
        /// 
        /// 
        /// </summary>

        Image _documentos { get; set; }
        public int _tipo { get; set; }

        public int _pagina { get; set; }

        public DocumentosPictureItem(Image documentos,int  tipo, int pagina)
        {
            
            _documentos = documentos;
            _tipo = tipo;
            _pagina = pagina;
        }
    }
}
