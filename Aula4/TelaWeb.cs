public class TelaWeb : TelaMensagem
{
    public override IBotao CriarBotao()
    {
        return new BotaoWeb();
    }
}