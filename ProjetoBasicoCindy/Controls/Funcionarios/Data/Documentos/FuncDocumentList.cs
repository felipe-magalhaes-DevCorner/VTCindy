using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBasicoCindy
{
    internal class FuncDocumentList : List<DocExistsRelationControl>
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
        public void RemoveDoCbyId(int idList)
        {
            ListOfDocs.RemoveAt(idList);
        }
        public void SetList (List<DocExistsRelationControl> listDocExistsRelationControls)
        {
            ListOfDocs = listDocExistsRelationControls;
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
        public FuncDocumentList MakeListToCollection()
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
