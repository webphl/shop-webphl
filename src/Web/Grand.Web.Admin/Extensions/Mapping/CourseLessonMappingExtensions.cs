﻿using Grand.Infrastructure.Mapper;
using Grand.Domain.Courses;
using Grand.Web.Admin.Models.Courses;

namespace Grand.Web.Admin.Extensions
{
    public static class CourseLessonMappingExtensions
    {
        public static CourseLessonModel ToModel(this CourseLesson entity)
        {
            return entity.MapTo<CourseLesson, CourseLessonModel>();
        }

        public static CourseLesson ToEntity(this CourseLessonModel model)
        {
            return model.MapTo<CourseLessonModel, CourseLesson>();
        }

        public static CourseLesson ToEntity(this CourseLessonModel model, CourseLesson destination)
        {
            return model.MapTo(destination);
        }
    }
}