using AutoMapper;

namespace App.Mappers
{
    public class MapperConfig<Entity, ViewModel>
    {
        public static Entity ConvertToEntity(ViewModel viewModel)
        {
            var config = new MapperConfiguration(c =>
            {
                c.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                c.CreateMap<ViewModel, Entity>();
            });

            var entity = config.CreateMapper().Map<ViewModel, Entity>(viewModel);

            return entity;
        }

        public static ViewModel ConvertToViewModel(Entity entity)
        {
            var config = new MapperConfiguration(c =>
            {
                c.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                c.CreateMap<Entity, ViewModel>();
            });

            var viewModel = config.CreateMapper().Map<Entity, ViewModel>(entity);

            return viewModel;
        }
    }
}
