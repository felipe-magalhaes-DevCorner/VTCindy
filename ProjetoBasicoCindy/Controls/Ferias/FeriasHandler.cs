using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Pabo.Calendar;
using MonthCalendar = Pabo.Calendar.MonthCalendar;

namespace ProjetoBasicoCindy.Ferias
{
    public class FeriasHandler
    {
        #region Variables

        private FlowLayoutPanel ShowPanel { get; set; }
        private FeriasColletionItem Ferias { get; set; }

        #endregion

        #region Contructor
        public FeriasHandler(FlowLayoutPanel panelToShow)
        {

            ShowPanel = panelToShow;
            
            BuildCalendar(DateTime.Now.Year);
            //FeriasColletionItem funcionariodata = new FeriasColletionItem();
            var objFunc = new FuncionarioItemEdit();
            LoadFuncFerias(objFunc.GetFuncionarioEdit().Ferias);




        }
        #endregion

        #region Build Calendars

        private void BuildCalendar(int year)
        {
            //variables
            int height = 0;
            ShowPanel.FlowDirection = FlowDirection.TopDown;
            int math = 1;
            //pannel for year select
            Panel yearSelect = new Panel();
            yearSelect.AutoSize = false;
            

            //labeo year
            Label lbYear = new Label();
            lbYear.AutoSize = true;
            //button left
            Button btLeftYear = new Button();
            btLeftYear.Size = new Size(16, 16);
            //read image for button
            var fs = new FileStream(@"Imagens\leftarrow.png", FileMode.Open, FileAccess.Read);
            var img = Image.FromStream(fs);
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
            FileStream fs2 = new FileStream(@"Imagens\rightarrow.png", FileMode.Open, FileAccess.Read);
            Image img2 = Image.FromStream(fs2);
            
            btRightArrow.Image = img2;
            var auxmargin = lbYear.Margin;
            auxmargin.All = 0;
            btLeftYear.Margin = auxmargin;
            //deal with space
            var margin = lbYear.Margin;
            

            
            btLeftYear.Padding = new Padding(0);
            lbYear.Text = year.ToString();
            lbYear.Font =  new Font("Times New Roman", 10.0f, FontStyle.Bold);
            lbYear.ForeColor = Color.Black;
            
            
            yearSelect.Margin = auxmargin;
            yearSelect.Padding = new Padding(0);
            yearSelect.BackColor = ColorTranslator.FromHtml("#CF6766");


            yearSelect.Controls.Add(btLeftYear);
            
            yearSelect.Controls.Add(lbYear);
            
            yearSelect.Controls.Add(btRightArrow);
            yearSelect.Controls.SetChildIndex(btLeftYear, 2);
            
            yearSelect.Controls.SetChildIndex(lbYear,1);
            //YearSelect.Controls.SetChildIndex(btRightArrow, 2);





            ShowPanel.Controls.Add(yearSelect);
            //divide months into panels for stacking horizontally and vertically 
            //4 panels with 3 calendars or 3 with 4 dunno yet
            for (int c = 1; c <= 3; c++)
            {
                //panel colum
                FlowLayoutPanel rowMonthPanel = new FlowLayoutPanel();
                
                rowMonthPanel.FlowDirection = FlowDirection.LeftToRight;
                rowMonthPanel.Tag = $"Row{c + 1}";
                //add 4 months to row panel

                for (int i = 1; i <= 4; i++)
                {

                    MonthCalendar calendar = new MonthCalendar();
                   
                    calendar.Tag = $"month{math}";
                    calendar.Name = math.ToString();
                    //add date value to calendar
                    //shows calendar month as well
                    //sets all settings of calendars
                    calendar.ActiveMonth.Year = year;
                    calendar.ActiveMonth.Month = math;
                    calendar.Header.ShowMonth = false;
                    calendar.Header.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(math);
                    calendar.Footer.ShowToday = false;
                    calendar.Header.MonthSelectors = false;
                    calendar.Header.BackColor1 = ColorTranslator.FromHtml("#CF6766");
                    calendar.Weekdays.TextColor = ColorTranslator.FromHtml("#0E1116"); 
                    calendar.KeyboardEnabled = false;


                    calendar.Weekdays.Font = new Font("Arial", 7);
                    DateItem[] d = new DateItem[5];
                    d.Initialize();
                    for (int k   = 0; k < 5; k++)
                        d[k] = new DateItem();
                    height = calendar.Height;
                    rowMonthPanel.Controls.Add(calendar);
                    math++;
                }

                //RowMonthPanel.BackColor = ColorTranslator.FromHtml("#D8DBE2");
                
                
                yearSelect.Dock = DockStyle.Top;
                rowMonthPanel.Size = new Size(ShowPanel.Width, height + 3);
                //year top panel settings
                yearSelect.MaximumSize = new Size(rowMonthPanel.Width -45, 16);

                btLeftYear.Dock = DockStyle.Left;
                //last part of dealing with label position
                lbYear.Dock = DockStyle.Fill;
                lbYear.AutoSize = false;
                lbYear.TextAlign = ContentAlignment.MiddleCenter;
                btRightArrow.Dock = DockStyle.Right;
                //btRightArrow.Click += new EventHandler(this.YearChange);
                //btLeftYear.Click += new EventHandler(this.YearChange);
                



                ShowPanel.BackColor = ColorTranslator.FromHtml("#D8DBE2");
                ShowPanel.Controls.Add(rowMonthPanel);

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
                    ShowPanel.Controls.Clear();
                    HelperClass.ChangeYear(changeyear);
                    BuildCalendar(HelperClass.YearShown);
                    
                    var objFunc = new FuncionarioItemEdit();
                    LoadFuncFerias(objFunc.GetFuncionarioEdit().Ferias);
        }






        #endregion


        #region Handlers for funcionario

        private void LoadFuncFerias(FeriasColletionItem feriasCol)
        {
            int auxMonthS = 0;
            int auxMonthE = 0;
            Control tagFound = new Control();

                Control row1 = ShowPanel.Controls[1];
                Control row2 = ShowPanel.Controls[2];
                Control row3 = ShowPanel.Controls[3];
                foreach (FeriasItem feriasItem in feriasCol.ListaFerias)
                {


                    //auxiliary variables

                    DateTime currentDate = new DateTime();
                    //get first and last vacation days
                    auxMonthS = feriasItem.InicioFerias.Month;
                    auxMonthE = feriasItem.FimFerias.Month;
                    //calculates the number of days
                    int numberOfDaysFerias = Math.Abs((feriasItem.InicioFerias - feriasItem.FimFerias).Days);
                    //calculates number of months
                    int numberOfMonths = auxMonthE - auxMonthS + 1;

                    //inicialize dateitems for calendar
                    //DateItem[] d = new DateItem[NumberOfDaysFerias];
                    //d.Initialize();
                    //for (int j = 0; j < NumberOfDaysFerias; j++)
                    //    d[j] = new DateItem();
                    int auxCounter = 0;


                    List<DateItem> listD = new List<DateItem>();

                    //repeat if more then 1 month
                    for (int m = 1; m <= numberOfMonths; m++)
                    {

                        Control calendarControl = new Control();
                        if (auxMonthS != 0)
                        {
                            if (auxMonthS > 0 && auxMonthS < 5)
                            {
                                calendarControl = HelperClass.FindTag(row1.Controls, $"month{auxMonthS}");
                            }
                            else if (auxMonthS > 4 && auxMonthS < 9)
                            {
                                calendarControl = HelperClass.FindTag(row2.Controls, $"month{auxMonthS}");
                            }
                            else
                            {
                                calendarControl = HelperClass.FindTag(row3.Controls, $"month{auxMonthS}");
                            }
                        }

                        MonthCalendar calendarToAdd = (MonthCalendar)calendarControl ?? throw new Exception("Algo deu ruim no calendario");


                        //cast dates to dateitems
                        for (int i = auxCounter; i <= numberOfDaysFerias; i++)
                        {
                            //compare current months
                            currentDate = feriasItem.InicioFerias.AddDays(i);


                            //make sure same month
                            if (auxMonthS == currentDate.Month)
                            {

                                DateItem d = new DateItem();
                                //add date to dateitem
                                d.Date = currentDate;
                                FileStream fs = new FileStream(@"Imagens\sunny.png", FileMode.Open, FileAccess.Read);
                                Image img = Image.FromStream(fs);
                                Bitmap objBitmap = new Bitmap(img, new Size(10, 10));
                                ImageList list = new ImageList();



                                d.Image = objBitmap;

                                fs.Close();
                                d.BackColor1 = Color.Red;
                                listD.Add(d);


                            }
                            else
                            {

                                auxMonthS += 1;
                                break;
                            }

                            auxCounter++;
                        }
                        DateItem[] e = new DateItem[listD.Count()];
                        e.Initialize();
                        for (int i = 0; i < listD.Count(); i++)
                            e[i] = listD[i];
                        calendarToAdd.AddDateInfo(e);


                    }
                }


            
            

            


            
        }











        #endregion

    }
}
