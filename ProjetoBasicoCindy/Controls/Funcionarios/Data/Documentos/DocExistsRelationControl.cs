using System;

namespace ProjetoBasicoCindy
{
    internal class DocExistsRelationControl
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
