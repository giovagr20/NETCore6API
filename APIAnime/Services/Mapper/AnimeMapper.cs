using System;
using APIAnime.Model;
using APIAnime.Services.DTO;
using APIAnime.Utils;

namespace APIAnime.Services.Mapper
{
    public class AnimeMapper : IMapperGeneral<AnimeDTO, AnimeModel>
    {
        private readonly ILogger<AnimeMapper> _logger;

        public async Task<AnimeModel> DtoToModel(AnimeDTO dto)
        {
            try
            {

                if (dto == null)
                {
                    _logger.LogInformation("No hay datos informados");
                    return new AnimeModel();
                }

                AnimeModel animeModel = new AnimeModel
                {
                    AnimeName = dto.AnimeName,
                    TotalSeasons = dto.TotalSeasons,
                    Description = dto.Description,
                    PictureUrl = dto.PictureUrl,
                    HasSeasons = dto.HasSeasons
                };

                return animeModel;

            } catch (Exception e) {
                _logger.LogError(e.Message);
                return new AnimeModel();
            }
        }


        public async Task<AnimeDTO> ModelToDto(AnimeModel model)
        {
            try {
                if (model == null)
                {
                    _logger.LogInformation("No hay datos retornados");
                    return new AnimeDTO();
                }

                AnimeDTO animeDTO = new AnimeDTO
                {

                    AnimeName = model.AnimeName,
                    Description = model.Description,
                    PictureUrl = model.PictureUrl,
                    TotalSeasons = model.TotalSeasons,
                    HasSeasons = model.HasSeasons

                };

                return animeDTO;

            } catch (Exception e) {
                _logger.LogError(e.Message);
                return new AnimeDTO();
            }
        }

        public async Task<IEnumerable<AnimeModel>> listDtoToListModel(IEnumerable<AnimeDTO> dtos)
        {

            IList<AnimeModel> animeModels = new List<AnimeModel>();
            if (dtos == null)
            {
                return Enumerable.Empty<AnimeModel>();
            }

            foreach (var anime in dtos)
            {
                AnimeModel animeModel =  await DtoToModel(anime);
                animeModels.Add(animeModel);
            }

            if (!animeModels.Any())
            {
                return Enumerable.Empty<AnimeModel>();
            }

            return animeModels.AsEnumerable();
        }

        public async Task<IEnumerable<AnimeDTO>> listModelToListDto(IEnumerable<AnimeModel> models)
        {
            IList<AnimeDTO> animeDTOs = new List<AnimeDTO>();

            if (models == null)
            {
                return Enumerable.Empty<AnimeDTO>();
            }

            foreach (var anime in models)
            {
                AnimeDTO animeDto = await ModelToDto(anime);
                animeDTOs.Add(animeDto);
            }

            if (!animeDTOs.Any())
            {
                return Enumerable.Empty<AnimeDTO>();

            }

            return animeDTOs.AsEnumerable();

        }

    }
}

