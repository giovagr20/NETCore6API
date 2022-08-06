using System;
namespace APIAnime.Utils
{
    public interface IMapperGeneral<Dto, Model>
    {
        Task<Model> DtoToModel(Dto dto);

        Task<Dto> ModelToDto(Model model);

        Task<IEnumerable<Dto>> listModelToListDto(IEnumerable<Model> models);

        Task<IEnumerable<Model>> listDtoToListModel(IEnumerable<Dto> dtos);


    }
}

