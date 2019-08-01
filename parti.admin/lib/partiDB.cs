﻿using System;
using System.Collections.Generic;

namespace parti.admin.lib
{
    public class partiDB
    {
        public class GetAuthen
        {
            public int tid { get; set; }
            public int id { get; set; }
            public string username { get; set; }
            public string passwd { get; set; }
            public string rules { get; set; }
            public string user_avatar { get; set; }
            public string fullname { get; set; }
            public string position { get; set; }
        }

        public class SumYearlyCourse
        {
            public string course;
            public int total;
        }

        public class GetUsers
        {
            public int id { get; set; }
            public string username { get; set; }
            public string passwd { get; set; }
            public string rules { get; set; }
        }

        public class GetCourse
        {
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }

        public class GetTrainerList
        {
            public string id { get; set; }
            public string name { get; set; }
            public string faminame { get; set; }
            public DateTime date_of_birth { get; set; }
            public string sex { get; set; }
            public string work_place { get; set; }
            public string position { get; set; }
            public string picture_url { get; set; }
            public string userame { get; set; }
            public string lv1 { get; set; }
            public string lv2 { get; set; }
            public string lv3 { get; set; }
            public string lv4 { get; set; }
            public string lv5 { get; set; }
        }

        public class GetUserProfile
        {
            public int id { get; set; } //user id
            public string name { get; set; } //trainer id
            public string faminame { get; set; }
            public DateTime date_of_birth { get; set; }
            public string sex { get; set; }
            public string work_place { get; set; }
            public string position { get; set; }
            public string picture_url { get; set; }
            public string userame { get; set; }
            public string lv1 { get; set; }
            public string lv2 { get; set; }
            public string lv3 { get; set; }
            public string lv4 { get; set; }
            public string lv5 { get; set; }
        }

        public class GetTraineeList
        {
            public string id { get; set; }
            public string name { get; set; }
            public string faminame { get; set; }
            public DateTime date_of_birth { get; set; }
            public string sex { get; set; }
            public string work_place { get; set; }
            public string position { get; set; }
            public DateTime date_of_modified_data { get; set; }
            public string doc_url { get; set; }
        }

        public class GetTrainingList
        {
            public string id { get; set; }
            public string title { get; set; }
            public int course_id { get; set; }
            public string course_name { get; set; }
            public string int_or_ext { get; set; }
            public string training_address { get; set; }
            public string training_district { get; set; }
            public string training_province { get; set; }
            public int training_days { get; set; }
            public DateTime training_date { get; set; }
            public string description { get; set; }
            public DateTime date_of_modified_date { get; set; }
        }

        public class GetTraineeByTraining
        {
            public string training_id { get; set; }
            public string trainee_id { get; set; }
            public string fullname { get; set; }
            public string work_place { get; set; }
        }

        public class GetTrainerByTraining
        {
            public string training_id { get; set; }
            public string trainer_id { get; set; }
            public string fullname { get; set; }
            public string work_place { get; set; }
        }

        public class GetYearPlan
        {
            public int id { get; set; }
            public string year_plan { get; set; }
            public string course_id { get; set; }
            public int target { get; set; }
        }

        public class GetCompareYearPlan
        {
            public string PlanType { get; set; }
            public string CourseID { get; set; }
            public string CourseName { get; set; }
            public string Targets { get; set; }
            public string DoneTarget { get; set; }
        }

        public class GetTrainingIDName
        {
            public string id { get; set; }
            public string title { get; set; }
        }

        public class GetDistrict
        {
            public string d_id { get; set; }
            public string d_name { get; set; }
            public string p_id { get; set; }
        }

        public class GetProvince
        {
            public string p_id { get; set; }
            public string p_name { get; set; }
        }

        public class RootObject
        {
            public List<GetDistrict> GetDistrict { get; set; }
            public List<GetProvince> GetProvince { get; set; }
            public List<GetCompareYearPlan> GetCompareYearPlan { get; set; }
            public List<GetAuthen> GetAuthen { get; set; }
            public List<SumYearlyCourse> SumYearlyCourse { get; set; }
            public List<GetUsers> GetUsers { get; set; }
            public List<GetCourse> GetCourse { get; set; }
            public List<GetTrainerList> GetTrainerList { get; set; }
            public List<GetUserProfile> GetUserProfile { get; set; }
            public List<GetTraineeList> GetTraineeList { get; set; }
            public List<GetTrainingList> GetTrainingList { get; set; }
            public List<GetTraineeByTraining> GetTraineeByTraining { get; set; }
            public List<GetTrainerByTraining> GetTrainerByTraining { get; set; }
            public List<GetYearPlan> GetYearPlans { get; set; }
            public List<GetTrainingIDName> GetTrainingIDName { get; set; }
        }
    }
}