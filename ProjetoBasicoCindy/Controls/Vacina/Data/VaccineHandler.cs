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
        public VaccineHandler(Panel vacinaPanel)
        {
            this.vacinaPanel = vacinaPanel;
            vacinaPanel.Controls.Clear();
            FuncionarioVaccinaColletion funcionariodata = new FuncionarioVaccinaColletion();
            var objFunc = new FuncionarioItemEdit();
            
            Columnbuilder();
            PopulateColumns(objFunc.GetFuncionarioEdit()._vacinas);
        }

        public Panel vacinaPanel { get; set; }

        #region Vaccine methods
        public void PopulateColumns(FuncionarioVaccinaColletion _func)
        {
            
            if (_func.listaVacinas !=null)
            {
                if (_func.listaVacinas.Count > 0)
                {

                    foreach (Vacina vacina in _func.listaVacinas)
                    {
                        if (true)
                        {

                        }

                        //insert column



                        //deal with square containing labels
                        Panel pnlegendaDose = new Panel();
                        //pnlegendaDose.Name = "nome";
                        var margim = pnlegendaDose.Margin;
                        margim.All = 1;
                        pnlegendaDose.MaximumSize = new Size((vacinaPanel.Size.Width - 6) / 6, 40);
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
                            Column2.MaximumSize = new Size((vacinaPanel.Size.Width - 6) / 6, vacinaPanel.Size.Height);
                            Column2.MinimumSize = new Size((vacinaPanel.Size.Width - 6) / 6, vacinaPanel.Size.Height);

                        }

                        Panel teste = new Panel();

                        dosevacina.Left = (pnlegendaDose.ClientSize.Width - dosevacina.Width) / 2;
                        dosevacina.Top = (pnlegendaDose.ClientSize.Height - dosevacina.Height) / 2;


                        Panel pn1Dose = new Panel();
                        pn1Dose.MaximumSize = new Size((vacinaPanel.Size.Width - 6) / 6, (vacinaPanel.Size.Height - 46) / 3);
                        pn1Dose.MinimumSize = new Size((vacinaPanel.Size.Width - 6) / 6, (vacinaPanel.Size.Height - 46) / 3);
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
                        foreach (Control c in vacinaPanel.Controls)
                        {
                            if (vacina._nome == c.Tag)
                            {
                                if (vacina._nome == c.Name)
                                {
                                    //c.Controls.Add();
                                    aux1 = c;

                                    c.BackColor = Color.Red;
                                    auxControl = false;

                                    vacinaPanel.Controls.Remove(c);
                                    c.Controls.Add(pn1Dose);
                                    vacinaPanel.Controls.Add(c);
                                }

                            }
                        }

                        //vacinaPanel.Controls.Add(Column2);


                        if (auxControl)
                        {
                            Column2.Controls.Add(pnlegendaDose);
                            vacinaPanel.Controls.Add(Column2);

                        }
                        else
                        {
                            vacinaPanel.Controls.Remove(aux1);
                            aux1.Controls.Add(teste);
                            vacinaPanel.Controls.Add(aux1);

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
            Column2.MaximumSize = new Size((vacinaPanel.Size.Width - 6) / 6, vacinaPanel.Size.Height);
            Column2.MinimumSize = new Size((vacinaPanel.Size.Width - 6) / 6, vacinaPanel.Size.Height);
            bool aux = true;
            foreach (var item in leftlabels)
            {
                //deal with square containing labels
                Panel pnlegendaDose = new Panel();
                var margim = pnlegendaDose.Margin;
                margim.All = 1;

                pnlegendaDose.Margin = margim;
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
                    pnlegendaDose.MaximumSize = new Size((vacinaPanel.Size.Width - 6) / 6, 40);
                    pnlegendaDose.MinimumSize = new Size((vacinaPanel.Size.Width - 6) / 6, 40);
                    //code to centralize text into panel

                    aux = false;
                }
                else
                {
                    pnlegendaDose.MaximumSize = new Size((vacinaPanel.Size.Width - 6) / 6, (vacinaPanel.Size.Height - 46) / 3);
                    pnlegendaDose.MinimumSize = new Size((vacinaPanel.Size.Width - 6) / 6, (vacinaPanel.Size.Height - 46) / 3);

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

            vacinaPanel.Controls.Add(Column2);
            #endregion





        }



        #endregion

    }
}
