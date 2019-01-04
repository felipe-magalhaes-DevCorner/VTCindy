using System.Drawing;

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

        private Image Documentos { get; set; }
        public int Tipo { get; set; }

        public int Pagina { get; set; }

        public DocumentosPictureItem(Image documentos,int  tipo, int pagina)
        {
            
            Documentos = documentos;
            Tipo = tipo;
            Pagina = pagina;
        }
    }
}
