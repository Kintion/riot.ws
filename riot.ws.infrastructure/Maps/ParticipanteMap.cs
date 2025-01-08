using AutoMapper;
using riot.ws.domain.Models;
using riot.ws.infrastructure.dto;


namespace riot.ws.infrastructure.Maps
{
    public class ParticipanteMap : Profile
    {
        public ParticipanteMap() {

            CreateMap<Participant, Participante>()
                //.ForMember(dest => dest.Puuid, opt => opt.MapFrom(src => src.Puuid))
                //.ForMember(dest => dest.Teamid, opt => opt.MapFrom(src => src.TeamId))
                //.ForMember(dest => dest.Championid, opt => opt.MapFrom(src => src.ChampionId))
                //.ForMember(dest => dest.Item0, opt => opt.MapFrom(src => src.Item0))
                //.ForMember(dest => dest.Item1, opt => opt.MapFrom(src => src.Item1))
                //.ForMember(dest => dest.Item2, opt => opt.MapFrom(src => src.Item2))
                //.ForMember(dest => dest.Item3, opt => opt.MapFrom(src => src.Item3))
                //.ForMember(dest => dest.Item4, opt => opt.MapFrom(src => src.Item4))
                //.ForMember(dest => dest.Item5, opt => opt.MapFrom(src => src.Item5))
                //.ForMember(dest => dest.Item6, opt => opt.MapFrom(src => src.Item6))
                //.ForMember(dest => dest.Summoner1Id, opt => opt.MapFrom(src => src.Summoner1Id))
                //.ForMember(dest => dest.Summoner2Id, opt => opt.MapFrom(src => src.Summoner2Id))
                //.ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
                //.ForMember(dest => dest.TotalDamageDealt, opt => opt.MapFrom(src => src.TotalDamageDealt))
                //.ForMember(dest => dest.Win, opt => opt.MapFrom(src => src.Win))
                //.ForMember(dest => dest.Summoner, opt => opt.MapFrom(src => new SummonerAccount{ 
                //    Gamename= src.RiotIdGameName,
                //    Profileiconid = (int)src.ProfileIcon,
                //    //Puuid= src.Puuid,
                //    Summonerid= src.SummonerId,
                //    Summonerlevel= (int)src.SummonerLevel,
                //    Tagline= src.RiotIdTagline,
                //    Id= src.SummonerId
                //}))
                .ReverseMap()
                ;

            CreateMap<ParticipanteWithMatchId, Participante>()
                .ForMember(dest => dest.Puuid, opt => opt.MapFrom(src => src.participant.Puuid))
                .ForMember(dest => dest.Teamid, opt => opt.MapFrom(src => src.participant.TeamId))
                .ForMember(dest => dest.Championid, opt => opt.MapFrom(src => src.participant.ChampionId))
                .ForMember(dest => dest.Item0, opt => opt.MapFrom(src => src.participant.Item0))
                .ForMember(dest => dest.Item1, opt => opt.MapFrom(src => src.participant.Item1))
                .ForMember(dest => dest.Item2, opt => opt.MapFrom(src => src.participant.Item2))
                .ForMember(dest => dest.Item3, opt => opt.MapFrom(src => src.participant.Item3))
                .ForMember(dest => dest.Item4, opt => opt.MapFrom(src => src.participant.Item4))
                .ForMember(dest => dest.Item5, opt => opt.MapFrom(src => src.participant.Item5))
                .ForMember(dest => dest.Item6, opt => opt.MapFrom(src => src.participant.Item6))
                .ForMember(dest => dest.Summoner1Id, opt => opt.MapFrom(src => src.participant.Summoner1Id))
                .ForMember(dest => dest.Summoner2Id, opt => opt.MapFrom(src => src.participant.Summoner2Id))
                .ForMember(dest => dest.TeamPosition, opt => opt.MapFrom(src => src.participant.TeamPosition))
                .ForMember(dest => dest.TotalDamageDealt, opt => opt.MapFrom(src => src.participant.TotalDamageDealt))
                .ForMember(dest => dest.Win, opt => opt.MapFrom(src => src.participant.Win))
                .ForMember(dest => dest.Matchid, opt => opt.MapFrom(src => src.MatchId))
                //.ForMember(dest => dest.Summoner, opt => opt.MapFrom(src => new 
                //{
                //    Gamename = src.participant.RiotIdGameName,
                //    Profileiconid = (int)src.participant.ProfileIcon,
                //    Puuid = src.participant.Puuid,
                //    Summonerid = src.participant.SummonerId,
                //    Summonerlevel = (int)src.participant.SummonerLevel,
                //    Tagline = src.participant.RiotIdTagline,
                //    Id = src.participant.SummonerId
                //}))
                .ReverseMap()
                ;

            CreateMap<Participant, SummonerAccount>()
                .ForMember(dest => dest.Gamename, opt => opt.MapFrom(src => src.RiotIdGameName))
                .ForMember(dest => dest.Profileiconid, opt => opt.MapFrom(src => src.ProfileIcon))
                .ForMember(dest => dest.Puuid, opt => opt.MapFrom(src => src.Puuid))
                .ForMember(dest => dest.Summonerid, opt => opt.MapFrom(src => src.SummonerId))
                .ForMember(dest => dest.Summonerlevel, opt => opt.MapFrom(src => src.SummonerLevel))
                .ForMember(dest => dest.Tagline, opt => opt.MapFrom(src => src.RiotIdTagline))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => "A" + src.Puuid))
                ;

            CreateMap<Participante, ParticipanteDto>().ReverseMap();
        }

    }
}
