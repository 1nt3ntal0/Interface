public class MiTiempo
{
    private System.Windows.Forms.Timer timer;

    // Delegado para el evento IntervaloTranscurrido
    public delegate void IntervaloTranscurridoHandler(object sender, EventArgs e);
    public event IntervaloTranscurridoHandler IntervaloTranscurrido;

    // Delegado para el evento InicioTiempo
    public delegate void InicioTiempoHandler(object sender, EventArgs e);
    public event InicioTiempoHandler InicioTiempo;

    public MiTiempo(int intervaloEnMilisegundos = 5000)
    {
        timer = new System.Windows.Forms.Timer();
        timer.Interval = intervaloEnMilisegundos;
        timer.Tick += Timer_Tick;

        // Avisar a Actualizacion al iniciar el tiempo
        OnInicioTiempo(EventArgs.Empty);

        timer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        // Avisar a Actualizacion en cada intervalo transcurrido
        OnIntervaloTranscurrido(EventArgs.Empty);
    }

    protected virtual void OnIntervaloTranscurrido(EventArgs e)
    {
        IntervaloTranscurrido?.Invoke(this, e);
    }

    protected virtual void OnInicioTiempo(EventArgs e)
    {
        InicioTiempo?.Invoke(this, e);
    }

    public void Detener()
    {
        timer.Stop();
    }

    public void Reiniciar()
    {
        timer.Stop();
        timer.Start();
    }
}