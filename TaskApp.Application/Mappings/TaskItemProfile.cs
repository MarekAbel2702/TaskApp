using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.DTOs;
using TaskApp.Domain.Entities;

namespace TaskApp.Application.Mappings
{
    public class TaskItemProfile : Profile
    {
        public TaskItemProfile() 
        {
            CreateMap<TaskItem, TaskItemDto>();
            CreateMap<CreateTaskItemDto, TaskItem>();
        }
    }
}
