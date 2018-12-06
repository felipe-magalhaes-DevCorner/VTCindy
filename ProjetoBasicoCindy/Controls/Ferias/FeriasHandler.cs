using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pabo.Calendar;
using MonthCalendar = Pabo.Calendar.MonthCalendar;

namespace ProjetoBasicoCindy.Ferias
{
    public class FeriasHandler
    {
        #region Variables
        FlowLayoutPanel showPanel { get; set; }
        FeriasColletionItem ferias { get; set; }

        #endregion

        #region Contructor
        public FeriasHandler(FlowLayoutPanel _panelToShow)
        {

            showPanel = _panelToShow;
            
            BuildCalendar(DateTime.Now.Year);
            //FeriasColletionItem funcionariodata = new FeriasColletionItem();
            var objFunc = new FuncionarioItemEdit();
            LoadFuncFerias(objFunc.GetFuncionarioEdit()._ferias);




        }
        #endregion

        #region Build Calendars

        private void BuildCalendar(int _year)
        {
            //variables
            int height = 0;
            bool wasExecuted = false;
            showPanel.FlowDirection = FlowDirection.TopDown;
            int math = 1;
            //pannel for year select
            Panel YearSelect = new Panel();
            YearSelect.AutoSize = false;
            

            //labeo year
            Label lbYear = new Label();
            lbYear.AutoSize = true;
            //button left
            Button btLeftYear = new Button();
            btLeftYear.Size = new Size(16, 16);
            //read image for button
            FileStream fs = new System.IO.FileStream(@"Imagens\leftarrow.png", FileMode.Open, FileAccess.Read);
            Image img = Image.FromStream(fs);
            btLeftYear.Image = img;
            btLeftYear.Name = "btLeftYear";
            btLeftYear.Padding = new Padding(0);
            btLeftYear.FlatStyle = FlatStyle.Flat;
            //button right
            Button btRightArrow = new Button(); ;
            btRightArrow.Name = "btRightArrow";
            btRightArrow.Image = img;
            btRightArrow.Padding = new Padding(0);
            btRightArrow.FlatStyle = FlatStyle.Flat;
            
            btRightArrow.Size = new Size(16, 16);
            FileStream fs2 = new System.IO.FileStream(@"Imagens\rightarrow.png", FileMode.Open, FileAccess.Read);
            Image img2 = Image.FromStream(fs2);
            
            btRightArrow.Image = img2;
            var auxmargin = lbYear.Margin;
            auxmargin.All = 0;
            btLeftYear.Margin = auxmargin;
            //deal with space
            var margin = lbYear.Margin;
            

            
            btLeftYear.Padding = new Padding(0);
            lbYear.Text = _year.ToString();
            lbYear.Font =  new Font("Times New Roman", 10.0f, FontStyle.Bold);
            lbYear.ForeColor = Color.Black;
            
            
            YearSelect.Margin = auxmargin;
            YearSelect.Padding = new Padding(0);
            YearSelect.BackColor = ColorTranslator.FromHtml("#CF6766");


            YearSelect.Controls.Add(btLeftYear);
            
            YearSelect.Controls.Add(lbYear);
            
            YearSelect.Controls.Add(btRightArrow);
            YearSelect.Controls.SetChildIndex(btLeftYear, 2);
            
            YearSelect.Controls.SetChildIndex(lbYear,1);
            //YearSelect.Controls.SetChildIndex(btRightArrow, 2);





            showPanel.Controls.Add(YearSelect);
            //divide months into panels for stacking horizontally and vertically 
            //4 panels with 3 calendars or 3 with 4 dunno yet
            for (int c = 1; c <= 3; c++)
            {
                //panel colum
                FlowLayoutPanel RowMonthPanel = new FlowLayoutPanel();
                
                RowMonthPanel.FlowDirection = FlowDirection.LeftToRight;
                RowMonthPanel.Tag = $"Row{c + 1}";
                //add 4 months to row panel

                for (int i = 1; i <= 4; i++)
                {

                    MonthCalendar Calendar = new MonthCalendar();
                   
                    Calendar.Tag = $"month{math}";
                    Calendar.Name = math.ToString();
                    //add date value to calendar
                    //shows calendar month as well
                    //sets all settings of calendars
                    Calendar.ActiveMonth.Year = _year;
                    Calendar.ActiveMonth.Month = math;
                    Calendar.Header.ShowMonth = false;
                    Calendar.Header.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(math);
                    Calendar.Footer.ShowToday = false;
                    Calendar.Header.MonthSelectors = false;
                    Calendar.Header.BackColor1 = ColorTranslator.FromHtml("#CF6766");
                    Calendar.Weekdays.TextColor = ColorTranslator.FromHtml("#0E1116"); 
                    Calendar.KeyboardEnabled = false;


                    Calendar.Weekdays.Font = new Font("Arial", 7);
                    DateItem[] d = new DateItem[5];
                    d.Initialize();
                    for (int k   = 0; k < 5; k++)
                        d[k] = new DateItem();
                    height = Calendar.Height;
                    RowMonthPanel.Controls.Add(Calendar);
                    math++;
                }

                //RowMonthPanel.BackColor = ColorTranslator.FromHtml("#D8DBE2");
                
                
                YearSelect.Dock = DockStyle.Top;
                RowMonthPanel.Size = new Size(showPanel.Width, height + 3);
                //year top panel settings
                YearSelect.MaximumSize = new Size((RowMonthPanel.Width -45), 16);

                btLeftYear.Dock = DockStyle.Left;
                //last part of dealing with label position
                lbYear.Dock = DockStyle.Fill;
                lbYear.AutoSize = false;
                lbYear.TextAlign = ContentAlignment.MiddleCenter;
                btRightArrow.Dock = DockStyle.Right;
                //btRightArrow.Click += new EventHandler(this.YearChange);
                //btLeftYear.Click += new EventHandler(this.YearChange);
                



                showPanel.BackColor = ColorTranslator.FromHtml("#D8DBE2");
                showPanel.Controls.Add(RowMonthPanel);

            }
            btLeftYear.Click += delegate
            {
                YearChange(-1);
            };
            btRightArrow.Click += delegate
            {
                YearChange(1);
            };

        }
        

        private void YearChange(int changeyear)
        {


                    showPanel.Controls.Clear();
                    HelperClass.ChangeYear(changeyear);
                    BuildCalendar(HelperClass.YearShown);
                    
                    var objFunc = new FuncionarioItemEdit();
                    LoadFuncFerias(objFunc.GetFuncionarioEdit()._ferias);


        }
        #endregion


        #region Handlers for funcionario

        private void LoadFuncFerias(FeriasColletionItem _feriasCol)
        {
            int auxMonthS = 0;
            int auxMonthE = 0;
            Control TagFound = new Control();

                Control row1 = showPanel.Controls[1];
                Control row2 = showPanel.Controls[2];
                Control row3 = showPanel.Controls[3];
                foreach (FeriasItem feriasItem in _feriasCol.ListaFerias)
                {


                    //auxiliary variables

                    DateTime currentDate = new DateTime();
                    //get first and last vacation days
                    auxMonthS = feriasItem.InicioFerias.Month;
                    auxMonthE = feriasItem.fimFerias.Month;
                    //calculates the number of days
                    int NumberOfDaysFerias = Math.Abs((feriasItem.InicioFerias - feriasItem.fimFerias).Days);
                    //calculates number of months
                    int NumberOfMonths = (auxMonthE - auxMonthS) + 1;

                    //inicialize dateitems for calendar
                    //DateItem[] d = new DateItem[NumberOfDaysFerias];
                    //d.Initialize();
                    //for (int j = 0; j < NumberOfDaysFerias; j++)
                    //    d[j] = new DateItem();
                    int auxCounter = 0;


                    List<DateItem> ListD = new List<DateItem>();

                    //repeat if more then 1 month
                    for (int m = 1; m <= NumberOfMonths; m++)
                    {

                        Control CalendarControl = new Control();
                        if (auxMonthS != 0)
                        {
                            if (auxMonthS > 0 && auxMonthS < 5)
                            {
                                CalendarControl = HelperClass.FindTag(row1.Controls, $"month{auxMonthS}");
                            }
                            else if (auxMonthS > 4 && auxMonthS < 9)
                            {
                                CalendarControl = HelperClass.FindTag(row2.Controls, $"month{auxMonthS}");
                            }
                            else
                            {
                                CalendarControl = HelperClass.FindTag(row3.Controls, $"month{auxMonthS}");
                            }
                        }

                        MonthCalendar CalendarToAdd = (MonthCalendar)CalendarControl ?? throw new Exception("Algo deu ruim no calendario");


                        //cast dates to dateitems
                        for (int i = auxCounter; i <= NumberOfDaysFerias; i++)
                        {
                            //compare current months
                            currentDate = feriasItem.InicioFerias.AddDays(i);


                            //make sure same month
                            if (auxMonthS == currentDate.Month)
                            {

                                DateItem d = new DateItem();
                                //add date to dateitem
                                d.Date = currentDate;
                                FileStream fs = new System.IO.FileStream(@"Imagens\sunny.png", FileMode.Open, FileAccess.Read);
                                Image img = Image.FromStream(fs);
                                Bitmap objBitmap = new Bitmap(img, new Size(10, 10));
                                ImageList list = new ImageList();



                                d.Image = objBitmap;

                                fs.Close();
                                d.BackColor1 = Color.Red;
                                ListD.Add(d);


                            }
                            else
                            {

                                auxMonthS += 1;
                                break;
                            }

                            auxCounter++;
                        }
                        DateItem[] e = new DateItem[ListD.Count()];
                        e.Initialize();
                        for (int i = 0; i < ListD.Count(); i++)
                            e[i] = ListD[i];
                        CalendarToAdd.AddDateInfo(e);


                    }
                }


            
            

            


            
        }











        #endregion

    }
}
