

using AutoMapper;
using riot.ws.domain.Models;
using riot.ws.infrastructure.dto;

namespace riot.ws.infrastructure.Maps
{
    public class RankMap : Profile
    {
        public RankMap() {
            CreateMap<RankDto, RankEntity>().ReverseMap();
        }
    }
}
