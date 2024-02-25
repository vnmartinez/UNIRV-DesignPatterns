public abstract class TelaMensagem
{
    public abstract IBotao CriarBotao();

    public void Mostrar()
    {
        var botao = CriarBotao();
        Console.WriteLine(botao.Mostrar());
    }
}