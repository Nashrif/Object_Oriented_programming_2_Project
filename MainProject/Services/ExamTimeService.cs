using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using System.Data;

namespace Services
{
    public class ExamTimeService
    {
        ExamTimeAccess examTimeAccess = new ExamTimeAccess();

        List<ExamInfo> examInfos = new List<ExamInfo>();

        public DataTable GetAllCourse()
        {
            return examTimeAccess.GetAllCourse();
        }

        public DataTable InsertExamTime(ExamInfo examInfo)
        {
            return examTimeAccess.InsertExamTimeAccess(examInfo.CourseName,examInfo.ExamTime);
        }


        //public List<ExamInfo> GetAllCourse()
        //{
        //    examInfos.Clear();
        //    var dt = examTimeAccess.GetAllCourse();

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        ExamInfo e = ConverToEntity(dt.Rows[i]);
        //        examInfos.Add(e);
        //    }
        //    return examInfos;
        //}

        //public ExamInfo ConverToEntity(DataRow dr)
        //{
        //    ExamInfo e = new ExamInfo();
        //    e.CourseName = dr["CourseName"].ToString();
        //    e.ExamTime = dr["ExamTime"].ToString();
        //    return e;
        //}
    }
}
