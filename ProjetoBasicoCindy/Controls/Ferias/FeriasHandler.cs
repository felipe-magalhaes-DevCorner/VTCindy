using System;
using System.Collections.Generic;
using System.Drawing;
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
        #endregion

        #region Contructor
        public FeriasHandler(FlowLayoutPanel _panelToShow)
        {
            showPanel = _panelToShow;
            BuildCalendar();
        }
        #endregion

        #region Methods

        private void BuildCalendar()
        {
            int height = 0;
            showPanel.FlowDirection = FlowDirection.TopDown;
            int math = 1;
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
                    //add date value to calendar
                    //shows calendar month as well
                    Calendar.ActiveMonth.Month = math;
                    
                    height = Calendar.Height;
                    RowMonthPanel.Controls.Add(Calendar);
                    math++;
                }
                
                RowMonthPanel.BackColor = Color.Red;

                RowMonthPanel.Size = new Size(showPanel.Width, height + 3);
                showPanel.Controls.Add(RowMonthPanel);

            }

        }







        #endregion

    }
}
