public class TelaConsole : TelaMensagem
{
    public override IBotao CriarBotao()
    {
        return new BotaoWindows();
    }
}