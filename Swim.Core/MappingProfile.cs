using AutoMapper;
using MediaBrowser.Model.Dto;
using Swim.Core.DTOs;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swim.Core
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<LessonDto, Lesson>().ReverseMap();
            CreateMap<PresenceDto, Presence>().ReverseMap();
            CreateMap<StudentDto, Student>().ReverseMap();
            CreateMap<TeacherDto, Teacher>().ReverseMap();
        }
    }
}
