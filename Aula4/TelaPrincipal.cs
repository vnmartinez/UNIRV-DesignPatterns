using System.Diagnostics;

public class TelaPrincipal
{
    public TelaPrincipal(int app)
    {
        TelaMensagem telaMensagem;
        if(app == 0)
            telaMensagem = new TelaWindows();
        else
           telaMensagem = new TelaWeb(); 

        telaMensagem.Mostrar();
    }
}