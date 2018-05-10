using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    public class DocumentosPictureCollection : List<DocumentosPictureItem>
    {
        public List<DocumentosPictureItem> DocumentoCollection { get; set; }


        public void SetList(List<DocumentosPictureItem> _list)
        {
            DocumentoCollection = _list;
        }
        public int COuntList()
        {
            return DocumentoCollection.Count();
        }
        public void AddDOC(DocumentosPictureItem _doc)
        {

            DocumentoCollection.Add(_doc);
        }
        public void RemoveDOC(DocumentosPictureItem _doc)
        {
            DocumentoCollection.Remove(_doc);
        }
        public void RemoveDOCbyID(int _idList)
        {
            DocumentoCollection.RemoveAt(_idList);
        }
        public List<DocumentosPictureItem> GetFuncionarioOnibusCollection()
        {
            List<DocumentosPictureItem> list = DocumentoCollection;
            return list;
        }
        public DocumentosPictureCollection MakeListTOCollection()
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
