using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoBasicoCindy.Vacina
{
    public class VaccineHandler
    {
        #region Variables
        private Size[] _columDimentions = new Size[3];
        public Panel VacinaPanel { get; set; }

        #endregion

        #region Constructor
        public VaccineHandler(Panel vacinaPanel)
        {
            VacinaPanel = vacinaPanel;
            vacinaPanel.Controls.Clear();
            //FuncionarioVaccinaColletion funcionariodata = new FuncionarioVaccinaColletion();
            var objFunc = new FuncionarioItemEdit();
            Columnbuilder();
            NewBuild(objFunc.GetFuncionarioEdit().Vacinas, VacinaPanel);

        }
        #endregion




        #region Starting a new

        private void NewBuild(FuncionarioVaccinaColletion vacinas, Panel panelToshow)
        {
            foreach (Vacina vacina in vacinas.ListaVacinas)
            {
                Control panelToadd = HelperClass.FindTag(panelToshow.Controls, DealWithVaccineNames(vacina));                
                ViewControls.Vacinas.VaccineViewer vacinaPanel = new ViewControls.Vacinas.VaccineViewer(vacina.Nome, vacina.Dados.Data.ToString("dd/MM/yyyy"), vacina.Dados.Lote, vacina.Dados.Unidade);
                panelToadd.Controls.RemoveAt(vacina.Dose);
                var margim = vacinaPanel.Margin;
                margim.All = 0;
                margim.Top = 1;
                vacinaPanel.Margin = margim;
                vacinaPanel.Size = VacineViewerSizeHandler(vacinaPanel, panelToadd);
                panelToadd.Controls.Add(vacinaPanel);
                panelToadd.Controls.SetChildIndex(vacinaPanel, (vacina.Dose));
            }
        }
        private Size VacineViewerSizeHandler(ViewControls.Vacinas.VaccineViewer vacina, Control panelreceived)
        {
            int vaccineNameControl = panelreceived.Controls[0].Size.Height + 1;
            int auxHeight = panelreceived.Height - vaccineNameControl;
            auxHeight = (auxHeight / 3);
            auxHeight -= 1;


            Size controlsize = new Size(panelreceived.Controls[0].Size.Width + 1, auxHeight);
            return controlsize;

        } 

        private void ShowVaccineInfo(FuncionarioVaccinaColletion vacina)
        {
            int squares = 1;
            foreach (Vacina vacinainfo in vacina.ListaVacinas)
            {
                FlowLayoutPanel pn1Dose = new FlowLayoutPanel();

                pn1Dose.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, (VacinaPanel.Size.Height - 46) / 3);
                pn1Dose.MinimumSize = new Size((VacinaPanel.Size.Width - 6) / 6, (VacinaPanel.Size.Height - 46) / 3);
                var margim = pn1Dose.Margin;
                margim.All = 1;
                pn1Dose.Margin = margim;
                pn1Dose.BackColor = Color.LightGray;



                Label lbData = new Label();
                Label lbLote = new Label();
                Label lbUnid = new Label();
                lbData.Text = String.Format("Data:" + vacinainfo.Dados.Data.ToString("dd/MM/yyyy"));
                lbLote.Text = String.Format("Lote:" + vacinainfo.Dados.Lote);
                lbUnid.Text = String.Format("Unid:" + vacinainfo.Dados.Unidade);
                ViewControls.Vacinas.VaccineViewer vacineInfo = new ViewControls.Vacinas.VaccineViewer(vacinainfo.Nome, vacinainfo.Dados.Data.ToString("dd/MM/yyyy"), vacinainfo.Dados.Lote, vacinainfo.Dados.Unidade);




                margim.All = 1;
                vacineInfo.Margin = margim;
                //lbData.Dock = DockStyle.Top;
                lbData.Margin = margim;
                lbData.Left = (pn1Dose.ClientSize.Width - lbData.Width) / 2;
                lbData.Top = (pn1Dose.ClientSize.Height - lbData.Height) / 5;
                //pn1Dose.Controls.Add(lbData);
                //pn1Dose.Controls.Add(lbLote);
                lbLote.Left = lbData.Left;
                lbLote.Top = lbData.Top + 25;
                //lbLote.Dock = DockStyle.Top;
                lbLote.Margin = margim;



                //lbUnid.Dock = DockStyle.Top;
                lbUnid.Margin = margim;
                //pn1Dose.Controls.Add(lbUnid);
                lbUnid.Left = lbData.Left;

                string nomevacina = "";
                switch (vacinainfo.Nome)
                {

                    case "HEPATITE B":
                        {
                            nomevacina = "Heb B";
                            squares = 3;
                        }

                        break;
                    case "DUPLA ADULTA":
                        {
                            nomevacina = "Dupla Adulta";
                            squares = 1;
                        }
                        break;
                    case "RUBEOLA":
                        {
                            nomevacina = "Rubeola";
                            squares = 1;
                        }
                        break;
                    case "FEBREAMARELA":
                        {
                            nomevacina = "Febre Amar.";
                            squares = 2;
                        }
                        break;
                    case "TRIPLICE VIRAL":
                        {
                            nomevacina = "Trip. Viral";
                            squares = 2;
                        }
                        break;
                    default:
                        nomevacina = "nao deu";
                        break;
                }




                //finds flowpanel with vaccine name
                Control panelToadd = HelperClass.FindTag(VacinaPanel.Controls, nomevacina);



                int dose = vacinainfo.Dose;
                //Size sizetose = pn1Dose.Size;
                vacineInfo.Size = new Size(_columDimentions[2].Width, (_columDimentions[2].Height -1));

                panelToadd.Controls.RemoveAt(dose);
                
                panelToadd.Controls.Add(vacineInfo);
                panelToadd.Controls.SetChildIndex(vacineInfo, (dose));


            }
            var helper =  HelperClass.FindTag(VacinaPanel.Controls, "teste");




        }


        private string DealWithVaccineNames(Vacina vacina)
        {

            switch (vacina.Nome)
            {

                case "HEPATITE B":
                    {
                        return "Heb B";
                        
                    }
                    
                case "DUPLA ADULTA":
                    {
                        return "Dupla Adulta";
                        
                    }
                case "RUBEOLA":
                    {
                        return "Rubeola";
                        
                    }

                case "FEBREAMARELA":
                    {
                        return "Febre Amar.";
                        
                    }

                case "TRIPLICE VIRAL":
                    {
                        return "Trip. Viral";
                        
                    }

                default:
                    return "nao deu";

            }
        }





        #endregion








        #region Vaccine methods
        public void PopulateColumns(FuncionarioVaccinaColletion func)
        {

            if (func.ListaVacinas != null)
            {
                if (func.ListaVacinas.Count > 0)
                {

                    foreach (Vacina vacina in func.ListaVacinas)
                    {


                        //insert column



                        //deal with square containing labels
                        Panel pnlegendaDose = new Panel();
                        //pnlegendaDose.Name = "nome";
                        var margim = pnlegendaDose.Margin;
                        margim.All = 1;
                        pnlegendaDose.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, 40);
                        pnlegendaDose.Margin = margim;
                        pnlegendaDose.BackColor = Color.LightGray;

                        Label dosevacina = new Label();
                        dosevacina.Text = vacina.Nome;
                        //panel for name of vaccine handler
                        pnlegendaDose.Controls.Add(dosevacina);
                        dosevacina.Left = (pnlegendaDose.ClientSize.Width - dosevacina.Width) / 2;
                        dosevacina.Top = (pnlegendaDose.ClientSize.Height - dosevacina.Height) / 2;

                        //panel for name of vaccine 1st dose

                        //check if there s acolumn for related vaccine
                        bool auxControl = true;
                        Control aux1 = null;
                        //foreach (Control c in vacinaPanel.Controls)
                        //{
                        //    if (vacina._nome == c.Tag)
                        //    {
                        //        if (vacina._nome == c.Name)
                        //        {
                        //            //c.Controls.Add();
                        //            aux1 = c;

                        //            c.BackColor = Color.Red;
                        //            auxControl = false;
                        //        }


                        //    }
                        //}
                        FlowLayoutPanel column2 = new FlowLayoutPanel();
                        if (auxControl)
                        {

                            column2.BackColor = Color.Yellow;
                            column2.Tag = vacina.Nome;
                            column2.Name = vacina.Nome;
                            var margin = column2.Margin;
                            margin.All = 0;
                            margin.Right = 1;

                            column2.Margin = margin;
                            column2.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, VacinaPanel.Size.Height);
                            column2.MinimumSize = new Size((VacinaPanel.Size.Width - 6) / 6, VacinaPanel.Size.Height);

                        }

                        Panel teste = new Panel();

                        dosevacina.Left = (pnlegendaDose.ClientSize.Width - dosevacina.Width) / 2;
                        dosevacina.Top = (pnlegendaDose.ClientSize.Height - dosevacina.Height) / 2;


                        Panel pn1Dose = new Panel();
                        pn1Dose.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, (VacinaPanel.Size.Height - 46) / 3);
                        pn1Dose.MinimumSize = new Size((VacinaPanel.Size.Width - 6) / 6, (VacinaPanel.Size.Height - 46) / 3);
                        margim = pnlegendaDose.Margin;
                        margim.All = 1;
                        pn1Dose.Margin = margim;
                        pn1Dose.BackColor = Color.LightGray;

                        Label lbData = new Label();
                        Label lbLote = new Label();
                        Label lbUnid = new Label();
                        lbData.Text = String.Format("Data:" + vacina.Dados.Data.ToString("dd/MM/yyyy"));
                        lbLote.Text = String.Format("Lote:" + vacina.Dados.Lote);
                        lbUnid.Text = String.Format("Unid:" + vacina.Dados.Unidade);


                        margim.All = 1;
                        //lbData.Dock = DockStyle.Top;
                        lbData.Margin = margim;
                        lbData.Left = (pn1Dose.ClientSize.Width - lbData.Width) / 2;
                        lbData.Top = (pn1Dose.ClientSize.Height - lbData.Height) / 5;
                        pn1Dose.Controls.Add(lbData);
                        pn1Dose.Controls.Add(lbLote);
                        lbLote.Left = lbData.Left;
                        lbLote.Top = lbData.Top + 25;
                        //lbLote.Dock = DockStyle.Top;
                        lbLote.Margin = margim;



                        //lbUnid.Dock = DockStyle.Top;
                        lbUnid.Margin = margim;
                        pn1Dose.Controls.Add(lbUnid);
                        lbUnid.Left = lbData.Left;
                        lbUnid.Top = lbData.Top + 50;
                        teste = pn1Dose;
                        if (aux1 != null)
                        {
                            aux1.Controls.Add(pn1Dose);
                        }
                        foreach (Control c in VacinaPanel.Controls)
                        {
                            if (vacina.Nome == c.Tag)
                            {
                                if (vacina.Nome == c.Name)
                                {
                                    //c.Controls.Add();
                                    aux1 = c;

                                    c.BackColor = Color.Red;
                                    auxControl = false;

                                    VacinaPanel.Controls.Remove(c);
                                    c.Controls.Add(pn1Dose);
                                    VacinaPanel.Controls.Add(c);
                                }

                            }
                        }

                        //vacinaPanel.Controls.Add(Column2);


                        if (auxControl)
                        {
                            column2.Controls.Add(pnlegendaDose);
                            VacinaPanel.Controls.Add(column2);

                        }
                        else
                        {
                            VacinaPanel.Controls.Remove(aux1);
                            aux1.Controls.Add(teste);
                            VacinaPanel.Controls.Add(aux1);

                        }
                    }

                }
            }





        }
        private void Columnbuilder()
        {
            #region Construtor inicial
            //panel for side legends

            int x = 60;
            int y = 40;
            string[] leftlabels = { "Doses/ Vacinas", "1ª Dose", "2ª Dose", "3ª Dose" };
            //add panels descriptions


            FlowLayoutPanel column2 = new FlowLayoutPanel();
            column2.BackColor = Color.White;
            var margin = column2.Margin;
            margin.All = 0;
            margin.Right = 1;

            column2.Margin = margin;
            column2.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, VacinaPanel.Size.Height);
            column2.MinimumSize = new Size((VacinaPanel.Size.Width - 6) / 6, VacinaPanel.Size.Height);
            _columDimentions[0] = column2.Size;
            bool aux = true;
            foreach (var item in leftlabels)
            {
                //deal with square containing labels
                Panel pnlegendaDose = new Panel();
                //var margim = pnlegendaDose.Margin;
                margin.All = 1;

                pnlegendaDose.Margin = margin;
                pnlegendaDose.BackColor = Color.DarkGray;


                //create labels to be added to control

                Label dosevacina = new Label();
                dosevacina.MaximumSize = new Size(50, 45);
                dosevacina.AutoSize = true;
                dosevacina.Size = new Size(60, 40);
                dosevacina.Text = item;
                dosevacina.Font = new Font(dosevacina.Font.Name, 8, FontStyle.Underline);
                //pnlegendaDose.AutoScroll = true;

                pnlegendaDose.Controls.Add(dosevacina);




                //deal with first square that has smaller size
                if (aux)
                {
                    pnlegendaDose.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, 40);
                    pnlegendaDose.MinimumSize = new Size((VacinaPanel.Size.Width - 6) / 6, 40);
                    //code to centralize text into panel
                    _columDimentions[1] = pnlegendaDose.Size;

                    aux = false;
                }
                else
                {
                    //other size legens
                    pnlegendaDose.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, (VacinaPanel.Size.Height - 46) / 3);
                    pnlegendaDose.MinimumSize = new Size((VacinaPanel.Size.Width - 6) / 6, (VacinaPanel.Size.Height - 46) / 3);

                    _columDimentions[2] = pnlegendaDose.Size;

                }



                y = column2.Size.Height;
                x = column2.Size.Width;
                y = y - 48;
                y = y / 3;
                dosevacina.Left = (pnlegendaDose.ClientSize.Width - dosevacina.Width) / 2;
                dosevacina.Top = (pnlegendaDose.ClientSize.Height - dosevacina.Height) / 2;
                column2.Controls.Add(pnlegendaDose);
                //vacinaPanel.Controls.Add(Column);
                
            }

            VacinaPanel.Controls.Add(column2);
            #endregion


            string[] vaccinenames = { "Heb B", "Trip. Viral", "Febre Amar.", "Rubeola", "Dupla Adulta" };
            //creates the 5 colums for vaccines
            Color[] colors = { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Red, Color.Red };
            var controlcolor = true;
            for (int i = 0; i < vaccinenames.Count(); i++)
            {

                //creates the 5 panels for vaccines
                FlowLayoutPanel panelVaccines = new FlowLayoutPanel();
                panelVaccines.Tag = vaccinenames[i];
                panelVaccines.AutoSize = false;
                margin.All = 0;
                panelVaccines.Margin = margin;
                panelVaccines.Padding = new Padding(0, 0, 0, 0);
                //sets size by previously stored variables
                panelVaccines.Size = new Size((((_columDimentions[0].Width * 4) / 5)), _columDimentions[0].Height);
                panelVaccines.FlowDirection = FlowDirection.TopDown;
                //panelVaccines.BackColor = colors[i];


                //------------STARTS INSERT OF DATE INSIDE COLUMN
                Panel panelVacinaName = new Panel();

                panelVacinaName.Size = new Size(panelVaccines.Width, _columDimentions[1].Height);
                _columDimentions[1].Width = panelVaccines.Width;
                _columDimentions[2].Width = _columDimentions[1].Width;
                //sets color interhange

                if (controlcolor)
                {
                    panelVacinaName.BackColor = Color.LightGray;
                    controlcolor = false;
                }
                else
                {
                    panelVacinaName.BackColor = Color.White;
                    controlcolor = true;
                }


                //add label with anme of vaccine
                Label vacinaa = new Label();
                vacinaa.Text = vaccinenames[i];
                panelVacinaName.Controls.Add(vacinaa);
                vacinaa.Left = 15;
                vacinaa.Top = (panelVacinaName.ClientSize.Height - vacinaa.Height) / 2;

                //inserts panel with label inside colum with vaccine name
                panelVacinaName.Controls.Add(vacinaa);


                //setsup objects at right margins and paddings
                var margim = panelVaccines.Margin;
                margim.All = 1;
                panelVaccines.Margin = margim;
                panelVacinaName.Margin = margim;
                panelVaccines.Controls.Add(panelVacinaName);
                //add dummy items to keep vaccinelist full
                int dosestotake = 0;
                switch (vaccinenames[i])
                {
                    

                    case "Heb B":
                        {
                            dosestotake = 3;

                        }

                        break;
                    case "Dupla Adulta":
                        {
                            dosestotake = 1;
                        }
                        break;
                    case "Rubeola":
                        {
                            dosestotake = 1;
                        }
                        break;
                    case "Febre Amar.":
                        {
                            dosestotake = 2;
                        }
                        break;
                    case "Trip. Viral" :
                        {
                            dosestotake = 2;
                        }
                        break;
                    default:
                       
                        break;
                }
                for (int j = 0; j < dosestotake; j++)
                {
                    ViewControls.Vacinas.VaccineViewer objClearVaccine = new ViewControls.Vacinas.VaccineViewer();

                    objClearVaccine.Margin = margim;
                    objClearVaccine.Size = new Size((VacinaPanel.Size.Width - 6) / 6, (VacinaPanel.Size.Height - 48) / 3);
                    objClearVaccine.Padding = new Padding(0, 0, 0, 0);
                    objClearVaccine.Tag = (j + 1);
                    panelVaccines.Controls.Add(objClearVaccine);


                }




                //insert colum

                VacinaPanel.Controls.Add(panelVaccines);





            }
            var teste = VacinaPanel;







        }



        #endregion

    }
}
