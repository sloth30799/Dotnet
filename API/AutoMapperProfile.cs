using AutoMapper;
using MODEL.DTOs.TaskDTOs;
using MODEL.Entities;

namespace API
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateNoteDTO, Note>();
        }
    }
}
