public class TelaWindows : TelaMensagem
{
    public override IBotao CriarBotao()
    {
        return new BotaoWindows();
    }
}