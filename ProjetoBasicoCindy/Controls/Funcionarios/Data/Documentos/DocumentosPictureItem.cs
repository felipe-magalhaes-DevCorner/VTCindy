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
        public float _matricula { get; set; }
        List<Image> _documentos = new List<Image>();
        
        public int _paginas { get; set; }

        public DocumentosPictureItem(float matricula, List<Image> documentos, int paginas)
        {
            _matricula = matricula;
            _documentos = documentos;
            _paginas = paginas;
        }
    }
}
