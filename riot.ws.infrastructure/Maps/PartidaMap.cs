

using AutoMapper;
using riot.ws.domain.Models;
using riot.ws.infrastructure.dto;

namespace riot.ws.infrastructure.Maps
{
    public class PartidaMap : Profile
    {
        public PartidaMap() {
            CreateMap<MatchDto, Partida>()
                .ForMember(dest => dest.Matchid, opt => opt.MapFrom(src => src.Metadata.MatchId))
                .ForMember(dest => dest.Queueid, opt => opt.MapFrom(src => src.Info.QueueId))
                .ForMember(dest => dest.Teamidwin, opt => opt.MapFrom(src => src.Info.Teams.Where(y => y.Win).First().TeamId))
                .ForMember(dest => dest.Duracion, opt => opt.MapFrom(src => src.Info.GameDuration))
                .ForMember(dest => dest.Fechafinalizacion, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeMilliseconds(src.Info.GameEndTimestamp).DateTime))
                .ForMember(dest => dest.Gameversion, opt => opt.MapFrom(src => src.Info.GameVersion))
                .ForMember(dest => dest.Platformid, opt => opt.MapFrom(src => src.Info.PlatformId))
                .ForMember(dest => dest.Participantes, opt => opt.MapFrom(src => src.Info.Participants))
                ;

            CreateMap<Partida, MatchResponse>()
                 .ForMember(dest => dest.Matchid, opt => opt.MapFrom(src => src.Matchid))
                .ForMember(dest => dest.Queueid, opt => opt.MapFrom(src => src.Queueid))
                .ForMember(dest => dest.Teamidwin, opt => opt.MapFrom(src => src.Teamidwin))
                .ForMember(dest => dest.Duracion, opt => opt.MapFrom(src => src.Duracion))
                .ForMember(dest => dest.Fechafinalizacion, opt => opt.MapFrom(src => src.Fechafinalizacion))
                .ForMember(dest => dest.Gameversion, opt => opt.MapFrom(src => src.Gameversion))
                .ForMember(dest => dest.Platformid, opt => opt.MapFrom(src => src.Platformid))
                .ForMember(dest => dest.Participantes, opt => opt.MapFrom(src => src.Participantes))
                .ReverseMap()

                ;

        }
    }
}
