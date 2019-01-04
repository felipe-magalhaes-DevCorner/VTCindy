using System;
using System.Drawing;
using System.Linq;
using ProjetoBasicoCindy.Exames.Data;

namespace ProjetoBasicoCindy
{
    public class ExameCheckOk
    {
        private FuncionarioItem _func;

        public ExameCheckOk(FuncionarioItem func)
        {
            this._func = func;

        }
        public ExameCheckOk()
        {
            

        }
        public Image ReturnImageExamFunc(Examitem exam)
        {
            int monthsToExpire = 0; //VARIABLE TO GET EXAM MAX TIME BEFORE EXPIRES
            //checks expiration date
            switch (exam.Nome)
            {
                case "Hemograma Completo":
                    {
                        monthsToExpire = 12;
                        break;
                    }
                case "Anti-HBS":
                    {
                        monthsToExpire = 60;
                        break;
                    }
                case "ASO":
                    {
                        monthsToExpire = 12;
                        break;
                    }
                case "HCV":
                    {
                        monthsToExpire = 12;
                        break;
                    }
                case "Rubeola":
                    {
                        monthsToExpire = 12;
                        break;
                    }
                case "Metanol":
                    {
                        monthsToExpire = 6;
                        break;
                    }


                default:
                    break;
            }



            var lastdayExam = exam.DataExame.LastOrDefault();

            if (lastdayExam.AddMonths(monthsToExpire - 2) < DateTime.Now)
            {



                if (lastdayExam.AddMonths(monthsToExpire) < DateTime.Now)
                {
                    DashboardCounter.ExamesVencidos += 1;
                    return Image.FromFile(@"Imagens\cancel.png");
                }
                else
                {
                    DashboardCounter.AlertaExames += 1;
                    return Image.FromFile(@"Imagens\alert.png");
                }

                


            }
            else
            {
                return Image.FromFile(@"Imagens\Checked.png");
            }






            
        }
        public Image ReturnImageExamFunc()
        {
            //GETS FUNC HIRE DATE
            DateTime dataContratação = _func.Adimissao;

            //RUNS TRU LIST OF EXAM TYPES
            foreach (ExamList exameTipo in _func.Exames.Exames)
            {
                //RUN TRU LIST OF EXAMS
                foreach (Examitem exame in exameTipo.ExameColletion)
                {
                    //RUN TRUE EXAM DATES, AND GETS MAXIMUM TIME BETWEEN EXAMS AND CHECK AGAIN EXAM
                    int monthsToExpire = 0; //VARIABLE TO GET EXAM MAX TIME BEFORE EXPIRES
                    switch (exame.Nome)
                    {
                        case "Hemograma Completo":
                            {
                                monthsToExpire = 12;
                                break;
                            }
                        case "Anti-HBS":
                            {
                                monthsToExpire = 60;
                                break;
                            }
                        case "ASO":
                            {
                                monthsToExpire = 12;
                                break;
                            }
                        case "HCV":
                            {
                                monthsToExpire = 12;
                                break;
                            }
                        case "Rubeola":
                            {
                                monthsToExpire = 12;
                                break;
                            }
                        case "Metanol":
                            {
                                monthsToExpire = 6;
                                break;
                            }


                        default:
                            break;
                    }



                    var lastdayExam = exame.DataExame.LastOrDefault();

                    if (lastdayExam.AddMonths(monthsToExpire) > DateTime.Now)
                    {



                        if (lastdayExam.AddMonths(monthsToExpire - 2) > DateTime.Now)
                        {
                            DashboardCounter.AlertaVacinas += 1;
                        }
                        else
                        {
                            DashboardCounter.ExamesVencidos += 1;
                        }
                        
                        return Image.FromFile(@"Imagens\cancel.png");


                    }

                }
            }
            return null;
        }


    }
}
