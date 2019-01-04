using System.Collections.Generic;
using System.Linq;

namespace ProjetoBasicoCindy
{
    public class DocumentosPictureCollection : List<DocumentosPictureItem>
    {
        public List<DocumentosPictureItem> DocumentoCollection { get; set; }


        public void SetList(List<DocumentosPictureItem> list)
        {
            DocumentoCollection = list;
        }
        public int COuntList()
        {
            return DocumentoCollection.Count();
        }
        public void AddDoc(DocumentosPictureItem doc)
        {

            DocumentoCollection.Add(doc);
        }
        public void RemoveDoc(DocumentosPictureItem doc)
        {
            DocumentoCollection.Remove(doc);
        }
        public void RemoveDoCbyId(int idList)
        {
            DocumentoCollection.RemoveAt(idList);
        }
        public List<DocumentosPictureItem> GetFuncionarioOnibusCollection()
        {
            List<DocumentosPictureItem> list = DocumentoCollection;
            return list;
        }
        public DocumentosPictureCollection MakeListToCollection()
        {
            DocumentosPictureCollection collection = new DocumentosPictureCollection();
            foreach (DocumentosPictureItem onibus in DocumentoCollection)
            {
                collection.Add(onibus);

            }
            return collection;

        }


    }
}
