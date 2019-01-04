namespace ProjetoBasicoCindy
{
    public class FuncionarioItemPreview
    {
        public int Idfuncionario { get; set; }
        public string Name { get; set; }
        public FuncionarioItemPreview(int idfuncionario = 1, string name = null)
        {
            Idfuncionario = idfuncionario;
            Name = name;
        }


        public void GetPreview(FuncionarioItem funcionario)
        {
            string[] previewArray = { funcionario.IdFuncionario.ToString(), funcionario.Name };
        }

    }



}
