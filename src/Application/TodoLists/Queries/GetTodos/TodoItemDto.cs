﻿using AutoMapper;
using BackToWorkBot.Application.Common.Mappings;
using BackToWorkBot.Domain.Entities;

namespace BackToWorkBot.Application.TodoLists.Queries.GetTodos
{
    public class TodoItemDto : IMapFrom<TodoItem>
    {
        public long Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public bool Done { get; set; }

        public int Priority { get; set; }

        public string Note { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TodoItem, TodoItemDto>()
                .ForMember(d => d.Priority, opt => opt.MapFrom(s => (int)s.Priority));
        }
    }
}
