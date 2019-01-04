using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBasicoCindy.Exames
{
    internal class ExamViewHandler
    {


        #region Variables

        private PictureBox _auxPic;
        private Control _auxRowControl;
        private int _tick = 26;
        private int _auxMaxHeightControls = 0;
        public Panel VacinaPanel { get; set; }
        #endregion

        #region Construtor
        public ExamViewHandler(Panel vacinaPanel)
        {
            VacinaPanel = vacinaPanel;
            VacinaPanel.Controls.Clear();
            var objFunc = new FuncionarioItemEdit();
            //BuildList(objFunc.GetFuncionarioEdit()._exames);
            BuildExamFunc(objFunc.GetFuncionarioEdit().Exames);

        }
        #endregion

        #region BuildTables
        /// <summary>
        /// trying again using desenho
        /// </summary>
        /// <param name="exames"></param>


        private void BuildExamFunc(Data.ExameItemColletion exames)
        {
            var margim = VacinaPanel.Margin;
            margim.All = 0;


            //foreach list inside exameitemcolletion from funcionario
            foreach (Data.ExamList listaTipo in exames.Exames)
            {
                //CREATES FIRST PANEL, FOR NAME "EXAME" FOR EXAMPLE
                FlowLayoutPanel expand = new FlowLayoutPanel
                {
                    Name = $"ExpandTipo",
                    Tag = listaTipo.Tipagem,
                    Dock = DockStyle.Top,
                    Margin = margim,
                    FlowDirection = FlowDirection.TopDown,
                    MaximumSize = new Size(VacinaPanel.Width, 34),
                    Size = new Size(VacinaPanel.Width, 34),
                    //BackColor = Color.Red
                    
                };
                //add text for desciption of exam tipagem
                var objTipagem = new Exame(false, listaTipo.Tipagem);
                expand.Controls.Add(objTipagem);

                foreach (Data.Examitem listaExame in listaTipo.ExameColletion)
                {
                    //CREATES SECOND PANEL FOR EXAME EXPAND
                    FlowLayoutPanel exameExpandChild1 = new FlowLayoutPanel
                    {
                        Name = $"ExameExpandChild1",
                        Tag = listaExame.Nome,
                        Dock = DockStyle.Top,
                        Margin = margim,
                        FlowDirection = FlowDirection.TopDown,
                        MaximumSize = new Size(expand.Width, 34),
                        Size = new Size(expand.Width, 34),

                        //BackColor = Color.Yellow
                    };
                    //if (testeBool)
                    //{
                    //    ExameExpandChild1.BackColor = Color.Blue;
                    //    testeBool = false;

                    //}
                    //else
                    //{
                    //    testeBool = true;
                    //}
                    var objListaExame = new Exame(true, listaExame.Nome);
                    exameExpandChild1.Controls.Add(objListaExame);

                    for (int i = 0; i < listaExame.DataExame.Count; i++)
                    {
                        var objExameDatas = new Exame(true, listaExame.DataExame[i] + listaExame.Protocolo[i]);
                        objExameDatas.picOpen.Visible = false;
                        objExameDatas.Size = new Size(VacinaPanel.Width, objExameDatas.Size.Height);
                        var objCheck = new ExameCheckOk();

                        PictureBox examStatus = new PictureBox();
                        examStatus.MaximumSize = new Size(30, 30);
                        examStatus.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (listaExame.DataExame.Count - 1 == i)
                        {
                            examStatus.Image = objCheck.ReturnImageExamFunc(listaExame);
                        }
                        else
                        {
                            examStatus.Image = Image.FromFile(@"Imagens\Checked.png");
                        }
                        objExameDatas.panelExansOK.Dock = DockStyle.Right;
                        objExameDatas.panelExansOK.Controls.Add(examStatus);


                        objExameDatas.panelChild.Size = new Size(60, 30);
                        exameExpandChild1.Controls.Add(objExameDatas);
                    }
                    expand.Controls.Add(exameExpandChild1);
                }
                VacinaPanel.Controls.Add(expand);
            }

        }


        #endregion

        #region Abandoned
        private void BuildExamList(List<Data.ExamList> exames, string nomeexame, int m)
        {
            FlowLayoutPanel expand = new FlowLayoutPanel
            {
                Name = $"ExpandGeral",
                Tag = $"ExpandGeral",
                Dock = DockStyle.Top
            };
            Color[] cores = { Color.Red, Color.Blue, Color.LightBlue };
            var margim = expand.Margin;
            margim.All = 0;
            expand.FlowDirection = FlowDirection.TopDown;
            expand.Margin = margim;
            expand.Size = new Size(VacinaPanel.Size.Width, 200);
            expand.BackColor = cores[m];

            //add exame tipo
            //EXAME EXTRAS ASO
            //


            Exame exame = new Exame(false, nomeexame)
            {
                Name = "Tipo"
            };
            Exame objTypeExam = exame;
            expand.Controls.Add(objTypeExam);
            //ExpandTipo.Controls.Add(objExames);

            Color[] colors = { Color.Yellow, Color.Blue, Color.Purple };



            for (int i = 0; i < exames.Count; i++)
            {
                //add nomes dos exames
                //hemograma completo
                FlowLayoutPanel expandTipo = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Name = $"ExpandTipo",
                    Tag = $"ExpandTipo",
                    //AutoSize = true,
                    Dock = DockStyle.Top
                };
                margim.All = 0;
                expandTipo.Margin = margim;
                expandTipo.Size = new Size(VacinaPanel.Size.Width, 31);
                expandTipo.BackColor = colors[i];
                var objExames = new Exame(true, exames[i].ExameColletion[i].Nome.ToString());
                expandTipo.Controls.Add(objExames);



                FlowLayoutPanel expandData = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    Name = $"ExpandExame",
                    Tag = $"ExpandExame",
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowOnly,

                    BackColor = Color.Brown,
                    Margin = margim
                };



                for (int j = 0; j < exames[i].ExameColletion[i].DataExame.Count; j++)
                {
                    string dataProtocolo = string.Format($"Data: {exames[i].ExameColletion[i].DataExame[j].ToString("dd/MM/yyyy")} Protocolo nº {exames[i].ExameColletion[i].Protocolo[j]}");
                    var objDataProtocolo = new Exame(true, dataProtocolo);
                    objDataProtocolo.panelChild.Size = new Size(52, 30);
                    objDataProtocolo.picOpen.Image = Image.FromFile(@"Imagens\checked.png");
                    objDataProtocolo.picOpen.Tag = "checked";
                    expandData.Controls.Add(objDataProtocolo);

                }
                Control.ControlCollection teste = expandData.Controls;
                int size = 13;
                foreach (Control item in teste)
                {
                    size += item.Size.Height;
                }
                expandData.Size = new Size(VacinaPanel.Size.Width, size);
                expand.Controls.Add(expandTipo);
                expand.Controls.Add(expandData);
                expand.Size = new Size(expand.Size.Width, 31);
                expand.MaximumSize = new Size(expand.Size.Width, 31);



            }
            expand.Size = new Size(expand.Size.Width, 30);
            expand.MaximumSize = new Size(expand.Size.Width, 30);
            //ADD MAIN EXPAND PANEL TO PREVIOUSLY OWNED PANEL IN TALBCONTROL FUNCIONARIOVIEW
            VacinaPanel.Controls.Add(expand);

        }

        private void BuildExamsFuncionario(Data.ExameItemColletion exames)
        {
            //BuildRowColletion(_exames.Exames, "Exames");
            //expanded panel
            FlowLayoutPanel expandPanel = new FlowLayoutPanel
            {
                Name = $"ExpandExame",
                Tag = $"ExpandExame",
                Dock = DockStyle.Top,
                Size = new Size(VacinaPanel.Size.Width, 31),
                BackColor = Color.Red
            };


            foreach (Data.ExamList exameList in exames.Exames)
            {
                var objTypeExam = new Exame(false, exameList.Tipagem)
                {
                    Name = "tipo"
                };
                expandPanel.Controls.Add(objTypeExam);

                foreach (Data.Examitem exame in exameList.ExameColletion)
                {
                    FlowLayoutPanel expandPanelChildTipo = new FlowLayoutPanel
                    {
                        Name = $"nomeExame",
                        Tag = $"nomeExame",
                        Dock = DockStyle.Top,
                        Size = new Size(VacinaPanel.Size.Width, 30),
                        BackColor = Color.Yellow
                    };
                    var objExameItem = new Exame(true, exame.Nome);
                    expandPanelChildTipo.Controls.Add(objExameItem);
                    FlowLayoutPanel expandPanelChildChildExame = new FlowLayoutPanel
                    {
                        Name = $"ChildExam",
                        Tag = $"ChildExam",
                        Dock = DockStyle.Top,
                        Size = new Size(VacinaPanel.Size.Width, 30),
                        BackColor = Color.Yellow
                    };
                    //ExpandPanelChildChildExame.Name = "ChildExam";

                    for (int i = 0; i < exame.DataExame.Count; i++)
                    {

                        var objDescricaoExame = new Exame(true, string.Format($"Data: {exame.DataExame[i]} Protocolo {exame.Protocolo[i]}"));

                        expandPanelChildChildExame.Controls.Add(objExameItem);
                        expandPanelChildTipo.Controls.Add(expandPanelChildChildExame);

                    }
                    expandPanel.Controls.Add(expandPanelChildTipo);
                    expandPanel.Size = new Size(expandPanel.Size.Width, expandPanel.Controls.Count * 34);
                    expandPanel.MaximumSize = new Size(expandPanel.Size.Width, expandPanel.Controls.Count * 34);
                }


                VacinaPanel.Controls.Add(expandPanel);
            }
        }
        private void BuildRowColletion(List<Data.ExamList> listToadd, string name)
        {
            //mainpanel
            VacinaPanel.AutoScroll = true;
            var margin = VacinaPanel.Margin;
            VacinaPanel.Dock = DockStyle.Fill;
            margin.All = 0;
            VacinaPanel.BackColor = Color.Red;
            VacinaPanel.Margin = margin;
            //expanded panel
            FlowLayoutPanel expandPanel = new FlowLayoutPanel
            {
                Name = $"Expand{name}",
                Tag = $"Expand{name}",
                Dock = DockStyle.Top
            };
            expandPanel.Size = new Size(expandPanel.Size.Width, 30);

            //rowpanel for exam/extra/aso
            Panel row = new Panel
            {
                Margin = margin,
                Name = name,
                Tag = name,
                Dock = DockStyle.Top,
                Anchor = AnchorStyles.Left,
                //Row.MaximumSize = new Size(MainPanel.Width, 26);
                Size = new Size(VacinaPanel.Width, 30),
                BackColor = Color.White
            };


            Label description = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill
            };
            description.MaximumSize = new Size(description.Size.Width, 30);
            description.Font = new Font("Times New Roman", 10.0f, FontStyle.Bold);
            description.Text = name;
            description.TextAlign = ContentAlignment.MiddleLeft;
            row.Controls.Add(description);

            //panel for open tree
            PictureBox openPic = new PictureBox
            {
                Dock = DockStyle.Left,
                Name = "openPic",
                Size = new Size(26, 26),

                Image = Image.FromFile(@"Imagens\move-to-next (1).png")
            };
            openPic.MaximumSize = new Size(openPic.Size.Width, 26);
            openPic.SizeMode = PictureBoxSizeMode.CenterImage;
            _auxPic = openPic;
            openPic.MouseClick += new MouseEventHandler(OpenPic_MouseClick);
            row.Controls.Add(openPic);
            expandPanel.Controls.Add(row);
            expandPanel.BackColor = Color.Black;


            foreach (Data.ExamList exameList in listToadd)
            {
                foreach (Data.Examitem exame in exameList.ExameColletion)
                {
                    BuildExamPanel(exame, expandPanel);
                }




            }
            VacinaPanel.Controls.Add(expandPanel);

        }
        private void BuildExamPanel(Data.Examitem examItem, FlowLayoutPanel expandPanel)
        {
            //rowpanel

            var margin = VacinaPanel.Margin;
            VacinaPanel.Dock = DockStyle.Fill;
            margin.All = 0;
            Panel row = new Panel
            {
                Margin = margin,
                Name = examItem.Nome,
                Tag = examItem.Nome,
                Dock = DockStyle.Top,
                Anchor = AnchorStyles.Left,
                //Row.MaximumSize = new Size(MainPanel.Width, 26);
                Size = new Size(VacinaPanel.Width, 26),
                //BackColor = Color.White
            };
            Label description = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill
            };
            description.MaximumSize = new Size(description.Size.Width, 30);
            description.Font = new Font("Times New Roman", 10.0f, FontStyle.Bold);
            description.Text = examItem.Nome;
            description.TextAlign = ContentAlignment.MiddleLeft;
            row.Controls.Add(description);

            //panel for open tree
            Panel leftseparator = new Panel
            {
                Dock = DockStyle.Left,
                Margin = margin,
                Size = new Size(26, 30)
            };
            //deal with left arrow open
            PictureBox openPic = new PictureBox();
            openPic.Dock = DockStyle.Left;
            openPic.Name = "picExame";
            openPic.Size = new Size(26, 30);

            openPic.Image = Image.FromFile(@"Imagens\move-to-next (1).png");
            openPic.MaximumSize = new Size(openPic.Size.Width, 30);
            openPic.SizeMode = PictureBoxSizeMode.CenterImage;
            _auxPic = openPic;
            openPic.MouseClick += new MouseEventHandler(OpenPic_MouseClick);
            row.Controls.Add(openPic);
            expandPanel.Controls.Add(row);
            //_ExpandPanel.BackColor = Color.Black;


            for (int i = 0; i < examItem.DataExame.Count; i++)
            {
                //row for hemograma completo
                Panel rowInside = new Panel();
                rowInside.Margin = margin;
                rowInside.Name = examItem.Nome;
                rowInside.Tag = examItem.Nome;
                rowInside.Dock = DockStyle.Top;
                rowInside.Anchor = AnchorStyles.Left;
                rowInside.MaximumSize = new Size(expandPanel.Width, 30);
                rowInside.Size = new Size(expandPanel.Width, 30);
                //RowInside.BackColor = Color.Yellow;

                Label datasexame = new Label();

                datasexame.AutoSize = false;
                datasexame.Dock = DockStyle.Fill;
                datasexame.MaximumSize = new Size(description.Size.Width, 30);
                datasexame.Font = new Font("Times New Roman", 10.0f, FontStyle.Bold);
                datasexame.Text = examItem.DataExame[i].ToString("dd/MM/yyyy") + $"Protocolo nº: {examItem.Protocolo[i]}";
                datasexame.TextAlign = ContentAlignment.MiddleLeft;
                rowInside.Controls.Add(description);
                //Label Protocolo = new Label();

                //Protocolo.AutoSize = false;
                //Protocolo.Dock = DockStyle.Fill;

                //Protocolo.Font = new Font("Times New Roman", 10.0f, FontStyle.Bold);
                //Protocolo.Text = _ExamItem.protocolo[i];
                //Protocolo.TextAlign = ContentAlignment.MiddleLeft;
                //RowInside.Controls.Add(Description);

                PictureBox picBoxExamOk = new PictureBox();
                picBoxExamOk.Dock = DockStyle.Right;
                picBoxExamOk.Name = "ExameOK";
                picBoxExamOk.Size = new Size(26, 30);
                picBoxExamOk.Image = Image.FromFile(@"Imagens\checked.png");
                picBoxExamOk.MaximumSize = new Size(openPic.Size.Width, 30);
                picBoxExamOk.SizeMode = PictureBoxSizeMode.CenterImage;
                rowInside.Controls.Add(picBoxExamOk);
                expandPanel.Controls.Add(rowInside);

            }
            VacinaPanel.Controls.Add(expandPanel);




        }



        private void BuildList(Data.ExameItemColletion exameCollection)
        {
            //mainpanel
            VacinaPanel.AutoScroll = true;
            var margin = VacinaPanel.Margin;
            VacinaPanel.Dock = DockStyle.Fill;
            margin.All = 0;
            VacinaPanel.BackColor = Color.Red;
            VacinaPanel.Margin = margin;
            string[] names = { "ASU", "Exames", "Extras" };
            for (int i = 0; i < 3; i++)
            {

                //expanded panel
                FlowLayoutPanel expandPanel = new FlowLayoutPanel();
                expandPanel.Name = $"Expand{names[i]}";
                expandPanel.Tag = $"Expand{names[i]}";
                expandPanel.Dock = DockStyle.Top;
                expandPanel.Size = new Size(expandPanel.Size.Width, 30);

                //rowpanel
                Panel row = new Panel();
                row.Margin = margin;
                row.Name = names[i];
                row.Tag = names[i];
                row.Dock = DockStyle.Top;
                row.Anchor = AnchorStyles.Left;
                //Row.MaximumSize = new Size(MainPanel.Width, 30);
                row.Size = new Size(VacinaPanel.Width, 30);
                row.BackColor = Color.White;


                Label description = new Label();

                description.AutoSize = false;
                description.Dock = DockStyle.Fill;
                description.MaximumSize = new Size(description.Size.Width, 30);
                description.Font = new Font("Times New Roman", 10.0f, FontStyle.Bold);
                description.Text = names[i];
                description.TextAlign = ContentAlignment.MiddleLeft;
                row.Controls.Add(description);

                //panel for open tree
                PictureBox openPic = new PictureBox
                {
                    Dock = DockStyle.Left,
                    Name = "openPic",
                    Size = new Size(26, 30),

                    Image = Image.FromFile(@"Imagens\move-to-next (1).png")
                };
                openPic.MaximumSize = new Size(openPic.Size.Width, 30);
                openPic.SizeMode = PictureBoxSizeMode.CenterImage;
                _auxPic = openPic;
                openPic.MouseClick += new MouseEventHandler(OpenPic_MouseClick);
                row.Controls.Add(openPic);
                expandPanel.Controls.Add(row);
                expandPanel.BackColor = Color.Black;
                VacinaPanel.Controls.Add(expandPanel);
            }


        }

        #endregion
        
        #region ClickHandlers

        private void OpenPic_MouseClick2(object sender, MouseEventArgs e)
        {
            var test = (PictureBox)sender;
            FlowLayoutPanel auxcontrolList = (FlowLayoutPanel)test.Parent.Parent;
            
            _auxRowControl = auxcontrolList;
            OpenParent(auxcontrolList);

        }

        private void OpenPic_MouseClick(object sender, MouseEventArgs e)
        {

            var test = (PictureBox)sender;
            FlowLayoutPanel auxcontrolList = (FlowLayoutPanel)test.Parent.Parent;
            
            OpenParent(auxcontrolList);

























            //var test = (PictureBox)sender;
            //if (test.Tag == null || test.Tag.ToString() == "Closed")
            //{
            //    test.Tag = "Open";
            //    Image img = test.Image;
            //    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //    test.Image = img;
            //    AuxRowControl = test.Parent.Parent;

            //    for (int i = 0; i < 3; i++)
            //    {
            //        //rowpanel
            //        Panel teste = new Panel();
            //        teste.Dock = DockStyle.Top;
            //        teste.Size = new Size(teste.Size.Width, 30);
            //        //Row.MaximumSize = new Size(MainPanel.Width, 30);
            //        teste.Size = new Size(VacinaPanel.Width, 30);
            //        Color testcolor;
            //        if (i == 0)
            //        {
            //            testcolor = Color.Yellow;
            //        }
            //        else if (i == 1)
            //        {
            //            testcolor = Color.Blue;
            //        }
            //        else
            //        {
            //            testcolor = Color.Violet;
            //        }
            //        teste.BackColor = testcolor;
            //        AuxRowControl.MaximumSize = new Size(AuxRowControl.Size.Width, (AuxRowControl.Controls.Count + 1) * (26 + 4));
            //        AuxRowControl.Controls.Add(teste);

            //    }
            //    OpenParent(AuxRowControl as FlowLayoutPanel);


            //}
            //else
            //{
            //    test.Tag = "Closed";
            //    Image img = test.Image;
            //    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            //    test.Image = img;
            //    AuxRowControl = test.Parent.Parent as FlowLayoutPanel;

            //    AuxRowControl.Size = new Size(AuxRowControl.Width, 26);
            //    int auxControlCount = AuxRowControl.Controls.Count;
            //    for (int i = 0; i < auxControlCount; i++)
            //    {
            //        if (i != 0)
            //        {
            //            AuxRowControl.Controls.RemoveAt(AuxRowControl.Controls.Count - 1);
            //        }

            //    }
            //    //AuxRowControl.Controls.Clear();
            //}
        }

        private void OpenParent(FlowLayoutPanel rowPanel)
        {
            _auxRowControl = rowPanel;
            Timer timer1 = new Timer();
            timer1.Tick += Timer1_Tick;
            

            if (rowPanel.Name.ToString() == "ExpandExtras")
            {
                _auxMaxHeightControls = 0;
                foreach (Control item in rowPanel.Controls)
                {
                    _tick = 26;
                    _auxMaxHeightControls += item.Height;
                    timer1.Start();
                }

            }
            else if (rowPanel.Name.ToString() == "ExpandExames")
            {
                _auxMaxHeightControls = 0;
                foreach (Control item in rowPanel.Controls)
                {
                    //tick = 26;
                    _auxMaxHeightControls += item.Height;
                    timer1.Start();
                }


            }
            else
            {
                _auxMaxHeightControls = 0;
                foreach (Control item in rowPanel.Controls)
                {
                    _tick = 26;
                    _auxMaxHeightControls += item.Height;
                    timer1.Start();
                }

            }

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            var aux = sender as Timer;

            if (_tick > 130)
            { aux.Stop(); }
            else
            {

                _auxRowControl.Size = new Size(_auxRowControl.Size.Width, _tick);
                _tick += 15;
            }
        }
        #endregion











    }
}
