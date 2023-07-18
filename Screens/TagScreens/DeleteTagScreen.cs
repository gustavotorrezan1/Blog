using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluindo uma tag");
            Console.WriteLine("-------------");
            Console.WriteLine("Qual o id da Tag que deseja excluir? ");
            var id = Console.ReadLine();
            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag foi excluida com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a tag");
            }
        }
    }
}
