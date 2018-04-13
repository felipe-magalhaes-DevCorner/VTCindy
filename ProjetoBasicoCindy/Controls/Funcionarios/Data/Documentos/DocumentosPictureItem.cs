using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string _nomeDoc { get; set; }
        public List<Bitmap> _documentos { get; set; }
        public int _paginas { get; set; }

    }
}
