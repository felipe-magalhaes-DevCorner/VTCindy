using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBasicoCindy.Exames
{
    public partial class Exame : UserControl
    {
        public Exame(bool child, string descricao)
        {
            InitializeComponent();
            if (child)
            {
                panelChild.Visible = true;
            }
            else
            {
                panelChild.Visible = false;
            }
            lbDescricao.Font = new Font("Times New Roman", 10.0f, FontStyle.Bold);
            picOpen.Image = Image.FromFile(@"Imagens\move-to-next (1).png");
            //picOpen.Tag = "Arrow";
            picOpen.MaximumSize = new Size(picOpen.Size.Width, 26);
            picOpen.SizeMode = PictureBoxSizeMode.CenterImage;
            lbDescricao.Text = descricao;
            lbDescricao.TextAlign = ContentAlignment.MiddleLeft;


        }

        private void PicOpen_Click(object sender, EventArgs e)
        {
            int heightaux = 0;
            PictureBox parent = (PictureBox)sender;
            //Panel panel = (Panel)parent.Parent;
            FlowLayoutPanel painel = (FlowLayoutPanel)parent.Parent.Parent.Parent;
            painel.AutoSize = false;
            Image testeimage = picOpen.Image;
            if (picOpen.Tag.ToString() == "arrowClosed")
            {
                testeimage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                picOpen.Image = testeimage;
                picOpen.Tag = "arrowOpen";
                if (painel.Name == "ExpandTipo")
                {
                    //panel "EXAME"

                    foreach (Control item in painel.Parent.Controls)
                    {
                        try
                        {
                            var testeexame = (Exame)item;
                            if (testeexame.picOpen.Tag.ToString() == "arrowOpen")
                            {
                                heightaux += testeexame.Parent.Parent.Size.Height;
                            }

                        }
                        catch
                        {

                        }


                    }
                    painel.MaximumSize = new Size(painel.Width, painel.Controls.Count * 36 + heightaux);
                    painel.Size = new Size(painel.Width, painel.Controls.Count * 36 + heightaux);



                }
                else if (painel.Name == "ExameExpandChild1")
                {
                    int heightAux = 0;
                    //panwl HCV


                    painel.MaximumSize = new Size(painel.Width, painel.Controls.Count * 36);
                    painel.Size = new Size(painel.Width, painel.Controls.Count * 36);
                    painel.Parent.MaximumSize = new Size(painel.Parent.Width, painel.Parent.Size.Height + painel.Size.Height - 36);
                    painel.Parent.Size = new Size(painel.Parent.Width, painel.Parent.Size.Height + painel.Size.Height - 36);
                }
            }
            else if (picOpen.Tag.ToString() == "arrowOpen")
            {
                testeimage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                picOpen.Image = testeimage;
                picOpen.Tag = "arrowClosed";
                if (painel.Name == "ExpandTipo")
                {
                    //panel "EXAME"

                    for (int i = 0; i < painel.Controls.Count; i++)
                    {
                        var closeopen = (PictureBox)HelperClass.FindTag(painel.Controls, "arrowOpen");
                        if (closeopen != null)
                        {
                            var examViewer = (Exame)closeopen.Parent.Parent;
                            examViewer.PicOpen_Click(examViewer.picOpen, new EventArgs());
                        }
                        

                    }
                    painel.MaximumSize = new Size(painel.Width, 36);
                    painel.Size = new Size(painel.Width, 36);


                }
                else if (painel.Name == "ExameExpandChild1")
                {
                    int heightaux2 = 0;
                    painel.MaximumSize = new Size(painel.Width, 34);
                    painel.Size = new Size(painel.Width, 34);
                    foreach (Control item in painel.Parent.Controls)
                    {
                        heightaux2 += item.Size.Height + 4;
                    }
                    painel.Parent.MaximumSize = new Size(painel.Parent.Width, heightaux2);
                    painel.Parent.Size = new Size(painel.Parent.Width, heightaux2);

                    //painel.Parent.MaximumSize = new Size(painel.Parent.Width, painel.Parent.Controls.Count * 36);
                    //painel.Parent.Size = new Size(painel.Parent.Width, painel.Parent.Controls.Count * 36);

                }










                //picOpen.Image = testeimage;
                //picOpen.Tag = "arrowClosed";
                //FlowLayoutPanel testeAux = painel;
                //FlowLayoutPanel teste = null;
                //if (testeAux.Controls.Count > 1)
                //{
                //    teste = (FlowLayoutPanel)painel.Controls[1];
                //    if (painel.Name == "ExpandGeral")
                //    {
                //        painel.AutoSize = true;
                //        painel.AutoSizeMode = AutoSizeMode.GrowOnly;
                //        teste.AutoSize = true;
                //        teste.AutoSizeMode = AutoSizeMode.GrowOnly;
                //        //teste.MaximumSize = new Size(teste.Size.Width, 32);
                //        //teste.Size = new Size(teste.Size.Width, 32);

                //        //painel.MaximumSize = new Size(painel.Size.Width, 35);
                //        //painel.Size = new Size(painel.Size.Width, 35);

                //    }
                //    else if (painel.Name == "ExpandTipo")
                //    {
                //        FlowLayoutPanel teste2 = (FlowLayoutPanel)painel.Parent;
                //        //teste2.MaximumSize = new Size(teste2.Size.Width, painel.Controls.Count * 32 + 30);
                //        //teste2.Size = new Size(teste2.Size.Width, painel.Controls.Count * 32 + 30);
                //        painel.AutoSize = true;
                //        painel.AutoSizeMode = AutoSizeMode.GrowOnly;
                //        teste2.AutoSize = true;
                //        teste2.AutoSizeMode = AutoSizeMode.GrowOnly;

                //        //FlowLayoutPanel teste33 = (FlowLayoutPanel)parent.Parent.Parent.Parent;
                //        //FlowLayoutPanel teste = (FlowLayoutPanel)painel.Controls[1];
                //        //teste.MaximumSize = new Size(teste.Size.Width, 26);
                //        //teste.Size = new Size(teste.Size.Width, 26);
                //    }
                //}


            }










            var hashoriginal = picOpen.Image;
            //picOpen.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);






        }

        private void lbDescricao_Click(object sender, EventArgs e)
        {

        }
    }
}
