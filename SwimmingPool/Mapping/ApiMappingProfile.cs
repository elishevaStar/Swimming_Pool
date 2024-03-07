using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Swim.API.Models;
using Swim.Core.Entities;

namespace Swim.API.Mapping
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<LessonPostModel, Lesson>();
            CreateMap<PresencePostModel, Presence>();
            CreateMap<StudentPostModel, Student>();
            CreateMap<TeacherPostModel, Teacher>();
        }

    }
}
