using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    class DocExistsRelationControl
    {
        private DocumentosPictureCollection DocumentosExistsControl { get; set; }
        private bool Exists { get; set; }

        public DocExistsRelationControl(DocumentosPictureCollection documentosExistsControl = null, bool exists = false)
        {
            DocumentosExistsControl = documentosExistsControl ?? throw new ArgumentNullException(nameof(documentosExistsControl));
            Exists = exists;
        }


    }
}
