using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBasicoCindy.Vacina
{
    public class VaccineHandler
    {
        #region Variables
        private Size[] ColumDimentions = new Size[3];
        public Panel VacinaPanel { get; set; }

        #endregion

        public VaccineHandler(Panel vacinaPanel)
        {
            this.VacinaPanel = vacinaPanel;
            vacinaPanel.Controls.Clear();
            FuncionarioVaccinaColletion funcionariodata = new FuncionarioVaccinaColletion();

            var objFunc = new FuncionarioItemEdit();



            Columnbuilder();
            NewBuild(objFunc.GetFuncionarioEdit()._vacinas, VacinaPanel);
            //ShowVaccineInfo(objFunc.GetFuncionarioEdit()._vacinas);

            //PopulateColumns(objFunc.GetFuncionarioEdit()._vacinas);
        }



        #region Starting a new

        private void NewBuild(FuncionarioVaccinaColletion _vacinas, Panel _panelToshow)
        {


            foreach (Vacina vacina in _vacinas.listaVacinas)
            {
                Control PanelToadd = HelperClass.FindTag(_panelToshow.Controls, DealWithVaccineNames(vacina));                
                ViewControls.Vacinas.VaccineViewer VacinaPanel = new ViewControls.Vacinas.VaccineViewer(vacina._nome, vacina._dados.Data.ToString("dd/MM/yyyy"), vacina._dados.Lote, vacina._dados.Unidade);
                PanelToadd.Controls.RemoveAt(vacina._dose);
                var margim = VacinaPanel.Margin;
                margim.All = 0;
                margim.Top = 1;
                VacinaPanel.Margin = margim;
                VacinaPanel.Size = VacineViewerSizeHandler(VacinaPanel, PanelToadd);
                PanelToadd.Controls.Add(VacinaPanel);
                PanelToadd.Controls.SetChildIndex(VacinaPanel, (vacina._dose));
            }
        }
        private Size VacineViewerSizeHandler(ViewControls.Vacinas.VaccineViewer _vacina, Control _panelreceived)
        {
            int VaccineNameControl = _panelreceived.Controls[0].Size.Height + 1;
            int AuxHeight = _panelreceived.Height - VaccineNameControl;
            AuxHeight = (AuxHeight / 3);
            AuxHeight -= 1;


            Size controlsize = new Size(_panelreceived.Controls[0].Size.Width + 1, AuxHeight);
            return controlsize;

        } 

        private void ShowVaccineInfo(FuncionarioVaccinaColletion _vacina)
        {
            int squares = 1;
            foreach (Vacina vacinainfo in _vacina.listaVacinas)
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
                lbData.Text = String.Format("Data:" + vacinainfo._dados.Data.ToString("dd/MM/yyyy"));
                lbLote.Text = String.Format("Lote:" + vacinainfo._dados.Lote);
                lbUnid.Text = String.Format("Unid:" + vacinainfo._dados.Unidade);
                ViewControls.Vacinas.VaccineViewer vacineInfo = new ViewControls.Vacinas.VaccineViewer(vacinainfo._nome, vacinainfo._dados.Data.ToString("dd/MM/yyyy"), vacinainfo._dados.Lote, vacinainfo._dados.Unidade);




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
                switch (vacinainfo._nome)
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
                Control PanelToadd = HelperClass.FindTag(VacinaPanel.Controls, nomevacina);



                int dose = vacinainfo._dose;
                //Size sizetose = pn1Dose.Size;
                vacineInfo.Size = new Size(ColumDimentions[2].Width, (ColumDimentions[2].Height -1));

                PanelToadd.Controls.RemoveAt(dose);
                
                PanelToadd.Controls.Add(vacineInfo);
                PanelToadd.Controls.SetChildIndex(vacineInfo, (dose));


            }
            var helper =  HelperClass.FindTag(VacinaPanel.Controls, "teste");




        }


        private string DealWithVaccineNames(Vacina _Vacina)
        {

            switch (_Vacina._nome)
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
        public void PopulateColumns(FuncionarioVaccinaColletion _func)
        {

            if (_func.listaVacinas != null)
            {
                if (_func.listaVacinas.Count > 0)
                {

                    foreach (Vacina vacina in _func.listaVacinas)
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
                        dosevacina.Text = vacina._nome;
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
                        FlowLayoutPanel Column2 = new FlowLayoutPanel();
                        if (auxControl)
                        {

                            Column2.BackColor = Color.Yellow;
                            Column2.Tag = vacina._nome;
                            Column2.Name = vacina._nome;
                            var margin = Column2.Margin;
                            margin.All = 0;
                            margin.Right = 1;

                            Column2.Margin = margin;
                            Column2.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, VacinaPanel.Size.Height);
                            Column2.MinimumSize = new Size((VacinaPanel.Size.Width - 6) / 6, VacinaPanel.Size.Height);

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
                        lbData.Text = String.Format("Data:" + vacina._dados.Data.ToString("dd/MM/yyyy"));
                        lbLote.Text = String.Format("Lote:" + vacina._dados.Lote);
                        lbUnid.Text = String.Format("Unid:" + vacina._dados.Unidade);


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
                            if (vacina._nome == c.Tag)
                            {
                                if (vacina._nome == c.Name)
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
                            Column2.Controls.Add(pnlegendaDose);
                            VacinaPanel.Controls.Add(Column2);

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


            FlowLayoutPanel Column2 = new FlowLayoutPanel();
            Column2.BackColor = Color.Yellow;
            var margin = Column2.Margin;
            margin.All = 0;
            margin.Right = 1;

            Column2.Margin = margin;
            Column2.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, VacinaPanel.Size.Height);
            Column2.MinimumSize = new Size((VacinaPanel.Size.Width - 6) / 6, VacinaPanel.Size.Height);
            ColumDimentions[0] = Column2.Size;
            bool aux = true;
            foreach (var item in leftlabels)
            {
                //deal with square containing labels
                Panel pnlegendaDose = new Panel();
                //var margim = pnlegendaDose.Margin;
                margin.All = 1;

                pnlegendaDose.Margin = margin;
                pnlegendaDose.BackColor = Color.LightGray;


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
                    ColumDimentions[1] = pnlegendaDose.Size;

                    aux = false;
                }
                else
                {
                    //other size legens
                    pnlegendaDose.MaximumSize = new Size((VacinaPanel.Size.Width - 6) / 6, (VacinaPanel.Size.Height - 46) / 3);
                    pnlegendaDose.MinimumSize = new Size((VacinaPanel.Size.Width - 6) / 6, (VacinaPanel.Size.Height - 46) / 3);

                    ColumDimentions[2] = pnlegendaDose.Size;

                }



                y = Column2.Size.Height;
                x = Column2.Size.Width;
                y = y - 48;
                y = y / 3;
                dosevacina.Left = (pnlegendaDose.ClientSize.Width - dosevacina.Width) / 2;
                dosevacina.Top = (pnlegendaDose.ClientSize.Height - dosevacina.Height) / 2;
                Column2.Controls.Add(pnlegendaDose);
                //vacinaPanel.Controls.Add(Column);
                
            }

            VacinaPanel.Controls.Add(Column2);
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
                panelVaccines.Size = new Size((((ColumDimentions[0].Width * 4) / 5)), ColumDimentions[0].Height);
                panelVaccines.FlowDirection = FlowDirection.TopDown;
                panelVaccines.BackColor = colors[i];


                //------------STARTS INSERT OF DATE INSIDE COLUMN
                Panel PanelVacinaName = new Panel();

                PanelVacinaName.Size = new Size(panelVaccines.Width, ColumDimentions[1].Height);
                ColumDimentions[1].Width = panelVaccines.Width;
                ColumDimentions[2].Width = ColumDimentions[1].Width;
                //sets color interhange

                if (controlcolor)
                {
                    PanelVacinaName.BackColor = Color.LightGray;
                    controlcolor = false;
                }
                else
                {
                    PanelVacinaName.BackColor = Color.White;
                    controlcolor = true;
                }


                //add label with anme of vaccine
                Label vacinaa = new Label();
                vacinaa.Text = vaccinenames[i];
                PanelVacinaName.Controls.Add(vacinaa);
                vacinaa.Left = 15;
                vacinaa.Top = (PanelVacinaName.ClientSize.Height - vacinaa.Height) / 2;

                //inserts panel with label inside colum with vaccine name
                PanelVacinaName.Controls.Add(vacinaa);


                //setsup objects at right margins and paddings
                var margim = panelVaccines.Margin;
                margim.All = 1;
                panelVaccines.Margin = margim;
                PanelVacinaName.Margin = margim;
                panelVaccines.Controls.Add(PanelVacinaName);
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
                    objClearVaccine.BackColor = Color.LightGray;
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
