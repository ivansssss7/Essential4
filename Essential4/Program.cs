namespace Essential4;

//Створити клас AbstractHandler.У тілі класу створити методи void Open(), 
//void Create(), void Change(), void Save(). 
//Створити похідні класи XMLHandler, TXTHandler, 
//DOCHandler від базового класу AbstractHandler.
//Написати програму, яка виконуватиме визначення документа і для
//кожного формату мають бути методи відкриття, створення, редагування, 
//збереження певного формату документа.

class Program
{
    static void Main()
    {
        AbstractHandler handler = new XMLHandler();
        handler.Open();
        handler.Create();
        handler.Change();
        handler.Save();

        handler = new TXTHandler();
        handler.Open();
        handler.Create();
        handler.Change();
        handler.Save();

        handler = new DOCHandler();
        handler.Open();
        handler.Create();
        handler.Change();
        handler.Save();
    }
}