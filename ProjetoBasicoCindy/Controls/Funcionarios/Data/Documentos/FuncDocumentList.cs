using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBasicoCindy
{
    class FuncDocumentList : List<DocExistsRelationControl>
    {
        private List<DocExistsRelationControl> ListOfDocs { get; set; }

        public FuncDocumentList(List<DocExistsRelationControl> listOfDocs = null)
        {
            ListOfDocs = listOfDocs ?? throw new ArgumentNullException(nameof(listOfDocs));
        }
        public int COuntList()
        {
            return ListOfDocs.Count();
        }
        public void RemoveDOCbyID(int _idList)
        {
            ListOfDocs.RemoveAt(_idList);
        }
        public void SetList (List<DocExistsRelationControl> _List_docExistsRelationControls)
        {
            ListOfDocs = _List_docExistsRelationControls;
        }
        public void SetList(DocExistsRelationControl docExistsRelationControls)
        {
            ListOfDocs.Add(docExistsRelationControls);
        }
        public List<DocExistsRelationControl> GetListDocs()
        {
            List<DocExistsRelationControl> list = ListOfDocs;
            return list;
            
        }
        public FuncDocumentList Get_FuncDocumentList()
        {
            return this;
        }
        public FuncDocumentList MakeListTOCollection()
        {
            FuncDocumentList collection = new FuncDocumentList();
            foreach (DocExistsRelationControl document in ListOfDocs)
            {
                collection.Add(document);

            }
            return collection;

        }








    }
}
