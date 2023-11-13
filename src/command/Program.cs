using command;
using command.Abstractions;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();

            ICommand openCommand = new OpenCommand(document);
            ICommand saveCommand = new SaveCommand(document);
            ICommand closeCommand = new CloseCommand(document);

            MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
            
            menu.ClickOpen();
            menu.ClickSave();
            menu.ClickClose();
            
            Console.ReadKey();
        }
    }
}